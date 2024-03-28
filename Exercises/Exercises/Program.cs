using Exercises.S5;
using Exercises.S6;
using System.Threading.Channels;

namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? input = "";

            while (input != "q")
            {
                Console.WriteLine(
                    "Please enter which section number to run execises for, or 'q' to exit: "
                );
                input = Console.ReadLine().ToLower().Trim();

                switch (input)
                {
                    case "2":
                        // S2 Exercises
                        var stopwatch = new S2.Stopwatch();
                        var post = new S2.Post("First Post", ":D");
                        break;
                    case "4":
                        // S4 Exercises
                        var stack = new S4.Stack();
                        stack.Push(1);
                        stack.Push(2);
                        stack.Push(3);
                        stack.Display();

                        Console.WriteLine(stack.Pop());
                        Console.WriteLine(stack.Pop());
                        Console.WriteLine(stack.Pop());
                        stack.Display();

                        stack.Push(1);
                        stack.Push(2);
                        stack.Push(3);
                        stack.Display();
                        stack.Clear();
                        stack.Display();
                        break;
                    case "5":
                        // S5 Exercises
                        var sqlConnection = new SqlConnection("Some SQL connection string");
                        var oracleConnection = new OracleConnection(
                            "Some Oracle connection string"
                        );

                        var dbCommandSql = new DbCommand(sqlConnection);
                        dbCommandSql.Execute("Some SQL execution command");

                        var dbCommandOracle = new DbCommand(oracleConnection);
                        dbCommandOracle.Execute("Some Oracle execution command");
                        break;
                    case "6":
                        // S6 Exercises
                        var workflow = new Workflow(
                            new List<IActivity>
                            {
                                new Activity("Upload a video to a cloud storage"),
                                new Activity(
                                    "Call a web service provided by a third-party video encoding service to tell them you have a video ready for encoding"
                                ),
                                new Activity(
                                    "Send an email to the owner of the video notifying them that the video started processing"
                                ),
                                new Activity(
                                    "Change the status of the video record in the database to \"Processing\""
                                )
                            }
                        );
                        var engine = new Engine(new List<IWorkflow>() { workflow });
                        engine.Run();
                        break;
                }
            }
        }
    }
}
