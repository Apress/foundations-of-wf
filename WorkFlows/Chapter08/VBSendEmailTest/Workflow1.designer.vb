<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial class Workflow1

    'NOTE: The following procedure is required by the Workflow Designer
    'It can be modified using the Workflow Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Private Sub InitializeComponent()
        Me.CanModifyActivities = True
        Me.sendEmailVB1 = New SendEmail.SendEmailVB
        '
        'sendEmailVB1
        '
        Me.sendEmailVB1.Body = Nothing
        Me.sendEmailVB1.Description = "Use to send email via SMTP, uses VB"
        Me.sendEmailVB1.From = ""
        Me.sendEmailVB1.Name = "sendEmailVB1"
        Me.sendEmailVB1.SmtpHost = "localhost"
        Me.sendEmailVB1.Subject = Nothing
        Me.sendEmailVB1.ToAddress = "someone@example.com"
        '
        'Workflow1
        '
        Me.Activities.Add(Me.sendEmailVB1)
        Me.Name = "Workflow1"
        Me.CanModifyActivities = False

    End Sub
    Private WithEvents sendEmailVB1 As SendEmail.SendEmailVB

End Class
