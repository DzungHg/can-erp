USE [OT_ERP_CAN_TRADE]
GO

/****** Object:  Table [dbo].[tblPO_APInvoice]    Script Date: 10/14/2019 3:13:15 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblPO_APInvoice](
	[Vendor_ID] [char](10) NOT NULL,
	[Invoice_No] [char](15) NOT NULL,
	[Invoice_Date] [datetime] NULL,
	[PO_ID] [char](15) NULL,
	[PO_Date] [datetime] NULL,
	[Description] [nvarchar](150) NULL,
	[Invoice_Amount] [money] NULL,
	[Discount_Amount] [money] NULL,
	[Due_Date] [datetime] NULL,
	[Paid] [bit] NULL,
 CONSTRAINT [pk_PO_APInvoice] PRIMARY KEY CLUSTERED 
(
	[Vendor_ID] ASC,
	[Invoice_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


