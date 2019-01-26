using System;

namespace CSharpExcercises
{
    public class MailService
    {
            public void OnVideoEncoded(Object obj, VideoEventArgs e)
            {
                System.Console.WriteLine("Sending an email..." + e.Video.Title);
            }
    }
}