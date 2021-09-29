namespace FESapp


using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

public  class Checklists
{
    [JsonProperty("_id")]
    public string Id { get; set; }

    [JsonProperty("question")]
    public string Question { get; set; }

    [JsonProperty("correct_answer")]
    public string CorrectAnswer { get; set; }

    [JsonProperty("createdAt")]
    public DateTimeOffset CreatedAt { get; set; }

    [JsonProperty("updatedAt")]
    public DateTimeOffset UpdatedAt { get; set; }

    [JsonProperty("__v")]
    public long V { get; set; }

    [JsonProperty("url")]
    public Url Url { get; set; }

    [JsonProperty("id")]
    public string ChecklistId { get; set; }
}

}