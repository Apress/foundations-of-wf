
Partial Class MyReviews
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            txtEmployeeID.Text = Server.HtmlEncode(Request.Cookies("EmployeeID").Value)
        End If

    End Sub

    Protected Sub DGReviews_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles DGReviews.SelectedIndexChanging
        If Not Request.Cookies("ReviewID") Is Nothing Then
            Dim cook As HttpCookie
            cook = Request.Cookies("ReviewID")
            cook.Value = Trim(DGReviews.Rows(e.NewSelectedIndex).Cells(1).Text)
            Response.Cookies.Set(cook)
        Else
            Dim cook As HttpCookie
            cook = New HttpCookie("ReviewID", Trim(DGReviews.Rows(e.NewSelectedIndex).Cells(1).Text))
            cook.Expires = DateTime.Now.AddDays(1)
            Response.Cookies.Add(cook)
        End If
        Response.Redirect("Review.aspx")
    End Sub
End Class
