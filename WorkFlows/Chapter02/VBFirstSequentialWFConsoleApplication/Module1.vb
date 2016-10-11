Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Threading
Imports System.Workflow.Runtime
Imports System.Workflow.Runtime.Hosting

Module Module1
    Class Program
        Shared WaitHandle As New AutoResetEvent(False)

        Shared Sub Main()
            Dim workflowRuntime As New WorkflowRuntime()
            Dim Parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

            AddHandler workflowRuntime.WorkflowCompleted, AddressOf OnWorkflowCompleted
            AddHandler workflowRuntime.WorkflowTerminated, AddressOf OnWorkflowTerminated

            Dim workflowInstance As WorkflowInstance
            Parameters.Add("Input1", 45)
            Parameters.Add("Input2", 45)

            workflowInstance = workflowRuntime.CreateWorkflow(GetType(Workflow1), Parameters)
            workflowInstance.Start()

            WaitHandle.WaitOne()
        End Sub

        Shared Sub OnWorkflowCompleted(ByVal sender As Object, ByVal e As WorkflowCompletedEventArgs)
            MsgBox("Output parameter: {0} " & e.OutputParameters("OutputValue").ToString)
            WaitHandle.Set()
        End Sub

        Shared Sub OnWorkflowTerminated(ByVal sender As Object, ByVal e As WorkflowTerminatedEventArgs)
            Console.WriteLine(e.Exception.Message)
            WaitHandle.Set()
        End Sub

    End Class
End Module

