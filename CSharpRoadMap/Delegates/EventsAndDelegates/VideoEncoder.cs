using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
   public class VideoEncoder
    {

        // 1- Define a delegate (Conctract between the publisher and the subscriber) (Determines signiture of the method in the subscriber)
        // 2- Define an Event based on that delegate
        // 3- Raise/Publish the event

        // public delegate void VideoEncodedEventHandler(object source, VideoEventArgs e); //Delegate name creates based on "eventname"+EventHandler

        public event EventHandler<VideoEventArgs> VideoEncoded;

        //EventHandler
        //EventHandler<TEventArgs>

        //public event VideoEncodedEventHandler VideoEncoded; // create event base above the delegate

        // OR

        // public event EventHandler<VideoEventArgs> VideoEncoded;  

        public void Encode(Video video)
        {
            // encoding logic...
            //..

            Console.WriteLine("Video encoding...");
            Thread.Sleep(3000);


            OnVideoEncoded(video); // After code has finished we just need to call this method
        }

        protected virtual void OnVideoEncoded(Video video) // event publisher method should be protected, virtual, void and its name should starts with On+"eventname"   
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this,new VideoEventArgs(){Video = video}); // this class based of this method so we clarify source as "this" class
            }
        }
    }
}
