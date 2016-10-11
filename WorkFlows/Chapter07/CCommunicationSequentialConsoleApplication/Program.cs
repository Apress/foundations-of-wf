#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Workflow.Runtime;
using System.Workflow.Runtime.Hosting;
using System.Workflow.Activities;

#endregion

namespace CCommunicationSequentialConsoleApplication
{
    class Program
    {
        static ReviewService LocalService;
        static void Main(string[] args)
        {
            using(WorkflowRuntime workflowRuntime = new WorkflowRuntime())

            {           
                LocalService = new ReviewService() ;
                workflowRuntime .AddService (LocalService);
                AutoResetEvent waitHandle = new AutoResetEvent(false);
                workflowRuntime.WorkflowCompleted += delegate(object sender, WorkflowCompletedEventArgs e) {waitHandle.Set();};
                workflowRuntime.WorkflowTerminated += delegate(object sender, WorkflowTerminatedEventArgs e)
                {
                    Console.WriteLine(e.Exception.Message);
                    waitHandle.Set();
                };

                WorkflowInstance instance = workflowRuntime.CreateWorkflow(typeof(CCommunicationSequentialConsoleApplication.Workflow1));
                instance.Start();

                waitHandle.WaitOne();
            }
        }
    }
}
