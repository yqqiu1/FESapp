using System;
using Newtonsoft.Json;

namespace FESapp
{
    public class Subchapter
    {
        [JsonProperty(PropertyName = "id")]
        public string id { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string title { get; set; }

        [JsonProperty(PropertyName = "content")]
        public string content { get; set; }

        public int type { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public Url url { get; set; }
    }
}
