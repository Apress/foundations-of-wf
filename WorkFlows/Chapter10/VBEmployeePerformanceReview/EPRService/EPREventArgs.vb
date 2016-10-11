Imports System
Imports System.Workflow.Activities
<Serializable()> _
Public Class EPREventArgs
    Inherits ExternalDataEventArgs
    Private IntReviewID As Integer
    Public Property ReviewID() As Integer
        Get
            Return IntReviewID
        End Get
        Set(ByVal value As Integer)
            IntReviewID = value
        End Set
    End Property
    Public Sub New(ByVal InstanceID As Guid, ByVal ReviewID As Integer)
        MyBase.New(InstanceID)
        IntReviewID = ReviewID
    End Sub
End Class
