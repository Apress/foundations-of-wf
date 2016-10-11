Imports System.Workflow.Runtime
Imports System.Workflow.Runtime.Hosting
Imports System.Workflow.Activities

Partial Class Review
    Inherits System.Web.UI.Page
    Private clsEPR As EPR
    Private workflowruntime As WorkflowRuntime
    Private workflowinstance As WorkflowInstance
    Private workflowinstanceid As Guid
    Private eprservice As New EPRService.EPRService
    Protected Sub btnHome_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHome.Click
        Response.Redirect("Default.aspx")
    End Sub

    Protected Sub btnMaintenance_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMaintenance.Click
        Response.Redirect("MaintenanceHome.aspx")
    End Sub

    Protected Sub btnExistingReviews_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExistingReviews.Click
        Response.Redirect("MyReviews.aspx")
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            txtEmployeeID.Text = Server.HtmlEncode(Request.Cookies("EmployeeID").Value)
            If Not Request.Cookies("ReviewID") Is Nothing Then
                txtReviewID.Text = Server.HtmlEncode(Request.Cookies("ReviewID").Value)
                lblEmployeeCommentsHeader.Visible = True
                txtEmployeeComments.Visible = True
                lblEmployeeCommentsInstructions.Visible = True
                clsEPR = New EPR
                If clsEPR.RetrieveReview(Trim(txtReviewID.Text)) Then
                    txtSummary.Text = clsEPR.SummaryOfActivities
                    txtCareerInterest.Text = clsEPR.CareerInterests
                    txtEmployeeComments.Text = clsEPR.EmployeeComments
                End If
            Else
                Dim cook As HttpCookie
                cook = New HttpCookie("ReviewID", 0)
                cook.Expires = DateTime.Now.AddDays(1)
                Response.Cookies.Add(cook)
                txtReviewID.Text = String.Empty
                lblEmployeeCommentsHeader.Visible = False
                txtEmployeeComments.Visible = False
                lblEmployeeCommentsInstructions.Visible = False
            End If
            LoadEmployeeInformation()
        End If
    End Sub
    Private Sub LoadEmployeeInformation()
        Try
            clsEPR = New EPR
            If clsEPR.RetrieveEmployeeInformation(Trim(txtEmployeeID.Text)) Then
                txtEmployeeName.Text = clsEPR.FirstName & " " & clsEPR.LastName
                txtJobTitle.Text = clsEPR.JobTitle
                txtDepartment.Text = clsEPR.Department
                txtSupervisor.Text = clsEPR.SupervisorName

            End If
        Catch ex As Exception
            txterrors.Text = ex.Message
            txterrors.Visible = True
        Finally
            clsEPR = Nothing

        End Try
    End Sub

    Protected Sub btnPerformance_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPerformance.Click
        Save()
        Response.Redirect("PerformanceCriteria.aspx")
    End Sub

    Protected Sub btnGoals_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGoals.Click
        Save()
        Response.Redirect("Goals.aspx")
    End Sub
    Private Sub Save()
        Try
            clsEPR = New EPR
            clsEPR.SummaryOfActivities = Trim(txtSummary.Text)
            clsEPR.CareerInterests = Trim(txtCareerInterest.Text)
            If Not txtReviewID.Text = String.Empty Then
                clsEPR.EmployeeComments = String.Empty
                clsEPR.UpdateReview(Trim(txtReviewID.Text))
            Else
                txtReviewID.Text = clsEPR.AddReview(Trim(txtEmployeeID.Text))
            End If
            Dim cook As HttpCookie
            cook = Request.Cookies("ReviewID")
            cook.Value = Trim(txtReviewID.Text)
            Response.Cookies.Set(cook)
        Catch ex As Exception
            txterrors.Text = ex.Message
            txterrors.Visible = True
        Finally
            clsEPR = Nothing

        End Try
    End Sub

    Protected Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Save()
        Response.Redirect("Default.aspx")
    End Sub

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        If Session("WorkflowInstanceID") = 0 Then
            InitiateWorkflow()
            StartWorkflow()
            eprservice.RaiseEmployeetoSupervisor(Trim(txtReviewID.Text), workflowinstanceid)

        End If
    End Sub
    Private Sub InitiateWorkflow()
        Try
            workflowruntime = New WorkflowRuntime

            Dim dataExchangeService As New ExternalDataEventArgs(Session("WorkflowInstanceID"))

            workflowruntime.AddService(dataExchangeService)
            workflowruntime.AddService(eprservice)
            HttpContext.Current.Cache("WorkflowRuntime") = workflowruntime
            workflowruntime.StartRuntime()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub StartWorkflow()
        workflowinstanceid = System.Guid.NewGuid

        workflowinstance = workflowruntime.CreateWorkflow(GetType(EPR))
        workflowinstanceid = workflowinstance.InstanceId
        workflowinstance.Start()
        Session("WorkflowInstanceID") = workflowinstanceid
    End Sub
End Class
