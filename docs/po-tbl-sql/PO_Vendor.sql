USE [OT_ERP_CAN_TRADE]
GO

/****** Object:  Table [dbo].[tblPO_Vendor]    Script Date: 10/14/2019 2:20:42 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblPO_Vendor](
	
	[Vendor_ID] [char](10) NOT NULL,
	[LastName] [nvarchar](50) NULL,
	[FirstName] [nvarchar](50) NULL,
	[VendorAdressBook_FK] [int] NULL,
	[Performing_Rating] [nvarchar](10) NULL,
	[AP_Balance] [money] NULL,
	[Outstand_Inv_Amt] [money] NULL,
	[Outstand_Credit] [money] NULL,
	[Last_Purchase_Date] [datetime] NULL,
	[Last_Payment_Date] [datetime] NULL,
	[Current_MTD_Returns] [money] NULL,
	[MTD_Purchase] [money] NULL,
	[YTD_Purchase] [money] NULL,
	[LYR_Purchase] [money] NULL,	
	[Notes] [ntext] NULL,
	[Inactive] [bit] NULL,
 CONSTRAINT [pk_PO_vendor] PRIMARY KEY CLUSTERED 
(
	[Vendor_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

