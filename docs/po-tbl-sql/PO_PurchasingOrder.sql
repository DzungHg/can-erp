USE [OT_ERP_CAN_TRADE]
GO

/****** Object:  Table [dbo].[tblPO_PurchaseOrder]    Script Date: 10/14/2019 3:25:46 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblPO_PurchaseOrder](
	[PO_ID] [char](15) NOT NULL,
	[PODate] [datetime] NULL,
	[CreatedBy_FK] [int] NULL,
	[POStatus_FK] [int] NULL,
	[Vendor_FK] [char](10) NULL,
	[Description] [nvarchar](150) NULL,
	[Incoterm_ID] [char](3) NULL,	
	[ShipVia_FK] [int] NULL,
	[PaymentTerm_FK] [int] NULL,
	[PaymentType_FK] [int] NULL,
	[Buyer_FK] [int] NULL,		
	[TaxYN] [bit] NULL,
	[TaxtRate] [float] NULL,
	[Department_FK] [char](5) NULL,
	[PO_Amount] [money] NULL,
 CONSTRAINT [pk_PO_PurchasingOrder] PRIMARY KEY CLUSTERED 
(
	[PO_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_PADDING OFF
GO

