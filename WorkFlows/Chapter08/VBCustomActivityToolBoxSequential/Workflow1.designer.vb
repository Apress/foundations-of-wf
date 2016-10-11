<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial class Workflow1

    'NOTE: The following procedure is required by the Workflow Designer
    'It can be modified using the Workflow Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Private Sub InitializeComponent()
        Me.CanModifyActivities = True
        Me.simpleActivity1 = New SimpleActivity.SimpleActivity
        '
        'simpleActivity1
        '
        Me.simpleActivity1.Description = "This is a simple activity"
        Me.simpleActivity1.Name = "simpleActivity1"
        '
        'Workflow1
        '
        Me.Activities.Add(Me.simpleActivity1)
        Me.Name = "Workflow1"
        Me.CanModifyActivities = False

    End Sub
    Private WithEvents simpleActivity1 As SimpleActivity.SimpleActivity

End Class
