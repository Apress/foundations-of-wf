#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Workflow.Runtime;
using System.Workflow.Runtime.Hosting;
using CFirstSequentialWFConsoleApplication.Properties;

#endregion

namespace CFirstSequentialWFConsoleApplication
{
    class Program
    {
        static AutoResetEvent waitHandle = new AutoResetEvent(false);
        static void Main(string[] args)
        {

            WorkflowRuntime workflowRuntime = new WorkflowRuntime();
           // AutoResetEvent waitHandle = new AutoResetEvent(false);

           workflowRuntime.WorkflowCompleted += OnWorkflowCompleted;

           workflowRuntime.WorkflowTerminated += OnWorkflowTerminated;
            
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters["Input1"] = 45;
            parameters["Input2"] = 45;

            WorkflowInstance instance = workflowRuntime.CreateWorkflow(typeof(CFirstSequentialWFConsoleApplication.Workflow1), parameters);
            instance.Start();

           waitHandle.WaitOne();
                    
        }
        static void OnWorkflowCompleted(object sender, WorkflowCompletedEventArgs e)
    {
        Console.WriteLine(e.OutputParameters["OutputValue"]);
               
    }

       static void OnWorkflowTerminated(object sender, WorkflowTerminatedEventArgs e)
    {
        
    }
    }

    }


    
 
