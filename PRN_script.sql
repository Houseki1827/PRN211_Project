USE [master]
GO
/****** Object:  Database [CoffeeShop]    Script Date: 25/3/2023 10:21:16 pm ******/
CREATE DATABASE [CoffeeShop]
 CONTAINMENT = NONE
GO
ALTER DATABASE [CoffeeShop] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CoffeeShop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CoffeeShop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CoffeeShop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CoffeeShop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CoffeeShop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CoffeeShop] SET ARITHABORT OFF 
GO
ALTER DATABASE [CoffeeShop] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [CoffeeShop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CoffeeShop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CoffeeShop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CoffeeShop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CoffeeShop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CoffeeShop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CoffeeShop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CoffeeShop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CoffeeShop] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CoffeeShop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CoffeeShop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CoffeeShop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CoffeeShop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CoffeeShop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CoffeeShop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CoffeeShop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CoffeeShop] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CoffeeShop] SET  MULTI_USER 
GO
ALTER DATABASE [CoffeeShop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CoffeeShop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CoffeeShop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CoffeeShop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CoffeeShop] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CoffeeShop] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [CoffeeShop] SET QUERY_STORE = ON
GO
ALTER DATABASE [CoffeeShop] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [CoffeeShop]
GO
/****** Object:  Table [dbo].[Cart]    Script Date: 25/3/2023 10:21:17 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cart](
	[itemId] [nvarchar](5) NOT NULL,
	[userId] [int] NOT NULL,
	[itemName] [nvarchar](150) NOT NULL,
	[price] [money] NOT NULL,
	[quantity] [int] NOT NULL,
	[orderDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Cart] PRIMARY KEY CLUSTERED 
(
	[itemId] ASC,
	[userId] ASC,
	[quantity] ASC,
	[orderDate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 25/3/2023 10:21:17 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[categoryId] [int] IDENTITY(1,1) NOT NULL,
	[categoryName] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[categoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item]    Script Date: 25/3/2023 10:21:17 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item](
	[itemId] [nvarchar](5) NOT NULL,
	[categoryId] [int] NOT NULL,
	[itemName] [nvarchar](150) NOT NULL,
	[price] [money] NOT NULL,
 CONSTRAINT [PK_Item_1] PRIMARY KEY CLUSTERED 
(
	[itemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 25/3/2023 10:21:17 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[orderId] [int] IDENTITY(1,1) NOT NULL,
	[userId] [int] NULL,
	[phone] [varchar](10) NOT NULL,
	[total] [money] NOT NULL,
	[status] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_Order_1] PRIMARY KEY CLUSTERED 
(
	[orderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 25/3/2023 10:21:17 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[orderId] [int] NOT NULL,
	[itemId] [nvarchar](5) NOT NULL,
	[quantity] [int] NOT NULL,
	[orderDate] [datetime] NOT NULL,
 CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[orderId] ASC,
	[itemId] ASC,
	[quantity] ASC,
	[orderDate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 25/3/2023 10:21:17 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[userId] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](150) NOT NULL,
	[password] [nvarchar](150) NOT NULL,
	[phone] [varchar](10) NOT NULL,
	[email] [nvarchar](150) NOT NULL,
	[created_date] [datetime] NOT NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([categoryId], [categoryName]) VALUES (1, N'Coffee')
INSERT [dbo].[Category] ([categoryId], [categoryName]) VALUES (2, N'Dessert')
INSERT [dbo].[Category] ([categoryId], [categoryName]) VALUES (1004, N'test')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
INSERT [dbo].[Item] ([itemId], [categoryId], [itemName], [price]) VALUES (N'c1', 1, N'Espresso', 45000.0000)
INSERT [dbo].[Item] ([itemId], [categoryId], [itemName], [price]) VALUES (N'c2', 1, N'Cappuccino', 45000.0000)
INSERT [dbo].[Item] ([itemId], [categoryId], [itemName], [price]) VALUES (N'c3', 1, N'Latte', 40000.0000)
INSERT [dbo].[Item] ([itemId], [categoryId], [itemName], [price]) VALUES (N'c4', 1, N'Americano', 39000.0000)
INSERT [dbo].[Item] ([itemId], [categoryId], [itemName], [price]) VALUES (N'c5', 1, N'Black coffee', 29000.0000)
INSERT [dbo].[Item] ([itemId], [categoryId], [itemName], [price]) VALUES (N'c6', 1, N'Black coffee with milk', 29000.0000)
INSERT [dbo].[Item] ([itemId], [categoryId], [itemName], [price]) VALUES (N'd1', 2, N'Mousse cake', 40000.0000)
INSERT [dbo].[Item] ([itemId], [categoryId], [itemName], [price]) VALUES (N'd2', 2, N'Tiramisu', 40000.0000)
INSERT [dbo].[Item] ([itemId], [categoryId], [itemName], [price]) VALUES (N'd3', 2, N'Pana Cotta', 35000.0000)
INSERT [dbo].[Item] ([itemId], [categoryId], [itemName], [price]) VALUES (N'd4', 2, N'Flan', 20000.0000)
INSERT [dbo].[Item] ([itemId], [categoryId], [itemName], [price]) VALUES (N'd5', 2, N'Muffin', 16000.0000)
INSERT [dbo].[Item] ([itemId], [categoryId], [itemName], [price]) VALUES (N'd6', 2, N'Macaron', 10000.0000)
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([userId], [username], [password], [phone], [email], [created_date]) VALUES (1, N'huyenptn', N'123456', N'0355235054', N'huyenptn@gmail.com', CAST(N'2023-03-20T00:00:00.000' AS DateTime))
INSERT [dbo].[User] ([userId], [username], [password], [phone], [email], [created_date]) VALUES (2, N'longdh', N'123456', N'0123456789', N'longdh@gmail.com', CAST(N'2023-03-20T00:00:00.000' AS DateTime))
INSERT [dbo].[User] ([userId], [username], [password], [phone], [email], [created_date]) VALUES (3, N'test01', N'111111', N'0123456789', N'test', CAST(N'2023-03-20T00:00:00.000' AS DateTime))
INSERT [dbo].[User] ([userId], [username], [password], [phone], [email], [created_date]) VALUES (9, N'guest7248', N'566100', N'0000000000', N'guest', CAST(N'2023-03-25T22:17:45.177' AS DateTime))
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Cart] ADD  DEFAULT (getdate()) FOR [orderDate]
GO
ALTER TABLE [dbo].[User] ADD  DEFAULT (getdate()) FOR [created_date]
GO
ALTER TABLE [dbo].[Cart]  WITH CHECK ADD FOREIGN KEY([itemId])
REFERENCES [dbo].[Item] ([itemId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cart]  WITH CHECK ADD FOREIGN KEY([userId])
REFERENCES [dbo].[User] ([userId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Item]  WITH CHECK ADD FOREIGN KEY([categoryId])
REFERENCES [dbo].[Category] ([categoryId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD FOREIGN KEY([userId])
REFERENCES [dbo].[User] ([userId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD FOREIGN KEY([itemId])
REFERENCES [dbo].[Item] ([itemId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD FOREIGN KEY([orderId])
REFERENCES [dbo].[Order] ([orderId])
ON DELETE CASCADE
GO
USE [master]
GO
ALTER DATABASE [CoffeeShop] SET  READ_WRITE 
GO
