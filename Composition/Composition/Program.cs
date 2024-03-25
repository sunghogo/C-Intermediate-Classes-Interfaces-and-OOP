namespace Composition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dbMigratorer = new DBMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigratorer.Migrate();

            installer.Install();
        }
    }
}
