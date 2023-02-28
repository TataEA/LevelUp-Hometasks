USE [Store]
GO

/****** Object:  Table [dbo].[OrderStatuses]    Script Date: 28.02.2023 23:11:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OrderStatuses](
	[Id] [uniqueidentifier] NOT NULL,
	[Value] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](300) NOT NULL,
 CONSTRAINT [PK_OrderStatuses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


