USE [OT_ERP_CAN_TRADE]
GO

/****** Object:  Table [dbo].[tblPO_AccountsPayableAdjustment]    Script Date: 10/14/2019 2:49:40 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblPO_AccountsPayableAdjustments](
	[Voucher_No] [char](10) NOT NULL,
	[Voucher_Date] [datetime]  NULL,
	[Vendor_FK] [char](10) NULL,
	[Transact_ID] [char](2) NULL,
	[Record_Code] [char](2) NULL,
	[PO_No] [char](15) NULL,
	[Invoice_No] [char](10)  NULL,
	[Invoice_Date] [datetime]  NULL,
	[Debit_Account] [char](7)  NULL,
	[Credit_Account] [char](7)  NULL,
	[Description] [nvarchar](150) NULL,
	[Amount] [money] NULL,	
	[Authorize_By] [int] NULL,
	
 CONSTRAINT [pk_PO_AccountsPayableAdjusment] PRIMARY KEY CLUSTERED 
(
	[Voucher_No] ASC
)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO




