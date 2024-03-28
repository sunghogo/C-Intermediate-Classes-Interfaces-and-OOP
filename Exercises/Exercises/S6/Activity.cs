namespace Exercises.S6
{
    public class Activity : IActivity
    {
        private readonly string _activity;

        public void Execute()
        {
            Console.WriteLine($"Executing {_activity}...");
        }

        public Activity(string activity)
        {
            if (String.IsNullOrWhiteSpace(activity))
            {
                throw new ArgumentException(nameof(activity));
            }

            _activity = activity;
        }
    }
}
