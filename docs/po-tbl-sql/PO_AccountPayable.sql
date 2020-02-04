USE [OT_ERP_CAN_TRADE]
GO

/****** Object:  Table [dbo].[tblPO_AccountPayable]    Script Date: 10/14/2019 2:49:40 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblPO_AccountPayable](
	[AP_No] [char](10) NOT NULL,
	[Vendor_FK] [char](10) NULL,
	[Transact_No] [char](15) NULL,
	[Record_Code] [char](2) NULL,
	[PO_No] [char](15) NULL,
	[Transact_Date] [datetime]  NULL,
	[Description] [nvarchar](150) NULL,
	[Amount] [money] NULL,	
	[Department_FK] [char](5) NULL,
	
 CONSTRAINT [pk_PO_AccountPayable] PRIMARY KEY CLUSTERED 
(
	[AP_No] ASC
)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO




