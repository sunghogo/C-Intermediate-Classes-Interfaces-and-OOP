using System.Diagnostics;

namespace Exercises.S6
{
    public class Workflow : IWorkflow
    {
        private readonly List<IActivity> _activities;

        public Workflow()
        {
            _activities = new List<IActivity>();
        }

        public Workflow(List<IActivity> activities)
        {
            _activities = new List<IActivity>();

            if (activities is null)
            {
                throw new ArgumentNullException(nameof(activities));
            }

            foreach (var activity in activities)
            {
                if (activity is null)
                {
                    throw new ArgumentNullException(nameof(activity));
                }
                _activities.Add(activity);
            }
        }

        public void Run()
        {
            for (int i = 0; i < _activities.Count; )
            {
                var activity = _activities[i];
                activity.Execute();
                _activities.Remove(activity);
            }
        }

        public void Run(IActivity activity)
        {
            activity.Execute();
        }

        public void Add(IActivity activity)
        {
            if (activity is null)
            {
                throw new ArgumentNullException(nameof(activity));
            }
            _activities.Add(activity);
        }

        public void Remove(IActivity activity)
        {
            if (activity is null)
            {
                throw new ArgumentNullException(nameof(activity));
            }
            _activities.Remove(activity);
        }
    }
}
