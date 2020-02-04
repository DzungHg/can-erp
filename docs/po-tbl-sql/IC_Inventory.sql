USE [OT_ERP_CAN_TRADE]
GO

/****** Object:  Table [dbo].[tblSO_SalesOrder]    Script Date: 10/13/2019 2:03:01 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblIC_Inventory](
	[Inventory_SEQ] [int] IDENTITY(1,1) NOT NULL,
	[Warehouse_FK] [char](15) NOT NULL,
	[Category_FK] [char](15) NOT NULL,
	[Item_SK] [int] NULL,
	[FixAsset] [bit] NULL,
	[Unit_FK] [int] NULL,
	[QuantityPerUnit] [float] NULL,
	[Location] [nvarchar](100) NULL,
	[Taxable] [bit] NULL,
	[TaxRate] [float] NULL,
	[ROP] [float] NULL,
	[EOQ] [float] NULL,
	[UnitPrice] [money] NULL,
	[GL_Asset] [char](7) NULL,
	[GL_COGS] [char](7) NULL,
	[GL_Sales] [char](7) NULL,
	[GL_NonTaxSales] [char](7) NULL,
	[LastSaleDate] [datetime] NULL,
	[LastPODate] [datetime] NULL,
	[LastReceiptDate] [datetime] NULL,
	[Leadtime] as [LastReceiptDate]-[LastPODate],
	[LastCost] [money] NULL,
	[EverageCost] [money] NULL,
	[Qty_On_Order] [float] NULL,
	[Qty_In_Stock] [float] NULL,
	[Qty_On_Hand] [float] NULL,
	[Qty_Allocated] [float] NULL,
	[TotalInventory] as [EverageCost]*([Qty_On_Hand]+[Qty_Allocated]),
	[MTD_Qty_Sold] [float] NULL,
	[MTD_Gross_Sales] [money] NULL,
	[MTD_COGS] [money] NULL,
	[YTD_Qty_Sold] [float] NULL,
	[YTD_Gross_Sales] [money] NULL,
	[YTD_COGS] [money] NULL,
	[YTD_Qty_Returned] [float] NULL,
	[LTD_Qty_Sold] [float] NULL,
	[LTD_Gross_Sales] [money] NULL,
	[LTD_COGS] [money] NULL,
	[NetGrossRate] [float] NULL,
	[VendorNumber_FK] [int] NULL,
	[LastUpdatedDate] [datetime] NULL,
	[LastUpdatedBy_FK] [int] NULL,
	[Notes] [ntext] NULL,
	[Inactive][bit] NULL

 CONSTRAINT [pk_inventory_InventorySEQ] PRIMARY KEY CLUSTERED 
(
	[Inventory_SEQ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

