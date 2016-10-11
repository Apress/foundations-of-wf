<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WorkflowAsService

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
        Me.webServiceOutputActivity1 = New System.Workflow.Activities.WebServiceOutputActivity
        Me.webServiceInputActivity1 = New System.Workflow.Activities.WebServiceInputActivity
        '
        'webServiceOutputActivity1
        '
        Me.webServiceOutputActivity1.InputActivityName = "webServiceInputActivity1"
        Me.webServiceOutputActivity1.Name = "webServiceOutputActivity1"
        activitybind1.Name = "WorkflowAsService"
        activitybind1.Path = "ValueEntered"
        workflowparameterbinding1.ParameterName = "(ReturnValue)"
        workflowparameterbinding1.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, CType(activitybind1, System.Workflow.ComponentModel.ActivityBind))
        Me.webServiceOutputActivity1.ParameterBindings.Add(workflowparameterbinding1)
        AddHandler Me.webServiceOutputActivity1.SendingOutput, AddressOf Me.webServiceOutputActivity1_SendingOutput
        '
        'webServiceInputActivity1
        '
        Me.webServiceInputActivity1.InterfaceType = GetType(VBAsWebServiceSequentialLibrary.WorkflowAsService.IWorkflowAsService)
        Me.webServiceInputActivity1.IsActivating = True
        Me.webServiceInputActivity1.MethodName = "AcceptValue"
        Me.webServiceInputActivity1.Name = "webServiceInputActivity1"
        activitybind2.Name = "WorkflowAsService"
        activitybind2.Path = "ValueEntered"
        workflowparameterbinding2.ParameterName = "IntputValue"
        workflowparameterbinding2.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, CType(activitybind2, System.Workflow.ComponentModel.ActivityBind))
        Me.webServiceInputActivity1.ParameterBindings.Add(workflowparameterbinding2)
        '
        'WorkflowAsService
        '
        Me.Activities.Add(Me.webServiceInputActivity1)
        Me.Activities.Add(Me.webServiceOutputActivity1)
        Me.Name = "WorkflowAsService"
        Me.CanModifyActivities = False

    End Sub
    Private WithEvents webServiceOutputActivity1 As System.Workflow.Activities.WebServiceOutputActivity
    Private WithEvents webServiceInputActivity1 As System.Workflow.Activities.WebServiceInputActivity

End Class
