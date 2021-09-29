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
    public partial class TextQuestion : ContentPage
    {
        QuizModel quiz;
        int questionIndex;

        public TextQuestion(QuizModel quiz, int questionIndex)
        {
            InitializeComponent();
            this.BindingContext = new TextQuestionViewModel(quiz, questionIndex);

            this.quiz = quiz;
            this.questionIndex = questionIndex;
        }

        async void OnButtonAClicked (object sender, EventArgs args)
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
    }
}