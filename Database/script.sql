USE [Game Store]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 5/15/2024 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[ID] [int] NOT NULL,
	[Category] [varchar](30) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 5/15/2024 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [varchar](30) NOT NULL,
	[CustomerPhoneNumber] [varchar](20) NOT NULL,
	[TotalPrice] [varchar](20) NOT NULL,
	[DateandTime] [datetime] NOT NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 5/15/2024 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ID] [varchar](10) NOT NULL,
	[Name] [varchar](30) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [int] NOT NULL,
	[CategoryID] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserInfo]    Script Date: 5/15/2024 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserInfo](
	[UserId] [varchar](10) NOT NULL,
	[UserName] [varchar](30) NOT NULL,
	[Password] [varchar](20) NOT NULL,
	[Role] [varchar](20) NOT NULL,
	[Address] [varchar](50) NOT NULL,
	[PhoneNumber] [varchar](15) NULL,
 CONSTRAINT [PK_UserInfo] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
