Imports Microsoft.VisualBasic

Public Class EPR
    Private IntDepartmentID As Integer
    Private StrDepartment As String
    Private IntEmployeeID As Integer
    Private StrFirstName As String
    Private StrLastName As String
    Private StrLogin As String
    Private StrPassword As String
    Private IntLocationID As Integer
    Private StrTitle As String
    Private IntSupervisorID As Integer
    Private blnHR As Boolean
    Private StrLocation As String
    Private IntQuestionID As Integer
    Private StrQuestion As String
    Private IntOrder As Integer
    Private IntReviewID As Integer
    Private DteDateCreated As Date
    Private StrSummaryOfActivities As String
    Private StrCareerInterests As String
    Private StrEmployeeComments As String
    Private DteEmployeeSignatureDate As Date
    Private DteSupervisorSignatureDate As Date
    Private StrGoal As String
    Private StrActionPlan As String
    Private StrTargetCompletionDate As String
    Private StrPriority As String
    Private IntResponse As Integer
    Private StrComments As String
    Private blnComplete As Boolean
    Private dteDateCompleted As Date
    Private clsDB As SQLAccess
    Private clsAdmin As Admin
    Private StrConnectionString As String
    Private StrSupervisor As String

    Private local_dr As Data.SqlClient.SqlDataReader
#Region "Public Properties"
    Public Property SupervisorName() As String
        Get
            Return StrSupervisor
        End Get
        Set(ByVal value As String)
            StrSupervisor = value
        End Set
    End Property
    Public Property Comments() As String
        Get
            Return StrComments
        End Get
        Set(ByVal value As String)
            StrComments = value
        End Set
    End Property
    Public Property Response() As Integer
        Get
            Return IntResponse
        End Get
        Set(ByVal value As Integer)
            IntResponse = value
        End Set
    End Property
    Public Property Priority() As String
        Get
            Return StrPriority
        End Get
        Set(ByVal value As String)
            StrPriority = value
        End Set
    End Property
    Public Property TargetCompletionDate() As String
        Get
            Return StrTargetCompletionDate
        End Get
        Set(ByVal value As String)
            StrTargetCompletionDate = value
        End Set
    End Property
    Public Property ActionPlan() As String
        Get
            Return StrActionPlan
        End Get
        Set(ByVal value As String)
            StrActionPlan = value
        End Set
    End Property
    Public Property Goal() As String
        Get
            Return StrGoal
        End Get
        Set(ByVal value As String)
            StrGoal = value
        End Set
    End Property
    Public Property DepartmentID() As Integer
        Get
            Return IntDepartmentID
        End Get
        Set(ByVal value As Integer)
            IntDepartmentID = value
        End Set
    End Property
    Public Property Department() As String
        Get
            Return StrDepartment
        End Get
        Set(ByVal value As String)
            StrDepartment = value
        End Set
    End Property
    Public Property EmployeeID() As Integer
        Get
            Return IntEmployeeID
        End Get
        Set(ByVal value As Integer)
            IntEmployeeID = value
        End Set
    End Property
    Public Property FirstName() As String
        Get
            Return StrFirstName
        End Get
        Set(ByVal value As String)
            StrFirstName = value
        End Set
    End Property
    Public Property LastName() As String
        Get
            Return StrLastName
        End Get
        Set(ByVal value As String)
            StrLastName = value
        End Set
    End Property
    Public Property Login() As String
        Get
            Return StrLogin
        End Get
        Set(ByVal value As String)
            StrLogin = value
        End Set
    End Property
    Public Property Password() As String
        Get
            Return StrPassword
        End Get
        Set(ByVal value As String)
            StrPassword = value
        End Set
    End Property
    Public Property Location() As String
        Get
            Return StrLocation
        End Get
        Set(ByVal value As String)
            StrLocation = value
        End Set
    End Property
    Public Property QuestionID() As Integer
        Get
            Return IntQuestionID
        End Get
        Set(ByVal value As Integer)
            IntQuestionID = value
        End Set
    End Property
    Public Property Question() As String
        Get
            Return StrQuestion
        End Get
        Set(ByVal value As String)
            StrQuestion = value
        End Set
    End Property
    Public Property Order() As Integer
        Get
            Return IntOrder
        End Get
        Set(ByVal value As Integer)
            IntOrder = value
        End Set
    End Property
    Public Property ReviewID() As Integer
        Get
            Return IntReviewID
        End Get
        Set(ByVal value As Integer)
            IntReviewID = value
        End Set
    End Property
    Public Property DateCreated() As Date
        Get
            Return DteDateCreated
        End Get
        Set(ByVal value As Date)
            DteDateCreated = value
        End Set
    End Property
    Public Property SummaryOfActivities() As String
        Get
            Return StrSummaryOfActivities
        End Get
        Set(ByVal value As String)
            StrSummaryOfActivities = value
        End Set
    End Property
    Public Property CareerInterests() As String
        Get
            Return StrCareerInterests
        End Get
        Set(ByVal value As String)
            StrCareerInterests = value
        End Set
    End Property
    Public Property EmployeeComments() As String
        Get
            Return StrEmployeeComments
        End Get
        Set(ByVal value As String)
            StrEmployeeComments = value
        End Set
    End Property
    Public Property SupervisorSignatureDate() As Date
        Get
            Return DteSupervisorSignatureDate
        End Get
        Set(ByVal value As Date)
            DteSupervisorSignatureDate = value
        End Set
    End Property
    Public Property JobTitle() As String
        Get
            Return StrTitle
        End Get
        Set(ByVal value As String)
            StrTitle = value
        End Set
    End Property
    Public Property Complete() As Boolean
        Get
            Return blnComplete
        End Get
        Set(ByVal value As Boolean)
            blnComplete = value
        End Set
    End Property
    Public Property DateCompleted() As Date
        Get
            Return dteDateCompleted
        End Get
        Set(ByVal value As Date)
            dteDateCompleted = value
        End Set
    End Property
#End Region
    Public Function RetrieveReview(ByVal ReviewID As Integer) As Boolean
        Try
            clsDB = New SQLAccess(StrConnectionString)
            clsAdmin = New Admin
            clsDB.AddNumberInputParameter("@IntReviewID", ReviewID)
            local_dr = clsDB.RetrieveDataReaderSP("usp_RetrieveReview")
            If local_dr.Read Then
                StrSummaryOfActivities = clsAdmin.GetDataReaderStringValue(local_dr, "StrSummaryOfActivities")
                StrCareerInterests = clsAdmin.GetDataReaderStringValue(local_dr, "StrCareerInterests")
                StrEmployeeComments = clsAdmin.GetDataReaderStringValue(local_dr, "StrEmployeeComments")
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            clsDB.Dispose()
        End Try
    End Function
    Public Function UpdateCriteriaComment(ByVal ReviewID As Integer, ByVal QuestionID As Integer, ByVal Comments As String) As Boolean
        Try
            clsDB = New SQLAccess(StrConnectionString)
            clsDB.AddNumberInputParameter("@IntReviewID", ReviewID)
            clsDB.AddNumberInputParameter("@IntQuestionID", QuestionID)
            clsDB.AddStringInputParameter("@StrComments", Comments)
            Return clsDB.ExecuteInsertUpdateSP("usp_UpdateCriteriaComment")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            clsDB.Dispose()
        End Try
    End Function
    Public Function RetrieveEmployeeInformation(ByVal EmployeeID As Integer) As Boolean
        Try
            clsDB = New SQLAccess(StrConnectionString)
            clsAdmin = New Admin
            clsDB.AddNumberInputParameter("@IntEmployeeID", EmployeeID)
            local_dr = clsDB.RetrieveDataReaderSP("usp_RetrieveEmployeeInformation")
            If local_dr.Read Then
                StrFirstName = clsAdmin.GetDataReaderStringValue(local_dr, "StrFirstName")
                StrLastName = clsAdmin.GetDataReaderStringValue(local_dr, "StrLastName")
                StrDepartment = clsAdmin.GetDataReaderStringValue(local_dr, "StrDepartment")
                StrTitle = clsAdmin.GetDataReaderStringValue(local_dr, "StrTitle")
                StrLocation = clsAdmin.GetDataReaderStringValue(local_dr, "StrLocation")
                StrSupervisor = clsAdmin.GetDataReaderStringValue(local_dr, "Supervisor")
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            clsDB.Dispose()
        End Try
    End Function
    Public Function RetrieveEmployeeID(ByVal Login As String) As Integer
        Try
            clsDB = New SQLAccess(StrConnectionString)
            clsDB.AddStringInputParameter("@StrLogin", Login)
            If clsDB.ExecuteSingleNumberValueSP("usp_RetrieveEmployeeID") Then
                Return clsDB.NumberValue
            Else
                Return 0
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            clsDB.Dispose()
        End Try
    End Function
    Public Function AddReview(ByVal EmployeeID As Integer) As Integer
        Try
            clsDB = New SQLAccess(StrConnectionString)
            clsDB.AddNumberInputParameter("@IntEmployeeID", EmployeeID)
            clsDB.AddStringInputParameter("@StrSummaryOfActivities", StrSummaryOfActivities)
            clsDB.AddStringInputParameter("@StrCareerInterests", StrCareerInterests)
            If clsDB.ExecuteSingleNumberValueSP("usp_AddReview") Then
                Return clsDB.NumberValue
            Else
                Return 0
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            clsDB.Dispose()
        End Try
    End Function
    Public Function AddDepartment(ByVal Department As String) As Boolean
        Try
            clsDB = New SQLAccess(StrConnectionString)
            clsDB.AddStringInputParameter("@StrDepartment", Department)
            Return clsDB.ExecuteInsertUpdateSP("usp_AddDepartment")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            clsDB.Dispose()
        End Try
    End Function
    Public Function AddEmployee() As Boolean
        Try
            clsDB = New SQLAccess(StrConnectionString)
            clsDB.AddStringInputParameter("@StrFirstName", StrFirstName)
            clsDB.AddStringInputParameter("@StrLastName", StrLastName)
            clsDB.AddStringInputParameter("@StrLogin", StrLogin)
            clsDB.AddStringInputParameter("@StrPassword", StrPassword)
            clsDB.AddNumberInputParameter("@IntLocationID", IntLocationID)
            clsDB.AddStringInputParameter("@StrTitle", StrTitle)
            clsDB.AddNumberInputParameter("@IntDepartmentID", IntDepartmentID)
            clsDB.AddNumberInputParameter("@IntSupervisorID", IntSupervisorID)
            clsDB.AddBooleanInputParameter("@blnHR", blnHR)
            Return clsDB.ExecuteInsertUpdateSP("usp_AddEmployee")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            clsDB.Dispose()
        End Try
    End Function
    Public Function AddGoal(ByVal ReviewID As Integer) As Boolean
        Try
            clsDB = New SQLAccess(StrConnectionString)
            clsDB.AddNumberInputParameter("@IntReviewID", ReviewID)
            clsDB.AddStringInputParameter("@StrGoal", StrGoal)
            clsDB.AddStringInputParameter("@StrActionPlan", StrActionPlan)
            clsDB.AddStringInputParameter("@StrTargetCompletionDate", StrTargetCompletionDate)
            clsDB.AddStringInputParameter("@StrPriority", StrPriority)
            Return clsDB.ExecuteInsertUpdateSP("usp_AddGoal")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            clsDB.Dispose()
        End Try
    End Function
    Public Function AddLocation(ByVal Location As String) As Boolean
        Try
            clsDB = New SQLAccess(StrConnectionString)
            clsDB.AddStringInputParameter("@StrLocation", Location)
            Return clsDB.ExecuteInsertUpdateSP("usp_Addlocation")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            clsDB.Dispose()
        End Try
    End Function
    Public Function AddQuestion(ByVal Question As String, ByVal Order As Integer) As Boolean
        Try
            clsDB = New SQLAccess(StrConnectionString)
            clsDB.AddStringInputParameter("@StrQuestion", Question)
            clsDB.AddNumberInputParameter("@IntOrder", Order)
            Return clsDB.ExecuteInsertUpdateSP("usp_AddQuestion")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            clsDB.Dispose()
        End Try
    End Function
    Public Function DeleteDepartment(ByVal DepartmentID As Integer) As Boolean
        Try
            clsDB = New SQLAccess(StrConnectionString)
            clsDB.AddNumberInputParameter("@IntDepartmentID", DepartmentID)
            Return clsDB.ExecuteInsertUpdateSP("usp_DeleteDepartment")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            clsDB.Dispose()
        End Try
    End Function
    Public Function DeleteEmployee(ByVal EmployeeID As Integer) As Boolean
        Try
            clsDB = New SQLAccess(StrConnectionString)
            clsDB.AddNumberInputParameter("@IntEmployeeID", EmployeeID)
            Return clsDB.ExecuteInsertUpdateSP("usp_DeleteEmployee")

        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            clsDB.Dispose()
        End Try
    End Function
    Public Function DeleteLocation(ByVal LocationID As Integer) As Boolean
        Try
            clsDB = New SQLAccess(StrConnectionString)
            clsDB.AddNumberInputParameter("@IntLocationId", LocationID)
            Return clsDB.ExecuteInsertUpdateSP("usp_DeleteLocation")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            clsDB.Dispose()
        End Try
    End Function
    Public Function DeleteQuestion(ByVal QuestionID As Integer) As Boolean
        Try
            clsDB = New SQLAccess(StrConnectionString)
            clsDB.AddNumberInputParameter("@IntQuestionId", QuestionID)
            Return clsDB.ExecuteInsertUpdateSP("usp_DeleteQuestion")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            clsDB.Dispose()
        End Try
    End Function
    Public Function RetrieveDepartmentList() As Data.DataSet
        Try
            clsDB = New SQLAccess(StrConnectionString)
            Return clsDB.RetrieveDataSetSP("usp_RetrieveDepartmentList")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            clsDB.Dispose()
        End Try
    End Function
    Public Function RetrieveEmployeeListForLocation(ByVal LocationID As Integer) As Data.DataSet
        Try
            clsDB = New SQLAccess(StrConnectionString)
            clsDB.AddNumberInputParameter("@IntLocationID", LocationID)
            Return clsDB.RetrieveDataSetSP("usp_RetrieveEmployeeListForLocation")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            clsDB.Dispose()
        End Try
    End Function
    Public Function RetrieveEmployeesForSupervisor(ByVal SupervisorID As Integer) As Data.DataSet
        Try
            clsDB = New SQLAccess(StrConnectionString)
            clsDB.AddNumberInputParameter("@IntSupervisorD", SupervisorID)
            Return clsDB.RetrieveDataSetSP("usp_RetrieveEmployeesForSupervisor")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            clsDB.Dispose()
        End Try
    End Function
    Public Function RetrieveGoals(ByVal ReviewID As Integer) As Data.DataSet
        Try
            clsDB = New SQLAccess(StrConnectionString)
            clsDB.AddNumberInputParameter("@IntReviewID", ReviewID)
            Return clsDB.RetrieveDataSetSP("usp_RetrieveGoalsForReview")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            clsDB.Dispose()
        End Try
    End Function
    Public Function RetrieveLocationList() As Data.DataSet
        Try
            clsDB = New SQLAccess(StrConnectionString)
            Return clsDB.RetrieveDataSetSP("usp_RetrieveLocationList")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            clsDB.Dispose()
        End Try
    End Function
    Public Function RetrieveQuestionList() As Data.DataSet
        Try
            clsDB = New SQLAccess(StrConnectionString)
            Return clsDB.RetrieveDataSetSP("usp_RetrieveQuestionList")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            clsDB.Dispose()
        End Try
    End Function
    Public Function RetrieveReviewQuestions(ByVal ReviewId As Integer) As Data.DataSet
        Try
            clsDB = New SQLAccess(StrConnectionString)
            clsDB.AddNumberInputParameter("@IntReviewID", ReviewId)
            Return clsDB.RetrieveDataSetSP("usp_RetrieveReviewQuestions")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            clsDB.Dispose()
        End Try
    End Function
    Public Function RetrieveReviewsForEmployee(ByVal EmployeeID As Integer) As Data.DataSet
        Try
            clsDB = New SQLAccess(StrConnectionString)
            clsDB.AddNumberInputParameter("@IntEmployeeID", EmployeeID)
            Return clsDB.RetrieveDataSetSP("usp_RetrieveReviewsForEmployee")

        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            clsDB.Dispose()
        End Try
    End Function
    Public Function UpdateDepartment(ByVal DepartmentID As Integer, ByVal Department As String, ByVal Active As Boolean) As Boolean
        Try
            clsDB = New SQLAccess(StrConnectionString)
            clsDB.AddNumberInputParameter("@IntDepartmentID", DepartmentID)
            clsDB.AddStringInputParameter("@StrDepartment", Department)
            clsDB.AddBooleanInputParameter("@blnActive", Active)
            Return clsDB.ExecuteInsertUpdateSP("usp_UpdateDepartment")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            clsDB.Dispose()
        End Try
    End Function
    Public Function UpdateLocation(ByVal LocationID As Integer, ByVal Location As String, ByVal Active As Boolean) As Boolean
        Try
            clsDB = New SQLAccess(StrConnectionString)
            clsDB.AddNumberInputParameter("@IntLocationID", LocationID)
            clsDB.AddStringInputParameter("@StrLocation", Location)
            clsDB.AddBooleanInputParameter("@blnActive", Active)
            Return clsDB.ExecuteInsertUpdateSP("usp_UpdateLocation")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            clsDB.Dispose()
        End Try
    End Function
    Public Function UpdateEmployee(ByVal EmployeeID As Integer, ByVal Active As Boolean) As Boolean
        Try
            clsDB = New SQLAccess(StrConnectionString)
            clsDB.AddNumberInputParameter("@IntEmployeeID", EmployeeID)
            clsDB.AddStringInputParameter("@StrFirstName", StrFirstName)
            clsDB.AddStringInputParameter("@StrLastName", StrLastName)
            clsDB.AddStringInputParameter("@StrLogin", StrLogin)
            clsDB.AddStringInputParameter("@StrPassword", StrPassword)
            clsDB.AddNumberInputParameter("@IntLocationID", IntLocationID)
            clsDB.AddStringInputParameter("@StrTitle", StrTitle)
            clsDB.AddNumberInputParameter("@IntDepartmentID", IntDepartmentID)
            clsDB.AddNumberInputParameter("@IntSupervisorID", IntSupervisorID)
            clsDB.AddBooleanInputParameter("@blnHR", blnHR)
            clsDB.AddBooleanInputParameter("@blnActive", Active)
            Return clsDB.ExecuteInsertUpdateSP("usp_UpdateEmployee")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            clsDB.Dispose()
        End Try
    End Function
    Public Function UpdateGoal(ByVal GoalID As Integer) As Boolean
        Try
            clsDB = New SQLAccess(StrConnectionString)
            clsDB.AddNumberInputParameter("@IntGoalID", GoalID)
            clsDB.AddStringInputParameter("@StrGoal", StrGoal)
            clsDB.AddStringInputParameter("@StrActionPlan", StrActionPlan)
            clsDB.AddStringInputParameter("@StrTargetCompletionDate", StrTargetCompletionDate)
            clsDB.AddStringInputParameter("@StrPriority", StrPriority)
            Return clsDB.ExecuteInsertUpdateSP("usp_UpdateGoal")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            clsDB.Dispose()
        End Try
    End Function
    Public Function UpdateQuestion(ByVal QuestionID As Integer, ByVal Active As Boolean) As Boolean
        Try
            clsDB = New SQLAccess(StrConnectionString)
            clsDB.AddNumberInputParameter("@IntQuestionID", QuestionID)
            clsDB.AddStringInputParameter("@StrQuestion", StrQuestion)
            clsDB.AddNumberInputParameter("@IntOrder", IntOrder)
            clsDB.AddBooleanInputParameter("@blnActive", Active)
            Return clsDB.ExecuteInsertUpdateSP("usp_UpdateQuestion")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            clsDB.Dispose()
        End Try
    End Function
    Public Function UpdateReview(ByVal ReviewID As Integer) As Boolean
        Try
            clsDB = New SQLAccess(StrConnectionString)
            clsDB.AddNumberInputParameter("@IntReviewID", ReviewID)
            clsDB.AddStringInputParameter("@StrSummaryOfActivities", StrSummaryOfActivities)
            clsDB.AddStringInputParameter("@StrCareerInterests", StrCareerInterests)
            clsDB.AddStringInputParameter("@StrEmployeeComments", StrEmployeeComments)
            Return clsDB.ExecuteInsertUpdateSP("usp_UpdateReview")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            clsDB.Dispose()
        End Try
    End Function
    Public Function UpdateReviewQuestion(ByVal ReviewID As Integer, ByVal QuestionID As Integer) As Boolean
        Try
            clsDB = New SQLAccess(StrConnectionString)
            clsDB.AddNumberInputParameter("@IntReviewID", ReviewID)
            clsDB.AddNumberInputParameter("@IntQuestionID", QuestionID)
            clsDB.AddNumberInputParameter("@IntResponse", IntResponse)
            clsDB.AddStringInputParameter("@StrComments", StrComments)
            Return clsDB.ExecuteInsertUpdateSP("usp_UpdateReviewQuestion")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            clsDB.Dispose()
        End Try
    End Function
    Public Sub New()
        StrConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("local").ToString

    End Sub
End Class
