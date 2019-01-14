using System.Collections.Generic;

namespace CSharpExcercises
{
    public class WorkFlowEngine : IRunnable
    {
        private readonly List<IExecutable> _flows;

        public WorkFlowEngine()
        {
            _flows = new List<IExecutable>();
        }

        public void Run()
        {
            foreach (var flow in _flows)
            {
                flow.Execute();
            }
        }
    }
}