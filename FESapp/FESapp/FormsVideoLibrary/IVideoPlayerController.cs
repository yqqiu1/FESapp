using System;
using System.Collections.Generic;
using System.Text;

namespace FESapp.FormsVideoLibrary
{
    public interface IVideoPlayerController
    {
        VideoStatus Status { set; get; }

        TimeSpan Duration { set; get; }
    }
}
