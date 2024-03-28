namespace Exercises.S6
{
    public class Workflow : IWorkflow
    {
        private readonly List<IActivity> _activities;

        public void Run()
        {
            foreach (var activity in _activities)
            {
                activity.Execute();
            }
        }

        public void Run(IWorkflow workflow)
        {
            workflow.Run();
        }

        public Workflow()
        {
            _activities = new List<IActivity>();
        }

        public Workflow(List<IActivity> workflows)
        {
            _activities = new List<IActivity>();

            foreach (var workflow in workflows)
            {
                _activities.Add(workflow);
            }
        }
    }
}
