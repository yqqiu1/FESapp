using System;
namespace FESapp
{
    public class HelpItem
    {
        public string title { get; set; } = "Title";
        public string content { get; set; } = "content loresm ipsumasdsandalsdnaskdnaskdnaskdnskdnskndskndskndskndsnkdnskdnskdsd";
        public Xamarin.Forms.ImageSource imageUri { get; set; } = Xamarin.Forms.ImageSource.FromResource("FESapp.feslogo.png");


        public HelpItem(string title, string content, Xamarin.Forms.ImageSource imageUri)
        {
            this.title = title;
            this.content = content;
            this.imageUri = imageUri;
        }

        public HelpItem()
        {

        }
    }
}
