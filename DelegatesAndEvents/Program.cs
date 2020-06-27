using System;

namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {

            var video = new Video() { title = "Video 1" };
            var videoencoder = new VideoEncoder();
            MailService ms = new MailService();
            MessageService mt = new MessageService();
            videoencoder.videoEncoded += ms.OnVideoEncoded;
            videoencoder.videoEncoded += mt.OnVideoEncoded;
            videoencoder.Encode(video);

            Console.WriteLine("Hello World!");
        }
    }

  
}
