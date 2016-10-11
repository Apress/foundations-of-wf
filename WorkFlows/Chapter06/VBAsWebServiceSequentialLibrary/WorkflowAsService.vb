'NOTE: When changing the namespace; please update XmlnsDefinitionAttribute in AssemblyInfo.vb
Public Class WorkflowAsService
    Inherits SequentialWorkflowActivity

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
    Public Interface IWorkflowAsService
        Function AcceptValue(ByVal IntputValue As Integer) As Integer
    End Interface
    Private Sub webServiceOutputActivity1_SendingOutput(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ValueEntered = ValueEntered + 10
    End Sub
    Public ValueEntered As System.Int32 = Nothing

End Class
