<ExternalDataExchange()> _
Public Interface IReview
    Function CreateReview(ByVal Reviewer As String, ByVal Reviewee As String) As Boolean
    Event ReviewApproved As EventHandler(Of ExternalDataEventArgs)
    Event ReviewNotApproved As EventHandler(Of ExternalDataEventArgs)
End Interface
Public Class ReviewService : Implements IReview
    Private StrReviewer As String
    Private StrReviewee As String

    Public Function CreateReview(ByVal Reviewer As String, ByVal Reviewee As String) As Boolean Implements IReview.CreateReview
        StrReviewer = Reviewer
        StrReviewee = Reviewee
        MsgBox("Reviewer: " & StrReviewer)

        ThreadPool.QueueUserWorkItem(New System.Threading.WaitCallback(AddressOf AskForApproval))

        Return True
    End Function

    Public Event ReviewApproved(ByVal sender As Object, ByVal e As ExternalDataEventArgs) Implements IReview.ReviewApproved

    Public Event ReviewNotApproved(ByVal sender As Object, ByVal e As ExternalDataEventArgs) Implements IReview.ReviewNotApproved
    Private Sub AskForApproval(ByVal o As Object)
        If MsgBox("Do you approve the review for: " & StrReviewee & " ?", MsgBoxStyle.YesNo, "Approve review?") = MsgBoxResult.Yes Then
            RaiseEvent ReviewApproved(Nothing, Nothing)
        Else
            RaiseEvent ReviewNotApproved(Nothing, Nothing)
        End If
    End Sub
    Private Sub ApproveReview(ByVal sender As Object, ByVal e As ExternalDataEventArgs) Handles Me.ReviewApproved
        MsgBox("Reviewer: " & StrReviewer & " has approved the review for " & StrReviewee)
    End Sub
    Private Sub DoNotApproveReview(ByVal sender As Object, ByVal e As ExternalDataEventArgs) Handles Me.ReviewNotApproved
        MsgBox("Reviewer: " & StrReviewer & " has not approved the review for " & StrReviewee)
    End Sub

End Class
