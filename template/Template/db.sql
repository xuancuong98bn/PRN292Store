USE [PRN292_Shopping]
GO
/****** Object:  Table [dbo].[tblBill]    Script Date: 6/17/2019 3:11:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblBill](
	[Code] [numeric](18, 0) NOT NULL,
	[CustomerCode] [varchar](10) NULL,
	[DateBuy] [smalldatetime] NULL,
	[Status] [numeric](18, 0) NULL,
 CONSTRAINT [PK_tblBill] PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblCustomer]    Script Date: 6/17/2019 3:11:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCustomer](
	[Code] [varchar](10) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Gender] [bit] NULL,
	[Address] [nvarchar](50) NULL,
	[DOB] [smalldatetime] NULL,
 CONSTRAINT [PK_tblCustomer] PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblDetailBill]    Script Date: 6/17/2019 3:11:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblDetailBill](
	[BillCode] [numeric](18, 0) NOT NULL,
	[ProductCode] [varchar](10) NOT NULL,
	[Quantity] [int] NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_tblDetailBill_1] PRIMARY KEY CLUSTERED 
(
	[BillCode] ASC,
	[ProductCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblProduct]    Script Date: 6/17/2019 3:11:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblProduct](
	[Code] [varchar](10) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Unit] [varchar](50) NULL,
	[Price] [float] NULL,
 CONSTRAINT [PK_tblProduct] PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblUser]    Script Date: 6/17/2019 3:11:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblUser](
	[Username] [varchar](50) NULL,
	[Password] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblBill] ([Code], [CustomerCode], [DateBuy], [Status]) VALUES (CAST(1 AS Numeric(18, 0)), N'1', CAST(N'2011-11-11 00:00:00' AS SmallDateTime), CAST(0 AS Numeric(18, 0)))
INSERT [dbo].[tblBill] ([Code], [CustomerCode], [DateBuy], [Status]) VALUES (CAST(2 AS Numeric(18, 0)), N'3', CAST(N'2010-10-10 00:00:00' AS SmallDateTime), CAST(0 AS Numeric(18, 0)))
INSERT [dbo].[tblBill] ([Code], [CustomerCode], [DateBuy], [Status]) VALUES (CAST(3 AS Numeric(18, 0)), N'2', CAST(N'2001-09-09 00:00:00' AS SmallDateTime), CAST(0 AS Numeric(18, 0)))
INSERT [dbo].[tblBill] ([Code], [CustomerCode], [DateBuy], [Status]) VALUES (CAST(4 AS Numeric(18, 0)), N'1', CAST(N'2019-06-12 00:00:00' AS SmallDateTime), CAST(0 AS Numeric(18, 0)))
INSERT [dbo].[tblBill] ([Code], [CustomerCode], [DateBuy], [Status]) VALUES (CAST(5 AS Numeric(18, 0)), N'2', CAST(N'2019-06-10 00:00:00' AS SmallDateTime), CAST(0 AS Numeric(18, 0)))
INSERT [dbo].[tblBill] ([Code], [CustomerCode], [DateBuy], [Status]) VALUES (CAST(6 AS Numeric(18, 0)), N'3', CAST(N'2019-06-10 00:00:00' AS SmallDateTime), CAST(0 AS Numeric(18, 0)))
INSERT [dbo].[tblBill] ([Code], [CustomerCode], [DateBuy], [Status]) VALUES (CAST(9 AS Numeric(18, 0)), N'3', CAST(N'2019-06-12 00:00:00' AS SmallDateTime), CAST(0 AS Numeric(18, 0)))
INSERT [dbo].[tblCustomer] ([Code], [Name], [Gender], [Address], [DOB]) VALUES (N'1', N'Chu Ð?c Tâm ', 1, N'Sài Gòn', CAST(N'1994-12-12 00:00:00' AS SmallDateTime))
INSERT [dbo].[tblCustomer] ([Code], [Name], [Gender], [Address], [DOB]) VALUES (N'2', N'Văn Mai Hương', 0, N'Hà Nội', CAST(N'1995-11-12 00:00:00' AS SmallDateTime))
INSERT [dbo].[tblCustomer] ([Code], [Name], [Gender], [Address], [DOB]) VALUES (N'3', N'Nguyễn Hà', 0, N'Đà Nẵng', CAST(N'1995-01-02 00:00:00' AS SmallDateTime))
INSERT [dbo].[tblCustomer] ([Code], [Name], [Gender], [Address], [DOB]) VALUES (N'KH01', N'Hoàng Hà ', 1, N'Ngh? An', CAST(N'1994-02-06 00:12:00' AS SmallDateTime))
INSERT [dbo].[tblCustomer] ([Code], [Name], [Gender], [Address], [DOB]) VALUES (N'KH02', N'Nguyen Xuan Cuong ', 1, N'FUHL', CAST(N'1998-11-10 00:00:00' AS SmallDateTime))
INSERT [dbo].[tblCustomer] ([Code], [Name], [Gender], [Address], [DOB]) VALUES (N'KH03', N'Meo Meo ', 0, N'HL', CAST(N'2019-06-10 16:43:00' AS SmallDateTime))
INSERT [dbo].[tblCustomer] ([Code], [Name], [Gender], [Address], [DOB]) VALUES (N'KH04', N'Aaa ', 1, N'gh', CAST(N'2019-06-14 16:54:00' AS SmallDateTime))
INSERT [dbo].[tblDetailBill] ([BillCode], [ProductCode], [Quantity], [Status]) VALUES (CAST(1 AS Numeric(18, 0)), N'K01', 10, 0)
INSERT [dbo].[tblDetailBill] ([BillCode], [ProductCode], [Quantity], [Status]) VALUES (CAST(1 AS Numeric(18, 0)), N'K02', 20, 0)
INSERT [dbo].[tblDetailBill] ([BillCode], [ProductCode], [Quantity], [Status]) VALUES (CAST(1 AS Numeric(18, 0)), N'M01', 23, 0)
INSERT [dbo].[tblDetailBill] ([BillCode], [ProductCode], [Quantity], [Status]) VALUES (CAST(2 AS Numeric(18, 0)), N'C01', 100, 0)
INSERT [dbo].[tblDetailBill] ([BillCode], [ProductCode], [Quantity], [Status]) VALUES (CAST(2 AS Numeric(18, 0)), N'K01', 20, 0)
INSERT [dbo].[tblDetailBill] ([BillCode], [ProductCode], [Quantity], [Status]) VALUES (CAST(4 AS Numeric(18, 0)), N'C01', 110, 0)
INSERT [dbo].[tblDetailBill] ([BillCode], [ProductCode], [Quantity], [Status]) VALUES (CAST(4 AS Numeric(18, 0)), N'M01', 10, 0)
INSERT [dbo].[tblDetailBill] ([BillCode], [ProductCode], [Quantity], [Status]) VALUES (CAST(5 AS Numeric(18, 0)), N'C01', 20, 0)
INSERT [dbo].[tblDetailBill] ([BillCode], [ProductCode], [Quantity], [Status]) VALUES (CAST(5 AS Numeric(18, 0)), N'M01', 10, 0)
INSERT [dbo].[tblProduct] ([Code], [Name], [Unit], [Price]) VALUES (N'C01', N'Chó ', N'Con', 12346)
INSERT [dbo].[tblProduct] ([Code], [Name], [Unit], [Price]) VALUES (N'K01', N'Bàn phím', N'Chiec', 200000)
INSERT [dbo].[tblProduct] ([Code], [Name], [Unit], [Price]) VALUES (N'K02', N'Bàn Phí Co ', N'Chiec', 1200000)
INSERT [dbo].[tblProduct] ([Code], [Name], [Unit], [Price]) VALUES (N'M01', N'Mèo ', N'Con', 123454)
INSERT [dbo].[tblUser] ([Username], [Password]) VALUES (N'admin', 123456)
ALTER TABLE [dbo].[tblBill]  WITH CHECK ADD  CONSTRAINT [FK_tblBill_tblCustomer] FOREIGN KEY([CustomerCode])
REFERENCES [dbo].[tblCustomer] ([Code])
GO
ALTER TABLE [dbo].[tblBill] CHECK CONSTRAINT [FK_tblBill_tblCustomer]
GO
ALTER TABLE [dbo].[tblDetailBill]  WITH CHECK ADD  CONSTRAINT [FK_tblDetailBill_tblBill] FOREIGN KEY([BillCode])
REFERENCES [dbo].[tblBill] ([Code])
GO
ALTER TABLE [dbo].[tblDetailBill] CHECK CONSTRAINT [FK_tblDetailBill_tblBill]
GO
ALTER TABLE [dbo].[tblDetailBill]  WITH CHECK ADD  CONSTRAINT [FK_tblDetailBill_tblProduct] FOREIGN KEY([ProductCode])
REFERENCES [dbo].[tblProduct] ([Code])
GO
ALTER TABLE [dbo].[tblDetailBill] CHECK CONSTRAINT [FK_tblDetailBill_tblProduct]
GO
