Imports System.Data.SqlClient
<ActivityValidator(GetType(ExecuteSQLValidator))> _
Public Class ExecuteSQL
    Inherits System.Workflow.ComponentModel.Activity
    Public Shared ConnectionStringProperty As DependencyProperty = DependencyProperty.Register("ConnectionString", GetType(String), GetType(ExecuteSQL), New PropertyMetadata("ConnectionString"))
    Public Shared SQLStatementProperty As DependencyProperty = DependencyProperty.Register("SQLStatement", GetType(String), GetType(ExecuteSQL), New PropertyMetadata("SQL Statement"))
    Public Shared StatusProperty As DependencyProperty = DependencyProperty.Register("Status", GetType(Boolean), GetType(ExecuteSQL))
    Public Shared NewIDProperty As DependencyProperty = DependencyProperty.Register("NewID", GetType(Integer), GetType(ExecuteSQL))
    
    <DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)> _
    <ValidationOption(ValidationOption.Required)> _
    <BrowsableAttribute(True)> _
    <DescriptionAttribute("The ConnectionString property is used to specify the connection string to use.")> _
    Public Property ConnectionString() As String
        Get
            Return CType(MyBase.GetValue(ExecuteSQL.ConnectionStringProperty), String)
        End Get
        Set(ByVal value As String)
            MyBase.SetValue(ExecuteSQL.ConnectionStringProperty, value)
        End Set
    End Property
    <DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)> _
    <ValidationOption(ValidationOption.Required)> _
    <BrowsableAttribute(True)> _
    <DescriptionAttribute("The SQL Statement property is used to specify the SQL Statement to execute.")> _
    Public Property SQLStatement() As String
        Get
            Return CType(MyBase.GetValue(ExecuteSQL.SQLStatementProperty), String)
        End Get
        Set(ByVal value As String)
            MyBase.SetValue(ExecuteSQL.SQLStatementProperty, value)
        End Set
    End Property
    <DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)> _
    <ValidationOption(ValidationOption.None)> _
    <BrowsableAttribute(True)> _
    <DescriptionAttribute("The Status property will provide the status of the execution")> _
    Public ReadOnly Property Status() As Boolean
        Get
            Return CType(MyBase.GetValue(ExecuteSQL.StatusProperty), Boolean)
        End Get
    End Property
    <DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)> _
    <ValidationOption(ValidationOption.None)> _
    <BrowsableAttribute(True)> _
    <DescriptionAttribute("The NewID property will provide the ID of the record inserted for an Insert statement")> _
    Public ReadOnly Property NewID() As Integer
        Get
            Return CType(MyBase.GetValue(ExecuteSQL.NewIDProperty), Integer)
        End Get
    End Property
    Protected Overrides Function Execute(ByVal context As ActivityExecutionContext) As ActivityExecutionStatus
        Dim Local_Conn As New SqlConnection
        Dim Local_Comm As New SqlCommand
        Dim Local_NumberReturned As Long
        Try
            If Not Local_Conn.State = ConnectionState.Open Then
                Local_Conn.ConnectionString = MyBase.GetValue(ExecuteSQL.ConnectionStringProperty).ToString
                Local_Conn.Open()
                Local_Comm.CommandText = Me.SQLStatement
                Local_Comm.CommandType = CommandType.Text
                Local_Comm.Connection = Local_Conn
                Local_NumberReturned = CInt(Local_Comm.ExecuteScalar)

                MyBase.SetReadOnlyPropertyValue(ExecuteSQL.NewIDProperty, Local_NumberReturned)

                If Not IsDBNull(Local_NumberReturned) Then
                    MyBase.SetReadOnlyPropertyValue(ExecuteSQL.StatusProperty, True)
                Else
                    MyBase.SetReadOnlyPropertyValue(ExecuteSQL.StatusProperty, False)
                End If
                Local_Comm.Dispose()
            End If
        Catch newexception As SqlException
            Throw newexception
        Finally
            Dispose()
        End Try
    End Function
    
    
   
End Class
