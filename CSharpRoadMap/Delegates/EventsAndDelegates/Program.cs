namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() {Title = "Video 1"}; 
            var videoEncoder = new VideoEncoder(); // Publisher
            var mailService = new MailService(); //subscriber

            //Before we call the Encode method we needed to do subscription (21. satır)
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; // Starts with a publisher.Event and (+=) is for register publishermethod in MailService to Event in Publisher class 
            var messageService = new MessageService(); // subscriber
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded; // method çağırmıyorum, referans ekliyorum o yüzden "()" kullanılmıyor sadece isim yazılıyor
            videoEncoder.Encode(video);
        }
    }
}
