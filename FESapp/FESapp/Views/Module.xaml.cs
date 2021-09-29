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
    public partial class Module : ContentPage
    {
        Chapter chapter;
        int index = 0;

    public Module(Chapter chapter)
        {

            this.chapter = chapter;
            InitializeComponent();


            updatechapter();

        }

        private async void onClickNext(object sender, EventArgs e)
        {
            if(index != (chapter.subchapters.ToArray().Length -1))
            {
                updatechapter();
            }
            else
            {
                await Navigation.PushAsync(new MainPage());
            }
          

        }
        public void updatechapter()
        {
            Subchapter subchapter = chapter.subchapters.ToArray()[index];
            BindingContext = subchapter;
            index++;
        }

    }
}