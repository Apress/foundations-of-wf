SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_UpdateReviewQuestion] 
	@IntReviewID int,
	@IntQuestionID int,
	@IntResponse int,
	@StrComments text
AS
BEGIN
	update tblreviewquestion
	set IntResponse=@IntResponse,
	strComments = @Strcomments
	where IntReviewId = @IntReviewId
	and intQuestionId = @IntQuestionID
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_UpdateCriteriaComment]
	@IntReviewID int,
	@IntQuestionID int,
	@StrComments text
AS
BEGIN
	update tblReviewQuestion
	set strcomments = @StrComments
	where intreviewid=@intreviewid
	and intquestionid = @intquestionid
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_RetrieveEmployeeID] 
	@StrLogin varchar(20)
AS
BEGIN
	select intemployeeid
	from tblemployees
	where strlogin = @strlogin
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_RetrieveEmployeeInformation] 
	@IntEmployeeID int
AS
BEGIN
	SELECT     tblEmployees.IntEmployeeID, tblEmployees.StrFirstName, tblEmployees.StrLastName, tblEmployees.StrLogin, tblEmployees.StrPassword, 
                      tblEmployees.IntLocationID, tblLocation.StrLocation, tblEmployees.StrTitle, tblEmployees.IntDepartmentID, tblDepartment.StrDepartment, 
                      tblEmployees.IntSupervisorID, sup.StrFirstName + ' ' + sup.StrLastName AS Supervisor, tblEmployees.blnHR, tblEmployees.blnActive
FROM         tblEmployees LEFT OUTER JOIN
                      tblLocation ON tblEmployees.IntLocationID = tblLocation.IntLocationID LEFT OUTER JOIN
                      tblEmployees AS sup ON tblEmployees.IntSupervisorID = sup.IntEmployeeID LEFT OUTER JOIN
                      tblDepartment ON tblEmployees.IntDepartmentID = tblDepartment.IntDepartmentID
	where tblemployees.intemployeeid=@intemployeeid
END


GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_AddReview]
	@IntEmployeeID int,
	@StrSummaryOfActivities text,
	@StrCareerInterests text
AS
BEGIN
	Declare @IntSupervisorID int

	select @IntSupervisorId = IntSupervisorID
	from tblemployees
	where intemployeeid = @IntEmployeeID

	insert into tblReview(IntEmployeeID,IntSupervisorID,
	StrSummaryOfActivities,StrCareerInterests)
	values (@IntEmployeeID,@IntSupervisorID,
	@StrSummaryOfActivities,@StrCareerInterests)

	declare @NextID int
	set @NextID=@@Identity

	insert into tblReviewQuestion(IntReviewID,
	IntQuestionID)
	select @NextID,IntQuestionID
	from tblQuestions
	where blnactive=1
	order by intorder
	
	select @NextID
END





GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_RetrieveReviewsForEmployee]
	@IntEmployeeID int
AS
BEGIN
SELECT     tblreview.intreviewid,Supervisor.StrFirstName + Supervisor.StrLastName AS SupervisorName, tblReview.DteDateCreated, 
tblReview.dteDateCompleted
FROM         tblEmployees AS Supervisor RIGHT OUTER JOIN
                      tblReview ON Supervisor.IntEmployeeID = tblReview.IntSupervisorID
WHERE     (tblReview.IntEmployeeID = @IntEmployeeID)
END



GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_AddEmployee]
	@StrFirstName varchar(50),
	@StrLastName varchar(50),
	@StrLogin varchar(20),
	@StrPassword varchar(20),
	@IntLocationID int,
	@StrTitle varchar(255),
	@IntDepartmentID int,
	@IntSupervisorID int,
	@blnHR bit
AS
BEGIN
	Insert into tblemployees(StrFirstName,StrLastName,
	StrLogin,StrPassword,IntLocationID,StrTitle,
	IntDepartmentID,IntSupervisorID,blnHR)
	values(@StrFirstName,@StrLastName,@StrLogin,
	@StrPassword,@IntLocationID,@StrTitle,
	@IntDepartmentID,@IntSupervisorID,@blnHR)
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_UpdateEmployee]
	@IntEmployeeID int,
	@StrFirstName varchar(50),
	@StrLastName varchar(50),
	@StrLogin varchar(20),
	@StrPassword varchar(20),
	@IntLocationID int,
	@StrTitle varchar(255),
	@IntDepartmentID int,
	@IntSupervisorID int,
	@blnHR bit,
	@blnActive bit
AS
BEGIN
	update tblemployees
	set StrFirstName = @StrFirstName,
	StrLastName = @StrLastName,
	StrLogin = @StrLogin,
	StrPassword = @StrPassword,
	IntLocationID = @IntLocationID,
	StrTitle = @StrTitle,
	IntDepartmentID = @IntDepartmentID,
	IntSupervisorID = @IntSupervisorID,
	blnHR = @blnHR,
	blnActive = @blnActive
	where IntEmployeeID = @IntEmployeeID
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_DeleteEmployee] 
	@IntEmployeeID int
AS
BEGIN
	update tblEmployees
	set blnActive=0 
	where intemployeeid = @IntEmployeeID
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_RetrieveEmployeeListForLocation]
	@IntLocationId int
AS
BEGIN
	Select StrFirstName, StrLastName
	from tblEmployees
	where IntLocationID = @IntLocationID
	
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_RetrieveEmployeesForSupervisor]
	@IntSupervisorID int
AS
BEGIN
	select StrFirstName,StrLastName
	from tblEmployees
	where IntSupervisorID = @IntSupervisorID
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_AddLocation]
	@StrLocation varchar(50)
AS
BEGIN
	insert into tbllocation(StrLocation)
	values(@StrLocation)
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_UpdateLocation]
	@IntLocationId int,
	@StrLocation varchar(50),
	@blnActive bit
AS
BEGIN
	Update tblLocation
	set StrLocation = @StrLocation,
	blnActive=@blnActive
	where IntLocationID = @IntLocationID
END


GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_RetrieveLocationList] 
	
AS
BEGIN
	select IntLocationID,StrLocation 
	from tbllocation
	where blnactive=1

END



GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_DeleteLocation] 
	@IntLocationID int
AS
BEGIN
	update tbllocation
	set blnactive=0
	where intlocationid = @intlocationid
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_RetrieveFullLocationList] 
	
AS
BEGIN
	select IntLocationID,StrLocation,blnactive
	from tbllocation
	

END




GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_DeleteDepartment]
	@IntDepartmentID int
AS
BEGIN
	update tbldepartment
	set blnactive=0
	where intdepartmentid = @intdepartmentid
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_RetrieveFullDepartmentList] 
AS
BEGIN
	select IntDepartmentID,StrDepartment,blnactive
	from tblDepartment


END



GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_AddDepartment]
	@StrDepartment varchar(50)
AS
BEGIN
	insert into tbldepartment(StrDepartment)
	values (@StrDepartment)
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_UpdateDepartment] 
	@IntDepartmentID int,
	@StrDepartment varchar(50),
	@blnActive bit
AS
BEGIN
	update tbldepartment
	set StrDepartment = @StrDepartment,
	blnActive=@blnActive
	where intdepartmentid = @intdepartmentid
END


GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_RetrieveDepartmentList] 
AS
BEGIN
	select IntDepartmentID,StrDepartment,blnactive
	from tblDepartment
	where blnactive=1

END



GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_UpdateReview] 
	@IntReviewID int,
	@StrSummaryOfActivities text,
	@StrCareerInterests text,
	@StrEmployeeComments text
AS
BEGIN
	update tblreview
	set StrSummaryofActivities = @StrSummaryOfActivities,
	StrCareerInterests = @StrCareerInterests,
	StrEmployeeComments = @StrEmployeeComments
	where IntReviewID = @IntReviewID
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_CompleteReview] 
	@IntReviewID int
AS
BEGIN
	update tblreview
	set blncomplete=1,
	dtedatecompleted=getdate()
	where intreviewid = @intreviewid
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_EmployeeSignature]
	@IntReviewId int
AS
BEGIN
	update tblReview
	set dteEmployeeSignatureDate = getdate()
	where intreviewid = @intreviewid
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_SupervisorSignature]
	@IntReviewID int
AS
BEGIN
	update tblreview
	set dtesupervisorsignaturedate=getdate()
	where intreviewid = @intreviewid
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_RetrieveReview]
	@IntReviewID int
AS
BEGIN
	select IntReviewID,IntEmployeeID,
	intsupervisorID,dtedatecreated,
	strsummaryofactivities,strcareerinterests,
	stremployeecomments,dteemployeesignaturedate,
	dtesupervisorsignaturedate,
	blncomplete,dtedatecompleted
	from tblreview
	where intreviewid=@intreviewid
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_AddGoal] 
	@IntReviewID int,
	@StrGoal text,
	@StrActionPlan text,
	@StrTargetCompletionDate varchar(50),
	@StrPriority varchar(50)
AS
BEGIN
	insert into tblReviewGoal(IntReviewID,
	StrGoal,StrActionPlan,StrTargetCompletionDate,
	StrPriority)
	values(@IntReviewID,@StrGoal,@StrActionPlan,
	@StrTargetCompletionDate,@StrPriority)
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_UpdateGoal] 
	@IntGoalID int,
	@StrGoal text,
	@StrActionPlan text,
	@StrTargetCompletionDate varchar(50),
	@StrPriority varchar(50)
AS
BEGIN
	update tblReviewGoal
	set StrGoal = @StrGoal,
	StrActionPlan = @StrActionPlan,
	StrTargetCompletionDate = @StrTargetCompletionDate,
	StrPriority = @StrPriority
	where IntGoalID =@intGoalID
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_RetrieveGoalsForReview]
	@IntReviewID int
AS
BEGIN
	Select IntGoalID,StrGoal,StrActionPlan,StrTargetCompletionDate,
	StrPriority
	from tblReviewGoal
	where IntReviewID = @IntReviewID
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_RetrieveReviewQuestions]
	@IntReviewID int
AS
BEGIN
	SELECT     tblReviewQuestion.IntReviewID, tblReviewQuestion.IntQuestionID, tblReviewQuestion.blnResponse1, tblReviewQuestion.blnResponse2, 
                      tblReviewQuestion.blnResponse3, tblReviewQuestion.blnResponse4, tblReviewQuestion.StrComments, tblQuestions.StrQuestion
FROM         tblReviewQuestion INNER JOIN
                      tblQuestions ON tblReviewQuestion.IntQuestionID = tblQuestions.IntQuestionID
WHERE     (tblReviewQuestion.IntReviewID = @Intreviewid)
ORDER BY tblReviewQuestion.IntQuestionID
END




GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_RetrieveFullQuestionList] 
AS
BEGIN
	select IntQuestionId,StrQuestion,blnactive,intorder
	from tblQuestions	
	order by IntOrder
END



GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_DeleteQuestion]
	@IntQuestionID int
AS
BEGIN
	update tblquestions
	set blnactive=0
	where intquestionid = @intquestionid
END


GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_AddQuestion]
	@StrQuestion text,
	@IntOrder int
AS
BEGIN
	insert into tblQuestions(StrQuestion,IntOrder)
	values(@StrQuestion,@IntOrder)
	
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_UpdateQuestion] 
	@IntQuestionID int,
	@StrQuestion text,
	@IntOrder int,
	@blnActive bit
AS
BEGIN
	update tblQuestions
	set StrQuestion = @StrQuestion,
	IntOrder = @IntOrder,
	blnActive = @blnActive
	where IntQuestionId = @IntQuestionID
END


GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_RetrieveQuestionList] 
AS
BEGIN
	select IntQuestionId,StrQuestion
	from tblQuestions
	where blnactive=1
	order by IntOrder
END


