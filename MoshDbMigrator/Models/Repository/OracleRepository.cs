using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshDbMigrator.Models.Repository
{
    public class OracleRepository : IGetRepository
    {
        public void GetAll()
        {
            Console.WriteLine("Get All Data From Oracle");
        }

        public void GetById(string id)
        {
            Console.WriteLine($"Get record with Id:{id} from Oracle");
        }
    }
}
