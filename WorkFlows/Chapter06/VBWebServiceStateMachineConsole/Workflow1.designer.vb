<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial class Workflow1

    'NOTE: The following procedure is required by the Workflow Designer
    'It can be modified using the Workflow Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Private Sub InitializeComponent()
        Me.CanModifyActivities = True
        Dim activitybind1 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
        Dim workflowparameterbinding1 As System.Workflow.ComponentModel.WorkflowParameterBinding = New System.Workflow.ComponentModel.WorkflowParameterBinding
        Dim workflowparameterbinding2 As System.Workflow.ComponentModel.WorkflowParameterBinding = New System.Workflow.ComponentModel.WorkflowParameterBinding
        Me.invokeWebServiceActivity1 = New System.Workflow.Activities.InvokeWebServiceActivity
        Me.BeforeInvokeCode = New System.Workflow.Activities.CodeActivity
        Me.delayActivity1 = New System.Workflow.Activities.DelayActivity
        Me.eventDrivenActivity1 = New System.Workflow.Activities.EventDrivenActivity
        Me.Workflow1InitialState = New System.Workflow.Activities.StateActivity
        '
        'invokeWebServiceActivity1
        '
        Me.invokeWebServiceActivity1.MethodName = "IsUser"
        Me.invokeWebServiceActivity1.Name = "invokeWebServiceActivity1"
        activitybind1.Name = "Workflow1"
        activitybind1.Path = "LoginName"
        workflowparameterbinding1.ParameterName = "UserName"
        workflowparameterbinding1.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, CType(activitybind1, System.Workflow.ComponentModel.ActivityBind))
        workflowparameterbinding2.ParameterName = "(ReturnValue)"
        workflowparameterbinding2.Value = False
        Me.invokeWebServiceActivity1.ParameterBindings.Add(workflowparameterbinding1)
        Me.invokeWebServiceActivity1.ParameterBindings.Add(workflowparameterbinding2)
        Me.invokeWebServiceActivity1.ProxyClass = GetType(VBWebServiceStateMachineConsole.SimpleWebService.Service)
        '
        'BeforeInvokeCode
        '
        Me.BeforeInvokeCode.Name = "BeforeInvokeCode"
        AddHandler Me.BeforeInvokeCode.ExecuteCode, AddressOf Me.BeforeInvokeCode_ExecuteCode
        '
        'delayActivity1
        '
        Me.delayActivity1.Name = "delayActivity1"
        Me.delayActivity1.TimeoutDuration = System.TimeSpan.Parse("00:00:10")
        '
        'eventDrivenActivity1
        '
        Me.eventDrivenActivity1.Activities.Add(Me.delayActivity1)
        Me.eventDrivenActivity1.Activities.Add(Me.BeforeInvokeCode)
        Me.eventDrivenActivity1.Activities.Add(Me.invokeWebServiceActivity1)
        Me.eventDrivenActivity1.Name = "eventDrivenActivity1"
        '
        'Workflow1InitialState
        '
        Me.Workflow1InitialState.Activities.Add(Me.eventDrivenActivity1)
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
    Private WithEvents eventDrivenActivity1 As System.Workflow.Activities.EventDrivenActivity
    Private WithEvents invokeWebServiceActivity1 As System.Workflow.Activities.InvokeWebServiceActivity
    Private WithEvents BeforeInvokeCode As System.Workflow.Activities.CodeActivity
    Private WithEvents delayActivity1 As System.Workflow.Activities.DelayActivity
    Private WithEvents Workflow1InitialState As System.Workflow.Activities.StateActivity


End Class
