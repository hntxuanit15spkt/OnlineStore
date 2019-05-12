USE [OnlineStoreDB]
GO
/****** Object:  Table [dbo].[ProductImages]    Script Date: 2019-05-12 10:05:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductImages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Path] [nvarchar](250) NULL,
	[ItemId] [int] NULL,
	[Timestamp] [timestamp] NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK__ImagePro__3214EC079E4A12CA] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ProductImages] ON 

INSERT [dbo].[ProductImages] ([Id], [Name], [Path], [ItemId], [IsDeleted]) VALUES (1, N'image.png', NULL, 25, 0)
INSERT [dbo].[ProductImages] ([Id], [Name], [Path], [ItemId], [IsDeleted]) VALUES (2, N'screencapture-pro15-emailserver-vn-2096-cpsess4909743690-webmail-paper-lantern-index-html-2019-05-06-13_09_31.png', NULL, 25, 0)
SET IDENTITY_INSERT [dbo].[ProductImages] OFF
ALTER TABLE [dbo].[ProductImages]  WITH CHECK ADD  CONSTRAINT [FK_ImageProduct_Item] FOREIGN KEY([ItemId])
REFERENCES [dbo].[Item] ([Id])
GO
ALTER TABLE [dbo].[ProductImages] CHECK CONSTRAINT [FK_ImageProduct_Item]
GO
