USE [OT_ERP_CAN_TRADE]
GO

/****** Object:  Table [dbo].[tblPO_RROrderDetail]    Script Date: 10/14/2019 4:09:02 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblPO_RROrderDetail](
	[RR_FK] [char](15) NOT NULL,
	[Inventory_FK] [int] NOT NULL,
	[Unit_Price] [money] NULL,
	[QtyOrdered] [float] NULL,
	[QtyReceived] [float] NULL,

 CONSTRAINT [pk_PO_RROrderDetail] PRIMARY KEY CLUSTERED 
(
	[RR_FK] ASC,
	[Inventory_FK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


