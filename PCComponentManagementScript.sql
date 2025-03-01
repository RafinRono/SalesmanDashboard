USE [PCComponentManagementDB]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 12/24/2023 5:55:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[BillId] [varchar](30) NOT NULL,
	[BillDate] [date] NULL,
	[TotalAmount] [float] NULL,
 CONSTRAINT [PK_Bill_1] PRIMARY KEY CLUSTERED 
(
	[BillId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item]    Script Date: 12/24/2023 5:55:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item](
	[IId] [varchar](30) NOT NULL,
	[IType] [varchar](50) NULL,
	[IBrand] [varchar](50) NULL,
	[IModelNo] [varchar](30) NOT NULL,
	[IPrice] [float] NOT NULL,
	[IStockStatus] [int] NOT NULL,
	[IMinimumStock] [int] NOT NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[IId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transection1]    Script Date: 12/24/2023 5:55:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transection1](
	[TId] [varchar](30) NOT NULL,
	[CustomerName] [varchar](50) NULL,
	[BillId] [varchar](30) NULL,
	[TotalAmount] [int] NULL,
	[TotalPrice] [float] NULL,
	[UId] [varchar](30) NULL,
 CONSTRAINT [PK_Transection1] PRIMARY KEY CLUSTERED 
(
	[TId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User1]    Script Date: 12/24/2023 5:55:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User1](
	[UId] [varchar](30) NOT NULL,
	[UName] [varchar](50) NULL,
	[UPassword] [varchar](30) NOT NULL,
	[UPhoneNo] [varchar](15) NOT NULL,
	[Email] [varchar](30) NULL,
	[UAddress] [varchar](100) NULL,
	[Role] [varchar](20) NOT NULL,
	[JoiningDate] [date] NULL,
	[Salary] [float] NOT NULL,
 CONSTRAINT [PK_User1] PRIMARY KEY CLUSTERED 
(
	[UId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Bill] ([BillId], [BillDate], [TotalAmount]) VALUES (N'b-001', CAST(N'2023-12-23' AS Date), 32000)
INSERT [dbo].[Bill] ([BillId], [BillDate], [TotalAmount]) VALUES (N'b-002', CAST(N'2023-12-24' AS Date), 3500)
INSERT [dbo].[Bill] ([BillId], [BillDate], [TotalAmount]) VALUES (N'b-003', CAST(N'2023-12-24' AS Date), 38000)
INSERT [dbo].[Bill] ([BillId], [BillDate], [TotalAmount]) VALUES (N'b-004', CAST(N'2023-12-24' AS Date), 2000)
INSERT [dbo].[Bill] ([BillId], [BillDate], [TotalAmount]) VALUES (N'b-005', CAST(N'2023-12-24' AS Date), 3500)
INSERT [dbo].[Bill] ([BillId], [BillDate], [TotalAmount]) VALUES (N'b-006', CAST(N'2023-12-24' AS Date), 27000)
INSERT [dbo].[Bill] ([BillId], [BillDate], [TotalAmount]) VALUES (N'b-007', CAST(N'2023-12-24' AS Date), 22000)
INSERT [dbo].[Bill] ([BillId], [BillDate], [TotalAmount]) VALUES (N'b-008', CAST(N'2023-12-24' AS Date), 18500)
INSERT [dbo].[Bill] ([BillId], [BillDate], [TotalAmount]) VALUES (N'b-009', CAST(N'2023-12-24' AS Date), 15500)
INSERT [dbo].[Bill] ([BillId], [BillDate], [TotalAmount]) VALUES (N'b-010', CAST(N'2023-12-24' AS Date), 37000)
INSERT [dbo].[Bill] ([BillId], [BillDate], [TotalAmount]) VALUES (N'b-011', CAST(N'2023-12-24' AS Date), 40500)
INSERT [dbo].[Bill] ([BillId], [BillDate], [TotalAmount]) VALUES (N'b-012', CAST(N'2023-12-24' AS Date), 22000)
GO
INSERT [dbo].[Item] ([IId], [IType], [IBrand], [IModelNo], [IPrice], [IStockStatus], [IMinimumStock]) VALUES (N'i-001', N'Processor', N'AMD', N'RYZEN 7 5800X', 22000, 15, 3)
INSERT [dbo].[Item] ([IId], [IType], [IBrand], [IModelNo], [IPrice], [IStockStatus], [IMinimumStock]) VALUES (N'i-002', N'SSD', N'Samsung', N'EVO 225GB', 2000, 15, 3)
INSERT [dbo].[Item] ([IId], [IType], [IBrand], [IModelNo], [IPrice], [IStockStatus], [IMinimumStock]) VALUES (N'i-003', N'RAM ', N'GIGABYTE', N'REVO 8GB', 1500, 37, 5)
INSERT [dbo].[Item] ([IId], [IType], [IBrand], [IModelNo], [IPrice], [IStockStatus], [IMinimumStock]) VALUES (N'i-004', N'Processor ', N'Intel ', N'i5-5230 ', 15000, 14, 10)
INSERT [dbo].[Item] ([IId], [IType], [IBrand], [IModelNo], [IPrice], [IStockStatus], [IMinimumStock]) VALUES (N'i-005', N'HDD', N'Toshiba', N'Amus 500GB', 3000, 41, 5)
GO
INSERT [dbo].[Transection1] ([TId], [CustomerName], [BillId], [TotalAmount], [TotalPrice], [UId]) VALUES (N't-001', N'Rafsan', N'b-001', 6, 16000, N'S-001')
INSERT [dbo].[Transection1] ([TId], [CustomerName], [BillId], [TotalAmount], [TotalPrice], [UId]) VALUES (N't-002', N'Altaf', N'b-002', 2, 3325, N'S-001')
INSERT [dbo].[Transection1] ([TId], [CustomerName], [BillId], [TotalAmount], [TotalPrice], [UId]) VALUES (N't-003', N'Mahmud', N'b-003', 7, 34200, N'S-001')
INSERT [dbo].[Transection1] ([TId], [CustomerName], [BillId], [TotalAmount], [TotalPrice], [UId]) VALUES (N't-004', N'Rono', N'b-004', 1, 1900, N'S-001')
INSERT [dbo].[Transection1] ([TId], [CustomerName], [BillId], [TotalAmount], [TotalPrice], [UId]) VALUES (N't-005', N'Hussain', N'b-005', 2, 3325, N'S-001')
INSERT [dbo].[Transection1] ([TId], [CustomerName], [BillId], [TotalAmount], [TotalPrice], [UId]) VALUES (N't-006', N'Imran', N'b-006', 4, 25650, N'S-001')
INSERT [dbo].[Transection1] ([TId], [CustomerName], [BillId], [TotalAmount], [TotalPrice], [UId]) VALUES (N't-007', N'Taranga', N'b-007', 5, 20900, N'S-001')
INSERT [dbo].[Transection1] ([TId], [CustomerName], [BillId], [TotalAmount], [TotalPrice], [UId]) VALUES (N't-008', N'Tahsin', N'b-008', 3, 17575, N'S-001')
INSERT [dbo].[Transection1] ([TId], [CustomerName], [BillId], [TotalAmount], [TotalPrice], [UId]) VALUES (N't-009', N'Ferdous', N'b-009', 6, 14725, N'S-001')
INSERT [dbo].[Transection1] ([TId], [CustomerName], [BillId], [TotalAmount], [TotalPrice], [UId]) VALUES (N't-010', N'Yunus', N'b-010', 2, 35150, N'S-001')
INSERT [dbo].[Transection1] ([TId], [CustomerName], [BillId], [TotalAmount], [TotalPrice], [UId]) VALUES (N't-011', N'Resadus', N'b-011', 4, 20250, N'S-001')
INSERT [dbo].[Transection1] ([TId], [CustomerName], [BillId], [TotalAmount], [TotalPrice], [UId]) VALUES (N't-012', N'Mahmud', N'b-012', 1, 20900, N'S-001')
GO
INSERT [dbo].[User1] ([UId], [UName], [UPassword], [UPhoneNo], [Email], [UAddress], [Role], [JoiningDate], [Salary]) VALUES (N'A-001', N'Admin', N'Admin', N'01501201355', N'admin@gmail.com', N'Kuril, Dhaka', N'Admin', CAST(N'2002-12-12' AS Date), 80000)
INSERT [dbo].[User1] ([UId], [UName], [UPassword], [UPhoneNo], [Email], [UAddress], [Role], [JoiningDate], [Salary]) VALUES (N'M-001', N'Manager', N'1234', N'01701501644', N'manager@gmail.com', N'Kuril, Dhaka', N'Manager', CAST(N'2018-12-10' AS Date), 50000)
INSERT [dbo].[User1] ([UId], [UName], [UPassword], [UPhoneNo], [Email], [UAddress], [Role], [JoiningDate], [Salary]) VALUES (N'S-001', N'Salesman', N'1234', N'01901501888', N'salesman@gmail.com', N'Kuril, Dhaka', N'Salesman', CAST(N'2020-01-01' AS Date), 20000)
GO
ALTER TABLE [dbo].[Transection1]  WITH CHECK ADD  CONSTRAINT [FK_Transection1_Transection1] FOREIGN KEY([BillId])
REFERENCES [dbo].[Bill] ([BillId])
GO
ALTER TABLE [dbo].[Transection1] CHECK CONSTRAINT [FK_Transection1_Transection1]
GO
ALTER TABLE [dbo].[Transection1]  WITH CHECK ADD  CONSTRAINT [FK_Transection1_User1] FOREIGN KEY([UId])
REFERENCES [dbo].[User1] ([UId])
GO
ALTER TABLE [dbo].[Transection1] CHECK CONSTRAINT [FK_Transection1_User1]
GO
