<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseOrderProcess

    'NOTE: The following procedure is required by the Workflow Designer
    'It can be modified using the Workflow Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Private Sub InitializeComponent()
        Me.CanModifyActivities = True
        Dim activitybind1 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
        Dim activitybind2 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
        Dim activitybind3 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
        Dim ruleconditionreference1 As System.Workflow.Activities.Rules.RuleConditionReference = New System.Workflow.Activities.Rules.RuleConditionReference
        Dim ruleconditionreference2 As System.Workflow.Activities.Rules.RuleConditionReference = New System.Workflow.Activities.Rules.RuleConditionReference
        Dim activitybind4 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
        Dim ruleconditionreference3 As System.Workflow.Activities.Rules.RuleConditionReference = New System.Workflow.Activities.Rules.RuleConditionReference
        Dim ruleconditionreference4 As System.Workflow.Activities.Rules.RuleConditionReference = New System.Workflow.Activities.Rules.RuleConditionReference
        Dim activitybind5 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
        Dim ruleconditionreference5 As System.Workflow.Activities.Rules.RuleConditionReference = New System.Workflow.Activities.Rules.RuleConditionReference
        Dim ruleconditionreference6 As System.Workflow.Activities.Rules.RuleConditionReference = New System.Workflow.Activities.Rules.RuleConditionReference
        Dim activitybind6 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
        Dim ruleconditionreference7 As System.Workflow.Activities.Rules.RuleConditionReference = New System.Workflow.Activities.Rules.RuleConditionReference
        Dim ruleconditionreference8 As System.Workflow.Activities.Rules.RuleConditionReference = New System.Workflow.Activities.Rules.RuleConditionReference
        Dim activitybind7 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
        Dim codecondition1 As System.Workflow.Activities.CodeCondition = New System.Workflow.Activities.CodeCondition
        Dim codecondition2 As System.Workflow.Activities.CodeCondition = New System.Workflow.Activities.CodeCondition
        Dim activitybind8 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
        Dim codecondition3 As System.Workflow.Activities.CodeCondition = New System.Workflow.Activities.CodeCondition
        Dim codecondition4 As System.Workflow.Activities.CodeCondition = New System.Workflow.Activities.CodeCondition
        Dim activitybind9 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
        Dim ruleconditionreference9 As System.Workflow.Activities.Rules.RuleConditionReference = New System.Workflow.Activities.Rules.RuleConditionReference
        Dim ruleconditionreference10 As System.Workflow.Activities.Rules.RuleConditionReference = New System.Workflow.Activities.Rules.RuleConditionReference
        Me.OrderQuantityNotGreater0 = New System.Workflow.ComponentModel.TerminateActivity
        Me.UpdatePurchaseOrderNumber = New ExecuteSQL.ExecuteSQL
        Me.GetPurchaseOrderNumber = New System.Workflow.Activities.CodeActivity
        Me.InsertPurchaseOrder = New ExecuteSQL.ExecuteSQL
        Me.PrepareInsert = New System.Workflow.Activities.CodeActivity
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
        'UpdatePurchaseOrderNumber
        '
        activitybind2.Name = "PurchaseOrderProcess"
        activitybind2.Path = "ConnString"
        Me.UpdatePurchaseOrderNumber.Description = "Use for Insert,Update, Delete"
        Me.UpdatePurchaseOrderNumber.Name = "UpdatePurchaseOrderNumber"
        Me.UpdatePurchaseOrderNumber.SQLStatement = "SQL Statement"
        Me.UpdatePurchaseOrderNumber.SetBinding(ExecuteSQL.ExecuteSQL.ConnectionStringProperty, CType(activitybind2, System.Workflow.ComponentModel.ActivityBind))
        '
        'GetPurchaseOrderNumber
        '
        Me.GetPurchaseOrderNumber.Name = "GetPurchaseOrderNumber"
        AddHandler Me.GetPurchaseOrderNumber.ExecuteCode, AddressOf Me.GetPurchaseOrderNumber_ExecuteCode
        '
        'InsertPurchaseOrder
        '
        activitybind3.Name = "PurchaseOrderProcess"
        activitybind3.Path = "ConnString"
        Me.InsertPurchaseOrder.Description = "Use for Insert,Update, Delete"
        Me.InsertPurchaseOrder.Name = "InsertPurchaseOrder"
        Me.InsertPurchaseOrder.SQLStatement = "SQL Statement"
        Me.InsertPurchaseOrder.SetBinding(ExecuteSQL.ExecuteSQL.ConnectionStringProperty, CType(activitybind3, System.Workflow.ComponentModel.ActivityBind))
        '
        'PrepareInsert
        '
        Me.PrepareInsert.Name = "PrepareInsert"
        AddHandler Me.PrepareInsert.ExecuteCode, AddressOf Me.AddPurchaseOrder_ExecuteCode
        '
        'OrderQuantityLess0
        '
        Me.OrderQuantityLess0.Activities.Add(Me.OrderQuantityNotGreater0)
        ruleconditionreference1.ConditionName = "OrderQuantityLess0"
        Me.OrderQuantityLess0.Condition = ruleconditionreference1
        Me.OrderQuantityLess0.Name = "OrderQuantityLess0"
        '
        'OrderQuantityGreater0
        '
        Me.OrderQuantityGreater0.Activities.Add(Me.PrepareInsert)
        Me.OrderQuantityGreater0.Activities.Add(Me.InsertPurchaseOrder)
        Me.OrderQuantityGreater0.Activities.Add(Me.GetPurchaseOrderNumber)
        Me.OrderQuantityGreater0.Activities.Add(Me.UpdatePurchaseOrderNumber)
        ruleconditionreference2.ConditionName = "PastExpectedDate"
        Me.OrderQuantityGreater0.Condition = ruleconditionreference2
        Me.OrderQuantityGreater0.Name = "OrderQuantityGreater0"
        activitybind4.Name = "PurchaseOrderProcess"
        activitybind4.Path = "ExpectedDateInPastError"
        '
        'ExpectedDateInPast
        '
        Me.ExpectedDateInPast.Name = "ExpectedDateInPast"
        Me.ExpectedDateInPast.SetBinding(System.Workflow.ComponentModel.TerminateActivity.ErrorProperty, CType(activitybind4, System.Workflow.ComponentModel.ActivityBind))
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
        ruleconditionreference3.ConditionName = "PastExpectedDate"
        Me.PastExpectedDate.Condition = ruleconditionreference3
        Me.PastExpectedDate.Name = "PastExpectedDate"
        '
        'FutureExpectedDate
        '
        Me.FutureExpectedDate.Activities.Add(Me.OrderQuantity)
        ruleconditionreference4.ConditionName = "FutureDateExpected"
        Me.FutureExpectedDate.Condition = ruleconditionreference4
        Me.FutureExpectedDate.Name = "FutureExpectedDate"
        activitybind5.Name = "PurchaseOrderProcess"
        activitybind5.Path = "MissingBuyerNameError"
        '
        'MissingBuyerName
        '
        Me.MissingBuyerName.Name = "MissingBuyerName"
        Me.MissingBuyerName.SetBinding(System.Workflow.ComponentModel.TerminateActivity.ErrorProperty, CType(activitybind5, System.Workflow.ComponentModel.ActivityBind))
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
        ruleconditionreference5.ConditionName = "BuyerNameMissing"
        Me.BuyerNameMissing.Condition = ruleconditionreference5
        Me.BuyerNameMissing.Name = "BuyerNameMissing"
        '
        'BuyerNamePresent
        '
        Me.BuyerNamePresent.Activities.Add(Me.CheckFutureExpectedDate)
        ruleconditionreference6.ConditionName = "BuyerNamePresent"
        Me.BuyerNamePresent.Condition = ruleconditionreference6
        Me.BuyerNamePresent.Name = "BuyerNamePresent"
        activitybind6.Name = "PurchaseOrderProcess"
        activitybind6.Path = "MissingBuyerLoginError"
        '
        'MissingBuyerLogin
        '
        Me.MissingBuyerLogin.Name = "MissingBuyerLogin"
        Me.MissingBuyerLogin.SetBinding(System.Workflow.ComponentModel.TerminateActivity.ErrorProperty, CType(activitybind6, System.Workflow.ComponentModel.ActivityBind))
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
        ruleconditionreference7.ConditionName = "BuyerLoginMissing"
        Me.BuyerLoginMissing.Condition = ruleconditionreference7
        Me.BuyerLoginMissing.Name = "BuyerLoginMissing"
        '
        'BuyerLoginPresent
        '
        Me.BuyerLoginPresent.Activities.Add(Me.CheckBuyerName)
        ruleconditionreference8.ConditionName = "BuyerLoginPresent"
        Me.BuyerLoginPresent.Condition = ruleconditionreference8
        Me.BuyerLoginPresent.Name = "BuyerLoginPresent"
        activitybind7.Name = "PurchaseOrderProcess"
        activitybind7.Path = "MissingExpectedDateError"
        '
        'MissingExpectedDate
        '
        Me.MissingExpectedDate.Name = "MissingExpectedDate"
        Me.MissingExpectedDate.SetBinding(System.Workflow.ComponentModel.TerminateActivity.ErrorProperty, CType(activitybind7, System.Workflow.ComponentModel.ActivityBind))
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
        AddHandler codecondition1.Condition, AddressOf Me.ExpectedDateMissingCondition
        Me.ExpectedDateMissing.Condition = codecondition1
        Me.ExpectedDateMissing.Name = "ExpectedDateMissing"
        '
        'ExpectedDatePresent
        '
        Me.ExpectedDatePresent.Activities.Add(Me.CheckBuyerLogin)
        AddHandler codecondition2.Condition, AddressOf Me.ExpectedDatePresentCondition
        Me.ExpectedDatePresent.Condition = codecondition2
        Me.ExpectedDatePresent.Name = "ExpectedDatePresent"
        activitybind8.Name = "PurchaseOrderProcess"
        activitybind8.Path = "MissingPurchaseDateError"
        '
        'MissingPurchaseDate
        '
        Me.MissingPurchaseDate.Name = "MissingPurchaseDate"
        Me.MissingPurchaseDate.SetBinding(System.Workflow.ComponentModel.TerminateActivity.ErrorProperty, CType(activitybind8, System.Workflow.ComponentModel.ActivityBind))
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
        AddHandler codecondition3.Condition, AddressOf Me.PurchaseDateMissingCondition
        Me.PurchaseDateMissing.Condition = codecondition3
        Me.PurchaseDateMissing.Name = "PurchaseDateMissing"
        '
        'PurchaseDatePresent
        '
        Me.PurchaseDatePresent.Activities.Add(Me.CheckExpectedDate)
        AddHandler codecondition4.Condition, AddressOf Me.PurchaseDatePresentCondition
        Me.PurchaseDatePresent.Condition = codecondition4
        Me.PurchaseDatePresent.Name = "PurchaseDatePresent"
        activitybind9.Name = "PurchaseOrderProcess"
        activitybind9.Path = "MissingPartNumberError"
        '
        'MissingPartNumber
        '
        Me.MissingPartNumber.Name = "MissingPartNumber"
        Me.MissingPartNumber.SetBinding(System.Workflow.ComponentModel.TerminateActivity.ErrorProperty, CType(activitybind9, System.Workflow.ComponentModel.ActivityBind))
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
        ruleconditionreference9.ConditionName = "PartNumberMissing"
        Me.PartNumberMissing.Condition = ruleconditionreference9
        Me.PartNumberMissing.Name = "PartNumberMissing"
        '
        'PartNumberPresent
        '
        Me.PartNumberPresent.Activities.Add(Me.CheckPurchaseDate)
        ruleconditionreference10.ConditionName = "PartNumberPresent"
        Me.PartNumberPresent.Condition = ruleconditionreference10
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
    Private UpdatePurchaseOrderNumber As ExecuteSQL.ExecuteSQL
    Private GetPurchaseOrderNumber As System.Workflow.Activities.CodeActivity
    Private InsertPurchaseOrder As ExecuteSQL.ExecuteSQL
    Private MissingPurchaseDate As System.Workflow.ComponentModel.TerminateActivity
    Private MissingExpectedDate As System.Workflow.ComponentModel.TerminateActivity
    Private MissingBuyerLogin As System.Workflow.ComponentModel.TerminateActivity
    Private MissingBuyerName As System.Workflow.ComponentModel.TerminateActivity
    Private ExpectedDateInPast As System.Workflow.ComponentModel.TerminateActivity
    Private OrderQuantityNotGreater0 As System.Workflow.ComponentModel.TerminateActivity
    Private MissingPartNumber As System.Workflow.ComponentModel.TerminateActivity
    Private OrderQuantityLess0 As System.Workflow.Activities.IfElseBranchActivity
    Private OrderQuantityGreater0 As System.Workflow.Activities.IfElseBranchActivity
    Private OrderQuantity As System.Workflow.Activities.IfElseActivity
    Private PastExpectedDate As System.Workflow.Activities.IfElseBranchActivity
    Private FutureExpectedDate As System.Workflow.Activities.IfElseBranchActivity
    Private CheckFutureExpectedDate As System.Workflow.Activities.IfElseActivity
    Private BuyerNameMissing As System.Workflow.Activities.IfElseBranchActivity
    Private BuyerNamePresent As System.Workflow.Activities.IfElseBranchActivity
    Private CheckBuyerName As System.Workflow.Activities.IfElseActivity
    Private BuyerLoginMissing As System.Workflow.Activities.IfElseBranchActivity
    Private BuyerLoginPresent As System.Workflow.Activities.IfElseBranchActivity
    Private CheckBuyerLogin As System.Workflow.Activities.IfElseActivity
    Private ExpectedDateMissing As System.Workflow.Activities.IfElseBranchActivity
    Private ExpectedDatePresent As System.Workflow.Activities.IfElseBranchActivity
    Private CheckExpectedDate As System.Workflow.Activities.IfElseActivity
    Private PurchaseDateMissing As System.Workflow.Activities.IfElseBranchActivity
    Private PurchaseDatePresent As System.Workflow.Activities.IfElseBranchActivity
    Private CheckPurchaseDate As System.Workflow.Activities.IfElseActivity
    Private PartNumberMissing As System.Workflow.Activities.IfElseBranchActivity
    Private PartNumberPresent As System.Workflow.Activities.IfElseBranchActivity
    Private CheckPartNumber As System.Workflow.Activities.IfElseActivity
    Private PrepareInsert As System.Workflow.Activities.CodeActivity

End Class
