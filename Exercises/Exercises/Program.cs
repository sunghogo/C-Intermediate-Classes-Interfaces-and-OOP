using Exercises.S5;

namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // S2 Exercises
            //var stopwatch = new S2.Stopwatch();
            //var post = new S2.Post("First Post", ":D");

            // S4 Exercises
            //var stack = new S4.Stack();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Display();

            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //stack.Display();

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Display();
            //stack.Clear();
            //stack.Display();

            // S5 Exercises
            var sqlConnection = new SqlConnection("Some SQL connection string");
            var oracleConnection = new OracleConnection("Some Oracle connection string");

            var dbCommandSql = new DbCommand(sqlConnection);
            dbCommandSql.Execute("Some SQL execution command");

            var dbCommandOracle = new DbCommand(oracleConnection);
            dbCommandOracle.Execute("Some Oracle execution command");
        }
    }
}
