'NOTE: When changing the namespace; please update XmlnsDefinitionAttribute in AssemblyInfo.vb
Public class Workflow1
    Inherits SequentialWorkflowActivity
    Public LoginName As String = "Brian"
    Public ValueReturned As Boolean = False
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
   
    
    Private Sub BeforeInvokeCode_ExecuteCode(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Before Invoke: " & ValueReturned)

    End Sub

    Private Sub AfterInvokeCode_ExecuteCode(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("After Invoke: " & ValueReturned)

    End Sub
End Class
