using System;
using System.Collections.Generic;
using System.Text;

namespace FESapp.ViewModel
{
    class ImageQuestionViewModel
    {

        public QuizModel quiz { get; }
        int questionIndex;
        int numQuestions;
        private string question;
        private string answerA;
        private string answerB;
        private string answerC;
        private string answerD;

        public ImageQuestionViewModel(QuizModel quiz, int questionIndex)
        {
            //assigning instance variables for reference by other methods
            this.quiz = quiz;
            this.questionIndex = questionIndex;

            //displaying questions
            renderQuestions();
        }

        public void renderQuestions()
        {
            question = quiz.quizzes[questionIndex].question;
            answerA = quiz.quizzes[questionIndex].answerA;
            answerB = quiz.quizzes[questionIndex].answerB;
            answerC = quiz.quizzes[questionIndex].answerC;
            answerD = quiz.quizzes[questionIndex].answerD;
        }

        //changes the question and answer strings
        public string Question => question;
        public string AnswerA => answerA;
        public string AnswerB => answerB;
        public string AnswerC => answerC;
        public string AnswerD => answerD;
    }
}
