
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub btnMaintenance_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMaintenance.Click
        Response.Redirect("MaintenanceHome.aspx")
    End Sub
    Protected Sub btnNewSelfReview_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNewSelfReview.Click
        Response.Redirect("NewReview.aspx")
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim clsepr As EPR
        Dim IntemployeeID As Integer
        Dim cook As HttpCookie

        Try
            clsepr = New EPR
            IntemployeeID = clsepr.RetrieveEmployeeID("bmyers")
            cook = New HttpCookie("EmployeeID", IntemployeeID)
            cook.Expires = DateTime.Now.AddDays(1)
            Response.Cookies.Add(cook)
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub btnExistingReviews_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExistingReviews.Click
        Response.Redirect("MyReviews.aspx")
    End Sub
End Class
