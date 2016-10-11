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
        Me.CompletedState = New System.Workflow.Activities.StateActivity
        Me.FirstState = New System.Workflow.Activities.StateActivity
        Me.stateInitializationActivity1 = New System.Workflow.Activities.StateInitializationActivity
        Me.whileActivity1 = New System.Workflow.Activities.WhileActivity
        Me.setStateActivity2 = New System.Workflow.Activities.SetStateActivity
        Me.codeActivity1 = New System.Workflow.Activities.CodeActivity
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
        Me.stateInitializationActivity1.Activities.Add(Me.whileActivity1)
        Me.stateInitializationActivity1.Activities.Add(Me.setStateActivity2)
        Me.stateInitializationActivity1.Name = "stateInitializationActivity1"
        '
        'whileActivity1
        '
        Me.whileActivity1.Activities.Add(Me.codeActivity1)
        AddHandler codecondition1.Condition, AddressOf Me.WhileCondition
        Me.whileActivity1.Condition = codecondition1
        Me.whileActivity1.Name = "whileActivity1"
        '
        'setStateActivity2
        '
        Me.setStateActivity2.Name = "setStateActivity2"
        Me.setStateActivity2.TargetStateName = "CompletedState"
        '
        'codeActivity1
        '
        Me.codeActivity1.Name = "codeActivity1"
        AddHandler Me.codeActivity1.ExecuteCode, AddressOf Me.codeActivity1_ExecuteCode
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
    Private WithEvents codeActivity1 As System.Workflow.Activities.CodeActivity
    Private WithEvents FirstState As System.Workflow.Activities.StateActivity
    Private WithEvents stateInitializationActivity1 As System.Workflow.Activities.StateInitializationActivity
    Private WithEvents whileActivity1 As System.Workflow.Activities.WhileActivity
    Private WithEvents setStateActivity2 As System.Workflow.Activities.SetStateActivity
    Private WithEvents CompletedState As System.Workflow.Activities.StateActivity


End Class
