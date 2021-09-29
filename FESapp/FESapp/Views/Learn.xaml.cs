using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FESapp.ViewModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FESapp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Learn : ContentPage
    {
        public Learn()
        {
            InitializeComponent();
            BindingContext = new LearnViewModel();
        }

        //send appropriate learn module info to the module page
        private async void OnNavigationButtonClicked(Object sender, ItemTappedEventArgs e)
        {
               var chapter = e.Item as Chapter;
            await Navigation.PushAsync(new Module(chapter));
        }
    }


}

