using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FESapp.ViewModel;

namespace FESapp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageQuestion : ContentPage
    {
        int questionIndex;
        QuizModel quiz;

        public ImageQuestion(QuizModel quiz, int questionIndex)
        {
            InitializeComponent();
            this.BindingContext = new ImageQuestionViewModel(quiz, questionIndex);

            this.quiz = quiz;
            this.questionIndex = questionIndex;

            //setting image source in xaml
            Image.Source = quiz.quizzes[questionIndex].url.url;
        }

        //upon user selecting an answer, display what the correct answer should be
        async void OnButtonAClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Answer(quiz, questionIndex));
        }
        async void OnButtonBClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Answer(quiz, questionIndex));
        }
        async void OnButtonCClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Answer(quiz, questionIndex));
        }
        async void OnButtonDClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Answer(quiz, questionIndex));
        }



        public async void OnHomeButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
        public async void OnHelpButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyPage());
        }


    }
}