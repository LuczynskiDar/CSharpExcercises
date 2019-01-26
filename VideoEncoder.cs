using System.Threading;
using System;

namespace CSharpExcercises
{
    public class VideoEventArgs: EventArgs
    {
     public Video Video { get; set; }
    }
    public class VideoEncoder
    {
        // 1. Define Delegate
        // 2. Define Event based on that delegate
        // 3. Raise the Event

        public delegate void VideoEncodingEventHandler(object source, VideoEventArgs args);
        public event VideoEncodingEventHandler VideoEncoding;

        public EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            
            System.Console.WriteLine("Video being encoded ...");
            Thread.Sleep(3000);
            
            OnVideoEncoded(video);

        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if(VideoEncoded!=null)
                VideoEncoded(this, new VideoEventArgs(){Video = video});
        }
    }
}