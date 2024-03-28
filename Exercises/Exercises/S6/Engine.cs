using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.S6
{
    public class Engine
    {
        private readonly List<IWorkflow> _workflows;

        public void Run()
        {
            foreach (var workflow in _workflows)
            {
                workflow.Run();
            }
        }

        public void Run(IWorkflow workflow)
        {
            workflow.Run();
        }

        public Engine()
        {
            _workflows = new List<IWorkflow>();
        }

        public Engine(List<IWorkflow> workflows)
        {
            _workflows = new List<IWorkflow>();

            foreach (var workflow in workflows)
            {
                _workflows.Add(workflow);
            }
        }
    }
}
