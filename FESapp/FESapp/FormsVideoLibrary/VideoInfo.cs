using System;
using System.Collections.Generic;
using System.Text;
using FESapp.FormsVideoLibrary;


namespace FESapp.FormsVideoLibrary
{
    public class VideoInfo
    {
        public string DisplayName { set; get; }

        public VideoSource VideoSource { set; get; }

        public override string ToString()
        {
            return DisplayName;
        }

    }
}
