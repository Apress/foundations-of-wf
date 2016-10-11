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
Partial Public Class WorkflowTerminatedFault
    Inherits SequentialWorkflowActivity
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Private Sub GeneralFaultCode_ExecuteCode(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("General Fault Error")
    End Sub

    Private Sub TerminatedFaultCode_ExecuteCode(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("My exception was thrown")
    End Sub

    Private Sub FirstActivity_ExecuteCode(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("First Activity")
    End Sub

    Private Sub codeActivity1_ExecuteCode(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("My exception was thrown")
    End Sub
End Class
