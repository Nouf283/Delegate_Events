using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DelegatesAndEvents
{
    public class Videoargs : EventArgs
    {
        public Video Videos { get; set; }
    }

    class VideoEncoder
    {
        public delegate void VideoAndEventHandlers(object source, Videoargs e);
        public event VideoAndEventHandlers videoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video.....");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }
        
        protected virtual void OnVideoEncoded(Video video)
        {
            //if (videoEncoded != null)
            //    videoEncoded(this, new Videoargs() {Videos=video});
            videoEncoded?.Invoke(this, new Videoargs() { Videos = video });

        }
    }
}
