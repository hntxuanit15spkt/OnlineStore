USE [OnlineStoreDB]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 2019-04-29 12:11:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[Timestamp] [timestamp] NULL,
	[IsDeleted] [bit] NOT NULL,
	[Status] [tinyint] NULL,
	[DateCreated] [datetime] NULL,
	[DateModified] [datetime] NULL,
	[SortOrder] [int] NULL,
	[ParentId] [int] NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [Name], [IsDeleted], [Status], [DateCreated], [DateModified], [SortOrder], [ParentId]) VALUES (1, N'Điện thoại', 0, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Category] ([Id], [Name], [IsDeleted], [Status], [DateCreated], [DateModified], [SortOrder], [ParentId]) VALUES (2, N'Laptop', 0, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Category] ([Id], [Name], [IsDeleted], [Status], [DateCreated], [DateModified], [SortOrder], [ParentId]) VALUES (3, N'Máy tính bảng', 0, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Category] ([Id], [Name], [IsDeleted], [Status], [DateCreated], [DateModified], [SortOrder], [ParentId]) VALUES (4, N'Phụ kiện', 0, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Category] OFF
