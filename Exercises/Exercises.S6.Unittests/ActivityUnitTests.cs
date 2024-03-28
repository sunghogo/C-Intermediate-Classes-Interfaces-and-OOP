namespace Exercises.S6.Unittests
{
    [TestClass]
    public class ActivityUnitTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Activity_ArgIsNull_ThrowsAnException()
        {
            new Activity(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Activity_ArgIsEmpty_ThrowsAnException()
        {
            new Activity("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Activity_ArgIsWhiteSpace_ThrowsAnException()
        {
            try
            {
                new Activity(" ");
            }
            catch (ArgumentException)
            {
                new Activity("\t");
            }
        }

        [TestMethod]
        public void Activity_ArgIsValidString_Passes()
        {
            new Activity("Valid activity");
        }

        [TestMethod]
        public void Execute_WritesToConsole_Passes()
        {
            using (StringWriter stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);

                string activityName = "Some activity";
                var activity = new Activity(activityName);
                activity.Execute();

                string capturedOut = stringWriter.ToString();
                string expectedOut = $"Executing {activityName}...";
                if (capturedOut.ToLower().Trim() != expectedOut.ToLower().Trim())
                {
                    throw new Exception(
                        $"Activity does not properly write to console. Captured console write: {capturedOut}"
                    );
                }
            }
        }
    }
}
