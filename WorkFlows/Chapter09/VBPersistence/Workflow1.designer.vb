<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial class Workflow1

    'NOTE: The following procedure is required by the Workflow Designer
    'It can be modified using the Workflow Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Private Sub InitializeComponent()
        Me.CanModifyActivities = True
        Me.codeActivity2 = New System.Workflow.Activities.CodeActivity
        Me.suspendActivity1 = New System.Workflow.ComponentModel.SuspendActivity
        Me.delayActivity1 = New System.Workflow.Activities.DelayActivity
        Me.codeActivity1 = New System.Workflow.Activities.CodeActivity
        '
        'codeActivity2
        '
        Me.codeActivity2.Name = "codeActivity2"
        AddHandler Me.codeActivity2.ExecuteCode, AddressOf Me.codeActivity2_ExecuteCode
        '
        'suspendActivity1
        '
        Me.suspendActivity1.Name = "suspendActivity1"
        '
        'delayActivity1
        '
        Me.delayActivity1.Name = "delayActivity1"
        Me.delayActivity1.TimeoutDuration = System.TimeSpan.Parse("00:00:10")
        '
        'codeActivity1
        '
        Me.codeActivity1.Name = "codeActivity1"
        AddHandler Me.codeActivity1.ExecuteCode, AddressOf Me.codeActivity1_ExecuteCode
        '
        'Workflow1
        '
        Me.Activities.Add(Me.codeActivity1)
        Me.Activities.Add(Me.delayActivity1)
        Me.Activities.Add(Me.suspendActivity1)
        Me.Activities.Add(Me.codeActivity2)
        Me.Name = "Workflow1"
        Me.CanModifyActivities = False

    End Sub
    Private WithEvents delayActivity1 As System.Workflow.Activities.DelayActivity
    Private WithEvents codeActivity2 As System.Workflow.Activities.CodeActivity
    Private WithEvents suspendActivity1 As System.Workflow.ComponentModel.SuspendActivity
    Private WithEvents codeActivity1 As System.Workflow.Activities.CodeActivity

End Class
