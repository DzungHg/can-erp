USE [OT_ERP_CAN_TRADE]
GO

/****** Object:  Table [dbo].[tblPO_RecReport]    Script Date: 10/14/2019 4:00:23 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblPO_RecReport](
	[RR_No] [char](15) NOT NULL,
	[RRDate] [datetime] NULL,
	[CreatedBy_FK] [int] NULL,
	[PO_ID] [char](15) NULL,
	[POStatus_FK] [int] NULL,
	[PODate] [datetime] NULL,
	[Vendor_FK] [char](10) NULL,
	[Description] [nvarchar](150) NULL,
	[Invoice_No] [char](15),
	[Invoice_Date] [datetime] NULL,
	[Ship_No] [char](6) NULL,
	[Ship_Date] [datetime] NULL,
	[Receiver_FK] [int] NULL,
	[BillOf_Loading_No] [char](7) NULL,
	[PO_Amount] [money] NULL,
	[Inactive] [bit] NULL,
	[Warhoused] [bit] NULL,

 CONSTRAINT [pk_PO_RecReport] PRIMARY KEY CLUSTERED 
(
	[RR_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


