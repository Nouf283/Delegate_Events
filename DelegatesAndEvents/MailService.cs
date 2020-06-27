using System;

namespace DelegatesAndEvents
{
    public class MailService{

        public void OnVideoEncoded(object source,Videoargs e)
        {
            Console.WriteLine("Mailservice: sending an email: "+ e.Videos.title);
        }
    }

    public class MessageService
    {

        public void OnVideoEncoded(object source, Videoargs e)
        {
            Console.WriteLine("Messageservice: sending an email:"+e.Videos.title);
        }
    }
}
