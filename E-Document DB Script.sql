USE [master]
GO
/****** Object:  Database [E-Document]    Script Date: 9/15/2023 10:02:18 AM ******/
CREATE DATABASE [E-Document]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'E-Document', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\E-Document.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'E-Document_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\E-Document_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [E-Document] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [E-Document].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [E-Document] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [E-Document] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [E-Document] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [E-Document] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [E-Document] SET ARITHABORT OFF 
GO
ALTER DATABASE [E-Document] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [E-Document] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [E-Document] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [E-Document] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [E-Document] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [E-Document] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [E-Document] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [E-Document] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [E-Document] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [E-Document] SET  ENABLE_BROKER 
GO
ALTER DATABASE [E-Document] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [E-Document] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [E-Document] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [E-Document] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [E-Document] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [E-Document] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [E-Document] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [E-Document] SET RECOVERY FULL 
GO
ALTER DATABASE [E-Document] SET  MULTI_USER 
GO
ALTER DATABASE [E-Document] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [E-Document] SET DB_CHAINING OFF 
GO
ALTER DATABASE [E-Document] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [E-Document] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [E-Document] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [E-Document] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'E-Document', N'ON'
GO
ALTER DATABASE [E-Document] SET QUERY_STORE = OFF
GO
USE [E-Document]
GO
/****** Object:  Schema [security]    Script Date: 9/15/2023 10:02:19 AM ******/
CREATE SCHEMA [security]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 9/15/2023 10:02:19 AM ******/
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
/****** Object:  Table [dbo].[ApplicationItAdmin]    Script Date: 9/15/2023 10:02:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ApplicationItAdmin](
	[ItAdminId] [nvarchar](50) NOT NULL,
	[ApplicationId] [bigint] NOT NULL,
 CONSTRAINT [PK_ApplicationItAdmin] PRIMARY KEY CLUSTERED 
(
	[ItAdminId] ASC,
	[ApplicationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ApplicationUserRequest]    Script Date: 9/15/2023 10:02:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ApplicationUserRequest](
	[BeneficiaryId] [nvarchar](50) NOT NULL,
	[RequestId] [bigint] NOT NULL,
	[CreatedAt] [smalldatetime] NULL,
	[ModifiedAt] [smalldatetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[ModifiedBy] [nvarchar](50) NULL,
	[BeneficiaryName] [nvarchar](200) NOT NULL,
	[BeneficiaryEmail] [nvarchar](50) NULL,
	[BeneficiaryPostion] [nvarchar](200) NULL,
	[BeneficiaryDepartment] [nvarchar](200) NULL,
	[BeneficiaryPhone] [nvarchar](50) NOT NULL,
	[BeneficiaryExtention] [nvarchar](50) NULL,
 CONSTRAINT [PK_ApplicationUserRequest] PRIMARY KEY CLUSTERED 
(
	[BeneficiaryId] ASC,
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Attachment]    Script Date: 9/15/2023 10:02:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Attachment](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[FilePath] [nvarchar](max) NOT NULL,
	[RequestId] [bigint] NOT NULL,
	[CreatedAt] [smalldatetime] NULL,
	[ModifiedAt] [smalldatetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[ModifiedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_Attachment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarRequest]    Script Date: 9/15/2023 10:02:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarRequest](
	[BeneficiaryId] [nvarchar](50) NOT NULL,
	[RequestId] [bigint] NOT NULL,
	[DepartureAddress] [nvarchar](50) NOT NULL,
	[DestinationAddress] [nvarchar](50) NOT NULL,
	[DepartureDate] [smalldatetime] NOT NULL,
	[RetrunDate] [smalldatetime] NOT NULL,
	[LuggageDescription] [nvarchar](max) NOT NULL,
	[VehicleType] [nvarchar](50) NOT NULL,
	[CreatedAt] [smalldatetime] NULL,
	[ModifiedAt] [smalldatetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[ModifiedBy] [nvarchar](50) NULL,
	[BeneficiaryName] [nvarchar](200) NOT NULL,
	[BeneficiaryEmail] [nvarchar](50) NULL,
	[BeneficiaryPostion] [nvarchar](200) NULL,
	[BeneficiaryDepartment] [nvarchar](200) NULL,
	[BeneficiaryPhone] [nvarchar](50) NOT NULL,
	[BeneficiaryExtention] [nvarchar](50) NULL,
 CONSTRAINT [PK_CarRequest] PRIMARY KEY CLUSTERED 
(
	[BeneficiaryId] ASC,
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DefinedApplication]    Script Date: 9/15/2023 10:02:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DefinedApplication](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ApplicationName] [nvarchar](200) NOT NULL,
	[ApplicationOwnerId] [nvarchar](50) NOT NULL,
	[CreatedAt] [smalldatetime] NULL,
	[ModifiedAt] [smalldatetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[ModifiedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_DefinedApplication] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DefinedApplicationRole]    Script Date: 9/15/2023 10:02:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DefinedApplicationRole](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](50) NOT NULL,
	[RequestedApplicationId] [bigint] NOT NULL,
	[CreatedAt] [smalldatetime] NULL,
	[ModifiedAt] [smalldatetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[ModifiedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_DefinedApplicationRole] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DefinedRequest]    Script Date: 9/15/2023 10:02:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DefinedRequest](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[RequestName] [nvarchar](50) NOT NULL,
	[RouteName] [nvarchar](50) NOT NULL,
	[ReviewersNumber] [int] NOT NULL,
	[DepartmentId] [bigint] NOT NULL,
	[CreatedAt] [smalldatetime] NULL,
	[ModifiedAt] [smalldatetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[ModifiedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_DefinedRequest] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DefinedRequestReviewer]    Script Date: 9/15/2023 10:02:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DefinedRequestReviewer](
	[DefinedRequestId] [bigint] NOT NULL,
	[ReviewerId] [nvarchar](50) NOT NULL,
	[StageName] [nvarchar](50) NULL,
	[StageNumber] [int] NOT NULL,
	[ReviewerType] [nvarchar](50) NOT NULL,
	[CreatedAt] [smalldatetime] NULL,
	[ModifiedAt] [smalldatetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[ModifiedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_DefinedRequestReviewer] PRIMARY KEY CLUSTERED 
(
	[DefinedRequestId] ASC,
	[ReviewerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DefinedRequestRole]    Script Date: 9/15/2023 10:02:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DefinedRequestRole](
	[RoleId] [nvarchar](450) NOT NULL,
	[DefinedRequestId] [bigint] NOT NULL,
	[CreatedAt] [smalldatetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[ModifiedAt] [smalldatetime] NULL,
	[ModifiedBy] [nvarchar](50) NULL,
	[Permission] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_DefinedRequestRole] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC,
	[DefinedRequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 9/15/2023 10:02:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[Id] [bigint] NOT NULL,
	[DepartmentName] [nvarchar](200) NOT NULL,
	[ManagerId] [nvarchar](50) NOT NULL,
	[CreatedAt] [smalldatetime] NULL,
	[ModifiedAt] [smalldatetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[ModifiedBy] [nvarchar](50) NULL,
	[DepartmentIcon] [nvarchar](max) NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DomainAccountRequest]    Script Date: 9/15/2023 10:02:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DomainAccountRequest](
	[BeneficiaryId] [nvarchar](50) NOT NULL,
	[RequestId] [bigint] NOT NULL,
	[DisplayName] [nvarchar](50) NULL,
	[LoginName] [nvarchar](50) NULL,
	[OU] [nvarchar](50) NULL,
	[CreatedAt] [smalldatetime] NULL,
	[ModifiedAt] [smalldatetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[ModifiedBy] [nvarchar](50) NULL,
	[BeneficiaryName] [nvarchar](200) NOT NULL,
	[BeneficiaryEmail] [nvarchar](50) NULL,
	[BeneficiaryPostion] [nvarchar](200) NULL,
	[BeneficiaryDepartment] [nvarchar](200) NULL,
	[BeneficiaryPhone] [nvarchar](50) NOT NULL,
	[BeneficiaryExtention] [nvarchar](50) NULL,
 CONSTRAINT [PK_DomainAccountRequest] PRIMARY KEY CLUSTERED 
(
	[BeneficiaryId] ASC,
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PoRequest]    Script Date: 9/15/2023 10:02:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PoRequest](
	[PoNumber] [nvarchar](450) NOT NULL,
	[PoDescription] [nvarchar](450) NOT NULL,
	[VendorName] [nvarchar](450) NOT NULL,
	[VendorNumber] [nvarchar](450) NOT NULL,
	[InvoiceNumber] [nvarchar](450) NOT NULL,
	[PoAttachmentPath] [nvarchar](max) NOT NULL,
	[InvoiceAttachmentPath] [nvarchar](max) NOT NULL,
	[RequestId] [bigint] NOT NULL,
	[CreatedAt] [smalldatetime] NULL,
	[ModifiedAt] [smalldatetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[ModifiedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_PoRequest] PRIMARY KEY CLUSTERED 
(
	[PoNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Request]    Script Date: 9/15/2023 10:02:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Request](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CurrentStage] [int] NULL,
	[Status] [nvarchar](50) NOT NULL,
	[Justification] [nvarchar](max) NULL,
	[CreatorId] [nvarchar](50) NOT NULL,
	[DeclinedBy] [nvarchar](200) NULL,
	[DefinedRequestId] [bigint] NOT NULL,
	[CreatedAt] [smalldatetime] NULL,
	[ModifiedAt] [smalldatetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[ModifiedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_Request] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RequestApplicationRole]    Script Date: 9/15/2023 10:02:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RequestApplicationRole](
	[RequestId] [bigint] NOT NULL,
	[ApplicationId] [bigint] NOT NULL,
	[RoleId] [bigint] NOT NULL,
	[CreatedAt] [smalldatetime] NULL,
	[ModifiedAt] [smalldatetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[ModifiedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_RequestApplicationRole] PRIMARY KEY CLUSTERED 
(
	[RequestId] ASC,
	[ApplicationId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RequestReviewer]    Script Date: 9/15/2023 10:02:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RequestReviewer](
	[RequestId] [bigint] NOT NULL,
	[ReviewerId] [nvarchar](50) NOT NULL,
	[StageName] [nvarchar](max) NULL,
	[StageNumber] [int] NOT NULL,
	[ReviewerType] [nvarchar](max) NULL,
	[Status] [nvarchar](50) NOT NULL,
	[ReviewerNotes] [nvarchar](max) NULL,
	[CreatedAt] [smalldatetime] NULL,
	[ModifiedAt] [smalldatetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[ModifiedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_RequestReviewer] PRIMARY KEY CLUSTERED 
(
	[RequestId] ASC,
	[ReviewerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Section]    Script Date: 9/15/2023 10:02:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Section](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[SectionName] [nvarchar](max) NULL,
	[DepartmentId] [bigint] NOT NULL,
	[HeadId] [nvarchar](50) NOT NULL,
	[CreatedAt] [smalldatetime] NULL,
	[ModifiedAt] [smalldatetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[ModifiedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_Section] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TravelDeskRequest]    Script Date: 9/15/2023 10:02:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TravelDeskRequest](
	[BeneficiaryId] [nvarchar](50) NOT NULL,
	[RequestId] [bigint] NOT NULL,
	[RequestTypes] [nvarchar](200) NOT NULL,
	[BeneficiaryNationality] [nvarchar](50) NOT NULL,
	[CostAllocation] [real] NOT NULL,
	[Currency] [nvarchar](50) NOT NULL,
	[CheckIn] [smalldatetime] NULL,
	[CheckOut] [smalldatetime] NULL,
	[MissionAddress] [nvarchar](max) NULL,
	[PaymentMethod] [nvarchar](50) NULL,
	[FlightOrigin] [nvarchar](50) NULL,
	[FlightDestination] [nvarchar](50) NULL,
	[DepartureDate] [smalldatetime] NULL,
	[ReturnDate] [smalldatetime] NULL,
	[DestinationCountry] [nvarchar](50) NULL,
	[ExpectedTravelTime] [smalldatetime] NULL,
	[CreatedAt] [smalldatetime] NULL,
	[ModifiedAt] [smalldatetime] NULL,
	[CreatedBy] [varchar](50) NULL,
	[ModifiedBy] [varchar](50) NULL,
	[BeneficiaryName] [nvarchar](200) NOT NULL,
	[BeneficiaryEmail] [nvarchar](50) NULL,
	[BeneficiaryPostion] [nvarchar](200) NULL,
	[BeneficiaryDepartment] [nvarchar](200) NULL,
	[BeneficiaryPhone] [nvarchar](50) NULL,
	[BeneficiaryExtention] [nvarchar](50) NULL,
 CONSTRAINT [PK_TravelDeskRequest] PRIMARY KEY CLUSTERED 
(
	[BeneficiaryId] ASC,
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VoucherRequest]    Script Date: 9/15/2023 10:02:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VoucherRequest](
	[BeneficiaryName] [nvarchar](450) NOT NULL,
	[RequestId] [bigint] NOT NULL,
	[VendorNumber] [nvarchar](max) NULL,
	[VendorName] [nvarchar](max) NULL,
	[InvoiceDate] [date] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[VoucherAmount] [real] NOT NULL,
	[VoucherCurrency] [nvarchar](max) NOT NULL,
	[VoucherType] [nvarchar](max) NULL,
	[CreatedAt] [smalldatetime] NULL,
	[ModifiedAt] [smalldatetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[ModifiedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_VoucherRequest] PRIMARY KEY CLUSTERED 
(
	[BeneficiaryName] ASC,
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [security].[Role]    Script Date: 9/15/2023 10:02:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [security].[Role](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [security].[RoleClaims]    Script Date: 9/15/2023 10:02:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [security].[RoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_RoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [security].[User]    Script Date: 9/15/2023 10:02:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [security].[User](
	[Id] [nvarchar](50) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[NormalizedUserName] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](200) NULL,
	[FullName] [nvarchar](200) NOT NULL,
	[Position] [nvarchar](200) NULL,
	[DepartmentId] [bigint] NULL,
	[SectionId] [bigint] NULL,
	[ManagerId] [nvarchar](50) NULL,
	[Company] [nvarchar](200) NULL,
	[LastLogin] [smalldatetime] NULL,
	[CreatedAt] [smalldatetime] NULL,
	[ModifiedAt] [smalldatetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[ModifiedBy] [nvarchar](50) NULL,
	[NormalizedEmail] [nvarchar](200) NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](50) NOT NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[IsEmployee] [bit] NOT NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [security].[UserClaims]    Script Date: 9/15/2023 10:02:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [security].[UserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](50) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_UserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [security].[UserLogin]    Script Date: 9/15/2023 10:02:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [security].[UserLogin](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_UserLogin] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [security].[UserRoles]    Script Date: 9/15/2023 10:02:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [security].[UserRoles](
	[UserId] [nvarchar](50) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_UserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [security].[UserToken]    Script Date: 9/15/2023 10:02:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [security].[UserToken](
	[UserId] [nvarchar](50) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_UserToken] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230912004818_initialMigration', N'7.0.10')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230913065346_addIsEmployee', N'7.0.10')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230913065807_getDefaultColumnsBack', N'7.0.10')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230913083802_update', N'7.0.10')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230913184024_refactorRequestRole', N'7.0.10')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230914050009_makePhoneNumberNotNull', N'7.0.10')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230914062409_replaceIconColumnPlace', N'7.0.10')
GO
SET IDENTITY_INSERT [dbo].[DefinedRequest] ON 
GO
INSERT [dbo].[DefinedRequest] ([Id], [RequestName], [RouteName], [ReviewersNumber], [DepartmentId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (1, N'Voucher', N'/HR/Voucher/', 5, 3, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[DefinedRequest] ([Id], [RequestName], [RouteName], [ReviewersNumber], [DepartmentId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (3, N'Equipment Requeset', N'/Operations/EquipmentRequest/', 3, 4, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[DefinedRequest] ([Id], [RequestName], [RouteName], [ReviewersNumber], [DepartmentId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (5, N'PO', N'/Finance/Po/', 2, 2, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[DefinedRequest] ([Id], [RequestName], [RouteName], [ReviewersNumber], [DepartmentId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (6, N'Domain Account', N'/IT/DomainAccount/', 4, 1, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[DefinedRequest] ([Id], [RequestName], [RouteName], [ReviewersNumber], [DepartmentId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (7, N'DB User', N'/IT/DbUser/', 3, 1, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[DefinedRequest] ([Id], [RequestName], [RouteName], [ReviewersNumber], [DepartmentId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (8, N'DR Drill', N'/IT/DrDrill/', 3, 1, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[DefinedRequest] OFF
GO
INSERT [dbo].[DefinedRequestRole] ([RoleId], [DefinedRequestId], [CreatedAt], [CreatedBy], [ModifiedAt], [ModifiedBy], [Permission]) VALUES (N'7a49542e-e22b-4c5c-84ad-0bfc7ce71cab', 3, NULL, NULL, NULL, NULL, N'All')
GO
INSERT [dbo].[DefinedRequestRole] ([RoleId], [DefinedRequestId], [CreatedAt], [CreatedBy], [ModifiedAt], [ModifiedBy], [Permission]) VALUES (N'7a49542e-e22b-4c5c-84ad-0bfc7ce71cab', 6, NULL, NULL, NULL, NULL, N'All')
GO
INSERT [dbo].[DefinedRequestRole] ([RoleId], [DefinedRequestId], [CreatedAt], [CreatedBy], [ModifiedAt], [ModifiedBy], [Permission]) VALUES (N'7a49542e-e22b-4c5c-84ad-0bfc7ce71cab', 7, NULL, NULL, NULL, NULL, N'All')
GO
INSERT [dbo].[DefinedRequestRole] ([RoleId], [DefinedRequestId], [CreatedAt], [CreatedBy], [ModifiedAt], [ModifiedBy], [Permission]) VALUES (N'7a49542e-e22b-4c5c-84ad-0bfc7ce71cab', 8, NULL, NULL, NULL, NULL, N'All')
GO
INSERT [dbo].[DefinedRequestRole] ([RoleId], [DefinedRequestId], [CreatedAt], [CreatedBy], [ModifiedAt], [ModifiedBy], [Permission]) VALUES (N'b746e112-ea70-40ca-a5f1-0ec896473280', 1, NULL, NULL, NULL, NULL, N'Review')
GO
INSERT [dbo].[DefinedRequestRole] ([RoleId], [DefinedRequestId], [CreatedAt], [CreatedBy], [ModifiedAt], [ModifiedBy], [Permission]) VALUES (N'b746e112-ea70-40ca-a5f1-0ec896473280', 3, NULL, NULL, NULL, NULL, N'All')
GO
INSERT [dbo].[DefinedRequestRole] ([RoleId], [DefinedRequestId], [CreatedAt], [CreatedBy], [ModifiedAt], [ModifiedBy], [Permission]) VALUES (N'b746e112-ea70-40ca-a5f1-0ec896473280', 6, NULL, NULL, NULL, NULL, N'All')
GO
INSERT [dbo].[DefinedRequestRole] ([RoleId], [DefinedRequestId], [CreatedAt], [CreatedBy], [ModifiedAt], [ModifiedBy], [Permission]) VALUES (N'd461093e-afb6-478f-93b6-50a01d9c2a42', 3, NULL, NULL, NULL, NULL, N'All')
GO
INSERT [dbo].[DefinedRequestRole] ([RoleId], [DefinedRequestId], [CreatedAt], [CreatedBy], [ModifiedAt], [ModifiedBy], [Permission]) VALUES (N'd461093e-afb6-478f-93b6-50a01d9c2a42', 6, NULL, NULL, NULL, NULL, N'All')
GO
INSERT [dbo].[DefinedRequestRole] ([RoleId], [DefinedRequestId], [CreatedAt], [CreatedBy], [ModifiedAt], [ModifiedBy], [Permission]) VALUES (N'd461093e-afb6-478f-93b6-50a01d9c2a42', 8, NULL, NULL, NULL, NULL, N'Review')
GO
INSERT [dbo].[DefinedRequestRole] ([RoleId], [DefinedRequestId], [CreatedAt], [CreatedBy], [ModifiedAt], [ModifiedBy], [Permission]) VALUES (N'dc7af9c0-60e7-4972-a18e-fe79b8946dce', 1, NULL, NULL, NULL, NULL, N'Request')
GO
INSERT [dbo].[DefinedRequestRole] ([RoleId], [DefinedRequestId], [CreatedAt], [CreatedBy], [ModifiedAt], [ModifiedBy], [Permission]) VALUES (N'dc7af9c0-60e7-4972-a18e-fe79b8946dce', 3, NULL, NULL, NULL, NULL, N'All')
GO
INSERT [dbo].[DefinedRequestRole] ([RoleId], [DefinedRequestId], [CreatedAt], [CreatedBy], [ModifiedAt], [ModifiedBy], [Permission]) VALUES (N'dc7af9c0-60e7-4972-a18e-fe79b8946dce', 6, NULL, NULL, NULL, NULL, N'All')
GO
INSERT [dbo].[Department] ([Id], [DepartmentName], [ManagerId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [DepartmentIcon]) VALUES (1, N'IT', N'51000', NULL, NULL, NULL, NULL, N'IT Icone')
GO
INSERT [dbo].[Department] ([Id], [DepartmentName], [ManagerId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [DepartmentIcon]) VALUES (2, N'Finance', N'55578', NULL, NULL, NULL, NULL, N'Finance Icon')
GO
INSERT [dbo].[Department] ([Id], [DepartmentName], [ManagerId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [DepartmentIcon]) VALUES (3, N'HR', N'123456', NULL, NULL, NULL, NULL, N'HR Icon')
GO
INSERT [dbo].[Department] ([Id], [DepartmentName], [ManagerId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [DepartmentIcon]) VALUES (4, N'Operations', N'85784', NULL, NULL, NULL, NULL, N'Operations Icon')
GO
SET IDENTITY_INSERT [dbo].[Section] ON 
GO
INSERT [dbo].[Section] ([Id], [SectionName], [DepartmentId], [HeadId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (1, N'Apllication Development', 1, N'51234', NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Section] OFF
GO
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'1', N'PO', NULL, N'sghewsgsgsge56sg4165es')
GO
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'7a49542e-e22b-4c5c-84ad-0bfc7ce71cab', N'IT', N'IT', N'NULL375810e0-ffbc-47ea-976a-26784b54c693')
GO
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'b746e112-ea70-40ca-a5f1-0ec896473280', N'Finance', N'FINANCE', N'1083d690-734d-4871-8379-294e5ce4fa8e')
GO
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'd461093e-afb6-478f-93b6-50a01d9c2a42', N'Operations', N'OPERATIONS', N'a652cc33-dd1a-49be-ab93-d53bf86a1ef1')
GO
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'dc7af9c0-60e7-4972-a18e-fe79b8946dce', N'HR', N'HR', N'd397c61e-8db0-4d56-8738-a73f14ef1dfc')
GO
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [Email], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [NormalizedEmail], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [LockoutEnabled], [AccessFailedCount], [IsEmployee], [EmailConfirmed], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd]) VALUES (N'123456', N'waboelgaday', N'WABOELGADAY', N'waboelgaday@example.com', N'Hakem Mohamed', N'HR Manager', 3, NULL, NULL, N'DP', NULL, CAST(N'2023-09-14T11:17:00' AS SmallDateTime), NULL, NULL, NULL, N'WABOELGADAY@EXAMPLE.COM', N'AQAAAAIAAYagAAAAEIfr+9Or6xwrWI8VSYeTqiVWEpOUKGjUfJEY29JPwO5Wy36XB/y3gvzPDy/AekUeag==', N'WNX4PUXS2PH7TV4H6T3JO4IRK5NHF5EP', N'3c063ac0-3245-4f13-96ed-f0b400a0e7e9', N'01095948568', 1, 0, 1, 0, 0, 0, NULL)
GO
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [Email], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [NormalizedEmail], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [LockoutEnabled], [AccessFailedCount], [IsEmployee], [EmailConfirmed], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd]) VALUES (N'12578', N'hmohamed', N'HMOHAMED', N'hmohamed@example.com', N'Hakem Mohamed', N'HR Officer', 3, NULL, NULL, N'DP', NULL, CAST(N'2023-09-14T11:16:00' AS SmallDateTime), NULL, NULL, NULL, N'HMOHAMED@EXAMPLE.COM', N'AQAAAAIAAYagAAAAEH0zXUIZ5fRQGjew4FPHX/skLJuTlJngqLqV11NiVJ6pAOgWxGNBNtSrY+pY2ZWRFg==', N'TZMF7C4ZCWBDM27HHVMUVV6PAYH3SYWY', N'72ea1582-ddd4-4ebc-b892-b1b14b10de2d', N'01099001215', 1, 0, 1, 0, 0, 0, NULL)
GO
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [Email], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [NormalizedEmail], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [LockoutEnabled], [AccessFailedCount], [IsEmployee], [EmailConfirmed], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd]) VALUES (N'51000', N'anasr', N'ANASR', N'anasr@example.com', N'Alaa Nasr', N'IT Manager', 1, NULL, NULL, N'DP', NULL, CAST(N'2023-09-14T11:13:00' AS SmallDateTime), NULL, NULL, NULL, N'ANASR@EXAMPLE.COM', N'AQAAAAIAAYagAAAAEIjFiBwfbijneRHVxGfGd0hdZXiNBtXpKJEyEJDSGAap4ErCXDDitlsWycM9oR+wyw==', N'INXHKC7CALIYZBIOFER3UCMQDGTO2SV2', N'7c2d0e70-d86c-43b5-9abe-b5c487e057e9', N'01556561152', 1, 0, 1, 0, 0, 0, NULL)
GO
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [Email], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [NormalizedEmail], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [LockoutEnabled], [AccessFailedCount], [IsEmployee], [EmailConfirmed], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd]) VALUES (N'51234', N'amustafa', N'AMUSTAFA', N'amustafa@example.com', N'Abdelsalam Mustafa', N'Application Section Head', 1, 1, N'51000', N'DP', NULL, CAST(N'2023-09-14T11:13:00' AS SmallDateTime), NULL, NULL, NULL, N'AMUSTAFA@EXAMPLE.COM', N'AQAAAAIAAYagAAAAECr+n/UJGSjsU9cGSnhTeqziTFzh+jBtXZ6XpHuKKkJysVS7J+RX25MtV1/uj1EEWg==', N'6MJEIAX24CXJWPAC3CHK6MYQ3GUZSI7A', N'4c6e5ed2-bd16-45b3-bfc1-ec7af6704b91', N'01556561159', 1, 0, 1, 0, 0, 0, NULL)
GO
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [Email], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [NormalizedEmail], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [LockoutEnabled], [AccessFailedCount], [IsEmployee], [EmailConfirmed], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd]) VALUES (N'51678', N'almuhammad', N'ALMUHAMMAD', N'alaa@example.com', N'Alaa Abo Elhassan Mohamed', N'IT Developer', 1, 1, N'51234', N'DP', CAST(N'2023-09-15T09:55:00' AS SmallDateTime), CAST(N'2023-09-14T11:11:00' AS SmallDateTime), NULL, NULL, NULL, N'ALAA@EXAMPLE.COM', N'AQAAAAIAAYagAAAAEDa32pQEdNTWYqvpBplcxTLIdOJzttw7atmwXn9lpjaKVAoeUC1kizzgf+ndI6BghA==', N'U5KZDNXNAA4RCECQQVJG4AL4GO3TZFEC', N'daaf533b-2c91-4910-ab6b-9fcb9cca5e04', N'01002721159', 1, 0, 1, 0, 0, 0, NULL)
GO
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [Email], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [NormalizedEmail], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [LockoutEnabled], [AccessFailedCount], [IsEmployee], [EmailConfirmed], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd]) VALUES (N'55578', N'msultan', N'MSULTAN', N'msultan@example.com', N'Mustafa Sultan', N'Finance Manager', 2, NULL, NULL, N'DP', NULL, CAST(N'2023-09-14T11:15:00' AS SmallDateTime), NULL, NULL, NULL, N'MSULTAN@EXAMPLE.COM', N'AQAAAAIAAYagAAAAEGwZb7tXZ3UeonnK/AIfPQlSEf8bssEx/gcZVT9D31inyq9XnYrt5kbh8qri+PybVw==', N'ZR3AUOW6FOKBA65UW3YVUDJSMWA3BTOK', N'07e82380-53bc-4c2f-93a2-38c55b6d48aa', N'01554561752', 1, 0, 1, 0, 0, 0, NULL)
GO
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [Email], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [NormalizedEmail], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [LockoutEnabled], [AccessFailedCount], [IsEmployee], [EmailConfirmed], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd]) VALUES (N'58878', N'edwapa', N'EDWAPA', N'edwapa@example.com', N'Essam Dwapa', N'Accountant', 2, NULL, NULL, N'DP', CAST(N'2023-09-14T13:55:00' AS SmallDateTime), CAST(N'2023-09-14T11:14:00' AS SmallDateTime), NULL, NULL, NULL, N'EDWAPA@EXAMPLE.COM', N'AQAAAAIAAYagAAAAEDktzHX7/ol1LyAiXEQkK66Hq9HaBGM7ZMAD10T9ql84BoZidQ+XLNZY5XivMnuXuw==', N'XLLMKO5GMPPWWUHAL7FPVTNJEQV6ZNB2', N'1665ee71-c1c0-46d5-9875-fa95eff1f54f', N'01556561752', 1, 0, 1, 0, 0, 0, NULL)
GO
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [Email], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [NormalizedEmail], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [LockoutEnabled], [AccessFailedCount], [IsEmployee], [EmailConfirmed], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd]) VALUES (N'85574', N'arafat', N'ARAFAT', N'arafat@example.com', N'Ahmed Rafaat', N'Planner', 4, NULL, NULL, N'DP', CAST(N'2023-09-14T13:56:00' AS SmallDateTime), CAST(N'2023-09-14T11:19:00' AS SmallDateTime), NULL, NULL, NULL, N'ARAFAT@EXAMPLE.COM', N'AQAAAAIAAYagAAAAEMPfs2IbX8LeKJL5hKG1MFA3IQTrpPZJbN87gqF2Z8ivVGwZBDKfUMDXZX297rYFew==', N'5YZRX2ARRJTY5HC77FCG7S4J53GBSCGY', N'4c0f6350-7450-4cd7-8039-dcc38575892f', N'01002558795', 1, 0, 1, 0, 0, 0, NULL)
GO
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [Email], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [NormalizedEmail], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [LockoutEnabled], [AccessFailedCount], [IsEmployee], [EmailConfirmed], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd]) VALUES (N'85784', N'mmohsen', N'MMOHSEN', N'mmohsen@example.com', N'Maged Mohsen', N'Operation Manager', 4, NULL, NULL, N'DP', NULL, CAST(N'2023-09-14T11:20:00' AS SmallDateTime), NULL, NULL, NULL, N'MMOHSEN@EXAMPLE.COM', N'AQAAAAIAAYagAAAAEI1ukLrWDfIuivFzs92uabkWqR67WZI5i40foFofRl35fi4eUfFx2sgdltF0ROH7Wg==', N'AEHINUTJ6M3KKWLIVNWEK2A2H43TB462', N'c4da87b6-347f-4829-8df9-0ba49f9335e7', N'01002558795', 1, 0, 1, 0, 0, 0, NULL)
GO
INSERT [security].[UserRoles] ([UserId], [RoleId]) VALUES (N'51000', N'7a49542e-e22b-4c5c-84ad-0bfc7ce71cab')
GO
INSERT [security].[UserRoles] ([UserId], [RoleId]) VALUES (N'51234', N'7a49542e-e22b-4c5c-84ad-0bfc7ce71cab')
GO
INSERT [security].[UserRoles] ([UserId], [RoleId]) VALUES (N'51678', N'7a49542e-e22b-4c5c-84ad-0bfc7ce71cab')
GO
INSERT [security].[UserRoles] ([UserId], [RoleId]) VALUES (N'55578', N'b746e112-ea70-40ca-a5f1-0ec896473280')
GO
INSERT [security].[UserRoles] ([UserId], [RoleId]) VALUES (N'58878', N'b746e112-ea70-40ca-a5f1-0ec896473280')
GO
INSERT [security].[UserRoles] ([UserId], [RoleId]) VALUES (N'85574', N'd461093e-afb6-478f-93b6-50a01d9c2a42')
GO
INSERT [security].[UserRoles] ([UserId], [RoleId]) VALUES (N'85784', N'd461093e-afb6-478f-93b6-50a01d9c2a42')
GO
INSERT [security].[UserRoles] ([UserId], [RoleId]) VALUES (N'123456', N'dc7af9c0-60e7-4972-a18e-fe79b8946dce')
GO
INSERT [security].[UserRoles] ([UserId], [RoleId]) VALUES (N'12578', N'dc7af9c0-60e7-4972-a18e-fe79b8946dce')
GO
/****** Object:  Index [IX_ApplicationItAdmin_ApplicationId]    Script Date: 9/15/2023 10:02:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_ApplicationItAdmin_ApplicationId] ON [dbo].[ApplicationItAdmin]
(
	[ApplicationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ApplicationUserRequest_RequestId]    Script Date: 9/15/2023 10:02:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_ApplicationUserRequest_RequestId] ON [dbo].[ApplicationUserRequest]
(
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Attachment_RequestId]    Script Date: 9/15/2023 10:02:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_Attachment_RequestId] ON [dbo].[Attachment]
(
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CarRequest_RequestId]    Script Date: 9/15/2023 10:02:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_CarRequest_RequestId] ON [dbo].[CarRequest]
(
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_DefinedApplication_ApplicationOwnerId]    Script Date: 9/15/2023 10:02:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_DefinedApplication_ApplicationOwnerId] ON [dbo].[DefinedApplication]
(
	[ApplicationOwnerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DefinedApplicationRole_RequestedApplicationId]    Script Date: 9/15/2023 10:02:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_DefinedApplicationRole_RequestedApplicationId] ON [dbo].[DefinedApplicationRole]
(
	[RequestedApplicationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DefinedRequest_DepartmentId]    Script Date: 9/15/2023 10:02:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_DefinedRequest_DepartmentId] ON [dbo].[DefinedRequest]
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_DefinedRequestReviewer_ReviewerId]    Script Date: 9/15/2023 10:02:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_DefinedRequestReviewer_ReviewerId] ON [dbo].[DefinedRequestReviewer]
(
	[ReviewerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DefinedRequestRole_DefinedRequestId]    Script Date: 9/15/2023 10:02:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_DefinedRequestRole_DefinedRequestId] ON [dbo].[DefinedRequestRole]
(
	[DefinedRequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Department_ManagerId]    Script Date: 9/15/2023 10:02:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_Department_ManagerId] ON [dbo].[Department]
(
	[ManagerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DomainAccountRequest_RequestId]    Script Date: 9/15/2023 10:02:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_DomainAccountRequest_RequestId] ON [dbo].[DomainAccountRequest]
(
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_PoRequest_InvoiceNumber]    Script Date: 9/15/2023 10:02:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_PoRequest_InvoiceNumber] ON [dbo].[PoRequest]
(
	[InvoiceNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_PoRequest_PoDescription]    Script Date: 9/15/2023 10:02:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_PoRequest_PoDescription] ON [dbo].[PoRequest]
(
	[PoDescription] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_PoRequest_RequestId]    Script Date: 9/15/2023 10:02:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_PoRequest_RequestId] ON [dbo].[PoRequest]
(
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_PoRequest_VendorName]    Script Date: 9/15/2023 10:02:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_PoRequest_VendorName] ON [dbo].[PoRequest]
(
	[VendorName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_PoRequest_VendorNumber]    Script Date: 9/15/2023 10:02:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_PoRequest_VendorNumber] ON [dbo].[PoRequest]
(
	[VendorNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Request_CreatorId]    Script Date: 9/15/2023 10:02:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_Request_CreatorId] ON [dbo].[Request]
(
	[CreatorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Request_DefinedRequestId]    Script Date: 9/15/2023 10:02:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_Request_DefinedRequestId] ON [dbo].[Request]
(
	[DefinedRequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_RequestApplicationRole_ApplicationId]    Script Date: 9/15/2023 10:02:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_RequestApplicationRole_ApplicationId] ON [dbo].[RequestApplicationRole]
(
	[ApplicationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_RequestApplicationRole_RoleId]    Script Date: 9/15/2023 10:02:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_RequestApplicationRole_RoleId] ON [dbo].[RequestApplicationRole]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_RequestReviewer_ReviewerId]    Script Date: 9/15/2023 10:02:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_RequestReviewer_ReviewerId] ON [dbo].[RequestReviewer]
(
	[ReviewerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Section_DepartmentId]    Script Date: 9/15/2023 10:02:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_Section_DepartmentId] ON [dbo].[Section]
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Section_HeadId]    Script Date: 9/15/2023 10:02:20 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Section_HeadId] ON [dbo].[Section]
(
	[HeadId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_TravelDeskRequest_RequestId]    Script Date: 9/15/2023 10:02:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_TravelDeskRequest_RequestId] ON [dbo].[TravelDeskRequest]
(
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_VoucherRequest_RequestId]    Script Date: 9/15/2023 10:02:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_VoucherRequest_RequestId] ON [dbo].[VoucherRequest]
(
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 9/15/2023 10:02:20 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [security].[Role]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_RoleClaims_RoleId]    Script Date: 9/15/2023 10:02:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_RoleClaims_RoleId] ON [security].[RoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 9/15/2023 10:02:20 AM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [security].[User]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_User_DepartmentId]    Script Date: 9/15/2023 10:02:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_User_DepartmentId] ON [security].[User]
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_User_ManagerId]    Script Date: 9/15/2023 10:02:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_User_ManagerId] ON [security].[User]
(
	[ManagerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_User_SectionId]    Script Date: 9/15/2023 10:02:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_User_SectionId] ON [security].[User]
(
	[SectionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 9/15/2023 10:02:20 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [security].[User]
(
	[NormalizedUserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserClaims_UserId]    Script Date: 9/15/2023 10:02:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_UserClaims_UserId] ON [security].[UserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserLogin_UserId]    Script Date: 9/15/2023 10:02:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_UserLogin_UserId] ON [security].[UserLogin]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserRoles_RoleId]    Script Date: 9/15/2023 10:02:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_UserRoles_RoleId] ON [security].[UserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DefinedRequestRole] ADD  DEFAULT (N'') FOR [Permission]
GO
ALTER TABLE [security].[User] ADD  DEFAULT (N'') FOR [PhoneNumber]
GO
ALTER TABLE [security].[User] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsEmployee]
GO
ALTER TABLE [security].[User] ADD  DEFAULT (CONVERT([bit],(0))) FOR [EmailConfirmed]
GO
ALTER TABLE [security].[User] ADD  DEFAULT (CONVERT([bit],(0))) FOR [PhoneNumberConfirmed]
GO
ALTER TABLE [security].[User] ADD  DEFAULT (CONVERT([bit],(0))) FOR [TwoFactorEnabled]
GO
ALTER TABLE [dbo].[ApplicationItAdmin]  WITH CHECK ADD  CONSTRAINT [FK_ApplicationItAdmin_DefinedApplication] FOREIGN KEY([ApplicationId])
REFERENCES [dbo].[DefinedApplication] ([Id])
GO
ALTER TABLE [dbo].[ApplicationItAdmin] CHECK CONSTRAINT [FK_ApplicationItAdmin_DefinedApplication]
GO
ALTER TABLE [dbo].[ApplicationItAdmin]  WITH CHECK ADD  CONSTRAINT [FK_ApplicationItAdmin_User] FOREIGN KEY([ItAdminId])
REFERENCES [security].[User] ([Id])
GO
ALTER TABLE [dbo].[ApplicationItAdmin] CHECK CONSTRAINT [FK_ApplicationItAdmin_User]
GO
ALTER TABLE [dbo].[ApplicationUserRequest]  WITH CHECK ADD  CONSTRAINT [FK_ApplicationUserRequest_Request] FOREIGN KEY([RequestId])
REFERENCES [dbo].[Request] ([Id])
GO
ALTER TABLE [dbo].[ApplicationUserRequest] CHECK CONSTRAINT [FK_ApplicationUserRequest_Request]
GO
ALTER TABLE [dbo].[Attachment]  WITH CHECK ADD  CONSTRAINT [FK_Attachment_Request] FOREIGN KEY([RequestId])
REFERENCES [dbo].[Request] ([Id])
GO
ALTER TABLE [dbo].[Attachment] CHECK CONSTRAINT [FK_Attachment_Request]
GO
ALTER TABLE [dbo].[CarRequest]  WITH CHECK ADD  CONSTRAINT [FK_CarRequest_Request] FOREIGN KEY([RequestId])
REFERENCES [dbo].[Request] ([Id])
GO
ALTER TABLE [dbo].[CarRequest] CHECK CONSTRAINT [FK_CarRequest_Request]
GO
ALTER TABLE [dbo].[DefinedApplication]  WITH CHECK ADD  CONSTRAINT [FK_DefinedApplication_User] FOREIGN KEY([ApplicationOwnerId])
REFERENCES [security].[User] ([Id])
GO
ALTER TABLE [dbo].[DefinedApplication] CHECK CONSTRAINT [FK_DefinedApplication_User]
GO
ALTER TABLE [dbo].[DefinedApplicationRole]  WITH CHECK ADD  CONSTRAINT [FK_DefinedApplicationRole_RequestedApplication] FOREIGN KEY([RequestedApplicationId])
REFERENCES [dbo].[DefinedApplication] ([Id])
GO
ALTER TABLE [dbo].[DefinedApplicationRole] CHECK CONSTRAINT [FK_DefinedApplicationRole_RequestedApplication]
GO
ALTER TABLE [dbo].[DefinedRequest]  WITH CHECK ADD  CONSTRAINT [FK_DefinedRequest_Department] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Department] ([Id])
GO
ALTER TABLE [dbo].[DefinedRequest] CHECK CONSTRAINT [FK_DefinedRequest_Department]
GO
ALTER TABLE [dbo].[DefinedRequestReviewer]  WITH CHECK ADD  CONSTRAINT [FK_DefinedRequestReviewer_DefinedRequest] FOREIGN KEY([DefinedRequestId])
REFERENCES [dbo].[DefinedRequest] ([Id])
GO
ALTER TABLE [dbo].[DefinedRequestReviewer] CHECK CONSTRAINT [FK_DefinedRequestReviewer_DefinedRequest]
GO
ALTER TABLE [dbo].[DefinedRequestReviewer]  WITH CHECK ADD  CONSTRAINT [FK_DefinedRequestReviewer_User] FOREIGN KEY([ReviewerId])
REFERENCES [security].[User] ([Id])
GO
ALTER TABLE [dbo].[DefinedRequestReviewer] CHECK CONSTRAINT [FK_DefinedRequestReviewer_User]
GO
ALTER TABLE [dbo].[DefinedRequestRole]  WITH CHECK ADD  CONSTRAINT [FK_DefinedRequestRole_DefinedRequest] FOREIGN KEY([DefinedRequestId])
REFERENCES [dbo].[DefinedRequest] ([Id])
GO
ALTER TABLE [dbo].[DefinedRequestRole] CHECK CONSTRAINT [FK_DefinedRequestRole_DefinedRequest]
GO
ALTER TABLE [dbo].[DefinedRequestRole]  WITH CHECK ADD  CONSTRAINT [FK_DefinedRequestRole_Role] FOREIGN KEY([RoleId])
REFERENCES [security].[Role] ([Id])
GO
ALTER TABLE [dbo].[DefinedRequestRole] CHECK CONSTRAINT [FK_DefinedRequestRole_Role]
GO
ALTER TABLE [dbo].[Department]  WITH CHECK ADD  CONSTRAINT [FK_Department_User] FOREIGN KEY([ManagerId])
REFERENCES [security].[User] ([Id])
GO
ALTER TABLE [dbo].[Department] CHECK CONSTRAINT [FK_Department_User]
GO
ALTER TABLE [dbo].[DomainAccountRequest]  WITH CHECK ADD  CONSTRAINT [FK_DomainAccountRequest_Request] FOREIGN KEY([RequestId])
REFERENCES [dbo].[Request] ([Id])
GO
ALTER TABLE [dbo].[DomainAccountRequest] CHECK CONSTRAINT [FK_DomainAccountRequest_Request]
GO
ALTER TABLE [dbo].[PoRequest]  WITH CHECK ADD  CONSTRAINT [FK_PoRequest_Request] FOREIGN KEY([RequestId])
REFERENCES [dbo].[Request] ([Id])
GO
ALTER TABLE [dbo].[PoRequest] CHECK CONSTRAINT [FK_PoRequest_Request]
GO
ALTER TABLE [dbo].[Request]  WITH CHECK ADD  CONSTRAINT [FK_Request_DefinedRequest] FOREIGN KEY([DefinedRequestId])
REFERENCES [dbo].[DefinedRequest] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Request] CHECK CONSTRAINT [FK_Request_DefinedRequest]
GO
ALTER TABLE [dbo].[Request]  WITH CHECK ADD  CONSTRAINT [FK_Request_User] FOREIGN KEY([CreatorId])
REFERENCES [security].[User] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Request] CHECK CONSTRAINT [FK_Request_User]
GO
ALTER TABLE [dbo].[RequestApplicationRole]  WITH CHECK ADD  CONSTRAINT [FK_RequestApplicationRole_DefinedApplication] FOREIGN KEY([ApplicationId])
REFERENCES [dbo].[DefinedApplication] ([Id])
GO
ALTER TABLE [dbo].[RequestApplicationRole] CHECK CONSTRAINT [FK_RequestApplicationRole_DefinedApplication]
GO
ALTER TABLE [dbo].[RequestApplicationRole]  WITH CHECK ADD  CONSTRAINT [FK_RequestApplicationRole_DefinedApplicationRole] FOREIGN KEY([RoleId])
REFERENCES [dbo].[DefinedApplicationRole] ([Id])
GO
ALTER TABLE [dbo].[RequestApplicationRole] CHECK CONSTRAINT [FK_RequestApplicationRole_DefinedApplicationRole]
GO
ALTER TABLE [dbo].[RequestApplicationRole]  WITH CHECK ADD  CONSTRAINT [FK_RequestApplicationRole_Request] FOREIGN KEY([RequestId])
REFERENCES [dbo].[Request] ([Id])
GO
ALTER TABLE [dbo].[RequestApplicationRole] CHECK CONSTRAINT [FK_RequestApplicationRole_Request]
GO
ALTER TABLE [dbo].[RequestReviewer]  WITH CHECK ADD  CONSTRAINT [FK_RequestReviewer_Request] FOREIGN KEY([RequestId])
REFERENCES [dbo].[Request] ([Id])
GO
ALTER TABLE [dbo].[RequestReviewer] CHECK CONSTRAINT [FK_RequestReviewer_Request]
GO
ALTER TABLE [dbo].[RequestReviewer]  WITH CHECK ADD  CONSTRAINT [FK_RequestReviewer_User] FOREIGN KEY([ReviewerId])
REFERENCES [security].[User] ([Id])
GO
ALTER TABLE [dbo].[RequestReviewer] CHECK CONSTRAINT [FK_RequestReviewer_User]
GO
ALTER TABLE [dbo].[Section]  WITH CHECK ADD  CONSTRAINT [FK_Section_Department] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Department] ([Id])
GO
ALTER TABLE [dbo].[Section] CHECK CONSTRAINT [FK_Section_Department]
GO
ALTER TABLE [dbo].[Section]  WITH CHECK ADD  CONSTRAINT [FK_Section_User] FOREIGN KEY([HeadId])
REFERENCES [security].[User] ([Id])
GO
ALTER TABLE [dbo].[Section] CHECK CONSTRAINT [FK_Section_User]
GO
ALTER TABLE [dbo].[TravelDeskRequest]  WITH CHECK ADD  CONSTRAINT [FK_TravelDeskRequest_Request] FOREIGN KEY([RequestId])
REFERENCES [dbo].[Request] ([Id])
GO
ALTER TABLE [dbo].[TravelDeskRequest] CHECK CONSTRAINT [FK_TravelDeskRequest_Request]
GO
ALTER TABLE [dbo].[VoucherRequest]  WITH CHECK ADD  CONSTRAINT [FK_VoucherRequest_Request] FOREIGN KEY([RequestId])
REFERENCES [dbo].[Request] ([Id])
GO
ALTER TABLE [dbo].[VoucherRequest] CHECK CONSTRAINT [FK_VoucherRequest_Request]
GO
ALTER TABLE [security].[RoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_RoleClaims_Role_RoleId] FOREIGN KEY([RoleId])
REFERENCES [security].[Role] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [security].[RoleClaims] CHECK CONSTRAINT [FK_RoleClaims_Role_RoleId]
GO
ALTER TABLE [security].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Department] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Department] ([Id])
GO
ALTER TABLE [security].[User] CHECK CONSTRAINT [FK_User_Department]
GO
ALTER TABLE [security].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Section] FOREIGN KEY([SectionId])
REFERENCES [dbo].[Section] ([Id])
GO
ALTER TABLE [security].[User] CHECK CONSTRAINT [FK_User_Section]
GO
ALTER TABLE [security].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_User] FOREIGN KEY([ManagerId])
REFERENCES [security].[User] ([Id])
GO
ALTER TABLE [security].[User] CHECK CONSTRAINT [FK_User_User]
GO
ALTER TABLE [security].[UserClaims]  WITH CHECK ADD  CONSTRAINT [FK_UserClaims_User_UserId] FOREIGN KEY([UserId])
REFERENCES [security].[User] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [security].[UserClaims] CHECK CONSTRAINT [FK_UserClaims_User_UserId]
GO
ALTER TABLE [security].[UserLogin]  WITH CHECK ADD  CONSTRAINT [FK_UserLogin_User_UserId] FOREIGN KEY([UserId])
REFERENCES [security].[User] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [security].[UserLogin] CHECK CONSTRAINT [FK_UserLogin_User_UserId]
GO
ALTER TABLE [security].[UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserRoles_Role_RoleId] FOREIGN KEY([RoleId])
REFERENCES [security].[Role] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [security].[UserRoles] CHECK CONSTRAINT [FK_UserRoles_Role_RoleId]
GO
ALTER TABLE [security].[UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserRoles_User_UserId] FOREIGN KEY([UserId])
REFERENCES [security].[User] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [security].[UserRoles] CHECK CONSTRAINT [FK_UserRoles_User_UserId]
GO
ALTER TABLE [security].[UserToken]  WITH CHECK ADD  CONSTRAINT [FK_UserToken_User_UserId] FOREIGN KEY([UserId])
REFERENCES [security].[User] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [security].[UserToken] CHECK CONSTRAINT [FK_UserToken_User_UserId]
GO
USE [master]
GO
ALTER DATABASE [E-Document] SET  READ_WRITE 
GO
