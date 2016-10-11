'NOTE: When changing the namespace; please update XmlnsDefinitionAttribute in AssemblyInfo.vb
Public Class PurchaseOrderProcess
    Inherits SequentialWorkflowActivity
    Private StrPurchaseOrderNumber As String
    Private StrPartNumber As String
    Private DtePurchaseDate As Date
    Private DteExpectedDate As Date
    Private StrBuyerLogin As String
    Private StrBuyerName As String
    Private IntQuantityOrdered As Integer
    Private clsDB As SQLAccess
    Public WriteOnly Property PartNumber() As String
        Set(ByVal value As String)
            StrPartNumber = value
        End Set
    End Property
    Public WriteOnly Property PurchaseDate() As Date
        Set(ByVal value As Date)
            DtePurchaseDate = value
        End Set
    End Property
    Public WriteOnly Property ExpectedDate() As Date

        Set(ByVal value As Date)
            DteExpectedDate = value
        End Set
    End Property
    Public WriteOnly Property BuyerLogin() As String

        Set(ByVal value As String)
            StrBuyerName = value
        End Set
    End Property
    Public WriteOnly Property BuyerName() As String
        
        Set(ByVal value As String)
            StrBuyerName = value
        End Set
    End Property
    Public WriteOnly Property QuantityOrdered() As Integer
        
        Set(ByVal value As Integer)
            IntQuantityOrdered = value
        End Set
    End Property
    Public ReadOnly Property PurchaseOrderNumber() As String
        Get
            Return StrPurchaseOrderNumber
        End Get
    End Property

    Public Sub New()
        MyBase.New()
        InitializeComponent()

    End Sub

    Private Sub AddPurchaseOrder_ExecuteCode(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SQLInsertUpdate()

    End Sub
    Private Sub SQLInsertUpdate()
        Dim StrSQL As String
        Dim IntPurchaseOrderID As Integer
        Try
            clsDB = New SQLAccess(My.Settings.ConnString.ToString)
            StrSQL = "Insert into tblPurchaseOrders(StrPartNumber,DtePurchaseDate,DteExpectedDate," & _
                "StrBuyerLogin,StrBuyerName,IntQuantityOrdered) values('" & StrPartNumber & "'," & _
                "'" & DtePurchaseDate & "','" & DteExpectedDate & "','" & StrBuyerLogin & "'," & _
                "'" & StrBuyerName & "'," & IntQuantityOrdered & ") Select @@Identity"
            If clsDB.ExecuteSingleNumberReturnSQL(StrSQL) Then
                IntPurchaseOrderID = clsDB.NumberValue
            End If

            Select Case IntPurchaseOrderID
                Case Is < 10
                    StrPurchaseOrderNumber = "00000" & IntPurchaseOrderID
                Case Is < 100
                    StrPurchaseOrderNumber = "0000" & IntPurchaseOrderID
                Case Is < 1000
                    StrPurchaseOrderNumber = "000" & IntPurchaseOrderID
                Case Is < 10000
                    StrPurchaseOrderNumber = "00" & IntPurchaseOrderID
                Case Is < 100000
                    StrPurchaseOrderNumber = "0" & IntPurchaseOrderID
                Case Else
                    StrPurchaseOrderNumber = CStr(IntPurchaseOrderID)
            End Select
            StrSQL = "Update tblpurchaseorders set StrPurchaseOrderNumber='" & StrPurchaseOrderNumber & "' " & _
                "where intpurchaseorderid = " & IntPurchaseOrderID
            If Not clsDB.ExecuteNonQuerySQL(StrSQL) Then
                StrPurchaseOrderNumber = String.Empty
            End If


        Catch ex As Exception

        End Try
    End Sub
End Class
