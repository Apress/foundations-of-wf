#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Workflow.Runtime;
using System.Workflow.Runtime.Hosting;

#endregion

namespace CPersistence
{
    class Program
    {
        static AutoResetEvent waitHandle = new AutoResetEvent(false);
        static void Main(string[] args)
        {
             try {
            // Create the WorkflowRuntime
                WorkflowRuntime workflowRuntime = new WorkflowRuntime();

                workflowRuntime.AddService(new SqlWorkflowPersistenceService("Initial Catalog=SqlPersistenceService;Data Source=localhost;Integrated Security=SSPI;"));

                // Set up the WorkflowRuntime event handlers
                workflowRuntime.WorkflowCompleted += OnWorkflowCompleted;
                workflowRuntime.WorkflowIdled += OnWorkflowIdled;
                workflowRuntime.WorkflowPersisted += OnWorkflowPersisted;
                workflowRuntime.WorkflowUnloaded += OnWorkflowUnloaded;
                workflowRuntime.WorkflowLoaded += OnWorkflowLoaded;
                workflowRuntime.WorkflowTerminated += OnWorkflowTerminated;

                // Load the workflow type
                Type type = typeof(Workflow1);

                // Create an instance of the workflow
                workflowRuntime.CreateWorkflow(type).Start();
                Console.WriteLine("Workflow Started.");

                // Wait for the event to be signaled
                waitHandle.WaitOne();

                // Stop the runtime
                workflowRuntime.StopRuntime();
                Console.WriteLine("Program Complete.");
            }
            catch (Exception exception)
            {
                Console.WriteLine("Application exception occured: " + exception.Message);
            }
        }
        //It is good practice to provide a handler for the WorkflowTerminated event
        // so the host application can manage unexpected problems during workflow execution
        // such as database connectivity issues, networking issues, etc.
        static void OnWorkflowTerminated(object sender, WorkflowTerminatedEventArgs e)
        {
            Console.WriteLine(e.Exception.Message);
            waitHandle.Set();
        }

        //Called when the workflow is loaded back into memory - in this sample this occurs when the timer expires
        static void OnWorkflowLoaded(object sender, WorkflowEventArgs e)
        {
            Console.WriteLine("Workflow was loaded.");
        }

        //Called when the workflow is unloaded from memory - in this sample the workflow instance is unloaded by the application
        // in the UnloadInstance method below.
        static void OnWorkflowUnloaded(object sender, WorkflowEventArgs e)
        {
            Console.WriteLine("Workflow was unloaded.");
        }

        //Called when the workflow is persisted - in this sample when it is unloaded and completed
        static void OnWorkflowPersisted(object sender, WorkflowEventArgs e)
        {
            Console.WriteLine("Workflow was persisted.");
        }

        //Called when the workflow is idle - in this sample this occurs when the workflow is waiting on the
        // delay1 activity to expire
        static void OnWorkflowIdled(object sender, WorkflowEventArgs e)
        {
            Console.WriteLine("Workflow is idle.");
            //Events that are raised back onto a workflow from a runtime event handler need to be queued on the ThreadPool.
            //This is because the instance is locked by the runtime engine, and directly raising an event back to the workflow
            // may cause a deadlock.
            ThreadPool.QueueUserWorkItem(UnloadInstance, e.WorkflowInstance);
        }

        //Perform the unload (persist and dispose)
        static void UnloadInstance(object workflowInstance)
        {
            ((WorkflowInstance)workflowInstance).TryUnload();
        }

        // This method will be called when a workflow instance is completed; since we have started only a single
        // instance we are ignoring the event args and signaling the waitHandle so the main thread can continue
        static void OnWorkflowCompleted(object sender, WorkflowCompletedEventArgs instance)
        {
            waitHandle.Set();
        }
    }
}
