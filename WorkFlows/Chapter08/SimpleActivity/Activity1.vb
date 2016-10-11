'NOTE: When changing the namespace; please update XmlnsDefinitionAttribute in AssemblyInfo.vb
Public Class SimpleActivity
    Inherits SequenceActivity
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Private Sub SimpleCode_ExecuteCode(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Simple")
    End Sub

    Private Sub ActivityCode_ExecuteCode(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Activity")
    End Sub
End Class
