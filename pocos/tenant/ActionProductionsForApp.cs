//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v9.10.27.0 (Newtonsoft.Json v9.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------

namespace Tas.Tenant.ActionProductionsForApps
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ActionProductionsForApp 
    {
        /// <summary>the app that can produce these actions</summary>
        [Newtonsoft.Json.JsonProperty("app", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string App { get; set; }
    
        [Newtonsoft.Json.JsonProperty("actionProductions", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.ObservableCollection<PossibleAction> ActionProductions { get; set; } = new System.Collections.ObjectModel.ObservableCollection<PossibleAction>();
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static ActionProductionsForApp FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ActionProductionsForApp>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class PossibleAction 
    {
        /// <summary>A fixed name of this action, containing only lower case alpha, digits and '-' characters, length <= 30. The actionName is displayed to the user at setup time (e.g. to enable or disable the button) so it should make some sense to them. actionName should be unique within this app and scope, i.e. an app should never return more than one action with the same actionName as a possible job action.</summary>
        [Newtonsoft.Json.JsonProperty("actionName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string ActionName { get; set; }
    
        /// <summary>A description of what this action does</summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }
    
        [Newtonsoft.Json.JsonProperty("availableToInternals", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool AvailableToInternals { get; set; }
    
        [Newtonsoft.Json.JsonProperty("availableToExternals", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool AvailableToExternals { get; set; }
    
        /// <summary>true if this action may provide a setup page (i.e. require some setup before it can be used)</summary>
        [Newtonsoft.Json.JsonProperty("mayRequireSetupFlag", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool MayRequireSetupFlag { get; set; }
    
        [Newtonsoft.Json.JsonProperty("semantics", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Semantics Semantics { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static PossibleAction FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PossibleAction>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    /// <summary>details about the semantics of this action that can be used by other apps. For example, knowledge that the action is used to apply for jobs may be useful if we want to (e.g.) prevent the user from applying unless they have completed some pre-qualification stage</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Semantics 
    {
        [Newtonsoft.Json.JsonProperty("purpose", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Purpose? Purpose { get; set; }
    
        [Newtonsoft.Json.JsonProperty("gateFor", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<Anonymous> GateFor { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static Semantics FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Semantics>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    /// <summary>values are: createAccount - this action can create the candidate's account. Applies only to general actions. apply - this action can apply for a job. Applies only to job actions. editDetails - this action can edit candidate details. Applies only to general actions.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum Purpose
    {
        [System.Runtime.Serialization.EnumMember(Value = "createAccount")]
        CreateAccount = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = "editDetails")]
        EditDetails = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = "apply")]
        Apply = 2,
    
    }
    
    /// <summary>a purpose that (e.g. 'apply') that this button is a gate for.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Anonymous 
    {
        [Newtonsoft.Json.JsonProperty("purpose", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Purpose Purpose { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static Anonymous FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Anonymous>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
}