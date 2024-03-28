using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Extensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        // Dependency Injection of passing dependency through constructor argument
        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo($"Migrating started at {DateTime.Now}");

            // Details of migrating the database

            _logger.LogInfo($"Migrating finished at {DateTime.Now}");
        }
    }
}
