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
Partial Public Class Workflow1
    Inherits SequentialWorkflowActivity
    Public Exception As New System.Exception
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
    Private Sub OnException(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Exception encountered, rolling back")

    End Sub
    Private Sub OnCompensate(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Transaction Rolled Back")

    End Sub


    Private Sub Insert1_ExecuteCode(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Insert1")
    End Sub

    Private Sub Insert2_ExecuteCode(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Insert2")
    End Sub

    Private Sub Complete_ExecuteCode(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Complete")
    End Sub
End Class
