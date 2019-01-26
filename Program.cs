using System;

namespace CSharpExcercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video(){Title = "Video1"};
            var videoEncoder = new VideoEncoder(); // publisher
            var mailService = new MailService(); // subscriber
            var messageService = new MessageService();    
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            Console.WriteLine("Hello World!");

            videoEncoder.Encode(video);
        }
    }
}
