Imports System.Data.SqlClient
Imports System.Data
Public Class SQLAccess
    Implements IDisposable
#Region "Private Variables"
    Private Local_Conn As New SqlConnection
    Private Local_Comm As New SqlCommand
    Private Local_Dreader As SqlDataReader
    Private Local_SQL As String
    Private Local_ConnString As String
    Private Local_StringReturned As String
    Private Local_NumberReturned As Long
    Private Local_SPName As String
    Private Local_Parameter As SqlParameter
    Private Local_SPPrefix As String
    Private blnMoreRecords As Boolean
    Private IntRecordsAffected As Integer
    Private Local_DataAdapter As SqlDataAdapter
    Private Local_DataSet As New DataSet
    Private Local_DataTable As New DataTable
    Private Local_DataColumn As New DataColumn
    Private Local_DataRow As DataRow
#End Region

#Region "Public Properties"
    Public Property ConnectionString() As String
        Get
            Return Local_ConnString
        End Get
        Set(ByVal Value As String)
            Local_ConnString = Value

        End Set
    End Property
    Public Property SQLString() As String
        Get
            Return Local_SQL
        End Get
        Set(ByVal Value As String)
            Local_SQL = Value
        End Set
    End Property

    Public Property SPName() As String
        Get
            Return Local_SPName
        End Get
        Set(ByVal Value As String)
            Local_SPName = Value
        End Set
    End Property
#End Region

#Region "Public Readonly"
    Public ReadOnly Property StringValue() As String
        Get
            Return Local_StringReturned
        End Get
    End Property
    Public ReadOnly Property NumberValue() As Integer
        Get
            Return Local_NumberReturned
        End Get
    End Property
#End Region

#Region "Constructors"
    Public Sub New()
        Local_ConnString = ""
        blnMoreRecords = False
    End Sub
    Public Sub New(ByVal ConnectionString As String)
        Local_ConnString = ConnectionString
        blnMoreRecords = False
    End Sub
#End Region

#Region "Public Methods"
   
    Public Sub AddStringInputParameter(ByVal ParameterName As String, ByVal Value As String)
        'This function will add an input parameter to a command object with the name provided in parametername
        'and the value in the value parameter. 

        Local_Parameter = New SqlParameter
        Local_Parameter.Direction = ParameterDirection.Input
        'SQL Server requires the @ sign, determine if the passed in parameter already has the symbol or not
        If InStr(ParameterName, "@") = 0 Then
            Local_Parameter.ParameterName = "@" & ParameterName
        Else
            Local_Parameter.ParameterName = ParameterName
        End If
        If Value & "" > "" Then
            Local_Parameter.Value = Value
        Else
            Local_Parameter.Value = ""
        End If

        'Add the parameter
        Try
            Local_Comm.Parameters.Add(Local_Parameter)
        Catch newexception As Exception
            Throw newexception
        End Try
    End Sub
    Public Sub AddDateInputParameter(ByVal ParameterName As String, ByVal Value As String)
        'This function will add an input parameter to a command object with the name provided in parametername
        'and the value in the value parameter. 

        Local_Parameter = New SqlParameter
        Local_Parameter.Direction = ParameterDirection.Input
        'SQL Server requires the @ sign, determine if the passed in parameter already has the symbol or not
        If InStr(ParameterName, "@") = 0 Then
            Local_Parameter.ParameterName = "@" & ParameterName
        Else
            Local_Parameter.ParameterName = ParameterName
        End If
        If Value & "" > "" Then
            Local_Parameter.Value = Value
        Else
            Local_Parameter.Value = "1/1/1900"
        End If

        'Add the parameter
        Try
            Local_Comm.Parameters.Add(Local_Parameter)
        Catch newexception As Exception
            Throw newexception
        End Try
    End Sub
    Public Sub AddNumberInputParameter(ByVal ParameterName As String, ByVal Value As String)
        'This function will add an input parameter to a command object with the name provided in parametername
        'and the value in the value parameter. 

        Local_Parameter = New SqlParameter
        Local_Parameter.Direction = ParameterDirection.Input
        'SQL Server requires the @ sign, determine if the passed in parameter already has the symbol or not
        If InStr(ParameterName, "@") = 0 Then
            Local_Parameter.ParameterName = "@" & ParameterName
        Else
            Local_Parameter.ParameterName = ParameterName
        End If
        If Value & "" > "" Then
            Local_Parameter.Value = Value
        Else
            Local_Parameter.Value = 0
        End If

        'Add the parameter
        Try
            Local_Comm.Parameters.Add(Local_Parameter)
        Catch newexception As Exception
            Throw newexception
        End Try
    End Sub
    Public Sub AddBooleanInputParameter(ByVal ParameterName As String, ByVal Value As String)
        'This function will add an input parameter to a command object with the name provided in parametername
        'and the value in the value parameter. 

        Local_Parameter = New SqlParameter
        Local_Parameter.Direction = ParameterDirection.Input
        'SQL Server requires the @ sign, determine if the passed in parameter already has the symbol or not
        If InStr(ParameterName, "@") = 0 Then
            Local_Parameter.ParameterName = "@" & ParameterName
        Else
            Local_Parameter.ParameterName = ParameterName
        End If
        If Value & "" > "" Then
            If CBool(Value) = True Then
                Local_Parameter.Value = 1
            Else
                Local_Parameter.Value = 0
            End If
        Else
            Local_Parameter.Value = 0
        End If

        'Add the parameter
        Try
            Local_Comm.Parameters.Add(Local_Parameter)
        Catch newexception As Exception
            Throw newexception
        End Try
    End Sub
    
    Public Function ExecuteSingleStringValueSP(ByVal SPName As String) As Boolean
        'This function will first verify a stored procedure has been passed to this class via the public property by a
        'call to a private method. Next this function will execute the stored procedure and assign the returned
        'single number value to a local string to be accessed via the public property

        ExecuteSingleStringValueSP = False
        Local_StringReturned = ""
        Local_SPName = SPName
        Try
            If PrepareSPCommand() Then
                Local_StringReturned = Local_Comm.ExecuteScalar
                If Local_StringReturned > "" Then
                    ExecuteSingleStringValueSP = True
                End If
                Local_Comm.Parameters.Clear()
                Local_Comm.Dispose()
            End If
        Catch castex As InvalidCastException
            ExecuteSingleStringValueSP = True
            Local_StringReturned = ""
        Catch newexception As SqlException
            Throw newexception
        Finally
            Dispose()
        End Try

    End Function
    
    Public Function ExecuteSingleStringReturnSQL(ByVal SQLString As String) As Boolean
        'This function will first verify a sql string has been passed to this class via the public property by a
        'call to a private method. Next this function will execute the sql string and assign the returned
        'single number value to a local string to be accessed via the public property

        ExecuteSingleStringReturnSQL = False
        Local_StringReturned = ""
        Local_SQL = SQLString
        Try
            If PrepareCommand() Then
                'The command object has been built
                Local_StringReturned = Local_Comm.ExecuteScalar
                If Local_StringReturned > "" Then
                    ExecuteSingleStringReturnSQL = True
                End If
                Local_Comm.Dispose()
            End If
        Catch castex As InvalidCastException
            ExecuteSingleStringReturnSQL = True
            Local_StringReturned = ""
        Catch newexception As SqlException
            'An error has occured, throw the exception to the next exception handler
            Throw newexception
        Finally
            Dispose()
        End Try



    End Function
    
    Public Function ExecuteSingleNumberValueSP(ByVal SPName As String) As Boolean
        'This function will first verify a stored procedure has been passed to this class via the public property by a
        'call to a private method. Next this function will execute the stored procedure and assign the returned
        'single number value to a local string to be accessed via the public property

        ExecuteSingleNumberValueSP = False
        Local_NumberReturned = 0
        Local_SPName = SPName
        Try
            If PrepareSPCommand() Then
                'The command object has been built
                Local_NumberReturned = Local_Comm.ExecuteScalar
                If Not IsDBNull(Local_NumberReturned) Then
                    ExecuteSingleNumberValueSP = True
                End If
                Local_Comm.Parameters.Clear()
                Local_Comm.Dispose()

            End If
        Catch newexception As SqlException
            'An error has occured, throw the exception to the next exception handler
            Throw newexception
        Finally
            Dispose()
        End Try



    End Function
   
    Public Function ExecuteSingleNumberReturnSQL(ByVal SQLString As String) As Boolean
        'This function will first verify a sql string has been passed to this class via the public property by a
        'call to a private method. Next this function will execute the sql statements and assign the returned
        'single number value to a local string to be accessed via the public property

        Local_NumberReturned = 0
        ExecuteSingleNumberReturnSQL = False
        Local_SQL = SQLString
        Try
            If PrepareCommand() Then
                'The command object has been built
                Local_NumberReturned = Local_Comm.ExecuteScalar
                If Not IsDBNull(Local_NumberReturned) Then
                    ExecuteSingleNumberReturnSQL = True
                End If
                Local_Comm.Dispose()
            End If
        Catch newexception As SqlException
            'An error has occured, throw the exception to the next exception handler
            Throw newexception
        Finally
            Dispose()
        End Try

    End Function
    
    Public Function ExecuteInsertUpdateSP(ByVal SPName As String) As Boolean
        'This function will first verify a stored procedure name has been passed to this class via the public property by a
        'call to a private method. Next this function will execute the stored procedure and assign the returned
        'value for the number of records affected to a local variable to be accessed via the public property

        ExecuteInsertUpdateSP = False
        IntRecordsAffected = 0
        Local_SPName = SPName
        Try
            If PrepareSPCommand() Then
                'The command object has been built, execute the stored procedure
                IntRecordsAffected = Local_Comm.ExecuteNonQuery()
                Local_Comm.Parameters.Clear()
                Local_Comm.Dispose()
                If IntRecordsAffected > 0 Then
                    ExecuteInsertUpdateSP = True
                End If
            End If
        Catch newexception As SqlException
            'An error has occured, throw the exception to the next exception handler
            Throw newexception
        Finally
            Dispose()
        End Try



    End Function
    
    Public Function ExecuteNonQuerySQL(ByVal SQLString As String) As Boolean
        'This function will first verify a sql string has been passed to this class via the public property by a
        'call to a private method. Next this function will execute the sql statements and assign the returned
        'value for the number of records affected to a local variable to be accessed via the public property

        'Initialize the variables
        Local_StringReturned = ""
        ExecuteNonQuerySQL = False
        IntRecordsAffected = 0
        Local_SQL = SQLString
        Try
            If PrepareCommand() Then
                'The command object is setup, execute the query
                IntRecordsAffected = Local_Comm.ExecuteNonQuery()
                Local_Comm.Dispose()
                If IntRecordsAffected > 0 Then
                    ExecuteNonQuerySQL = True
                End If
            End If
        Catch newexception As Exception
            'An error has occured, throw the exception to the next exception handler
            Throw newexception
        Finally
            Dispose()
        End Try

    End Function
    Public Function RetrieveDataReaderSP(ByVal SPName As String) As SqlDataReader
        'This function will create, retrieve, and return a data reader based on a stored procedure. 
        'This function will make a call to preparecommand to verify the command object can be created 
        'and an open connection can be establish. Next this function will attempt to create the reader and assign it to the function to be returned
        Local_SPName = SPName
        Try
            If PrepareSPCommand() Then
                RetrieveDataReaderSP = Local_Comm.ExecuteReader()
                Local_Comm.Parameters.Clear()
                Local_Comm.Dispose()
            End If
        Catch newexception As Exception
            Throw newexception
        End Try

    End Function
    
    Public Function RetrieveDataReader(ByVal SQLString As String) As SqlDataReader
        'This function will create, retrieve, and return a data reader based on a sql statement. This function will make a call to
        'preparecommand to verify the command object can be created and an open connection can be establish
        'Next this function will attempt to create the reader and assign it to the function to be returned
        Local_SQL = SQLString
        Try
            If PrepareCommand() Then
                RetrieveDataReader = Local_Comm.ExecuteReader
            End If
        Catch newexception As Exception
            Throw newexception
        End Try


    End Function
    
    Public Function RetrieveDataAdapterSQL(ByVal SQLString As String) As SqlDataAdapter
        Local_SQL = SQLString
        Try
            If PrepareCommand() Then
                RetrieveDataAdapterSQL = New SqlDataAdapter(Local_Comm.CommandText, Local_Conn)
            End If
        Catch newexception As SqlException
            Throw newexception
        End Try

    End Function
    
    Public Function RetrieveDataAdapterSP(ByVal SPName As String) As SqlDataAdapter
        Local_SPName = SPName
        Try
            If PrepareSPCommand() Then
                RetrieveDataAdapterSP = New SqlDataAdapter(Local_Comm)
            End If
        Catch newexception As SqlException
            Throw newexception
        End Try

    End Function
    
    Public Function RetrieveDataSetSP(ByVal SPName As String) As DataSet
        Local_SPName = SPName

        Try
            If PrepareSPCommand() Then
                Local_DataAdapter = New SqlDataAdapter(Local_Comm)
                Local_DataAdapter.Fill(Local_DataSet)
            End If
            Return Local_DataSet
        Catch newexception As SqlException
            Throw newexception
        Finally
            Local_Comm.Dispose()
            Dispose()
        End Try

    End Function
    Public Function RetrieveDataTableSP(ByVal SPName As String) As DataTable
        Local_SPName = SPName
        Try
            If PrepareSPCommand() Then
                Local_DataAdapter = New SqlDataAdapter(Local_Comm)
                Local_DataAdapter.Fill(Local_DataTable)
                Return Local_DataTable
            End If
        Catch newexception As Exception
            Throw newexception
        Finally
            Local_Comm.Dispose()
            Dispose()
        End Try
    End Function
    Public Function RetrieveDataTableSQL(ByVal SQL As String) As DataTable
        Local_SQL = SQL
        Try
            If PrepareCommand() Then
                Local_DataAdapter = New SqlDataAdapter(Local_Comm.CommandText, Local_Conn)
                Local_DataAdapter.Fill(Local_DataTable)
                Return Local_DataTable
            End If
        Catch newexception As Exception
            Throw newexception
        Finally
            Local_Comm.Dispose()
            Dispose()
        End Try
    End Function
    Public Function CreateDataTable(ByVal TableName As String) As Boolean
        Try
            Local_DataTable = New DataTable(TableName)
            Return True
        Catch newexception As Exception
            Return False
            Throw newexception
        End Try
    End Function
    Public Function AddColumn(ByVal TableName As String, ByVal ColumnName As String, ByVal ColumnType As Type) As Boolean
        Try
            If Not Local_DataTable.IsInitialized Then
                Local_DataTable = New DataTable(TableName)
            Else
                Local_DataColumn = New DataColumn(ColumnName, ColumnType)
                Local_DataTable.Columns.Add(Local_DataColumn)
                Return True
            End If

        Catch newexception As Exception
            Return False
            Throw newexception
        Finally
            Local_DataColumn.Dispose()
        End Try

    End Function
    Public Function AddRow(ByVal Row As DataRow) As Boolean
        Try
            If Not Local_DataTable.IsInitialized Then
                Return False
            Else
                Local_DataRow = Row
                Local_DataTable.Rows.Add(Local_DataRow)
                Return True
            End If
        Catch newexception As Exception
            Return False
            Throw newexception
        Finally
            Local_DataRow = Nothing
        End Try
    End Function
    Public Function GetRow(ByVal Index As Integer) As DataRow
        Try
            Return Local_DataTable.Rows.Find(Index)
        Catch newexception As Exception
            Throw newexception
        End Try
    End Function
    Public Function RetrieveDataSetSQL(ByVal SQLString As String) As DataSet
        Local_SQL = SQLString
        Try
            If PrepareCommand() Then
                Local_DataAdapter = New SqlDataAdapter(Local_Comm)
                Local_DataAdapter.Fill(Local_DataSet)
            End If
            Return Local_DataSet
        Catch newexception As SqlException
            Throw newexception
        Finally
            Local_Comm.Dispose()
            Dispose()
        End Try
    End Function
    Public Sub Dispose() Implements IDisposable.Dispose
        Local_Conn.Close()
        If Not Local_Conn Is Nothing Then
            Local_Conn.Dispose()
        End If

        If Not Local_Comm Is Nothing Then
            Local_Comm.Dispose()
        End If
        Local_SQL = ""


    End Sub
    Public Sub CloseConnection()
        Local_Conn.Close()
    End Sub
    Public Sub ClearParameters()
        Local_Comm.Parameters.Clear()
    End Sub
#End Region

#Region "Private Methods"
    Private Function PrepareSPCommand() As Boolean
        'This function will create and assign the appropriate variables for the command object. First this
        'function will see if the connection is already open. If the connection is open the command object is
        'attached to the existing connection otherwise a new connection is attempted by a call to MakeConnection.


        PrepareSPCommand = False

        If Local_SPName > "" Then
            If Not Local_Conn.State = ConnectionState.Open Then
                'Connection is not open
                Try
                    If MakeConnection() Then
                        'Connection has been made
                        Local_Comm.CommandText = Local_SPPrefix & Local_SPName
                        Local_Comm.CommandType = CommandType.StoredProcedure
                        Local_Comm.Connection = Local_Conn
                        PrepareSPCommand = True
                    End If
                Catch newexception As Exception
                    Throw newexception
                End Try
            Else
                'Connection is already open
                Local_Comm.CommandText = Local_SPPrefix & Local_SPName
                Local_Comm.CommandType = CommandType.StoredProcedure
                Local_Comm.Connection = Local_Conn
                PrepareSPCommand = True
            End If
        Else
            Throw New Exception("Stored procedure not provided")
        End If
    End Function
    Private Function PrepareCommand() As Boolean
        'This function will create and assign the appropriate variables for the command object. First this
        'function will see if the connection is already open. If the connection is open the command object is
        'attached to the existing connection otherwise a new connection is attempted by a call to MakeConnection.

        PrepareCommand = False
        If Local_SQL > "" Then
            If Not Local_Conn.State = ConnectionState.Open Then
                'Connection is not open
                Try
                    If MakeConnection() Then
                        'Connection has been made
                        Local_Comm.CommandText = Local_SQL
                        Local_Comm.CommandType = CommandType.Text
                        Local_Comm.Connection = Local_Conn
                        PrepareCommand = True
                    End If
                Catch newexception As Exception
                    Throw newexception
                End Try
            Else
                'Connection is already open
                Local_Comm.CommandText = Local_SQL
                Local_Comm.CommandType = CommandType.Text
                Local_Comm.Connection = Local_Conn
                PrepareCommand = True
            End If
        Else
            Throw New Exception("SQLString not provided")
        End If
    End Function
    Private Function MakeConnection() As Boolean
        'This function will see if the connection string property has been set. If it has not been set
        'a call to the checklocalconnectionstringproperties will be made to see if the properties of the
        'connection string have been provide. If neither exists an error is raised since the connection
        'string has not been established. Otherwise this function attempts to open the connection and throws
        'any encountered exceptions

        MakeConnection = False

        Local_Conn.ConnectionString = Local_ConnString
        'The connectionstring public property has been populated, now try to open the connection
        Try
            Local_Conn.Open()
            MakeConnection = True
        Catch newexception As SqlException
            'The connection could not be established. Throw the exception to the next exception handler
            Throw newexception
        End Try


    End Function
    
#End Region


End Class
