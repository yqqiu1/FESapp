using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FESapp.ViewModel
{
    public class LearnViewModel : ContentPage
    {
        public ObservableCollection<Chapter> ChapterList { get; set; }

        public LearnViewModel()
        {
            
            ChapterList = new ObservableCollection<Chapter>();
           
            
            //take JSON file for "Learn" and convert it into a "Course" object


            //load each chapter into listview

            System.Diagnostics.Debug.WriteLine("test data");

            // Get result and update any UI here.
            
            NetworkService.getApiService().getchapter().ContinueWith(respose =>
            {
                
                
                System.Diagnostics.Debug.WriteLine(respose.IsCompleted +" "+ respose.Status);



                // Get result and update any UI here.
                var chapters = respose.Result;
                
                foreach (var chap in chapters)
                    {
                    
                    System.Diagnostics.Debug.WriteLine(chap.title);

                        ChapterList.Add(chap);
                    }
                  
                

            }, TaskScheduler.Current).ConfigureAwait(false);
            }
        }

    }


