//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v9.10.27.0 (Newtonsoft.Json v9.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------

namespace Tas.Tenant.JobFeedDetails
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class JobFeedDetails 
    {
        /// <summary>The url of the job feed.</summary>
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Url { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static JobFeedDetails FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<JobFeedDetails>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
}