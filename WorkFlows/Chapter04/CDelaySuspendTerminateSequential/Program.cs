#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Workflow.Runtime;
using System.Workflow.Runtime.Hosting;
using CDelaySuspendTerminateSequential.Properties;

#endregion

namespace CDelaySuspendTerminateSequential
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkflowRuntime workflowRuntime = new WorkflowRuntime();
            
            AutoResetEvent waitHandle = new AutoResetEvent(false);
            workflowRuntime.WorkflowCompleted += delegate(object sender, WorkflowCompletedEventArgs e) {waitHandle.Set();};
            workflowRuntime.WorkflowTerminated += OnWorkflowTerminated;
            workflowRuntime.WorkflowSuspended += OnWorkflowSuspended;
            
            WorkflowInstance instance = workflowRuntime.CreateWorkflow(typeof(CDelaySuspendTerminateSequential.Workflow1));
            instance.Start();

            waitHandle.WaitOne();
        }

        static void OnWorkflowTerminated(object sender, WorkflowTerminatedEventArgs e)
        {
            Console.WriteLine("Terminated");
        }

        static void OnWorkflowSuspended(object sender, WorkflowSuspendedEventArgs e)
        {
            Console.WriteLine("suspended");
        }
    }
}
