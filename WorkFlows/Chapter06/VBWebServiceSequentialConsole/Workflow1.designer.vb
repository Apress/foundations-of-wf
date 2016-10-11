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
        Dim activitybind2 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
        Dim workflowparameterbinding2 As System.Workflow.ComponentModel.WorkflowParameterBinding = New System.Workflow.ComponentModel.WorkflowParameterBinding
        Me.eventDrivenActivity2 = New System.Workflow.Activities.EventDrivenActivity
        Me.eventDrivenActivity1 = New System.Workflow.Activities.EventDrivenActivity
        Me.listenActivity1 = New System.Workflow.Activities.ListenActivity
        Me.AfterInvokeCode = New System.Workflow.Activities.CodeActivity
        Me.InvokeSimpleWebService = New System.Workflow.Activities.InvokeWebServiceActivity
        Me.BeforeInvokeCode = New System.Workflow.Activities.CodeActivity
        '
        'eventDrivenActivity2
        '
        Me.eventDrivenActivity2.Name = "eventDrivenActivity2"
        '
        'eventDrivenActivity1
        '
        Me.eventDrivenActivity1.Name = "eventDrivenActivity1"
        '
        'listenActivity1
        '
        Me.listenActivity1.Activities.Add(Me.eventDrivenActivity1)
        Me.listenActivity1.Activities.Add(Me.eventDrivenActivity2)
        Me.listenActivity1.Name = "listenActivity1"
        '
        'AfterInvokeCode
        '
        Me.AfterInvokeCode.Name = "AfterInvokeCode"
        AddHandler Me.AfterInvokeCode.ExecuteCode, AddressOf Me.AfterInvokeCode_ExecuteCode
        '
        'InvokeSimpleWebService
        '
        Me.InvokeSimpleWebService.MethodName = "IsUser"
        Me.InvokeSimpleWebService.Name = "InvokeSimpleWebService"
        activitybind1.Name = "Workflow1"
        activitybind1.Path = "ValueReturned"
        workflowparameterbinding1.ParameterName = "(ReturnValue)"
        workflowparameterbinding1.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, CType(activitybind1, System.Workflow.ComponentModel.ActivityBind))
        activitybind2.Name = "Workflow1"
        activitybind2.Path = "LoginName"
        workflowparameterbinding2.ParameterName = "UserName"
        workflowparameterbinding2.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, CType(activitybind2, System.Workflow.ComponentModel.ActivityBind))
        Me.InvokeSimpleWebService.ParameterBindings.Add(workflowparameterbinding1)
        Me.InvokeSimpleWebService.ParameterBindings.Add(workflowparameterbinding2)
        Me.InvokeSimpleWebService.ProxyClass = GetType(VBWebServiceSequentialConsole.SimpleWebService.Service)
        '
        'BeforeInvokeCode
        '
        Me.BeforeInvokeCode.Name = "BeforeInvokeCode"
        AddHandler Me.BeforeInvokeCode.ExecuteCode, AddressOf Me.BeforeInvokeCode_ExecuteCode
        '
        'Workflow1
        '
        Me.Activities.Add(Me.BeforeInvokeCode)
        Me.Activities.Add(Me.InvokeSimpleWebService)
        Me.Activities.Add(Me.AfterInvokeCode)
        Me.Activities.Add(Me.listenActivity1)
        Me.Name = "Workflow1"
        Me.CanModifyActivities = False

    End Sub
    Private eventDrivenActivity2 As System.Workflow.Activities.EventDrivenActivity
    Private eventDrivenActivity1 As System.Workflow.Activities.EventDrivenActivity
    Private listenActivity1 As System.Workflow.Activities.ListenActivity
    Private AfterInvokeCode As System.Workflow.Activities.CodeActivity
    Private BeforeInvokeCode As System.Workflow.Activities.CodeActivity
    Private InvokeSimpleWebService As System.Workflow.Activities.InvokeWebServiceActivity

End Class
