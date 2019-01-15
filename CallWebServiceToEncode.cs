using System.Threading;

namespace CSharpExcercises
{
    public class CallWebServiceToEncode : IExecutable
    {
        public void Execute(WorkFlow workFlow)
        {
            
            System.Console.WriteLine("Calling Web service to encode the video .... please wait");
            Thread.Sleep(4000);
            System.Console.WriteLine("Your video is encoded !!");
        }

    }
}