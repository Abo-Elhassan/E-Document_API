USE [master]
GO
/****** Object:  Database [E-Document]    Script Date: 9/19/2023 8:31:57 AM ******/
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
/****** Object:  Schema [security]    Script Date: 9/19/2023 8:31:57 AM ******/
CREATE SCHEMA [security]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 9/19/2023 8:31:57 AM ******/
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
/****** Object:  Table [dbo].[ApplicationItAdmin]    Script Date: 9/19/2023 8:31:57 AM ******/
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
/****** Object:  Table [dbo].[ApplicationUserRequest]    Script Date: 9/19/2023 8:31:57 AM ******/
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
/****** Object:  Table [dbo].[Attachment]    Script Date: 9/19/2023 8:31:57 AM ******/
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
/****** Object:  Table [dbo].[CarRequest]    Script Date: 9/19/2023 8:31:57 AM ******/
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
/****** Object:  Table [dbo].[DefinedApplication]    Script Date: 9/19/2023 8:31:57 AM ******/
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
/****** Object:  Table [dbo].[DefinedApplicationRole]    Script Date: 9/19/2023 8:31:57 AM ******/
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
/****** Object:  Table [dbo].[DefinedRequest]    Script Date: 9/19/2023 8:31:57 AM ******/
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
/****** Object:  Table [dbo].[DefinedRequestReviewer]    Script Date: 9/19/2023 8:31:57 AM ******/
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
/****** Object:  Table [dbo].[DefinedRequestRole]    Script Date: 9/19/2023 8:31:57 AM ******/
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
/****** Object:  Table [dbo].[Department]    Script Date: 9/19/2023 8:31:57 AM ******/
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
/****** Object:  Table [dbo].[DomainAccountRequest]    Script Date: 9/19/2023 8:31:57 AM ******/
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
/****** Object:  Table [dbo].[PoRequest]    Script Date: 9/19/2023 8:31:57 AM ******/
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
	[RequestId] ASC,
	[PoNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Request]    Script Date: 9/19/2023 8:31:57 AM ******/
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
/****** Object:  Table [dbo].[RequestApplicationRole]    Script Date: 9/19/2023 8:31:57 AM ******/
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
/****** Object:  Table [dbo].[RequestReviewer]    Script Date: 9/19/2023 8:31:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RequestReviewer](
	[RequestId] [bigint] NOT NULL,
	[ReviewerId] [nvarchar](50) NOT NULL,
	[StageName] [nvarchar](max) NULL,
	[StageNumber] [int] NOT NULL,
	[ReviewerType] [nvarchar](50) NOT NULL,
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
/****** Object:  Table [dbo].[Section]    Script Date: 9/19/2023 8:31:57 AM ******/
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
/****** Object:  Table [dbo].[TravelDeskRequest]    Script Date: 9/19/2023 8:31:57 AM ******/
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
/****** Object:  Table [dbo].[VoucherRequest]    Script Date: 9/19/2023 8:31:57 AM ******/
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
/****** Object:  Table [security].[Role]    Script Date: 9/19/2023 8:31:57 AM ******/
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
/****** Object:  Table [security].[RoleClaims]    Script Date: 9/19/2023 8:31:57 AM ******/
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
/****** Object:  Table [security].[User]    Script Date: 9/19/2023 8:31:57 AM ******/
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
/****** Object:  Table [security].[UserClaims]    Script Date: 9/19/2023 8:31:57 AM ******/
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
/****** Object:  Table [security].[UserLogin]    Script Date: 9/19/2023 8:31:57 AM ******/
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
/****** Object:  Table [security].[UserRoles]    Script Date: 9/19/2023 8:31:57 AM ******/
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
/****** Object:  Table [security].[UserToken]    Script Date: 9/19/2023 8:31:57 AM ******/
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
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230918061834_seedPoRequest', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230918083241_changePoRequestRelation', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230919052910_assignRolesWithPermissions', N'7.0.10')
GO
SET IDENTITY_INSERT [dbo].[DefinedRequest] ON 

INSERT [dbo].[DefinedRequest] ([Id], [RequestName], [RouteName], [ReviewersNumber], [DepartmentId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (1, N'PO', N'/Procurement/PO/', 1, 16, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[DefinedRequest] OFF
GO
INSERT [dbo].[DefinedRequestReviewer] ([DefinedRequestId], [ReviewerId], [DelegatedReviewerId], [StageName], [StageNumber], [ReviewerType], [DelegatedUntil], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (1, N'51124', NULL, N'Finance Reviewer', 1, N'Basic', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[DefinedRequestRole] ([RoleId], [DefinedRequestId], [Permission], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'82cae434-a43f-4f98-86d2-4de5205a410f', 1, N'Request', NULL, NULL, NULL, NULL)
INSERT [dbo].[DefinedRequestRole] ([RoleId], [DefinedRequestId], [Permission], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'9a8e4316-c998-4125-a9ef-af391a9f8243', 1, N'Review', NULL, NULL, NULL, NULL)
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
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.75-4+', N'Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat.', N'Bertram Creed', N'15', N'3559220464786113', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 203, CAST(N'2022-09-24T00:00:00' AS SmallDateTime), CAST(N'2023-02-21T00:00:00' AS SmallDateTime), N'bcreede', N'bcreede')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.91-4+', N'Vestibulum ac est lacinia nisi venenatis tristique. Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue.', N'Gaven Ricart', N'29', N'4026900139327814', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 205, CAST(N'2023-06-23T00:00:00' AS SmallDateTime), CAST(N'2023-09-04T00:00:00' AS SmallDateTime), N'gricarts', N'gricarts')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.16-1+', N'Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat. Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede. Morbi porttitor lorem id ligula.', N'Yolane Padmore', N'20', N'5280763276227918', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 208, CAST(N'2023-01-20T00:00:00' AS SmallDateTime), CAST(N'2023-07-04T00:00:00' AS SmallDateTime), N'ypadmorej', N'ypadmorej')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.73-6+', N'Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh. In quis justo.', N'Irene Maddigan', N'6', N'5018786633938378879', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 209, CAST(N'2023-01-30T00:00:00' AS SmallDateTime), CAST(N'2022-10-10T00:00:00' AS SmallDateTime), N'imaddigan5', N'imaddigan5')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.59-4+', N'Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nulla dapibus dolor vel est. Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros. Vestibulum ac est lacinia nisi venenatis tristique. Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue. Aliquam erat volutpat.', N'Harland Linck', N'28', N'3561438207757177', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 214, CAST(N'2023-07-19T00:00:00' AS SmallDateTime), CAST(N'2023-07-02T00:00:00' AS SmallDateTime), N'hlinckr', N'hlinckr')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.09-8+', N'Vestibulum sed magna at nunc commodo placerat. Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede. Morbi porttitor lorem id ligula. Suspendisse ornare consequat lectus.', N'Andi Steward', N'18', N'3571748594742006', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 216, CAST(N'2023-07-05T00:00:00' AS SmallDateTime), CAST(N'2023-01-28T00:00:00' AS SmallDateTime), N'astewardh', N'astewardh')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.86-4+', N'Phasellus id sapien in sapien iaculis congue. Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl.', N'Reina Stoves', N'21', N'3544603271795203', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 218, CAST(N'2022-11-06T00:00:00' AS SmallDateTime), CAST(N'2023-01-01T00:00:00' AS SmallDateTime), N'rstovesk', N'rstovesk')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.15-3+', N'Duis bibendum. Morbi non quam nec dui luctus rutrum. Nulla tellus. In sagittis dui vel nisl.', N'Corrinne Braidford', N'16', N'6334209994908064926', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 222, CAST(N'2023-08-24T00:00:00' AS SmallDateTime), CAST(N'2023-05-03T00:00:00' AS SmallDateTime), N'cbraidfordf', N'cbraidfordf')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.27-9+', N'Fusce consequat.', N'Pia McNess', N'1', N'3573809752532338', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 224, CAST(N'2023-01-29T00:00:00' AS SmallDateTime), CAST(N'2023-06-25T00:00:00' AS SmallDateTime), N'pmcness0', N'pmcness0')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.06-6+', N'Maecenas ut massa quis augue luctus tincidunt. Nulla mollis molestie lorem. Quisque ut erat. Curabitur gravida nisi at nibh. In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat.', N'Ringo Waywell', N'23', N'374014173195271', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 228, CAST(N'2022-09-26T00:00:00' AS SmallDateTime), CAST(N'2023-03-13T00:00:00' AS SmallDateTime), N'rwaywellm', N'rwaywellm')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.68-7+', N'Nulla mollis molestie lorem. Quisque ut erat. Curabitur gravida nisi at nibh. In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat.', N'Max Dahlback', N'11', N'3528961373803246', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 238, CAST(N'2023-07-24T00:00:00' AS SmallDateTime), CAST(N'2022-12-06T00:00:00' AS SmallDateTime), N'mdahlbacka', N'mdahlbacka')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.77-4+', N'Nullam molestie nibh in lectus. Pellentesque at nulla. Suspendisse potenti. Cras in purus eu magna vulputate luctus. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vivamus vestibulum sagittis sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Etiam vel augue.', N'Datha Blampied', N'12', N'3562373062410845', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 239, CAST(N'2023-04-23T00:00:00' AS SmallDateTime), CAST(N'2023-05-23T00:00:00' AS SmallDateTime), N'dblampiedb', N'dblampiedb')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.46-9+', N'Curabitur convallis. Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor. Morbi vel lectus in quam fringilla rhoncus. Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis. Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero.', N'Tanny Sporton', N'49', N'3574363464482431', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 248, CAST(N'2023-03-14T00:00:00' AS SmallDateTime), CAST(N'2023-08-29T00:00:00' AS SmallDateTime), N'tsporton1c', N'tsporton1c')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.27-2+', N'Etiam vel augue. Vestibulum rutrum rutrum neque. Aenean auctor gravida sem. Praesent id massa id nisl venenatis lacinia. Aenean sit amet justo. Morbi ut odio. Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo. In blandit ultrices enim.', N'Kaela Pirt', N'8', N'3559293680994761', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 250, CAST(N'2023-03-22T00:00:00' AS SmallDateTime), CAST(N'2022-12-26T00:00:00' AS SmallDateTime), N'kpirt7', N'kpirt7')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.10-5+', N'In congue. Etiam justo. Etiam pretium iaculis justo.', N'Corabella Tolussi', N'33', N'3528465889009751', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 252, CAST(N'2023-02-09T00:00:00' AS SmallDateTime), CAST(N'2022-12-20T00:00:00' AS SmallDateTime), N'ctolussiw', N'ctolussiw')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.25-5+', N'Duis mattis egestas metus. Aenean fermentum.', N'Obadias Linstead', N'42', N'3535149896560565', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 253, CAST(N'2022-12-20T00:00:00' AS SmallDateTime), CAST(N'2023-09-10T00:00:00' AS SmallDateTime), N'olinstead15', N'olinstead15')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.11-7+', N'In est risus, auctor sed, tristique in, tempus sit amet, sem. Fusce consequat. Nulla nisl. Nunc nisl. Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa.', N'Jarrad Biaggi', N'24', N'5010129106754330', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 254, CAST(N'2022-11-18T00:00:00' AS SmallDateTime), CAST(N'2023-03-09T00:00:00' AS SmallDateTime), N'jbiaggin', N'jbiaggin')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.50-9+', N'Praesent lectus. Vestibulum quam sapien, varius ut, blandit non, interdum in, ante. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio. Curabitur convallis.', N'Lory Malacrida', N'45', N'3554509272156914', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 259, CAST(N'2023-03-06T00:00:00' AS SmallDateTime), CAST(N'2022-10-18T00:00:00' AS SmallDateTime), N'lmalacrida18', N'lmalacrida18')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.52-1+', N'Vestibulum ac est lacinia nisi venenatis tristique. Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue. Aliquam erat volutpat.', N'Dev Brame', N'5', N'6767147846678208065', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 271, CAST(N'2023-06-17T00:00:00' AS SmallDateTime), CAST(N'2023-01-11T00:00:00' AS SmallDateTime), N'dbrame4', N'dbrame4')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.20-7+', N'Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Etiam vel augue. Vestibulum rutrum rutrum neque. Aenean auctor gravida sem. Praesent id massa id nisl venenatis lacinia. Aenean sit amet justo. Morbi ut odio. Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo. In blandit ultrices enim. Lorem ipsum dolor sit amet, consectetuer adipiscing elit.', N'Bronnie Dominguez', N'35', N'3578659126215812', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 272, CAST(N'2023-04-13T00:00:00' AS SmallDateTime), CAST(N'2023-06-05T00:00:00' AS SmallDateTime), N'bdominguezy', N'bdominguezy')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.14-4+', N'Donec ut dolor. Morbi vel lectus in quam fringilla rhoncus.', N'Denna Frame', N'37', N'5610496641795480', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 273, CAST(N'2023-08-03T00:00:00' AS SmallDateTime), CAST(N'2023-08-20T00:00:00' AS SmallDateTime), N'dframe10', N'dframe10')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.21-4+', N'Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue. Aliquam erat volutpat. In congue. Etiam justo.', N'Merline Fuzzens', N'32', N'493666448873988516', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 276, CAST(N'2022-10-15T00:00:00' AS SmallDateTime), CAST(N'2023-06-03T00:00:00' AS SmallDateTime), N'mfuzzensv', N'mfuzzensv')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.20-3+', N'Duis mattis egestas metus.', N'Killie Walthall', N'50', N'5602223460289274', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 277, CAST(N'2023-01-02T00:00:00' AS SmallDateTime), CAST(N'2022-10-16T00:00:00' AS SmallDateTime), N'kwalthall1d', N'kwalthall1d')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.15-8+', N'Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Etiam vel augue. Vestibulum rutrum rutrum neque. Aenean auctor gravida sem. Praesent id massa id nisl venenatis lacinia. Aenean sit amet justo.', N'Jacky Woodhouse', N'14', N'3552009821673925', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 278, CAST(N'2023-03-03T00:00:00' AS SmallDateTime), CAST(N'2023-06-27T00:00:00' AS SmallDateTime), N'jwoodhoused', N'jwoodhoused')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.22-1+', N'Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus.', N'Carroll Banasiak', N'13', N'3532846423299657', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 279, CAST(N'2023-05-29T00:00:00' AS SmallDateTime), CAST(N'2023-07-04T00:00:00' AS SmallDateTime), N'cbanasiakc', N'cbanasiakc')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.27-8+', N'Nulla nisl.', N'Terrance Willcocks', N'34', N'06047395989808916', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 280, CAST(N'2023-03-10T00:00:00' AS SmallDateTime), CAST(N'2022-09-24T00:00:00' AS SmallDateTime), N'twillcocksx', N'twillcocksx')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.38-9+', N'Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus.', N'Farra Patrickson', N'25', N'6771344448383248875', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 281, CAST(N'2022-11-11T00:00:00' AS SmallDateTime), CAST(N'2023-04-18T00:00:00' AS SmallDateTime), N'fpatricksono', N'fpatricksono')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.29-7+', N'In eleifend quam a odio.', N'Liuka Neesham', N'36', N'503888007560133212', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 282, CAST(N'2023-03-13T00:00:00' AS SmallDateTime), CAST(N'2022-10-16T00:00:00' AS SmallDateTime), N'lneeshamz', N'lneeshamz')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.30-7+', N'Vivamus vestibulum sagittis sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.', N'Celene Cordsen', N'17', N'6334941117489021684', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 283, CAST(N'2023-09-02T00:00:00' AS SmallDateTime), CAST(N'2023-04-28T00:00:00' AS SmallDateTime), N'ccordseng', N'ccordseng')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.31-4+', N'Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat. Praesent blandit. Nam nulla.', N'Rowena Twaits', N'40', N'56022171565601205', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 284, CAST(N'2022-10-23T00:00:00' AS SmallDateTime), CAST(N'2023-03-10T00:00:00' AS SmallDateTime), N'rtwaits13', N'rtwaits13')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.38-2+', N'Praesent id massa id nisl venenatis lacinia. Aenean sit amet justo. Morbi ut odio. Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo. In blandit ultrices enim. Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin interdum mauris non ligula pellentesque ultrices.', N'Clifford Peachey', N'39', N'3579204957590915', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 285, CAST(N'2023-09-09T00:00:00' AS SmallDateTime), CAST(N'2023-01-24T00:00:00' AS SmallDateTime), N'cpeachey12', N'cpeachey12')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.43-8+', N'Maecenas tincidunt lacus at velit. Vivamus vel nulla eget eros elementum pellentesque. Quisque porta volutpat erat. Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus. Phasellus in felis. Donec semper sapien a libero. Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis.', N'Eugenius Dongall', N'48', N'3557518638220907', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 286, CAST(N'2022-12-24T00:00:00' AS SmallDateTime), CAST(N'2023-02-16T00:00:00' AS SmallDateTime), N'edongall1b', N'edongall1b')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.45-7+', N'Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat.', N'Luz Harnott', N'31', N'3528061060197505', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 287, CAST(N'2023-05-23T00:00:00' AS SmallDateTime), CAST(N'2023-04-26T00:00:00' AS SmallDateTime), N'lharnottu', N'lharnottu')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.46-7+', N'Cras pellentesque volutpat dui. Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti. Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum.', N'Christi Coggles', N'41', N'3578607582022321', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 288, CAST(N'2023-04-22T00:00:00' AS SmallDateTime), CAST(N'2023-05-01T00:00:00' AS SmallDateTime), N'ccoggles14', N'ccoggles14')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.53-3+', N'Suspendisse potenti.', N'Nicol Brea', N'43', N'3557568285973316', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 289, CAST(N'2022-10-01T00:00:00' AS SmallDateTime), CAST(N'2023-05-08T00:00:00' AS SmallDateTime), N'nbrea16', N'nbrea16')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.55-3+', N'Pellentesque ultrices mattis odio. Donec vitae nisi. Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus. Curabitur at ipsum ac tellus semper interdum.', N'Fidole Babcock', N'22', N'3579409999230269', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 290, CAST(N'2023-03-31T00:00:00' AS SmallDateTime), CAST(N'2023-01-01T00:00:00' AS SmallDateTime), N'fbabcockl', N'fbabcockl')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.55-4+', N'Nunc purus. Phasellus in felis. Donec semper sapien a libero. Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla.', N'Sheelagh McCunn', N'26', N'3576928668581804', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 291, CAST(N'2023-08-26T00:00:00' AS SmallDateTime), CAST(N'2023-04-06T00:00:00' AS SmallDateTime), N'smccunnp', N'smccunnp')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.57-8+', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin interdum mauris non ligula pellentesque ultrices. Phasellus id sapien in sapien iaculis congue.', N'Nydia Colchett', N'47', N'3573720130982808', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 292, CAST(N'2023-05-03T00:00:00' AS SmallDateTime), CAST(N'2023-09-12T00:00:00' AS SmallDateTime), N'ncolchett1a', N'ncolchett1a')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.62-7+', N'In eleifend quam a odio. In hac habitasse platea dictumst. Maecenas ut massa quis augue luctus tincidunt. Nulla mollis molestie lorem. Quisque ut erat. Curabitur gravida nisi at nibh. In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat.', N'Kania Danton', N'2', N'6333956052258700933', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 293, CAST(N'2023-05-15T00:00:00' AS SmallDateTime), CAST(N'2023-07-15T00:00:00' AS SmallDateTime), N'kdanton1', N'kdanton1')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.73-3+', N'Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl. Nunc rhoncus dui vel sem. Sed sagittis. Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus. Pellentesque at nulla. Suspendisse potenti. Cras in purus eu magna vulputate luctus. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.', N'Krisha Franciottoi', N'10', N'3552245872273856', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 294, CAST(N'2023-08-16T00:00:00' AS SmallDateTime), CAST(N'2022-10-11T00:00:00' AS SmallDateTime), N'kfranciottoi9', N'kfranciottoi9')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.82-0+', N'Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus. Phasellus in felis. Donec semper sapien a libero.', N'Avrit Blount', N'46', N'3578244889741609', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 295, CAST(N'2023-08-12T00:00:00' AS SmallDateTime), CAST(N'2023-07-12T00:00:00' AS SmallDateTime), N'ablount19', N'ablount19')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.82-2+', N'Vestibulum ac est lacinia nisi venenatis tristique. Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue. Aliquam erat volutpat. In congue. Etiam justo. Etiam pretium iaculis justo.', N'Marita Klaggeman', N'4', N'6371622373105872', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 296, CAST(N'2023-04-02T00:00:00' AS SmallDateTime), CAST(N'2023-05-27T00:00:00' AS SmallDateTime), N'mklaggeman3', N'mklaggeman3')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.86-0+', N'Integer ac neque. Duis bibendum.', N'Frederica Pressman', N'27', N'3561827226709773', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 297, CAST(N'2022-12-05T00:00:00' AS SmallDateTime), CAST(N'2023-07-29T00:00:00' AS SmallDateTime), N'fpressmanq', N'fpressmanq')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.86-1+', N'Aliquam erat volutpat. In congue. Etiam justo. Etiam pretium iaculis justo. In hac habitasse platea dictumst. Etiam faucibus cursus urna. Ut tellus. Nulla ut erat id mauris vulputate elementum. Nullam varius.', N'Arline Cossem', N'19', N'4911613110784514267', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 298, CAST(N'2022-11-23T00:00:00' AS SmallDateTime), CAST(N'2022-11-07T00:00:00' AS SmallDateTime), N'acossemi', N'acossemi')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'SOK.PO.87-6+', N'Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat. Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede. Morbi porttitor lorem id ligula. Suspendisse ornare consequat lectus. In est risus, auctor sed, tristique in, tempus sit amet, sem. Fusce consequat. Nulla nisl.', N'Jo Hanshaw', N'3', N'3544715717139539', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 299, CAST(N'2023-04-19T00:00:00' AS SmallDateTime), CAST(N'2023-06-26T00:00:00' AS SmallDateTime), N'jhanshaw2', N'jhanshaw2')
GO
SET IDENTITY_INSERT [dbo].[Request] ON 

INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (201, 0, N'Pending', N'Vestibulum quam sapien, varius ut, blandit non, interdum in, ante. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio. Curabitur convallis. Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor.', N'51188', N'ugroome0', 1, CAST(N'2023-08-30T00:00:00' AS SmallDateTime), CAST(N'2023-03-11T00:00:00' AS SmallDateTime), N'ccanadas0', N'aleaver0')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (202, 0, N'Approved', N'Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus. Curabitur at ipsum ac tellus semper interdum. Mauris ullamcorper purus sit amet nulla. Quisque arcu libero, rutrum ac, lobortis vel, dapibus at, diam. Nam tristique tortor eu pede.', N'51188', N'jdominiak1', 1, CAST(N'2022-09-28T00:00:00' AS SmallDateTime), CAST(N'2023-07-14T00:00:00' AS SmallDateTime), N'pdewinton1', N'cmckirdy1')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (203, 0, N'Pending', N'Morbi vel lectus in quam fringilla rhoncus. Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis. Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh. In quis justo. Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet.', N'51188', N'ddeandisie2', 1, CAST(N'2023-07-16T00:00:00' AS SmallDateTime), CAST(N'2023-09-08T00:00:00' AS SmallDateTime), N'sgreenlees2', N'mfawdrie2')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (204, 1, N'Declined', N'Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat.', N'51188', N'mdebeauchemp3', 1, CAST(N'2023-08-26T00:00:00' AS SmallDateTime), CAST(N'2023-04-06T00:00:00' AS SmallDateTime), N'mwharby3', N'rdobbins3')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (205, 0, N'Pending', N'Suspendisse ornare consequat lectus. In est risus, auctor sed, tristique in, tempus sit amet, sem. Fusce consequat. Nulla nisl. Nunc nisl. Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus. Duis at velit eu est congue elementum. In hac habitasse platea dictumst. Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante.', N'51188', N'dchadwin4', 1, CAST(N'2023-02-25T00:00:00' AS SmallDateTime), CAST(N'2023-03-31T00:00:00' AS SmallDateTime), N'edenham4', N'jbatrim4')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (206, 0, N'Pending', N'Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum. Aliquam non mauris. Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet.', N'51188', N'kdalgarno5', 1, CAST(N'2023-08-14T00:00:00' AS SmallDateTime), CAST(N'2023-02-19T00:00:00' AS SmallDateTime), N'wdawidman5', N'pwoodsford5')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (207, 1, N'Approved', N'Vivamus vestibulum sagittis sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Etiam vel augue. Vestibulum rutrum rutrum neque. Aenean auctor gravida sem. Praesent id massa id nisl venenatis lacinia. Aenean sit amet justo. Morbi ut odio. Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo.', N'51188', N'jdiego6', 1, CAST(N'2022-11-16T00:00:00' AS SmallDateTime), CAST(N'2022-10-14T00:00:00' AS SmallDateTime), N'jmoine6', N'hrunnett6')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (208, 1, N'Pending', N'Donec vitae nisi. Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus. Curabitur at ipsum ac tellus semper interdum. Mauris ullamcorper purus sit amet nulla.', N'51188', N'ntilly7', 1, CAST(N'2023-04-11T00:00:00' AS SmallDateTime), CAST(N'2023-07-13T00:00:00' AS SmallDateTime), N'scristea7', N'dlerohan7')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (209, 0, N'Approved', N'Mauris sit amet eros. Suspendisse accumsan tortor quis turpis. Sed ante. Vivamus tortor. Duis mattis egestas metus.', N'51188', N'twinfred8', 1, CAST(N'2023-01-04T00:00:00' AS SmallDateTime), CAST(N'2023-03-15T00:00:00' AS SmallDateTime), N'blattey8', N'slavell8')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (210, 0, N'Pending', N'Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis. Ut at dolor quis odio consequat varius. Integer ac leo. Pellentesque ultrices mattis odio. Donec vitae nisi.', N'51188', N'jkilmary9', 1, CAST(N'2023-09-04T00:00:00' AS SmallDateTime), CAST(N'2023-03-07T00:00:00' AS SmallDateTime), N'ebreese9', N'mpesselt9')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (211, 1, N'Pending', N'Suspendisse potenti. In eleifend quam a odio. In hac habitasse platea dictumst. Maecenas ut massa quis augue luctus tincidunt. Nulla mollis molestie lorem. Quisque ut erat. Curabitur gravida nisi at nibh.', N'51188', N'wwhiteforda', 1, CAST(N'2023-09-09T00:00:00' AS SmallDateTime), CAST(N'2023-07-15T00:00:00' AS SmallDateTime), N'mgavozzia', N'aabthorpea')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (212, 0, N'Approved', N'Donec posuere metus vitae ipsum. Aliquam non mauris. Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet.', N'51188', N'jmcnabbb', 1, CAST(N'2023-06-04T00:00:00' AS SmallDateTime), CAST(N'2023-09-12T00:00:00' AS SmallDateTime), N'sposnettb', N'aportwaineb')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (213, 1, N'Pending', N'In hac habitasse platea dictumst. Maecenas ut massa quis augue luctus tincidunt. Nulla mollis molestie lorem.', N'51188', N'mshowellc', 1, CAST(N'2023-05-31T00:00:00' AS SmallDateTime), CAST(N'2023-05-15T00:00:00' AS SmallDateTime), N'kmcleodc', N'lbalhatchetc')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (214, 1, N'Approved', N'Ut at dolor quis odio consequat varius. Integer ac leo. Pellentesque ultrices mattis odio.', N'51188', N'dpatriched', 1, CAST(N'2023-08-23T00:00:00' AS SmallDateTime), CAST(N'2023-07-16T00:00:00' AS SmallDateTime), N'kgavrield', N'tbreawoodd')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (215, 1, N'Declined', N'Nunc purus. Phasellus in felis. Donec semper sapien a libero. Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis. Ut at dolor quis odio consequat varius.', N'51188', N'rvandervliese', 1, CAST(N'2022-09-27T00:00:00' AS SmallDateTime), CAST(N'2023-06-07T00:00:00' AS SmallDateTime), N'rfarakere', N'ejoddense')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (216, 1, N'Pending', N'Donec posuere metus vitae ipsum. Aliquam non mauris. Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis.', N'51188', N'mverneyf', 1, CAST(N'2023-05-14T00:00:00' AS SmallDateTime), CAST(N'2022-09-29T00:00:00' AS SmallDateTime), N'araynorf', N'wrickerbyf')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (217, 0, N'Declined', N'In hac habitasse platea dictumst.', N'51188', N'marberg', 1, CAST(N'2023-05-24T00:00:00' AS SmallDateTime), CAST(N'2023-09-04T00:00:00' AS SmallDateTime), N'dfindleyg', N'tsaterthwaitg')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (218, 1, N'Pending', N'Praesent lectus. Vestibulum quam sapien, varius ut, blandit non, interdum in, ante. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio. Curabitur convallis. Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor. Morbi vel lectus in quam fringilla rhoncus. Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis. Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero.', N'51188', N'rcourtinh', 1, CAST(N'2023-08-04T00:00:00' AS SmallDateTime), CAST(N'2023-07-04T00:00:00' AS SmallDateTime), N'dleggitth', N'hramelh')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (219, 0, N'Approved', N'Phasellus sit amet erat. Nulla tempus. Vivamus in felis eu sapien cursus vestibulum. Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy.', N'51188', N'gschaumakeri', 1, CAST(N'2022-11-26T00:00:00' AS SmallDateTime), CAST(N'2022-10-06T00:00:00' AS SmallDateTime), N'mstollenwercki', N'akoppi')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (220, 1, N'Pending', N'Nulla tempus. Vivamus in felis eu sapien cursus vestibulum. Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy. Integer non velit. Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue.', N'51188', N'trattj', 1, CAST(N'2022-11-14T00:00:00' AS SmallDateTime), CAST(N'2023-02-18T00:00:00' AS SmallDateTime), N'sliffj', N'mbendlej')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (221, 1, N'Approved', N'In hac habitasse platea dictumst. Etiam faucibus cursus urna. Ut tellus. Nulla ut erat id mauris vulputate elementum.', N'51188', N'drobeyk', 1, CAST(N'2023-09-03T00:00:00' AS SmallDateTime), CAST(N'2023-08-04T00:00:00' AS SmallDateTime), N'adriuttik', N'klucak')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (222, 0, N'Approved', N'Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus. Suspendisse potenti. In eleifend quam a odio.', N'51188', N'tmustool', 1, CAST(N'2022-09-20T00:00:00' AS SmallDateTime), CAST(N'2022-11-25T00:00:00' AS SmallDateTime), N'bmettsl', N'mandresl')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (223, 0, N'Pending', N'Morbi non quam nec dui luctus rutrum. Nulla tellus. In sagittis dui vel nisl.', N'51188', N'lbeausangm', 1, CAST(N'2023-07-19T00:00:00' AS SmallDateTime), CAST(N'2023-01-10T00:00:00' AS SmallDateTime), N'cmccurleym', N'mduffillm')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (224, 1, N'Pending', N'Phasellus sit amet erat. Nulla tempus. Vivamus in felis eu sapien cursus vestibulum. Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy.', N'51188', N'djeramsn', 1, CAST(N'2023-08-30T00:00:00' AS SmallDateTime), CAST(N'2023-02-16T00:00:00' AS SmallDateTime), N'rwalderan', N'eboothebien')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (225, 0, N'Pending', N'Vestibulum rutrum rutrum neque.', N'51188', N'fmackibbono', 1, CAST(N'2022-11-09T00:00:00' AS SmallDateTime), CAST(N'2023-05-21T00:00:00' AS SmallDateTime), N'ahouldino', N'rcraiggo')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (226, 1, N'Pending', N'Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis. Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl. Nunc rhoncus dui vel sem. Sed sagittis. Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci.', N'51188', N'ltrustiep', 1, CAST(N'2023-04-29T00:00:00' AS SmallDateTime), CAST(N'2022-12-14T00:00:00' AS SmallDateTime), N'rdantuonip', N'mabbessp')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (227, 1, N'Declined', N'Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante.', N'51188', N'sdyasq', 1, CAST(N'2023-08-09T00:00:00' AS SmallDateTime), CAST(N'2022-10-18T00:00:00' AS SmallDateTime), N'vpierucciq', N'vbernardotteq')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (228, 1, N'Approved', N'Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis. Ut at dolor quis odio consequat varius.', N'51188', N'hlovittr', 1, CAST(N'2022-11-05T00:00:00' AS SmallDateTime), CAST(N'2022-12-06T00:00:00' AS SmallDateTime), N'mlambrichtr', N'tblarer')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (229, 0, N'Pending', N'Suspendisse ornare consequat lectus. In est risus, auctor sed, tristique in, tempus sit amet, sem. Fusce consequat. Nulla nisl. Nunc nisl. Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus. Duis at velit eu est congue elementum.', N'51188', N'jcarryers', 1, CAST(N'2022-11-24T00:00:00' AS SmallDateTime), CAST(N'2023-05-20T00:00:00' AS SmallDateTime), N'cjanneys', N'larmatyss')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (230, 0, N'Declined', N'Aenean auctor gravida sem. Praesent id massa id nisl venenatis lacinia. Aenean sit amet justo. Morbi ut odio. Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo. In blandit ultrices enim. Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin interdum mauris non ligula pellentesque ultrices. Phasellus id sapien in sapien iaculis congue. Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl.', N'51188', N'eknaggest', 1, CAST(N'2023-03-26T00:00:00' AS SmallDateTime), CAST(N'2023-01-21T00:00:00' AS SmallDateTime), N'calecockt', N'cbrotherhoodt')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (231, 1, N'Declined', N'Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui. Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc.', N'51188', N'jtibaldu', 1, CAST(N'2023-01-13T00:00:00' AS SmallDateTime), CAST(N'2022-10-12T00:00:00' AS SmallDateTime), N'sbaylieu', N'ktomasianu')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (232, 1, N'Approved', N'Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque. Duis bibendum. Morbi non quam nec dui luctus rutrum. Nulla tellus. In sagittis dui vel nisl.', N'51188', N'vgribbinsv', 1, CAST(N'2022-09-19T00:00:00' AS SmallDateTime), CAST(N'2023-08-24T00:00:00' AS SmallDateTime), N'msanjav', N'misaaksohnv')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (233, 1, N'Pending', N'Integer non velit. Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque. Duis bibendum. Morbi non quam nec dui luctus rutrum. Nulla tellus. In sagittis dui vel nisl. Duis ac nibh. Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus.', N'51188', N'klaughtonw', 1, CAST(N'2022-11-04T00:00:00' AS SmallDateTime), CAST(N'2023-04-30T00:00:00' AS SmallDateTime), N'omantlew', N'mlapsleyw')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (234, 0, N'Pending', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin risus. Praesent lectus. Vestibulum quam sapien, varius ut, blandit non, interdum in, ante. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio. Curabitur convallis.', N'51188', N'msaxtonx', 1, CAST(N'2022-11-08T00:00:00' AS SmallDateTime), CAST(N'2022-12-21T00:00:00' AS SmallDateTime), N'ndeevesx', N'migonetx')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (235, 1, N'Approved', N'Proin interdum mauris non ligula pellentesque ultrices.', N'51188', N'stodory', 1, CAST(N'2023-05-10T00:00:00' AS SmallDateTime), CAST(N'2022-12-02T00:00:00' AS SmallDateTime), N'kmatiebey', N'choundsony')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (236, 1, N'Approved', N'Aenean auctor gravida sem. Praesent id massa id nisl venenatis lacinia. Aenean sit amet justo.', N'51188', N'nraymenz', 1, CAST(N'2023-06-05T00:00:00' AS SmallDateTime), CAST(N'2022-10-03T00:00:00' AS SmallDateTime), N'omacroriez', N'rmcmychemz')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (237, 0, N'Approved', N'Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci.', N'51188', N'sbenoiton10', 1, CAST(N'2022-11-10T00:00:00' AS SmallDateTime), CAST(N'2023-02-12T00:00:00' AS SmallDateTime), N'aperfect10', N'jissacoff10')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (238, 1, N'Declined', N'Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante. Nulla justo. Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros. Suspendisse accumsan tortor quis turpis. Sed ante. Vivamus tortor.', N'51188', N'ybrearton11', 1, CAST(N'2023-02-27T00:00:00' AS SmallDateTime), CAST(N'2023-01-28T00:00:00' AS SmallDateTime), N'ccasswell11', N'eband11')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (239, 0, N'Declined', N'Aenean fermentum.', N'51188', N'clorincz12', 1, CAST(N'2023-07-14T00:00:00' AS SmallDateTime), CAST(N'2023-02-15T00:00:00' AS SmallDateTime), N'lcockle12', N'eyedy12')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (240, 0, N'Approved', N'Nulla tempus. Vivamus in felis eu sapien cursus vestibulum. Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy.', N'51188', N'emeconi13', 1, CAST(N'2023-02-16T00:00:00' AS SmallDateTime), CAST(N'2023-03-23T00:00:00' AS SmallDateTime), N'rlennox13', N'zrealph13')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (241, 1, N'Pending', N'Vestibulum quam sapien, varius ut, blandit non, interdum in, ante. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio. Curabitur convallis. Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor.', N'51188', N'fosment14', 1, CAST(N'2022-09-23T00:00:00' AS SmallDateTime), CAST(N'2023-03-30T00:00:00' AS SmallDateTime), N'atremollet14', N'sgiacobillo14')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (242, 0, N'Declined', N'Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis. Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh. In quis justo. Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet. Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo.', N'51188', N'tcominotti15', 1, CAST(N'2022-10-20T00:00:00' AS SmallDateTime), CAST(N'2023-01-11T00:00:00' AS SmallDateTime), N'btenman15', N'ncamacho15')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (243, 0, N'Approved', N'Ut at dolor quis odio consequat varius. Integer ac leo. Pellentesque ultrices mattis odio. Donec vitae nisi. Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus. Curabitur at ipsum ac tellus semper interdum. Mauris ullamcorper purus sit amet nulla.', N'51188', N'vbilam16', 1, CAST(N'2022-10-22T00:00:00' AS SmallDateTime), CAST(N'2023-07-20T00:00:00' AS SmallDateTime), N'eadamini16', N'awedmore16')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (244, 0, N'Pending', N'Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus. Phasellus in felis. Donec semper sapien a libero. Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis.', N'51188', N'lboothroyd17', 1, CAST(N'2023-01-15T00:00:00' AS SmallDateTime), CAST(N'2022-11-06T00:00:00' AS SmallDateTime), N'iambroix17', N'leitter17')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (245, 0, N'Pending', N'Sed accumsan felis. Ut at dolor quis odio consequat varius. Integer ac leo. Pellentesque ultrices mattis odio. Donec vitae nisi. Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus.', N'51188', N'cwalne18', 1, CAST(N'2023-03-09T00:00:00' AS SmallDateTime), CAST(N'2023-01-24T00:00:00' AS SmallDateTime), N'fsidworth18', N'vferrandez18')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (246, 1, N'Pending', N'Quisque ut erat. Curabitur gravida nisi at nibh. In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat.', N'51188', N'cdomeny19', 1, CAST(N'2023-03-19T00:00:00' AS SmallDateTime), CAST(N'2023-04-12T00:00:00' AS SmallDateTime), N'wcheevers19', N'mmontel19')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (247, 0, N'Approved', N'Vivamus tortor.', N'51188', N'msmitherman1a', 1, CAST(N'2022-09-21T00:00:00' AS SmallDateTime), CAST(N'2023-01-14T00:00:00' AS SmallDateTime), N'arozenbaum1a', N'ajakoviljevic1a')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (248, 1, N'Pending', N'Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante. Nulla justo.', N'51188', N'tcoley1b', 1, CAST(N'2023-07-12T00:00:00' AS SmallDateTime), CAST(N'2022-10-18T00:00:00' AS SmallDateTime), N'smountford1b', N'bspeed1b')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (249, 0, N'Approved', N'Quisque porta volutpat erat. Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus. Phasellus in felis. Donec semper sapien a libero. Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla.', N'51188', N'ldilley1c', 1, CAST(N'2023-09-17T00:00:00' AS SmallDateTime), CAST(N'2023-07-24T00:00:00' AS SmallDateTime), N'kbarz1c', N'cvicar1c')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (250, 1, N'Declined', N'Aliquam erat volutpat. In congue. Etiam justo. Etiam pretium iaculis justo. In hac habitasse platea dictumst.', N'51188', N'tmillership1d', 1, CAST(N'2022-09-29T00:00:00' AS SmallDateTime), CAST(N'2023-07-24T00:00:00' AS SmallDateTime), N'spigne1d', N'relcom1d')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (251, 1, N'Pending', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin interdum mauris non ligula pellentesque ultrices. Phasellus id sapien in sapien iaculis congue. Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl. Aenean lectus. Pellentesque eget nunc.', N'51188', N'fhellis1e', 1, CAST(N'2023-06-29T00:00:00' AS SmallDateTime), CAST(N'2022-12-20T00:00:00' AS SmallDateTime), N'traithbie1e', N'abordiss1e')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (252, 1, N'Approved', N'Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue. Aliquam erat volutpat. In congue. Etiam justo. Etiam pretium iaculis justo. In hac habitasse platea dictumst. Etiam faucibus cursus urna. Ut tellus. Nulla ut erat id mauris vulputate elementum. Nullam varius.', N'51188', N'acasiero1f', 1, CAST(N'2022-09-19T00:00:00' AS SmallDateTime), CAST(N'2023-08-04T00:00:00' AS SmallDateTime), N'gcrofts1f', N'msomerled1f')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (253, 0, N'Declined', N'Aliquam erat volutpat. In congue. Etiam justo. Etiam pretium iaculis justo. In hac habitasse platea dictumst. Etiam faucibus cursus urna.', N'51188', N'abarns1g', 1, CAST(N'2023-06-11T00:00:00' AS SmallDateTime), CAST(N'2023-08-08T00:00:00' AS SmallDateTime), N'bbtham1g', N'avinas1g')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (254, 1, N'Pending', N'Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis. Ut at dolor quis odio consequat varius. Integer ac leo. Pellentesque ultrices mattis odio. Donec vitae nisi. Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus.', N'51188', N'mcreegan1h', 1, CAST(N'2023-02-13T00:00:00' AS SmallDateTime), CAST(N'2022-12-22T00:00:00' AS SmallDateTime), N'pwillison1h', N'fwyllis1h')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (255, 1, N'Declined', N'Integer ac neque. Duis bibendum. Morbi non quam nec dui luctus rutrum. Nulla tellus. In sagittis dui vel nisl. Duis ac nibh. Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus. Suspendisse potenti. In eleifend quam a odio. In hac habitasse platea dictumst.', N'51188', N'asuddell1i', 1, CAST(N'2023-07-02T00:00:00' AS SmallDateTime), CAST(N'2023-01-14T00:00:00' AS SmallDateTime), N'gtuther1i', N'mhalden1i')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (256, 0, N'Pending', N'Suspendisse potenti. Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum. Aliquam non mauris. Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis. Fusce posuere felis sed lacus.', N'51188', N'acansdale1j', 1, CAST(N'2023-05-31T00:00:00' AS SmallDateTime), CAST(N'2023-07-10T00:00:00' AS SmallDateTime), N'lgrealey1j', N'jfoxley1j')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (257, 1, N'Declined', N'In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy. Integer non velit. Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque. Duis bibendum.', N'51188', N'aritzman1k', 1, CAST(N'2023-04-01T00:00:00' AS SmallDateTime), CAST(N'2022-11-20T00:00:00' AS SmallDateTime), N'dmacmakin1k', N'ewharby1k')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (258, 0, N'Approved', N'Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis. Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl. Nunc rhoncus dui vel sem. Sed sagittis. Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus. Pellentesque at nulla.', N'51188', N'glearoid1l', 1, CAST(N'2023-08-01T00:00:00' AS SmallDateTime), CAST(N'2023-07-21T00:00:00' AS SmallDateTime), N'csyder1l', N'otolan1l')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (259, 1, N'Pending', N'Praesent blandit.', N'51188', N'gvayro1m', 1, CAST(N'2023-06-18T00:00:00' AS SmallDateTime), CAST(N'2023-03-17T00:00:00' AS SmallDateTime), N'ncrum1m', N'pcallendar1m')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (260, 1, N'Pending', N'Mauris sit amet eros. Suspendisse accumsan tortor quis turpis. Sed ante. Vivamus tortor. Duis mattis egestas metus. Aenean fermentum. Donec ut mauris eget massa tempor convallis. Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh. Quisque id justo sit amet sapien dignissim vestibulum.', N'51188', N'npender1n', 1, CAST(N'2023-06-20T00:00:00' AS SmallDateTime), CAST(N'2023-06-03T00:00:00' AS SmallDateTime), N'ascathard1n', N'ccastanone1n')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (261, 0, N'Declined', N'Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui. Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti.', N'51188', N'lregan1o', 1, CAST(N'2023-07-12T00:00:00' AS SmallDateTime), CAST(N'2023-07-18T00:00:00' AS SmallDateTime), N'ldannohl1o', N'mtabourin1o')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (262, 1, N'Pending', N'Vivamus vestibulum sagittis sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Etiam vel augue. Vestibulum rutrum rutrum neque.', N'51188', N'jstancer1p', 1, CAST(N'2023-07-24T00:00:00' AS SmallDateTime), CAST(N'2023-04-24T00:00:00' AS SmallDateTime), N'swooderson1p', N'btildesley1p')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (263, 0, N'Pending', N'Sed accumsan felis. Ut at dolor quis odio consequat varius. Integer ac leo. Pellentesque ultrices mattis odio. Donec vitae nisi. Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus.', N'51188', N'bbeddall1q', 1, CAST(N'2022-10-10T00:00:00' AS SmallDateTime), CAST(N'2023-07-08T00:00:00' AS SmallDateTime), N'mhuerta1q', N'ndunleavy1q')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (264, 1, N'Declined', N'Quisque ut erat. Curabitur gravida nisi at nibh. In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat.', N'51188', N'sfist1r', 1, CAST(N'2023-01-28T00:00:00' AS SmallDateTime), CAST(N'2022-11-10T00:00:00' AS SmallDateTime), N'cmeneyer1r', N'lgiorgini1r')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (265, 1, N'Declined', N'Nulla suscipit ligula in lacus. Curabitur at ipsum ac tellus semper interdum. Mauris ullamcorper purus sit amet nulla.', N'51188', N'mclemont1s', 1, CAST(N'2023-04-29T00:00:00' AS SmallDateTime), CAST(N'2023-03-19T00:00:00' AS SmallDateTime), N'ggelly1s', N'rkeam1s')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (266, 0, N'Declined', N'In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat.', N'51188', N'jmallindine1t', 1, CAST(N'2023-03-10T00:00:00' AS SmallDateTime), CAST(N'2023-01-22T00:00:00' AS SmallDateTime), N'fchapiro1t', N'gthomtson1t')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (267, 1, N'Pending', N'Aenean sit amet justo. Morbi ut odio. Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo. In blandit ultrices enim.', N'51188', N'cglencrosche1u', 1, CAST(N'2023-01-15T00:00:00' AS SmallDateTime), CAST(N'2023-04-18T00:00:00' AS SmallDateTime), N'mblaschek1u', N'gaitkenhead1u')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (268, 1, N'Approved', N'Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor.', N'51188', N'kmacdiarmond1v', 1, CAST(N'2023-02-04T00:00:00' AS SmallDateTime), CAST(N'2023-01-18T00:00:00' AS SmallDateTime), N'alerwell1v', N'mspindler1v')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (269, 1, N'Declined', N'Nulla justo. Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros. Suspendisse accumsan tortor quis turpis.', N'51188', N'vrayburn1w', 1, CAST(N'2023-05-19T00:00:00' AS SmallDateTime), CAST(N'2023-07-02T00:00:00' AS SmallDateTime), N'bpadrick1w', N'jsisley1w')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (270, 1, N'Pending', N'Quisque porta volutpat erat.', N'51188', N'ctomasian1x', 1, CAST(N'2022-10-25T00:00:00' AS SmallDateTime), CAST(N'2023-04-09T00:00:00' AS SmallDateTime), N'gkumar1x', N'gmellonby1x')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (271, 1, N'Pending', N'Nulla facilisi. Cras non velit nec nisi vulputate nonummy. Maecenas tincidunt lacus at velit. Vivamus vel nulla eget eros elementum pellentesque. Quisque porta volutpat erat. Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus. Phasellus in felis. Donec semper sapien a libero. Nam dui.', N'51188', N'mbraban1y', 1, CAST(N'2022-09-26T00:00:00' AS SmallDateTime), CAST(N'2022-09-21T00:00:00' AS SmallDateTime), N'pmuscat1y', N'bwhettleton1y')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (272, 0, N'Approved', N'Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis. Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl. Nunc rhoncus dui vel sem. Sed sagittis. Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus.', N'51188', N'kmacias1z', 1, CAST(N'2023-09-04T00:00:00' AS SmallDateTime), CAST(N'2022-11-13T00:00:00' AS SmallDateTime), N'rneicho1z', N'egoodayle1z')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (273, 1, N'Pending', N'Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est. Phasellus sit amet erat. Nulla tempus.', N'51188', N'kbrownsall20', 1, CAST(N'2023-06-05T00:00:00' AS SmallDateTime), CAST(N'2023-06-10T00:00:00' AS SmallDateTime), N'lbullocke20', N'pingraham20')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (274, 0, N'Pending', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin interdum mauris non ligula pellentesque ultrices. Phasellus id sapien in sapien iaculis congue. Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl. Aenean lectus. Pellentesque eget nunc. Donec quis orci eget orci vehicula condimentum.', N'51188', N'gstanford21', 1, CAST(N'2023-08-20T00:00:00' AS SmallDateTime), CAST(N'2023-04-17T00:00:00' AS SmallDateTime), N'dwoods21', N'acruise21')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (275, 0, N'Pending', N'Curabitur gravida nisi at nibh. In hac habitasse platea dictumst.', N'51188', N'kmeaddowcroft22', 1, CAST(N'2023-06-15T00:00:00' AS SmallDateTime), CAST(N'2023-09-09T00:00:00' AS SmallDateTime), N'cblazeby22', N'cmaccahey22')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (276, 0, N'Approved', N'Phasellus sit amet erat. Nulla tempus. Vivamus in felis eu sapien cursus vestibulum. Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc.', N'51188', N'hclemencon23', 1, CAST(N'2023-09-09T00:00:00' AS SmallDateTime), CAST(N'2022-11-14T00:00:00' AS SmallDateTime), N'jdjurdjevic23', N'dcoppens23')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (277, 1, N'Approved', N'Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti. Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum. Aliquam non mauris.', N'51188', N'sboyat24', 1, CAST(N'2023-01-17T00:00:00' AS SmallDateTime), CAST(N'2023-07-25T00:00:00' AS SmallDateTime), N'hmccudden24', N'gayres24')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (278, 0, N'Pending', N'Nulla nisl. Nunc nisl. Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa.', N'51188', N'hsimonard25', 1, CAST(N'2023-04-29T00:00:00' AS SmallDateTime), CAST(N'2023-09-02T00:00:00' AS SmallDateTime), N'wreuter25', N'chundey25')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (279, 1, N'Declined', N'Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat. Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede.', N'51188', N'ppenk26', 1, CAST(N'2023-08-17T00:00:00' AS SmallDateTime), CAST(N'2022-12-30T00:00:00' AS SmallDateTime), N'cpeterson26', N'klaw26')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (280, 1, N'Declined', N'Donec quis orci eget orci vehicula condimentum. Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est. Phasellus sit amet erat. Nulla tempus.', N'51188', N'zrushbury27', 1, CAST(N'2023-03-02T00:00:00' AS SmallDateTime), CAST(N'2023-01-26T00:00:00' AS SmallDateTime), N'jchrishop27', N'cpavic27')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (281, 0, N'Approved', N'Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat. Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede. Morbi porttitor lorem id ligula.', N'51188', N'calltimes28', 1, CAST(N'2023-06-30T00:00:00' AS SmallDateTime), CAST(N'2022-12-12T00:00:00' AS SmallDateTime), N'hkohter28', N'kborne28')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (282, 0, N'Declined', N'Curabitur gravida nisi at nibh. In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat. Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede. Morbi porttitor lorem id ligula.', N'51188', N'ksaphir29', 1, CAST(N'2023-05-05T00:00:00' AS SmallDateTime), CAST(N'2023-03-07T00:00:00' AS SmallDateTime), N'bsandells29', N'fdaniely29')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (283, 0, N'Approved', N'Integer a nibh.', N'51188', N'crisborough2a', 1, CAST(N'2022-12-16T00:00:00' AS SmallDateTime), CAST(N'2023-02-03T00:00:00' AS SmallDateTime), N'hnewband2a', N'gplumley2a')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (284, 0, N'Pending', N'In congue. Etiam justo. Etiam pretium iaculis justo. In hac habitasse platea dictumst. Etiam faucibus cursus urna.', N'51188', N'cgrinyakin2b', 1, CAST(N'2023-04-25T00:00:00' AS SmallDateTime), CAST(N'2023-01-01T00:00:00' AS SmallDateTime), N'rhartburn2b', N'uwyant2b')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (285, 1, N'Pending', N'Integer non velit. Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque. Duis bibendum. Morbi non quam nec dui luctus rutrum. Nulla tellus. In sagittis dui vel nisl. Duis ac nibh.', N'51188', N'vnazair2c', 1, CAST(N'2023-04-17T00:00:00' AS SmallDateTime), CAST(N'2023-04-08T00:00:00' AS SmallDateTime), N'cnoe2c', N'lhamlin2c')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (286, 1, N'Pending', N'Nulla facilisi.', N'51188', N'rfawdery2d', 1, CAST(N'2022-11-30T00:00:00' AS SmallDateTime), CAST(N'2022-09-27T00:00:00' AS SmallDateTime), N'gtrebble2d', N'bpaliser2d')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (287, 1, N'Declined', N'Suspendisse potenti. Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum.', N'51188', N'dhabben2e', 1, CAST(N'2023-01-14T00:00:00' AS SmallDateTime), CAST(N'2023-03-10T00:00:00' AS SmallDateTime), N'cellwand2e', N'neam2e')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (288, 1, N'Pending', N'Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh. In quis justo. Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet. Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam.', N'51188', N'lburker2f', 1, CAST(N'2023-01-04T00:00:00' AS SmallDateTime), CAST(N'2022-10-02T00:00:00' AS SmallDateTime), N'preeday2f', N'ggillcrist2f')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (289, 0, N'Declined', N'Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh.', N'51188', N'doshevlan2g', 1, CAST(N'2023-09-06T00:00:00' AS SmallDateTime), CAST(N'2023-09-01T00:00:00' AS SmallDateTime), N'sdeere2g', N'wabadam2g')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (290, 0, N'Declined', N'Nulla nisl. Nunc nisl. Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus.', N'51188', N'groller2h', 1, CAST(N'2022-10-27T00:00:00' AS SmallDateTime), CAST(N'2022-09-20T00:00:00' AS SmallDateTime), N'ppitceathly2h', N'kpaumier2h')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (291, 1, N'Approved', N'Nulla justo. Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros. Suspendisse accumsan tortor quis turpis. Sed ante.', N'51188', N'olehenmann2i', 1, CAST(N'2023-01-23T00:00:00' AS SmallDateTime), CAST(N'2022-10-25T00:00:00' AS SmallDateTime), N'crounds2i', N'hatwill2i')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (292, 0, N'Declined', N'In est risus, auctor sed, tristique in, tempus sit amet, sem. Fusce consequat. Nulla nisl. Nunc nisl. Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus. Duis at velit eu est congue elementum.', N'51188', N'pgrieswood2j', 1, CAST(N'2023-05-04T00:00:00' AS SmallDateTime), CAST(N'2022-10-27T00:00:00' AS SmallDateTime), N'asymper2j', N'gschindler2j')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (293, 1, N'Pending', N'Phasellus id sapien in sapien iaculis congue. Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl. Aenean lectus.', N'51188', N'jalsina2k', 1, CAST(N'2023-02-23T00:00:00' AS SmallDateTime), CAST(N'2023-07-18T00:00:00' AS SmallDateTime), N'jstallard2k', N'msheaber2k')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (294, 1, N'Declined', N'Etiam vel augue. Vestibulum rutrum rutrum neque. Aenean auctor gravida sem. Praesent id massa id nisl venenatis lacinia. Aenean sit amet justo.', N'51188', N'wdelph2l', 1, CAST(N'2022-10-27T00:00:00' AS SmallDateTime), CAST(N'2023-08-22T00:00:00' AS SmallDateTime), N'klemarquis2l', N'hgrewer2l')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (295, 0, N'Approved', N'Praesent id massa id nisl venenatis lacinia. Aenean sit amet justo. Morbi ut odio. Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo. In blandit ultrices enim. Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin interdum mauris non ligula pellentesque ultrices. Phasellus id sapien in sapien iaculis congue.', N'51188', N'bkimblen2m', 1, CAST(N'2022-11-24T00:00:00' AS SmallDateTime), CAST(N'2023-06-24T00:00:00' AS SmallDateTime), N'abamborough2m', N'epaske2m')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (296, 1, N'Pending', N'Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis. Fusce posuere felis sed lacus.', N'51188', N'czincke2n', 1, CAST(N'2022-11-23T00:00:00' AS SmallDateTime), CAST(N'2023-05-13T00:00:00' AS SmallDateTime), N'scotter2n', N'dmacconnechie2n')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (297, 1, N'Declined', N'Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis. Ut at dolor quis odio consequat varius. Integer ac leo. Pellentesque ultrices mattis odio. Donec vitae nisi. Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus.', N'51188', N'ufiddiman2o', 1, CAST(N'2023-01-25T00:00:00' AS SmallDateTime), CAST(N'2022-12-12T00:00:00' AS SmallDateTime), N'hmottram2o', N'ncottesford2o')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (298, 1, N'Approved', N'Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus. Suspendisse potenti. In eleifend quam a odio.', N'51188', N'afoy2p', 1, CAST(N'2023-05-26T00:00:00' AS SmallDateTime), CAST(N'2023-07-06T00:00:00' AS SmallDateTime), N'smessitt2p', N'kjohnsee2p')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (299, 0, N'Pending', N'Cras in purus eu magna vulputate luctus. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vivamus vestibulum sagittis sapien.', N'51188', N'vkleimt2q', 1, CAST(N'2023-07-12T00:00:00' AS SmallDateTime), CAST(N'2023-08-29T00:00:00' AS SmallDateTime), N'aeldershaw2q', N'lechalie2q')
GO
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DeclinedBy], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (300, 1, N'Declined', N'Etiam pretium iaculis justo. In hac habitasse platea dictumst. Etiam faucibus cursus urna. Ut tellus. Nulla ut erat id mauris vulputate elementum. Nullam varius. Nulla facilisi. Cras non velit nec nisi vulputate nonummy. Maecenas tincidunt lacus at velit.', N'51188', N'jeudall2r', 1, CAST(N'2023-06-20T00:00:00' AS SmallDateTime), CAST(N'2023-07-23T00:00:00' AS SmallDateTime), N'bkatte2r', N'gcamel2r')
SET IDENTITY_INSERT [dbo].[Request] OFF
GO
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (201, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'at feugiat non pretium quis lectus suspendisse potenti in eleifend quam a odio', CAST(N'2022-11-09T00:00:00' AS SmallDateTime), CAST(N'2023-09-07T00:00:00' AS SmallDateTime), N'citskovitzl', N'mshiltonl')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (202, N'51124', N'Finance Reviewer', 1, N'Basic', N'Approved', N'sem mauris laoreet ut rhoncus aliquet pulvinar sed nisl nunc rhoncus dui vel sem sed', CAST(N'2022-11-22T00:00:00' AS SmallDateTime), CAST(N'2023-03-09T00:00:00' AS SmallDateTime), N'abamford15', N'dmainland15')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (211, N'51124', N'Finance Reviewer', 1, N'Basic', N'Approved', N'aliquam augue quam sollicitudin vitae consectetuer eget rutrum at lorem integer tincidunt ante vel ipsum praesent blandit lacinia', CAST(N'2022-11-09T00:00:00' AS SmallDateTime), CAST(N'2023-07-31T00:00:00' AS SmallDateTime), N'gmcilenna14', N'nhaycroft14')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (212, N'51124', N'Finance Reviewer', 1, N'Basic', N'Approved', N'diam id ornare imperdiet sapien urna pretium nisl ut volutpat sapien arcu sed augue aliquam', CAST(N'2022-10-16T00:00:00' AS SmallDateTime), CAST(N'2022-10-14T00:00:00' AS SmallDateTime), N'ltimoney1b', N'pgentle1b')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (213, N'51124', N'Finance Reviewer', 1, N'Basic', N'Pending', N'semper sapien a libero nam dui proin leo odio porttitor id consequat in consequat ut nulla sed accumsan', CAST(N'2022-10-20T00:00:00' AS SmallDateTime), CAST(N'2022-12-07T00:00:00' AS SmallDateTime), N'sseathwrightf', N'amaydwayf')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (214, N'51124', N'Finance Reviewer', 1, N'Basic', N'Pending', N'duis faucibus accumsan odio curabitur convallis duis consequat dui nec nisi volutpat', CAST(N'2023-08-14T00:00:00' AS SmallDateTime), CAST(N'2022-11-24T00:00:00' AS SmallDateTime), N'pbenoisi', N'sjermyi')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (215, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'sem duis aliquam convallis nunc proin at turpis a pede posuere nonummy integer non', CAST(N'2023-03-28T00:00:00' AS SmallDateTime), CAST(N'2022-12-20T00:00:00' AS SmallDateTime), N'vcrokere', N'cvilese')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (216, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'nulla facilisi cras non velit nec nisi vulputate nonummy maecenas tincidunt', CAST(N'2023-03-31T00:00:00' AS SmallDateTime), CAST(N'2023-04-11T00:00:00' AS SmallDateTime), N'tballp', N'efilshinp')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (217, N'51124', N'Finance Reviewer', 1, N'Basic', N'Approved', N'velit id pretium iaculis diam erat fermentum justo nec condimentum neque sapien placerat ante nulla justo aliquam quis', CAST(N'2022-09-30T00:00:00' AS SmallDateTime), CAST(N'2022-11-02T00:00:00' AS SmallDateTime), N'jwhorall1k', N'smcwhannel1k')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (218, N'51124', N'Finance Reviewer', 1, N'Basic', N'Pending', N'nibh fusce lacus purus aliquet at feugiat non pretium quis lectus suspendisse', CAST(N'2023-04-05T00:00:00' AS SmallDateTime), CAST(N'2023-07-07T00:00:00' AS SmallDateTime), N'bmcmakin1b', N'kroblou1b')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (221, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'amet cursus id turpis integer aliquet massa id lobortis convallis tortor risus', CAST(N'2023-03-11T00:00:00' AS SmallDateTime), CAST(N'2023-09-04T00:00:00' AS SmallDateTime), N'cdumbellow8', N'acallcott8')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (223, N'51124', N'Finance Reviewer', 1, N'Basic', N'Pending', N'tortor sollicitudin mi sit amet lobortis sapien sapien non mi integer ac neque duis bibendum morbi non quam nec dui', CAST(N'2023-04-17T00:00:00' AS SmallDateTime), CAST(N'2023-07-01T00:00:00' AS SmallDateTime), N'mshemmansb', N'cgoardb')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (226, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'dapibus nulla suscipit ligula in lacus curabitur at ipsum ac tellus', CAST(N'2023-04-26T00:00:00' AS SmallDateTime), CAST(N'2023-04-20T00:00:00' AS SmallDateTime), N'akehir1x', N'mmardall1x')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (230, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'donec pharetra magna vestibulum aliquet ultrices erat tortor sollicitudin mi sit amet', CAST(N'2023-01-03T00:00:00' AS SmallDateTime), CAST(N'2023-01-03T00:00:00' AS SmallDateTime), N'gcastelinj', N'bmallabundj')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (231, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'amet consectetuer adipiscing elit proin interdum mauris non ligula pellentesque ultrices phasellus id sapien in sapien', CAST(N'2023-08-28T00:00:00' AS SmallDateTime), CAST(N'2023-05-19T00:00:00' AS SmallDateTime), N'naspinal4', N'lyo4')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (232, N'51124', N'Finance Reviewer', 1, N'Basic', N'Approved', N'ridiculus mus etiam vel augue vestibulum rutrum rutrum neque aenean auctor gravida sem', CAST(N'2023-08-25T00:00:00' AS SmallDateTime), CAST(N'2023-05-23T00:00:00' AS SmallDateTime), N'iwarhurst1g', N'direland1g')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (235, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'ut ultrices vel augue vestibulum ante ipsum primis in faucibus orci luctus', CAST(N'2023-01-06T00:00:00' AS SmallDateTime), CAST(N'2023-08-07T00:00:00' AS SmallDateTime), N'gblaydon2e', N'ladami2e')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (236, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'pretium nisl ut volutpat sapien arcu sed augue aliquam erat volutpat in congue etiam justo etiam pretium', CAST(N'2023-07-21T00:00:00' AS SmallDateTime), CAST(N'2023-06-03T00:00:00' AS SmallDateTime), N'gjahnke1o', N'hvidler1o')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (237, N'51124', N'Finance Reviewer', 1, N'Basic', N'Approved', N'eget rutrum at lorem integer tincidunt ante vel ipsum praesent blandit lacinia erat vestibulum sed magna at', CAST(N'2023-04-18T00:00:00' AS SmallDateTime), CAST(N'2023-01-08T00:00:00' AS SmallDateTime), N'ahasluma', N'palloma')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (238, N'51124', N'Finance Reviewer', 1, N'Basic', N'Approved', N'nulla nisl nunc nisl duis bibendum felis sed interdum venenatis turpis enim blandit mi in', CAST(N'2022-10-02T00:00:00' AS SmallDateTime), CAST(N'2023-07-11T00:00:00' AS SmallDateTime), N'rleggana', N'tgoodbairna')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (239, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'nulla ac enim in tempor turpis nec euismod scelerisque quam turpis adipiscing lorem vitae mattis nibh ligula', CAST(N'2023-04-27T00:00:00' AS SmallDateTime), CAST(N'2023-01-09T00:00:00' AS SmallDateTime), N'lvannet10', N'aneames10')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (241, N'51124', N'Finance Reviewer', 1, N'Basic', N'Pending', N'feugiat non pretium quis lectus suspendisse potenti in eleifend quam a odio in hac habitasse platea', CAST(N'2022-10-22T00:00:00' AS SmallDateTime), CAST(N'2022-12-01T00:00:00' AS SmallDateTime), N'fnickels1p', N'eskullet1p')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (246, N'51124', N'Finance Reviewer', 1, N'Basic', N'Pending', N'duis faucibus accumsan odio curabitur convallis duis consequat dui nec nisi volutpat eleifend donec ut dolor morbi vel', CAST(N'2023-01-11T00:00:00' AS SmallDateTime), CAST(N'2022-11-27T00:00:00' AS SmallDateTime), N'sgronallerq', N'agrenshieldsq')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (247, N'51124', N'Finance Reviewer', 1, N'Basic', N'Pending', N'pulvinar nulla pede ullamcorper augue a suscipit nulla elit ac nulla', CAST(N'2022-11-05T00:00:00' AS SmallDateTime), CAST(N'2023-02-12T00:00:00' AS SmallDateTime), N'ngotter1f', N'cmcgrill1f')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (249, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'viverra diam vitae quam suspendisse potenti nullam porttitor lacus at turpis donec posuere metus vitae ipsum aliquam', CAST(N'2023-06-16T00:00:00' AS SmallDateTime), CAST(N'2022-11-02T00:00:00' AS SmallDateTime), N'smcghee3', N'aridgley3')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (251, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'metus arcu adipiscing molestie hendrerit at vulputate vitae nisl aenean lectus pellentesque', CAST(N'2023-03-13T00:00:00' AS SmallDateTime), CAST(N'2023-02-28T00:00:00' AS SmallDateTime), N'calban9', N'ntuson9')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (252, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'nunc proin at turpis a pede posuere nonummy integer non velit donec diam', CAST(N'2023-02-26T00:00:00' AS SmallDateTime), CAST(N'2023-04-21T00:00:00' AS SmallDateTime), N'mmitchesont', N'hradket')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (253, N'51124', N'Finance Reviewer', 1, N'Basic', N'Approved', N'primis in faucibus orci luctus et ultrices posuere cubilia curae nulla dapibus dolor vel est donec odio', CAST(N'2022-12-27T00:00:00' AS SmallDateTime), CAST(N'2023-01-12T00:00:00' AS SmallDateTime), N'agilhouley14', N'acarrabott14')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (255, N'51124', N'Finance Reviewer', 1, N'Basic', N'Approved', N'parturient montes nascetur ridiculus mus vivamus vestibulum sagittis sapien cum sociis natoque penatibus et', CAST(N'2022-12-21T00:00:00' AS SmallDateTime), CAST(N'2022-11-06T00:00:00' AS SmallDateTime), N'smcgivenk', N'zmokesk')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (256, N'51124', N'Finance Reviewer', 1, N'Basic', N'Pending', N'tempor turpis nec euismod scelerisque quam turpis adipiscing lorem vitae mattis nibh ligula nec sem', CAST(N'2022-09-26T00:00:00' AS SmallDateTime), CAST(N'2023-09-05T00:00:00' AS SmallDateTime), N'bwanstall17', N'mpuddle17')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (257, N'51124', N'Finance Reviewer', 1, N'Basic', N'Pending', N'leo pellentesque ultrices mattis odio donec vitae nisi nam ultrices libero non mattis pulvinar nulla pede ullamcorper', CAST(N'2023-05-23T00:00:00' AS SmallDateTime), CAST(N'2023-04-30T00:00:00' AS SmallDateTime), N'rgooday16', N'kcawsby16')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (260, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'posuere cubilia curae nulla dapibus dolor vel est donec odio justo sollicitudin ut suscipit a feugiat et', CAST(N'2023-08-28T00:00:00' AS SmallDateTime), CAST(N'2023-02-02T00:00:00' AS SmallDateTime), N'erobiot15', N'aquest15')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (264, N'51124', N'Finance Reviewer', 1, N'Basic', N'Pending', N'vestibulum velit id pretium iaculis diam erat fermentum justo nec condimentum neque sapien placerat ante nulla justo', CAST(N'2023-01-29T00:00:00' AS SmallDateTime), CAST(N'2023-08-22T00:00:00' AS SmallDateTime), N'bwortman2n', N'scuppitt2n')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (267, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'est congue elementum in hac habitasse platea dictumst morbi vestibulum velit', CAST(N'2023-08-22T00:00:00' AS SmallDateTime), CAST(N'2023-07-11T00:00:00' AS SmallDateTime), N'clindstroms', N'mschruurss')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (268, N'51124', N'Finance Reviewer', 1, N'Basic', N'Pending', N'et ultrices posuere cubilia curae nulla dapibus dolor vel est donec odio justo sollicitudin', CAST(N'2023-06-08T00:00:00' AS SmallDateTime), CAST(N'2023-06-10T00:00:00' AS SmallDateTime), N'kmatusov1q', N'lbiddlecombe1q')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (269, N'51124', N'Finance Reviewer', 1, N'Basic', N'Pending', N'hendrerit at vulputate vitae nisl aenean lectus pellentesque eget nunc donec quis orci eget', CAST(N'2022-10-26T00:00:00' AS SmallDateTime), CAST(N'2023-06-30T00:00:00' AS SmallDateTime), N'gdearsleyx', N'tgramerx')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (275, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'in faucibus orci luctus et ultrices posuere cubilia curae mauris viverra diam vitae quam suspendisse potenti nullam porttitor', CAST(N'2023-08-20T00:00:00' AS SmallDateTime), CAST(N'2023-02-16T00:00:00' AS SmallDateTime), N'lsurridge2b', N'rmacmeekan2b')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (276, N'51124', N'Finance Reviewer', 1, N'Basic', N'Approved', N'nulla nisl nunc nisl duis bibendum felis sed interdum venenatis turpis enim blandit mi in porttitor pede', CAST(N'2023-06-25T00:00:00' AS SmallDateTime), CAST(N'2023-04-01T00:00:00' AS SmallDateTime), N'coleszczak11', N'mwhitehouse11')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (279, N'51124', N'Finance Reviewer', 1, N'Basic', N'Approved', N'libero ut massa volutpat convallis morbi odio odio elementum eu interdum eu tincidunt in leo maecenas pulvinar lobortis est', CAST(N'2023-05-14T00:00:00' AS SmallDateTime), CAST(N'2023-04-16T00:00:00' AS SmallDateTime), N'aheinsius18', N'pcade18')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (280, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'donec pharetra magna vestibulum aliquet ultrices erat tortor sollicitudin mi sit amet lobortis sapien sapien non mi integer ac', CAST(N'2023-01-15T00:00:00' AS SmallDateTime), CAST(N'2023-09-06T00:00:00' AS SmallDateTime), N'rvickars24', N'lbartot24')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (281, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'nisi at nibh in hac habitasse platea dictumst aliquam augue quam sollicitudin vitae consectetuer eget rutrum at lorem integer tincidunt', CAST(N'2023-07-16T00:00:00' AS SmallDateTime), CAST(N'2022-10-31T00:00:00' AS SmallDateTime), N'jfigliovannif', N'kfrangletonf')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (283, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'vel accumsan tellus nisi eu orci mauris lacinia sapien quis libero nullam sit amet turpis elementum ligula vehicula consequat', CAST(N'2023-02-18T00:00:00' AS SmallDateTime), CAST(N'2022-12-06T00:00:00' AS SmallDateTime), N'amirrleeso', N'tstillo')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (284, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'donec ut dolor morbi vel lectus in quam fringilla rhoncus mauris enim leo rhoncus sed vestibulum sit', CAST(N'2023-03-30T00:00:00' AS SmallDateTime), CAST(N'2023-01-08T00:00:00' AS SmallDateTime), N'aeteen1l', N'nkeveren1l')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (285, N'51124', N'Finance Reviewer', 1, N'Basic', N'Pending', N'nulla neque libero convallis eget eleifend luctus ultricies eu nibh quisque id', CAST(N'2023-04-26T00:00:00' AS SmallDateTime), CAST(N'2023-06-20T00:00:00' AS SmallDateTime), N'jdanilevichg', N'cbardeg')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (286, N'51124', N'Finance Reviewer', 1, N'Basic', N'Approved', N'id nisl venenatis lacinia aenean sit amet justo morbi ut odio cras mi pede malesuada in imperdiet et commodo', CAST(N'2022-11-14T00:00:00' AS SmallDateTime), CAST(N'2022-10-23T00:00:00' AS SmallDateTime), N'cglencrossn', N'sbyshn')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (287, N'51124', N'Finance Reviewer', 1, N'Basic', N'Pending', N'bibendum felis sed interdum venenatis turpis enim blandit mi in porttitor pede', CAST(N'2023-04-20T00:00:00' AS SmallDateTime), CAST(N'2023-04-14T00:00:00' AS SmallDateTime), N'jboribal6', N'pdanelutti6')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (288, N'51124', N'Finance Reviewer', 1, N'Basic', N'Pending', N'dictumst morbi vestibulum velit id pretium iaculis diam erat fermentum justo nec condimentum neque sapien placerat ante nulla justo', CAST(N'2023-07-13T00:00:00' AS SmallDateTime), CAST(N'2023-06-19T00:00:00' AS SmallDateTime), N'jgammel12', N'rmitford12')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (293, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia', CAST(N'2023-04-19T00:00:00' AS SmallDateTime), CAST(N'2023-02-06T00:00:00' AS SmallDateTime), N'aanersen5', N'cahrens5')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (294, N'51124', N'Finance Reviewer', 1, N'Basic', N'Pending', N'sollicitudin ut suscipit a feugiat et eros vestibulum ac est lacinia nisi venenatis tristique', CAST(N'2022-11-01T00:00:00' AS SmallDateTime), CAST(N'2023-03-14T00:00:00' AS SmallDateTime), N'dcannell6', N'araeside6')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (297, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'odio in hac habitasse platea dictumst maecenas ut massa quis augue luctus tincidunt nulla mollis molestie', CAST(N'2023-08-20T00:00:00' AS SmallDateTime), CAST(N'2023-06-10T00:00:00' AS SmallDateTime), N'mshorthousez', N'gtinstonz')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (298, N'51124', N'Finance Reviewer', 1, N'Basic', N'Pending', N'sed vel enim sit amet nunc viverra dapibus nulla suscipit ligula in lacus curabitur', CAST(N'2023-01-17T00:00:00' AS SmallDateTime), CAST(N'2023-03-19T00:00:00' AS SmallDateTime), N'aslevin2r', N'eredler2r')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (299, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'risus semper porta volutpat quam pede lobortis ligula sit amet eleifend pede libero quis orci nullam molestie nibh', CAST(N'2023-06-03T00:00:00' AS SmallDateTime), CAST(N'2022-12-02T00:00:00' AS SmallDateTime), N'bsparsholt1d', N'ballpress1d')
INSERT [dbo].[RequestReviewer] ([RequestId], [ReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (300, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'lacinia aenean sit amet justo morbi ut odio cras mi pede malesuada in imperdiet et commodo', CAST(N'2023-03-20T00:00:00' AS SmallDateTime), CAST(N'2023-01-24T00:00:00' AS SmallDateTime), N'ccoffey0', N'bbudget0')
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
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'0d0f955e-f84d-442e-8676-d8c53839ba37', N'Security', N'SECURITY', N'fe9d811b-c9aa-4389-a060-8929730ea7b3')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'11a62722-df08-4ff6-aafc-773da482985d', N'CustomerService', N'CUSTOMERSERVICE', N'2f1929b8-1954-4d30-ad15-65c1734d7d20')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'2e66a76e-9fc8-4c38-bdee-07f4e5761a40', N'IT', N'IT', N'5dc0e0cc-9462-4e1e-a16e-4705fd401d38')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'31f60110-5331-43e3-afcc-86e25f285941', N'HR', N'HR', N'7daf0ee2-754b-4d4c-afe3-ecb09b47ed4f')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'39171323-91f5-407c-88dc-67b657f3e966', N'SuperAdmin', N'SUPERADMIN', N'1cb134e8-55ff-4edf-b87d-0e15c6da0b14')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'53481cef-8380-4ebe-8ea5-0a73f7a0e6ff', N'Commercial', N'COMMERCIAL', N'4bc04e25-6c7a-4e7c-8e9a-1ea9cedb007c')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'82cae434-a43f-4f98-86d2-4de5205a410f', N'Procurement', N'PROCUREMENT', N'6c85c14b-574c-4c36-801c-82e7ebc6b1ff')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'9a8e4316-c998-4125-a9ef-af391a9f8243', N'Finance', N'FINANCE', N'f5977670-a0e9-49cb-b748-7cb2f5e7d7dd')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'9b67cbc3-79b7-4225-a765-30f965cfe4ce', N'Engineering', N'ENGINEERING', N'091a6ff9-ab12-42aa-b4c2-884dbe807ccf')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'a249ad1e-f902-4f9d-9b61-e1f0a9158e7a', N'Store', N'STORE', N'9852c06b-cade-481b-a21c-8a917378cfaf')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'c2fc304e-99e7-45f2-ae8e-4eb3db2a6a54', N'Communications', N'COMMUNICATIONS', N'5879bf35-9a26-43ce-97fc-4ff951a2d5d9')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'c6211cfe-eee5-4aab-a1fa-8f546102fe2d', N'OperationCT', N'OPERATIONCT', N'3fc914ef-ea2b-4110-ae4a-aba1e0c9ea29')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'cb8fcbe1-2558-4a80-961f-6e683d5106ab', N'InfoFort', N'INFOFORT', N'244fef7c-057c-47d0-99f2-18180c04e198')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'ce3f68df-61aa-4e06-9c2a-6f19889bee60', N'Adminstration', N'ADMINSTRATION', N'75bcbb47-cd23-44b4-b9c3-f8ba0f1dccfb')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'e5634c42-82d8-4889-be9d-89d92b77d426', N'OperationBGC', N'OPERATIONBGC', N'6beda2c4-03dc-4c67-a303-583ae5c88806')
GO
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50000', N'stores_manager', N'STORES_MANAGER', N'Ahmed Zaki', N'Head of Stores', 20, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'stores_manager@dpworld.com', N'STORES_MANAGER@DPWORLD.COM', 0, NULL, N'f406fe59-7191-4787-9a0e-0afcca4185ad', N'54cb22a6-d74f-40f8-b71d-39dfb14619aa', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50128', N'ops-cfs_sec_head', N'OPS-CFS_SEC_HEAD', N'Ahmed Zaki', N'OPS-CFS Section Head', 14, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'ops-cfs_sec_head@dpworld.com', N'OPS-CFS_SEC_HEAD@DPWORLD.COM', 0, NULL, N'c4475a98-4a4e-4a0b-a424-e5a89c67480d', N'fb7cad3e-efac-4c05-8a9d-ebc0cf2e6d58', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50136', N'engineering_manager', N'ENGINEERING_MANAGER', N'Ahmed Zaki', N'Head of Engineering', 21, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'engineering_manager@dpworld.com', N'ENGINEERING_MANAGER@DPWORLD.COM', 0, NULL, N'9cc8837d-749e-4e0a-b600-5044d3f7f096', N'b62ec717-a1ef-49cf-a109-253f8b7f7750', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50140', N'hc-ssp_manager', N'HC-SSP_MANAGER', N'Maged Mohsen', N'Head of HC - Samsung SDS project', 11, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'hc-ssp_manager@dpworld.com', N'HC-SSP_MANAGER@DPWORLD.COM', 0, NULL, N'8ec2e516-35f5-413b-bce8-a6759027ffe8', N'36a341e7-a702-42e2-9352-0266ba5455d2', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50141', N'ops-ct_manager', N'OPS-CT_MANAGER', N'Maged Mohsen', N'Head of OPS-Containers', 14, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'ops-ct_manager@dpworld.com', N'OPS-CT_MANAGER@DPWORLD.COM', 0, NULL, N'd655543c-44cd-43d0-a508-23a75887b472', N'37b8897b-4127-4fc1-be28-41b5fbcd0420', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50263', N'security_manager', N'SECURITY_MANAGER', N'Ahmed Zaki', N'Head of Security', 19, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'security_manager@dpworld.com', N'SECURITY_MANAGER@DPWORLD.COM', 0, NULL, N'6b0ec6c7-41f5-4e93-9784-5dd97952eaa0', N'0466ba8c-cf06-46a0-9565-211a77b1bec2', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50269', N'admin_manager', N'ADMIN_MANAGER', N'Ahmed Zaki', N'Head of Administration', 1, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'admin_manager@dpworld.com', N'ADMIN_MANGER@DPWORLD.COM', 0, NULL, N'906cf3bc-b13e-44ab-b78b-108bbf432e9c', N'828df9e7-0582-412b-b7b9-aa3aec424ae2', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50279', N'people_manager', N'PEOPLE_MANAGER', N'Waleed Aboelgadayl', N'Head of People', 15, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'people_manager@dpworld.com', N'PEOPLE_MANAGER@DPWORLD.COM', 0, NULL, N'582f16f7-641f-49bf-9683-0653ba844397', N'284d918d-468a-42b9-94c8-b7d7bbce7063', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50354', N'ops-bgc_manager', N'OPS-BGC_MANAGER', N'Mohamed Radwan', N'Head of OPS-Cargo & Bulk', 13, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'ops-bgc_manager@dpworld.com', N'OPS-BGC_MANAGER@DPWORLD.COM', 0, NULL, N'3ed59bbd-270e-42e5-936b-26c8ddbe1dce', N'dcb04b45-656a-4908-b30d-65aba76a2216', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50562', N'tec-planning_sec_head', N'TEC-PLANNING_SEC_HEAD', N'Ahmed Zaki', N'TEC-Planning Section Head', 21, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'tec-planning_sec_head@dpworld.com', N'TEC-PLANNING_SEC_HEAD@DPWORLD.COM', 0, NULL, N'2ba149b7-1af7-4154-9377-7337b59c117b', N'52cf7432-5d12-45dc-a47e-221d93691258', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50670', N'ops-ct_sec_head', N'OPS-CT_SEC_HEAD', N'Ahmed Zaki', N'OPS-Containers Section Head', 14, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'ops-ct_sec_head@dpworld.com', N'OPS-DRI_SEC_HEAD@DPWORLD.COM', 0, NULL, N'722a2e53-9983-4156-a2f1-0c45b3fd4c34', N'dc18f47a-7ab9-402c-adc5-e3988de4b07f', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50844', N'ops-dri_sec_head', N'OPS-DRI_SEC_HEAD', N'Ahmed Zaki', N'OPS-DRI Section Head', 13, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'ops-dri_sec_head@dpworld.com', N'OPS-DRI_SEC_HEAD@DPWORLD.COM', 0, NULL, N'6ca921ee-9142-4e7a-adf6-08da0dba2ef7', N'c03cb0b0-eaf9-4a93-8b66-2958d6c57bba', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50882', N'qhse_manager', N'QHSE_MANAGER', N'Hassan Abdelghany', N'Head of QHSE', 18, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'qhse_manager@dpworld.com', N'QHSE_MANAGER@DPWORLD.COM', 0, NULL, N'48208b24-9560-431a-84f0-aaf68d330ef4', N'7e34aeb2-4945-408b-86a9-467a15b3926d', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50962', N'gr_manager', N'GR_MANAGER', N'Mohamed Tarek', N'Head of Governmental Relation', 9, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'governmentalrelation_manager@dpworld.com', N'GOVERNMENTALRELATION_MANAGER@DPWORLD.COM', 0, NULL, N'd85ebfdf-0cf7-4687-a86c-d4d6d5e9553b', N'93f96003-4dfb-4f9b-80eb-b7e724fbf275', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51090', N'tec-crane_sec_head', N'TEC-CRANE_SEC_HEAD', N'Ahmed Zaki', N'TEC-Crane Section Head', 21, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'tec-crane_sec_head@dpworld.com', N'TEC-CRANE_SEC_HEAD@DPWORLD.COM', 0, NULL, N'3c2b1298-6d0a-4ee0-8309-9061b86b7f47', N'f7770fa3-5479-4873-97e5-30edd868367d', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51124', N'finance_manager', N'FINANCE_MANAGER', N'Mustafa Sultan', N'Head of Finance', 8, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'finance_manager@dpworld.com', N'FINANCE_MANAGER@DPWORLD.COM', 0, NULL, N'02902e4b-51c5-485b-ae1a-edf217b6a984', N'8d85d5c4-912a-4f6f-be91-66def5fcbb86', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51126', N'tec-workshop_sec_head', N'TEC-WORKSHOP_SEC_HEAD', N'Ahmed Zaki', N'TEC-Workshop Section Head', 21, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'tec-workshop_sec_head@dpworld.com', N'TEC-WORKSHOP_SEC_HEAD@DPWORLD.COM', 0, NULL, N'c18d44ca-d470-43c0-a030-a075e61c7246', N'd74711fa-3050-4ad1-8744-c006c4c80681', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51188', N'procurment_manager', N'PROCURMENT_MANAGER', N'Tamer Elsayed', N'Head of Procurment', 16, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'procurement_manager@dpworld.com', N'PROCUREMENT_MANAGER@DPWORLD.COM', 0, NULL, N'0fd8a249-8fcf-4242-b90c-c87d738660e4', N'23bbbf22-8386-4c52-8f68-816f76070adf', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51229', N'cs_manager', N'CS_MANAGER', N'Hassan Nagah', N'Head of Customer Service', 6, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'customerservice_manager@dpworld.com', N'CUSTOMERSERVICE_MANAGER@DPWORLD.COM', 0, NULL, N'2b1e5d66-2ab6-4045-98dd-dda12d001044', N'8767fde3-e9f7-4247-a5bd-efeabe302efd', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51330', N'bt_manager', N'BT_MANAGER', N'Alaa Nasr', N'Head of Business Transformation', 3, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'businesstransformation_manager@dpworld.com', N'BUSINESSTRANSFORMATION_MANAGER@DPWORLD.COM', 0, NULL, N'2800f9db-a61a-4954-93f0-9607f490f03c', N'bc1995de-17f7-4a47-9700-9b3b10496878', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51331', N'it_manager', N'IT_MANAGER', N'Alaa Nasr', N'Head of IT', 12, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'it_manager@dpworld.com', N'IT_MANAGER@DPWORLD.COM', 0, NULL, N'0f3dbe28-81bc-49bb-b5be-96fddd81ddb0', N'a85aa31e-b15f-4fe2-a696-c06ca29d5dbd', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51449', N'ops-cg_sec_head', N'OPS-CG_SEC_HEAD', N'Ahmed Zaki', N'OPS-Cargo & Bulk Section Head', 13, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'ops-cg_sec_head@dpworld.com', N'OPS-CG_SEC_HEAD@DPWORLD.COM', 0, NULL, N'5d65e1b5-bb1d-468e-a051-ed6ae0c5c92e', N'36b4d7b5-7043-4df9-b9b5-dbdacb1309f7', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51509', N'commercial-ct_sec_head', N'COMMERCIAL-CT_SEC_HEAD', N'Ahmed Zaki', N'Commercial / Containers Section Head', 4, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'commercial-ct_sec_head@dpworld.com', N'ECOMMERCIAL-CT_SEC_HEAD@DPWORLD.COM', 0, NULL, N'165db91d-40c5-4b65-8b4e-c0e200df6a97', N'bdbfab75-01ca-4b2e-83fc-41ea7b9a2cfc', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51520', N'qhse_sec_head', N'QHSE_SEC_HEAD', N'Ahmed Zaki', N'QHSE Section HEad', 18, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'qhse_sec_head@dpworld.com', N'QHSE_SEC_HEAD@DPWORLD.COM', 0, NULL, N'b3b34ead-8443-461a-b522-0c0839df6248', N'4f233a7f-8c99-473e-ade4-2fdffb1125ca', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51529', N'projects_sec_head', N'PROJECTS_SEC_HEAD', N'Ahmed Zaki', N'Projects Section Head', 21, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'projects_sec_head@dpworld.com', N'PROJECTS_SEC_HEAD@DPWORLD.COM', 0, NULL, N'401ae2eb-9477-4c0e-ae6c-6e62427bfe8c', N'bef202f5-d621-4c30-89aa-045a15d3f798', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51572', N'hc-ds_manager', N'HC-DS_MANAGER', N'Aliaa Elgammal', N'Head of HC - DUBUY Sales', 10, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'hc-ds_manager@dpworld.com', N'HC-DS_MANAGER@DPWORLD.COM', 0, NULL, N'bf95f276-6ba8-4b18-a30d-dfd00459919e', N'61327db4-47e2-42af-812d-99c337cb800c', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51573', N'commercial_manager', N'COMMERCIAL_MANAGER', N'Aliaa Elgammal', N'Head of Commercial', 4, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'commercial_manager@dpworld.com', N'COMMERCIAL_MANAGER@DPWORLD.COM', 0, NULL, N'd131c03f-32d4-4f6a-87b1-a49fe361a145', N'9095685d-ccf7-4d77-aa39-7693431f741a', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51583', N'commercial-bgc_sec_head', N'COMMERCIAL-BGC_SEC_HEAD', N'Ahmed Zaki', N'CommercialBulk / GC Section Head', 4, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'commercial-bgc_sec_head@dpworld.com', N'ECOMMERCIAL-BGC_SEC_HEAD@DPWORLD.COM', 0, NULL, N'b6ecc5f4-5926-4d82-9f8a-2db016a07a72', N'a1b09615-d136-483c-8cb2-d0e6d5d1b263', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51659', N'projects_manager', N'PROJECTS_MANAGER', N'Mohamed Mandour', N'Head of Projects & Facility Management', 17, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'projectsfacilitymanager_manager@dpworld.com', N'PROJECTSFACILITYMANAGER_MANAGER@DPWORLD.COM', 0, NULL, N'6999c5db-b468-4c3d-99c2-7aed907e86e1', N'8fe1cc25-a3e2-460b-b90f-c64790f2775a', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51668', N'communications_manager', N'COMMUNICATIONS_MANAGER', N'Amina Hatem', N'Head of Communications', 5, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'communications_manager@dpworld.com', N'COMMUNICATIONS_MANAGER@DPWORLD.COM', 0, NULL, N'155384a5-36d2-4cfa-9f6a-1995e036bf6c', N'0604f910-54d6-4519-a889-0d9e46817177', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'5587', N'test', N'TEST', N'test user', N'string', NULL, NULL, NULL, N'string', 0, 1, NULL, CAST(N'2023-09-18T08:49:00' AS SmallDateTime), CAST(N'2023-09-18T08:59:00' AS SmallDateTime), NULL, NULL, N'test@example.com', N'TEST@EXAMPLE.COM', 0, N'AQAAAAIAAYagAAAAEI8g/2wrzGNKcmcdDIHJ1BYRZt0YkhQv7gv8YxwZKCgWFbpxjRttXTCzvo2j92UUJA==', N'L6Q5LWF6LUJCEBPRVZHFSRSUTT6X6GO4', N'97a04829-0c7b-4c89-8e40-e74b87f3104b', N'01534278431', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'90008', N'hc-ds_sec_head', N'HC-DS_SEC_HEAD', N'Ahmed Zaki', N'HC - DUBUY Sales Section Head', 11, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'hc-ds_sec_head@dpworld.com', N'HC-DS_SEC_HEAD@DPWORLD.COM', 0, NULL, N'b9c7edce-aa2c-4b0f-8348-862f1e20e121', N'230f51f0-3db0-4154-ae6e-6f03073ca975', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'90010', N'ff_manager', N'FF_MANAGER', N'Hanaa Mohamed', N'Head of Freight Forwarding', 2, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'freightforwarding_manager@dpworld.com', N'FREIGHTFORWARDING_MANAGER@DPWORLD.COM', 0, NULL, N'9fd24604-c8cb-4577-8a32-cc94a47da5cc', N'c7ebaeac-11a5-4cba-b403-14c2c9bed4ac', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'90015', N'hc-ssp_sec_head', N'HC-SSP_SEC_HEAD', N'Ahmed Zaki', N'HC - Samsung SDS project  Section Head', 10, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'hc-ssp_sec_head@dpworld.com', N'HC-SSP_SEC_HEAD@DPWORLD.COM', 0, NULL, N'd9bcd931-2490-4a5f-878b-eb15c76c177e', N'2bc4e8a0-7857-46cd-bef7-d9e4258e0261', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Exp-16', N'em_manager', N'EM_MANAGER', N'Urs Moll', N'Head of Executive Management', 7, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'executivemanagement_manager@dpworld.com', N'EXECUTIVEMANAGEMENT_MANAGER@DPWORLD.COM', 0, NULL, N'b0df257d-5f2d-48b6-bab2-d59e0ca342ff', N'cc3b4114-3df9-4050-92b6-7a55d96d05cc', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'string', N'string', N'STRING', N'string', N'string', NULL, NULL, NULL, N'string', 1, 1, NULL, CAST(N'2023-09-17T15:31:00' AS SmallDateTime), NULL, NULL, NULL, N'user@example.com', N'USER@EXAMPLE.COM', 0, N'AQAAAAIAAYagAAAAEAI5JGyKSLGlfkXRKZ0CbYuAzQUDkbdVPB93/F2kT6wcgWGklsWRUMM5g4QKyVunew==', N'RZNW7Y64POKQ3R56VLG3ZFZERIXNB2JU', N'facdd0ad-0ced-4a22-94e3-91b2c23ff61b', N'01543889566', 0, 0, NULL, 1, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'stringg', N'stringg', N'STRINGG', N'stringg', N'string', NULL, NULL, NULL, N'string', 0, 1, NULL, CAST(N'2023-09-17T15:32:00' AS SmallDateTime), NULL, NULL, NULL, N'usger@example.com', N'USGER@EXAMPLE.COM', 0, N'AQAAAAIAAYagAAAAEOpT/V3Ys0L/7tbjIJTTaCHjtDKnEaaVgyH8LXTh7qPQLU8efHqhMoJIYjkQSCZ0XQ==', N'CARHMI2SCO4TOE67DLEIVD7U4JIFLRBM', N'a318c458-cb44-4f18-982d-f396ef2ba632', N'01543889566', 0, 0, CAST(N'2023-09-24T11:12:08.9021249+00:00' AS DateTimeOffset), 1, 0)
GO
INSERT [security].[UserRoles] ([UserId], [RoleId]) VALUES (N'51188', N'82cae434-a43f-4f98-86d2-4de5205a410f')
INSERT [security].[UserRoles] ([UserId], [RoleId]) VALUES (N'51124', N'9a8e4316-c998-4125-a9ef-af391a9f8243')
GO
/****** Object:  Index [IX_ApplicationItAdmin_ApplicationId]    Script Date: 9/19/2023 8:31:58 AM ******/
CREATE NONCLUSTERED INDEX [IX_ApplicationItAdmin_ApplicationId] ON [dbo].[ApplicationItAdmin]
(
	[ApplicationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ApplicationUserRequest_RequestId]    Script Date: 9/19/2023 8:31:58 AM ******/
CREATE NONCLUSTERED INDEX [IX_ApplicationUserRequest_RequestId] ON [dbo].[ApplicationUserRequest]
(
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Attachment_RequestId]    Script Date: 9/19/2023 8:31:58 AM ******/
CREATE NONCLUSTERED INDEX [IX_Attachment_RequestId] ON [dbo].[Attachment]
(
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CarRequest_RequestId]    Script Date: 9/19/2023 8:31:58 AM ******/
CREATE NONCLUSTERED INDEX [IX_CarRequest_RequestId] ON [dbo].[CarRequest]
(
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_DefinedApplication_ApplicationOwnerId]    Script Date: 9/19/2023 8:31:58 AM ******/
CREATE NONCLUSTERED INDEX [IX_DefinedApplication_ApplicationOwnerId] ON [dbo].[DefinedApplication]
(
	[ApplicationOwnerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DefinedApplicationRole_RequestedApplicationId]    Script Date: 9/19/2023 8:31:58 AM ******/
CREATE NONCLUSTERED INDEX [IX_DefinedApplicationRole_RequestedApplicationId] ON [dbo].[DefinedApplicationRole]
(
	[RequestedApplicationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DefinedRequest_DepartmentId]    Script Date: 9/19/2023 8:31:58 AM ******/
CREATE NONCLUSTERED INDEX [IX_DefinedRequest_DepartmentId] ON [dbo].[DefinedRequest]
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_DefinedRequestReviewer_ReviewerId]    Script Date: 9/19/2023 8:31:58 AM ******/
CREATE NONCLUSTERED INDEX [IX_DefinedRequestReviewer_ReviewerId] ON [dbo].[DefinedRequestReviewer]
(
	[ReviewerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DefinedRequestRole_DefinedRequestId]    Script Date: 9/19/2023 8:31:58 AM ******/
CREATE NONCLUSTERED INDEX [IX_DefinedRequestRole_DefinedRequestId] ON [dbo].[DefinedRequestRole]
(
	[DefinedRequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Department_ManagerId]    Script Date: 9/19/2023 8:31:58 AM ******/
CREATE NONCLUSTERED INDEX [IX_Department_ManagerId] ON [dbo].[Department]
(
	[ManagerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DomainAccountRequest_RequestId]    Script Date: 9/19/2023 8:31:58 AM ******/
CREATE NONCLUSTERED INDEX [IX_DomainAccountRequest_RequestId] ON [dbo].[DomainAccountRequest]
(
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_PoRequest_InvoiceNumber]    Script Date: 9/19/2023 8:31:58 AM ******/
CREATE NONCLUSTERED INDEX [IX_PoRequest_InvoiceNumber] ON [dbo].[PoRequest]
(
	[InvoiceNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_PoRequest_PoDescription]    Script Date: 9/19/2023 8:31:58 AM ******/
CREATE NONCLUSTERED INDEX [IX_PoRequest_PoDescription] ON [dbo].[PoRequest]
(
	[PoDescription] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_PoRequest_PoNumber]    Script Date: 9/19/2023 8:31:58 AM ******/
CREATE NONCLUSTERED INDEX [IX_PoRequest_PoNumber] ON [dbo].[PoRequest]
(
	[PoNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_PoRequest_RequestId]    Script Date: 9/19/2023 8:31:58 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_PoRequest_RequestId] ON [dbo].[PoRequest]
(
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_PoRequest_VendorName]    Script Date: 9/19/2023 8:31:58 AM ******/
CREATE NONCLUSTERED INDEX [IX_PoRequest_VendorName] ON [dbo].[PoRequest]
(
	[VendorName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_PoRequest_VendorNumber]    Script Date: 9/19/2023 8:31:58 AM ******/
CREATE NONCLUSTERED INDEX [IX_PoRequest_VendorNumber] ON [dbo].[PoRequest]
(
	[VendorNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Request_CreatorId]    Script Date: 9/19/2023 8:31:58 AM ******/
CREATE NONCLUSTERED INDEX [IX_Request_CreatorId] ON [dbo].[Request]
(
	[CreatorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Request_DefinedRequestId]    Script Date: 9/19/2023 8:31:58 AM ******/
CREATE NONCLUSTERED INDEX [IX_Request_DefinedRequestId] ON [dbo].[Request]
(
	[DefinedRequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_RequestApplicationRole_ApplicationId]    Script Date: 9/19/2023 8:31:58 AM ******/
CREATE NONCLUSTERED INDEX [IX_RequestApplicationRole_ApplicationId] ON [dbo].[RequestApplicationRole]
(
	[ApplicationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_RequestApplicationRole_RoleId]    Script Date: 9/19/2023 8:31:58 AM ******/
CREATE NONCLUSTERED INDEX [IX_RequestApplicationRole_RoleId] ON [dbo].[RequestApplicationRole]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_RequestReviewer_ReviewerId]    Script Date: 9/19/2023 8:31:58 AM ******/
CREATE NONCLUSTERED INDEX [IX_RequestReviewer_ReviewerId] ON [dbo].[RequestReviewer]
(
	[ReviewerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Section_DepartmentId]    Script Date: 9/19/2023 8:31:58 AM ******/
CREATE NONCLUSTERED INDEX [IX_Section_DepartmentId] ON [dbo].[Section]
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Section_HeadId]    Script Date: 9/19/2023 8:31:58 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Section_HeadId] ON [dbo].[Section]
(
	[HeadId] ASC
)
WHERE ([HeadId] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_TravelDeskRequest_RequestId]    Script Date: 9/19/2023 8:31:58 AM ******/
CREATE NONCLUSTERED INDEX [IX_TravelDeskRequest_RequestId] ON [dbo].[TravelDeskRequest]
(
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_VoucherRequest_RequestId]    Script Date: 9/19/2023 8:31:58 AM ******/
CREATE NONCLUSTERED INDEX [IX_VoucherRequest_RequestId] ON [dbo].[VoucherRequest]
(
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 9/19/2023 8:31:58 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [security].[Role]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_RoleClaims_RoleId]    Script Date: 9/19/2023 8:31:58 AM ******/
CREATE NONCLUSTERED INDEX [IX_RoleClaims_RoleId] ON [security].[RoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 9/19/2023 8:31:58 AM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [security].[User]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_User_DepartmentId]    Script Date: 9/19/2023 8:31:58 AM ******/
CREATE NONCLUSTERED INDEX [IX_User_DepartmentId] ON [security].[User]
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_User_ManagerId]    Script Date: 9/19/2023 8:31:58 AM ******/
CREATE NONCLUSTERED INDEX [IX_User_ManagerId] ON [security].[User]
(
	[ManagerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_User_SectionId]    Script Date: 9/19/2023 8:31:58 AM ******/
CREATE NONCLUSTERED INDEX [IX_User_SectionId] ON [security].[User]
(
	[SectionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 9/19/2023 8:31:58 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [security].[User]
(
	[NormalizedUserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserClaims_UserId]    Script Date: 9/19/2023 8:31:58 AM ******/
CREATE NONCLUSTERED INDEX [IX_UserClaims_UserId] ON [security].[UserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserLogin_UserId]    Script Date: 9/19/2023 8:31:58 AM ******/
CREATE NONCLUSTERED INDEX [IX_UserLogin_UserId] ON [security].[UserLogin]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserRoles_RoleId]    Script Date: 9/19/2023 8:31:58 AM ******/
CREATE NONCLUSTERED INDEX [IX_UserRoles_RoleId] ON [security].[UserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Attachment] ADD  DEFAULT (CONVERT([bigint],(0))) FOR [RequestId]
GO
ALTER TABLE [dbo].[RequestReviewer] ADD  DEFAULT (N'') FOR [ReviewerType]
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
