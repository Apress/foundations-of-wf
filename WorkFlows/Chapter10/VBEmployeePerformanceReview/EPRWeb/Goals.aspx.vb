
Partial Class Goals
    Inherits System.Web.UI.Page
    Private clsepr As EPR

    Private Sub ShowFields()
        lblGoal.Visible = True
        txtGoal.Visible = True
        lblActionPlan.Visible = True
        txtActionPlan.Visible = True
        lblTargetCompletionDate.Visible = True
        txtTargetCompletionDate.Visible = True
        lblPriority.Visible = True
        txtPriority.Visible = True
        btnSaveGoal.Visible = True

    End Sub
    Private Sub HideFields()
        lblGoal.Visible = False
        txtGoal.Visible = False
        lblActionPlan.Visible = False
        txtActionPlan.Visible = False
        lblTargetCompletionDate.Visible = False
        txtTargetCompletionDate.Visible = False
        lblPriority.Visible = False
        txtPriority.Visible = False
        btnSaveGoal.Visible = False
    End Sub

    Protected Sub btnAddGoal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddGoal.Click
        ShowFields()
        txtGoalID.Text = String.Empty
    End Sub

    Protected Sub DGGoals_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles DGGoals.SelectedIndexChanging
      
        txtGoalID.Text = DGGoals.Rows(e.NewSelectedIndex).Cells(1).Text
        txtGoal.Text = DGGoals.Rows(e.NewSelectedIndex).Cells(2).Text
        txtActionPlan.Text = DGGoals.Rows(e.NewSelectedIndex).Cells(3).Text
        txtTargetCompletionDate.Text = DGGoals.Rows(e.NewSelectedIndex).Cells(4).Text
        txtPriority.Text = DGGoals.Rows(e.NewSelectedIndex).Cells(5).Text
        ShowFields()

    End Sub

    Protected Sub btnSaveGoal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveGoal.Click
        Try
            clsepr = New EPR
            clsepr.Goal = Trim(txtGoal.Text)
            clsepr.ActionPlan = Trim(txtActionPlan.Text)
            clsepr.TargetCompletionDate = Trim(txtTargetCompletionDate.Text)
            clsepr.Priority = Trim(txtPriority.Text)
            If txtGoalID.Text = String.Empty Then
                clsepr.AddGoal(Trim(txtReviewID.Text))
            Else
                clsepr.UpdateGoal(Trim(txtGoalID.Text))
            End If
            HideFields()
            DGGoals.DataBind()
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            txtReviewID.Text = Server.HtmlEncode(Request.Cookies("ReviewID").Value)
        End If
    End Sub
End Class
