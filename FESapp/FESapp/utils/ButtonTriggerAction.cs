using System;
using Xamarin.Forms;

namespace FESapp.utils
{
    public class ButtonTriggerAction : TriggerAction<VisualElement>
    {
        
        public Color BackgroundColor { get; set; }

        protected override void Invoke(VisualElement sender)
        {
            var button = sender as Button;
            if (button == null) return;
            if (BackgroundColor != null) button.BackgroundColor = BackgroundColor;
        }
    }
}
