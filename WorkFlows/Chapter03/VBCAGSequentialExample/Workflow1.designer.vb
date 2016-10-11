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
        Dim codecondition3 As System.Workflow.Activities.CodeCondition = New System.Workflow.Activities.CodeCondition
        Dim codecondition1 As System.Workflow.Activities.CodeCondition = New System.Workflow.Activities.CodeCondition
        Dim codecondition2 As System.Workflow.Activities.CodeCondition = New System.Workflow.Activities.CodeCondition
        Me.conditionedActivityGroup1 = New System.Workflow.Activities.ConditionedActivityGroup
        Me.Code1 = New System.Workflow.Activities.CodeActivity
        Me.Code2 = New System.Workflow.Activities.CodeActivity
        '
        'conditionedActivityGroup1
        '
        Me.conditionedActivityGroup1.Activities.Add(Me.Code1)
        Me.conditionedActivityGroup1.Activities.Add(Me.Code2)
        Me.conditionedActivityGroup1.Name = "conditionedActivityGroup1"
        AddHandler codecondition3.Condition, AddressOf Me.UntilCondition
        Me.conditionedActivityGroup1.UntilCondition = codecondition3
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
        AddHandler Me.Code2.ExecuteCode, AddressOf Me.Code2_ExecuteCode
        Me.Code2.SetValue(System.Workflow.Activities.ConditionedActivityGroup.WhenConditionProperty, codecondition2)
        '
        'Workflow1
        '
        Me.Activities.Add(Me.conditionedActivityGroup1)
        Me.Name = "Workflow1"
        Me.CanModifyActivities = False

    End Sub
    Private WithEvents conditionedActivityGroup1 As System.Workflow.Activities.ConditionedActivityGroup
    Private WithEvents Code2 As System.Workflow.Activities.CodeActivity
    Private WithEvents Code1 As System.Workflow.Activities.CodeActivity

End Class
