using System;

namespace Tas
{
    public class ProblemDetails
    {
        [Newtonsoft.Json.JsonProperty("type")]
        string Type { get; set; }
        [Newtonsoft.Json.JsonProperty("title")]
        string Title { get; set; }
        [Newtonsoft.Json.JsonProperty("status")]
        int Status { get; set; }
        [Newtonsoft.Json.JsonProperty("detail")]
        string Detail { get; set; }
        [Newtonsoft.Json.JsonProperty("instance")]
        Uri Instance { get; set; }
    }
}