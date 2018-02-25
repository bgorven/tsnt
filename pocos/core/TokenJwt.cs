//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v9.10.27.0 (Newtonsoft.Json v9.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------

namespace Tas.Core.TokenJwt
{
    #pragma warning disable // Disable all warnings

    /// <summary>a class of principal (typically a human) identifiable by SSO. In theory developer-defined but for now only TAS can create.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum PrincipalType
    {
        [System.Runtime.Serialization.EnumMember(Value = "user")]
        User = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = "candidate")]
        Candidate = 1,
    
    }
    
    /// <summary>A set of SAML values that uniquely identify this person, consistently across TAS apps, and with any number of potential IdPs</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class SamlSubject 
    {
        /// <summary>principal type</summary>
        [Newtonsoft.Json.JsonProperty("pt", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PrincipalType Pt { get; set; }
    
        /// <summary>key of the SAML assertion with the the TAS core SAML database</summary>
        [Newtonsoft.Json.JsonProperty("samlKey", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string SamlKey { get; set; }
    
        [Newtonsoft.Json.JsonProperty("nameID", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string NameID { get; set; }
    
        [Newtonsoft.Json.JsonProperty("entityID", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string EntityID { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static SamlSubject FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<SamlSubject>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    /// <summary>reference to http://self-issued.info/docs/draft-ietf-oauth-json-web-token.html</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class TokenJwt 
    {
        [Newtonsoft.Json.JsonProperty("sub", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SamlSubject Sub { get; set; }
    
        /// <summary>details of the app consuming the API</summary>
        [Newtonsoft.Json.JsonProperty("cons", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public Cons Cons { get; set; } = new Cons();
    
        /// <summary>audience - details of the app producing the API</summary>
        [Newtonsoft.Json.JsonProperty("aud", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public Aud Aud { get; set; } = new Aud();
    
        /// <summary>the API's developer</summary>
        [Newtonsoft.Json.JsonProperty("dev", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Dev { get; set; }
    
        /// <summary>the URI template of the API</summary>
        [Newtonsoft.Json.JsonProperty("api", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Api { get; set; }
    
        /// <summary>whether the API is being consumed as SoT (if true) or not</summary>
        [Newtonsoft.Json.JsonProperty("sot", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Sot { get; set; }
    
        /// <summary>time the token was issued, as per the spec.</summary>
        [Newtonsoft.Json.JsonProperty("iat", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Iat { get; set; }
    
        /// <summary>time the token expires, as per the spec.</summary>
        [Newtonsoft.Json.JsonProperty("exp", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Exp { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static TokenJwt FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<TokenJwt>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Cons 
    {
        /// <summary>the tenant who has installed the app consuming the API</summary>
        [Newtonsoft.Json.JsonProperty("ct", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Ct { get; set; }
    
        /// <summary>the app consuming the API</summary>
        [Newtonsoft.Json.JsonProperty("ca", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Ca { get; set; }
    
        /// <summary>the security generation of the tenant</summary>
        [Newtonsoft.Json.JsonProperty("sgen", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Sgen { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static Cons FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Cons>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Aud 
    {
        /// <summary>the tenant who has installed the app producing the API</summary>
        [Newtonsoft.Json.JsonProperty("pt", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Pt { get; set; }
    
        /// <summary>the app producing the API</summary>
        [Newtonsoft.Json.JsonProperty("pa", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Pa { get; set; }
    
        /// <summary>the security generation of the tenant</summary>
        [Newtonsoft.Json.JsonProperty("sgen", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Sgen { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static Aud FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Aud>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
}