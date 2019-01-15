using System.Threading;

namespace CSharpExcercises
{
    public class UploadVideoToCloud : IExecutable
    {
        public void Execute(WorkFlow workFlow)
        {
            System.Console.WriteLine("Uploading video to cloud .... please wait");
            Thread.Sleep(3000);
            System.Console.WriteLine("Your video is uploaded !!");
        }
    }
}