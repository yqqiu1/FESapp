using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FESapp
{
    public class Chapter
    {
        [JsonProperty(PropertyName = "id")]
        public string id { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string title { get; set; }

        [JsonProperty(PropertyName = "content")]
        public string content { get; set; }

        

        public DateTime created_at { get; set; }

        public DateTime updated_at { get; set; }

        [JsonProperty(PropertyName = "subchapters")]
        public List<Subchapter> subchapters { get; set; }

        public ChapterModel tochapterModel()
        {
            return new ChapterModel(id,title,content);
        }
    }
}
