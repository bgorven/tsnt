//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v9.10.27.0 (Newtonsoft.Json v9.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------

namespace Tas.Core.PatchSetPreparer
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
    
    /// <summary>operation on a single (non-array) SAML attribute</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class SingleValueAttributeOp 
    {
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
    
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Value { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static SingleValueAttributeOp FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<SingleValueAttributeOp>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    /// <summary>operation on a multi-valued SAML attribute</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class MultiValueAttributeOp 
    {
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
    
        [Newtonsoft.Json.JsonProperty("values", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.ObservableCollection<string> Values { get; set; } = new System.Collections.ObjectModel.ObservableCollection<string>();
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static MultiValueAttributeOp FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<MultiValueAttributeOp>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class AttributeOp 
    {
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static AttributeOp FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AttributeOp>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class AttributeOverride 
    {
        [Newtonsoft.Json.JsonProperty("filter", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Filter { get; set; }
    
        [Newtonsoft.Json.JsonProperty("ifMatched", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.ObservableCollection<AttributeOp> IfMatched { get; set; } = new System.Collections.ObjectModel.ObservableCollection<AttributeOp>();
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static AttributeOverride FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AttributeOverride>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class IdentitySourceSet 
    {
        [Newtonsoft.Json.JsonProperty("principalType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PrincipalType PrincipalType { get; set; }
    
        [Newtonsoft.Json.JsonProperty("identitySources", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.ObservableCollection<IdentitySource> IdentitySources { get; set; } = new System.Collections.ObjectModel.ObservableCollection<IdentitySource>();
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static IdentitySourceSet FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<IdentitySourceSet>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class BasicAuthCredentials 
    {
        [Newtonsoft.Json.JsonProperty("user", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string User { get; set; }
    
        [Newtonsoft.Json.JsonProperty("password", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Password { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static BasicAuthCredentials FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<BasicAuthCredentials>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Server 
    {
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
    
        [Newtonsoft.Json.JsonProperty("baseUri", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string BaseUri { get; set; }
    
        [Newtonsoft.Json.JsonProperty("basicAuthCredentials", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public BasicAuthCredentials BasicAuthCredentials { get; set; } = new BasicAuthCredentials();
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static Server FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Server>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Details 
    {
        /// <summary>The legal name of the organization</summary>
        [Newtonsoft.Json.JsonProperty("organizationName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrganizationName { get; set; }
    
        /// <summary>a short, alpha only, lower case identifier for the tenant, e.g. acme</summary>
        [Newtonsoft.Json.JsonProperty("shortCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ShortCode { get; set; }
    
        /// <summary>a description for this store</summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }
    
        /// <summary>the country code for the organization using the store</summary>
        [Newtonsoft.Json.JsonProperty("country", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Country { get; set; }
    
        /// <summary>The organization's primary industry</summary>
        [Newtonsoft.Json.JsonProperty("industry", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DetailsIndustry? Industry { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static Details FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Details>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Install 
    {
        [Newtonsoft.Json.JsonProperty("app", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string App { get; set; }
    
        [Newtonsoft.Json.JsonProperty("servers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<Server> Servers { get; set; }
    
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object Status { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static Install FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Install>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [Newtonsoft.Json.JsonConverter(typeof(JsonInheritanceConverter), "kind")]
    [JsonInheritanceAttribute("samlIdentitySource", typeof(SamlIdentitySource))]
    [JsonInheritanceAttribute("emailIdentitySource", typeof(EmailIdentitySource))]
    [JsonInheritanceAttribute("legacyAppIdentitySource", typeof(LegacyAppIdentitySource))]
    [JsonInheritanceAttribute("socialIdentitySource", typeof(SocialIdentitySource))]
    [JsonInheritanceAttribute("bootstrapIdentitySource", typeof(BootstrapIdentitySource))]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class IdentitySource 
    {
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }
    
        [Newtonsoft.Json.JsonProperty("attributeOverrides", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<AttributeOverride> AttributeOverrides { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static IdentitySource FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<IdentitySource>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class SamlIdentitySource : IdentitySource
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("metadata", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Metadata { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static SamlIdentitySource FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<SamlIdentitySource>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class EmailIdentitySource : IdentitySource
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Id { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static EmailIdentitySource FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<EmailIdentitySource>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class LegacyAppIdentitySource : IdentitySource
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("apiBase", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string ApiBase { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static LegacyAppIdentitySource FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<LegacyAppIdentitySource>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class SocialIdentitySource : IdentitySource
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("network", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SocialIdentitySourceNetwork Network { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static SocialIdentitySource FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<SocialIdentitySource>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class BootstrapIdentitySource : IdentitySource
    {
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static BootstrapIdentitySource FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<BootstrapIdentitySource>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class TenantExtended 
    {
        [Newtonsoft.Json.JsonProperty("details", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Details Details { get; set; }
    
        [Newtonsoft.Json.JsonProperty("installs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<Install> Installs { get; set; }
    
        [Newtonsoft.Json.JsonProperty("identitySourceSets", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<IdentitySourceSet> IdentitySourceSets { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static TenantExtended FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<TenantExtended>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class PatchSetPreparer 
    {
        /// <summary>the URI that your storefront app thinks the user should be redirected to on patch completion, unless some other storefront app gets installed and hence makes that decision</summary>
        [Newtonsoft.Json.JsonProperty("continuePage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContinuePage { get; set; }
    
        /// <summary>true to request that the tenant's security generation is incremented as the patch is applied</summary>
        [Newtonsoft.Json.JsonProperty("bumpSecurityGeneration", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool BumpSecurityGeneration { get; set; }
    
        [Newtonsoft.Json.JsonProperty("patchSet", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.ObservableCollection<Op> PatchSet { get; set; } = new System.Collections.ObjectModel.ObservableCollection<Op>();
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static PatchSetPreparer FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PatchSetPreparer>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum DetailsIndustry
    {
        [System.Runtime.Serialization.EnumMember(Value = "Banking")]
        Banking = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = "Healthcare")]
        Healthcare = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = "Hospitality")]
        Hospitality = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = "IT")]
        IT = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = "Manufacturing")]
        Manufacturing = 4,
    
        [System.Runtime.Serialization.EnumMember(Value = "Other")]
        Other = 5,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum SocialIdentitySourceNetwork
    {
        [System.Runtime.Serialization.EnumMember(Value = "LinkedIn")]
        LinkedIn = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = "Facebook")]
        Facebook = 1,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Op 
    {
        [Newtonsoft.Json.JsonProperty("op", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Op1 Op1 { get; set; }
    
        [Newtonsoft.Json.JsonProperty("path", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Path { get; set; }
    
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Value { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static Op FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Op>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum Op1
    {
        [System.Runtime.Serialization.EnumMember(Value = "add")]
        Add = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = "remove")]
        Remove = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = "move")]
        Move = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = "copy")]
        Copy = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = "replace")]
        Replace = 4,
    
        [System.Runtime.Serialization.EnumMember(Value = "test")]
        Test = 5,
    
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