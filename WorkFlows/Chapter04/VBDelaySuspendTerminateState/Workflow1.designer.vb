Imports System
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Collections
Imports System.Drawing
Imports System.Reflection
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
        Me.ToResume = New System.Workflow.Activities.SetStateActivity
        Me.SuspendError = New System.Workflow.ComponentModel.SuspendActivity
        Me.CounterLessEqual1 = New System.Workflow.Activities.IfElseBranchActivity
        Me.CounterGreater1 = New System.Workflow.Activities.IfElseBranchActivity
        Me.CodeResume = New System.Workflow.Activities.CodeActivity
        Me.Delay = New System.Workflow.Activities.DelayActivity
        Me.ifElseActivity1 = New System.Workflow.Activities.IfElseActivity
        Me.Delay1 = New System.Workflow.Activities.DelayActivity
        Me.eventDrivenActivity2 = New System.Workflow.Activities.EventDrivenActivity
        Me.eventDrivenActivity1 = New System.Workflow.Activities.EventDrivenActivity
        Me.ResumeState = New System.Workflow.Activities.StateActivity
        Me.InitialState = New System.Workflow.Activities.StateActivity
        '
        'TerminateError
        '
        Me.TerminateError.Name = "TerminateError"
        '
        'ToResume
        '
        Me.ToResume.Name = "ToResume"
        Me.ToResume.TargetStateName = "ResumeState"
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
        Me.CounterGreater1.Activities.Add(Me.ToResume)
        AddHandler codecondition2.Condition, AddressOf Me.CounterGreater1Condition
        Me.CounterGreater1.Condition = codecondition2
        Me.CounterGreater1.Name = "CounterGreater1"
        '
        'CodeResume
        '
        Me.CodeResume.Name = "CodeResume"
        AddHandler Me.CodeResume.ExecuteCode, AddressOf Me.CodeResume_ExecuteCode
        '
        'Delay
        '
        Me.Delay.Name = "Delay"
        Me.Delay.TimeoutDuration = System.TimeSpan.Parse("00:00:00")
        '
        'ifElseActivity1
        '
        Me.ifElseActivity1.Activities.Add(Me.CounterGreater1)
        Me.ifElseActivity1.Activities.Add(Me.CounterLessEqual1)
        Me.ifElseActivity1.Name = "ifElseActivity1"
        '
        'Delay1
        '
        Me.Delay1.Name = "Delay1"
        Me.Delay1.TimeoutDuration = System.TimeSpan.Parse("00:00:10")
        '
        'eventDrivenActivity2
        '
        Me.eventDrivenActivity2.Activities.Add(Me.Delay)
        Me.eventDrivenActivity2.Activities.Add(Me.CodeResume)
        Me.eventDrivenActivity2.Name = "eventDrivenActivity2"
        '
        'eventDrivenActivity1
        '
        Me.eventDrivenActivity1.Activities.Add(Me.Delay1)
        Me.eventDrivenActivity1.Activities.Add(Me.ifElseActivity1)
        Me.eventDrivenActivity1.Name = "eventDrivenActivity1"
        '
        'ResumeState
        '
        Me.ResumeState.Activities.Add(Me.eventDrivenActivity2)
        Me.ResumeState.Name = "ResumeState"
        '
        'InitialState
        '
        Me.InitialState.Activities.Add(Me.eventDrivenActivity1)
        Me.InitialState.Name = "InitialState"
        '
        'Workflow1
        '
        Me.Activities.Add(Me.InitialState)
        Me.Activities.Add(Me.ResumeState)
        Me.CompletedStateName = Nothing
        Me.DynamicUpdateCondition = Nothing
        Me.InitialStateName = "InitialState"
        Me.Name = "Workflow1"
        Me.CanModifyActivities = False

    End Sub
    Private eventDrivenActivity1 As System.Workflow.Activities.EventDrivenActivity
    Private ifElseActivity1 As System.Workflow.Activities.IfElseActivity
    Private CounterGreater1 As System.Workflow.Activities.IfElseBranchActivity
    Private CounterLessEqual1 As System.Workflow.Activities.IfElseBranchActivity
    Private ResumeState As System.Workflow.Activities.StateActivity
    Private Delay1 As System.Workflow.Activities.DelayActivity
    Private SuspendError As System.Workflow.ComponentModel.SuspendActivity
    Private ToResume As System.Workflow.Activities.SetStateActivity
    Private TerminateError As System.Workflow.ComponentModel.TerminateActivity
    Private eventDrivenActivity2 As System.Workflow.Activities.EventDrivenActivity
    Private Delay As System.Workflow.Activities.DelayActivity
    Private CodeResume As System.Workflow.Activities.CodeActivity
    Private InitialState As System.Workflow.Activities.StateActivity


End Class
