USE [OT_ERP_CAN_TRADE]
GO

/****** Object:  Table [dbo].[tblPO_APInvoicesDetail]    Script Date: 10/14/2019 3:20:37 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblPO_APInvoicesDetail](
	[Vendor_ID] [char](10) NOT NULL,
	[Invoice_No] [char](15) NOT NULL,
	[Invoice_Date] [datetime] NULL,
	[Inventory_FK] [int] NULL,
	[Unit_FK] [int] NULL,
	[Unit_Price] [money]  NULL,
	[Qty_Ordered] [float] NULL,
	
 CONSTRAINT [pk_PO_APInvoicesDetail] PRIMARY KEY CLUSTERED 
(
	[Vendor_ID] ASC,
	[Invoice_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


