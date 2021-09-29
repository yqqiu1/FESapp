using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FESapp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ServicesPage : ContentPage
    {
        public ObservableCollection<ServiceItem> Items { get; set; }

        public ServicesPage()
        {

            InitializeComponent();

            Items = new ObservableCollection<ServiceItem>
            {
                new ServiceItem("Equipment","Installation, Maintenance, and Inspection of:\nFire Indicator Panels (FIP),Alarm Signalling Equipment (ASE),Emergency Warning Intercom Systems (EWIS),Fire Sprinkler Systems,Special Hazard Systems,Project and Contract Capabilities,AESMR,Portable Fire Fighting Equipment,Means of Egress Items,Passive Fire & Smoke Systems,Emergency and Exit Lighting,Evacuation Plans,Building Fire Integrity Inspections"),
                new ServiceItem("Emergency Training","Installation, Maintenance, and Inspection"),
                new ServiceItem("Workshop","Installation, Maintenance, and Inspection"),

            };

            MyListView.ItemsSource = Items;
        }


    }


}
