using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FESapp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FireSafetyInformation : ContentPage
    {
        public FireSafetyInformation()
        {
            InitializeComponent();
        }

        private async void OnMainPageImageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void OnHelpFSIImageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FireSafetyInformationHelp());
        }

        private async void OnIMImageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InformationModule());
        }
        private async void OnBSCImageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BuildingSafetyCheckList());
        }
    }
}