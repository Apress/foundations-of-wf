Imports Microsoft.SharePoint
Imports Microsoft.SharePoint.Workflow
Imports Microsoft.SharePoint.WorkflowActions
Imports Microsoft.Office.Workflow.Utility

'NOTE: When changing the namespace; please update XmlnsDefinitionAttribute in AssemblyInfo.vb
Public Class Workflow1
    Inherits SequentialWorkflowActivity
    Public Assignee As String
    Public Instructions As String
    Public Comments As String
    Public TaskID As Guid
    Public CurrentUser As Integer
    Public IsFinished As Boolean
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
    Public workflowProperties As SPWorkflowActivationProperties = New Microsoft.SharePoint.Workflow.SPWorkflowActivationProperties
    Public Shared TaskPropProperty As System.Workflow.ComponentModel.DependencyProperty = DependencyProperty.Register("TaskProp", GetType(Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties), GetType(SharedDocumentExample.Workflow1))

    <System.ComponentModel.DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)> _
        <System.ComponentModel.BrowsableAttribute(True)> _
            <System.ComponentModel.CategoryAttribute("Misc")> _
                Public Property TaskProp() As SPWorkflowTaskProperties
        Get
            Return CType(MyBase.GetValue(SharedDocumentExample.Workflow1.TaskPropProperty), Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties)

        End Get
        Set(ByVal value As SPWorkflowTaskProperties)
            MyBase.SetValue(SharedDocumentExample.Workflow1.TaskPropProperty, value)

        End Set
    End Property
    Public TaskGUID As SPWorkflowTaskProperties = New Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties

    Private Sub OnWorkflowActivated(ByVal sender As System.Object, ByVal e As System.Workflow.Activities.ExternalDataEventArgs)
        Dim formdata As Hashtable
        formdata = Form.XmlToHashtable(workflowProperties.InitiationData)
        Instructions = formdata("instructions").ToString
        Assignee = formdata("Assignee").ToString
    End Sub
    Private Sub CreateTask(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TaskID = Guid.NewGuid
        CurrentUser = 0
        TaskProp.AssignedTo = Assignee
        TaskProp.Title = "Please review this document"
        TaskProp.Description = Instructions
    End Sub
    Public AfterProps As SPWorkflowTaskProperties = New Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties

    Private Sub OnTaskChanged(ByVal sender As System.Object, ByVal e As System.Workflow.Activities.ExternalDataEventArgs)
        IsFinished = Boolean.Parse(AfterProps.ExtendedProperties("isFinished").ToString)

    End Sub

    Private Sub NotFinished(ByVal sender As System.Object, ByVal e As System.Workflow.Activities.ConditionalEventArgs)
        e.Result = Not IsFinished
        IsFinished = False
    End Sub
End Class
