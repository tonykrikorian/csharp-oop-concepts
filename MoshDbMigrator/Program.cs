using MoshDbMigrator.Models;
using MoshDbMigrator.Models.Encoder;
using MoshDbMigrator.Models.Repository;
using MoshDbMigrator.Models.WorkflowEngine;
using MoshDbMigrator.Models.WorkflowEngine.Activities;
using System;

namespace MoshDbMigrator
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonData();
            Console.ReadKey();
        }

        static void PersonData() 
        {
            var person = new Person("Tony","Krikorian",new DateTime(1985,6,28));

            Console.WriteLine(person.GetAge());
            Console.WriteLine(person.GetFullanme());
            
        }
        static void WorkFlowEngineRunner() 
        {
            
            try
            {
                var workflow = new WorkflowEngine(new FileLogger("C:\\projects\\log.txt"));
                workflow.SetActivities(new SendEmailActivity());
                workflow.SetActivities(new HttpRequestActivity());

                workflow.Run();
            }
            catch (InvalidOperationException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        static void DbMigrator() 
        {
            var dbMigrator = new DbMigrator(new FileLogger("C:\\projects\\log.txt"));
            dbMigrator.Migrate();
        }

        static void VideoEncoder() 
        {
            var videoEncode = new VideoEncoder();
            videoEncode.AddNotificationChannel(new TwitterNotificationChannel("@TK_850"));
            videoEncode.AddNotificationChannel(new SlackNotificationChannel("tkrikoriam","Developers"));
            videoEncode.Encode(new Video());
        }
    }
}
