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

Partial Public class Workflow1

    'NOTE: The following procedure is required by the Workflow Designer
    'It can be modified using the Workflow Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Me.CanModifyActivities = True
        Dim codecondition1 As System.Workflow.Activities.CodeCondition = New System.Workflow.Activities.CodeCondition
        Dim codecondition2 As System.Workflow.Activities.CodeCondition = New System.Workflow.Activities.CodeCondition
        Me.TerminateError = New System.Workflow.ComponentModel.TerminateActivity
        Me.CodeResume = New System.Workflow.Activities.CodeActivity
        Me.SuspendError = New System.Workflow.ComponentModel.SuspendActivity
        Me.CounterLessEqual1 = New System.Workflow.Activities.IfElseBranchActivity
        Me.CounterGreater1 = New System.Workflow.Activities.IfElseBranchActivity
        Me.ifElseActivity1 = New System.Workflow.Activities.IfElseActivity
        Me.delay1 = New System.Workflow.Activities.DelayActivity
        '
        'TerminateError
        '
        Me.TerminateError.Name = "TerminateError"
        '
        'CodeResume
        '
        Me.CodeResume.Name = "CodeResume"
        AddHandler Me.CodeResume.ExecuteCode, AddressOf Me.CodeResume_ExecuteCode
        '
        'SuspendError
        '
        Me.SuspendError.Name = "SuspendError"
        '
        'CounterLessEqual1
        '
        Me.CounterLessEqual1.Activities.Add(Me.TerminateError)
        AddHandler codecondition1.Condition, AddressOf Me.CounterLessEqual1Condition
        Me.CounterLessEqual1.Condition = codecondition1
        Me.CounterLessEqual1.Name = "CounterLessEqual1"
        '
        'CounterGreater1
        '
        Me.CounterGreater1.Activities.Add(Me.SuspendError)
        Me.CounterGreater1.Activities.Add(Me.CodeResume)
        AddHandler codecondition2.Condition, AddressOf Me.CounterGreater1Condition
        Me.CounterGreater1.Condition = codecondition2
        Me.CounterGreater1.Name = "CounterGreater1"
        '
        'ifElseActivity1
        '
        Me.ifElseActivity1.Activities.Add(Me.CounterGreater1)
        Me.ifElseActivity1.Activities.Add(Me.CounterLessEqual1)
        Me.ifElseActivity1.Name = "ifElseActivity1"
        '
        'delay1
        '
        Me.delay1.Name = "delay1"
        Me.delay1.TimeoutDuration = System.TimeSpan.Parse("00:00:30")
        '
        'Workflow1
        '
        Me.Activities.Add(Me.delay1)
        Me.Activities.Add(Me.ifElseActivity1)
        Me.Name = "Workflow1"
        Me.CanModifyActivities = False

    End Sub
    Private ifElseActivity1 As System.Workflow.Activities.IfElseActivity
    Private CounterGreater1 As System.Workflow.Activities.IfElseBranchActivity
    Private SuspendError As System.Workflow.ComponentModel.SuspendActivity
    Private CounterLessEqual1 As System.Workflow.Activities.IfElseBranchActivity
    Private TerminateError As System.Workflow.ComponentModel.TerminateActivity
    Private CodeResume As System.Workflow.Activities.CodeActivity
    Private delay1 As System.Workflow.Activities.DelayActivity

End Class
