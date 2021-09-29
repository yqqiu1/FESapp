using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FESapp.ViewModel;
using FESapp.Views;

namespace FESapp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Answer : ContentPage
    {
        QuizModel quiz;
        int questionIndex;

        public Answer(QuizModel quiz, int questionIndex)
        {
            InitializeComponent();
            this.BindingContext = new AnswerViewModel(quiz, questionIndex);

            this.quiz = quiz;
            this.questionIndex = questionIndex;
        }

        //user has fininished reading the answer/explanation and wants to go to next quetion
        async void OnNextButton(object sender, EventArgs args)
        {
            //increment question count by one
            questionIndex++;

            //check to see if there is even a next question to display
            if (questionIndex < quiz.quizzes.Count)
            {
                //normal question coming up next
                if (quiz.quizzes[questionIndex].type == 1)
                {
                    await Navigation.PushAsync(new TextQuestion(quiz, questionIndex));
                }
                //video question coming up next
                else if (quiz.quizzes[questionIndex].type == 2)
                {
                    await Navigation.PushAsync(new VideoQuestion(quiz, questionIndex));
                }
                //image question coming up next
                else
                {
                    await Navigation.PushAsync(new ImageQuestion(quiz, questionIndex));
                }
            }

            //no more questions left to show
            else
            {
                //go back to home page
                await Navigation.PopToRootAsync();
            }
        }
    }
}