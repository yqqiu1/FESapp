using System;
namespace FESapp
{
    public class Checklists
    {
        public string _id { get; set; }
        public string question { get; set; }
        public string correct_answer { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public int __v { get; set; }
        public Url url { get; set; }
        public string id { get; set; }
    }
}
