
Partial Class EmployeeMaintenance
    Inherits System.Web.UI.Page
    Private clsEPR As EPR
    Protected Sub btnMaintenanceHome_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMaintenanceHome.Click
        Response.Redirect("MaintenanceHome.aspx")
    End Sub
    Protected Sub btnLocationmaintenance_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLocationmaintenance.Click
        Response.Redirect("LocationMaintenance.aspx")
    End Sub

    Protected Sub btnQuestionMaintenance_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnQuestionMaintenance.Click
        Response.Redirect("QuestionMaintenance.aspx")
    End Sub

    Protected Sub btnDepartmentMaintenance_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDepartmentMaintenance.Click
        Response.Redirect("DepartmentMaintenance.aspx")
    End Sub

    Protected Sub btnMaintenance_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMaintenance.Click
        Response.Redirect("Default.aspx")
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Private Sub ShowFields()
        lblQuestion.Visible = True
        txtQuestion.Visible = True
        btnSave.Visible = True
        chkActive.Visible = True
        btnDelete.Visible = True
        txtOrder.Visible = True
        lblOrder.Visible = True
    End Sub
    Private Sub HideFields()
        txtOrder.Visible = False
        lblOrder.Visible = False
        lblQuestion.Visible = False
        txtQuestion.Visible = False
        btnSave.Visible = False
        chkActive.Visible = False
        btnDelete.Visible = False
    End Sub

    Protected Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        txtQuestionID.Text = String.Empty
        txtQuestion.Text = String.Empty
        ShowFields()
    End Sub

    Protected Sub DGDepartments_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles DGQuestion.SelectedIndexChanging
        Dim chk As CheckBox
        txtQuestionID.Text = DGQuestion.Rows(e.NewSelectedIndex).Cells(1).Text
        txtOrder.Text = DGQuestion.Rows(e.NewSelectedIndex).Cells(2).Text
        txtQuestion.Text = DGQuestion.Rows(e.NewSelectedIndex).Cells(3).Text

        chk = DGQuestion.Rows(e.NewSelectedIndex).Cells(3).FindControl("checkbox1")
        chkActive.Checked = chk.Checked
        ShowFields()

    End Sub

    Protected Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            clsEPR = New EPR
            If txtQuestionID.Text = String.Empty Then
                'This is a new department
                If clsEPR.AddQuestion(Trim(txtQuestion.Text), Trim(txtOrder.Text)) Then
                    DGQuestion.DataBind()
                    HideFields()
                Else
                    lblerrors.Text = "Could not add"
                    lblerrors.Visible = True
                End If
            Else
                clsEPR.Question = Trim(txtQuestion.Text)
                clsEPR.Order = Trim(txtOrder.Text)
                If clsEPR.UpdateQuestion(Trim(txtQuestionID.Text), chkActive.Checked) Then
                    DGQuestion.DataBind()
                    HideFields()
                Else
                    lblerrors.Text = "Could not update"
                    lblerrors.Visible = True
                End If
            End If
        Catch ex As Exception
            lblerrors.Text = ex.Message
            lblerrors.Visible = True
        Finally
            clsEPR = Nothing
        End Try

    End Sub

    Protected Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            clsEPR = New EPR
            clsEPR.DeleteQuestion(Trim(txtQuestionID.Text))
            DGQuestion.DataBind()
            HideFields()

        Catch ex As Exception
            lblerrors.Text = ex.Message
            lblerrors.Visible = True
        Finally
            clsEPR = Nothing
        End Try
    End Sub
End Class
