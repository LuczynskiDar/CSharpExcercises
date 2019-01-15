using System;

namespace CSharpExcercises
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Starting the flow process....");
            var workFlowEngine = new WorkFlowEngine();   
            workFlowEngine.RegisterWork(new UploadVideoToCloud());
            workFlowEngine.RegisterWork(new CallWebServiceToEncode());
            workFlowEngine.Run(new Video());
            System.Console.WriteLine("Done!");
        }
    }
}
