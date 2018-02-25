//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v9.10.27.0 (Newtonsoft.Json v9.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------

namespace Tas.Tenant.CategoryValuesUpload
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class CategoryValuesUpload 
    {
        /// <summary>true if this set is to be applied as a dry run - i.e. no changes should be made to the category values at the target</summary>
        [Newtonsoft.Json.JsonProperty("testFlag", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool TestFlag { get; set; }
    
        [Newtonsoft.Json.JsonProperty("categoryValues", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.ObservableCollection<Value> CategoryValues { get; set; } = new System.Collections.ObjectModel.ObservableCollection<Value>();
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static CategoryValuesUpload FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<CategoryValuesUpload>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Value 
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Id { get; set; }
    
        /// <summary>whether this node can be selected (i.e. is not disabled)</summary>
        [Newtonsoft.Json.JsonProperty("available", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Available { get; set; }
    
        /// <summary>the user visible name for this category value</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
    
        /// <summary>a code for this category value</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code { get; set; }
    
        [Newtonsoft.Json.JsonProperty("externalId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExternalId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("location", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Location Location { get; set; }
    
        [Newtonsoft.Json.JsonProperty("values", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<Value> Values { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static Value FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Value>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    /// <summary>the geographic coordinates of this value, which represents a physical location. This may be present only when (a) the category itself has key of LOCATION, and (b) the value is a leaf (has no children)</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Location 
    {
        /// <summary>latitude of this location</summary>
        [Newtonsoft.Json.JsonProperty("lat", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Lat { get; set; }
    
        /// <summary>longitude of this location</summary>
        [Newtonsoft.Json.JsonProperty("lng", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Lng { get; set; }
    
        /// <summary>country, in ISO 3166-1 alpha-2 form</summary>
        [Newtonsoft.Json.JsonProperty("country", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public LocationCountry? Country { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static Location FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Location>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.27.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum LocationCountry
    {
        [System.Runtime.Serialization.EnumMember(Value = "AC")]
        AC = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = "AD")]
        AD = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = "AE")]
        AE = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = "AF")]
        AF = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = "AG")]
        AG = 4,
    
        [System.Runtime.Serialization.EnumMember(Value = "AI")]
        AI = 5,
    
        [System.Runtime.Serialization.EnumMember(Value = "AL")]
        AL = 6,
    
        [System.Runtime.Serialization.EnumMember(Value = "AM")]
        AM = 7,
    
        [System.Runtime.Serialization.EnumMember(Value = "AN")]
        AN = 8,
    
        [System.Runtime.Serialization.EnumMember(Value = "AO")]
        AO = 9,
    
        [System.Runtime.Serialization.EnumMember(Value = "AQ")]
        AQ = 10,
    
        [System.Runtime.Serialization.EnumMember(Value = "AR")]
        AR = 11,
    
        [System.Runtime.Serialization.EnumMember(Value = "AS")]
        AS = 12,
    
        [System.Runtime.Serialization.EnumMember(Value = "AT")]
        AT = 13,
    
        [System.Runtime.Serialization.EnumMember(Value = "AU")]
        AU = 14,
    
        [System.Runtime.Serialization.EnumMember(Value = "AW")]
        AW = 15,
    
        [System.Runtime.Serialization.EnumMember(Value = "AX")]
        AX = 16,
    
        [System.Runtime.Serialization.EnumMember(Value = "AZ")]
        AZ = 17,
    
        [System.Runtime.Serialization.EnumMember(Value = "BA")]
        BA = 18,
    
        [System.Runtime.Serialization.EnumMember(Value = "BB")]
        BB = 19,
    
        [System.Runtime.Serialization.EnumMember(Value = "BD")]
        BD = 20,
    
        [System.Runtime.Serialization.EnumMember(Value = "BE")]
        BE = 21,
    
        [System.Runtime.Serialization.EnumMember(Value = "BF")]
        BF = 22,
    
        [System.Runtime.Serialization.EnumMember(Value = "BG")]
        BG = 23,
    
        [System.Runtime.Serialization.EnumMember(Value = "BH")]
        BH = 24,
    
        [System.Runtime.Serialization.EnumMember(Value = "BI")]
        BI = 25,
    
        [System.Runtime.Serialization.EnumMember(Value = "BJ")]
        BJ = 26,
    
        [System.Runtime.Serialization.EnumMember(Value = "BM")]
        BM = 27,
    
        [System.Runtime.Serialization.EnumMember(Value = "BN")]
        BN = 28,
    
        [System.Runtime.Serialization.EnumMember(Value = "BO")]
        BO = 29,
    
        [System.Runtime.Serialization.EnumMember(Value = "BR")]
        BR = 30,
    
        [System.Runtime.Serialization.EnumMember(Value = "BS")]
        BS = 31,
    
        [System.Runtime.Serialization.EnumMember(Value = "BT")]
        BT = 32,
    
        [System.Runtime.Serialization.EnumMember(Value = "BV")]
        BV = 33,
    
        [System.Runtime.Serialization.EnumMember(Value = "BW")]
        BW = 34,
    
        [System.Runtime.Serialization.EnumMember(Value = "BY")]
        BY = 35,
    
        [System.Runtime.Serialization.EnumMember(Value = "BZ")]
        BZ = 36,
    
        [System.Runtime.Serialization.EnumMember(Value = "CA")]
        CA = 37,
    
        [System.Runtime.Serialization.EnumMember(Value = "CC")]
        CC = 38,
    
        [System.Runtime.Serialization.EnumMember(Value = "CD")]
        CD = 39,
    
        [System.Runtime.Serialization.EnumMember(Value = "CF")]
        CF = 40,
    
        [System.Runtime.Serialization.EnumMember(Value = "CG")]
        CG = 41,
    
        [System.Runtime.Serialization.EnumMember(Value = "CH")]
        CH = 42,
    
        [System.Runtime.Serialization.EnumMember(Value = "CI")]
        CI = 43,
    
        [System.Runtime.Serialization.EnumMember(Value = "CK")]
        CK = 44,
    
        [System.Runtime.Serialization.EnumMember(Value = "CL")]
        CL = 45,
    
        [System.Runtime.Serialization.EnumMember(Value = "CM")]
        CM = 46,
    
        [System.Runtime.Serialization.EnumMember(Value = "CN")]
        CN = 47,
    
        [System.Runtime.Serialization.EnumMember(Value = "CO")]
        CO = 48,
    
        [System.Runtime.Serialization.EnumMember(Value = "CR")]
        CR = 49,
    
        [System.Runtime.Serialization.EnumMember(Value = "CU")]
        CU = 50,
    
        [System.Runtime.Serialization.EnumMember(Value = "CV")]
        CV = 51,
    
        [System.Runtime.Serialization.EnumMember(Value = "CX")]
        CX = 52,
    
        [System.Runtime.Serialization.EnumMember(Value = "CY")]
        CY = 53,
    
        [System.Runtime.Serialization.EnumMember(Value = "CZ")]
        CZ = 54,
    
        [System.Runtime.Serialization.EnumMember(Value = "DE")]
        DE = 55,
    
        [System.Runtime.Serialization.EnumMember(Value = "DJ")]
        DJ = 56,
    
        [System.Runtime.Serialization.EnumMember(Value = "DK")]
        DK = 57,
    
        [System.Runtime.Serialization.EnumMember(Value = "DM")]
        DM = 58,
    
        [System.Runtime.Serialization.EnumMember(Value = "DO")]
        DO = 59,
    
        [System.Runtime.Serialization.EnumMember(Value = "DZ")]
        DZ = 60,
    
        [System.Runtime.Serialization.EnumMember(Value = "EC")]
        EC = 61,
    
        [System.Runtime.Serialization.EnumMember(Value = "EE")]
        EE = 62,
    
        [System.Runtime.Serialization.EnumMember(Value = "EG")]
        EG = 63,
    
        [System.Runtime.Serialization.EnumMember(Value = "ER")]
        ER = 64,
    
        [System.Runtime.Serialization.EnumMember(Value = "ES")]
        ES = 65,
    
        [System.Runtime.Serialization.EnumMember(Value = "ET")]
        ET = 66,
    
        [System.Runtime.Serialization.EnumMember(Value = "FI")]
        FI = 67,
    
        [System.Runtime.Serialization.EnumMember(Value = "FJ")]
        FJ = 68,
    
        [System.Runtime.Serialization.EnumMember(Value = "FK")]
        FK = 69,
    
        [System.Runtime.Serialization.EnumMember(Value = "FM")]
        FM = 70,
    
        [System.Runtime.Serialization.EnumMember(Value = "FO")]
        FO = 71,
    
        [System.Runtime.Serialization.EnumMember(Value = "FR")]
        FR = 72,
    
        [System.Runtime.Serialization.EnumMember(Value = "GA")]
        GA = 73,
    
        [System.Runtime.Serialization.EnumMember(Value = "GB")]
        GB = 74,
    
        [System.Runtime.Serialization.EnumMember(Value = "GD")]
        GD = 75,
    
        [System.Runtime.Serialization.EnumMember(Value = "GE")]
        GE = 76,
    
        [System.Runtime.Serialization.EnumMember(Value = "GF")]
        GF = 77,
    
        [System.Runtime.Serialization.EnumMember(Value = "GG")]
        GG = 78,
    
        [System.Runtime.Serialization.EnumMember(Value = "GH")]
        GH = 79,
    
        [System.Runtime.Serialization.EnumMember(Value = "GI")]
        GI = 80,
    
        [System.Runtime.Serialization.EnumMember(Value = "GL")]
        GL = 81,
    
        [System.Runtime.Serialization.EnumMember(Value = "GM")]
        GM = 82,
    
        [System.Runtime.Serialization.EnumMember(Value = "GN")]
        GN = 83,
    
        [System.Runtime.Serialization.EnumMember(Value = "GP")]
        GP = 84,
    
        [System.Runtime.Serialization.EnumMember(Value = "GQ")]
        GQ = 85,
    
        [System.Runtime.Serialization.EnumMember(Value = "GR")]
        GR = 86,
    
        [System.Runtime.Serialization.EnumMember(Value = "GS")]
        GS = 87,
    
        [System.Runtime.Serialization.EnumMember(Value = "GT")]
        GT = 88,
    
        [System.Runtime.Serialization.EnumMember(Value = "GU")]
        GU = 89,
    
        [System.Runtime.Serialization.EnumMember(Value = "GW")]
        GW = 90,
    
        [System.Runtime.Serialization.EnumMember(Value = "GY")]
        GY = 91,
    
        [System.Runtime.Serialization.EnumMember(Value = "HK")]
        HK = 92,
    
        [System.Runtime.Serialization.EnumMember(Value = "HM")]
        HM = 93,
    
        [System.Runtime.Serialization.EnumMember(Value = "HN")]
        HN = 94,
    
        [System.Runtime.Serialization.EnumMember(Value = "HR")]
        HR = 95,
    
        [System.Runtime.Serialization.EnumMember(Value = "HT")]
        HT = 96,
    
        [System.Runtime.Serialization.EnumMember(Value = "HU")]
        HU = 97,
    
        [System.Runtime.Serialization.EnumMember(Value = "ID")]
        ID = 98,
    
        [System.Runtime.Serialization.EnumMember(Value = "IE")]
        IE = 99,
    
        [System.Runtime.Serialization.EnumMember(Value = "IL")]
        IL = 100,
    
        [System.Runtime.Serialization.EnumMember(Value = "IM")]
        IM = 101,
    
        [System.Runtime.Serialization.EnumMember(Value = "IN")]
        IN = 102,
    
        [System.Runtime.Serialization.EnumMember(Value = "IO")]
        IO = 103,
    
        [System.Runtime.Serialization.EnumMember(Value = "IQ")]
        IQ = 104,
    
        [System.Runtime.Serialization.EnumMember(Value = "IR")]
        IR = 105,
    
        [System.Runtime.Serialization.EnumMember(Value = "IS")]
        IS = 106,
    
        [System.Runtime.Serialization.EnumMember(Value = "IT")]
        IT = 107,
    
        [System.Runtime.Serialization.EnumMember(Value = "JE")]
        JE = 108,
    
        [System.Runtime.Serialization.EnumMember(Value = "JM")]
        JM = 109,
    
        [System.Runtime.Serialization.EnumMember(Value = "JO")]
        JO = 110,
    
        [System.Runtime.Serialization.EnumMember(Value = "JP")]
        JP = 111,
    
        [System.Runtime.Serialization.EnumMember(Value = "KE")]
        KE = 112,
    
        [System.Runtime.Serialization.EnumMember(Value = "KG")]
        KG = 113,
    
        [System.Runtime.Serialization.EnumMember(Value = "KH")]
        KH = 114,
    
        [System.Runtime.Serialization.EnumMember(Value = "KI")]
        KI = 115,
    
        [System.Runtime.Serialization.EnumMember(Value = "KM")]
        KM = 116,
    
        [System.Runtime.Serialization.EnumMember(Value = "KN")]
        KN = 117,
    
        [System.Runtime.Serialization.EnumMember(Value = "KP")]
        KP = 118,
    
        [System.Runtime.Serialization.EnumMember(Value = "KR")]
        KR = 119,
    
        [System.Runtime.Serialization.EnumMember(Value = "KW")]
        KW = 120,
    
        [System.Runtime.Serialization.EnumMember(Value = "KY")]
        KY = 121,
    
        [System.Runtime.Serialization.EnumMember(Value = "KZ")]
        KZ = 122,
    
        [System.Runtime.Serialization.EnumMember(Value = "LA")]
        LA = 123,
    
        [System.Runtime.Serialization.EnumMember(Value = "LB")]
        LB = 124,
    
        [System.Runtime.Serialization.EnumMember(Value = "LC")]
        LC = 125,
    
        [System.Runtime.Serialization.EnumMember(Value = "LI")]
        LI = 126,
    
        [System.Runtime.Serialization.EnumMember(Value = "LK")]
        LK = 127,
    
        [System.Runtime.Serialization.EnumMember(Value = "LR")]
        LR = 128,
    
        [System.Runtime.Serialization.EnumMember(Value = "LS")]
        LS = 129,
    
        [System.Runtime.Serialization.EnumMember(Value = "LT")]
        LT = 130,
    
        [System.Runtime.Serialization.EnumMember(Value = "LU")]
        LU = 131,
    
        [System.Runtime.Serialization.EnumMember(Value = "LV")]
        LV = 132,
    
        [System.Runtime.Serialization.EnumMember(Value = "LY")]
        LY = 133,
    
        [System.Runtime.Serialization.EnumMember(Value = "MA")]
        MA = 134,
    
        [System.Runtime.Serialization.EnumMember(Value = "MC")]
        MC = 135,
    
        [System.Runtime.Serialization.EnumMember(Value = "MD")]
        MD = 136,
    
        [System.Runtime.Serialization.EnumMember(Value = "ME")]
        ME = 137,
    
        [System.Runtime.Serialization.EnumMember(Value = "MG")]
        MG = 138,
    
        [System.Runtime.Serialization.EnumMember(Value = "MH")]
        MH = 139,
    
        [System.Runtime.Serialization.EnumMember(Value = "MK")]
        MK = 140,
    
        [System.Runtime.Serialization.EnumMember(Value = "ML")]
        ML = 141,
    
        [System.Runtime.Serialization.EnumMember(Value = "MM")]
        MM = 142,
    
        [System.Runtime.Serialization.EnumMember(Value = "MN")]
        MN = 143,
    
        [System.Runtime.Serialization.EnumMember(Value = "MO")]
        MO = 144,
    
        [System.Runtime.Serialization.EnumMember(Value = "MP")]
        MP = 145,
    
        [System.Runtime.Serialization.EnumMember(Value = "MQ")]
        MQ = 146,
    
        [System.Runtime.Serialization.EnumMember(Value = "MR")]
        MR = 147,
    
        [System.Runtime.Serialization.EnumMember(Value = "MS")]
        MS = 148,
    
        [System.Runtime.Serialization.EnumMember(Value = "MT")]
        MT = 149,
    
        [System.Runtime.Serialization.EnumMember(Value = "MU")]
        MU = 150,
    
        [System.Runtime.Serialization.EnumMember(Value = "MV")]
        MV = 151,
    
        [System.Runtime.Serialization.EnumMember(Value = "MW")]
        MW = 152,
    
        [System.Runtime.Serialization.EnumMember(Value = "MX")]
        MX = 153,
    
        [System.Runtime.Serialization.EnumMember(Value = "MY")]
        MY = 154,
    
        [System.Runtime.Serialization.EnumMember(Value = "MZ")]
        MZ = 155,
    
        [System.Runtime.Serialization.EnumMember(Value = "NA")]
        NA = 156,
    
        [System.Runtime.Serialization.EnumMember(Value = "NC")]
        NC = 157,
    
        [System.Runtime.Serialization.EnumMember(Value = "NE")]
        NE = 158,
    
        [System.Runtime.Serialization.EnumMember(Value = "NF")]
        NF = 159,
    
        [System.Runtime.Serialization.EnumMember(Value = "NG")]
        NG = 160,
    
        [System.Runtime.Serialization.EnumMember(Value = "NI")]
        NI = 161,
    
        [System.Runtime.Serialization.EnumMember(Value = "NL")]
        NL = 162,
    
        [System.Runtime.Serialization.EnumMember(Value = "NO")]
        NO = 163,
    
        [System.Runtime.Serialization.EnumMember(Value = "NP")]
        NP = 164,
    
        [System.Runtime.Serialization.EnumMember(Value = "NR")]
        NR = 165,
    
        [System.Runtime.Serialization.EnumMember(Value = "NU")]
        NU = 166,
    
        [System.Runtime.Serialization.EnumMember(Value = "NZ")]
        NZ = 167,
    
        [System.Runtime.Serialization.EnumMember(Value = "OM")]
        OM = 168,
    
        [System.Runtime.Serialization.EnumMember(Value = "PA")]
        PA = 169,
    
        [System.Runtime.Serialization.EnumMember(Value = "PE")]
        PE = 170,
    
        [System.Runtime.Serialization.EnumMember(Value = "PF")]
        PF = 171,
    
        [System.Runtime.Serialization.EnumMember(Value = "PG")]
        PG = 172,
    
        [System.Runtime.Serialization.EnumMember(Value = "PH")]
        PH = 173,
    
        [System.Runtime.Serialization.EnumMember(Value = "PK")]
        PK = 174,
    
        [System.Runtime.Serialization.EnumMember(Value = "PL")]
        PL = 175,
    
        [System.Runtime.Serialization.EnumMember(Value = "PM")]
        PM = 176,
    
        [System.Runtime.Serialization.EnumMember(Value = "PN")]
        PN = 177,
    
        [System.Runtime.Serialization.EnumMember(Value = "PR")]
        PR = 178,
    
        [System.Runtime.Serialization.EnumMember(Value = "PT")]
        PT = 179,
    
        [System.Runtime.Serialization.EnumMember(Value = "PW")]
        PW = 180,
    
        [System.Runtime.Serialization.EnumMember(Value = "PY")]
        PY = 181,
    
        [System.Runtime.Serialization.EnumMember(Value = "QA")]
        QA = 182,
    
        [System.Runtime.Serialization.EnumMember(Value = "RE")]
        RE = 183,
    
        [System.Runtime.Serialization.EnumMember(Value = "RO")]
        RO = 184,
    
        [System.Runtime.Serialization.EnumMember(Value = "RS")]
        RS = 185,
    
        [System.Runtime.Serialization.EnumMember(Value = "RU")]
        RU = 186,
    
        [System.Runtime.Serialization.EnumMember(Value = "RW")]
        RW = 187,
    
        [System.Runtime.Serialization.EnumMember(Value = "SA")]
        SA = 188,
    
        [System.Runtime.Serialization.EnumMember(Value = "SB")]
        SB = 189,
    
        [System.Runtime.Serialization.EnumMember(Value = "SC")]
        SC = 190,
    
        [System.Runtime.Serialization.EnumMember(Value = "SD")]
        SD = 191,
    
        [System.Runtime.Serialization.EnumMember(Value = "SE")]
        SE = 192,
    
        [System.Runtime.Serialization.EnumMember(Value = "SG")]
        SG = 193,
    
        [System.Runtime.Serialization.EnumMember(Value = "SH")]
        SH = 194,
    
        [System.Runtime.Serialization.EnumMember(Value = "SI")]
        SI = 195,
    
        [System.Runtime.Serialization.EnumMember(Value = "SJ")]
        SJ = 196,
    
        [System.Runtime.Serialization.EnumMember(Value = "SK")]
        SK = 197,
    
        [System.Runtime.Serialization.EnumMember(Value = "SL")]
        SL = 198,
    
        [System.Runtime.Serialization.EnumMember(Value = "SM")]
        SM = 199,
    
        [System.Runtime.Serialization.EnumMember(Value = "SN")]
        SN = 200,
    
        [System.Runtime.Serialization.EnumMember(Value = "SO")]
        SO = 201,
    
        [System.Runtime.Serialization.EnumMember(Value = "SR")]
        SR = 202,
    
        [System.Runtime.Serialization.EnumMember(Value = "ST")]
        ST = 203,
    
        [System.Runtime.Serialization.EnumMember(Value = "SV")]
        SV = 204,
    
        [System.Runtime.Serialization.EnumMember(Value = "SY")]
        SY = 205,
    
        [System.Runtime.Serialization.EnumMember(Value = "SZ")]
        SZ = 206,
    
        [System.Runtime.Serialization.EnumMember(Value = "TA")]
        TA = 207,
    
        [System.Runtime.Serialization.EnumMember(Value = "TC")]
        TC = 208,
    
        [System.Runtime.Serialization.EnumMember(Value = "TD")]
        TD = 209,
    
        [System.Runtime.Serialization.EnumMember(Value = "TF")]
        TF = 210,
    
        [System.Runtime.Serialization.EnumMember(Value = "TG")]
        TG = 211,
    
        [System.Runtime.Serialization.EnumMember(Value = "TH")]
        TH = 212,
    
        [System.Runtime.Serialization.EnumMember(Value = "TJ")]
        TJ = 213,
    
        [System.Runtime.Serialization.EnumMember(Value = "TK")]
        TK = 214,
    
        [System.Runtime.Serialization.EnumMember(Value = "TL")]
        TL = 215,
    
        [System.Runtime.Serialization.EnumMember(Value = "TM")]
        TM = 216,
    
        [System.Runtime.Serialization.EnumMember(Value = "TN")]
        TN = 217,
    
        [System.Runtime.Serialization.EnumMember(Value = "TO")]
        TO = 218,
    
        [System.Runtime.Serialization.EnumMember(Value = "TR")]
        TR = 219,
    
        [System.Runtime.Serialization.EnumMember(Value = "TT")]
        TT = 220,
    
        [System.Runtime.Serialization.EnumMember(Value = "TV")]
        TV = 221,
    
        [System.Runtime.Serialization.EnumMember(Value = "TW")]
        TW = 222,
    
        [System.Runtime.Serialization.EnumMember(Value = "TZ")]
        TZ = 223,
    
        [System.Runtime.Serialization.EnumMember(Value = "UA")]
        UA = 224,
    
        [System.Runtime.Serialization.EnumMember(Value = "UG")]
        UG = 225,
    
        [System.Runtime.Serialization.EnumMember(Value = "UM")]
        UM = 226,
    
        [System.Runtime.Serialization.EnumMember(Value = "US")]
        US = 227,
    
        [System.Runtime.Serialization.EnumMember(Value = "UY")]
        UY = 228,
    
        [System.Runtime.Serialization.EnumMember(Value = "UZ")]
        UZ = 229,
    
        [System.Runtime.Serialization.EnumMember(Value = "VA")]
        VA = 230,
    
        [System.Runtime.Serialization.EnumMember(Value = "VC")]
        VC = 231,
    
        [System.Runtime.Serialization.EnumMember(Value = "VE")]
        VE = 232,
    
        [System.Runtime.Serialization.EnumMember(Value = "VG")]
        VG = 233,
    
        [System.Runtime.Serialization.EnumMember(Value = "VI")]
        VI = 234,
    
        [System.Runtime.Serialization.EnumMember(Value = "VN")]
        VN = 235,
    
        [System.Runtime.Serialization.EnumMember(Value = "VU")]
        VU = 236,
    
        [System.Runtime.Serialization.EnumMember(Value = "WF")]
        WF = 237,
    
        [System.Runtime.Serialization.EnumMember(Value = "WS")]
        WS = 238,
    
        [System.Runtime.Serialization.EnumMember(Value = "YE")]
        YE = 239,
    
        [System.Runtime.Serialization.EnumMember(Value = "YT")]
        YT = 240,
    
        [System.Runtime.Serialization.EnumMember(Value = "ZA")]
        ZA = 241,
    
        [System.Runtime.Serialization.EnumMember(Value = "ZM")]
        ZM = 242,
    
        [System.Runtime.Serialization.EnumMember(Value = "ZW")]
        ZW = 243,
    
    }
}