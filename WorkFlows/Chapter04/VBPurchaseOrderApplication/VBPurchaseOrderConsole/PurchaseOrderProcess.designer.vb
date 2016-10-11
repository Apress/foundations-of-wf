<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseOrderProcess

    'NOTE: The following procedure is required by the Workflow Designer
    'It can be modified using the Workflow Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Private Sub InitializeComponent()
        Me.CanModifyActivities = True
        Dim activitybind1 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
        Dim codecondition1 As System.Workflow.Activities.CodeCondition = New System.Workflow.Activities.CodeCondition
        Dim codecondition2 As System.Workflow.Activities.CodeCondition = New System.Workflow.Activities.CodeCondition
        Dim activitybind2 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
        Dim codecondition3 As System.Workflow.Activities.CodeCondition = New System.Workflow.Activities.CodeCondition
        Dim codecondition4 As System.Workflow.Activities.CodeCondition = New System.Workflow.Activities.CodeCondition
        Dim activitybind3 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
        Dim codecondition5 As System.Workflow.Activities.CodeCondition = New System.Workflow.Activities.CodeCondition
        Dim codecondition6 As System.Workflow.Activities.CodeCondition = New System.Workflow.Activities.CodeCondition
        Dim activitybind4 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
        Dim codecondition7 As System.Workflow.Activities.CodeCondition = New System.Workflow.Activities.CodeCondition
        Dim codecondition8 As System.Workflow.Activities.CodeCondition = New System.Workflow.Activities.CodeCondition
        Dim activitybind5 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
        Dim codecondition9 As System.Workflow.Activities.CodeCondition = New System.Workflow.Activities.CodeCondition
        Dim codecondition10 As System.Workflow.Activities.CodeCondition = New System.Workflow.Activities.CodeCondition
        Dim activitybind6 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
        Dim codecondition11 As System.Workflow.Activities.CodeCondition = New System.Workflow.Activities.CodeCondition
        Dim codecondition12 As System.Workflow.Activities.CodeCondition = New System.Workflow.Activities.CodeCondition
        Dim activitybind7 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
        Dim codecondition13 As System.Workflow.Activities.CodeCondition = New System.Workflow.Activities.CodeCondition
        Dim codecondition14 As System.Workflow.Activities.CodeCondition = New System.Workflow.Activities.CodeCondition
        Me.OrderQuantityNotGreater0 = New System.Workflow.ComponentModel.TerminateActivity
        Me.AddPurchaseOrder = New System.Workflow.Activities.CodeActivity
        Me.OrderQuantityLess0 = New System.Workflow.Activities.IfElseBranchActivity
        Me.OrderQuantityGreater0 = New System.Workflow.Activities.IfElseBranchActivity
        Me.ExpectedDateInPast = New System.Workflow.ComponentModel.TerminateActivity
        Me.OrderQuantity = New System.Workflow.Activities.IfElseActivity
        Me.PastExpectedDate = New System.Workflow.Activities.IfElseBranchActivity
        Me.FutureExpectedDate = New System.Workflow.Activities.IfElseBranchActivity
        Me.MissingBuyerName = New System.Workflow.ComponentModel.TerminateActivity
        Me.CheckFutureExpectedDate = New System.Workflow.Activities.IfElseActivity
        Me.BuyerNameMissing = New System.Workflow.Activities.IfElseBranchActivity
        Me.BuyerNamePresent = New System.Workflow.Activities.IfElseBranchActivity
        Me.MissingBuyerLogin = New System.Workflow.ComponentModel.TerminateActivity
        Me.CheckBuyerName = New System.Workflow.Activities.IfElseActivity
        Me.BuyerLoginMissing = New System.Workflow.Activities.IfElseBranchActivity
        Me.BuyerLoginPresent = New System.Workflow.Activities.IfElseBranchActivity
        Me.MissingExpectedDate = New System.Workflow.ComponentModel.TerminateActivity
        Me.CheckBuyerLogin = New System.Workflow.Activities.IfElseActivity
        Me.ExpectedDateMissing = New System.Workflow.Activities.IfElseBranchActivity
        Me.ExpectedDatePresent = New System.Workflow.Activities.IfElseBranchActivity
        Me.MissingPurchaseDate = New System.Workflow.ComponentModel.TerminateActivity
        Me.CheckExpectedDate = New System.Workflow.Activities.IfElseActivity
        Me.PurchaseDateMissing = New System.Workflow.Activities.IfElseBranchActivity
        Me.PurchaseDatePresent = New System.Workflow.Activities.IfElseBranchActivity
        Me.MissingPartNumber = New System.Workflow.ComponentModel.TerminateActivity
        Me.CheckPurchaseDate = New System.Workflow.Activities.IfElseActivity
        Me.PartNumberMissing = New System.Workflow.Activities.IfElseBranchActivity
        Me.PartNumberPresent = New System.Workflow.Activities.IfElseBranchActivity
        Me.CheckPartNumber = New System.Workflow.Activities.IfElseActivity
        activitybind1.Name = "PurchaseOrderProcess"
        activitybind1.Path = "OrderQuantityNotGreater0Error"
        '
        'OrderQuantityNotGreater0
        '
        Me.OrderQuantityNotGreater0.Name = "OrderQuantityNotGreater0"
        Me.OrderQuantityNotGreater0.SetBinding(System.Workflow.ComponentModel.TerminateActivity.ErrorProperty, CType(activitybind1, System.Workflow.ComponentModel.ActivityBind))
        '
        'AddPurchaseOrder
        '
        Me.AddPurchaseOrder.Name = "AddPurchaseOrder"
        AddHandler Me.AddPurchaseOrder.ExecuteCode, AddressOf Me.AddPurchaseOrder_ExecuteCode
        '
        'OrderQuantityLess0
        '
        Me.OrderQuantityLess0.Activities.Add(Me.OrderQuantityNotGreater0)
        AddHandler codecondition1.Condition, AddressOf Me.QuantityLessThan0Condition
        Me.OrderQuantityLess0.Condition = codecondition1
        Me.OrderQuantityLess0.Name = "OrderQuantityLess0"
        '
        'OrderQuantityGreater0
        '
        Me.OrderQuantityGreater0.Activities.Add(Me.AddPurchaseOrder)
        AddHandler codecondition2.Condition, AddressOf Me.QuantityOrderedGreater0Condition
        Me.OrderQuantityGreater0.Condition = codecondition2
        Me.OrderQuantityGreater0.Name = "OrderQuantityGreater0"
        activitybind2.Name = "PurchaseOrderProcess"
        activitybind2.Path = "ExpectedDateInPastError"
        '
        'ExpectedDateInPast
        '
        Me.ExpectedDateInPast.Name = "ExpectedDateInPast"
        Me.ExpectedDateInPast.SetBinding(System.Workflow.ComponentModel.TerminateActivity.ErrorProperty, CType(activitybind2, System.Workflow.ComponentModel.ActivityBind))
        '
        'OrderQuantity
        '
        Me.OrderQuantity.Activities.Add(Me.OrderQuantityGreater0)
        Me.OrderQuantity.Activities.Add(Me.OrderQuantityLess0)
        Me.OrderQuantity.Name = "OrderQuantity"
        '
        'PastExpectedDate
        '
        Me.PastExpectedDate.Activities.Add(Me.ExpectedDateInPast)
        AddHandler codecondition3.Condition, AddressOf Me.PastExpectedDateCondition
        Me.PastExpectedDate.Condition = codecondition3
        Me.PastExpectedDate.Name = "PastExpectedDate"
        '
        'FutureExpectedDate
        '
        Me.FutureExpectedDate.Activities.Add(Me.OrderQuantity)
        AddHandler codecondition4.Condition, AddressOf Me.FutureExpectedDateCondition
        Me.FutureExpectedDate.Condition = codecondition4
        Me.FutureExpectedDate.Name = "FutureExpectedDate"
        activitybind3.Name = "PurchaseOrderProcess"
        activitybind3.Path = "MissingBuyerNameError"
        '
        'MissingBuyerName
        '
        Me.MissingBuyerName.Name = "MissingBuyerName"
        Me.MissingBuyerName.SetBinding(System.Workflow.ComponentModel.TerminateActivity.ErrorProperty, CType(activitybind3, System.Workflow.ComponentModel.ActivityBind))
        '
        'CheckFutureExpectedDate
        '
        Me.CheckFutureExpectedDate.Activities.Add(Me.FutureExpectedDate)
        Me.CheckFutureExpectedDate.Activities.Add(Me.PastExpectedDate)
        Me.CheckFutureExpectedDate.Name = "CheckFutureExpectedDate"
        '
        'BuyerNameMissing
        '
        Me.BuyerNameMissing.Activities.Add(Me.MissingBuyerName)
        AddHandler codecondition5.Condition, AddressOf Me.BuyerNameMissingCondition
        Me.BuyerNameMissing.Condition = codecondition5
        Me.BuyerNameMissing.Name = "BuyerNameMissing"
        '
        'BuyerNamePresent
        '
        Me.BuyerNamePresent.Activities.Add(Me.CheckFutureExpectedDate)
        AddHandler codecondition6.Condition, AddressOf Me.BuyerNamePresentCondition
        Me.BuyerNamePresent.Condition = codecondition6
        Me.BuyerNamePresent.Name = "BuyerNamePresent"
        activitybind4.Name = "PurchaseOrderProcess"
        activitybind4.Path = "MissingBuyerLoginError"
        '
        'MissingBuyerLogin
        '
        Me.MissingBuyerLogin.Name = "MissingBuyerLogin"
        Me.MissingBuyerLogin.SetBinding(System.Workflow.ComponentModel.TerminateActivity.ErrorProperty, CType(activitybind4, System.Workflow.ComponentModel.ActivityBind))
        '
        'CheckBuyerName
        '
        Me.CheckBuyerName.Activities.Add(Me.BuyerNamePresent)
        Me.CheckBuyerName.Activities.Add(Me.BuyerNameMissing)
        Me.CheckBuyerName.Name = "CheckBuyerName"
        '
        'BuyerLoginMissing
        '
        Me.BuyerLoginMissing.Activities.Add(Me.MissingBuyerLogin)
        AddHandler codecondition7.Condition, AddressOf Me.BuyerLoginMissingCondition
        Me.BuyerLoginMissing.Condition = codecondition7
        Me.BuyerLoginMissing.Name = "BuyerLoginMissing"
        '
        'BuyerLoginPresent
        '
        Me.BuyerLoginPresent.Activities.Add(Me.CheckBuyerName)
        AddHandler codecondition8.Condition, AddressOf Me.BuyerLoginPresentCondition
        Me.BuyerLoginPresent.Condition = codecondition8
        Me.BuyerLoginPresent.Name = "BuyerLoginPresent"
        activitybind5.Name = "PurchaseOrderProcess"
        activitybind5.Path = "MissingExpectedDateError"
        '
        'MissingExpectedDate
        '
        Me.MissingExpectedDate.Name = "MissingExpectedDate"
        Me.MissingExpectedDate.SetBinding(System.Workflow.ComponentModel.TerminateActivity.ErrorProperty, CType(activitybind5, System.Workflow.ComponentModel.ActivityBind))
        '
        'CheckBuyerLogin
        '
        Me.CheckBuyerLogin.Activities.Add(Me.BuyerLoginPresent)
        Me.CheckBuyerLogin.Activities.Add(Me.BuyerLoginMissing)
        Me.CheckBuyerLogin.Name = "CheckBuyerLogin"
        '
        'ExpectedDateMissing
        '
        Me.ExpectedDateMissing.Activities.Add(Me.MissingExpectedDate)
        AddHandler codecondition9.Condition, AddressOf Me.ExpectedDateMissingCondition
        Me.ExpectedDateMissing.Condition = codecondition9
        Me.ExpectedDateMissing.Name = "ExpectedDateMissing"
        '
        'ExpectedDatePresent
        '
        Me.ExpectedDatePresent.Activities.Add(Me.CheckBuyerLogin)
        AddHandler codecondition10.Condition, AddressOf Me.ExpectedDatePresentCondition
        Me.ExpectedDatePresent.Condition = codecondition10
        Me.ExpectedDatePresent.Name = "ExpectedDatePresent"
        activitybind6.Name = "PurchaseOrderProcess"
        activitybind6.Path = "MissingPurchaseDateError"
        '
        'MissingPurchaseDate
        '
        Me.MissingPurchaseDate.Name = "MissingPurchaseDate"
        Me.MissingPurchaseDate.SetBinding(System.Workflow.ComponentModel.TerminateActivity.ErrorProperty, CType(activitybind6, System.Workflow.ComponentModel.ActivityBind))
        '
        'CheckExpectedDate
        '
        Me.CheckExpectedDate.Activities.Add(Me.ExpectedDatePresent)
        Me.CheckExpectedDate.Activities.Add(Me.ExpectedDateMissing)
        Me.CheckExpectedDate.Name = "CheckExpectedDate"
        '
        'PurchaseDateMissing
        '
        Me.PurchaseDateMissing.Activities.Add(Me.MissingPurchaseDate)
        AddHandler codecondition11.Condition, AddressOf Me.PurchaseDateMissingCondition
        Me.PurchaseDateMissing.Condition = codecondition11
        Me.PurchaseDateMissing.Name = "PurchaseDateMissing"
        '
        'PurchaseDatePresent
        '
        Me.PurchaseDatePresent.Activities.Add(Me.CheckExpectedDate)
        AddHandler codecondition12.Condition, AddressOf Me.PurchaseDatePresentCondition
        Me.PurchaseDatePresent.Condition = codecondition12
        Me.PurchaseDatePresent.Name = "PurchaseDatePresent"
        activitybind7.Name = "PurchaseOrderProcess"
        activitybind7.Path = "MissingPartNumberError"
        '
        'MissingPartNumber
        '
        Me.MissingPartNumber.Name = "MissingPartNumber"
        Me.MissingPartNumber.SetBinding(System.Workflow.ComponentModel.TerminateActivity.ErrorProperty, CType(activitybind7, System.Workflow.ComponentModel.ActivityBind))
        '
        'CheckPurchaseDate
        '
        Me.CheckPurchaseDate.Activities.Add(Me.PurchaseDatePresent)
        Me.CheckPurchaseDate.Activities.Add(Me.PurchaseDateMissing)
        Me.CheckPurchaseDate.Name = "CheckPurchaseDate"
        '
        'PartNumberMissing
        '
        Me.PartNumberMissing.Activities.Add(Me.MissingPartNumber)
        AddHandler codecondition13.Condition, AddressOf Me.PurchaseDateMissingCondition
        Me.PartNumberMissing.Condition = codecondition13
        Me.PartNumberMissing.Name = "PartNumberMissing"
        '
        'PartNumberPresent
        '
        Me.PartNumberPresent.Activities.Add(Me.CheckPurchaseDate)
        AddHandler codecondition14.Condition, AddressOf Me.PurchaseDatePresentCondition
        Me.PartNumberPresent.Condition = codecondition14
        Me.PartNumberPresent.Name = "PartNumberPresent"
        '
        'CheckPartNumber
        '
        Me.CheckPartNumber.Activities.Add(Me.PartNumberPresent)
        Me.CheckPartNumber.Activities.Add(Me.PartNumberMissing)
        Me.CheckPartNumber.Name = "CheckPartNumber"
        '
        'PurchaseOrderProcess
        '
        Me.Activities.Add(Me.CheckPartNumber)
        Me.Name = "PurchaseOrderProcess"
        Me.CanModifyActivities = False

    End Sub
    Private WithEvents MissingPurchaseDate As System.Workflow.ComponentModel.TerminateActivity
    Private WithEvents MissingExpectedDate As System.Workflow.ComponentModel.TerminateActivity
    Private WithEvents MissingBuyerLogin As System.Workflow.ComponentModel.TerminateActivity
    Private WithEvents MissingBuyerName As System.Workflow.ComponentModel.TerminateActivity
    Private WithEvents ExpectedDateInPast As System.Workflow.ComponentModel.TerminateActivity
    Private WithEvents OrderQuantityNotGreater0 As System.Workflow.ComponentModel.TerminateActivity
    Private WithEvents MissingPartNumber As System.Workflow.ComponentModel.TerminateActivity
    Private WithEvents OrderQuantityLess0 As System.Workflow.Activities.IfElseBranchActivity
    Private WithEvents OrderQuantityGreater0 As System.Workflow.Activities.IfElseBranchActivity
    Private WithEvents OrderQuantity As System.Workflow.Activities.IfElseActivity
    Private WithEvents PastExpectedDate As System.Workflow.Activities.IfElseBranchActivity
    Private WithEvents FutureExpectedDate As System.Workflow.Activities.IfElseBranchActivity
    Private WithEvents CheckFutureExpectedDate As System.Workflow.Activities.IfElseActivity
    Private WithEvents BuyerNameMissing As System.Workflow.Activities.IfElseBranchActivity
    Private WithEvents BuyerNamePresent As System.Workflow.Activities.IfElseBranchActivity
    Private WithEvents CheckBuyerName As System.Workflow.Activities.IfElseActivity
    Private WithEvents BuyerLoginMissing As System.Workflow.Activities.IfElseBranchActivity
    Private WithEvents BuyerLoginPresent As System.Workflow.Activities.IfElseBranchActivity
    Private WithEvents CheckBuyerLogin As System.Workflow.Activities.IfElseActivity
    Private WithEvents ExpectedDateMissing As System.Workflow.Activities.IfElseBranchActivity
    Private WithEvents ExpectedDatePresent As System.Workflow.Activities.IfElseBranchActivity
    Private WithEvents CheckExpectedDate As System.Workflow.Activities.IfElseActivity
    Private WithEvents PurchaseDateMissing As System.Workflow.Activities.IfElseBranchActivity
    Private WithEvents PurchaseDatePresent As System.Workflow.Activities.IfElseBranchActivity
    Private WithEvents CheckPurchaseDate As System.Workflow.Activities.IfElseActivity
    Private WithEvents PartNumberMissing As System.Workflow.Activities.IfElseBranchActivity
    Private WithEvents PartNumberPresent As System.Workflow.Activities.IfElseBranchActivity
    Private WithEvents CheckPartNumber As System.Workflow.Activities.IfElseActivity
    Private WithEvents AddPurchaseOrder As System.Workflow.Activities.CodeActivity

End Class
