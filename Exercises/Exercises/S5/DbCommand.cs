using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Exercises.S5
{
    public class DbCommand
    {
        private DbConnection DbConnection { get; set; }

        public DbCommand(DbConnection dbConnection)
        {
            if (dbConnection is null)
            {
                throw new ArgumentNullException(nameof(dbConnection));
            }

            DbConnection = dbConnection;
        }

        public void Execute(string? instruction)
        {
            DbConnection.Open();
            Console.WriteLine($"Executing {instruction}...");
            DbConnection.Close();
        }
    }
}
