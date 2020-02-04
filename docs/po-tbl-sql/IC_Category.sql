USE [OT_ERP_CAN_TRADE]
GO

/****** Object:  Table [dbo].[tblIC_Category]    Script Date: 10/14/2019 1:48:09 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblIC_Category](
	[Category_ID] [char](5) NOT NULL,
	[CategoryText] [nvarchar](50) NULL,
	[Inactive] [bit] NULL,
 CONSTRAINT [PK_tlbIC_Category] PRIMARY KEY CLUSTERED 
(
	[Category_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


