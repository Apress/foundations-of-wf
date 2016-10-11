Imports System
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Collections
Imports System.Drawing
Imports System.Workflow.ComponentModel
Imports System.Workflow.ComponentModel.Design
Imports System.Workflow.Runtime
Imports System.Workflow.Activities
Imports System.Workflow.Activities.Rules

'NOTE: When changing the namespace; please update XmlnsDefinitionAttribute in AssemblyInfo.vb
Partial Public class Workflow1
    Inherits StateMachineWorkflowActivity
    Private IntCounter As Integer = 10
    Public Sub New()
        MyBase.New()
        InitializeComponent()
        SuspendError.Error = "Counter>1"
        TerminateError.Error = "Counter<=1"
    End Sub
    Public Sub CounterGreater1Condition(ByVal sender As Object, ByVal e As ConditionalEventArgs)
        e.Result = IntCounter > 1
    End Sub
    Public Sub CounterLessEqual1Condition(ByVal sender As Object, ByVal e As ConditionalEventArgs)
        e.Result = IntCounter <= 1
    End Sub

    Private Sub CodeResume_ExecuteCode(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Workflow Resumed")
    End Sub
End Class
