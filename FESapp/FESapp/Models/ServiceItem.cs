using System;
namespace FESapp
{
    public class ServiceItem
    {
        public string title { get; set; }
        public string content { get; set; }

        public ServiceItem(string title, string content)

        {
            this.title = title;
            this.content = content;
        }


    }
}
