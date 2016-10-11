<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseOrderProcess

    'NOTE: The following procedure is required by the Workflow Designer
    'It can be modified using the Workflow Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Private Sub InitializeComponent()
        Me.CanModifyActivities = True
        Me.AddPurchaseOrder = New System.Workflow.Activities.CodeActivity
        '
        'AddPurchaseOrder
        '
        Me.AddPurchaseOrder.Name = "AddPurchaseOrder"
        AddHandler Me.AddPurchaseOrder.ExecuteCode, AddressOf Me.AddPurchaseOrder_ExecuteCode
        '
        'PurchaseOrderProcess
        '
        Me.Activities.Add(Me.AddPurchaseOrder)
        Me.Name = "PurchaseOrderProcess"
        Me.CanModifyActivities = False

    End Sub
    Private WithEvents AddPurchaseOrder As System.Workflow.Activities.CodeActivity

End Class
