using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshDbMigrator.Models.WorkflowEngine.Activities
{
    public class HttpRequestActivity : IActivity
    {
        

        public void Execute()
        {
            Console.WriteLine("Calling HTTP Service");    
        }
    }
}
