using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FESapp.ViewModel;
using FESapp.FormsVideoLibrary;

namespace FESapp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VideoQuestion : ContentPage
    {
        int questionIndex;
        QuizModel quiz;

        public VideoQuestion(QuizModel quiz, int questionIndex)
        {
            InitializeComponent();
            this.BindingContext = new VideoQuestionViewModel(quiz, questionIndex);

            this.quiz = quiz;
            this.questionIndex = questionIndex;

            //setting video source in xaml
            videoPlayer.Source = VideoSource.FromUri(quiz.quizzes[questionIndex].url.url);
        }

        //upon user selecting an answer, display what the correct answer should be
        async void OnButtonAClicked(object sender, EventArgs args)
        {
            videoPlayer.Stop();
            await Navigation.PushAsync(new Answer(quiz, questionIndex));
        }
        async void OnButtonBClicked(object sender, EventArgs args)
        {
            videoPlayer.Stop();
            await Navigation.PushAsync(new Answer(quiz, questionIndex));
        }
        async void OnButtonCClicked(object sender, EventArgs args)
        {
            videoPlayer.Stop();
            await Navigation.PushAsync(new Answer(quiz, questionIndex));
        }
        async void OnButtonDClicked(object sender, EventArgs args)
        {
            videoPlayer.Stop();
            await Navigation.PushAsync(new Answer(quiz, questionIndex));
        }
    }
}