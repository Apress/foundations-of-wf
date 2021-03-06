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
    Private IntInputValue As Integer
    Public WriteOnly Property InputValue() As Integer
        Set(ByVal value As Integer)
            IntInputValue = value
        End Set
    End Property
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
    Private Sub Branch1Condition(ByVal sender As System.Object, ByVal e As ConditionalEventArgs)
        e.Result = IntInputValue > 50
    End Sub
    Private Sub Branch2Condition(ByVal sender As System.Object, ByVal e As ConditionalEventArgs)
        e.Result = IntInputValue > 25
    End Sub
    Private Sub Branch1Code_ExecuteCode(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Branch1")
    End Sub

    Private Sub Branch2Code_ExecuteCode(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Branch2")
    End Sub
End Class
