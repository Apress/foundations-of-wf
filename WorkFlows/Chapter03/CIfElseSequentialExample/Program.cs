#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Workflow.Runtime;
using System.Workflow.Runtime.Hosting;
using CIfElseSequentialExample.Properties;

#endregion

namespace CIfElseSequentialExample
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkflowRuntime workflowRuntime = new WorkflowRuntime();
            
            AutoResetEvent waitHandle = new AutoResetEvent(false);
            workflowRuntime.WorkflowCompleted += delegate(object sender, WorkflowCompletedEventArgs e) {waitHandle.Set();};
            workflowRuntime.WorkflowTerminated += delegate(object sender, WorkflowTerminatedEventArgs e)
            {
                Console.WriteLine(e.Exception.Message);
                waitHandle.Set();
            };
            Dictionary<string, object> parms= new Dictionary<string, object>();
            Console.WriteLine("Input Value");
          
            parms["InputValue"] = System.Convert.ToInt32 (Console.ReadLine()); 
            WorkflowInstance instance = workflowRuntime.CreateWorkflow(typeof(CIfElseSequentialExample.Workflow1),parms);
            instance.Start();

            waitHandle.WaitOne();
        }
    }
}
