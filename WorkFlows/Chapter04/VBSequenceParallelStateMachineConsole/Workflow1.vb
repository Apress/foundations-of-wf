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
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Private Sub Sequence1_ExecuteCode(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Sequence 1")
    End Sub

    Private Sub Sequence2_ExecuteCode(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Sequence 2")
    End Sub

    Private Sub ParallelLeft_ExecuteCode(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Parallel left")
    End Sub

    Private Sub ParallelRight1_ExecuteCode(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Parallel Right 1")
    End Sub

    Private Sub ParallelRight2_ExecuteCode(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Parallel Right 2")
    End Sub
End Class
