USE [Purchasing]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPurchaseOrders](
	[IntPurchaseOrderID] [int] IDENTITY(1,1) NOT NULL,
	[StrPurchaseOrderNumber] [varchar](50) NULL,
	[StrPartNumber] [varchar](50) NULL,
	[dtePurchaseDate] [smalldatetime] NULL,
	[dteExpectedDate] [smalldatetime] NULL,
	[StrBuyerLogin] [varchar](50) NULL,
	[StrBuyerName] [varchar](50) NULL,
	[IntQuantityOrdered] [int] NULL,
	[blnReceived] [bit] NULL CONSTRAINT [DF_tblPurchaseOrders_blnReceived]  DEFAULT ((0)),
	[IntQuantityReceived] [int] NULL,
	[dteReceivedDate] [smalldatetime] NULL,
 CONSTRAINT [PK_tblPurchaseOrders] PRIMARY KEY CLUSTERED 
(
	[IntPurchaseOrderID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

