using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.S5
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string? connectionString)
            : base(connectionString) { }

        public override void Open()
        {
            Console.WriteLine($"Opening Oracle connection {this.GetConnectionString()}");
        }

        public override void Close()
        {
            Console.WriteLine($"Closing Oracle connection {this.GetConnectionString()}");
        }
    }
}
