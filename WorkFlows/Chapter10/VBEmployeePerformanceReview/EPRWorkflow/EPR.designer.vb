<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EPR

    'NOTE: The following procedure is required by the Workflow Designer
    'It can be modified using the Workflow Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Private Sub InitializeComponent()
        Me.CanModifyActivities = True
        Me.TransitionToCompleted2 = New System.Workflow.Activities.SetStateActivity
        Me.SendNotApprovedEmailToHR = New SendEmail.SendEmailVB
        Me.HandleEmployeeDoesNotApprove = New System.Workflow.Activities.HandleExternalEventActivity
        Me.TransitionToCompleted = New System.Workflow.Activities.SetStateActivity
        Me.SendApprovedEmailToHR = New SendEmail.SendEmailVB
        Me.HandleEmployeeApproved = New System.Workflow.Activities.HandleExternalEventActivity
        Me.TransitionToEmployeeChoice = New System.Workflow.Activities.SetStateActivity
        Me.SendEmailToEmployee = New SendEmail.SendEmailVB
        Me.HandleToEmployee = New System.Workflow.Activities.HandleExternalEventActivity
        Me.TransitionToSupervisor = New System.Workflow.Activities.SetStateActivity
        Me.SendEmailToSupervisor = New SendEmail.SendEmailVB
        Me.HandleToSupervisor = New System.Workflow.Activities.HandleExternalEventActivity
        Me.EmployeeDoesNotApprove = New System.Workflow.Activities.EventDrivenActivity
        Me.EmployeeApproves = New System.Workflow.Activities.EventDrivenActivity
        Me.HandleSupervisorToEmployee = New System.Workflow.Activities.EventDrivenActivity
        Me.EmployeeToSupervisor = New System.Workflow.Activities.EventDrivenActivity
        Me.Completed = New System.Workflow.Activities.StateActivity
        Me.EmployeeChoice = New System.Workflow.Activities.StateActivity
        Me.SupervisorToEmployee = New System.Workflow.Activities.StateActivity
        Me.ReviewToSupervisor = New System.Workflow.Activities.StateActivity
        '
        'TransitionToCompleted2
        '
        Me.TransitionToCompleted2.Name = "TransitionToCompleted2"
        Me.TransitionToCompleted2.TargetStateName = "Completed"
        '
        'SendNotApprovedEmailToHR
        '
        Me.SendNotApprovedEmailToHR.Body = Nothing
        Me.SendNotApprovedEmailToHR.Description = "Use to send email via SMTP, uses VB"
        Me.SendNotApprovedEmailToHR.From = "someone@example.com"
        Me.SendNotApprovedEmailToHR.Name = "SendNotApprovedEmailToHR"
        Me.SendNotApprovedEmailToHR.SmtpHost = "localhost"
        Me.SendNotApprovedEmailToHR.Subject = Nothing
        Me.SendNotApprovedEmailToHR.ToAddress = "someone@example.com"
        '
        'HandleEmployeeDoesNotApprove
        '
        Me.HandleEmployeeDoesNotApprove.EventName = "EmployeeNotApproved"
        Me.HandleEmployeeDoesNotApprove.InterfaceType = GetType(EPRService.IEPRService)
        Me.HandleEmployeeDoesNotApprove.Name = "HandleEmployeeDoesNotApprove"
        '
        'TransitionToCompleted
        '
        Me.TransitionToCompleted.Name = "TransitionToCompleted"
        Me.TransitionToCompleted.TargetStateName = "Completed"
        '
        'SendApprovedEmailToHR
        '
        Me.SendApprovedEmailToHR.Body = Nothing
        Me.SendApprovedEmailToHR.Description = "Use to send email via SMTP, uses VB"
        Me.SendApprovedEmailToHR.From = "someone@example.com"
        Me.SendApprovedEmailToHR.Name = "SendApprovedEmailToHR"
        Me.SendApprovedEmailToHR.SmtpHost = "localhost"
        Me.SendApprovedEmailToHR.Subject = Nothing
        Me.SendApprovedEmailToHR.ToAddress = "someone@example.com"
        '
        'HandleEmployeeApproved
        '
        Me.HandleEmployeeApproved.EventName = "EmployeeApproved"
        Me.HandleEmployeeApproved.InterfaceType = GetType(EPRService.IEPRService)
        Me.HandleEmployeeApproved.Name = "HandleEmployeeApproved"
        AddHandler Me.HandleEmployeeApproved.Invoked, AddressOf Me.ProcessApproved
        '
        'TransitionToEmployeeChoice
        '
        Me.TransitionToEmployeeChoice.Name = "TransitionToEmployeeChoice"
        Me.TransitionToEmployeeChoice.TargetStateName = "EmployeeChoice"
        '
        'SendEmailToEmployee
        '
        Me.SendEmailToEmployee.Body = Nothing
        Me.SendEmailToEmployee.Description = "Use to send email via SMTP, uses VB"
        Me.SendEmailToEmployee.From = "someone@example.com"
        Me.SendEmailToEmployee.Name = "SendEmailToEmployee"
        Me.SendEmailToEmployee.SmtpHost = "localhost"
        Me.SendEmailToEmployee.Subject = Nothing
        Me.SendEmailToEmployee.ToAddress = "someone@example.com"
        '
        'HandleToEmployee
        '
        Me.HandleToEmployee.EventName = "SupervisorToEmployee"
        Me.HandleToEmployee.InterfaceType = GetType(EPRService.IEPRService)
        Me.HandleToEmployee.Name = "HandleToEmployee"
        AddHandler Me.HandleToEmployee.Invoked, AddressOf Me.ProcessToEmployee
        '
        'TransitionToSupervisor
        '
        Me.TransitionToSupervisor.Name = "TransitionToSupervisor"
        Me.TransitionToSupervisor.TargetStateName = "SupervisorToEmployee"
        '
        'SendEmailToSupervisor
        '
        Me.SendEmailToSupervisor.Body = Nothing
        Me.SendEmailToSupervisor.Description = "Use to send email via SMTP, uses VB"
        Me.SendEmailToSupervisor.From = "someone@example.com"
        Me.SendEmailToSupervisor.Name = "SendEmailToSupervisor"
        Me.SendEmailToSupervisor.SmtpHost = "localhost"
        Me.SendEmailToSupervisor.Subject = Nothing
        Me.SendEmailToSupervisor.ToAddress = "someone@example.com"
        '
        'HandleToSupervisor
        '
        Me.HandleToSupervisor.Description = "Handle the To Supervisor event"
        Me.HandleToSupervisor.EventName = "EmployeeToSupervisor"
        Me.HandleToSupervisor.InterfaceType = GetType(EPRService.IEPRService)
        Me.HandleToSupervisor.Name = "HandleToSupervisor"
        AddHandler Me.HandleToSupervisor.Invoked, AddressOf Me.ProcessToSupervisor
        '
        'EmployeeDoesNotApprove
        '
        Me.EmployeeDoesNotApprove.Activities.Add(Me.HandleEmployeeDoesNotApprove)
        Me.EmployeeDoesNotApprove.Activities.Add(Me.SendNotApprovedEmailToHR)
        Me.EmployeeDoesNotApprove.Activities.Add(Me.TransitionToCompleted2)
        Me.EmployeeDoesNotApprove.Name = "EmployeeDoesNotApprove"
        '
        'EmployeeApproves
        '
        Me.EmployeeApproves.Activities.Add(Me.HandleEmployeeApproved)
        Me.EmployeeApproves.Activities.Add(Me.SendApprovedEmailToHR)
        Me.EmployeeApproves.Activities.Add(Me.TransitionToCompleted)
        Me.EmployeeApproves.Name = "EmployeeApproves"
        '
        'HandleSupervisorToEmployee
        '
        Me.HandleSupervisorToEmployee.Activities.Add(Me.HandleToEmployee)
        Me.HandleSupervisorToEmployee.Activities.Add(Me.SendEmailToEmployee)
        Me.HandleSupervisorToEmployee.Activities.Add(Me.TransitionToEmployeeChoice)
        Me.HandleSupervisorToEmployee.Name = "HandleSupervisorToEmployee"
        '
        'EmployeeToSupervisor
        '
        Me.EmployeeToSupervisor.Activities.Add(Me.HandleToSupervisor)
        Me.EmployeeToSupervisor.Activities.Add(Me.SendEmailToSupervisor)
        Me.EmployeeToSupervisor.Activities.Add(Me.TransitionToSupervisor)
        Me.EmployeeToSupervisor.Description = "Employee Sends To Supervisor"
        Me.EmployeeToSupervisor.Name = "EmployeeToSupervisor"
        '
        'Completed
        '
        Me.Completed.Name = "Completed"
        '
        'EmployeeChoice
        '
        Me.EmployeeChoice.Activities.Add(Me.EmployeeApproves)
        Me.EmployeeChoice.Activities.Add(Me.EmployeeDoesNotApprove)
        Me.EmployeeChoice.Name = "EmployeeChoice"
        '
        'SupervisorToEmployee
        '
        Me.SupervisorToEmployee.Activities.Add(Me.HandleSupervisorToEmployee)
        Me.SupervisorToEmployee.Name = "SupervisorToEmployee"
        '
        'ReviewToSupervisor
        '
        Me.ReviewToSupervisor.Activities.Add(Me.EmployeeToSupervisor)
        Me.ReviewToSupervisor.Description = "Send review to the supervisor"
        Me.ReviewToSupervisor.Name = "ReviewToSupervisor"
        '
        'EPR
        '
        Me.Activities.Add(Me.ReviewToSupervisor)
        Me.Activities.Add(Me.SupervisorToEmployee)
        Me.Activities.Add(Me.EmployeeChoice)
        Me.Activities.Add(Me.Completed)
        Me.CompletedStateName = "Completed"
        Me.DynamicUpdateCondition = Nothing
        Me.InitialStateName = "ReviewToSupervisor"
        Me.Name = "EPR"
        Me.CanModifyActivities = False

    End Sub
    Private EmployeeDoesNotApprove As System.Workflow.Activities.EventDrivenActivity
    Private EmployeeApproves As System.Workflow.Activities.EventDrivenActivity
    Private Completed As System.Workflow.Activities.StateActivity
    Private HandleEmployeeApproved As System.Workflow.Activities.HandleExternalEventActivity
    Private TransitionToCompleted As System.Workflow.Activities.SetStateActivity
    Private SendApprovedEmailToHR As SendEmail.SendEmailVB
    Private TransitionToCompleted2 As System.Workflow.Activities.SetStateActivity
    Private SendNotApprovedEmailToHR As SendEmail.SendEmailVB
    Private HandleEmployeeDoesNotApprove As System.Workflow.Activities.HandleExternalEventActivity
    Private TransitionToSupervisor As System.Workflow.Activities.SetStateActivity
    Private SendEmailToSupervisor As SendEmail.SendEmailVB
    Private HandleToSupervisor As System.Workflow.Activities.HandleExternalEventActivity
    Private EmployeeToSupervisor As System.Workflow.Activities.EventDrivenActivity
    Private HandleToEmployee As System.Workflow.Activities.HandleExternalEventActivity
    Private SendEmailToEmployee As SendEmail.SendEmailVB
    Private EmployeeChoice As System.Workflow.Activities.StateActivity
    Private TransitionToEmployeeChoice As System.Workflow.Activities.SetStateActivity
    Private HandleSupervisorToEmployee As System.Workflow.Activities.EventDrivenActivity
    Private SupervisorToEmployee As System.Workflow.Activities.StateActivity
    Private ReviewToSupervisor As System.Workflow.Activities.StateActivity


End Class
