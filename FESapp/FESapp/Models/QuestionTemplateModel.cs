using System;
using System.Collections.Generic;
using System.Text;

namespace FESapp
{
    public class QuestionTemplateModel
    {
        public string id { get; set; }
        public int type { get; set; }
        public Url url { get; set; }
        public string question { get; set; }
        public string answerA { get; set; }
        public string answerB { get; set; }
        public string answerC { get; set; }
        public string answerD { get; set; }
        public string correctAnswer { get; set; }
    }
}
