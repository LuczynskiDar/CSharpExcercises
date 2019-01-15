using System.Threading;

namespace CSharpExcercises
{
    public class ChangeVideoStatus : IExecutable
    {
        public void Execute(WorkFlow workFlow)
        {
            System.Console.WriteLine("Changing video status in user database.");
            Thread.Sleep(3000);
            System.Console.WriteLine("The video status has been changed to processing.");
        }
    }
}