USE [master]
GO
/****** Object:  Database [WharehouseManagementDB]    Script Date: 05/03/2021 08:58:49 م ******/
CREATE DATABASE [WharehouseManagementDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WharehouseManagementSystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\WharehouseManagementSystem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'WharehouseManagementSystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\WharehouseManagementSystem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [WharehouseManagementDB] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WharehouseManagementDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WharehouseManagementDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WharehouseManagementDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WharehouseManagementDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WharehouseManagementDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WharehouseManagementDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [WharehouseManagementDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [WharehouseManagementDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WharehouseManagementDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WharehouseManagementDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WharehouseManagementDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WharehouseManagementDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WharehouseManagementDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WharehouseManagementDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WharehouseManagementDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WharehouseManagementDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [WharehouseManagementDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WharehouseManagementDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WharehouseManagementDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WharehouseManagementDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WharehouseManagementDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WharehouseManagementDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WharehouseManagementDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WharehouseManagementDB] SET RECOVERY FULL 
GO
ALTER DATABASE [WharehouseManagementDB] SET  MULTI_USER 
GO
ALTER DATABASE [WharehouseManagementDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WharehouseManagementDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WharehouseManagementDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WharehouseManagementDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [WharehouseManagementDB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'WharehouseManagementDB', N'ON'
GO
ALTER DATABASE [WharehouseManagementDB] SET QUERY_STORE = OFF
GO
USE [WharehouseManagementDB]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 05/03/2021 08:58:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[phone] [nvarchar](50) NOT NULL,
	[mobile] [nvarchar](50) NOT NULL,
	[fax] [nvarchar](50) NOT NULL,
	[website] [nvarchar](max) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 05/03/2021 08:58:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inovice_Items]    Script Date: 05/03/2021 08:58:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inovice_Items](
	[order_number] [int] NOT NULL,
	[product_id] [int] NOT NULL,
	[supplyingOrder_id] [int] NOT NULL,
	[quantity] [int] NOT NULL,
 CONSTRAINT [PK_Inovice_Items] PRIMARY KEY CLUSTERED 
(
	[order_number] ASC,
	[product_id] ASC,
	[supplyingOrder_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item]    Script Date: 05/03/2021 08:58:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item](
	[Code] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[quantity] [int] NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item_Units]    Script Date: 05/03/2021 08:58:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item_Units](
	[Item_Code] [int] NOT NULL,
	[Unit_ID] [int] NOT NULL,
 CONSTRAINT [PK_Item_Units] PRIMARY KEY CLUSTERED 
(
	[Item_Code] ASC,
	[Unit_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payment_Order]    Script Date: 05/03/2021 08:58:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment_Order](
	[number] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NOT NULL,
	[customer_id] [int] NOT NULL,
 CONSTRAINT [PK_Payment_Order] PRIMARY KEY CLUSTERED 
(
	[number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provider]    Script Date: 05/03/2021 08:58:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provider](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[phone] [nvarchar](50) NOT NULL,
	[mobile] [nvarchar](50) NOT NULL,
	[fax] [nvarchar](50) NOT NULL,
	[website] [nvarchar](max) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Provider] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SupplyingOrder]    Script Date: 05/03/2021 08:58:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SupplyingOrder](
	[number] [int] IDENTITY(1,1) NOT NULL,
	[date] [date] NOT NULL,
	[supplier_id] [int] NOT NULL,
	[warehouse_id] [int] NOT NULL,
 CONSTRAINT [PK_SupplyingOrder] PRIMARY KEY CLUSTERED 
(
	[number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SupplyingOrder_Items]    Script Date: 05/03/2021 08:58:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SupplyingOrder_Items](
	[order_number] [int] NOT NULL,
	[item_code] [int] NOT NULL,
	[quantity] [int] NOT NULL,
	[Production_Date] [date] NOT NULL,
	[expiration_date] [date] NOT NULL,
 CONSTRAINT [PK_SupplyingOrder_Items] PRIMARY KEY CLUSTERED 
(
	[order_number] ASC,
	[item_code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transaction]    Script Date: 05/03/2021 08:58:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transaction](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[type_id] [int] NOT NULL,
	[order_id] [int] NOT NULL,
	[move_from_transaction_id] [int] NULL,
	[item_id] [int] NOT NULL,
	[quantity] [int] NOT NULL,
	[wharehouse_id] [int] NOT NULL,
	[total_quantity_for_product_in_wharehouse] [int] NOT NULL,
	[total_quantity_for_item_in_wharehouse] [int] NOT NULL,
	[date] [date] NOT NULL,
	[paymentOrderId] [int] NULL,
 CONSTRAINT [PK_Transaction] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transaction_Type]    Script Date: 05/03/2021 08:58:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transaction_Type](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[type] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Transaction_Type] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Unit]    Script Date: 05/03/2021 08:58:51 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Unit](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[quantity] [int] NOT NULL,
 CONSTRAINT [PK_Unit] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WarehouseItems]    Script Date: 05/03/2021 08:58:51 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WarehouseItems](
	[order_id] [int] NOT NULL,
	[warehouse_id] [int] NOT NULL,
	[item_id] [int] NOT NULL,
	[quantity] [int] NOT NULL,
 CONSTRAINT [PK_WarehouseItems] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC,
	[warehouse_id] ASC,
	[item_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Wharehouse]    Script Date: 05/03/2021 08:58:51 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Wharehouse](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[address] [nvarchar](max) NOT NULL,
	[employee_id] [int] NOT NULL,
 CONSTRAINT [PK_Wharehouse] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Inovice_Items]  WITH CHECK ADD  CONSTRAINT [FK_Inovice_Items_Item] FOREIGN KEY([product_id])
REFERENCES [dbo].[Item] ([Code])
GO
ALTER TABLE [dbo].[Inovice_Items] CHECK CONSTRAINT [FK_Inovice_Items_Item]
GO
ALTER TABLE [dbo].[Inovice_Items]  WITH CHECK ADD  CONSTRAINT [FK_Inovice_Items_Payment_Order] FOREIGN KEY([order_number])
REFERENCES [dbo].[Payment_Order] ([number])
GO
ALTER TABLE [dbo].[Inovice_Items] CHECK CONSTRAINT [FK_Inovice_Items_Payment_Order]
GO
ALTER TABLE [dbo].[Inovice_Items]  WITH CHECK ADD  CONSTRAINT [FK_Inovice_Items_SupplyingOrder] FOREIGN KEY([supplyingOrder_id])
REFERENCES [dbo].[SupplyingOrder] ([number])
GO
ALTER TABLE [dbo].[Inovice_Items] CHECK CONSTRAINT [FK_Inovice_Items_SupplyingOrder]
GO
ALTER TABLE [dbo].[Item_Units]  WITH CHECK ADD  CONSTRAINT [FK_Item_Units_Item] FOREIGN KEY([Item_Code])
REFERENCES [dbo].[Item] ([Code])
GO
ALTER TABLE [dbo].[Item_Units] CHECK CONSTRAINT [FK_Item_Units_Item]
GO
ALTER TABLE [dbo].[Item_Units]  WITH CHECK ADD  CONSTRAINT [FK_Item_Units_Unit] FOREIGN KEY([Unit_ID])
REFERENCES [dbo].[Unit] ([ID])
GO
ALTER TABLE [dbo].[Item_Units] CHECK CONSTRAINT [FK_Item_Units_Unit]
GO
ALTER TABLE [dbo].[Payment_Order]  WITH CHECK ADD  CONSTRAINT [FK_Payment_Order_Customer] FOREIGN KEY([customer_id])
REFERENCES [dbo].[Customer] ([id])
GO
ALTER TABLE [dbo].[Payment_Order] CHECK CONSTRAINT [FK_Payment_Order_Customer]
GO
ALTER TABLE [dbo].[SupplyingOrder]  WITH CHECK ADD  CONSTRAINT [FK_SupplyingOrder_Provider] FOREIGN KEY([supplier_id])
REFERENCES [dbo].[Provider] ([id])
GO
ALTER TABLE [dbo].[SupplyingOrder] CHECK CONSTRAINT [FK_SupplyingOrder_Provider]
GO
ALTER TABLE [dbo].[SupplyingOrder]  WITH CHECK ADD  CONSTRAINT [FK_SupplyingOrder_Wharehouse] FOREIGN KEY([warehouse_id])
REFERENCES [dbo].[Wharehouse] ([ID])
GO
ALTER TABLE [dbo].[SupplyingOrder] CHECK CONSTRAINT [FK_SupplyingOrder_Wharehouse]
GO
ALTER TABLE [dbo].[SupplyingOrder_Items]  WITH CHECK ADD  CONSTRAINT [FK_SupplyingOrder_Items_Item] FOREIGN KEY([item_code])
REFERENCES [dbo].[Item] ([Code])
GO
ALTER TABLE [dbo].[SupplyingOrder_Items] CHECK CONSTRAINT [FK_SupplyingOrder_Items_Item]
GO
ALTER TABLE [dbo].[SupplyingOrder_Items]  WITH CHECK ADD  CONSTRAINT [FK_SupplyingOrder_Items_SupplyingOrder] FOREIGN KEY([order_number])
REFERENCES [dbo].[SupplyingOrder] ([number])
GO
ALTER TABLE [dbo].[SupplyingOrder_Items] CHECK CONSTRAINT [FK_SupplyingOrder_Items_SupplyingOrder]
GO
ALTER TABLE [dbo].[Transaction]  WITH CHECK ADD  CONSTRAINT [FK_Transaction_Item] FOREIGN KEY([item_id])
REFERENCES [dbo].[Item] ([Code])
GO
ALTER TABLE [dbo].[Transaction] CHECK CONSTRAINT [FK_Transaction_Item]
GO
ALTER TABLE [dbo].[Transaction]  WITH CHECK ADD  CONSTRAINT [FK_Transaction_Payment_Order] FOREIGN KEY([paymentOrderId])
REFERENCES [dbo].[Payment_Order] ([number])
GO
ALTER TABLE [dbo].[Transaction] CHECK CONSTRAINT [FK_Transaction_Payment_Order]
GO
ALTER TABLE [dbo].[Transaction]  WITH CHECK ADD  CONSTRAINT [FK_Transaction_SupplyingOrder] FOREIGN KEY([order_id])
REFERENCES [dbo].[SupplyingOrder] ([number])
GO
ALTER TABLE [dbo].[Transaction] CHECK CONSTRAINT [FK_Transaction_SupplyingOrder]
GO
ALTER TABLE [dbo].[Transaction]  WITH CHECK ADD  CONSTRAINT [FK_Transaction_Transaction] FOREIGN KEY([move_from_transaction_id])
REFERENCES [dbo].[Transaction] ([id])
GO
ALTER TABLE [dbo].[Transaction] CHECK CONSTRAINT [FK_Transaction_Transaction]
GO
ALTER TABLE [dbo].[Transaction]  WITH CHECK ADD  CONSTRAINT [FK_Transaction_Transaction_Type] FOREIGN KEY([type_id])
REFERENCES [dbo].[Transaction_Type] ([id])
GO
ALTER TABLE [dbo].[Transaction] CHECK CONSTRAINT [FK_Transaction_Transaction_Type]
GO
ALTER TABLE [dbo].[Transaction]  WITH CHECK ADD  CONSTRAINT [FK_Transaction_Wharehouse] FOREIGN KEY([wharehouse_id])
REFERENCES [dbo].[Wharehouse] ([ID])
GO
ALTER TABLE [dbo].[Transaction] CHECK CONSTRAINT [FK_Transaction_Wharehouse]
GO
ALTER TABLE [dbo].[WarehouseItems]  WITH CHECK ADD  CONSTRAINT [FK_WarehouseItems_Item] FOREIGN KEY([item_id])
REFERENCES [dbo].[Item] ([Code])
GO
ALTER TABLE [dbo].[WarehouseItems] CHECK CONSTRAINT [FK_WarehouseItems_Item]
GO
ALTER TABLE [dbo].[WarehouseItems]  WITH CHECK ADD  CONSTRAINT [FK_WarehouseItems_SupplyingOrder] FOREIGN KEY([order_id])
REFERENCES [dbo].[SupplyingOrder] ([number])
GO
ALTER TABLE [dbo].[WarehouseItems] CHECK CONSTRAINT [FK_WarehouseItems_SupplyingOrder]
GO
ALTER TABLE [dbo].[WarehouseItems]  WITH CHECK ADD  CONSTRAINT [FK_WarehouseItems_Wharehouse] FOREIGN KEY([warehouse_id])
REFERENCES [dbo].[Wharehouse] ([ID])
GO
ALTER TABLE [dbo].[WarehouseItems] CHECK CONSTRAINT [FK_WarehouseItems_Wharehouse]
GO
ALTER TABLE [dbo].[Wharehouse]  WITH CHECK ADD  CONSTRAINT [FK_Wharehouse_Employee] FOREIGN KEY([employee_id])
REFERENCES [dbo].[Employee] ([id])
GO
ALTER TABLE [dbo].[Wharehouse] CHECK CONSTRAINT [FK_Wharehouse_Employee]
GO
USE [master]
GO
ALTER DATABASE [WharehouseManagementDB] SET  READ_WRITE 
GO
