Imports System
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Collections
Imports System.Drawing
Imports System.Workflow.ComponentModel.Compiler
Imports System.Workflow.ComponentModel.Serialization
Imports System.Workflow.ComponentModel
Imports System.Workflow.ComponentModel.Design
Imports System.Workflow.Runtime
Imports System.Workflow.Activities
Imports System.Workflow.Activities.Rules

'NOTE: When changing the namespace; please update XmlnsDefinitionAttribute in AssemblyInfo.vb
Partial Public class Workflow1
    Inherits SequentialWorkflowActivity
    Public IntValue As Integer = 1
    Public intvalue2 As Integer

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Private Sub BeforePolicyCode_ExecuteCode(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Before Policy: " & IntValue)
    End Sub

    Private Sub AfterPolicyCode_ExecuteCode(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("After Policy: " & IntValue)
    End Sub
    Private Sub GreaterThan0()
        IntValue = 0
    End Sub
End Class
