using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FESapp.ViewModel
{
    public class CheckListViewModel : ViewModelBase
    {
        private ApiService service;
        public List<Checklists> checklists = new List<Checklists>();
        public Checklists currentChecklistitem
        {
            get { return internalChecklistitem; }
            set { SetProperty(ref internalChecklistitem, value); }
        }
        
        private Checklists internalChecklistitem;
        
        private int index = 0;
        public CheckListViewModel()
        {
            service = NetworkService.getApiService();
            currentChecklistitem = new Checklists();
            currentChecklistitem.question = "asda";
            
        }

        public void getChecklists()
        {
            
            service.getchecklists().ContinueWith(response=>{
                checklists = response.Result;
                next();

            }, TaskScheduler.FromCurrentSynchronizationContext()).ConfigureAwait(false);
        }

        public void next()
        {
            if (index < (checklists.ToArray().Length - 1))
            {
                currentChecklistitem = checklists.ToArray()[index];
               

                index++;
            }
            else
            {

            }
           
        }
    }
}

