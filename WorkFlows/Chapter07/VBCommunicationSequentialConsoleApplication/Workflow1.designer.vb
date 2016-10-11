<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial class Workflow1

    'NOTE: The following procedure is required by the Workflow Designer
    'It can be modified using the Workflow Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Private Sub InitializeComponent()
        Me.CanModifyActivities = True
        Dim workflowparameterbinding1 As System.Workflow.ComponentModel.WorkflowParameterBinding = New System.Workflow.ComponentModel.WorkflowParameterBinding
        Dim workflowparameterbinding2 As System.Workflow.ComponentModel.WorkflowParameterBinding = New System.Workflow.ComponentModel.WorkflowParameterBinding
        Me.HandleReviewNotApproved = New System.Workflow.Activities.HandleExternalEventActivity
        Me.HandleReviewApproval = New System.Workflow.Activities.HandleExternalEventActivity
        Me.eventDrivenActivity2 = New System.Workflow.Activities.EventDrivenActivity
        Me.eventDrivenActivity1 = New System.Workflow.Activities.EventDrivenActivity
        Me.ReviewResponse = New System.Workflow.Activities.ListenActivity
        Me.callCreateReview = New System.Workflow.Activities.CallExternalMethodActivity
        '
        'HandleReviewNotApproved
        '
        Me.HandleReviewNotApproved.EventName = "ReviewNotApproved"
        Me.HandleReviewNotApproved.InterfaceType = GetType(VBCommunicationSequentialConsoleApplication.IReview)
        Me.HandleReviewNotApproved.Name = "HandleReviewNotApproved"
        AddHandler Me.HandleReviewNotApproved.Invoked, AddressOf Me.OnNotApproved
        '
        'HandleReviewApproval
        '
        Me.HandleReviewApproval.EventName = "ReviewApproved"
        Me.HandleReviewApproval.InterfaceType = GetType(VBCommunicationSequentialConsoleApplication.IReview)
        Me.HandleReviewApproval.Name = "HandleReviewApproval"
        AddHandler Me.HandleReviewApproval.Invoked, AddressOf Me.OnApproved
        '
        'eventDrivenActivity2
        '
        Me.eventDrivenActivity2.Activities.Add(Me.HandleReviewNotApproved)
        Me.eventDrivenActivity2.Name = "eventDrivenActivity2"
        '
        'eventDrivenActivity1
        '
        Me.eventDrivenActivity1.Activities.Add(Me.HandleReviewApproval)
        Me.eventDrivenActivity1.Name = "eventDrivenActivity1"
        '
        'ReviewResponse
        '
        Me.ReviewResponse.Activities.Add(Me.eventDrivenActivity1)
        Me.ReviewResponse.Activities.Add(Me.eventDrivenActivity2)
        Me.ReviewResponse.Name = "ReviewResponse"
        '
        'callCreateReview
        '
        Me.callCreateReview.InterfaceType = GetType(VBCommunicationSequentialConsoleApplication.IReview)
        Me.callCreateReview.MethodName = "CreateReview"
        Me.callCreateReview.Name = "callCreateReview"
        workflowparameterbinding1.ParameterName = "Reviewee"
        workflowparameterbinding1.Value = "You"
        workflowparameterbinding2.ParameterName = "Reviewer"
        workflowparameterbinding2.Value = "Me"
        Me.callCreateReview.ParameterBindings.Add(workflowparameterbinding1)
        Me.callCreateReview.ParameterBindings.Add(workflowparameterbinding2)
        '
        'Workflow1
        '
        Me.Activities.Add(Me.callCreateReview)
        Me.Activities.Add(Me.ReviewResponse)
        Me.Name = "Workflow1"
        Me.CanModifyActivities = False

    End Sub
    Private HandleReviewApproval As System.Workflow.Activities.HandleExternalEventActivity
    Private eventDrivenActivity2 As System.Workflow.Activities.EventDrivenActivity
    Private eventDrivenActivity1 As System.Workflow.Activities.EventDrivenActivity
    Private ReviewResponse As System.Workflow.Activities.ListenActivity
    Private HandleReviewNotApproved As System.Workflow.Activities.HandleExternalEventActivity
    Private callCreateReview As System.Workflow.Activities.CallExternalMethodActivity

End Class
