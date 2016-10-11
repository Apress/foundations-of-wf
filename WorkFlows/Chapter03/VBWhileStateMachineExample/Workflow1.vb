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
    Private IntCounter As Integer = 0
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
    Public Sub WhileCondition(ByVal sender As Object, ByVal e As ConditionalEventArgs)
        e.Result = IntCounter < 10
        IntCounter = IntCounter + 1
    End Sub

    
    Private Sub codeActivity1_ExecuteCode(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(IntCounter)
    End Sub
End Class
