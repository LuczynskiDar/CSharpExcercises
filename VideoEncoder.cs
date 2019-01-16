using System.Threading;
using System;

namespace CSharpExcercises
{
    public class VideoEncoder
    {
        // 1. Define Delegate
        // 2. Define Event based on that delegate
        // 3. Raise the Event

        public delegate void VideoEncoderEventHandler(object source, EventArgs args);

        public void Encode(Video video)
        {
            
            System.Console.WriteLine("Video being encoded ...");
            Thread.Sleep(3000);

        }
    }
}