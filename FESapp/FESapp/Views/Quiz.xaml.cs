using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FESapp.ViewModel;
using FESapp.Views;
using XFGloss;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FESapp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Quiz : ContentPage
    {
        public Quiz()
        {
            InitializeComponent();
            this.BindingContext = new QuizViewModel();
            //get rid of navigation bar, it messes with the UI/doesn't really work so we replaced it with our own implementation of sorts 
            NavigationPage.SetHasNavigationBar(this, false);
        }

        public async void OnQuizSelected(object sender, SelectionChangedEventArgs e)
        {
            //only passes the set of questions belonging to the quiz that user tapped on
            
            var quiz = e.CurrentSelection.FirstOrDefault() as QuizModel;
         
            //checking what type of question the first question is. Load different page based on that.
            //normal question
            if (quiz.quizzes[0].type == 1)
            {
               await  Navigation.PushAsync(new TextQuestion(quiz, 0));
            }
            //video question
            else if (quiz.quizzes[0].type == 2)
            {
                await Navigation.PushAsync(new VideoQuestion(quiz, 0));
            }
            //image question
            else
            {
                await Navigation.PushAsync(new ImageQuestion(quiz, 0));
            }
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