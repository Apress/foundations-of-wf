'NOTE: When changing the namespace; please update XmlnsDefinitionAttribute in AssemblyInfo.vb
Public Class Workflow1

    Inherits StateMachineWorkflowActivity
    Public LoginName As String
    Public ValueReturned As Boolean
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    


End Class
