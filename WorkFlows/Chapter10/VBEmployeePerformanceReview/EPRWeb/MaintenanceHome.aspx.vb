
Partial Class MaintenanceHome
    Inherits System.Web.UI.Page

    Protected Sub btnDepartmentMaintenance_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDepartmentMaintenance.Click
        Response.Redirect("DepartmentMaintenance.aspx")
    End Sub

    Protected Sub btnLocationmaintenance_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLocationmaintenance.Click
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
End Class
