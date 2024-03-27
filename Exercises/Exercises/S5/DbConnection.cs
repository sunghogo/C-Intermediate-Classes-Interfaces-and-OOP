using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.S5
{
    public abstract class DbConnection
    {
        private string ConnectionString { get; set; }
        private TimeSpan Timeout { get; set; }

        public DbConnection(string? connectionString)
        {
            if (String.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentException(nameof(connectionString));
            }

            ConnectionString = connectionString;
            Timeout = TimeSpan.FromSeconds(10);
        }

        public abstract void Open();
        public abstract void Close();

        public string GetConnectionString()
        {
            return ConnectionString;
        }
    }
}
