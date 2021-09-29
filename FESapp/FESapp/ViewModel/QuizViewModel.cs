using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using Xamarin.Forms;
using FESapp.Models;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using FESapp.Views;
using System.Threading.Tasks;

namespace FESapp.ViewModel
{
    class QuizViewModel : ContentPage, INotifyPropertyChanged
    {
        private QuizRootObject questionList;
        public ObservableCollection<QuizModel> questionListObservable { get; set; }

        public QuizViewModel()
        {
            questionListObservable = new ObservableCollection<QuizModel>();
            NetworkService.getApiService().getTests().ContinueWith(respose =>
            {
                if (respose.IsCompleted && respose.Status == TaskStatus.RanToCompletion)
                {

                    // Get result and update any UI here.
                    var tests = respose.Result;

                    foreach (var test in tests)
                    {
                        questionListObservable.Add(test);
                    }
                }

            }, TaskScheduler.FromCurrentSynchronizationContext()).ConfigureAwait(false);
        }
    }
    }

