using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshDbMigrator.Models
{
    public class DbMigrator
    {
        private ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate() 
        {
            _logger.LogInfo($"Migration starts at {DateTime.Now}");

            _logger.LogInfo($"Migration finishs at {DateTime.Now}");
        }
    }
}
