Imports System.Data.SqlClient
Public Class EPR
    Inherits StateMachineWorkflowActivity
    Private Local_Conn As New SqlConnection
    Private Local_Comm As New SqlCommand
    Private Local_Parameter As SqlParameter
    Private IntReviewID As Integer
    Private StrEmailAddress As String
    Public Property ReviewID() As Integer
        Get
            Return IntReviewID
        End Get
        Set(ByVal value As Integer)
            IntReviewID = value
        End Set
    End Property
    Private Sub ProcessToSupervisor(ByVal sender As System.Object, ByVal e As System.Workflow.Activities.ExternalDataEventArgs)
        Try
            Local_Conn = New SqlConnection
            Local_Comm = New SqlCommand

            AddInputParameter("@IntReviewID", IntReviewID)
            If ExecuteNonQuerySP("usp_ReviewToSupervisor") Then
                AddInputParameter("@IntReviewID", IntReviewID)
                StrEmailAddress = ReturnSingleStringSP("usp_RetrieveSupervisorEmailAddress")
                SendEmailToSupervisor.ToAddress = StrEmailAddress
                SendEmailToSupervisor.From = "Notifications@yourcompany.com"
                SendEmailToSupervisor.Body = "An Employee Review has been sent to you"
                SendEmailToSupervisor.Subject = "Employee Review Notification"
                SendEmailToSupervisor.SmtpHost = My.Settings.SMTPAddress.ToString
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ProcessToEmployee(ByVal sender As System.Object, ByVal e As System.Workflow.Activities.ExternalDataEventArgs)
        Try
            Local_Conn = New SqlConnection
            Local_Comm = New SqlCommand
            AddInputParameter("@IntReviewID", IntReviewID)
            If ExecuteNonQuerySP("usp_ReviewToEmployee") Then
                AddInputParameter("@IntReviewID", IntReviewID)
                StrEmailAddress = ReturnSingleStringSP("usp_RetrieveEmployeeEmailAddress")
                SendEmailToSupervisor.ToAddress = StrEmailAddress
                SendEmailToSupervisor.From = "Notifications@yourcompany.com"
                SendEmailToSupervisor.Body = "An Employee Review has been sent to you"
                SendEmailToSupervisor.Subject = "Employee Review Notification"
                SendEmailToSupervisor.SmtpHost = My.Settings.SMTPAddress.ToString
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ProcessApproved(ByVal sender As System.Object, ByVal e As System.Workflow.Activities.ExternalDataEventArgs)
        Try
            Local_Conn = New SqlConnection
            Local_Comm = New SqlCommand
            AddInputParameter("@IntReviewID", IntReviewID)
            If ExecuteNonQuerySP("usp_ReviewApproved") Then
                AddInputParameter("@IntReviewID", IntReviewID)
                StrEmailAddress = ReturnSingleStringSP("usp_RetrieveHREmailAddress")
                SendEmailToSupervisor.ToAddress = StrEmailAddress
                SendEmailToSupervisor.From = "Notifications@yourcompany.com"
                SendEmailToSupervisor.Body = "An Employee Review has been Approved and Completed"
                SendEmailToSupervisor.Subject = "Employee Review Notification"
                SendEmailToSupervisor.SmtpHost = My.Settings.SMTPAddress.ToString
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ProcessNotApproved(ByVal sender As System.Object, ByVal e As System.Workflow.Activities.ExternalDataEventArgs)
        Try
            Local_Conn = New SqlConnection
            Local_Comm = New SqlCommand
            AddInputParameter("@IntReviewID", IntReviewID)
            If ExecuteNonQuerySP("usp_ReviewNotApproved") Then
                AddInputParameter("@IntReviewID", IntReviewID)
                StrEmailAddress = ReturnSingleStringSP("usp_RetrieveHREmailAddress")
                SendEmailToSupervisor.ToAddress = StrEmailAddress
                SendEmailToSupervisor.From = "Notifications@yourcompany.com"
                SendEmailToSupervisor.Body = "An Employee Review has been NOT Approved"
                SendEmailToSupervisor.Subject = "Employee Review Notification"
                SendEmailToSupervisor.SmtpHost = My.Settings.SMTPAddress.ToString
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub AddInputParameter(ByVal ParameterName As String, ByVal Value As String)
        Local_Parameter = New SqlParameter
        Local_Parameter.Direction = ParameterDirection.Input
        If InStr(ParameterName, "@") = 0 Then
            Local_Parameter.ParameterName = "@" & ParameterName
        Else
            Local_Parameter.ParameterName = ParameterName
        End If
        Try
            Local_Comm.Parameters.Add(Local_Parameter)
        Catch newexception As Exception
            Throw newexception
        End Try
    End Sub
    Private Function ExecuteNonQuerySP(ByVal SPName As String) As Boolean

        Dim Local_NumberReturned As Long
        Try
            If Not Local_Conn.State = ConnectionState.Open Then
                Local_Conn.ConnectionString = My.Settings.ConnString
                Local_Conn.Open()
                Local_Comm.CommandText = SPName
                Local_Comm.CommandType = CommandType.StoredProcedure
                Local_Comm.Connection = Local_Conn
                Local_NumberReturned = CInt(Local_Comm.ExecuteNonQuery)
                If Local_NumberReturned > 0 Then
                    Return True
                Else
                    Return False
                End If
                Local_Comm.Dispose()
            End If
        Catch newexception As SqlException
            Throw newexception
        Finally
            Local_Conn.Close()
            Local_Conn.Dispose()
            Local_Comm.Parameters.Clear()
            Local_Comm.Dispose()
        End Try
    End Function
    Private Function ReturnSingleStringSP(ByVal SPName As String) As String
        Dim Local_StringReturned As String

        Try
            If Not Local_Conn.State = ConnectionState.Open Then
                Local_Conn.ConnectionString = My.Settings.ConnString
                Local_Conn.Open()
                Local_Comm.CommandText = SPName
                Local_Comm.CommandType = CommandType.StoredProcedure
                Local_Comm.Connection = Local_Conn
                Local_StringReturned = CStr(Local_Comm.ExecuteScalar)
                If Not IsDBNull(Local_StringReturned) Then
                    Return Local_StringReturned
                Else
                    Return String.Empty
                End If
                Local_Comm.Dispose()
            End If
        Catch newexception As SqlException
            Throw newexception
        Finally
            Local_Conn.Close()
            Local_Conn.Dispose()
            Local_Comm.Parameters.Clear()
            Local_Comm.Dispose()
        End Try
    End Function
End Class
