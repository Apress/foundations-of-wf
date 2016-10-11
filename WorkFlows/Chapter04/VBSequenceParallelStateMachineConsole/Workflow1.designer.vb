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
        Me.ParallelRight2 = New System.Workflow.Activities.CodeActivity
        Me.ParallelRight1 = New System.Workflow.Activities.CodeActivity
        Me.ParallelLeft = New System.Workflow.Activities.CodeActivity
        Me.sequenceActivity3 = New System.Workflow.Activities.SequenceActivity
        Me.sequenceActivity2 = New System.Workflow.Activities.SequenceActivity
        Me.Sequence2 = New System.Workflow.Activities.CodeActivity
        Me.Sequence1 = New System.Workflow.Activities.CodeActivity
        Me.parallelActivity1 = New System.Workflow.Activities.ParallelActivity
        Me.GoToLastState = New System.Workflow.Activities.SetStateActivity
        Me.sequenceActivity1 = New System.Workflow.Activities.SequenceActivity
        Me.stateInitializationActivity2 = New System.Workflow.Activities.StateInitializationActivity
        Me.stateInitializationActivity1 = New System.Workflow.Activities.StateInitializationActivity
        Me.LastState = New System.Workflow.Activities.StateActivity
        Me.InitialState = New System.Workflow.Activities.StateActivity
        '
        'ParallelRight2
        '
        Me.ParallelRight2.Name = "ParallelRight2"
        AddHandler Me.ParallelRight2.ExecuteCode, AddressOf Me.ParallelRight2_ExecuteCode
        '
        'ParallelRight1
        '
        Me.ParallelRight1.Name = "ParallelRight1"
        AddHandler Me.ParallelRight1.ExecuteCode, AddressOf Me.ParallelRight1_ExecuteCode
        '
        'ParallelLeft
        '
        Me.ParallelLeft.Name = "ParallelLeft"
        AddHandler Me.ParallelLeft.ExecuteCode, AddressOf Me.ParallelLeft_ExecuteCode
        '
        'sequenceActivity3
        '
        Me.sequenceActivity3.Activities.Add(Me.ParallelRight1)
        Me.sequenceActivity3.Activities.Add(Me.ParallelRight2)
        Me.sequenceActivity3.Name = "sequenceActivity3"
        '
        'sequenceActivity2
        '
        Me.sequenceActivity2.Activities.Add(Me.ParallelLeft)
        Me.sequenceActivity2.Name = "sequenceActivity2"
        '
        'Sequence2
        '
        Me.Sequence2.Name = "Sequence2"
        AddHandler Me.Sequence2.ExecuteCode, AddressOf Me.Sequence2_ExecuteCode
        '
        'Sequence1
        '
        Me.Sequence1.Name = "Sequence1"
        AddHandler Me.Sequence1.ExecuteCode, AddressOf Me.Sequence1_ExecuteCode
        '
        'parallelActivity1
        '
        Me.parallelActivity1.Activities.Add(Me.sequenceActivity2)
        Me.parallelActivity1.Activities.Add(Me.sequenceActivity3)
        Me.parallelActivity1.Name = "parallelActivity1"
        '
        'GoToLastState
        '
        Me.GoToLastState.Name = "GoToLastState"
        Me.GoToLastState.TargetStateName = "LastState"
        '
        'sequenceActivity1
        '
        Me.sequenceActivity1.Activities.Add(Me.Sequence1)
        Me.sequenceActivity1.Activities.Add(Me.Sequence2)
        Me.sequenceActivity1.Name = "sequenceActivity1"
        '
        'stateInitializationActivity2
        '
        Me.stateInitializationActivity2.Activities.Add(Me.parallelActivity1)
        Me.stateInitializationActivity2.Name = "stateInitializationActivity2"
        '
        'stateInitializationActivity1
        '
        Me.stateInitializationActivity1.Activities.Add(Me.sequenceActivity1)
        Me.stateInitializationActivity1.Activities.Add(Me.GoToLastState)
        Me.stateInitializationActivity1.Name = "stateInitializationActivity1"
        '
        'LastState
        '
        Me.LastState.Activities.Add(Me.stateInitializationActivity2)
        Me.LastState.Name = "LastState"
        '
        'InitialState
        '
        Me.InitialState.Activities.Add(Me.stateInitializationActivity1)
        Me.InitialState.Name = "InitialState"
        '
        'Workflow1
        '
        Me.Activities.Add(Me.InitialState)
        Me.Activities.Add(Me.LastState)
        Me.CompletedStateName = Nothing
        Me.DynamicUpdateCondition = Nothing
        Me.InitialStateName = "InitialState"
        Me.Name = "Workflow1"
        Me.CanModifyActivities = False

    End Sub
    Private stateInitializationActivity1 As System.Workflow.Activities.StateInitializationActivity
    Private sequenceActivity1 As System.Workflow.Activities.SequenceActivity
    Private Sequence1 As System.Workflow.Activities.CodeActivity
    Private Sequence2 As System.Workflow.Activities.CodeActivity
    Private GoToLastState As System.Workflow.Activities.SetStateActivity
    Private LastState As System.Workflow.Activities.StateActivity
    Private stateInitializationActivity2 As System.Workflow.Activities.StateInitializationActivity
    Private parallelActivity1 As System.Workflow.Activities.ParallelActivity
    Private sequenceActivity2 As System.Workflow.Activities.SequenceActivity
    Private ParallelLeft As System.Workflow.Activities.CodeActivity
    Private sequenceActivity3 As System.Workflow.Activities.SequenceActivity
    Private ParallelRight1 As System.Workflow.Activities.CodeActivity
    Private ParallelRight2 As System.Workflow.Activities.CodeActivity
    Private InitialState As System.Workflow.Activities.StateActivity


End Class
