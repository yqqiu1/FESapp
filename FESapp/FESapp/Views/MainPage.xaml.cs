using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using FESapp.Views;

namespace FESapp
{
    [DesignTimeVisible(false)]
    //main menu page which contains buttons linking to the three other sections of the application
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //button linking to Fire Safety Information
        private async void QuizButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Quiz());
        }

        //button linking to Quiz
        private async void LearnButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Learn());
        }

        //button linking to About FES
        private async void AboutFESButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutFESTabbed());
        }

        private async void checklistClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChecklistPage());
        }
    }
}
