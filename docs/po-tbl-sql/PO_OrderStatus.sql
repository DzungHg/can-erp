USE [OT_ERP_CAN_TRADE]
GO

/****** Object:  Table [dbo].[tblPO_OrderStatus]    Script Date: 10/14/2019 3:42:19 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblPO_OrderStatus](
	[POStatus_ID] [nchar](20) NOT NULL,
	[POStatusText] [nvarchar](50) NULL,
	[Description] [nvarchar](100) NULL,
 CONSTRAINT [pk_PO_orderstatus] PRIMARY KEY CLUSTERED 
(
	[POStatus_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


