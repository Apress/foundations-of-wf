'NOTE: When changing the namespace; please update XmlnsDefinitionAttribute in AssemblyInfo.vb
Public class Workflow1
    Inherits SequentialWorkflowActivity
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Private Sub codeActivity1_ExecuteCode(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("I'm here")
    End Sub
End Class
