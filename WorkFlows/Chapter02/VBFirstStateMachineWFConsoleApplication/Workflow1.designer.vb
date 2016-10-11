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
        Me.CompletedState = New System.Workflow.Activities.StateActivity
        Me.FirstState = New System.Workflow.Activities.StateActivity
        Me.SecondState = New System.Workflow.Activities.StateActivity
        Me.eventDrivenActivity1 = New System.Workflow.Activities.EventDrivenActivity
        Me.eventDrivenActivity2 = New System.Workflow.Activities.EventDrivenActivity
        Me.delayActivity1 = New System.Workflow.Activities.DelayActivity
        Me.setStateActivity1 = New System.Workflow.Activities.SetStateActivity
        Me.delayActivity2 = New System.Workflow.Activities.DelayActivity
        Me.setStateActivity2 = New System.Workflow.Activities.SetStateActivity
        '
        'CompletedState
        '
        Me.CompletedState.Description = "This is the last state "
        Me.CompletedState.Name = "CompletedState"
        '
        'FirstState
        '
        Me.FirstState.Activities.Add(Me.eventDrivenActivity1)
        Me.FirstState.Description = "This is the first state"
        Me.FirstState.Name = "FirstState"
        '
        'SecondState
        '
        Me.SecondState.Activities.Add(Me.eventDrivenActivity2)
        Me.SecondState.Description = "This is the second state"
        Me.SecondState.Name = "SecondState"
        '
        'eventDrivenActivity1
        '
        Me.eventDrivenActivity1.Activities.Add(Me.delayActivity1)
        Me.eventDrivenActivity1.Activities.Add(Me.setStateActivity1)
        Me.eventDrivenActivity1.Name = "eventDrivenActivity1"
        '
        'eventDrivenActivity2
        '
        Me.eventDrivenActivity2.Activities.Add(Me.delayActivity2)
        Me.eventDrivenActivity2.Activities.Add(Me.setStateActivity2)
        Me.eventDrivenActivity2.Name = "eventDrivenActivity2"
        '
        'delayActivity1
        '
        Me.delayActivity1.Name = "delayActivity1"
        Me.delayActivity1.TimeoutDuration = System.TimeSpan.Parse("00:00:30")
        '
        'setStateActivity1
        '
        Me.setStateActivity1.Name = "setStateActivity1"
        Me.setStateActivity1.TargetStateName = "SecondState"
        '
        'delayActivity2
        '
        Me.delayActivity2.Name = "delayActivity2"
        Me.delayActivity2.TimeoutDuration = System.TimeSpan.Parse("00:00:30")
        '
        'setStateActivity2
        '
        Me.setStateActivity2.Name = "setStateActivity2"
        Me.setStateActivity2.TargetStateName = "CompletedState"
        '
        'Workflow1
        '
        Me.Activities.Add(Me.CompletedState)
        Me.Activities.Add(Me.FirstState)
        Me.Activities.Add(Me.SecondState)
        Me.CompletedStateName = "CompletedState"
        Me.DynamicUpdateCondition = Nothing
        Me.InitialStateName = "FirstState"
        Me.Name = "Workflow1"
        Me.CanModifyActivities = False

    End Sub
    Private WithEvents setStateActivity1 As System.Workflow.Activities.SetStateActivity
    Private WithEvents setStateActivity2 As System.Workflow.Activities.SetStateActivity
    Private WithEvents delayActivity1 As System.Workflow.Activities.DelayActivity
    Private WithEvents SecondState As System.Workflow.Activities.StateActivity
    Private WithEvents eventDrivenActivity2 As System.Workflow.Activities.EventDrivenActivity
    Private WithEvents delayActivity2 As System.Workflow.Activities.DelayActivity
    Private WithEvents FirstState As System.Workflow.Activities.StateActivity
    Private WithEvents eventDrivenActivity1 As System.Workflow.Activities.EventDrivenActivity
    Private WithEvents CompletedState As System.Workflow.Activities.StateActivity


End Class
