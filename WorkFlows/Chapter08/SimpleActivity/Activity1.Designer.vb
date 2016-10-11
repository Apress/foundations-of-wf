<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SimpleActivity

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Private Sub InitializeComponent()
        Me.CanModifyActivities = True
        Me.ActivityCode = New System.Workflow.Activities.CodeActivity
        Me.SimpleCode = New System.Workflow.Activities.CodeActivity
        '
        'ActivityCode
        '
        Me.ActivityCode.Name = "ActivityCode"
        AddHandler Me.ActivityCode.ExecuteCode, AddressOf Me.ActivityCode_ExecuteCode
        '
        'SimpleCode
        '
        Me.SimpleCode.Name = "SimpleCode"
        AddHandler Me.SimpleCode.ExecuteCode, AddressOf Me.SimpleCode_ExecuteCode
        '
        'SimpleActivity
        '
        Me.Activities.Add(Me.SimpleCode)
        Me.Activities.Add(Me.ActivityCode)
        Me.Description = "This is a simple activity"
        Me.Name = "SimpleActivity"
        Me.CanModifyActivities = False

    End Sub
    Private WithEvents ActivityCode As System.Workflow.Activities.CodeActivity
    Private WithEvents SimpleCode As System.Workflow.Activities.CodeActivity

End Class

