'NOTE: When changing the namespace; please update XmlnsDefinitionAttribute in AssemblyInfo.vb
Module Module1
    Class Program

        Shared WaitHandle As New AutoResetEvent(False)

        Shared Sub Main()
            Using workflowRuntime As New WorkflowRuntime()
                AddHandler workflowRuntime.WorkflowCompleted, AddressOf OnWorkflowCompleted
                AddHandler workflowRuntime.WorkflowIdled, AddressOf OnWorkflowIdled
                AddHandler workflowRuntime.WorkflowPersisted, AddressOf OnWorkflowPersisted
                AddHandler workflowRuntime.WorkflowUnloaded, AddressOf OnWorkflowUnloaded
                AddHandler workflowRuntime.WorkflowLoaded, AddressOf OnWorkflowLoaded
                AddHandler workflowRuntime.WorkflowTerminated, AddressOf OnWorkflowTerminated

                workflowRuntime.AddService(New SqlWorkflowPersistenceService("Initial Catalog=SqlPersistenceService;Data Source=localhost;Integrated Security=SSPI;"))
                Dim workflowInstance As WorkflowInstance
                workflowInstance = workflowRuntime.CreateWorkflow(GetType(Workflow1))
                workflowInstance.Start()
                WaitHandle.WaitOne()
            End Using
        End Sub

        Shared Sub UnloadInstance(ByVal workflowInstance As Object)
            CType(workflowInstance, WorkflowInstance).TryUnload()
        End Sub

        Shared Sub OnWorkflowCompleted(ByVal sender As Object, ByVal e As WorkflowCompletedEventArgs)
            WaitHandle.Set()
        End Sub

        Shared Sub OnWorkflowTerminated(ByVal sender As Object, ByVal e As WorkflowTerminatedEventArgs)
            Console.WriteLine(e.Exception.Message)
            WaitHandle.Set()
        End Sub

        Shared Sub OnWorkflowLoaded(ByVal sender As Object, ByVal e As WorkflowEventArgs)
            Console.WriteLine("Workflow was loaded.")
        End Sub

        Shared Sub OnWorkflowUnloaded(ByVal sender As Object, ByVal e As WorkflowEventArgs)
            Console.WriteLine("Workflow was unloaded.")
        End Sub

        Shared Sub OnWorkflowPersisted(ByVal sender As Object, ByVal e As WorkflowEventArgs)
            Console.WriteLine("Workflow was persisted.")
        End Sub

        Shared Sub OnWorkflowIdled(ByVal sender As Object, ByVal e As WorkflowEventArgs)
            Console.WriteLine("Workflow is idle.")
            ThreadPool.QueueUserWorkItem(New WaitCallback(AddressOf UnloadInstance), e.WorkflowInstance)
        End Sub
    End Class
End Module

