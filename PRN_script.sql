USE [master]
GO
/****** Object:  Database [CoffeeShop]    Script Date: 24-Mar-23 1:41:59 PM ******/
CREATE DATABASE [CoffeeShop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CoffeeShop', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\CoffeeShop.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CoffeeShop_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\CoffeeShop_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CoffeeShop] SET COMPATIBILITY_LEVEL = 150
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
ALTER DATABASE [CoffeeShop] SET AUTO_CLOSE OFF 
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
ALTER DATABASE [CoffeeShop] SET  DISABLE_BROKER 
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
ALTER DATABASE [CoffeeShop] SET RECOVERY FULL 
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
EXEC sys.sp_db_vardecimal_storage_format N'CoffeeShop', N'ON'
GO
ALTER DATABASE [CoffeeShop] SET QUERY_STORE = OFF
GO
USE [CoffeeShop]
GO
/****** Object:  Table [dbo].[Cart]    Script Date: 24-Mar-23 1:42:00 PM ******/
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
	[orderDate] [datetime] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 24-Mar-23 1:42:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[categoryId] [int] NOT NULL,
	[categoryName] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[categoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item]    Script Date: 24-Mar-23 1:42:00 PM ******/
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
/****** Object:  Table [dbo].[Order]    Script Date: 24-Mar-23 1:42:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[orderId] [int] IDENTITY(1,1) NOT NULL,
	[userId] [int] NOT NULL,
	[phone] [varchar](10) NOT NULL,
	[total] [money] NOT NULL,
	[status] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_Order_1] PRIMARY KEY CLUSTERED 
(
	[orderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 24-Mar-23 1:42:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[orderId] [int] NOT NULL,
	[itemId] [nvarchar](5) NOT NULL,
	[quantity] [int] NOT NULL,
	[orderDate] [datetime] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 24-Mar-23 1:42:00 PM ******/
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
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Cart] ([itemId], [userId], [itemName], [price], [quantity], [orderDate]) VALUES (N'c1', 2, N'Espresso', 45000.0000, 1, CAST(N'2023-03-24T13:36:08.530' AS DateTime))
INSERT [dbo].[Cart] ([itemId], [userId], [itemName], [price], [quantity], [orderDate]) VALUES (N'c2', 2, N'Cappuccino', 45000.0000, 1, CAST(N'2023-03-22T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Category] ([categoryId], [categoryName]) VALUES (1, N'Coffee')
INSERT [dbo].[Category] ([categoryId], [categoryName]) VALUES (2, N'Dessert')
GO
INSERT [dbo].[Item] ([itemId], [categoryId], [itemName], [price]) VALUES (N'c1', 1, N'Espresso', 45000.0000)
INSERT [dbo].[Item] ([itemId], [categoryId], [itemName], [price]) VALUES (N'c2', 1, N'Cappuccino', 45000.0000)
INSERT [dbo].[Item] ([itemId], [categoryId], [itemName], [price]) VALUES (N'c3', 1, N'Latte', 45000.0000)
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
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([orderId], [userId], [phone], [total], [status]) VALUES (1, 2, N'0355235054', 45000.0000, N'Waiting')
INSERT [dbo].[Order] ([orderId], [userId], [phone], [total], [status]) VALUES (2, 2, N'0355235054', 40000.0000, N'Waiting')
SET IDENTITY_INSERT [dbo].[Order] OFF
GO
INSERT [dbo].[OrderDetail] ([orderId], [itemId], [quantity], [orderDate]) VALUES (1, N'c2', 1, CAST(N'2023-03-22T00:00:00.000' AS DateTime))
INSERT [dbo].[OrderDetail] ([orderId], [itemId], [quantity], [orderDate]) VALUES (1, N'd2', 1, CAST(N'2023-03-22T00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([userId], [username], [password], [phone], [email]) VALUES (2, N'huyenptn', N'123456', N'0355235054', N'huyenptn@gmail.com')
INSERT [dbo].[User] ([userId], [username], [password], [phone], [email]) VALUES (3, N'longdh', N'123456', N'0123456789', N'longdh@gmail.com')
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Cart]  WITH CHECK ADD  CONSTRAINT [FK_Cart_Item] FOREIGN KEY([itemId])
REFERENCES [dbo].[Item] ([itemId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cart] CHECK CONSTRAINT [FK_Cart_Item]
GO
ALTER TABLE [dbo].[Cart]  WITH CHECK ADD  CONSTRAINT [FK_Cart_User] FOREIGN KEY([userId])
REFERENCES [dbo].[User] ([userId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cart] CHECK CONSTRAINT [FK_Cart_User]
GO
ALTER TABLE [dbo].[Item]  WITH CHECK ADD  CONSTRAINT [FK_Item_Category] FOREIGN KEY([categoryId])
REFERENCES [dbo].[Category] ([categoryId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Item] CHECK CONSTRAINT [FK_Item_Category]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_User1] FOREIGN KEY([userId])
REFERENCES [dbo].[User] ([userId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_User1]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Item] FOREIGN KEY([itemId])
REFERENCES [dbo].[Item] ([itemId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Item]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Order] FOREIGN KEY([orderId])
REFERENCES [dbo].[Order] ([orderId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Order]
GO
USE [master]
GO
ALTER DATABASE [CoffeeShop] SET  READ_WRITE 
GO
