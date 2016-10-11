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
        Me.Workflow1InitialState = New System.Workflow.Activities.StateActivity
        '
        'Workflow1InitialState
        '
        Me.Workflow1InitialState.Name = "Workflow1InitialState"
        '
        'Workflow1
        '
        Me.Activities.Add(Me.Workflow1InitialState)
        Me.CompletedStateName = Nothing
        Me.DynamicUpdateCondition = Nothing
        Me.InitialStateName = "Workflow1InitialState"
        Me.Name = "Workflow1"
        Me.CanModifyActivities = False
    End Sub

    Private Workflow1InitialState As System.Workflow.Activities.StateActivity

End Class
