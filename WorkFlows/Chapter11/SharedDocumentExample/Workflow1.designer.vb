<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial class Workflow1

    'NOTE: The following procedure is required by the Workflow Designer
    'It can be modified using the Workflow Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Private Sub InitializeComponent()
        Me.CanModifyActivities = True
        Dim activitybind1 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
        Dim correlationtoken1 As System.Workflow.Runtime.CorrelationToken = New System.Workflow.Runtime.CorrelationToken
        Dim correlationtoken2 As System.Workflow.Runtime.CorrelationToken = New System.Workflow.Runtime.CorrelationToken
        Dim codecondition1 As System.Workflow.Activities.CodeCondition = New System.Workflow.Activities.CodeCondition
        Dim correlationtoken3 As System.Workflow.Runtime.CorrelationToken = New System.Workflow.Runtime.CorrelationToken
        Dim activitybind2 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
        Dim activitybind3 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
        Dim correlationtoken4 As System.Workflow.Runtime.CorrelationToken = New System.Workflow.Runtime.CorrelationToken
        Dim activitybind4 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
        Me.onTaskChanged1 = New Microsoft.SharePoint.WorkflowActions.OnTaskChanged
        Me.completeTask1 = New Microsoft.SharePoint.WorkflowActions.CompleteTask
        Me.whileActivity1 = New System.Workflow.Activities.WhileActivity
        Me.createTask1 = New Microsoft.SharePoint.WorkflowActions.CreateTask
        Me.sequenceActivity1 = New System.Workflow.Activities.SequenceActivity
        Me.onWorkflowActivated1 = New Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated
        '
        'onTaskChanged1
        '
        activitybind1.Name = "Workflow1"
        activitybind1.Path = "AfterProps"
        Me.onTaskChanged1.BeforeProperties = Nothing
        correlationtoken1.Name = "TaskToken"
        correlationtoken1.OwnerActivityName = "Workflow1"
        Me.onTaskChanged1.CorrelationToken = correlationtoken1
        Me.onTaskChanged1.Executor = Nothing
        Me.onTaskChanged1.Name = "onTaskChanged1"
        Me.onTaskChanged1.TaskId = New System.Guid("00000000-0000-0000-0000-000000000000")
        AddHandler Me.onTaskChanged1.Invoked, AddressOf Me.OnTaskChanged
        Me.onTaskChanged1.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, CType(activitybind1, System.Workflow.ComponentModel.ActivityBind))
        '
        'completeTask1
        '
        correlationtoken2.Name = "TaskToken"
        correlationtoken2.OwnerActivityName = "Workflow1"
        Me.completeTask1.CorrelationToken = correlationtoken2
        Me.completeTask1.Name = "completeTask1"
        Me.completeTask1.TaskId = New System.Guid("00000000-0000-0000-0000-000000000000")
        Me.completeTask1.TaskOutcome = Nothing
        '
        'whileActivity1
        '
        Me.whileActivity1.Activities.Add(Me.onTaskChanged1)
        AddHandler codecondition1.Condition, AddressOf Me.NotFinished
        Me.whileActivity1.Condition = codecondition1
        Me.whileActivity1.Name = "whileActivity1"
        '
        'createTask1
        '
        correlationtoken3.Name = "TaskToken"
        correlationtoken3.OwnerActivityName = "Workflow1"
        Me.createTask1.CorrelationToken = correlationtoken3
        Me.createTask1.Name = "createTask1"
        Me.createTask1.SpecialPermissions = Nothing
        activitybind2.Name = "Workflow1"
        activitybind2.Path = "TaskID"
        activitybind3.Name = "Workflow1"
        activitybind3.Path = "TaskProp"
        AddHandler Me.createTask1.MethodInvoking, AddressOf Me.CreateTask
        Me.createTask1.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTask.TaskPropertiesProperty, CType(activitybind3, System.Workflow.ComponentModel.ActivityBind))
        Me.createTask1.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTask.TaskIdProperty, CType(activitybind2, System.Workflow.ComponentModel.ActivityBind))
        '
        'sequenceActivity1
        '
        Me.sequenceActivity1.Activities.Add(Me.createTask1)
        Me.sequenceActivity1.Activities.Add(Me.whileActivity1)
        Me.sequenceActivity1.Activities.Add(Me.completeTask1)
        Me.sequenceActivity1.Name = "sequenceActivity1"
        '
        'onWorkflowActivated1
        '
        correlationtoken4.Name = "workflowToken"
        correlationtoken4.OwnerActivityName = "Workflow1"
        Me.onWorkflowActivated1.CorrelationToken = correlationtoken4
        Me.onWorkflowActivated1.EventName = "OnWorkflowActivated"
        Me.onWorkflowActivated1.Name = "onWorkflowActivated1"
        Me.onWorkflowActivated1.WorkflowId = New System.Guid("00000000-0000-0000-0000-000000000000")
        activitybind4.Name = "Workflow1"
        activitybind4.Path = "workflowProperties"
        AddHandler Me.onWorkflowActivated1.Invoked, AddressOf Me.OnWorkflowActivated
        Me.onWorkflowActivated1.SetBinding(Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated.WorkflowPropertiesProperty, CType(activitybind4, System.Workflow.ComponentModel.ActivityBind))
        '
        'Workflow1
        '
        Me.Activities.Add(Me.onWorkflowActivated1)
        Me.Activities.Add(Me.sequenceActivity1)
        Me.Name = "Workflow1"
        Me.CanModifyActivities = False

    End Sub
    Private onTaskChanged1 As Microsoft.SharePoint.WorkflowActions.OnTaskChanged
    Private completeTask1 As Microsoft.SharePoint.WorkflowActions.CompleteTask
    Private whileActivity1 As System.Workflow.Activities.WhileActivity
    Private createTask1 As Microsoft.SharePoint.WorkflowActions.CreateTask
    Private sequenceActivity1 As System.Workflow.Activities.SequenceActivity
    Private onWorkflowActivated1 As Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated

End Class
