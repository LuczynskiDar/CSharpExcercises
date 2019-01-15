using System.Threading;

namespace CSharpExcercises
{
    public class SendEmailToOwner: IExecutable
    {
        public void Execute(WorkFlow workFlow)
        {
            System.Console.WriteLine("Dear user, the encoding of your video was initiated.");
            Thread.Sleep(3000);
        }
    }
}