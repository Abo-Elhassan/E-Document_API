USE [master]
GO
/****** Object:  Database [E-Document]    Script Date: 9/18/2023 8:41:40 AM ******/
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
/****** Object:  Schema [security]    Script Date: 9/18/2023 8:41:40 AM ******/
CREATE SCHEMA [security]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 9/18/2023 8:41:40 AM ******/
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
/****** Object:  Table [dbo].[ApplicationItAdmin]    Script Date: 9/18/2023 8:41:40 AM ******/
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
/****** Object:  Table [dbo].[ApplicationUserRequest]    Script Date: 9/18/2023 8:41:40 AM ******/
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
/****** Object:  Table [dbo].[Attachment]    Script Date: 9/18/2023 8:41:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Attachment](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[FilePath] [nvarchar](max) NOT NULL,
	[RequestId] [bigint] NULL,
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
/****** Object:  Table [dbo].[CarRequest]    Script Date: 9/18/2023 8:41:40 AM ******/
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
/****** Object:  Table [dbo].[DefinedApplication]    Script Date: 9/18/2023 8:41:40 AM ******/
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
/****** Object:  Table [dbo].[DefinedApplicationRole]    Script Date: 9/18/2023 8:41:40 AM ******/
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
/****** Object:  Table [dbo].[DefinedRequest]    Script Date: 9/18/2023 8:41:40 AM ******/
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
/****** Object:  Table [dbo].[DefinedRequestReviewer]    Script Date: 9/18/2023 8:41:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DefinedRequestReviewer](
	[DefinedRequestId] [bigint] NOT NULL,
	[ReviewerId] [nvarchar](50) NOT NULL,
	[DelegatedReviewerId] [nvarchar](50) NULL,
	[StageName] [nvarchar](50) NULL,
	[StageNumber] [int] NOT NULL,
	[ReviewerType] [nvarchar](50) NOT NULL,
	[DelegatedUntil] [smalldatetime] NULL,
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
/****** Object:  Table [dbo].[DefinedRequestRole]    Script Date: 9/18/2023 8:41:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DefinedRequestRole](
	[RoleId] [nvarchar](450) NOT NULL,
	[DefinedRequestId] [bigint] NOT NULL,
	[Permission] [nvarchar](max) NOT NULL,
	[CreatedAt] [smalldatetime] NULL,
	[ModifiedAt] [smalldatetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[ModifiedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_DefinedRequestRole] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC,
	[DefinedRequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 9/18/2023 8:41:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[Id] [bigint] NOT NULL,
	[DepartmentName] [nvarchar](200) NOT NULL,
	[DepartmentIcon] [nvarchar](max) NULL,
	[ManagerId] [nvarchar](50) NULL,
	[CreatedAt] [smalldatetime] NULL,
	[ModifiedAt] [smalldatetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[ModifiedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DomainAccountRequest]    Script Date: 9/18/2023 8:41:40 AM ******/
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
/****** Object:  Table [dbo].[PoRequest]    Script Date: 9/18/2023 8:41:40 AM ******/
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
/****** Object:  Table [dbo].[Request]    Script Date: 9/18/2023 8:41:40 AM ******/
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
/****** Object:  Table [dbo].[RequestApplicationRole]    Script Date: 9/18/2023 8:41:40 AM ******/
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
/****** Object:  Table [dbo].[RequestReviewer]    Script Date: 9/18/2023 8:41:40 AM ******/
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
/****** Object:  Table [dbo].[Section]    Script Date: 9/18/2023 8:41:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Section](
	[Id] [bigint] NOT NULL,
	[SectionName] [nvarchar](max) NULL,
	[DepartmentId] [bigint] NULL,
	[HeadId] [nvarchar](50) NULL,
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
/****** Object:  Table [dbo].[TravelDeskRequest]    Script Date: 9/18/2023 8:41:40 AM ******/
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
/****** Object:  Table [dbo].[VoucherRequest]    Script Date: 9/18/2023 8:41:40 AM ******/
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
/****** Object:  Table [security].[Role]    Script Date: 9/18/2023 8:41:40 AM ******/
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
/****** Object:  Table [security].[RoleClaims]    Script Date: 9/18/2023 8:41:40 AM ******/
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
/****** Object:  Table [security].[User]    Script Date: 9/18/2023 8:41:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [security].[User](
	[Id] [nvarchar](50) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[NormalizedUserName] [nvarchar](50) NOT NULL,
	[FullName] [nvarchar](200) NOT NULL,
	[Position] [nvarchar](200) NULL,
	[DepartmentId] [bigint] NULL,
	[SectionId] [bigint] NULL,
	[ManagerId] [nvarchar](50) NULL,
	[Company] [nvarchar](200) NULL,
	[IsEmployee] [bit] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[LastLogin] [smalldatetime] NULL,
	[CreatedAt] [smalldatetime] NULL,
	[ModifiedAt] [smalldatetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[ModifiedBy] [nvarchar](50) NULL,
	[Email] [nvarchar](200) NULL,
	[NormalizedEmail] [nvarchar](200) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](50) NOT NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [security].[UserClaims]    Script Date: 9/18/2023 8:41:40 AM ******/
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
/****** Object:  Table [security].[UserLogin]    Script Date: 9/18/2023 8:41:40 AM ******/
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
/****** Object:  Table [security].[UserRoles]    Script Date: 9/18/2023 8:41:40 AM ******/
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
/****** Object:  Table [security].[UserToken]    Script Date: 9/18/2023 8:41:40 AM ******/
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
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230917092155_initialMigration', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230917105138_AddUsers', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230917105453_updateUsers', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230917105625_addDepartment', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230917110045_addSection', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230917110408_updateUsersDepartments', N'7.0.10')
GO
INSERT [dbo].[Department] ([Id], [DepartmentName], [DepartmentIcon], [ManagerId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (1, N'Administration', N'Administration.svg', N'50269', NULL, NULL, NULL, NULL)
INSERT [dbo].[Department] ([Id], [DepartmentName], [DepartmentIcon], [ManagerId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2, N'Freight Forwarding', NULL, N'90010', NULL, NULL, NULL, NULL)
INSERT [dbo].[Department] ([Id], [DepartmentName], [DepartmentIcon], [ManagerId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (3, N'Business Transformation', NULL, N'51331', NULL, NULL, NULL, NULL)
INSERT [dbo].[Department] ([Id], [DepartmentName], [DepartmentIcon], [ManagerId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (4, N'Commercial', N'Commercial.svg', N'51573', NULL, NULL, NULL, NULL)
INSERT [dbo].[Department] ([Id], [DepartmentName], [DepartmentIcon], [ManagerId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (5, N'Communications', N'Communications.svg', N'51668', NULL, NULL, NULL, NULL)
INSERT [dbo].[Department] ([Id], [DepartmentName], [DepartmentIcon], [ManagerId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (6, N'Customer Service', N'Customer Service.svg', N'51229', NULL, NULL, NULL, NULL)
INSERT [dbo].[Department] ([Id], [DepartmentName], [DepartmentIcon], [ManagerId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (7, N'Executive Management', NULL, N'Exp-16', NULL, NULL, NULL, NULL)
INSERT [dbo].[Department] ([Id], [DepartmentName], [DepartmentIcon], [ManagerId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (8, N'Finance', NULL, N'51124', NULL, NULL, NULL, NULL)
INSERT [dbo].[Department] ([Id], [DepartmentName], [DepartmentIcon], [ManagerId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (9, N'Governmental Relation', NULL, N'50962', NULL, NULL, NULL, NULL)
INSERT [dbo].[Department] ([Id], [DepartmentName], [DepartmentIcon], [ManagerId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10, N'HC - DUBUY Sales', NULL, N'51573', NULL, NULL, NULL, NULL)
INSERT [dbo].[Department] ([Id], [DepartmentName], [DepartmentIcon], [ManagerId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (11, N'HC - Samsung SDS project', NULL, N'50140', NULL, NULL, NULL, NULL)
INSERT [dbo].[Department] ([Id], [DepartmentName], [DepartmentIcon], [ManagerId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (12, N'IT', N'IT.svg', N'51331', NULL, NULL, NULL, NULL)
INSERT [dbo].[Department] ([Id], [DepartmentName], [DepartmentIcon], [ManagerId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (13, N'OPS-Cargo & Bulk', N'OPS-BGC.svg', N'50354', NULL, NULL, NULL, NULL)
INSERT [dbo].[Department] ([Id], [DepartmentName], [DepartmentIcon], [ManagerId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (14, N'OPS-Containers', NULL, N'50141', NULL, NULL, NULL, NULL)
INSERT [dbo].[Department] ([Id], [DepartmentName], [DepartmentIcon], [ManagerId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (15, N'People', N'People .svg', N'50279', NULL, NULL, NULL, NULL)
INSERT [dbo].[Department] ([Id], [DepartmentName], [DepartmentIcon], [ManagerId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (16, N'Procurement', N'Procurement.svg', N'51188', NULL, NULL, NULL, NULL)
INSERT [dbo].[Department] ([Id], [DepartmentName], [DepartmentIcon], [ManagerId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (17, N'Projects & Facility Management', NULL, N'51659', NULL, NULL, NULL, NULL)
INSERT [dbo].[Department] ([Id], [DepartmentName], [DepartmentIcon], [ManagerId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (18, N'QHSE', NULL, N'50882', NULL, NULL, NULL, NULL)
INSERT [dbo].[Department] ([Id], [DepartmentName], [DepartmentIcon], [ManagerId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (19, N'Security', N'Security.svg', N'50263', NULL, NULL, NULL, NULL)
INSERT [dbo].[Department] ([Id], [DepartmentName], [DepartmentIcon], [ManagerId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (20, N'Store', N'Stores.svg', N'50000', NULL, NULL, NULL, NULL)
INSERT [dbo].[Department] ([Id], [DepartmentName], [DepartmentIcon], [ManagerId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (21, N'Engineering', N'Technical Engineering.svg', N'50136', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Section] ([Id], [SectionName], [DepartmentId], [HeadId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (1, N'Administration', 1, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Section] ([Id], [SectionName], [DepartmentId], [HeadId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2, N'Freight Forwarding', 2, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Section] ([Id], [SectionName], [DepartmentId], [HeadId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (3, N'Business Transformation', 3, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Section] ([Id], [SectionName], [DepartmentId], [HeadId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (4, N'Commercial / Containers', 4, N'51509', NULL, NULL, NULL, NULL)
INSERT [dbo].[Section] ([Id], [SectionName], [DepartmentId], [HeadId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (5, N'Commercial Bulk / GC', 4, N'51583', NULL, NULL, NULL, NULL)
INSERT [dbo].[Section] ([Id], [SectionName], [DepartmentId], [HeadId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (6, N'Communications', 5, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Section] ([Id], [SectionName], [DepartmentId], [HeadId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (7, N'Customer Service', 6, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Section] ([Id], [SectionName], [DepartmentId], [HeadId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (8, N'Executive Management', 7, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Section] ([Id], [SectionName], [DepartmentId], [HeadId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (9, N'Finance', 8, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Section] ([Id], [SectionName], [DepartmentId], [HeadId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10, N'Governmental Relation', 9, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Section] ([Id], [SectionName], [DepartmentId], [HeadId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (11, N'Samsung SDS project', 10, N'90015', NULL, NULL, NULL, NULL)
INSERT [dbo].[Section] ([Id], [SectionName], [DepartmentId], [HeadId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (12, N'DUBUY- Sales', 11, N'90008', NULL, NULL, NULL, NULL)
INSERT [dbo].[Section] ([Id], [SectionName], [DepartmentId], [HeadId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (13, N'IT', 12, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Section] ([Id], [SectionName], [DepartmentId], [HeadId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (14, N'OPS-Cargo & Bulk', 13, N'51449', NULL, NULL, NULL, NULL)
INSERT [dbo].[Section] ([Id], [SectionName], [DepartmentId], [HeadId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (15, N'OPS- DRI', 13, N'50844', NULL, NULL, NULL, NULL)
INSERT [dbo].[Section] ([Id], [SectionName], [DepartmentId], [HeadId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (16, N'OPS-Containers', 14, N'50670', NULL, NULL, NULL, NULL)
INSERT [dbo].[Section] ([Id], [SectionName], [DepartmentId], [HeadId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (17, N'OPS-CFS', 14, N'50128', NULL, NULL, NULL, NULL)
INSERT [dbo].[Section] ([Id], [SectionName], [DepartmentId], [HeadId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (18, N'People', 15, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Section] ([Id], [SectionName], [DepartmentId], [HeadId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (19, N'Procurement', 16, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Section] ([Id], [SectionName], [DepartmentId], [HeadId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (20, N'Projects', 17, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Section] ([Id], [SectionName], [DepartmentId], [HeadId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (21, N'Safety', 18, N'51520', NULL, NULL, NULL, NULL)
INSERT [dbo].[Section] ([Id], [SectionName], [DepartmentId], [HeadId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (22, N'Clinic', 18, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Section] ([Id], [SectionName], [DepartmentId], [HeadId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (23, N'Security', 19, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Section] ([Id], [SectionName], [DepartmentId], [HeadId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (24, N'Store', 20, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Section] ([Id], [SectionName], [DepartmentId], [HeadId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (25, N'TEC-Crane', 21, N'51090', NULL, NULL, NULL, NULL)
INSERT [dbo].[Section] ([Id], [SectionName], [DepartmentId], [HeadId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (26, N'Projects', 21, N'51529', NULL, NULL, NULL, NULL)
INSERT [dbo].[Section] ([Id], [SectionName], [DepartmentId], [HeadId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (27, N'TEC-Planning', 21, N'50562', NULL, NULL, NULL, NULL)
INSERT [dbo].[Section] ([Id], [SectionName], [DepartmentId], [HeadId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (28, N'TEC-Workshop', 21, N'51126', NULL, NULL, NULL, NULL)
GO
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'0', N'SuperAdmin', N'SUPERADMIN', N'6081e33a-3e1e-491e-ad77-5252ebbfec01')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'1', N'HR', N'HR', N'19cb41df-c4f6-4104-8291-3e928f1ca1e9')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'10', N'Engineering', N'ENGINEERING', N'c38ef1b7-40d6-4636-a6c2-2d6ef748f28b')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'11', N'Commercial', N'COMMERCIAL', N'869dbd17-c62e-45aa-be2d-1e6c9260a059')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'12', N'InfoFort', N'INFOFORT', N'3ac48a26-bb24-4637-9c3a-f5be3258f2f0')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'2', N'Finance', N'FINANCE', N'a69bf47c-1425-4940-ba1c-64332d1c4d53')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'3', N'Procurement', N'PROCUREMENT', N'7a3c811c-7035-4c51-9f5a-4e8d152f96fd')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'4', N'IT', N'IT', N'ca6f6b1f-4867-4a18-8edf-0480d521b196')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'5', N'Security', N'SECURITY', N'6125de1a-5c68-4f09-8f49-534f09f024b3')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'6', N'Adminstration', N'ADMINSTRATION', N'306169ea-bee3-4f58-8cb0-9612c32b5db9')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'7', N'Stores', N'STORES', N'ccd03a53-895a-4ea1-8d9b-0a2a56acfd8a')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'8', N'CustomerService', N'CUSTOMERSERVICE', N'd3c70f64-1fcb-4cc2-8da5-b243cb06c3ef')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'9', N'OperationBGC', N'OPERATIONBGC', N'd37923ba-d564-4447-a8da-864ac388ccfe')
GO
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50000', N'stores_manager', N'STORES_MANAGER', N'Ahmed Zaki', N'Head of Stores', 20, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'stores_manager@dpworld.com', N'STORES_MANAGER@DPWORLD.COM', 0, NULL, N'07963c3d-0af9-4a5a-bce0-c652e3f7e088', N'8e7dff19-067e-4b13-820d-67680c8a6a7d', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50128', N'ops-cfs_sec_head', N'OPS-CFS_SEC_HEAD', N'Ahmed Zaki', N'OPS-CFS Section Head', 14, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'ops-cfs_sec_head@dpworld.com', N'OPS-CFS_SEC_HEAD@DPWORLD.COM', 0, NULL, N'90cadb47-d8a1-4c2a-afdd-02ab8a1bcbe3', N'cbf10b61-4fd8-46a8-900e-7dce8990dfc8', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50136', N'engineering_manager', N'ENGINEERING_MANAGER', N'Ahmed Zaki', N'Head of Engineering', 21, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'engineering_manager@dpworld.com', N'ENGINEERING_MANAGER@DPWORLD.COM', 0, NULL, N'c017beb8-7e5e-4afd-8b55-d7feb5caef4d', N'56f26aab-c252-4572-b9fe-dc5cd277c37b', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50140', N'hc-ssp_manager', N'HC-SSP_MANAGER', N'Maged Mohsen', N'Head of HC - Samsung SDS project', 11, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'hc-ssp_manager@dpworld.com', N'HC-SSP_MANAGER@DPWORLD.COM', 0, NULL, N'344395a3-adfb-4c29-9213-103a2172a02a', N'57709cd5-6494-4f9b-bb90-aec2e6a70969', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50141', N'ops-ct_manager', N'OPS-CT_MANAGER', N'Maged Mohsen', N'Head of OPS-Containers', 14, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'ops-ct_manager@dpworld.com', N'OPS-CT_MANAGER@DPWORLD.COM', 0, NULL, N'42035649-a95c-4443-8461-d3bb7d936017', N'f32574c5-880b-428b-b24a-3d165ee37db6', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50263', N'security_manager', N'SECURITY_MANAGER', N'Ahmed Zaki', N'Head of Security', 19, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'security_manager@dpworld.com', N'SECURITY_MANAGER@DPWORLD.COM', 0, NULL, N'd5547d60-d23b-47e3-adfc-dfa484163f9f', N'bce2fe7f-156c-425f-a801-846987c5bc59', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50269', N'admin_manager', N'ADMIN_MANAGER', N'Ahmed Zaki', N'Head of Administration', 1, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'admin_manager@dpworld.com', N'ADMIN_MANGER@DPWORLD.COM', 0, NULL, N'43ef352f-0676-4111-9a82-86c24897f63e', N'0350d5ef-86b3-4f72-a79d-ab826bfa6582', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50279', N'people_manager', N'PEOPLE_MANAGER', N'Waleed Aboelgadayl', N'Head of People', 15, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'people_manager@dpworld.com', N'PEOPLE_MANAGER@DPWORLD.COM', 0, NULL, N'fe62849e-5cb5-4dac-bbdb-d4c4d9c54ffb', N'7a812790-144c-400c-a3ba-a185e609663a', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50354', N'ops-bgc_manager', N'OPS-BGC_MANAGER', N'Mohamed Radwan', N'Head of OPS-Cargo & Bulk', 13, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'ops-bgc_manager@dpworld.com', N'OPS-BGC_MANAGER@DPWORLD.COM', 0, NULL, N'25168321-4de6-443b-8c46-64908293277c', N'7c4bed13-f4e6-47cf-9010-6d32dd18805e', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50562', N'tec-planning_sec_head', N'TEC-PLANNING_SEC_HEAD', N'Ahmed Zaki', N'TEC-Planning Section Head', 21, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'tec-planning_sec_head@dpworld.com', N'TEC-PLANNING_SEC_HEAD@DPWORLD.COM', 0, NULL, N'bae93d84-e817-4d78-b1b5-47ddf62b0241', N'a42a9987-f611-4716-950c-3b18995d5f49', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50670', N'ops-ct_sec_head', N'OPS-CT_SEC_HEAD', N'Ahmed Zaki', N'OPS-Containers Section Head', 14, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'ops-ct_sec_head@dpworld.com', N'OPS-DRI_SEC_HEAD@DPWORLD.COM', 0, NULL, N'aa578934-d8e5-454e-a8c0-0dc8d63d11b4', N'9d07c6c8-a649-4337-ad1c-e14e05f7f284', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50844', N'ops-dri_sec_head', N'OPS-DRI_SEC_HEAD', N'Ahmed Zaki', N'OPS-DRI Section Head', 13, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'ops-dri_sec_head@dpworld.com', N'OPS-DRI_SEC_HEAD@DPWORLD.COM', 0, NULL, N'53132ae9-1d6e-45ab-83c6-0b2a50325c37', N'68151fe2-dcb6-48f3-83f3-17cbf970dc58', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50882', N'qhse_manager', N'QHSE_MANAGER', N'Hassan Abdelghany', N'Head of QHSE', 18, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'qhse_manager@dpworld.com', N'QHSE_MANAGER@DPWORLD.COM', 0, NULL, N'acbbd2bd-59d9-42d5-be6b-1ec900ff58e3', N'2ed82a3f-83eb-43e6-a605-13f504443821', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50962', N'gr_manager', N'GR_MANAGER', N'Mohamed Tarek', N'Head of Governmental Relation', 9, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'governmentalrelation_manager@dpworld.com', N'GOVERNMENTALRELATION_MANAGER@DPWORLD.COM', 0, NULL, N'683225c3-a8ed-40c3-a3d8-d2c60a865370', N'0973bb54-6fbd-4a91-adde-8d6b4522d177', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51090', N'tec-crane_sec_head', N'TEC-CRANE_SEC_HEAD', N'Ahmed Zaki', N'TEC-Crane Section Head', 21, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'tec-crane_sec_head@dpworld.com', N'TEC-CRANE_SEC_HEAD@DPWORLD.COM', 0, NULL, N'1c3d13ae-7680-4954-901f-b25289b93c5a', N'5e975249-7f3e-4e2b-9d29-db9c66c17d8c', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51124', N'finance_manager', N'FINANCE_MANAGER', N'Mustafa Sultan', N'Head of Finance', 8, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'finance_manager@dpworld.com', N'FINANCE_MANAGER@DPWORLD.COM', 0, NULL, N'1ff386bf-a4ae-4284-b026-45a06d8c5cd1', N'58553545-3c95-4964-8ae7-31cba9623f16', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51126', N'tec-workshop_sec_head', N'TEC-WORKSHOP_SEC_HEAD', N'Ahmed Zaki', N'TEC-Workshop Section Head', 21, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'tec-workshop_sec_head@dpworld.com', N'TEC-WORKSHOP_SEC_HEAD@DPWORLD.COM', 0, NULL, N'c3f6e9e0-df59-4c90-8cd1-4c754afaa0b1', N'38dd8837-dd11-4e6c-a320-8a7eb118312b', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51188', N'procurment_manager', N'PROCURMENT_MANAGER', N'Tamer Elsayed', N'Head of Procurment', 16, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'procurement_manager@dpworld.com', N'PROCUREMENT_MANAGER@DPWORLD.COM', 0, NULL, N'304b062a-839e-45a6-b234-66d696c177de', N'3669e54f-1187-4836-94c0-5f13f280bcb0', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51229', N'cs_manager', N'CS_MANAGER', N'Hassan Nagah', N'Head of Customer Service', 6, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'customerservice_manager@dpworld.com', N'CUSTOMERSERVICE_MANAGER@DPWORLD.COM', 0, NULL, N'cadb5f96-a017-4bd5-95d3-bb450afafaa5', N'ecf259a3-b872-4056-9349-63cb85fb1347', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51330', N'bt_manager', N'BT_MANAGER', N'Alaa Nasr', N'Head of Business Transformation', 3, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'businesstransformation_manager@dpworld.com', N'BUSINESSTRANSFORMATION_MANAGER@DPWORLD.COM', 0, NULL, N'0686a839-4f96-4cfa-ac97-8125d65e2544', N'fadc0add-36fc-4d5a-bbd5-0a05595f29e4', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51331', N'it_manager', N'IT_MANAGER', N'Alaa Nasr', N'Head of IT', 12, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'it_manager@dpworld.com', N'IT_MANAGER@DPWORLD.COM', 0, NULL, N'cde61c48-2643-4834-a1fe-8dbefd264dd1', N'4d843edb-f112-47f0-a2f0-0ee490eaf006', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51449', N'ops-cg_sec_head', N'OPS-CG_SEC_HEAD', N'Ahmed Zaki', N'OPS-Cargo & Bulk Section Head', 13, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'ops-cg_sec_head@dpworld.com', N'OPS-CG_SEC_HEAD@DPWORLD.COM', 0, NULL, N'37392a8c-f7fe-48cf-a685-2c45e34363a0', N'ea0e4014-805c-4d4f-8361-19822c9a16ce', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51509', N'commercial-ct_sec_head', N'COMMERCIAL-CT_SEC_HEAD', N'Ahmed Zaki', N'Commercial / Containers Section Head', 4, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'commercial-ct_sec_head@dpworld.com', N'ECOMMERCIAL-CT_SEC_HEAD@DPWORLD.COM', 0, NULL, N'fea55a2b-4785-4c15-877f-59811d7ce252', N'a95536b2-9ee1-438c-9750-4f319e71a1d9', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51520', N'qhse_sec_head', N'QHSE_SEC_HEAD', N'Ahmed Zaki', N'QHSE Section HEad', 18, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'qhse_sec_head@dpworld.com', N'QHSE_SEC_HEAD@DPWORLD.COM', 0, NULL, N'80942a33-c850-4691-92b9-97465298e05a', N'da64804f-695a-4952-8bfe-d75a4cb42e86', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51529', N'projects_sec_head', N'PROJECTS_SEC_HEAD', N'Ahmed Zaki', N'Projects Section Head', 21, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'projects_sec_head@dpworld.com', N'PROJECTS_SEC_HEAD@DPWORLD.COM', 0, NULL, N'15e7c0df-3e09-469c-9236-545e5ae2c4d3', N'c782d13a-44af-42de-bd58-4befcdac2730', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51572', N'hc-ds_manager', N'HC-DS_MANAGER', N'Aliaa Elgammal', N'Head of HC - DUBUY Sales', 10, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'hc-ds_manager@dpworld.com', N'HC-DS_MANAGER@DPWORLD.COM', 0, NULL, N'030bb6e2-9109-4964-88bf-f31c361bcf66', N'b5886498-cb3c-4d74-a287-d5b5ff8cb332', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51573', N'commercial_manager', N'COMMERCIAL_MANAGER', N'Aliaa Elgammal', N'Head of Commercial', 4, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'commercial_manager@dpworld.com', N'COMMERCIAL_MANAGER@DPWORLD.COM', 0, NULL, N'8bec993b-354f-4133-b735-49dcf0cf4358', N'fe20bd80-2bc5-44ff-a5c6-52f29b387a83', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51583', N'commercial-bgc_sec_head', N'COMMERCIAL-BGC_SEC_HEAD', N'Ahmed Zaki', N'CommercialBulk / GC Section Head', 4, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'commercial-bgc_sec_head@dpworld.com', N'ECOMMERCIAL-BGC_SEC_HEAD@DPWORLD.COM', 0, NULL, N'0d4a211a-4cd3-4dbb-bf9b-b435e0cfc4bc', N'6bfe8cea-840b-4fbf-92e4-c83f6ca0999a', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51659', N'projects_manager', N'PROJECTS_MANAGER', N'Mohamed Mandour', N'Head of Projects & Facility Management', 17, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'projectsfacilitymanager_manager@dpworld.com', N'PROJECTSFACILITYMANAGER_MANAGER@DPWORLD.COM', 0, NULL, N'24cbb6e6-8825-4b6a-ba53-698b67b5aa89', N'7539510f-957a-4f3c-a641-6320472a2c4c', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51668', N'communications_manager', N'COMMUNICATIONS_MANAGER', N'Amina Hatem', N'Head of Communications', 5, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'communications_manager@dpworld.com', N'COMMUNICATIONS_MANAGER@DPWORLD.COM', 0, NULL, N'3f6958ba-4ec1-4f67-8212-a017bffafadc', N'8aa0e3d7-58a8-4e65-aaf4-420b17d8e03c', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'90008', N'hc-ds_sec_head', N'HC-DS_SEC_HEAD', N'Ahmed Zaki', N'HC - DUBUY Sales Section Head', 11, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'hc-ds_sec_head@dpworld.com', N'HC-DS_SEC_HEAD@DPWORLD.COM', 0, NULL, N'1e7a64fc-4c7b-43e8-9ac5-dd507ceacd0c', N'e6f7065f-3496-4c29-9062-03a5ba86f9d8', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'90010', N'ff_manager', N'FF_MANAGER', N'Hanaa Mohamed', N'Head of Freight Forwarding', 2, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'freightforwarding_manager@dpworld.com', N'FREIGHTFORWARDING_MANAGER@DPWORLD.COM', 0, NULL, N'acc05dd0-c119-4766-b5c2-01a635b0ca30', N'38a2a7fe-2e12-4f86-bceb-30243190c8a1', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'90015', N'hc-ssp_sec_head', N'HC-SSP_SEC_HEAD', N'Ahmed Zaki', N'HC - Samsung SDS project  Section Head', 10, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'hc-ssp_sec_head@dpworld.com', N'HC-SSP_SEC_HEAD@DPWORLD.COM', 0, NULL, N'e8126543-572a-480e-9b27-46e76dab03a5', N'8d6c31ca-6b87-4963-93cb-80c0390adf47', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Exp-16', N'em_manager', N'EM_MANAGER', N'Urs Moll', N'Head of Executive Management', 7, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'executivemanagement_manager@dpworld.com', N'EXECUTIVEMANAGEMENT_MANAGER@DPWORLD.COM', 0, NULL, N'a0517324-941b-4e51-a028-a99bac3fb336', N'fcaf19ee-937b-4e5b-b4a0-9882903d18cf', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'string', N'string', N'STRING', N'string', N'string', NULL, NULL, NULL, N'string', 1, 1, NULL, CAST(N'2023-09-17T15:31:00' AS SmallDateTime), NULL, NULL, NULL, N'user@example.com', N'USER@EXAMPLE.COM', 0, N'AQAAAAIAAYagAAAAEAI5JGyKSLGlfkXRKZ0CbYuAzQUDkbdVPB93/F2kT6wcgWGklsWRUMM5g4QKyVunew==', N'RZNW7Y64POKQ3R56VLG3ZFZERIXNB2JU', N'facdd0ad-0ced-4a22-94e3-91b2c23ff61b', N'01543889566', 0, 0, NULL, 1, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'stringg', N'stringg', N'STRINGG', N'stringg', N'string', NULL, NULL, NULL, N'string', 0, 1, NULL, CAST(N'2023-09-17T15:32:00' AS SmallDateTime), NULL, NULL, NULL, N'usger@example.com', N'USGER@EXAMPLE.COM', 0, N'AQAAAAIAAYagAAAAEOpT/V3Ys0L/7tbjIJTTaCHjtDKnEaaVgyH8LXTh7qPQLU8efHqhMoJIYjkQSCZ0XQ==', N'CARHMI2SCO4TOE67DLEIVD7U4JIFLRBM', N'a318c458-cb44-4f18-982d-f396ef2ba632', N'01543889566', 0, 0, CAST(N'2023-09-24T11:12:08.9021249+00:00' AS DateTimeOffset), 1, 0)
GO
/****** Object:  Index [IX_ApplicationItAdmin_ApplicationId]    Script Date: 9/18/2023 8:41:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_ApplicationItAdmin_ApplicationId] ON [dbo].[ApplicationItAdmin]
(
	[ApplicationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ApplicationUserRequest_RequestId]    Script Date: 9/18/2023 8:41:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_ApplicationUserRequest_RequestId] ON [dbo].[ApplicationUserRequest]
(
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Attachment_RequestId]    Script Date: 9/18/2023 8:41:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_Attachment_RequestId] ON [dbo].[Attachment]
(
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CarRequest_RequestId]    Script Date: 9/18/2023 8:41:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_CarRequest_RequestId] ON [dbo].[CarRequest]
(
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_DefinedApplication_ApplicationOwnerId]    Script Date: 9/18/2023 8:41:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_DefinedApplication_ApplicationOwnerId] ON [dbo].[DefinedApplication]
(
	[ApplicationOwnerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DefinedApplicationRole_RequestedApplicationId]    Script Date: 9/18/2023 8:41:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_DefinedApplicationRole_RequestedApplicationId] ON [dbo].[DefinedApplicationRole]
(
	[RequestedApplicationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DefinedRequest_DepartmentId]    Script Date: 9/18/2023 8:41:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_DefinedRequest_DepartmentId] ON [dbo].[DefinedRequest]
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_DefinedRequestReviewer_ReviewerId]    Script Date: 9/18/2023 8:41:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_DefinedRequestReviewer_ReviewerId] ON [dbo].[DefinedRequestReviewer]
(
	[ReviewerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DefinedRequestRole_DefinedRequestId]    Script Date: 9/18/2023 8:41:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_DefinedRequestRole_DefinedRequestId] ON [dbo].[DefinedRequestRole]
(
	[DefinedRequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Department_ManagerId]    Script Date: 9/18/2023 8:41:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_Department_ManagerId] ON [dbo].[Department]
(
	[ManagerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DomainAccountRequest_RequestId]    Script Date: 9/18/2023 8:41:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_DomainAccountRequest_RequestId] ON [dbo].[DomainAccountRequest]
(
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_PoRequest_InvoiceNumber]    Script Date: 9/18/2023 8:41:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_PoRequest_InvoiceNumber] ON [dbo].[PoRequest]
(
	[InvoiceNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_PoRequest_PoDescription]    Script Date: 9/18/2023 8:41:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_PoRequest_PoDescription] ON [dbo].[PoRequest]
(
	[PoDescription] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_PoRequest_RequestId]    Script Date: 9/18/2023 8:41:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_PoRequest_RequestId] ON [dbo].[PoRequest]
(
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_PoRequest_VendorName]    Script Date: 9/18/2023 8:41:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_PoRequest_VendorName] ON [dbo].[PoRequest]
(
	[VendorName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_PoRequest_VendorNumber]    Script Date: 9/18/2023 8:41:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_PoRequest_VendorNumber] ON [dbo].[PoRequest]
(
	[VendorNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Request_CreatorId]    Script Date: 9/18/2023 8:41:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_Request_CreatorId] ON [dbo].[Request]
(
	[CreatorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Request_DefinedRequestId]    Script Date: 9/18/2023 8:41:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_Request_DefinedRequestId] ON [dbo].[Request]
(
	[DefinedRequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_RequestApplicationRole_ApplicationId]    Script Date: 9/18/2023 8:41:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_RequestApplicationRole_ApplicationId] ON [dbo].[RequestApplicationRole]
(
	[ApplicationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_RequestApplicationRole_RoleId]    Script Date: 9/18/2023 8:41:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_RequestApplicationRole_RoleId] ON [dbo].[RequestApplicationRole]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_RequestReviewer_ReviewerId]    Script Date: 9/18/2023 8:41:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_RequestReviewer_ReviewerId] ON [dbo].[RequestReviewer]
(
	[ReviewerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Section_DepartmentId]    Script Date: 9/18/2023 8:41:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_Section_DepartmentId] ON [dbo].[Section]
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Section_HeadId]    Script Date: 9/18/2023 8:41:40 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Section_HeadId] ON [dbo].[Section]
(
	[HeadId] ASC
)
WHERE ([HeadId] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_TravelDeskRequest_RequestId]    Script Date: 9/18/2023 8:41:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_TravelDeskRequest_RequestId] ON [dbo].[TravelDeskRequest]
(
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_VoucherRequest_RequestId]    Script Date: 9/18/2023 8:41:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_VoucherRequest_RequestId] ON [dbo].[VoucherRequest]
(
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 9/18/2023 8:41:40 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [security].[Role]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_RoleClaims_RoleId]    Script Date: 9/18/2023 8:41:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_RoleClaims_RoleId] ON [security].[RoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 9/18/2023 8:41:40 AM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [security].[User]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_User_DepartmentId]    Script Date: 9/18/2023 8:41:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_User_DepartmentId] ON [security].[User]
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_User_ManagerId]    Script Date: 9/18/2023 8:41:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_User_ManagerId] ON [security].[User]
(
	[ManagerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_User_SectionId]    Script Date: 9/18/2023 8:41:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_User_SectionId] ON [security].[User]
(
	[SectionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 9/18/2023 8:41:40 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [security].[User]
(
	[NormalizedUserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserClaims_UserId]    Script Date: 9/18/2023 8:41:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_UserClaims_UserId] ON [security].[UserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserLogin_UserId]    Script Date: 9/18/2023 8:41:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_UserLogin_UserId] ON [security].[UserLogin]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserRoles_RoleId]    Script Date: 9/18/2023 8:41:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_UserRoles_RoleId] ON [security].[UserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
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
