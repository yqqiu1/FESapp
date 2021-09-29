using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FESapp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutFESTabbed : TabbedPage
    {
        public AboutFESTabbed()
        {
            InitializeComponent();
        }


        private async void OnVistWebButtonClicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://www.fes.com.au/www/");
            await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);

        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://www.fes.com.au/c/login/");
            await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }

        private async void OnServicesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ServicesPage());
        }
    }
}