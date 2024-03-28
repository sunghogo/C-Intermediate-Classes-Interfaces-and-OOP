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

        public Engine()
        {
            _workflows = new List<IWorkflow>();
        }

        public Engine(List<IWorkflow> workflows)
        {
            _workflows = new List<IWorkflow>();

            if (workflows is null)
            {
                throw new ArgumentNullException(nameof(workflows));
            }

            foreach (var workflow in workflows)
            {
                if (workflow is null)
                {
                    throw new ArgumentNullException(nameof(workflow));
                }
                _workflows.Add(workflow);
            }
        }

        public void Run()
        {
            for (int i = 0; i < _workflows.Count; )
            {
                var workflow = _workflows[i];
                workflow.Run();
                _workflows.Remove(workflow);
            }
        }

        public void Run(IWorkflow workflow)
        {
            workflow.Run();
        }

        public void Add(IWorkflow workflow)
        {
            if (workflow is null)
            {
                throw new ArgumentNullException(nameof(workflow));
            }
            _workflows.Add(workflow);
        }

        public void Remove(IWorkflow workflow)
        {
            if (workflow is null)
            {
                throw new ArgumentNullException(nameof(workflow));
            }
            _workflows.Remove(workflow);
        }
    }
}
