using System;
using System.Collections.Generic;
using System.Text;
using Refit;

namespace FESapp
{
    public class QuizModel
    {
        

        public string quizName { get { return TestName; } set { quizName = value; } }
        public string TestName { get; set; }

        [AliasAs("quizzes")]
        public List<QuestionTemplateModel> quizzes { get; set; }
    }
}