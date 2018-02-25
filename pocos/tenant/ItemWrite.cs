//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v9.10.27.0 (Newtonsoft.Json v9.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------

namespace Tas.Tenant.ItemWrite
{
    #pragma warning disable // Disable all warnings

    [Newtonsoft.Json.JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritanceAttribute("boolean", typeof(Boolean))]
    [JsonInheritanceAttribute("boolean", typeof(Boolean2))]
    [JsonInheritanceAttribute("string", typeof(String2))]
    [JsonInheritanceAttribute("number", typeof(Number2))]
    [JsonInheritanceAttribute("date", typeof(Date2))]
    [JsonInheritanceAttribute("file", typeof(File2))]
    [JsonInheritanceAttribute("picklist", typeof(Picklist2))]
    [JsonInheritanceAttribute("table", typeof(Table))]
    [JsonInheritanceAttribute("string", typeof(String))]
    [JsonInheritanceAttribute("number", typeof(Number))]
    [JsonInheritanceAttribute("date", typeof(Date))]
    [JsonInheritanceAttribute("picklist", typeof(Picklist))]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ItemRead 
    {
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }
    
        [Newtonsoft.Json.JsonProperty("display", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Display { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static ItemRead FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ItemRead>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Boolean : ItemRead
    {
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
    
        [Newtonsoft.Json.JsonProperty("display", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Display { get; set; }
    
        /// <summary>json representation of a boolean item's current value</summary>
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Value { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static Boolean FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Boolean>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class String : ItemRead
    {
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
    
        [Newtonsoft.Json.JsonProperty("display", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Display { get; set; }
    
        /// <summary>json representation of a string item's current value</summary>
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Value { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static String FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<String>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Number : ItemRead
    {
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
    
        [Newtonsoft.Json.JsonProperty("display", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Display { get; set; }
    
        /// <summary>json representation of a number item's current value</summary>
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Value { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static Number FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Number>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Date : ItemRead
    {
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
    
        [Newtonsoft.Json.JsonProperty("display", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Display { get; set; }
    
        /// <summary>json representation of a date item's current value</summary>
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.DateTime Value { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static Date FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Date>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [Newtonsoft.Json.JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritanceAttribute("file", typeof(File))]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ItemWrite 
    {
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static ItemWrite FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ItemWrite>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class File : ItemWrite
    {
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
    
        [Newtonsoft.Json.JsonProperty("display", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Display { get; set; }
    
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public FileUpload Value { get; set; } = new FileUpload();
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static File FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<File>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Picklist : ItemRead
    {
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
    
        [Newtonsoft.Json.JsonProperty("display", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Display { get; set; }
    
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.ObservableCollection<PickChoice> Value { get; set; } = new System.Collections.ObjectModel.ObservableCollection<PickChoice>();
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static Picklist FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Picklist>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    /// <summary>keep in synch with the trait document_asStream</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum MediaType
    {
        [System.Runtime.Serialization.EnumMember(Value = "application/pdf")]
        Application_pdf = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = "application/vnd.openxmlformats-officedocument.wordprocessingml.document")]
        Application_vnd_openxmlformatsOfficedocument_wordprocessingml_document = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = "application/msword")]
        Application_msword = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = "application/rtf")]
        Application_rtf = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = "text/plain")]
        Text_plain = 4,
    
        [System.Runtime.Serialization.EnumMember(Value = "image/png")]
        Image_png = 5,
    
        [System.Runtime.Serialization.EnumMember(Value = "text/html")]
        Text_html = 6,
    
    }
    
    /// <summary>details for a previously uploaded file</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class FileDownload 
    {
        [Newtonsoft.Json.JsonProperty("fileName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string FileName { get; set; }
    
        [Newtonsoft.Json.JsonProperty("via", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Via { get; set; }
    
        [Newtonsoft.Json.JsonProperty("mediaType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public MediaType MediaType { get; set; }
    
        [Newtonsoft.Json.JsonProperty("size", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Size { get; set; }
    
        /// <summary>hash of the file's binary content</summary>
        [Newtonsoft.Json.JsonProperty("md5", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Md5 { get; set; }
    
        /// <summary>the date and time the file was uploaded</summary>
        [Newtonsoft.Json.JsonProperty("dateUploaded", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? DateUploaded { get; set; }
    
        /// <summary>pre-signed link as per http://docs.aws.amazon.com/AmazonS3/latest/API/sigv4-query-string-auth.html to access the raw data. Includes file name as the trailing component so that browsers name the download correctly.</summary>
        [Newtonsoft.Json.JsonProperty("preSignedUri", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string PreSignedUri { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static FileDownload FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<FileDownload>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class PickChoice 
    {
        /// <summary>the name of a choice that the user selected</summary>
        [Newtonsoft.Json.JsonProperty("choice", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Choice { get; set; }
    
        /// <summary>items unlocked based on a picklist choice</summary>
        [Newtonsoft.Json.JsonProperty("subItems", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<ItemRead> SubItems { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static PickChoice FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PickChoice>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Boolean2 : ItemRead
    {
        /// <summary>json representation of a boolean item's current value</summary>
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Value { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static Boolean2 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Boolean2>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class String2 : ItemRead
    {
        /// <summary>json representation of a string item's current value</summary>
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Value { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static String2 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<String2>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Number2 : ItemRead
    {
        /// <summary>json representation of a number item's current value</summary>
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Value { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static Number2 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Number2>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Date2 : ItemRead
    {
        /// <summary>json representation of a date item's current value</summary>
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.DateTime Value { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static Date2 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Date2>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class File2 : ItemRead
    {
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public FileDownload Value { get; set; } = new FileDownload();
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static File2 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<File2>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Picklist2 : ItemRead
    {
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.ObservableCollection<PickChoice> Value { get; set; } = new System.Collections.ObjectModel.ObservableCollection<PickChoice>();
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static Picklist2 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Picklist2>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Table : ItemRead
    {
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.ObservableCollection<System.Collections.ObjectModel.ObservableCollection<ItemRead>> Value { get; set; } = new System.Collections.ObjectModel.ObservableCollection<System.Collections.ObjectModel.ObservableCollection<ItemRead>>();
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static Table FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Table>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    /// <summary>Details for a file upload operation</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class FileUpload 
    {
        [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Data { get; set; }
    
        [Newtonsoft.Json.JsonProperty("fileName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string FileName { get; set; }
    
        [Newtonsoft.Json.JsonProperty("via", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Via { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static FileUpload FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<FileUpload>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    [System.AttributeUsage(System.AttributeTargets.Class, AllowMultiple = true)]
    internal class JsonInheritanceAttribute : System.Attribute
    {
        public JsonInheritanceAttribute(string key, System.Type type)
        {
            Key = key;
            Type = type;
        }
    
        public string Key { get; }
    
        public System.Type Type { get; }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    internal class JsonInheritanceConverter : Newtonsoft.Json.JsonConverter
    {
        internal static readonly string DefaultDiscriminatorName = "discriminator";
    
        private readonly string _discriminator;
    
        [System.ThreadStatic]
        private static bool _isReading;
    
        [System.ThreadStatic]
        private static bool _isWriting;
    
        public JsonInheritanceConverter()
        {
            _discriminator = DefaultDiscriminatorName;
        }
    
        public JsonInheritanceConverter(string discriminator)
        {
            _discriminator = discriminator;
        }
    
        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
        {
            try
            {
                _isWriting = true;
    
                var jObject = Newtonsoft.Json.Linq.JObject.FromObject(value, serializer);
                jObject.AddFirst(new Newtonsoft.Json.Linq.JProperty(_discriminator, value.GetType().Name));
                writer.WriteToken(jObject.CreateReader());
            }
            finally
            {
                _isWriting = false;
            }
        }
    
        public override bool CanWrite
        {
            get
            {
                if (_isWriting)
                {
                    _isWriting = false;
                    return false;
                }
                return true;
            }
        }
    
        public override bool CanRead
        {
            get
            {
                if (_isReading)
                {
                    _isReading = false;
                    return false;
                }
                return true;
            }
        }
    
        public override bool CanConvert(System.Type objectType)
        {
            return true;
        }
    
        public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer)
        {
            var jObject = serializer.Deserialize<Newtonsoft.Json.Linq.JObject>(reader);
            if (jObject == null)
                return null;
    
            var discriminator = Newtonsoft.Json.Linq.Extensions.Value<string>(jObject.GetValue(_discriminator));
            var subtype = GetObjectSubtype(objectType, discriminator);
    
            try
            {
                _isReading = true;
                return serializer.Deserialize(jObject.CreateReader(), subtype);
            }
            finally
            {
                _isReading = false;
            }
        }
    
        private System.Type GetObjectSubtype(System.Type objectType, string discriminator)
        {
            foreach (var type in System.Reflection.CustomAttributeExtensions.GetCustomAttributes<JsonInheritanceAttribute>(System.Reflection.IntrospectionExtensions.GetTypeInfo(objectType), true))
            {
                if (type.Key == discriminator)
                    return type.Type;
            }
    
            return objectType;
        }
    }
}