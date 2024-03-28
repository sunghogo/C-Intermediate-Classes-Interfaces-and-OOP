namespace Extensibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new ConsoleLogger());
            dbMigrator.Migrate();

            // Open-Closed Principle (OCP): Changing the behavior by extending the code (open to extension using interfaces but closed for modification)
            var dbMigrator2 = new DbMigrator(new FileLogger(@"C:\temp\testLog.txt"));
            dbMigrator2.Migrate();
        }
    }
}
