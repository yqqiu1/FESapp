using System;
using System.Collections.Generic;
using System.Text;

namespace FESapp.ViewModel
{
    class AnswerViewModel
    {

        public QuizModel quiz { get; }
        private string answer;

        public AnswerViewModel(QuizModel quiz, int questionIndex)
        {
            //assigning instance variables for reference by other methods
            this.quiz = quiz;

            //assigning answer variable to correct answer
            answer = quiz.quizzes[questionIndex].correctAnswer;
        }

        //binding answer to xaml
        public string CorrectAnswer => answer;
    
    }
}
