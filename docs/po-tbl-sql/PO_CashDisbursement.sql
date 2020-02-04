USE [OT_ERP_CAN_TRADE]
GO

/****** Object:  Table [dbo].[tblPO_CashDisbursement]    Script Date: 10/14/2019 4:13:30 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblPO_CashDisbursement](
	[PO_CashDisb_No] [char](10) NOT NULL,
	[PO_CashDisb_Date] [datetime] NULL,
	[Customer_FK] [int] NULL,
	[Description] [nvarchar](150) NULL,
	[Disbursement_Type] [char](2) NOT NULL,	
	[Gross_Invt_Amt] [money] NULL,
	[Discount_Invt_Amt] [money] NULL,
	[Check_No] [char](15) NOT NULL,
	[Check_Date] [datetime] NULL,
	[Check_Amount] [money] NULL,
	[DebiAccount] [char](7) NULL,
	[CreditAccount] [char](7) NULL,
	[Payment] [bit] NULL,

 CONSTRAINT [pk_PO_CashDebursement] PRIMARY KEY CLUSTERED 
(
	[PO_CashDisb_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


