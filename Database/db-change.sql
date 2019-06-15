USE [OnlineStoreDB]
GO
/****** Object:  Table [dbo].[DeliveryType]    Script Date: 2019-06-15 9:16:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeliveryType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[Value] [decimal](18, 2) NULL,
	[Timestamp] [timestamp] NULL,
	[IsDeleted] [bit] NULL,
	[DateModified] [datetime] NULL,
	[DateCreated] [datetime] NULL,
 CONSTRAINT [PK_DeliveryType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 2019-06-15 9:16:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Timestamp] [timestamp] NOT NULL,
	[DeliveryDate] [datetime2](7) NULL,
	[SaleOff] [decimal](18, 2) NOT NULL,
	[EmployeeId] [uniqueidentifier] NULL,
	[CustomerId] [uniqueidentifier] NOT NULL,
	[ShippingFee] [decimal](18, 2) NOT NULL,
	[Status] [tinyint] NOT NULL,
	[OrderDate] [datetime2](7) NOT NULL,
	[AddressId] [int] NULL,
	[IsDeleted] [bit] NOT NULL,
	[DeliveryTypeId] [int] NOT NULL,
	[DateCreated] [datetime] NULL,
	[DateModified] [datetime] NULL,
	[PaymentType] [tinyint] NULL,
	[SubTotal] [decimal](18, 0) NULL,
	[Total] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DeliveryType] ON 

INSERT [dbo].[DeliveryType] ([Id], [Name], [Value], [IsDeleted], [DateModified], [DateCreated]) VALUES (1, N'Giao hàng tiêu chuẩn', CAST(5000.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[DeliveryType] ([Id], [Name], [Value], [IsDeleted], [DateModified], [DateCreated]) VALUES (2, N'Giao hàng ưu tiên', CAST(15000.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[DeliveryType] ([Id], [Name], [Value], [IsDeleted], [DateModified], [DateCreated]) VALUES (3, N'Nhận hàng tại showroom', CAST(0.00 AS Decimal(18, 2)), NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[DeliveryType] OFF
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([Id], [DeliveryDate], [SaleOff], [EmployeeId], [CustomerId], [ShippingFee], [Status], [OrderDate], [AddressId], [IsDeleted], [DeliveryTypeId], [DateCreated], [DateModified], [PaymentType], [SubTotal], [Total]) VALUES (2, CAST(N'2019-11-01T23:20:00.0000000' AS DateTime2), CAST(0.00 AS Decimal(18, 2)), NULL, N'b48829d5-906a-47b6-e7ed-08d6db6117ff', CAST(15000.00 AS Decimal(18, 2)), 4, CAST(N'2019-05-18T14:32:28.5833333' AS DateTime2), 4, 0, 1, CAST(N'2019-05-18T14:32:28.583' AS DateTime), CAST(N'2019-05-27T11:45:35.293' AS DateTime), 1, CAST(1025700000 AS Decimal(18, 0)), CAST(1025700000 AS Decimal(18, 0)))
INSERT [dbo].[Order] ([Id], [DeliveryDate], [SaleOff], [EmployeeId], [CustomerId], [ShippingFee], [Status], [OrderDate], [AddressId], [IsDeleted], [DeliveryTypeId], [DateCreated], [DateModified], [PaymentType], [SubTotal], [Total]) VALUES (3, CAST(N'2019-05-19T08:40:37.8033333' AS DateTime2), CAST(0.00 AS Decimal(18, 2)), NULL, N'b48829d5-906a-47b6-e7ed-08d6db6117ff', CAST(11000.00 AS Decimal(18, 2)), 4, CAST(N'2019-05-19T08:40:37.8033333' AS DateTime2), 4, 0, 2, CAST(N'2019-05-09T08:40:37.803' AS DateTime), CAST(N'2019-05-19T08:40:37.803' AS DateTime), 1, CAST(1025700000 AS Decimal(18, 0)), CAST(1025800000 AS Decimal(18, 0)))
INSERT [dbo].[Order] ([Id], [DeliveryDate], [SaleOff], [EmployeeId], [CustomerId], [ShippingFee], [Status], [OrderDate], [AddressId], [IsDeleted], [DeliveryTypeId], [DateCreated], [DateModified], [PaymentType], [SubTotal], [Total]) VALUES (4, NULL, CAST(0.00 AS Decimal(18, 2)), NULL, N'b48829d5-906a-47b6-e7ed-08d6db6117ff', CAST(0.00 AS Decimal(18, 2)), 4, CAST(N'2019-05-29T23:23:41.6266667' AS DateTime2), 4, 0, 3, CAST(N'2019-05-02T08:40:37.803' AS DateTime), NULL, 1, CAST(1025700000 AS Decimal(18, 0)), CAST(1025800000 AS Decimal(18, 0)))
INSERT [dbo].[Order] ([Id], [DeliveryDate], [SaleOff], [EmployeeId], [CustomerId], [ShippingFee], [Status], [OrderDate], [AddressId], [IsDeleted], [DeliveryTypeId], [DateCreated], [DateModified], [PaymentType], [SubTotal], [Total]) VALUES (5, NULL, CAST(0.00 AS Decimal(18, 2)), NULL, N'b48829d5-906a-47b6-e7ed-08d6db6117ff', CAST(0.00 AS Decimal(18, 2)), 4, CAST(N'2019-05-31T00:05:44.4300000' AS DateTime2), NULL, 0, 3, NULL, NULL, 1, CAST(1025700000 AS Decimal(18, 0)), CAST(1025700000 AS Decimal(18, 0)))
INSERT [dbo].[Order] ([Id], [DeliveryDate], [SaleOff], [EmployeeId], [CustomerId], [ShippingFee], [Status], [OrderDate], [AddressId], [IsDeleted], [DeliveryTypeId], [DateCreated], [DateModified], [PaymentType], [SubTotal], [Total]) VALUES (6, CAST(N'2019-06-20T17:00:00.0000000' AS DateTime2), CAST(0.00 AS Decimal(18, 2)), NULL, N'b48829d5-906a-47b6-e7ed-08d6db6117ff', CAST(0.00 AS Decimal(18, 2)), 1, CAST(N'2019-05-31T00:07:55.4900000' AS DateTime2), NULL, 0, 1, NULL, CAST(N'2019-05-31T00:47:35.333' AS DateTime), 1, CAST(1025700000 AS Decimal(18, 0)), CAST(1025700000 AS Decimal(18, 0)))
INSERT [dbo].[Order] ([Id], [DeliveryDate], [SaleOff], [EmployeeId], [CustomerId], [ShippingFee], [Status], [OrderDate], [AddressId], [IsDeleted], [DeliveryTypeId], [DateCreated], [DateModified], [PaymentType], [SubTotal], [Total]) VALUES (9, CAST(N'2019-05-19T08:40:37.8033333' AS DateTime2), CAST(0.00 AS Decimal(18, 2)), NULL, N'b48829d5-906a-47b6-e7ed-08d6db6117ff', CAST(12000.00 AS Decimal(18, 2)), 2, CAST(N'2019-05-19T08:40:37.8033333' AS DateTime2), NULL, 0, 1, CAST(N'2019-05-19T08:40:37.803' AS DateTime), CAST(N'2019-05-19T08:40:37.803' AS DateTime), 1, CAST(1400000 AS Decimal(18, 0)), CAST(1400000 AS Decimal(18, 0)))
INSERT [dbo].[Order] ([Id], [DeliveryDate], [SaleOff], [EmployeeId], [CustomerId], [ShippingFee], [Status], [OrderDate], [AddressId], [IsDeleted], [DeliveryTypeId], [DateCreated], [DateModified], [PaymentType], [SubTotal], [Total]) VALUES (10, CAST(N'2019-06-20T17:00:00.0000000' AS DateTime2), CAST(0.00 AS Decimal(18, 2)), NULL, N'b48829d5-906a-47b6-e7ed-08d6db6117ff', CAST(0.00 AS Decimal(18, 2)), 1, CAST(N'2019-05-31T00:07:55.4900000' AS DateTime2), NULL, 0, 1, NULL, CAST(N'2019-05-31T00:47:35.333' AS DateTime), 1, CAST(1025700000 AS Decimal(18, 0)), CAST(1025700000 AS Decimal(18, 0)))
INSERT [dbo].[Order] ([Id], [DeliveryDate], [SaleOff], [EmployeeId], [CustomerId], [ShippingFee], [Status], [OrderDate], [AddressId], [IsDeleted], [DeliveryTypeId], [DateCreated], [DateModified], [PaymentType], [SubTotal], [Total]) VALUES (11, CAST(N'2019-05-19T08:40:37.8033333' AS DateTime2), CAST(0.00 AS Decimal(18, 2)), NULL, N'b48829d5-906a-47b6-e7ed-08d6db6117ff', CAST(12000.00 AS Decimal(18, 2)), 2, CAST(N'2019-05-19T08:40:37.8033333' AS DateTime2), NULL, 0, 1, CAST(N'2019-05-19T08:40:37.803' AS DateTime), CAST(N'2019-05-19T08:40:37.803' AS DateTime), 1, CAST(1400000 AS Decimal(18, 0)), CAST(1400000 AS Decimal(18, 0)))
INSERT [dbo].[Order] ([Id], [DeliveryDate], [SaleOff], [EmployeeId], [CustomerId], [ShippingFee], [Status], [OrderDate], [AddressId], [IsDeleted], [DeliveryTypeId], [DateCreated], [DateModified], [PaymentType], [SubTotal], [Total]) VALUES (12, CAST(N'2019-06-20T17:00:00.0000000' AS DateTime2), CAST(0.00 AS Decimal(18, 2)), NULL, N'b48829d5-906a-47b6-e7ed-08d6db6117ff', CAST(0.00 AS Decimal(18, 2)), 1, CAST(N'2019-05-31T00:07:55.4900000' AS DateTime2), NULL, 0, 1, NULL, CAST(N'2019-05-31T00:47:35.333' AS DateTime), 1, CAST(1025700000 AS Decimal(18, 0)), CAST(1025700000 AS Decimal(18, 0)))
INSERT [dbo].[Order] ([Id], [DeliveryDate], [SaleOff], [EmployeeId], [CustomerId], [ShippingFee], [Status], [OrderDate], [AddressId], [IsDeleted], [DeliveryTypeId], [DateCreated], [DateModified], [PaymentType], [SubTotal], [Total]) VALUES (13, CAST(N'2019-05-19T08:40:37.8033333' AS DateTime2), CAST(0.00 AS Decimal(18, 2)), NULL, N'b48829d5-906a-47b6-e7ed-08d6db6117ff', CAST(12000.00 AS Decimal(18, 2)), 2, CAST(N'2019-05-19T08:40:37.8033333' AS DateTime2), NULL, 0, 1, CAST(N'2019-05-19T08:40:37.803' AS DateTime), CAST(N'2019-05-19T08:40:37.803' AS DateTime), 1, CAST(1400000 AS Decimal(18, 0)), CAST(1400000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[Order] OFF
ALTER TABLE [dbo].[Order] ADD  CONSTRAINT [DF_Order_SaleOff]  DEFAULT ((0)) FOR [SaleOff]
GO
ALTER TABLE [dbo].[Order] ADD  CONSTRAINT [DF_Order_ShippingFee]  DEFAULT ((0)) FOR [ShippingFee]
GO
ALTER TABLE [dbo].[Order] ADD  CONSTRAINT [DF_Order_IsSelfReceive]  DEFAULT ((0)) FOR [DeliveryTypeId]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Address] FOREIGN KEY([AddressId])
REFERENCES [dbo].[Address] ([Id])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Address]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_AspNetUsers] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_AspNetUsers]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_DeliveryType] FOREIGN KEY([DeliveryTypeId])
REFERENCES [dbo].[DeliveryType] ([Id])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_DeliveryType]
GO
