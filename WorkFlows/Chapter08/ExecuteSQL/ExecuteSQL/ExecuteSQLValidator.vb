
Public Class ExecuteSQLValidator
    Inherits System.Workflow.ComponentModel.Compiler.ActivityValidator
    Public Overrides Function ValidateProperties(ByVal manager As ValidationManager, ByVal obj As Object) As ValidationErrorCollection
        Dim Errors As New ValidationErrorCollection
        Dim activity As ExecuteSQL = TryCast(obj, ExecuteSQL)

        If activity IsNot Nothing Then
            If String.IsNullOrEmpty(activity.ConnectionString) Then
                Errors.Add(New ValidationError("No connection string provided", 1))
            End If

            If String.IsNullOrEmpty(activity.SQLStatement) Then
                Errors.Add(New ValidationError("No SQL Statment provided", 1))
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
