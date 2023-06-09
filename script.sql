USE [master]
GO
/****** Object:  Database [Ecommerce]    Script Date: 01/05/2023 03:28:09 ص ******/
CREATE DATABASE [Ecommerce]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Ecommerce', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Ecommerce.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Ecommerce_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Ecommerce_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Ecommerce] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Ecommerce].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Ecommerce] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Ecommerce] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Ecommerce] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Ecommerce] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Ecommerce] SET ARITHABORT OFF 
GO
ALTER DATABASE [Ecommerce] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Ecommerce] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Ecommerce] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Ecommerce] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Ecommerce] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Ecommerce] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Ecommerce] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Ecommerce] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Ecommerce] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Ecommerce] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Ecommerce] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Ecommerce] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Ecommerce] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Ecommerce] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Ecommerce] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Ecommerce] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [Ecommerce] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Ecommerce] SET RECOVERY FULL 
GO
ALTER DATABASE [Ecommerce] SET  MULTI_USER 
GO
ALTER DATABASE [Ecommerce] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Ecommerce] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Ecommerce] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Ecommerce] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Ecommerce] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Ecommerce] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Ecommerce', N'ON'
GO
ALTER DATABASE [Ecommerce] SET QUERY_STORE = ON
GO
ALTER DATABASE [Ecommerce] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Ecommerce]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 01/05/2023 03:28:09 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Addresses]    Script Date: 01/05/2023 03:28:10 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Addresses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Unit_Number] [int] NOT NULL,
	[Street_Number] [int] NOT NULL,
	[Address_line1] [nvarchar](max) NOT NULL,
	[Address_line2] [nvarchar](max) NOT NULL,
	[City] [nvarchar](max) NOT NULL,
	[Region] [nvarchar](max) NOT NULL,
	[Postal_Code] [int] NOT NULL,
	[IsDefault] [bit] NOT NULL,
	[Country_Id] [int] NOT NULL,
	[UserId] [nvarchar](450) NULL,
 CONSTRAINT [PK_Addresses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ApplicationUserProduct]    Script Date: 01/05/2023 03:28:10 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ApplicationUserProduct](
	[ApplicationUsersId] [nvarchar](450) NOT NULL,
	[ProductsId] [int] NOT NULL,
 CONSTRAINT [PK_ApplicationUserProduct] PRIMARY KEY CLUSTERED 
(
	[ApplicationUsersId] ASC,
	[ProductsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 01/05/2023 03:28:10 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 01/05/2023 03:28:10 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 01/05/2023 03:28:10 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 01/05/2023 03:28:10 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 01/05/2023 03:28:10 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 01/05/2023 03:28:10 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 01/05/2023 03:28:10 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CartProducts]    Script Date: 01/05/2023 03:28:10 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CartProducts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Quantity] [int] NOT NULL,
	[ApplicationUserId] [nvarchar](450) NOT NULL,
	[ProductItemId] [int] NOT NULL,
 CONSTRAINT [PK_CartProducts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 01/05/2023 03:28:10 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Countries]    Script Date: 01/05/2023 03:28:10 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Country_Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Coupons]    Script Date: 01/05/2023 03:28:10 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Coupons](
	[Name] [nvarchar](450) NOT NULL,
	[Reduction] [real] NOT NULL,
	[ExpirationDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Coupons] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderLines]    Script Date: 01/05/2023 03:28:10 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderLines](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductItemId] [int] NOT NULL,
	[OrderId] [int] NOT NULL,
	[Qty] [int] NOT NULL,
	[Price] [real] NOT NULL,
 CONSTRAINT [PK_OrderLines] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderStatus]    Script Date: 01/05/2023 03:28:10 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderStatus](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Status] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_OrderStatus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentMethods]    Script Date: 01/05/2023 03:28:10 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentMethods](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[PaymentTypeId] [int] NOT NULL,
	[Provider] [nvarchar](max) NULL,
	[AccountNumber] [float] NOT NULL,
	[ExpiryDate] [nvarchar](max) NULL,
	[IsDefault] [bit] NOT NULL,
 CONSTRAINT [PK_PaymentMethods] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentTypes]    Script Date: 01/05/2023 03:28:10 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Value] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_PaymentTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductConfigurations]    Script Date: 01/05/2023 03:28:10 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductConfigurations](
	[ProductItemId] [int] NOT NULL,
	[VariationOptionsId] [int] NOT NULL,
 CONSTRAINT [PK_ProductConfigurations] PRIMARY KEY CLUSTERED 
(
	[ProductItemId] ASC,
	[VariationOptionsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductItems]    Script Date: 01/05/2023 03:28:10 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductItems](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SKU] [nvarchar](max) NOT NULL,
	[StockQty] [int] NOT NULL,
	[Image] [nvarchar](max) NULL,
	[Price] [real] NOT NULL,
	[ProductId] [int] NOT NULL,
 CONSTRAINT [PK_ProductItems] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 01/05/2023 03:28:10 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Image] [nvarchar](max) NOT NULL,
	[Star] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Review]    Script Date: 01/05/2023 03:28:10 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Review](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Comment] [nvarchar](max) NOT NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[Rating] [int] NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ProductId] [int] NOT NULL,
 CONSTRAINT [PK_Review] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShippingMethods]    Script Date: 01/05/2023 03:28:10 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShippingMethods](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Price] [real] NOT NULL,
 CONSTRAINT [PK_ShippingMethods] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShopOrders]    Script Date: 01/05/2023 03:28:10 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShopOrders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[OrderDate] [datetime2](7) NOT NULL,
	[ShippingAddressId] [int] NOT NULL,
	[ShippingMethodId] [int] NOT NULL,
	[OrderTotal] [real] NOT NULL,
	[OrderStatusId] [int] NOT NULL,
	[SessionId] [nvarchar](max) NULL,
	[paymentIntentId] [nvarchar](max) NULL,
 CONSTRAINT [PK_ShopOrders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VariationOptions]    Script Date: 01/05/2023 03:28:10 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VariationOptions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Value] [nvarchar](max) NOT NULL,
	[VariationId] [int] NOT NULL,
 CONSTRAINT [PK_VariationOptions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Variations]    Script Date: 01/05/2023 03:28:10 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Variations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[CategoryId] [int] NOT NULL,
 CONSTRAINT [PK_Variations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230430210901_mig1', N'7.0.5')
GO
SET IDENTITY_INSERT [dbo].[Addresses] ON 

INSERT [dbo].[Addresses] ([Id], [Unit_Number], [Street_Number], [Address_line1], [Address_line2], [City], [Region], [Postal_Code], [IsDefault], [Country_Id], [UserId]) VALUES (1, 6, 63, N'Mohamed Ali', N'ElHaram', N'Giza', N'ElHaram', 25698, 1, 51, N'fb44506f-3732-46e4-a203-df6dc96b5212')
INSERT [dbo].[Addresses] ([Id], [Unit_Number], [Street_Number], [Address_line1], [Address_line2], [City], [Region], [Postal_Code], [IsDefault], [Country_Id], [UserId]) VALUES (2, 9, 86, N'El Huda', N'Abbas ElAqad', N'cairo', N'Naser City', 56847, 0, 51, N'fb44506f-3732-46e4-a203-df6dc96b5212')
INSERT [dbo].[Addresses] ([Id], [Unit_Number], [Street_Number], [Address_line1], [Address_line2], [City], [Region], [Postal_Code], [IsDefault], [Country_Id], [UserId]) VALUES (3, 12, 12, N'flat', N'flat', N'mansoura', N'mansoura', 12345, 1, 51, N'c21a139d-4475-4515-9964-f7d0a68ea948')
SET IDENTITY_INSERT [dbo].[Addresses] OFF
GO
INSERT [dbo].[ApplicationUserProduct] ([ApplicationUsersId], [ProductsId]) VALUES (N'c21a139d-4475-4515-9964-f7d0a68ea948', 1)
INSERT [dbo].[ApplicationUserProduct] ([ApplicationUsersId], [ProductsId]) VALUES (N'fb44506f-3732-46e4-a203-df6dc96b5212', 1)
INSERT [dbo].[ApplicationUserProduct] ([ApplicationUsersId], [ProductsId]) VALUES (N'c21a139d-4475-4515-9964-f7d0a68ea948', 2)
INSERT [dbo].[ApplicationUserProduct] ([ApplicationUsersId], [ProductsId]) VALUES (N'fb44506f-3732-46e4-a203-df6dc96b5212', 6)
INSERT [dbo].[ApplicationUserProduct] ([ApplicationUsersId], [ProductsId]) VALUES (N'fb44506f-3732-46e4-a203-df6dc96b5212', 10)
INSERT [dbo].[ApplicationUserProduct] ([ApplicationUsersId], [ProductsId]) VALUES (N'fb44506f-3732-46e4-a203-df6dc96b5212', 43)
GO
INSERT [dbo].[AspNetUserLogins] ([LoginProvider], [ProviderKey], [ProviderDisplayName], [UserId]) VALUES (N'Google', N'113301521928819505040', N'Google', N'fb44506f-3732-46e4-a203-df6dc96b5212')
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'c21a139d-4475-4515-9964-f7d0a68ea948', N'Cristine', N'CRISTINE', N'c@gmail.com', N'C@GMAIL.COM', 0, N'AQAAAAIAAYagAAAAEMd4yeW5n4lrlZWpcrMxW5OAQXgUNDWSwlfRVlt2X5JWEKwYqJqseG8AhwKyS2Y6LA==', N'C2C3YKSOMGBESSG6VQ3HMZVPAJ4UBI2S', N'32d50816-7779-48b3-b95f-141bb227fa22', N'0100000000', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'fb44506f-3732-46e4-a203-df6dc96b5212', N'Mahmoud', N'MAHMOUD', N'mahmoudsofan0@gmail.com', N'MAHMOUDSOFAN0@GMAIL.COM', 0, NULL, N'X7KICE3V6WNVMBR6YED6DUGHN6UUUMAZ', N'd4760f33-62ec-45ef-b976-90cc408cfa07', NULL, 0, 0, NULL, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[CartProducts] ON 

INSERT [dbo].[CartProducts] ([Id], [Quantity], [ApplicationUserId], [ProductItemId]) VALUES (6, 2, N'fb44506f-3732-46e4-a203-df6dc96b5212', 1)
INSERT [dbo].[CartProducts] ([Id], [Quantity], [ApplicationUserId], [ProductItemId]) VALUES (7, 3, N'fb44506f-3732-46e4-a203-df6dc96b5212', 39)
INSERT [dbo].[CartProducts] ([Id], [Quantity], [ApplicationUserId], [ProductItemId]) VALUES (8, 2, N'fb44506f-3732-46e4-a203-df6dc96b5212', 174)
INSERT [dbo].[CartProducts] ([Id], [Quantity], [ApplicationUserId], [ProductItemId]) VALUES (9, 1, N'c21a139d-4475-4515-9964-f7d0a68ea948', 8)
SET IDENTITY_INSERT [dbo].[CartProducts] OFF
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [Name]) VALUES (1, N'T-shirt')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (2, N'trousers ')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (3, N'Shoes')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (4, N'Socks')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (5, N'Watch')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (7, N'Washer')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (8, N'Fryer')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (9, N'Phone')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Countries] ON 

INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (1, N'Afghanistan')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (2, N'Albania')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (3, N'Algeria')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (4, N'Andorra')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (5, N'Angola')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (6, N'Antigua and Barbuda')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (7, N'Argentina')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (8, N'Armenia')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (9, N'Austria')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (10, N'Azerbaijan')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (11, N'Bahrain')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (12, N'Bangladesh')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (13, N'Barbados')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (14, N'Belarus')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (15, N'Belgium')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (16, N'Belize')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (17, N'Benin')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (18, N'Bhutan')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (19, N'Bolivia')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (20, N'Bosnia and Herzegovina')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (21, N'Botswana')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (22, N'Brazil')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (23, N'Brunei')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (24, N'Bulgaria')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (25, N'Burkina Faso')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (26, N'Burundi')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (27, N'Cabo Verde')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (28, N'Cambodia')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (29, N'Cameroon')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (30, N'Canada')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (31, N'Central African Republic')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (32, N'Chad')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (33, N'Channel Islands')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (34, N'Chile')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (35, N'China')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (36, N'Colombia')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (37, N'Comoros')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (38, N'Congo')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (39, N'Costa Rica')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (40, N'Côte d''Ivoire')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (41, N'Croatia')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (42, N'Cuba')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (43, N'Cyprus')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (44, N'Czech Republic')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (45, N'Denmark')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (46, N'Djibouti')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (47, N'Dominica')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (48, N'Dominican Republic')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (49, N'DR Congo')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (50, N'Ecuador')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (51, N'Egypt')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (52, N'El Salvador')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (53, N'Equatorial Guinea')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (54, N'Eritrea')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (55, N'Estonia')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (56, N'Eswatini')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (57, N'Ethiopia')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (58, N'Faeroe Islands')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (59, N'Finland')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (60, N'France')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (61, N'French Guiana')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (62, N'Gabon')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (63, N'Gambia')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (64, N'Georgia')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (65, N'Germany')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (66, N'Ghana')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (67, N'Gibraltar')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (68, N'Greece')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (69, N'Grenada')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (70, N'Guatemala')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (71, N'Guinea')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (72, N'Guinea-Bissau')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (73, N'Guyana')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (74, N'Haiti')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (75, N'Holy See')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (76, N'Honduras')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (77, N'Hong Kong')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (78, N'Hungary')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (79, N'Iceland')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (80, N'India')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (81, N'Indonesia')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (82, N'Iran')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (83, N'Iraq')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (84, N'Ireland')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (85, N'Isle of Man')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (86, N'Israel')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (87, N'Italy')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (88, N'Jamaica')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (89, N'Japan')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (90, N'Jordan')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (91, N'Kazakhstan')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (92, N'Kenya')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (93, N'Kuwait')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (94, N'Kyrgyzstan')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (95, N'Laos')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (96, N'Latvia')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (97, N'Lebanon')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (98, N'Lesotho')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (99, N'Liberia')
GO
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (100, N'Libya')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (101, N'Liechtenstein')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (102, N'Lithuania')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (103, N'Luxembourg')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (104, N'Macao')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (105, N'Madagascar')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (106, N'Malawi')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (107, N'Malaysia')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (108, N'Maldives')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (109, N'Mali')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (110, N'Malta')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (111, N'Mauritania')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (112, N'Mauritius')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (113, N'Mayotte')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (114, N'Mexico')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (115, N'Moldova')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (116, N'Monaco')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (117, N'Mongolia')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (118, N'Montenegro')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (119, N'Morocco')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (120, N'Mozambique')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (121, N'Myanmar')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (122, N'Namibia')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (123, N'Nepal')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (124, N'Netherlands')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (125, N'Nicaragua')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (126, N'Niger')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (127, N'Nigeria')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (128, N'North Korea')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (129, N'North Macedonia')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (130, N'Norway')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (131, N'Oman')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (132, N'Pakistan')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (133, N'Panama')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (134, N'Paraguay')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (135, N'Peru')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (136, N'Philippines')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (137, N'Poland')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (138, N'Portugal')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (139, N'Qatar')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (140, N'Réunion')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (141, N'Romania')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (142, N'Russia')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (143, N'Rwanda')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (144, N'Saint Helena')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (145, N'Saint Kitts and Nevis')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (146, N'Saint Lucia')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (147, N'Saint Vincent and the Grenadines')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (148, N'San Marino')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (149, N'Sao Tome & Principe')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (150, N'Saudi Arabia')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (151, N'Senegal')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (152, N'Serbia')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (153, N'Seychelles')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (154, N'Sierra Leone')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (155, N'Singapore')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (156, N'Slovakia')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (157, N'Slovenia')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (158, N'Somalia')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (159, N'South Africa')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (160, N'South Korea')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (161, N'South Sudan')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (162, N'Spain')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (163, N'Sri Lanka')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (164, N'State of Palestine')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (165, N'Sudan')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (166, N'Suriname')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (167, N'Sweden')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (168, N'Switzerland')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (169, N'Syria')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (170, N'Taiwan')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (171, N'Tajikistan')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (172, N'Tanzania')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (173, N'Thailand')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (174, N'The Bahamas')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (175, N'Timor-Leste')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (176, N'Togo')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (177, N'Trinidad and Tobago')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (178, N'Tunisia')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (179, N'Turkey')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (180, N'Turkmenistan')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (181, N'Uganda')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (182, N'Ukraine')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (183, N'United Arab Emirates')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (184, N'United Kingdom')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (185, N'United States')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (186, N'Uruguay')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (187, N'Uzbekistan')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (188, N'Venezuela')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (189, N'Vietnam')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (190, N'Western Sahara')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (191, N'Yemen')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (192, N'Zambia')
INSERT [dbo].[Countries] ([Id], [Country_Name]) VALUES (193, N'Zimbabwe')
SET IDENTITY_INSERT [dbo].[Countries] OFF
GO
INSERT [dbo].[Coupons] ([Name], [Reduction], [ExpirationDate]) VALUES (N'BIGTREAT', 0.25, CAST(N'2022-12-03T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Coupons] ([Name], [Reduction], [ExpirationDate]) VALUES (N'FREESHIPPING', 0.3, CAST(N'2025-12-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Coupons] ([Name], [Reduction], [ExpirationDate]) VALUES (N'SPOOKY15', 0.15, CAST(N'2025-12-02T00:00:00.0000000' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[OrderStatus] ON 

INSERT [dbo].[OrderStatus] ([Id], [Status]) VALUES (1, N'Pending')
INSERT [dbo].[OrderStatus] ([Id], [Status]) VALUES (2, N'Processing')
INSERT [dbo].[OrderStatus] ([Id], [Status]) VALUES (3, N'Shipped')
INSERT [dbo].[OrderStatus] ([Id], [Status]) VALUES (4, N'Delivered')
INSERT [dbo].[OrderStatus] ([Id], [Status]) VALUES (5, N'Returned')
INSERT [dbo].[OrderStatus] ([Id], [Status]) VALUES (6, N'Cancelled')
INSERT [dbo].[OrderStatus] ([Id], [Status]) VALUES (7, N'On Hold')
SET IDENTITY_INSERT [dbo].[OrderStatus] OFF
GO
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (1, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (2, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (5, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (6, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (9, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (10, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (13, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (14, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (17, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (18, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (21, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (22, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (25, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (26, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (29, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (30, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (33, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (34, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (37, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (38, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (41, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (42, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (45, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (46, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (49, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (50, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (53, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (54, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (57, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (58, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (61, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (62, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (65, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (66, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (69, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (70, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (73, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (74, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (77, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (78, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (81, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (82, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (85, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (86, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (89, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (90, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (93, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (94, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (97, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (98, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (101, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (102, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (105, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (106, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (109, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (110, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (113, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (114, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (117, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (118, 1)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (3, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (4, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (7, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (8, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (11, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (12, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (15, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (16, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (19, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (20, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (23, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (24, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (27, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (28, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (31, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (32, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (35, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (36, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (39, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (40, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (43, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (44, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (47, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (48, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (51, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (52, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (55, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (56, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (59, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (60, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (63, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (64, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (67, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (68, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (71, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (72, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (75, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (76, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (79, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (80, 2)
GO
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (83, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (84, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (87, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (88, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (91, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (92, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (95, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (96, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (99, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (100, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (103, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (104, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (107, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (108, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (111, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (112, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (115, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (116, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (119, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (120, 2)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (1, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (3, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (5, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (7, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (9, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (11, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (13, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (15, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (17, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (19, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (21, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (23, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (25, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (27, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (29, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (31, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (33, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (35, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (37, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (39, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (41, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (43, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (45, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (47, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (49, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (51, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (53, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (55, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (57, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (59, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (61, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (63, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (65, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (67, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (69, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (71, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (73, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (75, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (77, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (79, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (81, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (83, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (85, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (87, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (89, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (91, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (93, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (95, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (97, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (99, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (101, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (103, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (105, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (107, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (109, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (111, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (113, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (115, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (117, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (119, 3)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (2, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (4, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (6, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (8, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (10, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (12, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (14, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (16, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (18, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (20, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (22, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (24, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (26, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (28, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (30, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (32, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (34, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (36, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (38, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (40, 4)
GO
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (42, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (44, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (46, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (48, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (50, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (52, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (54, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (56, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (58, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (60, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (62, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (64, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (66, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (68, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (70, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (72, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (74, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (76, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (78, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (80, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (82, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (84, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (86, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (88, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (90, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (92, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (94, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (96, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (98, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (100, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (102, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (104, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (106, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (108, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (110, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (112, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (114, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (116, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (118, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (120, 4)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (130, 5)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (133, 5)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (136, 5)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (139, 5)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (142, 5)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (145, 5)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (148, 5)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (151, 5)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (154, 5)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (157, 5)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (160, 5)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (163, 5)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (166, 5)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (169, 5)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (172, 5)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (184, 5)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (187, 5)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (190, 5)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (131, 6)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (134, 6)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (137, 6)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (140, 6)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (143, 6)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (146, 6)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (149, 6)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (152, 6)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (155, 6)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (158, 6)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (161, 6)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (164, 6)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (167, 6)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (170, 6)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (173, 6)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (176, 6)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (179, 6)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (182, 6)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (185, 6)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (188, 6)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (191, 6)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (194, 6)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (197, 6)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (200, 6)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (212, 6)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (215, 6)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (218, 6)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (221, 6)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (224, 6)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (228, 6)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (123, 7)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (126, 7)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (129, 7)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (132, 7)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (135, 7)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (138, 7)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (141, 7)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (144, 7)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (147, 7)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (150, 7)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (153, 7)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (156, 7)
GO
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (159, 7)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (162, 7)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (165, 7)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (168, 7)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (171, 7)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (174, 7)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (177, 7)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (180, 7)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (183, 7)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (186, 7)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (189, 7)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (192, 7)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (195, 7)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (198, 7)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (201, 7)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (204, 7)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (207, 7)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (210, 7)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (213, 7)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (216, 7)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (219, 7)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (222, 7)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (225, 7)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (122, 8)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (125, 8)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (128, 8)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (175, 8)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (178, 8)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (181, 8)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (193, 8)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (196, 8)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (199, 8)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (203, 8)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (206, 8)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (209, 8)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (211, 8)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (214, 8)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (217, 8)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (220, 8)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (223, 8)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (227, 8)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (121, 9)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (124, 9)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (127, 9)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (202, 9)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (205, 9)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (208, 9)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (133, 10)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (134, 10)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (135, 10)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (142, 10)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (143, 10)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (144, 10)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (151, 10)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (152, 10)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (153, 10)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (160, 10)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (161, 10)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (162, 10)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (169, 10)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (170, 10)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (171, 10)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (178, 10)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (179, 10)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (180, 10)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (187, 10)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (188, 10)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (189, 10)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (196, 10)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (197, 10)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (198, 10)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (214, 10)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (215, 10)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (216, 10)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (224, 10)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (225, 10)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (226, 10)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (121, 11)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (122, 11)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (123, 11)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (130, 11)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (131, 11)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (132, 11)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (139, 11)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (140, 11)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (141, 11)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (148, 11)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (149, 11)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (150, 11)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (157, 11)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (158, 11)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (159, 11)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (166, 11)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (167, 11)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (168, 11)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (175, 11)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (176, 11)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (177, 11)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (184, 11)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (185, 11)
GO
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (186, 11)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (193, 11)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (194, 11)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (195, 11)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (202, 11)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (203, 11)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (204, 11)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (211, 11)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (212, 11)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (213, 11)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (221, 11)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (222, 11)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (223, 11)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (124, 12)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (125, 12)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (126, 12)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (145, 12)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (146, 12)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (147, 12)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (154, 12)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (155, 12)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (156, 12)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (163, 12)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (164, 12)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (165, 12)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (172, 12)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (173, 12)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (174, 12)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (181, 12)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (182, 12)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (183, 12)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (190, 12)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (191, 12)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (192, 12)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (199, 12)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (200, 12)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (201, 12)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (205, 12)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (206, 12)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (207, 12)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (217, 12)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (218, 12)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (219, 12)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (227, 12)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (228, 12)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (127, 14)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (128, 14)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (129, 14)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (136, 14)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (137, 14)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (138, 14)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (208, 14)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (209, 14)
INSERT [dbo].[ProductConfigurations] ([ProductItemId], [VariationOptionsId]) VALUES (210, 14)
GO
SET IDENTITY_INSERT [dbo].[ProductItems] ON 

INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (1, N'AmericanEagle-L-Red', 100, N'/Image/Products/1.jpg', 120, 1)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (2, N'AmericanEagle-XL-Red', 50, N'/Image/Products/2.jpg', 100, 1)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (3, N'AmericanEagle-L-Blue', 20, N'/Image/Products/1.jpg', 80, 1)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (4, N'AmericanEagle-XL-Blue', 0, N'/Image/Products/2.jpg', 200, 1)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (5, N'Knight-L-Red', 200, N'/Image/Products/1.jpg', 120, 2)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (6, N'Knight-XL-Red', 300, N'/Image/Products/2.jpg', 100, 2)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (7, N'Knight-L-Blue', 10, N'/Image/Products/1.jpg', 80, 2)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (8, N'Knight-XL-Blue', 60, N'/Image/Products/2.jpg', 200, 2)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (9, N'AmericanEagle-L-Red', 100, N'/Image/Products/1.jpg', 120, 3)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (10, N'AmericanEagle-XL-Red', 50, N'/Image/Products/2.jpg', 100, 3)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (11, N'AmericanEagle-L-Blue', 20, N'/Image/Products/1.jpg', 80, 3)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (12, N'AmericanEagle-XL-Blue', 0, N'/Image/Products/2.jpg', 200, 3)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (13, N'Knight-L-Red', 200, N'/Image/Products/1.jpg', 120, 4)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (14, N'Knight-XL-Red', 300, N'/Image/Products/2.jpg', 100, 4)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (15, N'Knight-L-Blue', 10, N'/Image/Products/1.jpg', 80, 4)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (16, N'Knight-XL-Blue', 60, N'/Image/Products/2.jpg', 200, 4)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (17, N'AmericanEagle-L-Red', 100, N'/Image/Products/1.jpg', 120, 5)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (18, N'AmericanEagle-XL-Red', 50, N'/Image/Products/2.jpg', 100, 5)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (19, N'AmericanEagle-L-Blue', 20, N'/Image/Products/1.jpg', 80, 5)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (20, N'AmericanEagle-XL-Blue', 0, N'/Image/Products/2.jpg', 200, 5)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (21, N'Knight-L-Red', 200, N'/Image/Products/1.jpg', 120, 6)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (22, N'Knight-XL-Red', 300, N'/Image/Products/2.jpg', 100, 6)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (23, N'Knight-L-Blue', 10, N'/Image/Products/1.jpg', 80, 6)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (24, N'Knight-XL-Blue', 60, N'/Image/Products/2.jpg', 200, 6)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (25, N'AmericanEagle-L-Red', 100, N'/Image/Products/1.jpg', 120, 7)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (26, N'AmericanEagle-XL-Red', 50, N'/Image/Products/2.jpg', 100, 7)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (27, N'AmericanEagle-L-Blue', 20, N'/Image/Products/1.jpg', 80, 7)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (28, N'AmericanEagle-XL-Blue', 0, N'/Image/Products/2.jpg', 200, 7)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (29, N'Knight-L-Red', 200, N'/Image/Products/1.jpg', 120, 8)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (30, N'Knight-XL-Red', 300, N'/Image/Products/2.jpg', 100, 8)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (31, N'Knight-L-Blue', 10, N'/Image/Products/1.jpg', 80, 8)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (32, N'Knight-XL-Blue', 60, N'/Image/Products/2.jpg', 200, 8)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (33, N'AmericanEagle-L-Red', 100, N'/Image/Products/1.jpg', 120, 9)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (34, N'AmericanEagle-XL-Red', 50, N'/Image/Products/2.jpg', 100, 9)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (35, N'AmericanEagle-L-Blue', 20, N'/Image/Products/1.jpg', 80, 9)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (36, N'AmericanEagle-XL-Blue', 0, N'/Image/Products/2.jpg', 200, 9)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (37, N'Knight-L-Red', 200, N'/Image/Products/1.jpg', 120, 10)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (38, N'Knight-XL-Red', 300, N'/Image/Products/2.jpg', 100, 10)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (39, N'Knight-L-Blue', 10, N'/Image/Products/1.jpg', 80, 10)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (40, N'Knight-XL-Blue', 60, N'/Image/Products/2.jpg', 200, 10)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (41, N'AmericanEagle-L-Red', 100, N'/Image/Products/1.jpg', 120, 11)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (42, N'AmericanEagle-XL-Red', 50, N'/Image/Products/2.jpg', 100, 11)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (43, N'AmericanEagle-L-Blue', 20, N'/Image/Products/1.jpg', 80, 11)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (44, N'AmericanEagle-XL-Blue', 0, N'/Image/Products/2.jpg', 200, 11)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (45, N'Knight-L-Red', 200, N'/Image/Products/1.jpg', 120, 12)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (46, N'Knight-XL-Red', 300, N'/Image/Products/2.jpg', 100, 12)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (47, N'Knight-L-Blue', 10, N'/Image/Products/1.jpg', 80, 12)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (48, N'Knight-XL-Blue', 60, N'/Image/Products/2.jpg', 200, 12)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (49, N'AmericanEagle-L-Red', 100, N'/Image/Products/1.jpg', 120, 13)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (50, N'AmericanEagle-XL-Red', 50, N'/Image/Products/2.jpg', 100, 13)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (51, N'AmericanEagle-L-Blue', 20, N'/Image/Products/1.jpg', 80, 13)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (52, N'AmericanEagle-XL-Blue', 0, N'/Image/Products/2.jpg', 200, 13)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (53, N'Knight-L-Red', 200, N'/Image/Products/1.jpg', 120, 14)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (54, N'Knight-XL-Red', 300, N'/Image/Products/2.jpg', 100, 14)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (55, N'Knight-L-Blue', 10, N'/Image/Products/1.jpg', 80, 14)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (56, N'Knight-XL-Blue', 60, N'/Image/Products/2.jpg', 200, 14)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (57, N'AmericanEagle-L-Red', 100, N'/Image/Products/1.jpg', 120, 15)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (58, N'AmericanEagle-XL-Red', 50, N'/Image/Products/2.jpg', 100, 15)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (59, N'AmericanEagle-L-Blue', 20, N'/Image/Products/1.jpg', 80, 15)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (60, N'AmericanEagle-XL-Blue', 0, N'/Image/Products/2.jpg', 200, 15)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (61, N'Knight-L-Red', 200, N'/Image/Products/1.jpg', 120, 16)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (62, N'Knight-XL-Red', 300, N'/Image/Products/2.jpg', 100, 16)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (63, N'Knight-L-Blue', 10, N'/Image/Products/1.jpg', 80, 16)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (64, N'Knight-XL-Blue', 60, N'/Image/Products/2.jpg', 200, 16)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (65, N'AmericanEagle-L-Red', 100, N'/Image/Products/1.jpg', 120, 17)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (66, N'AmericanEagle-XL-Red', 50, N'/Image/Products/2.jpg', 100, 17)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (67, N'AmericanEagle-L-Blue', 20, N'/Image/Products/1.jpg', 80, 17)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (68, N'AmericanEagle-XL-Blue', 0, N'/Image/Products/2.jpg', 200, 17)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (69, N'Knight-L-Red', 200, N'/Image/Products/1.jpg', 120, 18)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (70, N'Knight-XL-Red', 300, N'/Image/Products/2.jpg', 100, 18)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (71, N'Knight-L-Blue', 10, N'/Image/Products/1.jpg', 80, 18)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (72, N'Knight-XL-Blue', 60, N'/Image/Products/2.jpg', 200, 18)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (73, N'AmericanEagle-L-Red', 100, N'/Image/Products/1.jpg', 120, 19)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (74, N'AmericanEagle-XL-Red', 50, N'/Image/Products/2.jpg', 100, 19)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (75, N'AmericanEagle-L-Blue', 20, N'/Image/Products/1.jpg', 80, 19)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (76, N'AmericanEagle-XL-Blue', 0, N'/Image/Products/2.jpg', 200, 19)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (77, N'Knight-L-Red', 200, N'/Image/Products/1.jpg', 120, 20)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (78, N'Knight-XL-Red', 300, N'/Image/Products/2.jpg', 100, 20)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (79, N'Knight-L-Blue', 10, N'/Image/Products/1.jpg', 80, 20)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (80, N'Knight-XL-Blue', 60, N'/Image/Products/2.jpg', 200, 20)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (81, N'AmericanEagle-L-Red', 100, N'/Image/Products/1.jpg', 120, 21)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (82, N'AmericanEagle-XL-Red', 50, N'/Image/Products/2.jpg', 100, 21)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (83, N'AmericanEagle-L-Blue', 20, N'/Image/Products/1.jpg', 80, 21)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (84, N'AmericanEagle-XL-Blue', 0, N'/Image/Products/2.jpg', 200, 21)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (85, N'Knight-L-Red', 200, N'/Image/Products/1.jpg', 120, 22)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (86, N'Knight-XL-Red', 300, N'/Image/Products/2.jpg', 100, 22)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (87, N'Knight-L-Blue', 10, N'/Image/Products/1.jpg', 80, 22)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (88, N'Knight-XL-Blue', 60, N'/Image/Products/2.jpg', 200, 22)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (89, N'AmericanEagle-L-Red', 100, N'/Image/Products/1.jpg', 120, 23)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (90, N'AmericanEagle-XL-Red', 50, N'/Image/Products/2.jpg', 100, 23)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (91, N'AmericanEagle-L-Blue', 20, N'/Image/Products/1.jpg', 80, 23)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (92, N'AmericanEagle-XL-Blue', 0, N'/Image/Products/2.jpg', 200, 23)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (93, N'Knight-L-Red', 200, N'/Image/Products/1.jpg', 120, 24)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (94, N'Knight-XL-Red', 300, N'/Image/Products/2.jpg', 100, 24)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (95, N'Knight-L-Blue', 10, N'/Image/Products/1.jpg', 80, 24)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (96, N'Knight-XL-Blue', 60, N'/Image/Products/2.jpg', 200, 24)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (97, N'AmericanEagle-L-Red', 100, N'/Image/Products/1.jpg', 120, 25)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (98, N'AmericanEagle-XL-Red', 50, N'/Image/Products/2.jpg', 100, 25)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (99, N'AmericanEagle-L-Blue', 20, N'/Image/Products/1.jpg', 80, 25)
GO
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (100, N'AmericanEagle-XL-Blue', 0, N'/Image/Products/2.jpg', 200, 25)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (101, N'Knight-L-Red', 200, N'/Image/Products/1.jpg', 120, 26)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (102, N'Knight-XL-Red', 300, N'/Image/Products/2.jpg', 100, 26)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (103, N'Knight-L-Blue', 10, N'/Image/Products/1.jpg', 80, 26)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (104, N'Knight-XL-Blue', 60, N'/Image/Products/2.jpg', 200, 26)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (105, N'AmericanEagle-L-Red', 100, N'/Image/Products/1.jpg', 120, 27)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (106, N'AmericanEagle-XL-Red', 50, N'/Image/Products/2.jpg', 100, 27)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (107, N'AmericanEagle-L-Blue', 20, N'/Image/Products/1.jpg', 80, 27)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (108, N'AmericanEagle-XL-Blue', 0, N'/Image/Products/2.jpg', 200, 27)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (109, N'Knight-L-Red', 200, N'/Image/Products/1.jpg', 120, 28)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (110, N'Knight-XL-Red', 300, N'/Image/Products/2.jpg', 100, 28)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (111, N'Knight-L-Blue', 10, N'/Image/Products/1.jpg', 80, 28)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (112, N'Knight-XL-Blue', 60, N'/Image/Products/2.jpg', 200, 28)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (113, N'AmericanEagle-L-Red', 100, N'/Image/Products/1.jpg', 120, 29)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (114, N'AmericanEagle-XL-Red', 50, N'/Image/Products/2.jpg', 100, 29)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (115, N'AmericanEagle-L-Blue', 20, N'/Image/Products/1.jpg', 80, 29)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (116, N'AmericanEagle-XL-Blue', 0, N'/Image/Products/2.jpg', 200, 29)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (117, N'Knight-L-Red', 200, N'/Image/Products/1.jpg', 120, 30)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (118, N'Knight-XL-Red', 300, N'/Image/Products/2.jpg', 100, 30)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (119, N'Knight-L-Blue', 10, N'/Image/Products/1.jpg', 80, 30)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (120, N'Knight-XL-Blue', 60, N'/Image/Products/2.jpg', 200, 30)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (121, N'Apple iPhone 14 Pro Max-1000-Black', 50, N'/Image/Products/25.jpg', 1500, 38)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (122, N'Apple iPhone 14 Pro Max-500-Black', 120, N'/Image/Products/25.jpg', 1200, 38)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (123, N'Apple iPhone 14 Pro Max-265-Black', 40, N'/Image/Products/25.jpg', 1000, 38)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (124, N'Apple iPhone 14 Pro Max-1000-Gray', 60, N'/Image/Products/25.jpg', 1500, 38)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (125, N'Apple iPhone 14 Pro Max-500-Gray', 8, N'/Image/Products/25.jpg', 1200, 38)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (126, N'Apple iPhone 14 Pro Max-265-Gray', 40, N'/Image/Products/25.jpg', 1000, 38)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (127, N'Apple iPhone 14 Pro Max-1000-Red', 60, N'/Image/Products/25.jpg', 1500, 38)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (128, N'Apple iPhone 14 Pro Max-500-Red', 170, N'/Image/Products/25.jpg', 1200, 38)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (129, N'Apple iPhone 14 Pro Max-265-Red', 200, N'/Image/Products/25.jpg', 1000, 38)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (130, N'Apple iPhone 11-64-Black', 50, N'/Image/Products/26.jpg', 300, 39)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (131, N'Apple iPhone 11-128-Black', 120, N'/Image/Products/26.jpg', 420, 39)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (132, N'Apple iPhone 11-265-Black', 40, N'/Image/Products/26.jpg', 500, 39)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (133, N'Apple iPhone 11-64-Gold', 60, N'/Image/Products/26.jpg', 300, 39)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (134, N'Apple iPhone 11-128-Gold', 8, N'/Image/Products/26.jpg', 420, 39)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (135, N'Apple iPhone 11-265-Gold', 40, N'/Image/Products/26.jpg', 500, 39)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (136, N'Apple iPhone 11-64-Red', 60, N'/Image/Products/26.jpg', 300, 39)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (137, N'Apple iPhone 11-128-Red', 170, N'/Image/Products/26.jpg', 420, 39)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (138, N'Apple iPhone 11-265-Red', 200, N'/Image/Products/26.jpg', 500, 39)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (139, N'Apple iPhone XR-64-Black', 50, N'/Image/Products/27.jpg', 224, 40)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (140, N'Apple iPhone XR-128-Black', 120, N'/Image/Products/27.jpg', 300, 40)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (141, N'Apple iPhone XR-265-Black', 40, N'/Image/Products/27.jpg', 410, 40)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (142, N'Apple iPhone XR-64-Gold', 60, N'/Image/Products/27.jpg', 224, 40)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (143, N'Apple iPhone XR-128-Gold', 8, N'/Image/Products/27.jpg', 300, 40)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (144, N'Apple iPhone XR-265-Gold', 40, N'/Image/Products/27.jpg', 410, 40)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (145, N'Apple iPhone XR-64-Gray', 60, N'/Image/Products/27.jpg', 224, 40)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (146, N'Apple iPhone XR-128-Gray', 170, N'/Image/Products/27.jpg', 300, 40)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (147, N'Apple iPhone XR-265-Gray', 200, N'/Image/Products/27.jpg', 410, 40)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (148, N'Apple iPhone 12 Mini-64-Black', 50, N'/Image/Products/28.jpg', 390, 41)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (149, N'Apple iPhone 12 Mini-128-Black', 120, N'/Image/Products/28.jpg', 450, 41)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (150, N'Apple iPhone 12 Mini-265-Black', 40, N'/Image/Products/28.jpg', 520, 41)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (151, N'Apple iPhone 12 Mini-64-Gold', 60, N'/Image/Products/28.jpg', 390, 41)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (152, N'Apple iPhone 12 Mini-128-Gold', 8, N'/Image/Products/28.jpg', 450, 41)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (153, N'Apple iPhone 12 Mini-265-Gold', 40, N'/Image/Products/28.jpg', 520, 41)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (154, N'Apple iPhone 12 Mini-64-Gray', 60, N'/Image/Products/28.jpg', 390, 41)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (155, N'Apple iPhone 12 Mini-128-Gray', 170, N'/Image/Products/28.jpg', 450, 41)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (156, N'Apple iPhone 12 Mini-265-Gray', 200, N'/Image/Products/28.jpg', 520, 41)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (157, N'Apple iPhone 12-64-Black', 50, N'/Image/Products/29.jpg', 450, 42)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (158, N'Apple iPhone 12 -128-Black', 120, N'/Image/Products/29.jpg', 500, 42)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (159, N'Apple iPhone 12 -265-Black', 40, N'/Image/Products/29.jpg', 550, 42)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (160, N'Apple iPhone 12 -64-Gold', 60, N'/Image/Products/29.jpg', 450, 42)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (161, N'Apple iPhone 12 -128-Gold', 8, N'/Image/Products/29.jpg', 500, 42)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (162, N'Apple iPhone 12 -265-Gold', 40, N'/Image/Products/29.jpg', 550, 42)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (163, N'Apple iPhone 12 -64-Gray', 60, N'/Image/Products/29.jpg', 450, 42)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (164, N'Apple iPhone 12 -128-Gray', 170, N'/Image/Products/29.jpg', 500, 42)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (165, N'Apple iPhone 12 -265-Gray', 200, N'/Image/Products/29.jpg', 550, 42)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (166, N'Apple iPhone XS Max-64-Black', 50, N'/Image/Products/30.jpg', 270, 43)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (167, N'Apple iPhone XS Max -128-Black', 120, N'/Image/Products/30.jpg', 350, 43)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (168, N'Apple iPhone XS Max -265-Black', 40, N'/Image/Products/30.jpg', 430, 43)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (169, N'Apple iPhone XS Max -64-Gold', 60, N'/Image/Products/30.jpg', 270, 43)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (170, N'Apple iPhone XS Max -128-Gold', 8, N'/Image/Products/30.jpg', 350, 43)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (171, N'Apple iPhone XS Max -265-Gold', 40, N'/Image/Products/30.jpg', 430, 43)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (172, N'Apple iPhone XS Max -64-Gray', 60, N'/Image/Products/30.jpg', 270, 43)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (173, N'Apple iPhone XS Max -128-Gray', 170, N'/Image/Products/30.jpg', 350, 43)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (174, N'Apple iPhone XS Max -265-Gray', 200, N'/Image/Products/30.jpg', 430, 43)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (175, N'Apple iPhone 13-512-Black', 50, N'/Image/Products/31.jpg', 668, 44)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (176, N'Apple iPhone 13 -128-Black', 120, N'/Image/Products/31.jpg', 770, 44)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (177, N'Apple iPhone 13 -265-Black', 40, N'/Image/Products/31.jpg', 830, 44)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (178, N'Apple iPhone 13 -512-Gold', 60, N'/Image/Products/31.jpg', 668, 44)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (179, N'Apple iPhone 13 -128-Gold', 8, N'/Image/Products/31.jpg', 770, 44)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (180, N'Apple iPhone 13 -265-Gold', 40, N'/Image/Products/31.jpg', 830, 44)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (181, N'Apple iPhone 13 -512-Gray', 60, N'/Image/Products/31.jpg', 668, 44)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (182, N'Apple iPhone 13 -128-Gray', 170, N'/Image/Products/31.jpg', 770, 44)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (183, N'Apple iPhone 13 -265-Gray', 200, N'/Image/Products/31.jpg', 830, 44)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (184, N'Apple iPhone XS -64-Black', 50, N'/Image/Products/32.jpg', 270, 45)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (185, N'Apple iPhone XS  -128-Black', 120, N'/Image/Products/32.jpg', 350, 45)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (186, N'Apple iPhone XS  -265-Black', 40, N'/Image/Products/32.jpg', 430, 45)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (187, N'Apple iPhone XS  -64-Gold', 60, N'/Image/Products/32.jpg', 270, 45)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (188, N'Apple iPhone XS  -128-Gold', 8, N'/Image/Products/32.jpg', 350, 45)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (189, N'Apple iPhone XS  -265-Gold', 40, N'/Image/Products/32.jpg', 430, 45)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (190, N'Apple iPhone XS  -64-Gray', 60, N'/Image/Products/32.jpg', 270, 45)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (191, N'Apple iPhone XS  -128-Gray', 170, N'/Image/Products/32.jpg', 350, 45)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (192, N'Apple iPhone XS  -265-Gray', 200, N'/Image/Products/32.jpg', 430, 45)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (193, N'Apple iPhone 13 Max-512-Black', 50, N'/Image/Products/33.jpg', 1200, 46)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (194, N'Apple iPhone 13 Max -128-Black', 120, N'/Image/Products/33.jpg', 940, 46)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (195, N'Apple iPhone 13 Max -265-Black', 40, N'/Image/Products/33.jpg', 1050, 46)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (196, N'Apple iPhone 13 Max -512-Gold', 60, N'/Image/Products/33.jpg', 1200, 46)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (197, N'Apple iPhone 13 Max -128-Gold', 8, N'/Image/Products/33.jpg', 940, 46)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (198, N'Apple iPhone 13 Max -265-Gold', 40, N'/Image/Products/33.jpg', 1050, 46)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (199, N'Apple iPhone 13 Max -512-Gray', 60, N'/Image/Products/33.jpg', 1200, 46)
GO
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (200, N'Apple iPhone 13 Max -128-Gray', 170, N'/Image/Products/33.jpg', 940, 46)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (201, N'Apple iPhone 13 Max -265-Gray', 200, N'/Image/Products/33.jpg', 1050, 46)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (202, N'Apple iPhone 14 Pro-1000-Black', 50, N'/Image/Products/34.jpg', 1300, 47)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (203, N'Apple iPhone 14 Pro-500-Black', 120, N'/Image/Products/34.jpg', 1150, 47)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (204, N'Apple iPhone 14 Pro-265-Black', 40, N'/Image/Products/34.jpg', 1000, 47)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (205, N'Apple iPhone 14 Pro-1000-Gray', 60, N'/Image/Products/34.jpg', 1300, 47)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (206, N'Apple iPhone 14 Pro-500-Gray', 8, N'/Image/Products/34.jpg', 1150, 47)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (207, N'Apple iPhone 14 Pro-265-Gray', 40, N'/Image/Products/34.jpg', 1000, 47)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (208, N'Apple iPhone 14 Pro-1000-Red', 60, N'/Image/Products/34.jpg', 1300, 47)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (209, N'Apple iPhone 14 Pro-500-Red', 170, N'/Image/Products/34.jpg', 1150, 47)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (210, N'Apple iPhone 14 Pro-265-Red', 200, N'/Image/Products/34.jpg', 1000, 47)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (211, N'Apple iPhone 13 Pro-512-Black', 50, N'/Image/Products/35.jpg', 980, 48)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (212, N'Apple iPhone 13 Pro -128-Black', 120, N'/Image/Products/35.jpg', 850, 48)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (213, N'Apple iPhone 13 Pro -265-Black', 40, N'/Image/Products/35.jpg', 740, 48)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (214, N'Apple iPhone 13 Pro -512-Gold', 60, N'/Image/Products/35.jpg', 980, 48)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (215, N'Apple iPhone 13 Pro -128-Gold', 8, N'/Image/Products/35.jpg', 850, 48)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (216, N'Apple iPhone 13 Pro -265-Gold', 40, N'/Image/Products/35.jpg', 740, 48)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (217, N'Apple iPhone 13 Pro -512-Gray', 60, N'/Image/Products/35.jpg', 980, 48)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (218, N'Apple iPhone 13 Pro -128-Gray', 170, N'/Image/Products/35.jpg', 850, 48)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (219, N'Apple iPhone 13 Pro -265-Gray', 200, N'/Image/Products/35.jpg', 740, 48)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (220, N'Apple iPhone 12 Pro Max-512-Black', 50, N'/Image/Products/36.jpg', 1150, 49)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (221, N'Apple iPhone 12 Pro Max -128-Black', 120, N'/Image/Products/36.jpg', 850, 49)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (222, N'Apple iPhone 12 Pro Max -265-Black', 40, N'/Image/Products/36.jpg', 800, 49)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (223, N'Apple iPhone 12 Pro Max -512-Gold', 60, N'/Image/Products/36.jpg', 1150, 49)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (224, N'Apple iPhone 12 Pro Max -128-Gold', 8, N'/Image/Products/36.jpg', 850, 49)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (225, N'Apple iPhone 12 Pro Max -265-Gold', 40, N'/Image/Products/36.jpg', 800, 49)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (226, N'Apple iPhone 12 Pro Max -512-Gray', 60, N'/Image/Products/36.jpg', 1150, 49)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (227, N'Apple iPhone 12 Pro Max -128-Gray', 170, N'/Image/Products/36.jpg', 850, 49)
INSERT [dbo].[ProductItems] ([Id], [SKU], [StockQty], [Image], [Price], [ProductId]) VALUES (228, N'Apple iPhone 12 Pro Max -265-Gray', 200, N'/Image/Products/36.jpg', 800, 49)
SET IDENTITY_INSERT [dbo].[ProductItems] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (1, N'American Eagle', N'American Eagle Men U-0181-2395-604 Super Soft Graphic T-Shirt', N'/Image/Products/1.jpg', 5, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (2, N'Knight', N'Knight Mens Stretch Round Neck T-Shirt Half sleeves Kngh Base Layer Top', N'/Image/Products/2.jpg', 3, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (3, N'Hero Basic', N'Hero Basic mens Round Neck Undershirt', N'/Image/Products/3.jpg', 4, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (4, N'Romba', N'Romba Men''s Summer Text Sleeve Cotton T Shirt', N'/Image/Products/4.jpg', 1, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (5, N'Andora', N'Andora Mens 33S22M30333 T-Shirt', N'/Image/Products/5.jpg', 2, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (6, N'CAESAR', N'CAESAR Mens MensSport T-Shirt With Short Sleeves MensSport T-Shirt With Short Sleeves', N'/Image/Products/6.jpg', 5, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (7, N'Nexus', N'Nexus Original Cotton T-Shirt', N'/Image/Products/7.jpg', 3, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (8, N'Ravin EG', N'Ravin EG Mens Ravin Chest Printed Cotton T-Shirt For Men S22M048 T-Shirt', N'/Image/Products/8.jpg', 4, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (9, N'CAESAR', N'CAESAR Mens Mens Printed Round Neck T-Shirt T-Shirt', N'/Image/Products/9.jpg', 1, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (10, N'adidas', N'adidas Mens Train Essentials Seasonal Logo Training T-Shirt TRAINING T-SHIRTS for Men T-Shirt', N'/Image/Products/10.jpg', 2, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (11, N'adidas', N'Adidas linear beach-bit short sleeve graphic t-shirt t-shirts for men', N'/Image/Products/11.jpg', 5, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (12, N'Generic', N'BlackEdition Over size snake T-shirt', N'/Image/Products/12.jpg', 3, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (13, N'American Eagle', N'American Eagle Men U-0181-2395-604 Super Soft Graphic T-Shirt', N'/Image/Products/1.jpg', 4, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (14, N'Knight', N'Knight Mens Stretch Round Neck T-Shirt Half sleeves Kngh Base Layer Top', N'/Image/Products/2.jpg', 1, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (15, N'Hero Basic', N'Hero Basic mens Round Neck Undershirt', N'/Image/Products/3.jpg', 2, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (16, N'Romba', N'Romba Men''s Summer Text Sleeve Cotton T Shirt', N'/Image/Products/4.jpg', 5, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (17, N'Andora', N'Andora Mens 33S22M30333 T-Shirt', N'/Image/Products/5.jpg', 3, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (18, N'CAESAR', N'CAESAR Mens MensSport T-Shirt With Short Sleeves MensSport T-Shirt With Short Sleeves', N'/Image/Products/6.jpg', 4, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (19, N'Nexus', N'Nexus Original Cotton T-Shirt', N'/Image/Products/7.jpg', 1, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (20, N'Ravin EG', N'Ravin EG Mens Ravin Chest Printed Cotton T-Shirt For Men S22M048 T-Shirt', N'/Image/Products/8.jpg', 2, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (21, N'CAESAR', N'CAESAR Mens Mens Printed Round Neck T-Shirt T-Shirt', N'/Image/Products/9.jpg', 5, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (22, N'adidas', N'adidas Mens Train Essentials Seasonal Logo Training T-Shirt TRAINING T-SHIRTS for Men T-Shirt', N'/Image/Products/10.jpg', 3, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (23, N'adidas', N'Adidas linear beach-bit short sleeve graphic t-shirt t-shirts for men', N'/Image/Products/11.jpg', 4, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (24, N'Generic', N'BlackEdition Over size snake T-shirt', N'/Image/Products/12.jpg', 1, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (25, N'American Eagle', N'American Eagle Men U-0181-2395-604 Super Soft Graphic T-Shirt', N'/Image/Products/1.jpg', 2, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (26, N'Knight', N'Knight Mens Stretch Round Neck T-Shirt Half sleeves Kngh Base Layer Top', N'/Image/Products/2.jpg', 5, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (27, N'Hero Basic', N'Hero Basic mens Round Neck Undershirt', N'/Image/Products/3.jpg', 3, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (28, N'Romba', N'Romba Men''s Summer Text Sleeve Cotton T Shirt', N'/Image/Products/4.jpg', 4, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (29, N'Andora', N'Andora Mens 33S22M30333 T-Shirt', N'/Image/Products/5.jpg', 1, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (30, N'CAESAR', N'CAESAR Mens MensSport T-Shirt With Short Sleeves MensSport T-Shirt With Short Sleeves', N'/Image/Products/6.jpg', 2, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (31, N'BLACK TIGER', N'HIGH QUALITY Classic-fit Men''s Pants for Gentleman', N'/Image/Products/13.jpg', 5, 2)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (32, N'Mintra', N'Mintra CAI Women Shoes', N'/Image/Products/14.jpg', 3, 3)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (33, N'STITCH', N'STITCH mens Pack of 5 Lycra Ankle Socks', N'/Image/Products/15.jpg', 4, 4)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (34, N'SEIKO', N'SEIKO QUARTZ Metal Band Analg Watch for Men BLUE Dial SUR399P1', N'/Image/Products/16.jpg', 1, 5)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (36, N'Toshiba - Washing Machine', N'Toshiba - Washing Machine - 8kg - Silver - Inverter - 1400rpm - TW-BJ90M4E(SK)', N'/Image/Products/18.jpg', 5, 7)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (37, N'Nutricook AF357V AIR FRYER', N'Nutricook AF357V AIR FRYER 3 VISION 5.7L 1700W Black clear window - International warranty', N'/Image/Products/19.jpg', 3, 8)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (38, N'Apple iPhone 14 Pro Max', N'Apple iPhone 14 Pro Max, 1TB, Space Black - Unlocked (Renewed Premium)', N'/Image/Products/25.jpg', 4, 9)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (39, N'Apple iPhone 11', N'Apple iPhone 11, 64GB, Black - Unlocked (Renewed)', N'/Image/Products/26.jpg', 1, 9)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (40, N'Apple iPhone XR', N'Apple iPhone XR, 64GB, Black - Unlocked (Renewed)', N'/Image/Products/27.jpg', 2, 9)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (41, N'Apple iPhone 12 Mini', N'Apple iPhone 12 Mini, 64GB, White - Unlocked (Renewed Premium)', N'/Image/Products/28.jpg', 5, 9)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (42, N'Apple iPhone 12', N'Apple iPhone 12, 64GB, Green - Fully Unlocked (Renewed)', N'/Image/Products/29.jpg', 3, 9)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (43, N'Apple iPhone XS Max', N'Apple iPhone XS Max, US Version, 64GB, Space Gray - Unlocked (Renewed)', N'/Image/Products/30.jpg', 4, 9)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (44, N'Apple iPhone 13', N'Apple iPhone 13, 128GB, Product Red - Unlocked (Renewed Premium)', N'/Image/Products/31.jpg', 1, 9)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (45, N'Apple iPhone XS', N'Apple iPhone XS, US Version, 256GB, Space Gray - Unlocked (Renewed)', N'/Image/Products/32.jpg', 2, 9)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (46, N'Apple iPhone 13 Pro Max', N'Apple iPhone 13 Pro Max, 128GB, Sierra Blue - Unlocked (Renewed Premium)', N'/Image/Products/33.jpg', 5, 9)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (47, N'Apple iPhone 14 Pro', N'Apple iPhone 14 Pro, 1TB, Deep Purple - Unlocked (Renewed Premium)', N'/Image/Products/34.jpg', 3, 9)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (48, N'Apple iPhone 13 Pro', N' Apple iPhone 13 Pro, 128GB, Gold - Unlocked (Renewed Premium)', N'/Image/Products/35.jpg', 4, 9)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Image], [Star], [CategoryId]) VALUES (49, N'Apple iPhone 12 Pro Max', N'Apple iPhone 12 Pro Max, 256GB, Pacific Blue - Unlocked (Renewed Premium)
', N'/Image/Products/36.jpg', 1, 9)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[ShippingMethods] ON 

INSERT [dbo].[ShippingMethods] ([Id], [Name], [Price]) VALUES (1, N'Fast', 20)
INSERT [dbo].[ShippingMethods] ([Id], [Name], [Price]) VALUES (2, N'Express', 50)
INSERT [dbo].[ShippingMethods] ([Id], [Name], [Price]) VALUES (3, N'Regular', 10)
SET IDENTITY_INSERT [dbo].[ShippingMethods] OFF
GO
SET IDENTITY_INSERT [dbo].[ShopOrders] ON 

INSERT [dbo].[ShopOrders] ([Id], [UserId], [OrderDate], [ShippingAddressId], [ShippingMethodId], [OrderTotal], [OrderStatusId], [SessionId], [paymentIntentId]) VALUES (1, N'c21a139d-4475-4515-9964-f7d0a68ea948', CAST(N'2023-05-01T02:11:10.0007248' AS DateTime2), 3, 3, 10, 1, N'cs_test_a1BdHUPkedjKJF5NFlSceU52JNlfV6ykGKGXkAFyMSdY7mzrMmAauwoG5N', NULL)
INSERT [dbo].[ShopOrders] ([Id], [UserId], [OrderDate], [ShippingAddressId], [ShippingMethodId], [OrderTotal], [OrderStatusId], [SessionId], [paymentIntentId]) VALUES (2, N'c21a139d-4475-4515-9964-f7d0a68ea948', CAST(N'2023-05-01T02:13:04.5145036' AS DateTime2), 3, 3, 10, 1, N'cs_test_a1C6zMCkbEbAiu8GGBIR0QD6wTuZovH2dFHdKLbaV3krzitpdZv7zsNOep', NULL)
INSERT [dbo].[ShopOrders] ([Id], [UserId], [OrderDate], [ShippingAddressId], [ShippingMethodId], [OrderTotal], [OrderStatusId], [SessionId], [paymentIntentId]) VALUES (3, N'c21a139d-4475-4515-9964-f7d0a68ea948', CAST(N'2023-05-01T02:16:41.4229739' AS DateTime2), 3, 3, 10, 1, N'cs_test_a1lWo9jwbMzMKh1wNzIVn99qfujC9GLI91SF7pwazCW9NSAxOBcg1axiYI', NULL)
INSERT [dbo].[ShopOrders] ([Id], [UserId], [OrderDate], [ShippingAddressId], [ShippingMethodId], [OrderTotal], [OrderStatusId], [SessionId], [paymentIntentId]) VALUES (4, N'c21a139d-4475-4515-9964-f7d0a68ea948', CAST(N'2023-05-01T02:16:45.3781052' AS DateTime2), 3, 3, 10, 1, N'cs_test_a1gpxs2nFXvh9WbG7LAwpXTHLuxy3pEj29tbNML25pELSXC9sd7WiR3IdD', NULL)
INSERT [dbo].[ShopOrders] ([Id], [UserId], [OrderDate], [ShippingAddressId], [ShippingMethodId], [OrderTotal], [OrderStatusId], [SessionId], [paymentIntentId]) VALUES (5, N'c21a139d-4475-4515-9964-f7d0a68ea948', CAST(N'2023-05-01T02:22:06.8313309' AS DateTime2), 3, 3, 10, 1, N'cs_test_b1V4G0YdVSvQYgDpIloSvqYs3A4N9cLX1iVzBvRiM0ZBdsFk8sDdCASKwW', NULL)
INSERT [dbo].[ShopOrders] ([Id], [UserId], [OrderDate], [ShippingAddressId], [ShippingMethodId], [OrderTotal], [OrderStatusId], [SessionId], [paymentIntentId]) VALUES (6, N'c21a139d-4475-4515-9964-f7d0a68ea948', CAST(N'2023-05-01T02:26:40.4928799' AS DateTime2), 3, 3, 10, 1, N'cs_test_b1QUgv70h0u39xhofZafAnG4BjiXEFttoj0hU1Nu1dZgXAMlDNEzdtJTP9', NULL)
INSERT [dbo].[ShopOrders] ([Id], [UserId], [OrderDate], [ShippingAddressId], [ShippingMethodId], [OrderTotal], [OrderStatusId], [SessionId], [paymentIntentId]) VALUES (7, N'c21a139d-4475-4515-9964-f7d0a68ea948', CAST(N'2023-05-01T02:27:00.5344767' AS DateTime2), 3, 3, 10, 1, N'cs_test_b1YzyhkgOwftag3G1gNwqOw6ODaOgyMunEejiSI9Dx2l9QWJwW0W8YITBv', NULL)
INSERT [dbo].[ShopOrders] ([Id], [UserId], [OrderDate], [ShippingAddressId], [ShippingMethodId], [OrderTotal], [OrderStatusId], [SessionId], [paymentIntentId]) VALUES (8, N'c21a139d-4475-4515-9964-f7d0a68ea948', CAST(N'2023-05-01T02:28:16.7254193' AS DateTime2), 3, 3, 10, 1, N'cs_test_b1TB3C2shVqU42SaXAzXnezPQ9QHEfEd4SmdlLgMk8rX4dqvPPX1Fij3mP', NULL)
INSERT [dbo].[ShopOrders] ([Id], [UserId], [OrderDate], [ShippingAddressId], [ShippingMethodId], [OrderTotal], [OrderStatusId], [SessionId], [paymentIntentId]) VALUES (9, N'c21a139d-4475-4515-9964-f7d0a68ea948', CAST(N'2023-05-01T02:28:51.9555094' AS DateTime2), 3, 3, 10, 1, N'cs_test_b1ESYPeQeOSDcL3gxkidnOLrhJkULeUvTTohYGPOGcVYdz9kofJCGpdKgp', NULL)
INSERT [dbo].[ShopOrders] ([Id], [UserId], [OrderDate], [ShippingAddressId], [ShippingMethodId], [OrderTotal], [OrderStatusId], [SessionId], [paymentIntentId]) VALUES (10, N'c21a139d-4475-4515-9964-f7d0a68ea948', CAST(N'2023-05-01T02:29:37.8457780' AS DateTime2), 3, 3, 10, 1, N'cs_test_b1x8dtQLGkalTnpPUBSUgBVEZRQ1YxvkAUqnGohZUHROD2zX8gW4Od6geF', NULL)
INSERT [dbo].[ShopOrders] ([Id], [UserId], [OrderDate], [ShippingAddressId], [ShippingMethodId], [OrderTotal], [OrderStatusId], [SessionId], [paymentIntentId]) VALUES (11, N'c21a139d-4475-4515-9964-f7d0a68ea948', CAST(N'2023-05-01T02:31:00.7391581' AS DateTime2), 3, 3, 10, 1, N'cs_test_b1aCKLd39Ajs7oSIV9Py0Ka7OG3mxvo2kSzwVFewahXauk1fBcbF0oJI74', NULL)
INSERT [dbo].[ShopOrders] ([Id], [UserId], [OrderDate], [ShippingAddressId], [ShippingMethodId], [OrderTotal], [OrderStatusId], [SessionId], [paymentIntentId]) VALUES (12, N'c21a139d-4475-4515-9964-f7d0a68ea948', CAST(N'2023-05-01T02:32:57.0090856' AS DateTime2), 3, 3, 10, 2, N'cs_test_b1s7JI0C0MSLr3WppCSd3BmHij6AEK2vVNYOktAYx9kugAJ5QFqBo9Zl6B', NULL)
INSERT [dbo].[ShopOrders] ([Id], [UserId], [OrderDate], [ShippingAddressId], [ShippingMethodId], [OrderTotal], [OrderStatusId], [SessionId], [paymentIntentId]) VALUES (13, N'c21a139d-4475-4515-9964-f7d0a68ea948', CAST(N'2023-05-01T02:51:19.1878199' AS DateTime2), 3, 3, 10, 2, N'cs_test_b1mafDPS2w08jBMbcZDP36xbf5q2XWaHo2APepbg5K4ityzQ9DlAi49qKC', NULL)
INSERT [dbo].[ShopOrders] ([Id], [UserId], [OrderDate], [ShippingAddressId], [ShippingMethodId], [OrderTotal], [OrderStatusId], [SessionId], [paymentIntentId]) VALUES (14, N'c21a139d-4475-4515-9964-f7d0a68ea948', CAST(N'2023-05-01T02:54:46.4682635' AS DateTime2), 3, 3, 10, 2, N'cs_test_b1p5KB85R2UVPV2ApprKhyDNjEXcuWUsdwGjx440iwNVD1WN8jvupN4Obv', NULL)
INSERT [dbo].[ShopOrders] ([Id], [UserId], [OrderDate], [ShippingAddressId], [ShippingMethodId], [OrderTotal], [OrderStatusId], [SessionId], [paymentIntentId]) VALUES (15, N'c21a139d-4475-4515-9964-f7d0a68ea948', CAST(N'2023-05-01T03:20:04.7277687' AS DateTime2), 3, 2, 190, 2, N'cs_test_b1fOADr9FvRcAL6Rmb7bKozmiBRyazJgrhpUth8G6ko9tSdRtX8psQeZlm', NULL)
SET IDENTITY_INSERT [dbo].[ShopOrders] OFF
GO
SET IDENTITY_INSERT [dbo].[VariationOptions] ON 

INSERT [dbo].[VariationOptions] ([Id], [Value], [VariationId]) VALUES (1, N'Red', 1)
INSERT [dbo].[VariationOptions] ([Id], [Value], [VariationId]) VALUES (2, N'Blue', 1)
INSERT [dbo].[VariationOptions] ([Id], [Value], [VariationId]) VALUES (3, N'L', 2)
INSERT [dbo].[VariationOptions] ([Id], [Value], [VariationId]) VALUES (4, N'XL', 2)
INSERT [dbo].[VariationOptions] ([Id], [Value], [VariationId]) VALUES (5, N'64', 4)
INSERT [dbo].[VariationOptions] ([Id], [Value], [VariationId]) VALUES (6, N'128', 4)
INSERT [dbo].[VariationOptions] ([Id], [Value], [VariationId]) VALUES (7, N'265', 4)
INSERT [dbo].[VariationOptions] ([Id], [Value], [VariationId]) VALUES (8, N'512', 4)
INSERT [dbo].[VariationOptions] ([Id], [Value], [VariationId]) VALUES (9, N'1000', 4)
INSERT [dbo].[VariationOptions] ([Id], [Value], [VariationId]) VALUES (10, N'Gold', 3)
INSERT [dbo].[VariationOptions] ([Id], [Value], [VariationId]) VALUES (11, N'Black', 3)
INSERT [dbo].[VariationOptions] ([Id], [Value], [VariationId]) VALUES (12, N'Gray', 3)
INSERT [dbo].[VariationOptions] ([Id], [Value], [VariationId]) VALUES (13, N'Pacific blue', 3)
INSERT [dbo].[VariationOptions] ([Id], [Value], [VariationId]) VALUES (14, N'Red', 3)
SET IDENTITY_INSERT [dbo].[VariationOptions] OFF
GO
SET IDENTITY_INSERT [dbo].[Variations] ON 

INSERT [dbo].[Variations] ([Id], [Name], [CategoryId]) VALUES (1, N'Color', 1)
INSERT [dbo].[Variations] ([Id], [Name], [CategoryId]) VALUES (2, N'Size', 1)
INSERT [dbo].[Variations] ([Id], [Name], [CategoryId]) VALUES (3, N'Color', 9)
INSERT [dbo].[Variations] ([Id], [Name], [CategoryId]) VALUES (4, N'Space', 9)
SET IDENTITY_INSERT [dbo].[Variations] OFF
GO
/****** Object:  Index [IX_Addresses_Country_Id]    Script Date: 01/05/2023 03:28:10 ص ******/
CREATE NONCLUSTERED INDEX [IX_Addresses_Country_Id] ON [dbo].[Addresses]
(
	[Country_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Addresses_UserId]    Script Date: 01/05/2023 03:28:10 ص ******/
CREATE NONCLUSTERED INDEX [IX_Addresses_UserId] ON [dbo].[Addresses]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ApplicationUserProduct_ProductsId]    Script Date: 01/05/2023 03:28:10 ص ******/
CREATE NONCLUSTERED INDEX [IX_ApplicationUserProduct_ProductsId] ON [dbo].[ApplicationUserProduct]
(
	[ProductsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 01/05/2023 03:28:10 ص ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 01/05/2023 03:28:10 ص ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 01/05/2023 03:28:10 ص ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 01/05/2023 03:28:10 ص ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 01/05/2023 03:28:10 ص ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 01/05/2023 03:28:10 ص ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 01/05/2023 03:28:10 ص ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_CartProducts_ApplicationUserId]    Script Date: 01/05/2023 03:28:10 ص ******/
CREATE NONCLUSTERED INDEX [IX_CartProducts_ApplicationUserId] ON [dbo].[CartProducts]
(
	[ApplicationUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CartProducts_ProductItemId]    Script Date: 01/05/2023 03:28:10 ص ******/
CREATE NONCLUSTERED INDEX [IX_CartProducts_ProductItemId] ON [dbo].[CartProducts]
(
	[ProductItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderLines_OrderId]    Script Date: 01/05/2023 03:28:10 ص ******/
CREATE NONCLUSTERED INDEX [IX_OrderLines_OrderId] ON [dbo].[OrderLines]
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderLines_ProductItemId]    Script Date: 01/05/2023 03:28:10 ص ******/
CREATE NONCLUSTERED INDEX [IX_OrderLines_ProductItemId] ON [dbo].[OrderLines]
(
	[ProductItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_PaymentMethods_PaymentTypeId]    Script Date: 01/05/2023 03:28:10 ص ******/
CREATE NONCLUSTERED INDEX [IX_PaymentMethods_PaymentTypeId] ON [dbo].[PaymentMethods]
(
	[PaymentTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_PaymentMethods_UserId]    Script Date: 01/05/2023 03:28:10 ص ******/
CREATE NONCLUSTERED INDEX [IX_PaymentMethods_UserId] ON [dbo].[PaymentMethods]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductConfigurations_VariationOptionsId]    Script Date: 01/05/2023 03:28:10 ص ******/
CREATE NONCLUSTERED INDEX [IX_ProductConfigurations_VariationOptionsId] ON [dbo].[ProductConfigurations]
(
	[VariationOptionsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductItems_ProductId]    Script Date: 01/05/2023 03:28:10 ص ******/
CREATE NONCLUSTERED INDEX [IX_ProductItems_ProductId] ON [dbo].[ProductItems]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Products_CategoryId]    Script Date: 01/05/2023 03:28:10 ص ******/
CREATE NONCLUSTERED INDEX [IX_Products_CategoryId] ON [dbo].[Products]
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Review_ProductId]    Script Date: 01/05/2023 03:28:10 ص ******/
CREATE NONCLUSTERED INDEX [IX_Review_ProductId] ON [dbo].[Review]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Review_UserId]    Script Date: 01/05/2023 03:28:10 ص ******/
CREATE NONCLUSTERED INDEX [IX_Review_UserId] ON [dbo].[Review]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ShopOrders_OrderStatusId]    Script Date: 01/05/2023 03:28:10 ص ******/
CREATE NONCLUSTERED INDEX [IX_ShopOrders_OrderStatusId] ON [dbo].[ShopOrders]
(
	[OrderStatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ShopOrders_ShippingAddressId]    Script Date: 01/05/2023 03:28:10 ص ******/
CREATE NONCLUSTERED INDEX [IX_ShopOrders_ShippingAddressId] ON [dbo].[ShopOrders]
(
	[ShippingAddressId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ShopOrders_ShippingMethodId]    Script Date: 01/05/2023 03:28:10 ص ******/
CREATE NONCLUSTERED INDEX [IX_ShopOrders_ShippingMethodId] ON [dbo].[ShopOrders]
(
	[ShippingMethodId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_ShopOrders_UserId]    Script Date: 01/05/2023 03:28:10 ص ******/
CREATE NONCLUSTERED INDEX [IX_ShopOrders_UserId] ON [dbo].[ShopOrders]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_VariationOptions_VariationId]    Script Date: 01/05/2023 03:28:10 ص ******/
CREATE NONCLUSTERED INDEX [IX_VariationOptions_VariationId] ON [dbo].[VariationOptions]
(
	[VariationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Variations_CategoryId]    Script Date: 01/05/2023 03:28:10 ص ******/
CREATE NONCLUSTERED INDEX [IX_Variations_CategoryId] ON [dbo].[Variations]
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Addresses]  WITH CHECK ADD  CONSTRAINT [FK_Addresses_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Addresses] CHECK CONSTRAINT [FK_Addresses_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Addresses]  WITH CHECK ADD  CONSTRAINT [FK_Addresses_Countries_Country_Id] FOREIGN KEY([Country_Id])
REFERENCES [dbo].[Countries] ([Id])
GO
ALTER TABLE [dbo].[Addresses] CHECK CONSTRAINT [FK_Addresses_Countries_Country_Id]
GO
ALTER TABLE [dbo].[ApplicationUserProduct]  WITH CHECK ADD  CONSTRAINT [FK_ApplicationUserProduct_AspNetUsers_ApplicationUsersId] FOREIGN KEY([ApplicationUsersId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[ApplicationUserProduct] CHECK CONSTRAINT [FK_ApplicationUserProduct_AspNetUsers_ApplicationUsersId]
GO
ALTER TABLE [dbo].[ApplicationUserProduct]  WITH CHECK ADD  CONSTRAINT [FK_ApplicationUserProduct_Products_ProductsId] FOREIGN KEY([ProductsId])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[ApplicationUserProduct] CHECK CONSTRAINT [FK_ApplicationUserProduct_Products_ProductsId]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[CartProducts]  WITH CHECK ADD  CONSTRAINT [FK_CartProducts_AspNetUsers_ApplicationUserId] FOREIGN KEY([ApplicationUserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[CartProducts] CHECK CONSTRAINT [FK_CartProducts_AspNetUsers_ApplicationUserId]
GO
ALTER TABLE [dbo].[CartProducts]  WITH CHECK ADD  CONSTRAINT [FK_CartProducts_ProductItems_ProductItemId] FOREIGN KEY([ProductItemId])
REFERENCES [dbo].[ProductItems] ([Id])
GO
ALTER TABLE [dbo].[CartProducts] CHECK CONSTRAINT [FK_CartProducts_ProductItems_ProductItemId]
GO
ALTER TABLE [dbo].[OrderLines]  WITH CHECK ADD  CONSTRAINT [FK_OrderLines_ProductItems_ProductItemId] FOREIGN KEY([ProductItemId])
REFERENCES [dbo].[ProductItems] ([Id])
GO
ALTER TABLE [dbo].[OrderLines] CHECK CONSTRAINT [FK_OrderLines_ProductItems_ProductItemId]
GO
ALTER TABLE [dbo].[OrderLines]  WITH CHECK ADD  CONSTRAINT [FK_OrderLines_ShopOrders_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[ShopOrders] ([Id])
GO
ALTER TABLE [dbo].[OrderLines] CHECK CONSTRAINT [FK_OrderLines_ShopOrders_OrderId]
GO
ALTER TABLE [dbo].[PaymentMethods]  WITH CHECK ADD  CONSTRAINT [FK_PaymentMethods_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[PaymentMethods] CHECK CONSTRAINT [FK_PaymentMethods_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[PaymentMethods]  WITH CHECK ADD  CONSTRAINT [FK_PaymentMethods_PaymentTypes_PaymentTypeId] FOREIGN KEY([PaymentTypeId])
REFERENCES [dbo].[PaymentTypes] ([Id])
GO
ALTER TABLE [dbo].[PaymentMethods] CHECK CONSTRAINT [FK_PaymentMethods_PaymentTypes_PaymentTypeId]
GO
ALTER TABLE [dbo].[ProductConfigurations]  WITH CHECK ADD  CONSTRAINT [FK_ProductConfigurations_ProductItems_ProductItemId] FOREIGN KEY([ProductItemId])
REFERENCES [dbo].[ProductItems] ([Id])
GO
ALTER TABLE [dbo].[ProductConfigurations] CHECK CONSTRAINT [FK_ProductConfigurations_ProductItems_ProductItemId]
GO
ALTER TABLE [dbo].[ProductConfigurations]  WITH CHECK ADD  CONSTRAINT [FK_ProductConfigurations_VariationOptions_VariationOptionsId] FOREIGN KEY([VariationOptionsId])
REFERENCES [dbo].[VariationOptions] ([Id])
GO
ALTER TABLE [dbo].[ProductConfigurations] CHECK CONSTRAINT [FK_ProductConfigurations_VariationOptions_VariationOptionsId]
GO
ALTER TABLE [dbo].[ProductItems]  WITH CHECK ADD  CONSTRAINT [FK_ProductItems_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[ProductItems] CHECK CONSTRAINT [FK_ProductItems_Products_ProductId]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([Id])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories_CategoryId]
GO
ALTER TABLE [dbo].[Review]  WITH CHECK ADD  CONSTRAINT [FK_Review_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Review] CHECK CONSTRAINT [FK_Review_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Review]  WITH CHECK ADD  CONSTRAINT [FK_Review_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[Review] CHECK CONSTRAINT [FK_Review_Products_ProductId]
GO
ALTER TABLE [dbo].[ShopOrders]  WITH CHECK ADD  CONSTRAINT [FK_ShopOrders_Addresses_ShippingAddressId] FOREIGN KEY([ShippingAddressId])
REFERENCES [dbo].[Addresses] ([Id])
GO
ALTER TABLE [dbo].[ShopOrders] CHECK CONSTRAINT [FK_ShopOrders_Addresses_ShippingAddressId]
GO
ALTER TABLE [dbo].[ShopOrders]  WITH CHECK ADD  CONSTRAINT [FK_ShopOrders_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[ShopOrders] CHECK CONSTRAINT [FK_ShopOrders_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[ShopOrders]  WITH CHECK ADD  CONSTRAINT [FK_ShopOrders_OrderStatus_OrderStatusId] FOREIGN KEY([OrderStatusId])
REFERENCES [dbo].[OrderStatus] ([Id])
GO
ALTER TABLE [dbo].[ShopOrders] CHECK CONSTRAINT [FK_ShopOrders_OrderStatus_OrderStatusId]
GO
ALTER TABLE [dbo].[ShopOrders]  WITH CHECK ADD  CONSTRAINT [FK_ShopOrders_ShippingMethods_ShippingMethodId] FOREIGN KEY([ShippingMethodId])
REFERENCES [dbo].[ShippingMethods] ([Id])
GO
ALTER TABLE [dbo].[ShopOrders] CHECK CONSTRAINT [FK_ShopOrders_ShippingMethods_ShippingMethodId]
GO
ALTER TABLE [dbo].[VariationOptions]  WITH CHECK ADD  CONSTRAINT [FK_VariationOptions_Variations_VariationId] FOREIGN KEY([VariationId])
REFERENCES [dbo].[Variations] ([Id])
GO
ALTER TABLE [dbo].[VariationOptions] CHECK CONSTRAINT [FK_VariationOptions_Variations_VariationId]
GO
ALTER TABLE [dbo].[Variations]  WITH CHECK ADD  CONSTRAINT [FK_Variations_Categories_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([Id])
GO
ALTER TABLE [dbo].[Variations] CHECK CONSTRAINT [FK_Variations_Categories_CategoryId]
GO
USE [master]
GO
ALTER DATABASE [Ecommerce] SET  READ_WRITE 
GO
