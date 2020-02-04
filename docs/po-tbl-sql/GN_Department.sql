USE [OT_ERP_CAN_TRADE]
GO

/****** Object:  Table [dbo].[tblGN_Department]    Script Date: 10/14/2019 4:33:16 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblGN_Department](
	[Department_ID] [char](5) NOT NULL,
	[Deparment_Name] [nvarchar](15) NULL,
	[Description] [nvarchar](150) NULL,
 CONSTRAINT [pk_GN_Deparment] PRIMARY KEY CLUSTERED 
(
	[Department_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


