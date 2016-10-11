'NOTE: When changing the namespace; please update XmlnsDefinitionAttribute in AssemblyInfo.vb
Public class Workflow1
    Inherits SequentialWorkflowActivity
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Private Sub codeActivity1_ExecuteCode(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("First Activity: " & Now())
    End Sub

    Private Sub codeActivity2_ExecuteCode(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Second activity: " & Now())
    End Sub
End Class
