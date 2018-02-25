//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v9.10.27.0 (Newtonsoft.Json v9.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------

namespace Tas.Tenant.AssessmentTypes
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class AppTypesWithID 
    {
        /// <summary>Shortcode for the app that owns these assessment types</summary>
        [Newtonsoft.Json.JsonProperty("app", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string App { get; set; }
    
        /// <summary>Name for the app that owns these assessment types</summary>
        [Newtonsoft.Json.JsonProperty("appName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string AppName { get; set; }
    
        [Newtonsoft.Json.JsonProperty("assessmentTypesWithID", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.ObservableCollection<Anonymous> AssessmentTypesWithID { get; set; } = new System.Collections.ObjectModel.ObservableCollection<Anonymous>();
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static AppTypesWithID FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AppTypesWithID>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Anonymous 
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("activeFlag", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool ActiveFlag { get; set; }
    
        [Newtonsoft.Json.JsonProperty("assessmentType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public AssessmentType AssessmentType { get; set; } = new AssessmentType();
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static Anonymous FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Anonymous>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class AssessmentType 
    {
        [Newtonsoft.Json.JsonProperty("key", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Key { get; set; }
    
        [Newtonsoft.Json.JsonProperty("userTitle", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string UserTitle { get; set; }
    
        [Newtonsoft.Json.JsonProperty("candidateTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CandidateTitle { get; set; }
    
        [Newtonsoft.Json.JsonProperty("daysToExpire", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int DaysToExpire { get; set; }
    
        [Newtonsoft.Json.JsonProperty("canReuse", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool CanReuse { get; set; }
    
        [Newtonsoft.Json.JsonProperty("isPassFail", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsPassFail { get; set; }
    
        [Newtonsoft.Json.JsonProperty("candidateDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CandidateDescription { get; set; }
    
        [Newtonsoft.Json.JsonProperty("userDescription", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string UserDescription { get; set; }
    
        [Newtonsoft.Json.JsonProperty("appCommunicatesDirectlyToCandidate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool AppCommunicatesDirectlyToCandidate { get; set; }
    
        [Newtonsoft.Json.JsonProperty("image", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Image { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static AssessmentType FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AssessmentType>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
}