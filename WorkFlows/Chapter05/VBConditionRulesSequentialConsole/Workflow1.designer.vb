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
        Dim ruleconditionreference1 As System.Workflow.Activities.Rules.RuleConditionReference = New System.Workflow.Activities.Rules.RuleConditionReference
        Dim ruleconditionreference2 As System.Workflow.Activities.Rules.RuleConditionReference = New System.Workflow.Activities.Rules.RuleConditionReference
        Me.LessThanEqual0Code = New System.Workflow.Activities.CodeActivity
        Me.GreaterThan0Code = New System.Workflow.Activities.CodeActivity
        Me.LessThanEqual0 = New System.Workflow.Activities.IfElseBranchActivity
        Me.GreaterThan0 = New System.Workflow.Activities.IfElseBranchActivity
        Me.ifElseActivity1 = New System.Workflow.Activities.IfElseActivity
        '
        'LessThanEqual0Code
        '
        Me.LessThanEqual0Code.Name = "LessThanEqual0Code"
        AddHandler Me.LessThanEqual0Code.ExecuteCode, AddressOf Me.LessThanEqual0Code_ExecuteCode
        '
        'GreaterThan0Code
        '
        Me.GreaterThan0Code.Name = "GreaterThan0Code"
        AddHandler Me.GreaterThan0Code.ExecuteCode, AddressOf Me.GreaterThan0Code_ExecuteCode
        '
        'LessThanEqual0
        '
        Me.LessThanEqual0.Activities.Add(Me.LessThanEqual0Code)
        ruleconditionreference1.ConditionName = "Condition2"
        Me.LessThanEqual0.Condition = ruleconditionreference1
        Me.LessThanEqual0.Name = "LessThanEqual0"
        '
        'GreaterThan0
        '
        Me.GreaterThan0.Activities.Add(Me.GreaterThan0Code)
        ruleconditionreference2.ConditionName = "Condition1"
        Me.GreaterThan0.Condition = ruleconditionreference2
        Me.GreaterThan0.Name = "GreaterThan0"
        '
        'ifElseActivity1
        '
        Me.ifElseActivity1.Activities.Add(Me.GreaterThan0)
        Me.ifElseActivity1.Activities.Add(Me.LessThanEqual0)
        Me.ifElseActivity1.Name = "ifElseActivity1"
        '
        'Workflow1
        '
        Me.Activities.Add(Me.ifElseActivity1)
        Me.Name = "Workflow1"
        Me.CanModifyActivities = False

    End Sub
    Private WithEvents ifElseActivity1 As System.Workflow.Activities.IfElseActivity
    Private WithEvents GreaterThan0 As System.Workflow.Activities.IfElseBranchActivity
    Private WithEvents GreaterThan0Code As System.Workflow.Activities.CodeActivity
    Private WithEvents LessThanEqual0Code As System.Workflow.Activities.CodeActivity
    Private WithEvents LessThanEqual0 As System.Workflow.Activities.IfElseBranchActivity

End Class
