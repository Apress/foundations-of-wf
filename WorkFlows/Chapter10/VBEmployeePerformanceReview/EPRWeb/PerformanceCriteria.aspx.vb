
Partial Class PerformanceCriteria
    Inherits System.Web.UI.Page
    Private clsepr As EPR

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            txtReviewID.Text = Server.HtmlEncode(Request.Cookies("ReviewID").Value)
            txtEmployeeID.Text = Server.HtmlEncode(Request.Cookies("EmployeeID").Value)
        End If


    End Sub

    Protected Sub btnReturn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        Response.Redirect("NewReview.aspx")
    End Sub
    Private Sub Save()
        Dim r As GridViewRow
        Dim t As TextBox
        Dim chk As CheckBox
        Try
            clsepr = New EPR
            For Each r In DGQuestions.Rows
                t = r.FindControl("textbox1")
                chk = r.FindControl("checkbox1")
                If chk.Checked Then
                    clsepr.Response = 4
                Else
                    chk = r.FindControl("checkbox2")
                    If chk.Checked Then
                        clsepr.Response = 3
                    Else
                        chk = r.FindControl("checkbox3")
                        If chk.Checked Then
                            clsepr.Response = 2
                        Else
                            chk = r.FindControl("checkbox4")
                            If chk.Checked Then
                                clsepr.Response = 1
                            Else
                                clsepr.Response = 0
                            End If
                        End If
                    End If
                End If
                clsepr.Comments = r.Cells(8).Text
                clsepr.UpdateReviewQuestion(Trim(txtReviewID.Text), t.Text)

            Next
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub DGQuestions_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles DGQuestions.SelectedIndexChanging
        Dim t As TextBox
        Try
            clsepr = New EPR
            t = DGQuestions.Rows(e.NewSelectedIndex).FindControl("textbox1")
            txtQuestionID.Text = t.Text
            txtComments.Text = DGQuestions.Rows(e.NewSelectedIndex).Cells(8).Text
            lblcomments.Visible = True
            txtComments.Visible = True
            btnSaveComments.Visible = True
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub btnSaveComments_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveComments.Click
        Try
            clsepr = New EPR
            If clsepr.UpdateCriteriaComment(Trim(txtReviewID.Text), Trim(txtQuestionID.Text), Trim(txtComments.Text)) Then
                lblcomments.Visible = False
                txtComments.Visible = False
                btnSaveComments.Visible = False
                DGQuestions.DataBind()
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class
