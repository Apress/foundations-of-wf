Imports System
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Collections
Imports System.Drawing
Imports System.Reflection
Imports System.Workflow.ComponentModel.Compiler
Imports System.Workflow.ComponentModel.Serialization
Imports System.Workflow.ComponentModel
Imports System.Workflow.ComponentModel.Design
Imports System.Workflow.Runtime
Imports System.Workflow.Activities
Imports System.Workflow.Activities.Rules

Partial Public Class WorkflowTerminatedFault

    'NOTE: The following procedure is required by the Workflow Designer
    'It can be modified using the Workflow Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Me.CanModifyActivities = True
        Me.codeActivity1 = New System.Workflow.Activities.CodeActivity
        Me.MyException = New System.Workflow.ComponentModel.FaultHandlerActivity
        Me.faultHandlersActivity1 = New System.Workflow.ComponentModel.FaultHandlersActivity
        Me.throwActivity1 = New System.Workflow.ComponentModel.ThrowActivity
        Me.FirstActivity = New System.Workflow.Activities.CodeActivity
        '
        'codeActivity1
        '
        Me.codeActivity1.Name = "codeActivity1"
        AddHandler Me.codeActivity1.ExecuteCode, AddressOf Me.codeActivity1_ExecuteCode
        '
        'MyException
        '
        Me.MyException.Activities.Add(Me.codeActivity1)
        Me.MyException.FaultType = GetType(VBFaultHandlerSequentialConsoleApplication.MyException)
        Me.MyException.Name = "MyException"
        '
        'faultHandlersActivity1
        '
        Me.faultHandlersActivity1.Activities.Add(Me.MyException)
        Me.faultHandlersActivity1.Name = "faultHandlersActivity1"
        '
        'throwActivity1
        '
        Me.throwActivity1.FaultType = GetType(VBFaultHandlerSequentialConsoleApplication.MyException)
        Me.throwActivity1.Name = "throwActivity1"
        '
        'FirstActivity
        '
        Me.FirstActivity.Name = "FirstActivity"
        AddHandler Me.FirstActivity.ExecuteCode, AddressOf Me.FirstActivity_ExecuteCode
        '
        'WorkflowTerminatedFault
        '
        Me.Activities.Add(Me.FirstActivity)
        Me.Activities.Add(Me.throwActivity1)
        Me.Activities.Add(Me.faultHandlersActivity1)
        Me.Name = "Workflow1"
        Me.CanModifyActivities = False

    End Sub
    Private WorkflowTerminatedFault As System.Workflow.ComponentModel.FaultHandlerActivity
    Private faultHandlersActivity1 As System.Workflow.ComponentModel.FaultHandlersActivity
    Private FirstActivity As System.Workflow.Activities.CodeActivity
    Private throwActivity1 As System.Workflow.ComponentModel.ThrowActivity
    Private MyException As System.Workflow.ComponentModel.FaultHandlerActivity
    Private codeActivity1 As System.Workflow.Activities.CodeActivity

End Class
