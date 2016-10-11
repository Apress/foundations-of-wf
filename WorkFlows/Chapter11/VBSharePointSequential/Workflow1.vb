Imports Microsoft.SharePoint
Imports Microsoft.SharePoint.Workflow
Imports Microsoft.SharePoint.WorkflowActions
Imports Microsoft.Office.Workflow.Utility

'NOTE: When changing the namespace; please update XmlnsDefinitionAttribute in AssemblyInfo.vb
Public Class Workflow1
    Inherits SequentialWorkflowActivity
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
    Public workflowProperties As SPWorkflowActivationProperties = New Microsoft.SharePoint.Workflow.SPWorkflowActivationProperties
End Class
