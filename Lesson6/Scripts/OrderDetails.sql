USE [Store]
GO

/****** Object:  Table [dbo].[OrderDetails]    Script Date: 28.02.2023 23:10:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OrderDetails](
	[Price] [decimal](18, 2) NOT NULL,
	[Amount] [float] NOT NULL,
	[Sum] [decimal](18, 2) NOT NULL,
	[OrderId] [uniqueidentifier] NOT NULL,
	[ShopItemId] [uniqueidentifier] NOT NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([Id])
GO

ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders]
GO

ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_ShopItems] FOREIGN KEY([ShopItemId])
REFERENCES [dbo].[ShopItems] ([Id])
GO

ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_ShopItems]
GO


