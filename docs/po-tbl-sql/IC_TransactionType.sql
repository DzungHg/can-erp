USE [OT_ERP_CAN_TRADE]
GO

/****** Object:  Table [dbo].[tblIC_TransactionType]    Script Date: 10/13/2019 4:19:00 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblIC_TransactionType](
	[Transaction_ID] [char](2) NOT NULL,
	[Transaction_Name] [nvarchar](70) NULL,
	[Description]  [nvarchar](250) NULL,
 CONSTRAINT [PK_tlbIC_TransactionType] PRIMARY KEY CLUSTERED 
(
	[Transaction_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


