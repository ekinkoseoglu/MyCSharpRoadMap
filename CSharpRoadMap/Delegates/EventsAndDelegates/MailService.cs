using System;

namespace EventsAndDelegates
{
    public class MailService // This class responsible for sending Email once the Video has encoded
    {
        public void OnVideoEncoded(object source, VideoEventArgs e) //Create publisher method of event (but not subscripted yet...)
        {
            Console.WriteLine("MailService: Sending an email..." + e.Video.Title);
        }
    }
}