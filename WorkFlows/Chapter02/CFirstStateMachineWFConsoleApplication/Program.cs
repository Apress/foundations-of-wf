#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Workflow.Runtime;
using System.Workflow.Runtime.Hosting;
using CFirstStateMachineWFConsoleApplication.Properties;

#endregion

namespace CFirstStateMachineWFConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkflowRuntime workflowRuntime = new WorkflowRuntime();

            AutoResetEvent waitHandle = new AutoResetEvent(false);
            workflowRuntime.WorkflowCompleted += OnWorkflowCompleted;
            workflowRuntime.WorkflowTerminated += OnWorkflowTerminated;


            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters["Input1"] = 45;
            parameters["Input2"] = 45;

            WorkflowInstance instance = workflowRuntime.CreateWorkflow(typeof(CFirstStateMachineWFConsoleApplication.Workflow1));
            instance.Start();

            waitHandle.WaitOne();
           
        }

        static void OnWorkflowCompleted(object sender, WorkflowCompletedEventArgs e)
        {
            Console.WriteLine("Workflow Complete");

        }

        static void OnWorkflowTerminated(object sender, WorkflowTerminatedEventArgs e)
        {

        }
    }
}
