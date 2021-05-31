using System;

namespace MoshDbMigrator.Models.WorkflowEngine.Activities
{
    public class SendEmailActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Send an Email Activity");
        }
    }
}
