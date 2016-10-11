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
        Me.Workflow1InitialState = New System.Workflow.Activities.StateActivity
        Me.eventDrivenActivity1 = New System.Workflow.Activities.EventDrivenActivity
        Me.policyActivity1 = New System.Workflow.Activities.PolicyActivity
        '
        'Workflow1InitialState
        '
        Me.Workflow1InitialState.Activities.Add(Me.eventDrivenActivity1)
        Me.Workflow1InitialState.Name = "Workflow1InitialState"
        '
        'eventDrivenActivity1
        '
        Me.eventDrivenActivity1.Activities.Add(Me.policyActivity1)
        Me.eventDrivenActivity1.Name = "eventDrivenActivity1"
        '
        'policyActivity1
        '
        Me.policyActivity1.Name = "policyActivity1"
        Me.policyActivity1.RuleSetReference = Nothing
        '
        'Workflow1
        '
        Me.Activities.Add(Me.Workflow1InitialState)
        Me.CompletedStateName = Nothing
        Me.DynamicUpdateCondition = Nothing
        Me.InitialStateName = "Workflow1InitialState"
        Me.Name = "Workflow1"
        Me.CanModifyActivities = False

    End Sub
    Private WithEvents eventDrivenActivity1 As System.Workflow.Activities.EventDrivenActivity
    Private WithEvents policyActivity1 As System.Workflow.Activities.PolicyActivity
    Private WithEvents Workflow1InitialState As System.Workflow.Activities.StateActivity


End Class
