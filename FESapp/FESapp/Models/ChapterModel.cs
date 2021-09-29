using System;
using System.Collections.Generic;
using System.Text;

namespace FESapp
{
public class ChapterModel
    {
        public ChapterModel(string id, string title, string content)
        {
            this.id = id;
            this.title = title;
            this.content = content;
        }

        public string id { get; set; }
        public string title { get; set; }
        public string content { get; set;  }

    }
}
