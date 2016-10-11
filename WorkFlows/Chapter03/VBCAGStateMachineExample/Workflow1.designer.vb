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
        Me.CompletedState = New System.Workflow.Activities.StateActivity
        Me.FirstState = New System.Workflow.Activities.StateActivity
        Me.stateInitializationActivity1 = New System.Workflow.Activities.StateInitializationActivity
        Me.conditionedActivityGroup1 = New System.Workflow.Activities.ConditionedActivityGroup
        Me.Code1 = New System.Workflow.Activities.CodeActivity
        Me.Code2 = New System.Workflow.Activities.CodeActivity
        Me.setStateActivity1 = New System.Workflow.Activities.SetStateActivity
        '
        'CompletedState
        '
        Me.CompletedState.Name = "CompletedState"
        '
        'FirstState
        '
        Me.FirstState.Activities.Add(Me.stateInitializationActivity1)
        Me.FirstState.Name = "FirstState"
        '
        'stateInitializationActivity1
        '
        Me.stateInitializationActivity1.Activities.Add(Me.conditionedActivityGroup1)
        Me.stateInitializationActivity1.Activities.Add(Me.setStateActivity1)
        Me.stateInitializationActivity1.Name = "stateInitializationActivity1"
        '
        'conditionedActivityGroup1
        '
        Me.conditionedActivityGroup1.Activities.Add(Me.Code1)
        Me.conditionedActivityGroup1.Activities.Add(Me.Code2)
        Me.conditionedActivityGroup1.Name = "conditionedActivityGroup1"
        AddHandler codecondition1.Condition, AddressOf Me.Code1WhileCondition
        '
        'Code1
        '
        Me.Code1.Name = "Code1"
        AddHandler Me.Code1.ExecuteCode, AddressOf Me.Code1_ExecuteCode
        Me.Code1.SetValue(System.Workflow.Activities.ConditionedActivityGroup.WhenConditionProperty, codecondition1)
        AddHandler codecondition2.Condition, AddressOf Me.Code2WhileCondition
        '
        'Code2
        '
        Me.Code2.Name = "Code2"
        AddHandler Me.Code2.ExecuteCode, AddressOf Me.codeActivity1_ExecuteCode
        Me.Code2.SetValue(System.Workflow.Activities.ConditionedActivityGroup.WhenConditionProperty, codecondition2)
        '
        'setStateActivity1
        '
        Me.setStateActivity1.Name = "setStateActivity1"
        Me.setStateActivity1.TargetStateName = "CompletedState"
        '
        'Workflow1
        '
        Me.Activities.Add(Me.CompletedState)
        Me.Activities.Add(Me.FirstState)
        Me.CompletedStateName = "CompletedState"
        Me.DynamicUpdateCondition = Nothing
        Me.InitialStateName = "FirstState"
        Me.Name = "Workflow1"
        Me.CanModifyActivities = False

    End Sub
    Private WithEvents FirstState As System.Workflow.Activities.StateActivity
    Private WithEvents stateInitializationActivity1 As System.Workflow.Activities.StateInitializationActivity
    Private WithEvents conditionedActivityGroup1 As System.Workflow.Activities.ConditionedActivityGroup
    Private WithEvents Code1 As System.Workflow.Activities.CodeActivity
    Private WithEvents Code2 As System.Workflow.Activities.CodeActivity
    Private WithEvents setStateActivity1 As System.Workflow.Activities.SetStateActivity
    Private WithEvents CompletedState As System.Workflow.Activities.StateActivity


End Class
