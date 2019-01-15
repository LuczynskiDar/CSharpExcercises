using System.Collections.Generic;

namespace CSharpExcercises
{
    public class WorkFlowEngine : IRunnable
    {
        private readonly List<IExecutable> _works;

        public WorkFlowEngine()
        {
            _works = new List<IExecutable>();
        }

        public void Run(Video video)
        {
            foreach (var work in _works)
            {
                work.Execute(new WorkFlow());
            }
        }

        public void RegisterWork(IExecutable work)
        {
                _works.Add(work);
        }
    }
}