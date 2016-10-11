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
        Dim rulesetreference1 As System.Workflow.Activities.Rules.RuleSetReference = New System.Workflow.Activities.Rules.RuleSetReference
        Me.AfterPolicyCode = New System.Workflow.Activities.CodeActivity
        Me.policyActivity1 = New System.Workflow.Activities.PolicyActivity
        Me.BeforePolicyCode = New System.Workflow.Activities.CodeActivity
        '
        'AfterPolicyCode
        '
        Me.AfterPolicyCode.Name = "AfterPolicyCode"
        AddHandler Me.AfterPolicyCode.ExecuteCode, AddressOf Me.AfterPolicyCode_ExecuteCode
        '
        'policyActivity1
        '
        Me.policyActivity1.Name = "policyActivity1"
        rulesetreference1.RuleSetName = "RuleSet1"
        Me.policyActivity1.RuleSetReference = rulesetreference1
        '
        'BeforePolicyCode
        '
        Me.BeforePolicyCode.Name = "BeforePolicyCode"
        AddHandler Me.BeforePolicyCode.ExecuteCode, AddressOf Me.BeforePolicyCode_ExecuteCode
        '
        'Workflow1
        '
        Me.Activities.Add(Me.BeforePolicyCode)
        Me.Activities.Add(Me.policyActivity1)
        Me.Activities.Add(Me.AfterPolicyCode)
        Me.Name = "Workflow1"
        Me.CanModifyActivities = False

    End Sub
    Private WithEvents AfterPolicyCode As System.Workflow.Activities.CodeActivity
    Private WithEvents BeforePolicyCode As System.Workflow.Activities.CodeActivity
    Private WithEvents policyActivity1 As System.Workflow.Activities.PolicyActivity

End Class
