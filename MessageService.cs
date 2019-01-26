using System;

namespace CSharpExcercises
{
    internal class MessageService
    {

        public void OnVideoEncoded(Object obj, VideoEventArgs e) 
            => System.Console.WriteLine("Sending a message..." + e.Video.Title);

    }
}