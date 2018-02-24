using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using NJsonSchema;
using NJsonSchema.CodeGeneration.CSharp;

namespace Tas.CodeGeneration
{
    public class Generator
    {
        static void Main(string[] args)
        {
            foreach (var type in new[] { "tenant", "core" })
            {
                Main("tas-" + type + "-apis/docs/schemas/", Path.Combine("schemas", type), Path.Combine("pocos", type), Capitalize(type)).Wait();
            }
        }

        async static Task Main(string inDir, string schemaDir, string outDir, string package)
        {
            Directory.CreateDirectory(schemaDir);

            foreach (var file in Directory.GetFiles(inDir))
            {
                var fileName = Path.GetFileNameWithoutExtension(file);
                JObject schema = JObject.Parse(File.ReadAllText(file));
                var className = Capitalize(fileName);
                schema["title"] = className;

                if (schema["items"] != null)
                {
                    if (schema["items"]["$ref"] == null)
                    {
                        schema["items"]["title"] = Depluralize(className);
                    }
                    else if (schema["items"]["$ref"].Value<string>().StartsWith("#/definitions/"))
                    {
                        var definition = schema["items"]["$ref"].Value<string>().Substring("#/definitions/".Length);
                        schema["definitions"][definition]["title"] = Capitalize(definition);
                    }
                }

                ConvertInheritance(schema, "#", (JObject)schema["definitions"], className, inDir);

                File.WriteAllText(Path.Combine(schemaDir, fileName + ".json"), schema.ToString());
            }

            foreach (var f in Directory.GetFiles(outDir, "*.cs"))
            {
                File.Delete(f);
            }

            foreach (var file in Directory.GetFiles(schemaDir))
            {
                var schema = await JsonSchema4.FromFileAsync(file);
                var nameSpace = "Tas." + package + "." + schema.Title;
                if (schema.Type == JsonObjectType.Array)
                {
                    if (schema.Item == null)
                    {
                        continue;
                    }
                    else if (schema.Item.Reference == null && schema.Item.Type == JsonObjectType.Object)
                    {
                        schema = schema.Item;
                    }
                    else if (schema.Item.Reference == null || schema.Item.Reference.DocumentPath != null)
                    {
                        //Nonnull DocumentPath indicates direct reference to schema file (e.g "items":{"$ref":"abc.json"}).
                        continue;
                    }
                    else if (schema.Item.Reference.Type == JsonObjectType.Object)
                    {
                        schema = schema.Item.Reference;
                    }
                    else
                    {
                        continue;
                    }
                }
                var generator = new CSharpGenerator(schema, new CSharpGeneratorSettings()
                {
                    Namespace = nameSpace,
                    ClassStyle = CSharpClassStyle.Poco,
                    JsonConverters = new[] { "Newtonsoft.Json.Converters.StringEnumConverter" },
                    RequiredPropertiesMustBeDefined = false,
                    SchemaType = SchemaType.Swagger2
                });
                File.WriteAllText(Path.Combine(outDir, schema.Title + ".cs"), generator.GenerateFile());
            }
        }

        private static void ConvertInheritance(JObject schema, string path, JObject definitions, string className, string inDir)
        {
            if (schema["oneOf"] != null)
            {
                if (definitions == null)
                {
                    schema["definitions"] = definitions = new JObject();
                }
                var subSchemas = new List<JObject>();
                JObject migrateToSupertype = null;
                string discriminator = null;
                foreach (JObject it in schema["oneOf"])
                {
                    string reference = it["$ref"].Value<string>();
                    string subSchemaFileName = reference.Split("#/definitions/")[0];
                    string definition = reference.Split("#/definitions/")[1];
                    string subClass = definition.Length == 0 ? subSchemaFileName : definition;
                    JObject subSchema;
                    if (subSchemaFileName.Length == 0)
                    {
                        subSchema = definitions[definition].Value<JObject>();
                    }
                    else if (definition.Length == 0)
                    {
                        subSchema = JObject.Parse(File.ReadAllText(Path.Combine(inDir, subSchemaFileName)));
                    }
                    else
                    {
                        subSchema = JObject.Parse(File.ReadAllText(Path.Combine(inDir, subSchemaFileName)))["definitions"][definition].Value<JObject>();
                    }

                    if (discriminator == null)
                    {
                        discriminator = subSchema["properties"].Value<JObject>().Properties().FirstOrDefault(p => p.Value["enum"] is JArray && p.Value["enum"].Count() == 1)?.Name;
                        if (discriminator == null)
                        {
                            Console.WriteLine("No discriminator found for " + className);
                            return;
                        }
                    }

                    string subTypeName = subSchema["properties"][discriminator]["enum"][0].Value<string>();
                    subSchema["properties"].Value<JObject>().Remove(discriminator);
                    subSchema["allOf"] = new JArray() { new JObject() };
                    subSchema["allOf"][0]["$ref"] = new JValue(path);
                    if (subSchemaFileName.Length == 0)
                    {
                        definitions.Remove(definition);
                    }


                    JObject properties = subSchema["properties"].Value<JObject>();

                    string subSchemaJson = subSchema.ToString();
                    subSchemaJson = subSchemaJson.Replace("\"#", "\"" + subSchemaFileName + "#");
                    subSchema = JObject.Parse(subSchemaJson);

                    if (migrateToSupertype == null)
                    {
                        migrateToSupertype = properties;
                    }
                    else
                    {
                        var keys = migrateToSupertype.Properties().Select(p => p.Name).ToList();
                        foreach (var k in keys)
                        {
                            if (properties[k] == null || !JToken.DeepEquals(properties[k], migrateToSupertype[k]))
                            {
                                migrateToSupertype.Remove(k);
                            }
                        }
                    }
                    subSchemas.Add(subSchema);
                    definitions[subTypeName] = subSchema;
                }

                schema["discriminator"] = discriminator;
                schema["properties"] = new JObject();
                schema["properties"][discriminator] = new JObject();
                schema["properties"][discriminator]["type"] = "string";

                foreach (var p in migrateToSupertype.Properties())
                {
                    schema["properties"][p.Name] = p.Value;
                    foreach (var subSchema in subSchemas)
                    {
                        subSchema["properties"].Value<JObject>().Remove(p.Name);
                    }
                }
                schema.Remove("oneOf");
            }

            if (schema["definitions"] != null)
            {
                foreach (var p in schema["definitions"].Value<JObject>().Properties().ToList())
                {
                    ConvertInheritance(p.Value.Value<JObject>(), path + "/definitions/" + p.Name, definitions, Capitalize(p.Name), inDir);
                }
            }

            if (schema["items"] != null)
            {
                schema["items"]["title"] = Depluralize(className);
                ConvertInheritance(schema["items"].Value<JObject>(), path + "/items", definitions, Depluralize(className), inDir);
            }
        }

        public static string Depluralize(string name)
        {
            return name.EndsWith('s') ? name.Substring(0, name.Length - 1) : name;
        }

        public static string Capitalize(string name)
        {
            return String.Join("", name.Split('-').Select(word => char.ToUpper(word[0]) + word.Substring(1)));
        }
    }
}
