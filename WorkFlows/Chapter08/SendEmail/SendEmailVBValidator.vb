Imports System.Net.Mail
Imports System.Workflow.Activities
Imports System.Workflow.ComponentModel
Imports System.Workflow.ComponentModel.Compiler
Public Class SendEmailVBValidator
    Inherits System.Workflow.ComponentModel.Compiler.ActivityValidator
    Public Overrides Function ValidateProperties(ByVal manager As ValidationManager, ByVal obj As Object) As ValidationErrorCollection
        Dim Errors As New ValidationErrorCollection
        Dim activity As SendEmailVB = TryCast(obj, SendEmailVB)
        
        If activity IsNot Nothing Then
            If String.IsNullOrEmpty(activity.ToAddress) Then
                Errors.Add(New ValidationError("No To email address", 1))
            ElseIf Not activity.ToAddress.Contains("@") Then
                Errors.Add(New ValidationError("Invalid To email address", 2))
            End If

            If String.IsNullOrEmpty(activity.From) Then
                Errors.Add(New ValidationError("No from email address", 1))
            ElseIf Not activity.ToAddress.Contains("@") Then
                Errors.Add(New ValidationError("Invalid from email address", 2))
            End If
            If Errors.HasErrors Then
                Dim ErrorsMessage As String = String.Empty
                For Each validationError As ValidationError In Errors
                    ErrorsMessage = ErrorsMessage + String.Format("Validation error: Number{0}-'{1} ", _
                        validationError.ErrorNumber, validationError.ErrorText)
                Next
                Throw New InvalidOperationException(ErrorsMessage)
            End If

        End If
        Return Errors
    End Function

End Class
