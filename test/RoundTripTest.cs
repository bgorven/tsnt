using System;
using Xunit;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Linq;
using Tas;
using Tas.CodeGeneration;
using Newtonsoft.Json.Converters;
using System.Collections;

namespace test
{
    public class RoundTripTest
    {
        [Fact]
        public void Tenant_json_validates_after_round_trip()
        {
            validate(Path.GetFullPath("../../../../tas-tenant-apis/docs"), "Tas.Tenant");
        }

        [Fact]
        public void Core_json_validates_after_round_trip()
        {
            validate(Path.GetFullPath("../../../../tas-core-apis/docs"), "Tas.Core");
        }

        private void validate(string baseDir, string nameSpace)
        {
            var schemas = Path.Combine(baseDir, "schemas");
            var resolver = new Resolver(schemas);
            foreach (var example in Directory.EnumerateFiles(Path.Combine(baseDir, "examples")))
            {
                var exampleFile = Path.GetFileName(example);
                switch (exampleFile)
                {
                    //Items in examples are out of date
                    case "candidateEdit-simple.json":
                    case "candidateEditSpec-additional.json":
                    case "candidateEditSpec-apply.json":
                    case "candidateEditSpec-ATSData.json":
                    case "candidateEditSpec-register.json":
                    case "candidateEditSpec-registeradditional.json":

                    //Invalid enum values
                    case "rebootStatus-juggleApps.json":
                    case "rebootStatus-simpleReboot.json":
                    case "rebootStatus-bumpSecurityGeneration.json":

                    //Required fields are null
                    case "assessmentRead-created.json":
                    case "assessmentWriteByApp-completed.json":
                    case "assessmentWriteByApp-underway.json":
                    case "candidateFace-simple.json":
                        continue;
                }

                var schema = Path.Combine(schemas, GetSchemaName(exampleFile));
                if (schema.EndsWith("Read.json") || schema.EndsWith("Write.json"))
                {
                    //probably contains items, and thus is affected by
                    //https://github.com/RSuter/NJsonSchema/pull/628
                    continue;
                }
                switch (Path.GetFileName(schema))
                {
                    //https://github.com/RSuter/NJsonSchema/pull/628
                    case "tenantExtended.json":

                    //Degenerate inheritance
                    case "assertionHooks.json":
                    case "patchSet.json":
                    case "patchSetPreparer.json":
                        continue;
                }
                Type valueType;
                try
                {
                    valueType = GetValueType(nameSpace, schema);
                    Console.WriteLine("Validating " + example + " against " + (typeof(IList).IsAssignableFrom(valueType) ? "collection type " : "") + schema);
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("No schema found for " + Path.GetFileName(example));
                    continue;
                }
                catch (Exception e)
                {
                    throw new Exception("Error resolving schema for " + Path.GetFileName(example), e);
                }


                var poco = JsonConvert.DeserializeObject(File.ReadAllText(example), valueType);
                var json = JsonConvert.SerializeObject(poco, new JsonSerializerSettings() { Converters = new[] { new StringEnumConverter() }, ContractResolver = new IgnoreEmptyArrays() });
                var validator = new JSchemaValidatingReader(new JsonTextReader(new StringReader(json))) { Schema = JSchema.Parse(File.ReadAllText(schema), resolver) };


                try
                {
                    while (validator.Read()) { }
                }
                catch (Exception e)
                {
                    Console.WriteLine(json);
                    Assert.True(false, e.Message);
                }
                Assert.True(valueType.IsInstanceOfType(poco));

                if (exampleFile == "categoryValuesUpload-mockLocations.json")
                {
                    //https://github.com/JamesNK/Newtonsoft.Json/issues/1007
                    return;
                }
                Assert.True(JToken.DeepEquals(JToken.Parse(json), JToken.Parse(File.ReadAllText(example))), example + " equals " + json);
            }
        }

        private string GetSchemaName(string file)
        {
            if (file.StartsWith("routes-consumers-"))
            {
                return "routes-consumers.json";
            }
            var name = file.Split("-")[0];
            switch (name)
            {
                case "panelsForApp":
                    return "panelForApp.json";
                case "trackerMeta":
                    return "meta.json";
                default:
                    return name + ".json";
            }
        }

        private Type GetValueType(string nameSpace, String schemaName)
        {
            String[] parts = schemaName.Split('#');
            var schema = JToken.Parse(File.ReadAllText(parts[0]));
            var typeName = Path.GetFileNameWithoutExtension(parts[0]);
            if (parts.Length > 1)
            {
                foreach (var property in parts[1].Split('/'))
                {
                    if (String.IsNullOrEmpty(property))
                    {
                        continue;
                    }
                    schema = schema[property];
                    typeName = property;
                }
            }
            return GetValueType(nameSpace, schema, parts[0], typeName);
        }

        private Type GetValueType(string nameSpace, JToken schema, string fileName, string typeName)
        {
            var schemaType = schema["type"].Value<string>();
            switch (schemaType)
            {
                case "object":
                    var typeToLoad = nameSpace + '.' + Generator.Capitalize(Path.GetFileNameWithoutExtension(fileName)) + "." + Generator.Capitalize(typeName);
                    var type = typeof(IgnoreEmptyArrays).Assembly.GetType(typeToLoad);
                    if (type == null)
                    {
                        throw new Exception("Failed to load " + typeToLoad);
                    }
                    return type;
                case "array":
                    Type itemType;
                    if (schema["items"] == null)
                    {
                        itemType = typeof(JToken);
                    }
                    else if (schema["items"]["$ref"] != null)
                    {
                        var reference = schema["items"]["$ref"].Value<string>();
                        itemType = GetValueType(nameSpace, reference.StartsWith('#') ? fileName + reference : Path.Combine(Path.GetDirectoryName(fileName), reference));
                    }
                    else
                    {
                        typeToLoad = nameSpace + '.' + Generator.Capitalize(Path.GetFileNameWithoutExtension(fileName)) + "." + Generator.Capitalize(Generator.Depluralize(typeName));
                        itemType = typeof(IgnoreEmptyArrays).Assembly.GetType(typeToLoad);
                        if (itemType == null)
                        {
                            throw new Exception("Failed to load " + typeToLoad);
                        }
                    }
                    var collectionType = typeof(System.Collections.Generic.List<>).MakeGenericType(itemType);
                    if (!typeof(IList).IsAssignableFrom(collectionType)) { throw new Exception(); }
                    return collectionType;
                case "string":
                    return typeof(string);
                case "number":
                    return typeof(int);
                case "boolean":
                    return typeof(bool);
                default:
                    throw new Exception("Unrecognized json type: " + schemaType);
            }
        }
    }

    class Resolver : JSchemaResolver
    {
        private string _baseDir;
        public Resolver(string baseDir)
        {
            _baseDir = baseDir;
        }
        public override Stream GetSchemaResource(ResolveSchemaContext context, SchemaReference reference)
        {
            return new FileStream(Path.Combine(_baseDir, Path.GetFileName(reference.BaseUri.ToString())), FileMode.Open);
        }
    }

}