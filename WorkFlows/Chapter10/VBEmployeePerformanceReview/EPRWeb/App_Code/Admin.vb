Imports System.Data

Public Class Admin
    Private DS As DataSet
    Private clsDB As SQLAccess
  
    Public Function GetDataReaderStringValue(ByVal DR As SqlClient.SqlDataReader, ByVal ColumnName As String) As String
        If DR(ColumnName) & "" > "" Then
            GetDataReaderStringValue = DR(ColumnName)
        Else
            GetDataReaderStringValue = ""
        End If
    End Function
    Public Function GetDataReaderIntegerValue(ByVal dr As SqlClient.SqlDataReader, ByVal ColumnName As String) As Integer
        If dr(ColumnName) & "" > "" Then
            GetDataReaderIntegerValue = dr(ColumnName)
        Else
            GetDataReaderIntegerValue = 0
        End If
    End Function
    Public Function GetDataReaderDecimalValue(ByVal dr As SqlClient.SqlDataReader, ByVal ColumnName As String) As Decimal
        If dr(ColumnName) & "" > "" Then
            GetDataReaderDecimalValue = dr(ColumnName)
        Else
            GetDataReaderDecimalValue = 0
        End If
    End Function
    Public Function GetDataReaderDateValue(ByVal dr As SqlClient.SqlDataReader, ByVal columnname As String) As Date
        If dr(columnname) & "" > "" Then
            GetDataReaderDateValue = dr(columnname)
        Else
            GetDataReaderDateValue = "1/1/1900"
        End If
    End Function
    Public Function GetDataReaderBitValue(ByVal dr As SqlClient.SqlDataReader, ByVal ColumnName As String) As Boolean
        If dr(ColumnName) = 1 Then
            GetDataReaderBitValue = True
        Else
            GetDataReaderBitValue = False
        End If
    End Function
    

End Class ' END CLASS DEFINITION Admin
