Imports System
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Collections
Imports System.Drawing
Imports System.Reflection
Imports System.Workflow.ComponentModel.Compiler
Imports System.Workflow.ComponentModel.Serialization
Imports System.Workflow.ComponentModel
Imports System.Workflow.ComponentModel.Design
Imports System.Workflow.Runtime
Imports System.Workflow.Activities
Imports System.Workflow.Activities.Rules

Partial Public class Workflow1

    'NOTE: The following procedure is required by the Workflow Designer
    'It can be modified using the Workflow Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Me.CanModifyActivities = True
        Dim activitybind2 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
        Dim activitybind1 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
        Me.transactionScopeActivity1 = New System.Workflow.ComponentModel.TransactionScopeActivity
        Me.Complete = New System.Workflow.Activities.CodeActivity
        Me.faultHandlersActivity1 = New System.Workflow.ComponentModel.FaultHandlersActivity
        Me.cancellationHandlerActivity1 = New System.Workflow.ComponentModel.CancellationHandlerActivity
        Me.Insert1 = New System.Workflow.Activities.CodeActivity
        Me.Insert2 = New System.Workflow.Activities.CodeActivity
        Me.throwActivity1 = New System.Workflow.ComponentModel.ThrowActivity
        Me.GeneralFault = New System.Workflow.ComponentModel.FaultHandlerActivity
        Me.compensateActivity1 = New System.Workflow.ComponentModel.CompensateActivity
        '
        'transactionScopeActivity1
        '
        Me.transactionScopeActivity1.Activities.Add(Me.Insert1)
        Me.transactionScopeActivity1.Activities.Add(Me.Insert2)
        Me.transactionScopeActivity1.Name = "transactionScopeActivity1"
        Me.transactionScopeActivity1.TransactionOptions.IsolationLevel = System.Transactions.IsolationLevel.Serializable
        '
        'Complete
        '
        Me.Complete.Name = "Complete"
        AddHandler Me.Complete.ExecuteCode, AddressOf Me.Complete_ExecuteCode
        '
        'faultHandlersActivity1
        '
        Me.faultHandlersActivity1.Activities.Add(Me.GeneralFault)
        Me.faultHandlersActivity1.Name = "faultHandlersActivity1"
        '
        'cancellationHandlerActivity1
        '
        Me.cancellationHandlerActivity1.Name = "cancellationHandlerActivity1"
        '
        'Insert1
        '
        Me.Insert1.Name = "Insert1"
        AddHandler Me.Insert1.ExecuteCode, AddressOf Me.Insert1_ExecuteCode
        '
        'Insert2
        '
        Me.Insert2.Name = "Insert2"
        AddHandler Me.Insert2.ExecuteCode, AddressOf Me.Insert2_ExecuteCode
        activitybind2.Name = "Workflow1"
        activitybind2.Path = "Exception"
        '
        'throwActivity1
        '
        Me.throwActivity1.FaultType = GetType(System.Exception)
        Me.throwActivity1.Name = "throwActivity1"
        Me.throwActivity1.SetBinding(System.Workflow.ComponentModel.ThrowActivity.FaultProperty, CType(activitybind2, System.Workflow.ComponentModel.ActivityBind))
        activitybind1.Name = "Workflow1"
        activitybind1.Path = "Exception"
        '
        'GeneralFault
        '
        Me.GeneralFault.Activities.Add(Me.compensateActivity1)
        Me.GeneralFault.FaultType = GetType(System.Exception)
        Me.GeneralFault.Name = "GeneralFault"
        Me.GeneralFault.SetBinding(System.Workflow.ComponentModel.FaultHandlerActivity.FaultProperty, CType(activitybind1, System.Workflow.ComponentModel.ActivityBind))
        '
        'compensateActivity1
        '
        Me.compensateActivity1.Name = "compensateActivity1"
        Me.compensateActivity1.TargetActivityName = "transactionScopeActivity1"
        '
        'Workflow1
        '
        Me.Activities.Add(Me.transactionScopeActivity1)
        Me.Activities.Add(Me.throwActivity1)
        Me.Activities.Add(Me.Complete)
        Me.Activities.Add(Me.faultHandlersActivity1)
        Me.Activities.Add(Me.cancellationHandlerActivity1)
        Me.Name = "Workflow1"
        Me.CanModifyActivities = False

    End Sub
    Private WithEvents faultHandlersActivity1 As System.Workflow.ComponentModel.FaultHandlersActivity
    Private WithEvents Insert1 As System.Workflow.Activities.CodeActivity
    Private WithEvents Insert2 As System.Workflow.Activities.CodeActivity
    Private WithEvents GeneralFault As System.Workflow.ComponentModel.FaultHandlerActivity
    Private WithEvents Complete As System.Workflow.Activities.CodeActivity
    Private WithEvents throwActivity1 As System.Workflow.ComponentModel.ThrowActivity
    Private WithEvents cancellationHandlerActivity1 As System.Workflow.ComponentModel.CancellationHandlerActivity
    Private WithEvents compensateActivity1 As System.Workflow.ComponentModel.CompensateActivity
    Private WithEvents transactionScopeActivity1 As System.Workflow.ComponentModel.TransactionScopeActivity

End Class
