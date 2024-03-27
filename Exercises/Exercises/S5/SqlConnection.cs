using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.S5
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string? connectionString)
            : base(connectionString) { }

        public override void Open()
        {
            Console.WriteLine($"Opening SQL connection to {this.GetConnectionString()}");
        }

        public override void Close()
        {
            Console.WriteLine($"Closing SQL connection {this.GetConnectionString()}");
        }
    }
}
