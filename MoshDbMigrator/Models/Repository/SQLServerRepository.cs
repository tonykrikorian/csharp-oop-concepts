using System;

namespace MoshDbMigrator.Models.Repository
{
    public class SQLServerRepository : IGetRepository
    {
        public void GetAll()
        {
            Console.WriteLine("Get all records from SQL Server");
        }

        public void GetById(string id)
        {
            Console.WriteLine($"Get record with id:{id} from SQL Server");
        }
    }
}
