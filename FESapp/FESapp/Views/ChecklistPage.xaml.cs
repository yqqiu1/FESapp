using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FESapp.ViewModel;
using Xamarin.Forms;

namespace FESapp.Views
{
    public partial class ChecklistPage : ContentPage
    {
       


       

        CheckListViewModel viewmodel;
        public ChecklistPage()
        {

            InitializeComponent();
             viewmodel = new CheckListViewModel();
            viewmodel.getChecklists();
            BindingContext = viewmodel;
            



        }

       

        private async void onClickNext(object sender, EventArgs e)
        {
            OnPropertyChanged(nameof(viewmodel.currentChecklistitem));
            viewmodel.next();
           


        }


    }
    
}
