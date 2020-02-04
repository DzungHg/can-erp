USE [OT_ERP_CAN_TRADE]
GO

/****** Object:  Table [dbo].[tblSO_SalesOrder]    Script Date: 10/13/2019 2:03:01 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblIC_Warehouse](
	[Warehouse_ID] [char](5) NOT NULL,
	[WarehouseName] [nvarchar](50) NULL,
	[WarehouseAddress] [nvarchar](100)  NULL,
	[Inactive] [bit] NULL,
 CONSTRAINT [PK_tlbIC_Warehouse] PRIMARY KEY CLUSTERED 
(
	[Warehouse_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

