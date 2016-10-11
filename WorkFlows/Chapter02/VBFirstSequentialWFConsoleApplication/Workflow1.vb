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
    Private InputValue1 As Integer
    Private InputValue2 As Integer
    Private OutputResult As Integer
    Public WriteOnly Property Input1() As Integer
        Set(ByVal value As Integer)
            InputValue1 = value
        End Set
    End Property
    Public WriteOnly Property Input2() As Integer
        Set(ByVal value As Integer)
            InputValue2 = value
        End Set
    End Property
    Public ReadOnly Property OutputValue() As Integer
        Get
            Return OutputResult
        End Get
    End Property
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Private Sub Step1_ExecuteCode(ByVal sender As System.Object, ByVal e As System.EventArgs)
        OutputResult = InputValue1 + InputValue2
        MsgBox("Step1")
    End Sub

    Private Sub Step2_ExecuteCode(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Step2")
    End Sub

    
End Class
