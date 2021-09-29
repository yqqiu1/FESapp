using System;
namespace FESapp
{
public class Url
    {
        public string id { get; set; }
        public string name { get; set; }
        public string hash { get; set; }
        public string sha256 { get; set; }
        public string ext { get; set; }
        public string mime { get; set; }
        public string size { get; set; }
        public string url { get; set; }
        public string provider { get; set; }
        public object public_id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
