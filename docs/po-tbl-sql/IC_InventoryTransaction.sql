USE [OT_ERP_CAN_TRADE]
GO

/****** Object:  Table [dbo].[tblIC_InventoryTrans]    Script Date: 10/13/2019 4:02:43 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblIC_Transaction](
[Trans_No] [char](7) NOT NULL,
[Trans_Code] [char](2) NOT NULL,
[Trans_Date] [datetime] NULL,
[Warehouse_ID] [char](5) NOT NULL,
[Item_FK] [int] NULL,
[Reference_No] [nvarchar](15)  NULL,
[Reference_Date] [datetime]  NULL,
[Taxable] [bit] NULL,
[Cust_Vend_WarID] [char](10) NULL,
[Trans_Qty] [float] NULL,
[UOM] [char] (2) NULL,
[Trans_Amount] [money] NULL,
[Qty_On_Hand_EOB] [float] NULL,
[Qty_On_Order_EOB] [float] NULL,
[Qty_On_Allowed_EOB] [float] NULL,
[GL_Asset] [char] (7) NULL,
[GL_COGS] [char] (7) NULL,
[GL_Sales] [char] (7) NULL,
 CONSTRAINT [PK_tlbIC_Transaction] PRIMARY KEY CLUSTERED 
(
	[Trans_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

