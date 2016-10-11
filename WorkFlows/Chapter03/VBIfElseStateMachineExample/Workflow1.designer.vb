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
        Me.CompletedStated = New System.Workflow.Activities.StateActivity
        Me.FirstState = New System.Workflow.Activities.StateActivity
        Me.Branch1State = New System.Workflow.Activities.StateActivity
        Me.Branch2State = New System.Workflow.Activities.StateActivity
        Me.Branch1EventActivity = New System.Workflow.Activities.EventDrivenActivity
        Me.Branch2EventActivity = New System.Workflow.Activities.EventDrivenActivity
        Me.Branch1Delay = New System.Workflow.Activities.DelayActivity
        Me.Branch1Code = New System.Workflow.Activities.CodeActivity
        Me.Branch1SetState = New System.Workflow.Activities.SetStateActivity
        Me.Branch2Delay = New System.Workflow.Activities.DelayActivity
        Me.Branch2Code = New System.Workflow.Activities.CodeActivity
        Me.Branch2SetState = New System.Workflow.Activities.SetStateActivity
        Me.stateInitializationActivity1 = New System.Workflow.Activities.StateInitializationActivity
        Me.ifElseActivity1 = New System.Workflow.Activities.IfElseActivity
        Me.Branch1 = New System.Workflow.Activities.IfElseBranchActivity
        Me.Branch2 = New System.Workflow.Activities.IfElseBranchActivity
        Me.SetStateBranch1 = New System.Workflow.Activities.SetStateActivity
        Me.SetStateBranch2 = New System.Workflow.Activities.SetStateActivity
        Me.Branch3 = New System.Workflow.Activities.IfElseBranchActivity
        Me.SetStateBranch3 = New System.Workflow.Activities.SetStateActivity
        '
        'CompletedStated
        '
        Me.CompletedStated.Name = "CompletedStated"
        '
        'FirstState
        '
        Me.FirstState.Activities.Add(Me.stateInitializationActivity1)
        Me.FirstState.Name = "FirstState"
        '
        'Branch1State
        '
        Me.Branch1State.Activities.Add(Me.Branch1EventActivity)
        Me.Branch1State.Name = "Branch1State"
        '
        'Branch2State
        '
        Me.Branch2State.Activities.Add(Me.Branch2EventActivity)
        Me.Branch2State.Name = "Branch2State"
        '
        'Branch1EventActivity
        '
        Me.Branch1EventActivity.Activities.Add(Me.Branch1Delay)
        Me.Branch1EventActivity.Activities.Add(Me.Branch1Code)
        Me.Branch1EventActivity.Activities.Add(Me.Branch1SetState)
        Me.Branch1EventActivity.Name = "Branch1EventActivity"
        '
        'Branch2EventActivity
        '
        Me.Branch2EventActivity.Activities.Add(Me.Branch2Delay)
        Me.Branch2EventActivity.Activities.Add(Me.Branch2Code)
        Me.Branch2EventActivity.Activities.Add(Me.Branch2SetState)
        Me.Branch2EventActivity.Name = "Branch2EventActivity"
        '
        'Branch1Delay
        '
        Me.Branch1Delay.Name = "Branch1Delay"
        Me.Branch1Delay.TimeoutDuration = System.TimeSpan.Parse("00:00:05")
        '
        'Branch1Code
        '
        Me.Branch1Code.Name = "Branch1Code"
        AddHandler Me.Branch1Code.ExecuteCode, AddressOf Me.Branch1Code_ExecuteCode
        '
        'Branch1SetState
        '
        Me.Branch1SetState.Name = "Branch1SetState"
        Me.Branch1SetState.TargetStateName = "CompletedStated"
        '
        'Branch2Delay
        '
        Me.Branch2Delay.Name = "Branch2Delay"
        Me.Branch2Delay.TimeoutDuration = System.TimeSpan.Parse("00:00:05")
        '
        'Branch2Code
        '
        Me.Branch2Code.Name = "Branch2Code"
        AddHandler Me.Branch2Code.ExecuteCode, AddressOf Me.Branch2Code_ExecuteCode
        '
        'Branch2SetState
        '
        Me.Branch2SetState.Name = "Branch2SetState"
        Me.Branch2SetState.TargetStateName = "CompletedStated"
        '
        'stateInitializationActivity1
        '
        Me.stateInitializationActivity1.Activities.Add(Me.ifElseActivity1)
        Me.stateInitializationActivity1.Name = "stateInitializationActivity1"
        '
        'ifElseActivity1
        '
        Me.ifElseActivity1.Activities.Add(Me.Branch1)
        Me.ifElseActivity1.Activities.Add(Me.Branch2)
        Me.ifElseActivity1.Activities.Add(Me.Branch3)
        Me.ifElseActivity1.Name = "ifElseActivity1"
        '
        'Branch1
        '
        Me.Branch1.Activities.Add(Me.SetStateBranch1)
        AddHandler codecondition1.Condition, AddressOf Me.Branch1Condition
        Me.Branch1.Condition = codecondition1
        Me.Branch1.Name = "Branch1"
        '
        'Branch2
        '
        Me.Branch2.Activities.Add(Me.SetStateBranch2)
        AddHandler codecondition2.Condition, AddressOf Me.Branch2Condition
        Me.Branch2.Condition = codecondition2
        Me.Branch2.Name = "Branch2"
        '
        'SetStateBranch1
        '
        Me.SetStateBranch1.Name = "SetStateBranch1"
        Me.SetStateBranch1.TargetStateName = "Branch1State"
        '
        'SetStateBranch2
        '
        Me.SetStateBranch2.Name = "SetStateBranch2"
        Me.SetStateBranch2.TargetStateName = "Branch2State"
        '
        'Branch3
        '
        Me.Branch3.Activities.Add(Me.SetStateBranch3)
        Me.Branch3.Name = "Branch3"
        '
        'SetStateBranch3
        '
        Me.SetStateBranch3.Name = "SetStateBranch3"
        Me.SetStateBranch3.TargetStateName = "CompletedStated"
        '
        'Workflow1
        '
        Me.Activities.Add(Me.CompletedStated)
        Me.Activities.Add(Me.FirstState)
        Me.Activities.Add(Me.Branch1State)
        Me.Activities.Add(Me.Branch2State)
        Me.CompletedStateName = "CompletedStated"
        Me.DynamicUpdateCondition = Nothing
        Me.InitialStateName = "FirstState"
        Me.Name = "Workflow1"
        Me.CanModifyActivities = False

    End Sub
    Private WithEvents FirstState As System.Workflow.Activities.StateActivity
    Private WithEvents Branch1State As System.Workflow.Activities.StateActivity
    Private WithEvents Branch1EventActivity As System.Workflow.Activities.EventDrivenActivity
    Private WithEvents Branch1Delay As System.Workflow.Activities.DelayActivity
    Private WithEvents Branch1Code As System.Workflow.Activities.CodeActivity
    Private WithEvents Branch2State As System.Workflow.Activities.StateActivity
    Private WithEvents Branch2EventActivity As System.Workflow.Activities.EventDrivenActivity
    Private WithEvents Branch1SetState As System.Workflow.Activities.SetStateActivity
    Private WithEvents Branch2Delay As System.Workflow.Activities.DelayActivity
    Private WithEvents Branch2Code As System.Workflow.Activities.CodeActivity
    Private WithEvents Branch2SetState As System.Workflow.Activities.SetStateActivity
    Private WithEvents stateInitializationActivity1 As System.Workflow.Activities.StateInitializationActivity
    Private WithEvents ifElseActivity1 As System.Workflow.Activities.IfElseActivity
    Private WithEvents Branch1 As System.Workflow.Activities.IfElseBranchActivity
    Private WithEvents Branch2 As System.Workflow.Activities.IfElseBranchActivity
    Private WithEvents SetStateBranch1 As System.Workflow.Activities.SetStateActivity
    Private WithEvents SetStateBranch2 As System.Workflow.Activities.SetStateActivity
    Private WithEvents Branch3 As System.Workflow.Activities.IfElseBranchActivity
    Private WithEvents SetStateBranch3 As System.Workflow.Activities.SetStateActivity
    Private WithEvents CompletedStated As System.Workflow.Activities.StateActivity


End Class
