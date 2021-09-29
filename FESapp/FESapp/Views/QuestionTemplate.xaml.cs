using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FESapp.Models;
using FESapp.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FESapp.FormsVideoLibrary;

namespace FESapp.Views
{
    public partial class QuestionTemplate : ContentPage
    {
        public QuestionTemplate(QuizModel quiz)
        {
            InitializeComponent();
            this.BindingContext = new QuestionTemplateViewModel(quiz);
        }
            
        async void OnButtonAClicked(object sender, EventArgs args)
        {
            //await Navigation.PushAsync(new MainPage());
        }
        async void OnButtonBClicked(object sender, EventArgs args)
        {
           // await Navigation.PushAsync(new MainPage());
        }
        async void OnButtonCClicked(object sender, EventArgs args)
        {
           // await Navigation.PushAsync(new MainPage());
        }
        async void OnButtonDClicked(object sender, EventArgs args)
        {
           // await Navigation.PushAsync(new MainPage());
        }
    }
}