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
        Me.Step1 = New System.Workflow.Activities.CodeActivity
        Me.Step2 = New System.Workflow.Activities.CodeActivity
        '
        'Step1
        '
        Me.Step1.Description = "Step 1 in the process"
        Me.Step1.Name = "Step1"
        AddHandler Me.Step1.ExecuteCode, AddressOf Me.Step1_ExecuteCode
        '
        'Step2
        '
        Me.Step2.Description = "Step 2 in process"
        Me.Step2.Name = "Step2"
        AddHandler Me.Step2.ExecuteCode, AddressOf Me.Step2_ExecuteCode
        '
        'Workflow1
        '
        Me.Activities.Add(Me.Step1)
        Me.Activities.Add(Me.Step2)
        Me.Name = "Workflow1"
        
        Me.CanModifyActivities = False

    End Sub
    Private WithEvents Step2 As System.Workflow.Activities.CodeActivity
    Private WithEvents Step1 As System.Workflow.Activities.CodeActivity

End Class
