SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEmployees](
	[IntEmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[StrFirstName] [varchar](50) NULL,
	[StrLastName] [varchar](50) NULL,
	[StrLogin] [varchar](20) NULL,
	[StrPassword] [varchar](20) NULL,
	[IntLocationID] [int] NULL,
	[StrTitle] [varchar](255) NULL,
	[IntDepartmentID] [int] NULL,
	[IntSupervisorID] [int] NULL,
	[blnHR] [bit] NULL CONSTRAINT [DF_tblEmployees_blnHR]  DEFAULT ((0)),
	[blnActive] [bit] NULL CONSTRAINT [DF_tblEmployees_blnActive]  DEFAULT ((1)),
 CONSTRAINT [PK_tblEmployees] PRIMARY KEY CLUSTERED 
(
	[IntEmployeeID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLocation](
	[IntLocationID] [int] IDENTITY(1,1) NOT NULL,
	[StrLocation] [varchar](50) NULL,
	[blnActive] [bit] NULL CONSTRAINT [DF_tblLocation_blnActive]  DEFAULT ((1)),
 CONSTRAINT [PK_tblLocation] PRIMARY KEY CLUSTERED 
(
	[IntLocationID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDepartment](
	[IntDepartmentID] [int] IDENTITY(1,1) NOT NULL,
	[StrDepartment] [varchar](50) NULL,
	[blnActive] [bit] NULL CONSTRAINT [DF_tblDepartment_blnActive]  DEFAULT ((1)),
 CONSTRAINT [PK_tblDepartment] PRIMARY KEY CLUSTERED 
(
	[IntDepartmentID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblReview](
	[IntReviewID] [int] IDENTITY(1,1) NOT NULL,
	[IntEmployeeID] [int] NULL,
	[IntSupervisorID] [int] NULL,
	[DteDateCreated] [datetime] NULL CONSTRAINT [DF_tblReview_DteDateCreated]  DEFAULT (getdate()),
	[StrSummaryOfActivities] [text] NULL,
	[StrCareerInterests] [text] NULL,
	[StrEmployeeComments] [text] NULL,
	[DteEmployeeSignatureDate] [datetime] NULL,
	[DteSupervisorSignatureDate] [datetime] NULL CONSTRAINT [DF_tblReview_DteSupervisorSignatureDate]  DEFAULT ((0)),
	[blnComplete] [bit] NULL,
	[dteDateCompleted] [datetime] NULL,
	[IntInstanceID] [int] NULL,
 CONSTRAINT [PK_tblReview] PRIMARY KEY CLUSTERED 
(
	[IntReviewID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblReviewGoal](
	[IntGoalID] [int] IDENTITY(1,1) NOT NULL,
	[IntReviewID] [int] NULL,
	[StrGoal] [text] NULL,
	[StrActionPlan] [text] NULL,
	[StrTargetCompletionDate] [varchar](50) NULL,
	[StrPriority] [varchar](50) NULL,
 CONSTRAINT [PK_tblReviewGoal] PRIMARY KEY CLUSTERED 
(
	[IntGoalID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblReviewQuestion](
	[IntReviewID] [int] NOT NULL,
	[IntQuestionID] [int] NOT NULL,
	[blnResponse1] [bit] NULL CONSTRAINT [DF_tblReviewQuestion_IntResponse1]  DEFAULT ((0)),
	[blnResponse2] [bit] NULL CONSTRAINT [DF_tblReviewQuestion_IntResponse2]  DEFAULT ((0)),
	[blnResponse3] [bit] NULL CONSTRAINT [DF_tblReviewQuestion_IntResponse3]  DEFAULT ((0)),
	[blnResponse4] [bit] NULL CONSTRAINT [DF_tblReviewQuestion_IntResponse4]  DEFAULT ((0)),
	[StrComments] [text] NULL,
 CONSTRAINT [PK_tblReviewQuestion] PRIMARY KEY CLUSTERED 
(
	[IntReviewID] ASC,
	[IntQuestionID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblQuestions](
	[IntQuestionID] [int] IDENTITY(1,1) NOT NULL,
	[StrQuestion] [text] NULL,
	[IntOrder] [int] NULL,
	[blnActive] [bit] NULL CONSTRAINT [DF_tblQuestions_blnActive]  DEFAULT ((1)),
 CONSTRAINT [PK_tblQuestions] PRIMARY KEY CLUSTERED 
(
	[IntQuestionID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

