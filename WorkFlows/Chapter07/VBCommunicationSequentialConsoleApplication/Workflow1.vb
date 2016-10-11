'NOTE: When changing the namespace; please update XmlnsDefinitionAttribute in AssemblyInfo.vb
Public class Workflow1
    Inherits SequentialWorkflowActivity
    Public blnCreated As Boolean
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
    Private Sub OnApproved(ByVal sender As Object, ByVal e As ExternalDataEventArgs)
        MsgBox("Approved")
    End Sub
    Private Sub OnNotApproved(ByVal sender As Object, ByVal e As ExternalDataEventArgs)
        MsgBox("Not Approved")
    End Sub

End Class
