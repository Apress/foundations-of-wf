
Partial Class LocationMaintenance
    Inherits System.Web.UI.Page
    Private clsEPR As EPR
    Protected Sub btnMaintenanceHome_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMaintenanceHome.Click
        Response.Redirect("MaintenanceHome.aspx")
    End Sub
    Protected Sub btnLocationmaintenance_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDepartmentmaintenance.Click
        Response.Redirect("LocationMaintenance.aspx")
    End Sub

    Protected Sub btnEmployeeMaintenance_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEmployeeMaintenance.Click
        Response.Redirect("EmployeeMaintenance.aspx")
    End Sub

    Protected Sub btnQuestionMaintenance_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnQuestionMaintenance.Click
        Response.Redirect("QuestionMaintenance.aspx")
    End Sub

    Protected Sub btnMaintenance_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMaintenance.Click
        Response.Redirect("Default.aspx")
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Private Sub ShowFields()
        lblLocation.Visible = True
        txtLocation.Visible = True
        btnSave.Visible = True
        chkActive.Visible = True
        btnDelete.Visible = True
    End Sub
    Private Sub HideFields()
        lblLocation.Visible = False
        txtLocation.Visible = False
        btnSave.Visible = False
        chkActive.Visible = False
        btnDelete.Visible = False
    End Sub

    Protected Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        txtLocationID.Text = String.Empty
        txtLocation.Text = String.Empty
        ShowFields()
    End Sub

    Protected Sub DGDepartments_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles DGLocations.SelectedIndexChanging
        Dim chk As CheckBox
        txtLocationID.Text = DGLocations.Rows(e.NewSelectedIndex).Cells(1).Text
        txtLocation.Text = DGLocations.Rows(e.NewSelectedIndex).Cells(2).Text
        chk = DGLocations.Rows(e.NewSelectedIndex).Cells(3).FindControl("checkbox1")
        chkActive.Checked = chk.Checked
        ShowFields()

    End Sub

    Protected Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            clsEPR = New EPR
            If txtLocationID.Text = String.Empty Then
                'This is a new department
                If clsEPR.AddLocation(Trim(txtLocation.Text)) Then
                    DGLocations.DataBind()
                    HideFields()
                Else
                    lblerrors.Text = "Could not add"
                    lblerrors.Visible = True
                End If
            Else
                If clsEPR.UpdateLocation(Trim(txtLocationID.Text), Trim(txtLocation.Text), chkActive.Checked) Then
                    DGLocations.DataBind()
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
            clsEPR.DeleteLocation(Trim(txtLocationID.Text))
            DGLocations.DataBind()
            HideFields()

        Catch ex As Exception
            lblerrors.Text = ex.Message
            lblerrors.Visible = True
        Finally
            clsEPR = Nothing
        End Try
    End Sub
End Class
