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
        Dim codecondition1 As System.Workflow.Activities.CodeCondition = New System.Workflow.Activities.CodeCondition
        Dim codecondition2 As System.Workflow.Activities.CodeCondition = New System.Workflow.Activities.CodeCondition
        Me.ifElseActivity1 = New System.Workflow.Activities.IfElseActivity
        Me.Branch1 = New System.Workflow.Activities.IfElseBranchActivity
        Me.Branch2 = New System.Workflow.Activities.IfElseBranchActivity
        Me.Branch1Code = New System.Workflow.Activities.CodeActivity
        Me.Branch2Code = New System.Workflow.Activities.CodeActivity
        '
        'ifElseActivity1
        '
        Me.ifElseActivity1.Activities.Add(Me.Branch1)
        Me.ifElseActivity1.Activities.Add(Me.Branch2)
        Me.ifElseActivity1.Name = "ifElseActivity1"
        '
        'Branch1
        '
        Me.Branch1.Activities.Add(Me.Branch1Code)
        AddHandler codecondition1.Condition, AddressOf Me.Branch1Condition
        Me.Branch1.Condition = codecondition1
        Me.Branch1.Name = "Branch1"
        '
        'Branch2
        '
        Me.Branch2.Activities.Add(Me.Branch2Code)
        AddHandler codecondition2.Condition, AddressOf Me.Branch2Condition
        Me.Branch2.Condition = codecondition2
        Me.Branch2.Name = "Branch2"
        '
        'Branch1Code
        '
        Me.Branch1Code.Description = "Code to execute for Branch 1"
        Me.Branch1Code.Name = "Branch1Code"
        AddHandler Me.Branch1Code.ExecuteCode, AddressOf Me.Branch1Code_ExecuteCode
        '
        'Branch2Code
        '
        Me.Branch2Code.Name = "Branch2Code"
        AddHandler Me.Branch2Code.ExecuteCode, AddressOf Me.Branch2Code_ExecuteCode
        '
        'Workflow1
        '
        Me.Activities.Add(Me.ifElseActivity1)
        Me.Name = "Workflow1"
        Me.CanModifyActivities = False

    End Sub
    Private WithEvents ifElseActivity1 As System.Workflow.Activities.IfElseActivity
    Private WithEvents Branch1 As System.Workflow.Activities.IfElseBranchActivity
    Private WithEvents Branch1Code As System.Workflow.Activities.CodeActivity
    Private WithEvents Branch2Code As System.Workflow.Activities.CodeActivity
    Private WithEvents Branch2 As System.Workflow.Activities.IfElseBranchActivity

End Class
