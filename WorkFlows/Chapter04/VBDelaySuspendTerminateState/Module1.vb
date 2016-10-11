Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Threading
Imports System.Workflow.Runtime
Imports System.Workflow.Runtime.Hosting

'NOTE: When changing the namespace; please update XmlnsDefinitionAttribute in AssemblyInfo.vb
Module Module1
    Class Program
        Shared WaitHandle As New AutoResetEvent(False)

        Shared Sub Main()
            Dim workflowRuntime As New WorkflowRuntime()

            AddHandler workflowRuntime.WorkflowCompleted, AddressOf OnWorkflowCompleted
            AddHandler workflowRuntime.WorkflowTerminated, AddressOf OnWorkflowTerminated
            AddHandler workflowRuntime.WorkflowSuspended, AddressOf OnWorkflowSuspended

            Dim workflowInstance As WorkflowInstance
            workflowInstance = workflowRuntime.CreateWorkflow(GetType(Workflow1))
            workflowInstance.Start()

            WaitHandle.WaitOne()
        End Sub

        Shared Sub OnWorkflowCompleted(ByVal sender As Object, ByVal e As WorkflowCompletedEventArgs)
            WaitHandle.Set()
        End Sub

        Shared Sub OnWorkflowTerminated(ByVal sender As Object, ByVal e As WorkflowTerminatedEventArgs)
            MsgBox(e.Exception.Message)
            WaitHandle.Set()
        End Sub
        Shared Sub OnWorkflowSuspended(ByVal sender As Object, ByVal e As WorkflowSuspendedEventArgs)
            Dim wfinstance As WorkflowInstance
            wfinstance = e.WorkflowInstance
            If MsgBox(e.Error & " Do you want to continue?", MsgBoxStyle.YesNo, "Workflow Suspended") = MsgBoxResult.Yes Then
                wfinstance.Resume()
            Else
                wfinstance.Terminate("User Choice")
                WaitHandle.Set()
            End If

        End Sub





    End Class





End Module

