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
        Me.code2 = New System.Workflow.Activities.CodeActivity
        Me.ToState2 = New System.Workflow.Activities.SetStateActivity
        Me.Code1 = New System.Workflow.Activities.CodeActivity
        Me.Finalization1 = New System.Workflow.Activities.StateFinalizationActivity
        Me.Initialization1 = New System.Workflow.Activities.StateInitializationActivity
        Me.State2 = New System.Workflow.Activities.StateActivity
        Me.State1 = New System.Workflow.Activities.StateActivity
        '
        'code2
        '
        Me.code2.Name = "code2"
        AddHandler Me.code2.ExecuteCode, AddressOf Me.code2_ExecuteCode
        '
        'ToState2
        '
        Me.ToState2.Name = "ToState2"
        Me.ToState2.TargetStateName = "State2"
        '
        'Code1
        '
        Me.Code1.Name = "Code1"
        AddHandler Me.Code1.ExecuteCode, AddressOf Me.Code1_ExecuteCode
        '
        'Finalization1
        '
        Me.Finalization1.Activities.Add(Me.code2)
        Me.Finalization1.Name = "Finalization1"
        '
        'Initialization1
        '
        Me.Initialization1.Activities.Add(Me.Code1)
        Me.Initialization1.Activities.Add(Me.ToState2)
        Me.Initialization1.Name = "Initialization1"
        '
        'State2
        '
        Me.State2.Name = "State2"
        '
        'State1
        '
        Me.State1.Activities.Add(Me.Initialization1)
        Me.State1.Activities.Add(Me.Finalization1)
        Me.State1.Name = "State1"
        '
        'Workflow1
        '
        Me.Activities.Add(Me.State1)
        Me.Activities.Add(Me.State2)
        Me.CompletedStateName = "State2"
        Me.DynamicUpdateCondition = Nothing
        Me.InitialStateName = "State1"
        Me.Name = "Workflow1"
        Me.CanModifyActivities = False

    End Sub
    Private Initialization1 As System.Workflow.Activities.StateInitializationActivity
    Private Code1 As System.Workflow.Activities.CodeActivity
    Private Finalization1 As System.Workflow.Activities.StateFinalizationActivity
    Private code2 As System.Workflow.Activities.CodeActivity
    Private ToState2 As System.Workflow.Activities.SetStateActivity
    Private State2 As System.Workflow.Activities.StateActivity
    Private State1 As System.Workflow.Activities.StateActivity


End Class
