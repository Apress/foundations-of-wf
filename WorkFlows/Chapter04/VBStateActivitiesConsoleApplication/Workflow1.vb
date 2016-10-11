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
        Me.InitialStateName = "State1"
        MsgBox("Workflow started")
    End Sub

    Private Sub Code1_ExecuteCode(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Code1")
    End Sub

    Private Sub code2_ExecuteCode(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Code2")
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        MsgBox("Workflow Closing")
    End Sub
End Class
