USE [master]
GO
/****** Object:  Database [E-Document]    Script Date: 9/20/2023 8:35:42 PM ******/
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
/****** Object:  Schema [security]    Script Date: 9/20/2023 8:35:42 PM ******/
CREATE SCHEMA [security]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 9/20/2023 8:35:42 PM ******/
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
/****** Object:  Table [dbo].[ApplicationItAdmin]    Script Date: 9/20/2023 8:35:42 PM ******/
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
/****** Object:  Table [dbo].[ApplicationUserRequest]    Script Date: 9/20/2023 8:35:42 PM ******/
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
/****** Object:  Table [dbo].[Attachment]    Script Date: 9/20/2023 8:35:42 PM ******/
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
/****** Object:  Table [dbo].[CarRequest]    Script Date: 9/20/2023 8:35:42 PM ******/
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
/****** Object:  Table [dbo].[DefinedApplication]    Script Date: 9/20/2023 8:35:42 PM ******/
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
/****** Object:  Table [dbo].[DefinedApplicationRole]    Script Date: 9/20/2023 8:35:42 PM ******/
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
/****** Object:  Table [dbo].[DefinedRequest]    Script Date: 9/20/2023 8:35:42 PM ******/
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
/****** Object:  Table [dbo].[DefinedRequestReviewer]    Script Date: 9/20/2023 8:35:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DefinedRequestReviewer](
	[DefinedRequestId] [bigint] NOT NULL,
	[AssignedReviewerId] [nvarchar](50) NOT NULL,
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
	[AssignedReviewerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DefinedRequestRole]    Script Date: 9/20/2023 8:35:42 PM ******/
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
/****** Object:  Table [dbo].[Department]    Script Date: 9/20/2023 8:35:42 PM ******/
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
/****** Object:  Table [dbo].[DomainAccountRequest]    Script Date: 9/20/2023 8:35:42 PM ******/
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
/****** Object:  Table [dbo].[PoRequest]    Script Date: 9/20/2023 8:35:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PoRequest](
	[PoNumber] [nvarchar](450) NOT NULL,
	[PoDescription] [nvarchar](max) NOT NULL,
	[VendorName] [nvarchar](450) NOT NULL,
	[VendorNumber] [int] NOT NULL,
	[InvoiceNumber] [nvarchar](450) NOT NULL,
	[PoAttachmentPath] [nvarchar](max) NOT NULL,
	[InvoiceAttachmentPath] [nvarchar](max) NOT NULL,
	[RequestId] [bigint] NOT NULL,
	[CreatedAt] [smalldatetime] NULL,
	[ModifiedAt] [smalldatetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[ModifiedBy] [nvarchar](50) NULL,
	[CreatorFullName] [nvarchar](200) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [IX_PoRequest_RequestId]    Script Date: 9/20/2023 8:35:42 PM ******/
CREATE UNIQUE CLUSTERED INDEX [IX_PoRequest_RequestId] ON [dbo].[PoRequest]
(
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Request]    Script Date: 9/20/2023 8:35:42 PM ******/
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
/****** Object:  Table [dbo].[RequestApplicationRole]    Script Date: 9/20/2023 8:35:42 PM ******/
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
/****** Object:  Table [dbo].[RequestReviewer]    Script Date: 9/20/2023 8:35:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RequestReviewer](
	[RequestId] [bigint] NOT NULL,
	[AssignedReviewerId] [nvarchar](50) NOT NULL,
	[StageName] [nvarchar](max) NULL,
	[StageNumber] [int] NOT NULL,
	[ReviewerType] [nvarchar](50) NOT NULL,
	[Status] [nvarchar](50) NOT NULL,
	[ReviewerNotes] [nvarchar](max) NULL,
	[CreatedAt] [smalldatetime] NULL,
	[ModifiedAt] [smalldatetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[ModifiedBy] [nvarchar](50) NULL,
	[ReviewedBy] [nvarchar](200) NULL,
 CONSTRAINT [PK_RequestReviewer] PRIMARY KEY CLUSTERED 
(
	[RequestId] ASC,
	[AssignedReviewerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Section]    Script Date: 9/20/2023 8:35:42 PM ******/
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
/****** Object:  Table [dbo].[TravelDeskRequest]    Script Date: 9/20/2023 8:35:42 PM ******/
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
/****** Object:  Table [dbo].[VoucherRequest]    Script Date: 9/20/2023 8:35:42 PM ******/
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
/****** Object:  Table [security].[Role]    Script Date: 9/20/2023 8:35:42 PM ******/
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
/****** Object:  Table [security].[RoleClaims]    Script Date: 9/20/2023 8:35:42 PM ******/
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
/****** Object:  Table [security].[User]    Script Date: 9/20/2023 8:35:42 PM ******/
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
/****** Object:  Table [security].[UserClaims]    Script Date: 9/20/2023 8:35:42 PM ******/
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
/****** Object:  Table [security].[UserLogin]    Script Date: 9/20/2023 8:35:42 PM ******/
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
/****** Object:  Table [security].[UserRoles]    Script Date: 9/20/2023 8:35:42 PM ******/
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
/****** Object:  Table [security].[UserToken]    Script Date: 9/20/2023 8:35:42 PM ******/
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
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230919091355_changePoRequetPk', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230919131844_addReviewedByColumn', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230920095055_addCreatorFullName', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230920100035_updateRequestsRelations', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230920111810_updatePermisions', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230920135940_moveCreatorFullNameform_Request_to_PoRequest', N'7.0.10')
GO
SET IDENTITY_INSERT [dbo].[DefinedRequest] ON 

INSERT [dbo].[DefinedRequest] ([Id], [RequestName], [RouteName], [ReviewersNumber], [DepartmentId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (1, N'PO', N'/Procurement/PO/', 1, 16, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[DefinedRequest] OFF
GO
INSERT [dbo].[DefinedRequestReviewer] ([DefinedRequestId], [AssignedReviewerId], [DelegatedReviewerId], [StageName], [StageNumber], [ReviewerType], [DelegatedUntil], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (1, N'51124', NULL, N'Finance Reviewer', 1, N'Basic', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[DefinedRequestRole] ([RoleId], [DefinedRequestId], [Permission], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'121c1742-99e7-4b61-ab2f-f748876e2975', 1, N'Review', NULL, NULL, NULL, NULL)
INSERT [dbo].[DefinedRequestRole] ([RoleId], [DefinedRequestId], [Permission], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'6826ac7e-b4ae-47ff-8bf6-cc904db43d84', 1, N'Request', NULL, NULL, NULL, NULL)
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
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.91-4+', N'Vestibulum ac est lacinia nisi venenatis tristique. Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue.', N'Gaven Ricart', 29, N'4026900139327814', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 205, CAST(N'2023-06-23T00:00:00' AS SmallDateTime), CAST(N'2023-09-04T00:00:00' AS SmallDateTime), N'procurment_manager', N'gricarts', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.16-1+', N'Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat. Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede. Morbi porttitor lorem id ligula.', N'Yolane Padmore', 20, N'5280763276227918', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 208, CAST(N'2023-01-20T00:00:00' AS SmallDateTime), CAST(N'2023-07-04T00:00:00' AS SmallDateTime), N'procurment_manager', N'ypadmorej', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.73-6+', N'Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh. In quis justo.', N'Irene Maddigan', 6, N'5018786633938378879', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 209, CAST(N'2023-01-30T00:00:00' AS SmallDateTime), CAST(N'2022-10-10T00:00:00' AS SmallDateTime), N'imaddigan5', N'imaddigan5', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.09-8+', N'Vestibulum sed magna at nunc commodo placerat. Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede. Morbi porttitor lorem id ligula. Suspendisse ornare consequat lectus.', N'Andi Steward', 18, N'3571748594742006', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 216, CAST(N'2023-07-05T00:00:00' AS SmallDateTime), CAST(N'2023-01-28T00:00:00' AS SmallDateTime), N'astewardh', N'astewardh', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.86-4+', N'Phasellus id sapien in sapien iaculis congue. Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl.', N'Reina Stoves', 21, N'3544603271795203', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 218, CAST(N'2022-11-06T00:00:00' AS SmallDateTime), CAST(N'2023-01-01T00:00:00' AS SmallDateTime), N'rstovesk', N'rstovesk', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.15-3+', N'Duis bibendum. Morbi non quam nec dui luctus rutrum. Nulla tellus. In sagittis dui vel nisl.', N'Corrinne Braidford', 16, N'6334209994908064926', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 222, CAST(N'2023-08-24T00:00:00' AS SmallDateTime), CAST(N'2023-05-03T00:00:00' AS SmallDateTime), N'cbraidfordf', N'cbraidfordf', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.27-9+', N'Fusce consequat.', N'Pia McNess', 1, N'3573809752532338', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 224, CAST(N'2023-01-29T00:00:00' AS SmallDateTime), CAST(N'2023-06-25T00:00:00' AS SmallDateTime), N'pmcness0', N'pmcness0', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.68-7+', N'Nulla mollis molestie lorem. Quisque ut erat. Curabitur gravida nisi at nibh. In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat.', N'Max Dahlback', 11, N'3528961373803246', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 238, CAST(N'2023-07-24T00:00:00' AS SmallDateTime), CAST(N'2022-12-06T00:00:00' AS SmallDateTime), N'mdahlbacka', N'mdahlbacka', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.77-4+', N'Nullam molestie nibh in lectus. Pellentesque at nulla. Suspendisse potenti. Cras in purus eu magna vulputate luctus. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vivamus vestibulum sagittis sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Etiam vel augue.', N'Datha Blampied', 12, N'3562373062410845', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 239, CAST(N'2023-04-23T00:00:00' AS SmallDateTime), CAST(N'2023-05-23T00:00:00' AS SmallDateTime), N'dblampiedb', N'dblampiedb', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.46-9+', N'Curabitur convallis. Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor. Morbi vel lectus in quam fringilla rhoncus. Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis. Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero.', N'Tanny Sporton', 49, N'3574363464482431', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 248, CAST(N'2023-03-14T00:00:00' AS SmallDateTime), CAST(N'2023-08-29T00:00:00' AS SmallDateTime), N'tsporton1c', N'tsporton1c', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.27-2+', N'Etiam vel augue. Vestibulum rutrum rutrum neque. Aenean auctor gravida sem. Praesent id massa id nisl venenatis lacinia. Aenean sit amet justo. Morbi ut odio. Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo. In blandit ultrices enim.', N'Kaela Pirt', 8, N'3559293680994761', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 250, CAST(N'2023-03-22T00:00:00' AS SmallDateTime), CAST(N'2022-12-26T00:00:00' AS SmallDateTime), N'kpirt7', N'kpirt7', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.10-5+', N'In congue. Etiam justo. Etiam pretium iaculis justo.', N'Corabella Tolussi', 33, N'3528465889009751', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 252, CAST(N'2023-02-09T00:00:00' AS SmallDateTime), CAST(N'2022-12-20T00:00:00' AS SmallDateTime), N'ctolussiw', N'ctolussiw', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.25-5+', N'Duis mattis egestas metus. Aenean fermentum.', N'Obadias Linstead', 42, N'3535149896560565', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 253, CAST(N'2022-12-20T00:00:00' AS SmallDateTime), CAST(N'2023-09-10T00:00:00' AS SmallDateTime), N'olinstead15', N'olinstead15', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.11-7+', N'In est risus, auctor sed, tristique in, tempus sit amet, sem. Fusce consequat. Nulla nisl. Nunc nisl. Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa.', N'Jarrad Biaggi', 24, N'5010129106754330', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 254, CAST(N'2022-11-18T00:00:00' AS SmallDateTime), CAST(N'2023-03-09T00:00:00' AS SmallDateTime), N'jbiaggin', N'jbiaggin', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.50-9+', N'Praesent lectus. Vestibulum quam sapien, varius ut, blandit non, interdum in, ante. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio. Curabitur convallis.', N'Lory Malacrida', 45, N'3554509272156914', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 259, CAST(N'2023-03-06T00:00:00' AS SmallDateTime), CAST(N'2022-10-18T00:00:00' AS SmallDateTime), N'lmalacrida18', N'lmalacrida18', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.52-1+', N'Vestibulum ac est lacinia nisi venenatis tristique. Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue. Aliquam erat volutpat.', N'Dev Brame', 5, N'6767147846678208065', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 271, CAST(N'2023-06-17T00:00:00' AS SmallDateTime), CAST(N'2023-01-11T00:00:00' AS SmallDateTime), N'dbrame4', N'dbrame4', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.20-7+', N'Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Etiam vel augue. Vestibulum rutrum rutrum neque. Aenean auctor gravida sem. Praesent id massa id nisl venenatis lacinia. Aenean sit amet justo. Morbi ut odio. Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo. In blandit ultrices enim. Lorem ipsum dolor sit amet, consectetuer adipiscing elit.', N'Bronnie Dominguez', 35, N'3578659126215812', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 272, CAST(N'2023-04-13T00:00:00' AS SmallDateTime), CAST(N'2023-06-05T00:00:00' AS SmallDateTime), N'bdominguezy', N'bdominguezy', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.14-4+', N'Donec ut dolor. Morbi vel lectus in quam fringilla rhoncus.', N'Denna Frame', 37, N'5610496641795480', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 273, CAST(N'2023-08-03T00:00:00' AS SmallDateTime), CAST(N'2023-08-20T00:00:00' AS SmallDateTime), N'dframe10', N'dframe10', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.21-4+', N'Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue. Aliquam erat volutpat. In congue. Etiam justo.', N'Merline Fuzzens', 32, N'493666448873988516', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 276, CAST(N'2022-10-15T00:00:00' AS SmallDateTime), CAST(N'2023-06-03T00:00:00' AS SmallDateTime), N'mfuzzensv', N'mfuzzensv', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.20-3+', N'Duis mattis egestas metus.', N'Killie Walthall', 50, N'5602223460289274', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 277, CAST(N'2023-01-02T00:00:00' AS SmallDateTime), CAST(N'2022-10-16T00:00:00' AS SmallDateTime), N'kwalthall1d', N'kwalthall1d', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.15-8+', N'Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Etiam vel augue. Vestibulum rutrum rutrum neque. Aenean auctor gravida sem. Praesent id massa id nisl venenatis lacinia. Aenean sit amet justo.', N'Jacky Woodhouse', 14, N'3552009821673925', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 278, CAST(N'2023-03-03T00:00:00' AS SmallDateTime), CAST(N'2023-06-27T00:00:00' AS SmallDateTime), N'jwoodhoused', N'jwoodhoused', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.22-1+', N'Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus.', N'Carroll Banasiak', 13, N'3532846423299657', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 279, CAST(N'2023-05-29T00:00:00' AS SmallDateTime), CAST(N'2023-07-04T00:00:00' AS SmallDateTime), N'cbanasiakc', N'cbanasiakc', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.27-8+', N'Nulla nisl.', N'Terrance Willcocks', 34, N'06047395989808916', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 280, CAST(N'2023-03-10T00:00:00' AS SmallDateTime), CAST(N'2022-09-24T00:00:00' AS SmallDateTime), N'twillcocksx', N'twillcocksx', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.38-9+', N'Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus.', N'Farra Patrickson', 25, N'6771344448383248875', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 281, CAST(N'2022-11-11T00:00:00' AS SmallDateTime), CAST(N'2023-04-18T00:00:00' AS SmallDateTime), N'fpatricksono', N'fpatricksono', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.29-7+', N'In eleifend quam a odio.', N'Liuka Neesham', 36, N'503888007560133212', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 282, CAST(N'2023-03-13T00:00:00' AS SmallDateTime), CAST(N'2022-10-16T00:00:00' AS SmallDateTime), N'lneeshamz', N'lneeshamz', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.30-7+', N'Vivamus vestibulum sagittis sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.', N'Celene Cordsen', 17, N'6334941117489021684', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 283, CAST(N'2023-09-02T00:00:00' AS SmallDateTime), CAST(N'2023-04-28T00:00:00' AS SmallDateTime), N'ccordseng', N'ccordseng', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.31-4+', N'Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat. Praesent blandit. Nam nulla.', N'Rowena Twaits', 40, N'56022171565601205', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 284, CAST(N'2022-10-23T00:00:00' AS SmallDateTime), CAST(N'2023-03-10T00:00:00' AS SmallDateTime), N'rtwaits13', N'rtwaits13', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.38-2+', N'Praesent id massa id nisl venenatis lacinia. Aenean sit amet justo. Morbi ut odio. Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo. In blandit ultrices enim. Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin interdum mauris non ligula pellentesque ultrices.', N'Clifford Peachey', 39, N'3579204957590915', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 285, CAST(N'2023-09-09T00:00:00' AS SmallDateTime), CAST(N'2023-01-24T00:00:00' AS SmallDateTime), N'cpeachey12', N'cpeachey12', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.43-8+', N'Maecenas tincidunt lacus at velit. Vivamus vel nulla eget eros elementum pellentesque. Quisque porta volutpat erat. Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus. Phasellus in felis. Donec semper sapien a libero. Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis.', N'Eugenius Dongall', 48, N'3557518638220907', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 286, CAST(N'2022-12-24T00:00:00' AS SmallDateTime), CAST(N'2023-02-16T00:00:00' AS SmallDateTime), N'edongall1b', N'edongall1b', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.45-7+', N'Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat.', N'Luz Harnott', 31, N'3528061060197505', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 287, CAST(N'2023-05-23T00:00:00' AS SmallDateTime), CAST(N'2023-04-26T00:00:00' AS SmallDateTime), N'lharnottu', N'lharnottu', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.46-7+', N'Cras pellentesque volutpat dui. Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti. Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum.', N'Christi Coggles', 41, N'3578607582022321', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 288, CAST(N'2023-04-22T00:00:00' AS SmallDateTime), CAST(N'2023-05-01T00:00:00' AS SmallDateTime), N'ccoggles14', N'ccoggles14', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.53-3+', N'Suspendisse potenti.', N'Nicol Brea', 43, N'3557568285973316', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 289, CAST(N'2022-10-01T00:00:00' AS SmallDateTime), CAST(N'2023-05-08T00:00:00' AS SmallDateTime), N'nbrea16', N'nbrea16', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.55-3+', N'Pellentesque ultrices mattis odio. Donec vitae nisi. Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus. Curabitur at ipsum ac tellus semper interdum.', N'Fidole Babcock', 22, N'3579409999230269', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 290, CAST(N'2023-03-31T00:00:00' AS SmallDateTime), CAST(N'2023-01-01T00:00:00' AS SmallDateTime), N'fbabcockl', N'fbabcockl', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.55-4+', N'Nunc purus. Phasellus in felis. Donec semper sapien a libero. Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla.', N'Sheelagh McCunn', 26, N'3576928668581804', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 291, CAST(N'2023-08-26T00:00:00' AS SmallDateTime), CAST(N'2023-04-06T00:00:00' AS SmallDateTime), N'smccunnp', N'smccunnp', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.57-8+', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin interdum mauris non ligula pellentesque ultrices. Phasellus id sapien in sapien iaculis congue.', N'Nydia Colchett', 47, N'3573720130982808', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 292, CAST(N'2023-05-03T00:00:00' AS SmallDateTime), CAST(N'2023-09-12T00:00:00' AS SmallDateTime), N'ncolchett1a', N'ncolchett1a', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.62-7+', N'In eleifend quam a odio. In hac habitasse platea dictumst. Maecenas ut massa quis augue luctus tincidunt. Nulla mollis molestie lorem. Quisque ut erat. Curabitur gravida nisi at nibh. In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat.', N'Kania Danton', 2, N'6333956052258700933', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 293, CAST(N'2023-05-15T00:00:00' AS SmallDateTime), CAST(N'2023-07-15T00:00:00' AS SmallDateTime), N'kdanton1', N'kdanton1', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.73-3+', N'Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl. Nunc rhoncus dui vel sem. Sed sagittis. Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus. Pellentesque at nulla. Suspendisse potenti. Cras in purus eu magna vulputate luctus. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.', N'Krisha Franciottoi', 10, N'3552245872273856', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 294, CAST(N'2023-08-16T00:00:00' AS SmallDateTime), CAST(N'2022-10-11T00:00:00' AS SmallDateTime), N'kfranciottoi9', N'kfranciottoi9', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.82-0+', N'Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus. Phasellus in felis. Donec semper sapien a libero.', N'Avrit Blount', 46, N'3578244889741609', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 295, CAST(N'2023-08-12T00:00:00' AS SmallDateTime), CAST(N'2023-07-12T00:00:00' AS SmallDateTime), N'ablount19', N'ablount19', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.82-2+', N'Vestibulum ac est lacinia nisi venenatis tristique. Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue. Aliquam erat volutpat. In congue. Etiam justo. Etiam pretium iaculis justo.', N'Marita Klaggeman', 4, N'6371622373105872', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 296, CAST(N'2023-04-02T00:00:00' AS SmallDateTime), CAST(N'2023-05-27T00:00:00' AS SmallDateTime), N'mklaggeman3', N'mklaggeman3', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.86-0+', N'Integer ac neque. Duis bibendum.', N'Frederica Pressman', 27, N'3561827226709773', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 297, CAST(N'2022-12-05T00:00:00' AS SmallDateTime), CAST(N'2023-07-29T00:00:00' AS SmallDateTime), N'fpressmanq', N'fpressmanq', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.86-1+', N'Aliquam erat volutpat. In congue. Etiam justo. Etiam pretium iaculis justo. In hac habitasse platea dictumst. Etiam faucibus cursus urna. Ut tellus. Nulla ut erat id mauris vulputate elementum. Nullam varius.', N'Arline Cossem', 19, N'4911613110784514267', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 298, CAST(N'2022-11-23T00:00:00' AS SmallDateTime), CAST(N'2022-11-07T00:00:00' AS SmallDateTime), N'acossemi', N'acossemi', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.87-6+', N'Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat. Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede. Morbi porttitor lorem id ligula. Suspendisse ornare consequat lectus. In est risus, auctor sed, tristique in, tempus sit amet, sem. Fusce consequat. Nulla nisl.', N'Jo Hanshaw', 3, N'3544715717139539', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 299, CAST(N'2023-04-19T00:00:00' AS SmallDateTime), CAST(N'2023-06-26T00:00:00' AS SmallDateTime), N'jhanshaw2', N'jhanshaw2', NULL)
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [CreatorFullName]) VALUES (N'SOK.PO.20-16432928', N'po description', N'Test Vendor', 99, N'323242', N'string', N'string', 302, CAST(N'2023-09-20T20:17:00' AS SmallDateTime), NULL, N'procurement_manager', NULL, N'Tamer Elsayed')
GO
SET IDENTITY_INSERT [dbo].[Request] ON 

INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (201, 0, N'Pending', N'Vestibulum quam sapien, varius ut, blandit non, interdum in, ante. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio. Curabitur convallis. Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor.', N'51188', 1, CAST(N'2023-08-30T00:00:00' AS SmallDateTime), CAST(N'2023-03-11T00:00:00' AS SmallDateTime), N'ccanadas0', N'aleaver0')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (202, 0, N'Approved', N'Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus. Curabitur at ipsum ac tellus semper interdum. Mauris ullamcorper purus sit amet nulla. Quisque arcu libero, rutrum ac, lobortis vel, dapibus at, diam. Nam tristique tortor eu pede.', N'51188', 1, CAST(N'2022-09-28T00:00:00' AS SmallDateTime), CAST(N'2023-07-14T00:00:00' AS SmallDateTime), N'pdewinton1', N'cmckirdy1')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (203, 0, N'Pending', N'Morbi vel lectus in quam fringilla rhoncus. Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis. Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh. In quis justo. Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet.', N'51188', 1, CAST(N'2023-07-16T00:00:00' AS SmallDateTime), CAST(N'2023-09-08T00:00:00' AS SmallDateTime), N'sgreenlees2', N'mfawdrie2')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (204, 1, N'Declined', N'Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat.', N'51188', 1, CAST(N'2023-08-26T00:00:00' AS SmallDateTime), CAST(N'2023-04-06T00:00:00' AS SmallDateTime), N'mwharby3', N'rdobbins3')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (205, 0, N'Pending', N'Suspendisse ornare consequat lectus. In est risus, auctor sed, tristique in, tempus sit amet, sem. Fusce consequat. Nulla nisl. Nunc nisl. Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus. Duis at velit eu est congue elementum. In hac habitasse platea dictumst. Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante.', N'51188', 1, CAST(N'2023-02-25T00:00:00' AS SmallDateTime), CAST(N'2023-03-31T00:00:00' AS SmallDateTime), N'edenham4', N'jbatrim4')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (206, 0, N'Pending', N'Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum. Aliquam non mauris. Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet.', N'51188', 1, CAST(N'2023-08-14T00:00:00' AS SmallDateTime), CAST(N'2023-02-19T00:00:00' AS SmallDateTime), N'wdawidman5', N'pwoodsford5')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (207, 1, N'Approved', N'Vivamus vestibulum sagittis sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Etiam vel augue. Vestibulum rutrum rutrum neque. Aenean auctor gravida sem. Praesent id massa id nisl venenatis lacinia. Aenean sit amet justo. Morbi ut odio. Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo.', N'51188', 1, CAST(N'2022-11-16T00:00:00' AS SmallDateTime), CAST(N'2022-10-14T00:00:00' AS SmallDateTime), N'jmoine6', N'hrunnett6')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (208, 1, N'Pending', N'Donec vitae nisi. Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus. Curabitur at ipsum ac tellus semper interdum. Mauris ullamcorper purus sit amet nulla.', N'51188', 1, CAST(N'2023-04-11T00:00:00' AS SmallDateTime), CAST(N'2023-07-13T00:00:00' AS SmallDateTime), N'scristea7', N'dlerohan7')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (209, 0, N'Approved', N'Mauris sit amet eros. Suspendisse accumsan tortor quis turpis. Sed ante. Vivamus tortor. Duis mattis egestas metus.', N'51188', 1, CAST(N'2023-01-04T00:00:00' AS SmallDateTime), CAST(N'2023-03-15T00:00:00' AS SmallDateTime), N'blattey8', N'slavell8')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (210, 0, N'Pending', N'Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis. Ut at dolor quis odio consequat varius. Integer ac leo. Pellentesque ultrices mattis odio. Donec vitae nisi.', N'51188', 1, CAST(N'2023-09-04T00:00:00' AS SmallDateTime), CAST(N'2023-03-07T00:00:00' AS SmallDateTime), N'ebreese9', N'mpesselt9')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (211, 1, N'Pending', N'Suspendisse potenti. In eleifend quam a odio. In hac habitasse platea dictumst. Maecenas ut massa quis augue luctus tincidunt. Nulla mollis molestie lorem. Quisque ut erat. Curabitur gravida nisi at nibh.', N'51188', 1, CAST(N'2023-09-09T00:00:00' AS SmallDateTime), CAST(N'2023-07-15T00:00:00' AS SmallDateTime), N'mgavozzia', N'aabthorpea')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (212, 0, N'Approved', N'Donec posuere metus vitae ipsum. Aliquam non mauris. Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet.', N'51188', 1, CAST(N'2023-06-04T00:00:00' AS SmallDateTime), CAST(N'2023-09-12T00:00:00' AS SmallDateTime), N'sposnettb', N'aportwaineb')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (213, 1, N'Pending', N'In hac habitasse platea dictumst. Maecenas ut massa quis augue luctus tincidunt. Nulla mollis molestie lorem.', N'51188', 1, CAST(N'2023-05-31T00:00:00' AS SmallDateTime), CAST(N'2023-05-15T00:00:00' AS SmallDateTime), N'kmcleodc', N'lbalhatchetc')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (215, 1, N'Declined', N'Nunc purus. Phasellus in felis. Donec semper sapien a libero. Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis. Ut at dolor quis odio consequat varius.', N'51188', 1, CAST(N'2022-09-27T00:00:00' AS SmallDateTime), CAST(N'2023-06-07T00:00:00' AS SmallDateTime), N'rfarakere', N'ejoddense')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (216, 1, N'Pending', N'Donec posuere metus vitae ipsum. Aliquam non mauris. Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis.', N'51188', 1, CAST(N'2023-05-14T00:00:00' AS SmallDateTime), CAST(N'2022-09-29T00:00:00' AS SmallDateTime), N'araynorf', N'wrickerbyf')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (217, 0, N'Declined', N'In hac habitasse platea dictumst.', N'51188', 1, CAST(N'2023-05-24T00:00:00' AS SmallDateTime), CAST(N'2023-09-04T00:00:00' AS SmallDateTime), N'dfindleyg', N'tsaterthwaitg')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (218, 1, N'Pending', N'Praesent lectus. Vestibulum quam sapien, varius ut, blandit non, interdum in, ante. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio. Curabitur convallis. Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor. Morbi vel lectus in quam fringilla rhoncus. Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis. Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero.', N'51188', 1, CAST(N'2023-08-04T00:00:00' AS SmallDateTime), CAST(N'2023-07-04T00:00:00' AS SmallDateTime), N'dleggitth', N'hramelh')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (219, 0, N'Approved', N'Phasellus sit amet erat. Nulla tempus. Vivamus in felis eu sapien cursus vestibulum. Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy.', N'51188', 1, CAST(N'2022-11-26T00:00:00' AS SmallDateTime), CAST(N'2022-10-06T00:00:00' AS SmallDateTime), N'mstollenwercki', N'akoppi')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (220, 1, N'Pending', N'Nulla tempus. Vivamus in felis eu sapien cursus vestibulum. Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy. Integer non velit. Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue.', N'51188', 1, CAST(N'2022-11-14T00:00:00' AS SmallDateTime), CAST(N'2023-02-18T00:00:00' AS SmallDateTime), N'sliffj', N'mbendlej')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (221, 1, N'Approved', N'In hac habitasse platea dictumst. Etiam faucibus cursus urna. Ut tellus. Nulla ut erat id mauris vulputate elementum.', N'51188', 1, CAST(N'2023-09-03T00:00:00' AS SmallDateTime), CAST(N'2023-08-04T00:00:00' AS SmallDateTime), N'adriuttik', N'klucak')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (222, 0, N'Approved', N'Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus. Suspendisse potenti. In eleifend quam a odio.', N'51188', 1, CAST(N'2022-09-20T00:00:00' AS SmallDateTime), CAST(N'2022-11-25T00:00:00' AS SmallDateTime), N'bmettsl', N'mandresl')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (223, 0, N'Pending', N'Morbi non quam nec dui luctus rutrum. Nulla tellus. In sagittis dui vel nisl.', N'51188', 1, CAST(N'2023-07-19T00:00:00' AS SmallDateTime), CAST(N'2023-01-10T00:00:00' AS SmallDateTime), N'cmccurleym', N'mduffillm')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (224, 1, N'Pending', N'Phasellus sit amet erat. Nulla tempus. Vivamus in felis eu sapien cursus vestibulum. Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy.', N'51188', 1, CAST(N'2023-08-30T00:00:00' AS SmallDateTime), CAST(N'2023-02-16T00:00:00' AS SmallDateTime), N'rwalderan', N'eboothebien')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (225, 0, N'Pending', N'Vestibulum rutrum rutrum neque.', N'51188', 1, CAST(N'2022-11-09T00:00:00' AS SmallDateTime), CAST(N'2023-05-21T00:00:00' AS SmallDateTime), N'ahouldino', N'rcraiggo')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (226, 1, N'Pending', N'Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis. Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl. Nunc rhoncus dui vel sem. Sed sagittis. Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci.', N'51188', 1, CAST(N'2023-04-29T00:00:00' AS SmallDateTime), CAST(N'2022-12-14T00:00:00' AS SmallDateTime), N'rdantuonip', N'mabbessp')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (227, 1, N'Declined', N'Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante.', N'51188', 1, CAST(N'2023-08-09T00:00:00' AS SmallDateTime), CAST(N'2022-10-18T00:00:00' AS SmallDateTime), N'vpierucciq', N'vbernardotteq')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (229, 0, N'Pending', N'Suspendisse ornare consequat lectus. In est risus, auctor sed, tristique in, tempus sit amet, sem. Fusce consequat. Nulla nisl. Nunc nisl. Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus. Duis at velit eu est congue elementum.', N'51188', 1, CAST(N'2022-11-24T00:00:00' AS SmallDateTime), CAST(N'2023-05-20T00:00:00' AS SmallDateTime), N'cjanneys', N'larmatyss')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (230, 0, N'Declined', N'Aenean auctor gravida sem. Praesent id massa id nisl venenatis lacinia. Aenean sit amet justo. Morbi ut odio. Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo. In blandit ultrices enim. Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin interdum mauris non ligula pellentesque ultrices. Phasellus id sapien in sapien iaculis congue. Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl.', N'51188', 1, CAST(N'2023-03-26T00:00:00' AS SmallDateTime), CAST(N'2023-01-21T00:00:00' AS SmallDateTime), N'calecockt', N'cbrotherhoodt')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (231, 1, N'Declined', N'Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui. Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc.', N'51188', 1, CAST(N'2023-01-13T00:00:00' AS SmallDateTime), CAST(N'2022-10-12T00:00:00' AS SmallDateTime), N'sbaylieu', N'ktomasianu')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (232, 1, N'Approved', N'Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque. Duis bibendum. Morbi non quam nec dui luctus rutrum. Nulla tellus. In sagittis dui vel nisl.', N'51188', 1, CAST(N'2022-09-19T00:00:00' AS SmallDateTime), CAST(N'2023-08-24T00:00:00' AS SmallDateTime), N'msanjav', N'misaaksohnv')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (233, 1, N'Pending', N'Integer non velit. Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque. Duis bibendum. Morbi non quam nec dui luctus rutrum. Nulla tellus. In sagittis dui vel nisl. Duis ac nibh. Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus.', N'51188', 1, CAST(N'2022-11-04T00:00:00' AS SmallDateTime), CAST(N'2023-04-30T00:00:00' AS SmallDateTime), N'omantlew', N'mlapsleyw')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (234, 0, N'Pending', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin risus. Praesent lectus. Vestibulum quam sapien, varius ut, blandit non, interdum in, ante. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio. Curabitur convallis.', N'51188', 1, CAST(N'2022-11-08T00:00:00' AS SmallDateTime), CAST(N'2022-12-21T00:00:00' AS SmallDateTime), N'ndeevesx', N'migonetx')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (235, 1, N'Approved', N'Proin interdum mauris non ligula pellentesque ultrices.', N'51188', 1, CAST(N'2023-05-10T00:00:00' AS SmallDateTime), CAST(N'2022-12-02T00:00:00' AS SmallDateTime), N'kmatiebey', N'choundsony')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (236, 1, N'Approved', N'Aenean auctor gravida sem. Praesent id massa id nisl venenatis lacinia. Aenean sit amet justo.', N'51188', 1, CAST(N'2023-06-05T00:00:00' AS SmallDateTime), CAST(N'2022-10-03T00:00:00' AS SmallDateTime), N'omacroriez', N'rmcmychemz')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (237, 0, N'Approved', N'Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci.', N'51188', 1, CAST(N'2022-11-10T00:00:00' AS SmallDateTime), CAST(N'2023-02-12T00:00:00' AS SmallDateTime), N'aperfect10', N'jissacoff10')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (238, 1, N'Declined', N'Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante. Nulla justo. Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros. Suspendisse accumsan tortor quis turpis. Sed ante. Vivamus tortor.', N'51188', 1, CAST(N'2023-02-27T00:00:00' AS SmallDateTime), CAST(N'2023-01-28T00:00:00' AS SmallDateTime), N'ccasswell11', N'eband11')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (239, 0, N'Declined', N'Aenean fermentum.', N'51188', 1, CAST(N'2023-07-14T00:00:00' AS SmallDateTime), CAST(N'2023-02-15T00:00:00' AS SmallDateTime), N'lcockle12', N'eyedy12')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (240, 0, N'Approved', N'Nulla tempus. Vivamus in felis eu sapien cursus vestibulum. Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy.', N'51188', 1, CAST(N'2023-02-16T00:00:00' AS SmallDateTime), CAST(N'2023-03-23T00:00:00' AS SmallDateTime), N'rlennox13', N'zrealph13')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (241, 1, N'Pending', N'Vestibulum quam sapien, varius ut, blandit non, interdum in, ante. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio. Curabitur convallis. Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor.', N'51188', 1, CAST(N'2022-09-23T00:00:00' AS SmallDateTime), CAST(N'2023-03-30T00:00:00' AS SmallDateTime), N'atremollet14', N'sgiacobillo14')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (242, 0, N'Declined', N'Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis. Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh. In quis justo. Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet. Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo.', N'51188', 1, CAST(N'2022-10-20T00:00:00' AS SmallDateTime), CAST(N'2023-01-11T00:00:00' AS SmallDateTime), N'btenman15', N'ncamacho15')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (243, 0, N'Approved', N'Ut at dolor quis odio consequat varius. Integer ac leo. Pellentesque ultrices mattis odio. Donec vitae nisi. Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus. Curabitur at ipsum ac tellus semper interdum. Mauris ullamcorper purus sit amet nulla.', N'51188', 1, CAST(N'2022-10-22T00:00:00' AS SmallDateTime), CAST(N'2023-07-20T00:00:00' AS SmallDateTime), N'eadamini16', N'awedmore16')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (244, 0, N'Pending', N'Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus. Phasellus in felis. Donec semper sapien a libero. Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis.', N'51188', 1, CAST(N'2023-01-15T00:00:00' AS SmallDateTime), CAST(N'2022-11-06T00:00:00' AS SmallDateTime), N'iambroix17', N'leitter17')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (245, 0, N'Pending', N'Sed accumsan felis. Ut at dolor quis odio consequat varius. Integer ac leo. Pellentesque ultrices mattis odio. Donec vitae nisi. Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus.', N'51188', 1, CAST(N'2023-03-09T00:00:00' AS SmallDateTime), CAST(N'2023-01-24T00:00:00' AS SmallDateTime), N'fsidworth18', N'vferrandez18')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (246, 1, N'Pending', N'Quisque ut erat. Curabitur gravida nisi at nibh. In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat.', N'51188', 1, CAST(N'2023-03-19T00:00:00' AS SmallDateTime), CAST(N'2023-04-12T00:00:00' AS SmallDateTime), N'wcheevers19', N'mmontel19')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (247, 0, N'Approved', N'Vivamus tortor.', N'51188', 1, CAST(N'2022-09-21T00:00:00' AS SmallDateTime), CAST(N'2023-01-14T00:00:00' AS SmallDateTime), N'arozenbaum1a', N'ajakoviljevic1a')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (248, 1, N'Pending', N'Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante. Nulla justo.', N'51188', 1, CAST(N'2023-07-12T00:00:00' AS SmallDateTime), CAST(N'2022-10-18T00:00:00' AS SmallDateTime), N'smountford1b', N'bspeed1b')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (249, 0, N'Approved', N'Quisque porta volutpat erat. Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus. Phasellus in felis. Donec semper sapien a libero. Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla.', N'51188', 1, CAST(N'2023-09-17T00:00:00' AS SmallDateTime), CAST(N'2023-07-24T00:00:00' AS SmallDateTime), N'kbarz1c', N'cvicar1c')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (250, 1, N'Declined', N'Aliquam erat volutpat. In congue. Etiam justo. Etiam pretium iaculis justo. In hac habitasse platea dictumst.', N'51188', 1, CAST(N'2022-09-29T00:00:00' AS SmallDateTime), CAST(N'2023-07-24T00:00:00' AS SmallDateTime), N'spigne1d', N'relcom1d')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (251, 1, N'Pending', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin interdum mauris non ligula pellentesque ultrices. Phasellus id sapien in sapien iaculis congue. Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl. Aenean lectus. Pellentesque eget nunc.', N'51188', 1, CAST(N'2023-06-29T00:00:00' AS SmallDateTime), CAST(N'2022-12-20T00:00:00' AS SmallDateTime), N'traithbie1e', N'abordiss1e')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (252, 1, N'Approved', N'Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue. Aliquam erat volutpat. In congue. Etiam justo. Etiam pretium iaculis justo. In hac habitasse platea dictumst. Etiam faucibus cursus urna. Ut tellus. Nulla ut erat id mauris vulputate elementum. Nullam varius.', N'51188', 1, CAST(N'2022-09-19T00:00:00' AS SmallDateTime), CAST(N'2023-08-04T00:00:00' AS SmallDateTime), N'gcrofts1f', N'msomerled1f')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (253, 0, N'Declined', N'Aliquam erat volutpat. In congue. Etiam justo. Etiam pretium iaculis justo. In hac habitasse platea dictumst. Etiam faucibus cursus urna.', N'51188', 1, CAST(N'2023-06-11T00:00:00' AS SmallDateTime), CAST(N'2023-08-08T00:00:00' AS SmallDateTime), N'bbtham1g', N'avinas1g')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (254, 1, N'Pending', N'Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis. Ut at dolor quis odio consequat varius. Integer ac leo. Pellentesque ultrices mattis odio. Donec vitae nisi. Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus.', N'51188', 1, CAST(N'2023-02-13T00:00:00' AS SmallDateTime), CAST(N'2022-12-22T00:00:00' AS SmallDateTime), N'pwillison1h', N'fwyllis1h')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (255, 1, N'Declined', N'Integer ac neque. Duis bibendum. Morbi non quam nec dui luctus rutrum. Nulla tellus. In sagittis dui vel nisl. Duis ac nibh. Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus. Suspendisse potenti. In eleifend quam a odio. In hac habitasse platea dictumst.', N'51188', 1, CAST(N'2023-07-02T00:00:00' AS SmallDateTime), CAST(N'2023-01-14T00:00:00' AS SmallDateTime), N'gtuther1i', N'mhalden1i')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (256, 0, N'Pending', N'Suspendisse potenti. Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum. Aliquam non mauris. Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis. Fusce posuere felis sed lacus.', N'51188', 1, CAST(N'2023-05-31T00:00:00' AS SmallDateTime), CAST(N'2023-07-10T00:00:00' AS SmallDateTime), N'lgrealey1j', N'jfoxley1j')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (257, 1, N'Declined', N'In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy. Integer non velit. Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque. Duis bibendum.', N'51188', 1, CAST(N'2023-04-01T00:00:00' AS SmallDateTime), CAST(N'2022-11-20T00:00:00' AS SmallDateTime), N'dmacmakin1k', N'ewharby1k')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (258, 0, N'Approved', N'Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis. Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl. Nunc rhoncus dui vel sem. Sed sagittis. Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus. Pellentesque at nulla.', N'51188', 1, CAST(N'2023-08-01T00:00:00' AS SmallDateTime), CAST(N'2023-07-21T00:00:00' AS SmallDateTime), N'csyder1l', N'otolan1l')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (259, 1, N'Pending', N'Praesent blandit.', N'51188', 1, CAST(N'2023-06-18T00:00:00' AS SmallDateTime), CAST(N'2023-03-17T00:00:00' AS SmallDateTime), N'ncrum1m', N'pcallendar1m')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (260, 1, N'Pending', N'Mauris sit amet eros. Suspendisse accumsan tortor quis turpis. Sed ante. Vivamus tortor. Duis mattis egestas metus. Aenean fermentum. Donec ut mauris eget massa tempor convallis. Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh. Quisque id justo sit amet sapien dignissim vestibulum.', N'51188', 1, CAST(N'2023-06-20T00:00:00' AS SmallDateTime), CAST(N'2023-06-03T00:00:00' AS SmallDateTime), N'ascathard1n', N'ccastanone1n')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (261, 0, N'Declined', N'Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui. Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti.', N'51188', 1, CAST(N'2023-07-12T00:00:00' AS SmallDateTime), CAST(N'2023-07-18T00:00:00' AS SmallDateTime), N'ldannohl1o', N'mtabourin1o')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (262, 1, N'Pending', N'Vivamus vestibulum sagittis sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Etiam vel augue. Vestibulum rutrum rutrum neque.', N'51188', 1, CAST(N'2023-07-24T00:00:00' AS SmallDateTime), CAST(N'2023-04-24T00:00:00' AS SmallDateTime), N'swooderson1p', N'btildesley1p')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (263, 0, N'Pending', N'Sed accumsan felis. Ut at dolor quis odio consequat varius. Integer ac leo. Pellentesque ultrices mattis odio. Donec vitae nisi. Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus.', N'51188', 1, CAST(N'2022-10-10T00:00:00' AS SmallDateTime), CAST(N'2023-07-08T00:00:00' AS SmallDateTime), N'mhuerta1q', N'ndunleavy1q')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (264, 1, N'Declined', N'Quisque ut erat. Curabitur gravida nisi at nibh. In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat.', N'51188', 1, CAST(N'2023-01-28T00:00:00' AS SmallDateTime), CAST(N'2022-11-10T00:00:00' AS SmallDateTime), N'cmeneyer1r', N'lgiorgini1r')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (265, 1, N'Declined', N'Nulla suscipit ligula in lacus. Curabitur at ipsum ac tellus semper interdum. Mauris ullamcorper purus sit amet nulla.', N'51188', 1, CAST(N'2023-04-29T00:00:00' AS SmallDateTime), CAST(N'2023-03-19T00:00:00' AS SmallDateTime), N'ggelly1s', N'rkeam1s')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (266, 0, N'Declined', N'In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat.', N'51188', 1, CAST(N'2023-03-10T00:00:00' AS SmallDateTime), CAST(N'2023-01-22T00:00:00' AS SmallDateTime), N'fchapiro1t', N'gthomtson1t')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (267, 1, N'Pending', N'Aenean sit amet justo. Morbi ut odio. Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo. In blandit ultrices enim.', N'51188', 1, CAST(N'2023-01-15T00:00:00' AS SmallDateTime), CAST(N'2023-04-18T00:00:00' AS SmallDateTime), N'mblaschek1u', N'gaitkenhead1u')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (268, 1, N'Approved', N'Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor.', N'51188', 1, CAST(N'2023-02-04T00:00:00' AS SmallDateTime), CAST(N'2023-01-18T00:00:00' AS SmallDateTime), N'alerwell1v', N'mspindler1v')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (269, 1, N'Declined', N'Nulla justo. Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros. Suspendisse accumsan tortor quis turpis.', N'51188', 1, CAST(N'2023-05-19T00:00:00' AS SmallDateTime), CAST(N'2023-07-02T00:00:00' AS SmallDateTime), N'bpadrick1w', N'jsisley1w')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (270, 1, N'Pending', N'Quisque porta volutpat erat.', N'51188', 1, CAST(N'2022-10-25T00:00:00' AS SmallDateTime), CAST(N'2023-04-09T00:00:00' AS SmallDateTime), N'gkumar1x', N'gmellonby1x')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (271, 1, N'Pending', N'Nulla facilisi. Cras non velit nec nisi vulputate nonummy. Maecenas tincidunt lacus at velit. Vivamus vel nulla eget eros elementum pellentesque. Quisque porta volutpat erat. Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus. Phasellus in felis. Donec semper sapien a libero. Nam dui.', N'51188', 1, CAST(N'2022-09-26T00:00:00' AS SmallDateTime), CAST(N'2022-09-21T00:00:00' AS SmallDateTime), N'pmuscat1y', N'bwhettleton1y')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (272, 0, N'Approved', N'Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis. Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl. Nunc rhoncus dui vel sem. Sed sagittis. Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus.', N'51188', 1, CAST(N'2023-09-04T00:00:00' AS SmallDateTime), CAST(N'2022-11-13T00:00:00' AS SmallDateTime), N'rneicho1z', N'egoodayle1z')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (273, 1, N'Pending', N'Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est. Phasellus sit amet erat. Nulla tempus.', N'51188', 1, CAST(N'2023-06-05T00:00:00' AS SmallDateTime), CAST(N'2023-06-10T00:00:00' AS SmallDateTime), N'lbullocke20', N'pingraham20')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (274, 0, N'Pending', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin interdum mauris non ligula pellentesque ultrices. Phasellus id sapien in sapien iaculis congue. Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl. Aenean lectus. Pellentesque eget nunc. Donec quis orci eget orci vehicula condimentum.', N'51188', 1, CAST(N'2023-08-20T00:00:00' AS SmallDateTime), CAST(N'2023-04-17T00:00:00' AS SmallDateTime), N'dwoods21', N'acruise21')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (275, 0, N'Pending', N'Curabitur gravida nisi at nibh. In hac habitasse platea dictumst.', N'51188', 1, CAST(N'2023-06-15T00:00:00' AS SmallDateTime), CAST(N'2023-09-09T00:00:00' AS SmallDateTime), N'cblazeby22', N'cmaccahey22')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (276, 0, N'Approved', N'Phasellus sit amet erat. Nulla tempus. Vivamus in felis eu sapien cursus vestibulum. Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc.', N'51188', 1, CAST(N'2023-09-09T00:00:00' AS SmallDateTime), CAST(N'2022-11-14T00:00:00' AS SmallDateTime), N'jdjurdjevic23', N'dcoppens23')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (277, 1, N'Approved', N'Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti. Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum. Aliquam non mauris.', N'51188', 1, CAST(N'2023-01-17T00:00:00' AS SmallDateTime), CAST(N'2023-07-25T00:00:00' AS SmallDateTime), N'hmccudden24', N'gayres24')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (278, 0, N'Pending', N'Nulla nisl. Nunc nisl. Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa.', N'51188', 1, CAST(N'2023-04-29T00:00:00' AS SmallDateTime), CAST(N'2023-09-02T00:00:00' AS SmallDateTime), N'wreuter25', N'chundey25')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (279, 1, N'Declined', N'Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat. Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede.', N'51188', 1, CAST(N'2023-08-17T00:00:00' AS SmallDateTime), CAST(N'2022-12-30T00:00:00' AS SmallDateTime), N'cpeterson26', N'klaw26')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (280, 1, N'Declined', N'Donec quis orci eget orci vehicula condimentum. Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est. Phasellus sit amet erat. Nulla tempus.', N'51188', 1, CAST(N'2023-03-02T00:00:00' AS SmallDateTime), CAST(N'2023-01-26T00:00:00' AS SmallDateTime), N'jchrishop27', N'cpavic27')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (281, 0, N'Approved', N'Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat. Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede. Morbi porttitor lorem id ligula.', N'51188', 1, CAST(N'2023-06-30T00:00:00' AS SmallDateTime), CAST(N'2022-12-12T00:00:00' AS SmallDateTime), N'hkohter28', N'kborne28')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (282, 0, N'Declined', N'Curabitur gravida nisi at nibh. In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat. Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede. Morbi porttitor lorem id ligula.', N'51188', 1, CAST(N'2023-05-05T00:00:00' AS SmallDateTime), CAST(N'2023-03-07T00:00:00' AS SmallDateTime), N'bsandells29', N'fdaniely29')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (283, 0, N'Approved', N'Integer a nibh.', N'51188', 1, CAST(N'2022-12-16T00:00:00' AS SmallDateTime), CAST(N'2023-02-03T00:00:00' AS SmallDateTime), N'hnewband2a', N'gplumley2a')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (284, 0, N'Pending', N'In congue. Etiam justo. Etiam pretium iaculis justo. In hac habitasse platea dictumst. Etiam faucibus cursus urna.', N'51188', 1, CAST(N'2023-04-25T00:00:00' AS SmallDateTime), CAST(N'2023-01-01T00:00:00' AS SmallDateTime), N'rhartburn2b', N'uwyant2b')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (285, 1, N'Pending', N'Integer non velit. Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque. Duis bibendum. Morbi non quam nec dui luctus rutrum. Nulla tellus. In sagittis dui vel nisl. Duis ac nibh.', N'51188', 1, CAST(N'2023-04-17T00:00:00' AS SmallDateTime), CAST(N'2023-04-08T00:00:00' AS SmallDateTime), N'cnoe2c', N'lhamlin2c')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (286, 1, N'Pending', N'Nulla facilisi.', N'51188', 1, CAST(N'2022-11-30T00:00:00' AS SmallDateTime), CAST(N'2022-09-27T00:00:00' AS SmallDateTime), N'gtrebble2d', N'bpaliser2d')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (287, 1, N'Declined', N'Suspendisse potenti. Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum.', N'51188', 1, CAST(N'2023-01-14T00:00:00' AS SmallDateTime), CAST(N'2023-03-10T00:00:00' AS SmallDateTime), N'cellwand2e', N'neam2e')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (288, 1, N'Pending', N'Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh. In quis justo. Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet. Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam.', N'51188', 1, CAST(N'2023-01-04T00:00:00' AS SmallDateTime), CAST(N'2022-10-02T00:00:00' AS SmallDateTime), N'preeday2f', N'ggillcrist2f')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (289, 0, N'Declined', N'Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh.', N'51188', 1, CAST(N'2023-09-06T00:00:00' AS SmallDateTime), CAST(N'2023-09-01T00:00:00' AS SmallDateTime), N'sdeere2g', N'wabadam2g')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (290, 0, N'Declined', N'Nulla nisl. Nunc nisl. Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus.', N'51188', 1, CAST(N'2022-10-27T00:00:00' AS SmallDateTime), CAST(N'2022-09-20T00:00:00' AS SmallDateTime), N'ppitceathly2h', N'kpaumier2h')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (291, 1, N'Approved', N'Nulla justo. Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros. Suspendisse accumsan tortor quis turpis. Sed ante.', N'51188', 1, CAST(N'2023-01-23T00:00:00' AS SmallDateTime), CAST(N'2022-10-25T00:00:00' AS SmallDateTime), N'crounds2i', N'hatwill2i')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (292, 0, N'Declined', N'In est risus, auctor sed, tristique in, tempus sit amet, sem. Fusce consequat. Nulla nisl. Nunc nisl. Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus. Duis at velit eu est congue elementum.', N'51188', 1, CAST(N'2023-05-04T00:00:00' AS SmallDateTime), CAST(N'2022-10-27T00:00:00' AS SmallDateTime), N'asymper2j', N'gschindler2j')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (293, 1, N'Pending', N'Phasellus id sapien in sapien iaculis congue. Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl. Aenean lectus.', N'51188', 1, CAST(N'2023-02-23T00:00:00' AS SmallDateTime), CAST(N'2023-07-18T00:00:00' AS SmallDateTime), N'jstallard2k', N'msheaber2k')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (294, 1, N'Declined', N'Etiam vel augue. Vestibulum rutrum rutrum neque. Aenean auctor gravida sem. Praesent id massa id nisl venenatis lacinia. Aenean sit amet justo.', N'51188', 1, CAST(N'2022-10-27T00:00:00' AS SmallDateTime), CAST(N'2023-08-22T00:00:00' AS SmallDateTime), N'klemarquis2l', N'hgrewer2l')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (295, 0, N'Approved', N'Praesent id massa id nisl venenatis lacinia. Aenean sit amet justo. Morbi ut odio. Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo. In blandit ultrices enim. Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin interdum mauris non ligula pellentesque ultrices. Phasellus id sapien in sapien iaculis congue.', N'51188', 1, CAST(N'2022-11-24T00:00:00' AS SmallDateTime), CAST(N'2023-06-24T00:00:00' AS SmallDateTime), N'abamborough2m', N'epaske2m')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (296, 1, N'Pending', N'Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis. Fusce posuere felis sed lacus.', N'51188', 1, CAST(N'2022-11-23T00:00:00' AS SmallDateTime), CAST(N'2023-05-13T00:00:00' AS SmallDateTime), N'scotter2n', N'dmacconnechie2n')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (297, 1, N'Declined', N'Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis. Ut at dolor quis odio consequat varius. Integer ac leo. Pellentesque ultrices mattis odio. Donec vitae nisi. Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus.', N'51188', 1, CAST(N'2023-01-25T00:00:00' AS SmallDateTime), CAST(N'2022-12-12T00:00:00' AS SmallDateTime), N'hmottram2o', N'ncottesford2o')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (298, 1, N'Approved', N'Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus. Suspendisse potenti. In eleifend quam a odio.', N'51188', 1, CAST(N'2023-05-26T00:00:00' AS SmallDateTime), CAST(N'2023-07-06T00:00:00' AS SmallDateTime), N'smessitt2p', N'kjohnsee2p')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (299, 0, N'Pending', N'Cras in purus eu magna vulputate luctus. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vivamus vestibulum sagittis sapien.', N'51188', 1, CAST(N'2023-07-12T00:00:00' AS SmallDateTime), CAST(N'2023-08-29T00:00:00' AS SmallDateTime), N'aeldershaw2q', N'lechalie2q')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (300, 1, N'Declined', N'Etiam pretium iaculis justo. In hac habitasse platea dictumst. Etiam faucibus cursus urna. Ut tellus. Nulla ut erat id mauris vulputate elementum. Nullam varius. Nulla facilisi. Cras non velit nec nisi vulputate nonummy. Maecenas tincidunt lacus at velit.', N'51188', 1, CAST(N'2023-06-20T00:00:00' AS SmallDateTime), CAST(N'2023-07-23T00:00:00' AS SmallDateTime), N'bkatte2r', N'gcamel2r')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (302, 1, N'Pending', NULL, N'51188', 1, CAST(N'2023-09-20T20:17:00' AS SmallDateTime), NULL, N'procurement_manager', NULL)
GO
SET IDENTITY_INSERT [dbo].[Request] OFF
GO
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (202, N'51678', N'Finance Reviewer', 1, N'Basic', N'Approved', N'sem mauris laoreet ut rhoncus aliquet pulvinar sed nisl nunc rhoncus dui vel sem sed', CAST(N'2022-11-22T00:00:00' AS SmallDateTime), CAST(N'2023-03-09T00:00:00' AS SmallDateTime), N'abamford15', N'dmainland15', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (211, N'51678', N'Finance Reviewer', 1, N'Basic', N'Approved', N'aliquam augue quam sollicitudin vitae consectetuer eget rutrum at lorem integer tincidunt ante vel ipsum praesent blandit lacinia', CAST(N'2022-11-09T00:00:00' AS SmallDateTime), CAST(N'2023-07-31T00:00:00' AS SmallDateTime), N'gmcilenna14', N'nhaycroft14', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (212, N'51678', N'Finance Reviewer', 1, N'Basic', N'Approved', N'diam id ornare imperdiet sapien urna pretium nisl ut volutpat sapien arcu sed augue aliquam', CAST(N'2022-10-16T00:00:00' AS SmallDateTime), CAST(N'2022-10-14T00:00:00' AS SmallDateTime), N'ltimoney1b', N'pgentle1b', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (213, N'51678', N'Finance Reviewer', 1, N'Basic', N'Pending', N'semper sapien a libero nam dui proin leo odio porttitor id consequat in consequat ut nulla sed accumsan', CAST(N'2022-10-20T00:00:00' AS SmallDateTime), CAST(N'2022-12-07T00:00:00' AS SmallDateTime), N'sseathwrightf', N'amaydwayf', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (215, N'51678', N'Finance Reviewer', 1, N'Basic', N'Declined', N'sem duis aliquam convallis nunc proin at turpis a pede posuere nonummy integer non', CAST(N'2023-03-28T00:00:00' AS SmallDateTime), CAST(N'2022-12-20T00:00:00' AS SmallDateTime), N'vcrokere', N'cvilese', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (216, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'nulla facilisi cras non velit nec nisi vulputate nonummy maecenas tincidunt', CAST(N'2023-03-31T00:00:00' AS SmallDateTime), CAST(N'2023-04-11T00:00:00' AS SmallDateTime), N'tballp', N'efilshinp', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (217, N'51678', N'Finance Reviewer', 1, N'Basic', N'Approved', N'velit id pretium iaculis diam erat fermentum justo nec condimentum neque sapien placerat ante nulla justo aliquam quis', CAST(N'2022-09-30T00:00:00' AS SmallDateTime), CAST(N'2022-11-02T00:00:00' AS SmallDateTime), N'jwhorall1k', N'smcwhannel1k', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (218, N'51124', N'Finance Reviewer', 1, N'Basic', N'Pending', N'nibh fusce lacus purus aliquet at feugiat non pretium quis lectus suspendisse', CAST(N'2023-04-05T00:00:00' AS SmallDateTime), CAST(N'2023-07-07T00:00:00' AS SmallDateTime), N'bmcmakin1b', N'kroblou1b', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (221, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'amet cursus id turpis integer aliquet massa id lobortis convallis tortor risus', CAST(N'2023-03-11T00:00:00' AS SmallDateTime), CAST(N'2023-09-04T00:00:00' AS SmallDateTime), N'cdumbellow8', N'acallcott8', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (223, N'51124', N'Finance Reviewer', 1, N'Basic', N'Pending', N'tortor sollicitudin mi sit amet lobortis sapien sapien non mi integer ac neque duis bibendum morbi non quam nec dui', CAST(N'2023-04-17T00:00:00' AS SmallDateTime), CAST(N'2023-07-01T00:00:00' AS SmallDateTime), N'mshemmansb', N'cgoardb', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (226, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'dapibus nulla suscipit ligula in lacus curabitur at ipsum ac tellus', CAST(N'2023-04-26T00:00:00' AS SmallDateTime), CAST(N'2023-04-20T00:00:00' AS SmallDateTime), N'akehir1x', N'mmardall1x', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (230, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'donec pharetra magna vestibulum aliquet ultrices erat tortor sollicitudin mi sit amet', CAST(N'2023-01-03T00:00:00' AS SmallDateTime), CAST(N'2023-01-03T00:00:00' AS SmallDateTime), N'gcastelinj', N'bmallabundj', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (231, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'amet consectetuer adipiscing elit proin interdum mauris non ligula pellentesque ultrices phasellus id sapien in sapien', CAST(N'2023-08-28T00:00:00' AS SmallDateTime), CAST(N'2023-05-19T00:00:00' AS SmallDateTime), N'naspinal4', N'lyo4', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (232, N'51124', N'Finance Reviewer', 1, N'Basic', N'Approved', N'ridiculus mus etiam vel augue vestibulum rutrum rutrum neque aenean auctor gravida sem', CAST(N'2023-08-25T00:00:00' AS SmallDateTime), CAST(N'2023-05-23T00:00:00' AS SmallDateTime), N'iwarhurst1g', N'direland1g', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (235, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'ut ultrices vel augue vestibulum ante ipsum primis in faucibus orci luctus', CAST(N'2023-01-06T00:00:00' AS SmallDateTime), CAST(N'2023-08-07T00:00:00' AS SmallDateTime), N'gblaydon2e', N'ladami2e', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (236, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'pretium nisl ut volutpat sapien arcu sed augue aliquam erat volutpat in congue etiam justo etiam pretium', CAST(N'2023-07-21T00:00:00' AS SmallDateTime), CAST(N'2023-06-03T00:00:00' AS SmallDateTime), N'gjahnke1o', N'hvidler1o', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (237, N'51124', N'Finance Reviewer', 1, N'Basic', N'Approved', N'eget rutrum at lorem integer tincidunt ante vel ipsum praesent blandit lacinia erat vestibulum sed magna at', CAST(N'2023-04-18T00:00:00' AS SmallDateTime), CAST(N'2023-01-08T00:00:00' AS SmallDateTime), N'ahasluma', N'palloma', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (238, N'51124', N'Finance Reviewer', 1, N'Basic', N'Approved', N'nulla nisl nunc nisl duis bibendum felis sed interdum venenatis turpis enim blandit mi in', CAST(N'2022-10-02T00:00:00' AS SmallDateTime), CAST(N'2023-07-11T00:00:00' AS SmallDateTime), N'rleggana', N'tgoodbairna', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (239, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'nulla ac enim in tempor turpis nec euismod scelerisque quam turpis adipiscing lorem vitae mattis nibh ligula', CAST(N'2023-04-27T00:00:00' AS SmallDateTime), CAST(N'2023-01-09T00:00:00' AS SmallDateTime), N'lvannet10', N'aneames10', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (241, N'51124', N'Finance Reviewer', 1, N'Basic', N'Pending', N'feugiat non pretium quis lectus suspendisse potenti in eleifend quam a odio in hac habitasse platea', CAST(N'2022-10-22T00:00:00' AS SmallDateTime), CAST(N'2022-12-01T00:00:00' AS SmallDateTime), N'fnickels1p', N'eskullet1p', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (246, N'51124', N'Finance Reviewer', 1, N'Basic', N'Pending', N'duis faucibus accumsan odio curabitur convallis duis consequat dui nec nisi volutpat eleifend donec ut dolor morbi vel', CAST(N'2023-01-11T00:00:00' AS SmallDateTime), CAST(N'2022-11-27T00:00:00' AS SmallDateTime), N'sgronallerq', N'agrenshieldsq', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (247, N'51124', N'Finance Reviewer', 1, N'Basic', N'Pending', N'pulvinar nulla pede ullamcorper augue a suscipit nulla elit ac nulla', CAST(N'2022-11-05T00:00:00' AS SmallDateTime), CAST(N'2023-02-12T00:00:00' AS SmallDateTime), N'ngotter1f', N'cmcgrill1f', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (249, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'viverra diam vitae quam suspendisse potenti nullam porttitor lacus at turpis donec posuere metus vitae ipsum aliquam', CAST(N'2023-06-16T00:00:00' AS SmallDateTime), CAST(N'2022-11-02T00:00:00' AS SmallDateTime), N'smcghee3', N'aridgley3', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (251, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'metus arcu adipiscing molestie hendrerit at vulputate vitae nisl aenean lectus pellentesque', CAST(N'2023-03-13T00:00:00' AS SmallDateTime), CAST(N'2023-02-28T00:00:00' AS SmallDateTime), N'calban9', N'ntuson9', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (252, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'nunc proin at turpis a pede posuere nonummy integer non velit donec diam', CAST(N'2023-02-26T00:00:00' AS SmallDateTime), CAST(N'2023-04-21T00:00:00' AS SmallDateTime), N'mmitchesont', N'hradket', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (253, N'51124', N'Finance Reviewer', 1, N'Basic', N'Approved', N'primis in faucibus orci luctus et ultrices posuere cubilia curae nulla dapibus dolor vel est donec odio', CAST(N'2022-12-27T00:00:00' AS SmallDateTime), CAST(N'2023-01-12T00:00:00' AS SmallDateTime), N'agilhouley14', N'acarrabott14', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (255, N'51124', N'Finance Reviewer', 1, N'Basic', N'Approved', N'parturient montes nascetur ridiculus mus vivamus vestibulum sagittis sapien cum sociis natoque penatibus et', CAST(N'2022-12-21T00:00:00' AS SmallDateTime), CAST(N'2022-11-06T00:00:00' AS SmallDateTime), N'smcgivenk', N'zmokesk', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (256, N'51124', N'Finance Reviewer', 1, N'Basic', N'Pending', N'tempor turpis nec euismod scelerisque quam turpis adipiscing lorem vitae mattis nibh ligula nec sem', CAST(N'2022-09-26T00:00:00' AS SmallDateTime), CAST(N'2023-09-05T00:00:00' AS SmallDateTime), N'bwanstall17', N'mpuddle17', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (257, N'51124', N'Finance Reviewer', 1, N'Basic', N'Pending', N'leo pellentesque ultrices mattis odio donec vitae nisi nam ultrices libero non mattis pulvinar nulla pede ullamcorper', CAST(N'2023-05-23T00:00:00' AS SmallDateTime), CAST(N'2023-04-30T00:00:00' AS SmallDateTime), N'rgooday16', N'kcawsby16', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (260, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'posuere cubilia curae nulla dapibus dolor vel est donec odio justo sollicitudin ut suscipit a feugiat et', CAST(N'2023-08-28T00:00:00' AS SmallDateTime), CAST(N'2023-02-02T00:00:00' AS SmallDateTime), N'erobiot15', N'aquest15', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (264, N'51124', N'Finance Reviewer', 1, N'Basic', N'Pending', N'vestibulum velit id pretium iaculis diam erat fermentum justo nec condimentum neque sapien placerat ante nulla justo', CAST(N'2023-01-29T00:00:00' AS SmallDateTime), CAST(N'2023-08-22T00:00:00' AS SmallDateTime), N'bwortman2n', N'scuppitt2n', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (267, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'est congue elementum in hac habitasse platea dictumst morbi vestibulum velit', CAST(N'2023-08-22T00:00:00' AS SmallDateTime), CAST(N'2023-07-11T00:00:00' AS SmallDateTime), N'clindstroms', N'mschruurss', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (268, N'51124', N'Finance Reviewer', 1, N'Basic', N'Pending', N'et ultrices posuere cubilia curae nulla dapibus dolor vel est donec odio justo sollicitudin', CAST(N'2023-06-08T00:00:00' AS SmallDateTime), CAST(N'2023-06-10T00:00:00' AS SmallDateTime), N'kmatusov1q', N'lbiddlecombe1q', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (269, N'51124', N'Finance Reviewer', 1, N'Basic', N'Pending', N'hendrerit at vulputate vitae nisl aenean lectus pellentesque eget nunc donec quis orci eget', CAST(N'2022-10-26T00:00:00' AS SmallDateTime), CAST(N'2023-06-30T00:00:00' AS SmallDateTime), N'gdearsleyx', N'tgramerx', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (275, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'in faucibus orci luctus et ultrices posuere cubilia curae mauris viverra diam vitae quam suspendisse potenti nullam porttitor', CAST(N'2023-08-20T00:00:00' AS SmallDateTime), CAST(N'2023-02-16T00:00:00' AS SmallDateTime), N'lsurridge2b', N'rmacmeekan2b', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (276, N'51124', N'Finance Reviewer', 1, N'Basic', N'Approved', N'nulla nisl nunc nisl duis bibendum felis sed interdum venenatis turpis enim blandit mi in porttitor pede', CAST(N'2023-06-25T00:00:00' AS SmallDateTime), CAST(N'2023-04-01T00:00:00' AS SmallDateTime), N'coleszczak11', N'mwhitehouse11', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (279, N'51124', N'Finance Reviewer', 1, N'Basic', N'Approved', N'libero ut massa volutpat convallis morbi odio odio elementum eu interdum eu tincidunt in leo maecenas pulvinar lobortis est', CAST(N'2023-05-14T00:00:00' AS SmallDateTime), CAST(N'2023-04-16T00:00:00' AS SmallDateTime), N'aheinsius18', N'pcade18', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (280, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'donec pharetra magna vestibulum aliquet ultrices erat tortor sollicitudin mi sit amet lobortis sapien sapien non mi integer ac', CAST(N'2023-01-15T00:00:00' AS SmallDateTime), CAST(N'2023-09-06T00:00:00' AS SmallDateTime), N'rvickars24', N'lbartot24', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (281, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'nisi at nibh in hac habitasse platea dictumst aliquam augue quam sollicitudin vitae consectetuer eget rutrum at lorem integer tincidunt', CAST(N'2023-07-16T00:00:00' AS SmallDateTime), CAST(N'2022-10-31T00:00:00' AS SmallDateTime), N'jfigliovannif', N'kfrangletonf', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (283, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'vel accumsan tellus nisi eu orci mauris lacinia sapien quis libero nullam sit amet turpis elementum ligula vehicula consequat', CAST(N'2023-02-18T00:00:00' AS SmallDateTime), CAST(N'2022-12-06T00:00:00' AS SmallDateTime), N'amirrleeso', N'tstillo', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (284, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'donec ut dolor morbi vel lectus in quam fringilla rhoncus mauris enim leo rhoncus sed vestibulum sit', CAST(N'2023-03-30T00:00:00' AS SmallDateTime), CAST(N'2023-01-08T00:00:00' AS SmallDateTime), N'aeteen1l', N'nkeveren1l', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (285, N'51124', N'Finance Reviewer', 1, N'Basic', N'Pending', N'nulla neque libero convallis eget eleifend luctus ultricies eu nibh quisque id', CAST(N'2023-04-26T00:00:00' AS SmallDateTime), CAST(N'2023-06-20T00:00:00' AS SmallDateTime), N'jdanilevichg', N'cbardeg', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (286, N'51124', N'Finance Reviewer', 1, N'Basic', N'Approved', N'id nisl venenatis lacinia aenean sit amet justo morbi ut odio cras mi pede malesuada in imperdiet et commodo', CAST(N'2022-11-14T00:00:00' AS SmallDateTime), CAST(N'2022-10-23T00:00:00' AS SmallDateTime), N'cglencrossn', N'sbyshn', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (287, N'51124', N'Finance Reviewer', 1, N'Basic', N'Pending', N'bibendum felis sed interdum venenatis turpis enim blandit mi in porttitor pede', CAST(N'2023-04-20T00:00:00' AS SmallDateTime), CAST(N'2023-04-14T00:00:00' AS SmallDateTime), N'jboribal6', N'pdanelutti6', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (288, N'51124', N'Finance Reviewer', 1, N'Basic', N'Pending', N'dictumst morbi vestibulum velit id pretium iaculis diam erat fermentum justo nec condimentum neque sapien placerat ante nulla justo', CAST(N'2023-07-13T00:00:00' AS SmallDateTime), CAST(N'2023-06-19T00:00:00' AS SmallDateTime), N'jgammel12', N'rmitford12', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (293, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia', CAST(N'2023-04-19T00:00:00' AS SmallDateTime), CAST(N'2023-02-06T00:00:00' AS SmallDateTime), N'aanersen5', N'cahrens5', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (294, N'51124', N'Finance Reviewer', 1, N'Basic', N'Pending', N'sollicitudin ut suscipit a feugiat et eros vestibulum ac est lacinia nisi venenatis tristique', CAST(N'2022-11-01T00:00:00' AS SmallDateTime), CAST(N'2023-03-14T00:00:00' AS SmallDateTime), N'dcannell6', N'araeside6', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (297, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'odio in hac habitasse platea dictumst maecenas ut massa quis augue luctus tincidunt nulla mollis molestie', CAST(N'2023-08-20T00:00:00' AS SmallDateTime), CAST(N'2023-06-10T00:00:00' AS SmallDateTime), N'mshorthousez', N'gtinstonz', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (297, N'51678', N'Finance Reviewer', 1, N'Basic', N'Declined', N'at feugiat non pretium quis lectus suspendisse potenti in eleifend quam a odio', CAST(N'2022-11-09T00:00:00' AS SmallDateTime), CAST(N'2023-09-07T00:00:00' AS SmallDateTime), N'procurment_manager', N'mshiltonl', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (298, N'51124', N'Finance Reviewer', 1, N'Basic', N'Pending', N'sed vel enim sit amet nunc viverra dapibus nulla suscipit ligula in lacus curabitur', CAST(N'2023-01-17T00:00:00' AS SmallDateTime), CAST(N'2023-03-19T00:00:00' AS SmallDateTime), N'aslevin2r', N'eredler2r', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (299, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'risus semper porta volutpat quam pede lobortis ligula sit amet eleifend pede libero quis orci nullam molestie nibh', CAST(N'2023-06-03T00:00:00' AS SmallDateTime), CAST(N'2022-12-02T00:00:00' AS SmallDateTime), N'bsparsholt1d', N'ballpress1d', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (300, N'51124', N'Finance Reviewer', 1, N'Basic', N'Declined', N'lacinia aenean sit amet justo morbi ut odio cras mi pede malesuada in imperdiet et commodo', CAST(N'2023-03-20T00:00:00' AS SmallDateTime), CAST(N'2023-01-24T00:00:00' AS SmallDateTime), N'ccoffey0', N'bbudget0', NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [ReviewedBy]) VALUES (302, N'51124', N'Finance Reviewer', 1, N'Basic', N'Pending', NULL, CAST(N'2023-09-20T20:17:00' AS SmallDateTime), NULL, NULL, NULL, NULL)
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
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'04cd21f1-113b-477e-a517-7dcb1ea8a024', N'IT', N'IT', N'0cb746df-5bf7-497b-adec-21063f3e42bb')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'120a9027-4229-4379-95ce-b6bfd1333e0c', N'CustomerService', N'CUSTOMERSERVICE', N'9d6e19e1-be12-42b0-bdcd-402fd83e7d74')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'121c1742-99e7-4b61-ab2f-f748876e2975', N'Finance', N'FINANCE', N'47feedcb-d4df-44c5-9584-0da7edac1342')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'1ee5bd21-f548-47f6-918f-2b0b7625ded2', N'Adminstration', N'ADMINSTRATION', N'abd87636-ff1d-4bdc-8960-f45eb4c66a22')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'32044808-6d0e-4e18-be60-0606ae9d51ae', N'Security', N'SECURITY', N'2493c125-eb40-4344-abb8-6c95d270d54e')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'3cb27f9e-80bf-4383-9aa2-e56f7b730b10', N'OperationBGC', N'OPERATIONBGC', N'5ec576a8-fd80-4004-9973-40ff6f834463')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'6826ac7e-b4ae-47ff-8bf6-cc904db43d84', N'Procurement', N'PROCUREMENT', N'90904c3c-9b4a-4f7c-a44d-cc443612bf64')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'7bf924d4-2d36-44b2-9dcd-be12b2593e54', N'InfoFort', N'INFOFORT', N'87164c35-3488-41e9-beb4-eaaa141514d1')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'9580fd22-e5e7-4a6f-a316-30119f8c10fc', N'Engineering', N'ENGINEERING', N'1a2b457b-723e-4958-83f8-d0af4e675b02')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'a4c5c4a0-6b0a-4639-a8eb-95d068413b24', N'SuperAdmin', N'SUPERADMIN', N'19341457-eaf0-481d-96d6-4839778c1f0b')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'be82457f-910a-4e86-b95b-187c5af7980e', N'HR', N'HR', N'48e8b5f1-d719-4224-975d-1ceb0e6d6b96')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'c08d8152-6409-46a2-b515-f5f10528a437', N'Store', N'STORE', N'4225b60a-7de8-4913-8b91-0ded0813743a')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'cbbe579c-cf18-4975-aa7f-9f90d412c30e', N'OperationCT', N'OPERATIONCT', N'41aae6bd-346d-48a9-8ce6-7a7fc1a278ce')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'd220a87b-7988-4e18-a15d-36277033f5e2', N'Commercial', N'COMMERCIAL', N'0301f15f-6cb7-4daa-9c97-eca012b4c10b')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'f6a9fa19-0beb-4c17-8c57-47cc6930d654', N'Communications', N'COMMUNICATIONS', N'18c91c20-b3f3-48b7-b691-d3c1171ffa1e')
GO
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50000', N'stores_manager', N'STORES_MANAGER', N'Ahmed Zaki', N'Head of Stores', 20, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, N'procurment_manager', NULL, N'stores_manager@dpworld.com', N'STORES_MANAGER@DPWORLD.COM', 0, NULL, N'500fe054-0e86-463e-bbd6-d47466f25c88', N'7057db61-830c-4596-b69b-c6bc8970ed64', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50128', N'ops-cfs_sec_head', N'OPS-CFS_SEC_HEAD', N'Ahmed Zaki', N'OPS-CFS Section Head', 14, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, N'procurment_manager', NULL, N'ops-cfs_sec_head@dpworld.com', N'OPS-CFS_SEC_HEAD@DPWORLD.COM', 0, NULL, N'92551c0d-e784-4af0-8c48-eae39669891e', N'e8c7acb1-f048-4761-930c-5db2824dcbb9', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50136', N'engineering_manager', N'ENGINEERING_MANAGER', N'Ahmed Zaki', N'Head of Engineering', 21, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'engineering_manager@dpworld.com', N'ENGINEERING_MANAGER@DPWORLD.COM', 0, NULL, N'725acba7-2920-4872-ac71-e9d929505d69', N'b2742b1a-0a0a-44d7-a530-c09e6ff34a38', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50140', N'hc-ssp_manager', N'HC-SSP_MANAGER', N'Maged Mohsen', N'Head of HC - Samsung SDS project', 11, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'hc-ssp_manager@dpworld.com', N'HC-SSP_MANAGER@DPWORLD.COM', 0, NULL, N'7a03cbae-b683-4ed4-9cfa-900485dce73f', N'2acfdb87-a141-4c70-8822-9e4c4c2ae680', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50141', N'ops-ct_manager', N'OPS-CT_MANAGER', N'Maged Mohsen', N'Head of OPS-Containers', 14, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'ops-ct_manager@dpworld.com', N'OPS-CT_MANAGER@DPWORLD.COM', 0, NULL, N'0a2eb632-37b7-4b64-af17-a74fc00ba438', N'1ef5faca-93c2-427d-b3ec-f0ff99ff6f12', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50263', N'security_manager', N'SECURITY_MANAGER', N'Ahmed Zaki', N'Head of Security', 19, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'security_manager@dpworld.com', N'SECURITY_MANAGER@DPWORLD.COM', 0, NULL, N'4d7eb2f6-67ee-46cc-bf75-cb9871a83cf7', N'bd4f69fe-e624-425f-b7f2-8104e6ef9a15', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50269', N'admin_manager', N'ADMIN_MANAGER', N'Ahmed Zaki', N'Head of Administration', 1, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'admin_manager@dpworld.com', N'ADMIN_MANGER@DPWORLD.COM', 0, NULL, N'64a7acf3-7ec4-4c59-9472-b25a695f6130', N'74e37079-8f2d-4530-9c99-10edbd47f45e', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50279', N'people_manager', N'PEOPLE_MANAGER', N'Waleed Aboelgadayl', N'Head of People', 15, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'people_manager@dpworld.com', N'PEOPLE_MANAGER@DPWORLD.COM', 0, NULL, N'd69f3994-8431-4f11-b2e1-cddb25f73bf6', N'3917822c-1d3c-4107-b23a-80cbff45cbd9', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50354', N'ops-bgc_manager', N'OPS-BGC_MANAGER', N'Mohamed Radwan', N'Head of OPS-Cargo & Bulk', 13, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'ops-bgc_manager@dpworld.com', N'OPS-BGC_MANAGER@DPWORLD.COM', 0, NULL, N'55a5b649-583a-48c1-a85c-c7a5ed9e3b15', N'f20a9305-e0b9-46a8-8bac-34fbad1393f7', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50562', N'tec-planning_sec_head', N'TEC-PLANNING_SEC_HEAD', N'Ahmed Zaki', N'TEC-Planning Section Head', 21, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'tec-planning_sec_head@dpworld.com', N'TEC-PLANNING_SEC_HEAD@DPWORLD.COM', 0, NULL, N'5f984438-89cb-4f01-8613-be7b5e36a6f6', N'a765945d-441f-4a7c-84b9-cea915e45dd2', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50670', N'ops-ct_sec_head', N'OPS-CT_SEC_HEAD', N'Ahmed Zaki', N'OPS-Containers Section Head', 14, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'ops-ct_sec_head@dpworld.com', N'OPS-DRI_SEC_HEAD@DPWORLD.COM', 0, NULL, N'6d1702ee-ad90-450a-a9be-5671cc4c64ed', N'4a0e6dfa-bc00-4bd6-9ac2-f09ae40ee420', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50844', N'ops-dri_sec_head', N'OPS-DRI_SEC_HEAD', N'Ahmed Zaki', N'OPS-DRI Section Head', 13, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'ops-dri_sec_head@dpworld.com', N'OPS-DRI_SEC_HEAD@DPWORLD.COM', 0, NULL, N'fde2a5fc-7352-404f-929c-7cd9821c82f3', N'95762d6e-a05a-4d92-946b-47952b362311', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50882', N'qhse_manager', N'QHSE_MANAGER', N'Hassan Abdelghany', N'Head of QHSE', 18, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'qhse_manager@dpworld.com', N'QHSE_MANAGER@DPWORLD.COM', 0, NULL, N'cae7134a-0f1d-459f-ac3f-c427923c802c', N'0d282c6f-9ba5-4490-8fd2-6848e7458704', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50962', N'gr_manager', N'GR_MANAGER', N'Mohamed Tarek', N'Head of Governmental Relation', 9, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'governmentalrelation_manager@dpworld.com', N'GOVERNMENTALRELATION_MANAGER@DPWORLD.COM', 0, NULL, N'595ed6fc-611f-4e8b-80f5-1f3f0fd5a99e', N'dfb8da9b-286e-4725-9c64-daef1338c28b', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51090', N'tec-crane_sec_head', N'TEC-CRANE_SEC_HEAD', N'Ahmed Zaki', N'TEC-Crane Section Head', 21, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'tec-crane_sec_head@dpworld.com', N'TEC-CRANE_SEC_HEAD@DPWORLD.COM', 0, NULL, N'8d0f9e9e-60c4-48b4-9e47-b719105d8845', N'6c83979b-a34f-4e52-a284-1b59821f53eb', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51124', N'finance_manager', N'FINANCE_MANAGER', N'Mustafa Sultan', N'Head of Finance', 8, NULL, NULL, N'DP World', 1, 1, CAST(N'2023-09-20T19:37:00' AS SmallDateTime), NULL, CAST(N'2023-09-20T19:37:00' AS SmallDateTime), NULL, NULL, N'finance_manager@dpworld.com', N'FINANCE_MANAGER@DPWORLD.COM', 0, NULL, N'288858a7-3ff2-4a0f-9b2e-5838377bc513', N'242fc37f-c9ff-4741-ac90-74e75b539e80', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51126', N'tec-workshop_sec_head', N'TEC-WORKSHOP_SEC_HEAD', N'Ahmed Zaki', N'TEC-Workshop Section Head', 21, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'tec-workshop_sec_head@dpworld.com', N'TEC-WORKSHOP_SEC_HEAD@DPWORLD.COM', 0, NULL, N'4d54e552-8369-4694-8de7-a63b57b06a65', N'9e716c83-8fed-40fe-af90-0ec4283ce707', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51188', N'procurement_manager', N'PROCURMENT_MANAGER', N'Tamer Elsayed', N'Head of Procurment', 16, NULL, NULL, N'DP World', 1, 1, CAST(N'2023-09-20T20:06:00' AS SmallDateTime), NULL, CAST(N'2023-09-20T20:06:00' AS SmallDateTime), NULL, NULL, N'procurement_manager@dpworld.com', N'PROCUREMENT_MANAGER@DPWORLD.COM', 0, NULL, N'ead8308a-7ec2-4e28-932d-537b229f534e', N'a33854ab-2ef1-456f-b16a-36912778c572', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51229', N'cs_manager', N'CS_MANAGER', N'Hassan Nagah', N'Head of Customer Service', 6, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'customerservice_manager@dpworld.com', N'CUSTOMERSERVICE_MANAGER@DPWORLD.COM', 0, NULL, N'ac6f7209-f87f-4016-9239-5026e2b70461', N'4e218080-e7ce-4bcb-ab95-0b33f60cba98', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51330', N'bt_manager', N'BT_MANAGER', N'Alaa Nasr', N'Head of Business Transformation', 3, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'businesstransformation_manager@dpworld.com', N'BUSINESSTRANSFORMATION_MANAGER@DPWORLD.COM', 0, NULL, N'5ccf890f-45a0-45a5-88ff-0c14cf9f4d39', N'b072c0de-583b-456f-aa26-b3c2661cd293', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51331', N'it_manager', N'IT_MANAGER', N'Alaa Nasr', N'Head of IT', 12, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'it_manager@dpworld.com', N'IT_MANAGER@DPWORLD.COM', 0, NULL, N'9ce16585-ac8c-4ad0-a9d8-1bfdf8ac9a50', N'17b62a33-a43e-4e05-8577-7c2396c2f845', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51449', N'ops-cg_sec_head', N'OPS-CG_SEC_HEAD', N'Ahmed Zaki', N'OPS-Cargo & Bulk Section Head', 13, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'ops-cg_sec_head@dpworld.com', N'OPS-CG_SEC_HEAD@DPWORLD.COM', 0, NULL, N'c2d7da93-dae7-4cc4-b9b0-16e869d64222', N'750e4a47-ab86-4964-9049-4a3e65fd5b42', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51509', N'commercial-ct_sec_head', N'COMMERCIAL-CT_SEC_HEAD', N'Ahmed Zaki', N'Commercial / Containers Section Head', 4, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'commercial-ct_sec_head@dpworld.com', N'ECOMMERCIAL-CT_SEC_HEAD@DPWORLD.COM', 0, NULL, N'935eaf88-93e6-46fc-bc77-432549e6d744', N'43dfd3aa-4e41-40f3-874f-06feb53173b0', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51520', N'qhse_sec_head', N'QHSE_SEC_HEAD', N'Ahmed Zaki', N'QHSE Section HEad', 18, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'qhse_sec_head@dpworld.com', N'QHSE_SEC_HEAD@DPWORLD.COM', 0, NULL, N'd6f22573-e647-47eb-9c35-7d0d6a3c70c4', N'2343da26-16b0-419d-9cd6-0acc35042d96', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51529', N'projects_sec_head', N'PROJECTS_SEC_HEAD', N'Ahmed Zaki', N'Projects Section Head', 21, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'projects_sec_head@dpworld.com', N'PROJECTS_SEC_HEAD@DPWORLD.COM', 0, NULL, N'b914de50-caa7-4ed4-9704-488051410ed9', N'9bd590fc-c007-4d5b-a35e-39ba9824be13', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51572', N'hc-ds_manager', N'HC-DS_MANAGER', N'Aliaa Elgammal', N'Head of HC - DUBUY Sales', 10, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'hc-ds_manager@dpworld.com', N'HC-DS_MANAGER@DPWORLD.COM', 0, NULL, N'd3832a9b-a294-4756-ab5c-dd615f0ba0aa', N'45f6f8a9-c549-40b7-bcfd-d6f13633b652', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51573', N'commercial_manager', N'COMMERCIAL_MANAGER', N'Aliaa Elgammal', N'Head of Commercial', 4, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'commercial_manager@dpworld.com', N'COMMERCIAL_MANAGER@DPWORLD.COM', 0, NULL, N'9dc95bb4-1118-46a8-a069-cb8ede790f77', N'1cc946b0-99a1-4e71-be52-9003a0c4e845', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51583', N'commercial-bgc_sec_head', N'COMMERCIAL-BGC_SEC_HEAD', N'Ahmed Zaki', N'CommercialBulk / GC Section Head', 4, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'commercial-bgc_sec_head@dpworld.com', N'ECOMMERCIAL-BGC_SEC_HEAD@DPWORLD.COM', 0, NULL, N'018bb594-a41c-4fc8-b36d-77ac47ea7a4f', N'8e08f500-98c4-4254-ba00-a7d49ff7ef7d', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51659', N'projects_manager', N'PROJECTS_MANAGER', N'Mohamed Mandour', N'Head of Projects & Facility Management', 17, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'projectsfacilitymanager_manager@dpworld.com', N'PROJECTSFACILITYMANAGER_MANAGER@DPWORLD.COM', 0, NULL, N'277b7cb4-a767-400b-967c-6cfe2d27c323', N'780867b0-c1d5-4edb-8a4e-1eff3328299f', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51668', N'communications_manager', N'COMMUNICATIONS_MANAGER', N'Amina Hatem', N'Head of Communications', 5, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'communications_manager@dpworld.com', N'COMMUNICATIONS_MANAGER@DPWORLD.COM', 0, NULL, N'72ae434e-464f-479c-a98e-0afff0b5adec', N'a97172ea-74fc-4827-b41c-69fd188e255b', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51678', N'almuhammad', N'ALMUHAMMAD', N'Alaa Abo Elhassan', N'IT Developer', 12, 13, N'51331', N'DP World', 1, 1, CAST(N'2023-09-20T11:01:00' AS SmallDateTime), CAST(N'2023-09-19T18:31:00' AS SmallDateTime), CAST(N'2023-09-20T11:01:00' AS SmallDateTime), N'finance_manager', NULL, N'almuhammad@dpworld.com', N'ALMUHAMMAD@DPWORLD.COM', 0, N'AQAAAAIAAYagAAAAENlNCka8s1cBdZgMu7YIiiEJ21o1nbT6QmYZKioujApY8WlLrnd3YpHgBfaWpwuvTw==', N'4HP3OHNG5SVVDWA7YBAJSDTXMI7ISQEK', N'5afdb852-7a6e-423b-a932-f4ce471c10ce', N'01896299217', 0, 0, NULL, 1, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'5587', N'test', N'TEST', N'test user', N'string', NULL, NULL, NULL, N'string', 0, 1, NULL, CAST(N'2023-09-18T08:49:00' AS SmallDateTime), CAST(N'2023-09-18T08:59:00' AS SmallDateTime), NULL, NULL, N'test@example.com', N'TEST@EXAMPLE.COM', 0, N'AQAAAAIAAYagAAAAEI8g/2wrzGNKcmcdDIHJ1BYRZt0YkhQv7gv8YxwZKCgWFbpxjRttXTCzvo2j92UUJA==', N'L6Q5LWF6LUJCEBPRVZHFSRSUTT6X6GO4', N'97a04829-0c7b-4c89-8e40-e74b87f3104b', N'01534278431', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'90008', N'hc-ds_sec_head', N'HC-DS_SEC_HEAD', N'Ahmed Zaki', N'HC - DUBUY Sales Section Head', 11, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'hc-ds_sec_head@dpworld.com', N'HC-DS_SEC_HEAD@DPWORLD.COM', 0, NULL, N'4bff1179-bc32-454e-a4a4-c57034cf5ebb', N'353fe721-45ac-4a49-bf9e-6e78af2cc6e9', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'90010', N'ff_manager', N'FF_MANAGER', N'Hanaa Mohamed', N'Head of Freight Forwarding', 2, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'freightforwarding_manager@dpworld.com', N'FREIGHTFORWARDING_MANAGER@DPWORLD.COM', 0, NULL, N'5d852796-b4ea-4318-b2fc-040356e634c8', N'5ded8ac0-c8b6-4cd0-9dee-f061919a8555', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'90015', N'hc-ssp_sec_head', N'HC-SSP_SEC_HEAD', N'Ahmed Zaki', N'HC - Samsung SDS project  Section Head', 10, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'hc-ssp_sec_head@dpworld.com', N'HC-SSP_SEC_HEAD@DPWORLD.COM', 0, NULL, N'0815e486-f572-43ba-880d-9d5b3dca93b0', N'34ad6cf8-816e-4744-8615-e3a9480a012c', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Exp-16', N'em_manager', N'EM_MANAGER', N'Urs Moll', N'Head of Executive Management', 7, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'executivemanagement_manager@dpworld.com', N'EXECUTIVEMANAGEMENT_MANAGER@DPWORLD.COM', 0, NULL, N'532ae757-0407-49d1-9124-08868d52bbe0', N'67bb8c6d-dd86-4f04-ab20-9e9eaac349fe', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'string', N'string', N'STRING', N'string', N'string', NULL, NULL, NULL, N'string', 1, 1, NULL, CAST(N'2023-09-17T15:31:00' AS SmallDateTime), NULL, NULL, NULL, N'user@example.com', N'USER@EXAMPLE.COM', 0, N'AQAAAAIAAYagAAAAEAI5JGyKSLGlfkXRKZ0CbYuAzQUDkbdVPB93/F2kT6wcgWGklsWRUMM5g4QKyVunew==', N'RZNW7Y64POKQ3R56VLG3ZFZERIXNB2JU', N'facdd0ad-0ced-4a22-94e3-91b2c23ff61b', N'01543889566', 0, 0, NULL, 1, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'stringg', N'stringg', N'STRINGG', N'stringg', N'string', NULL, NULL, NULL, N'string', 0, 1, NULL, CAST(N'2023-09-17T15:32:00' AS SmallDateTime), NULL, NULL, NULL, N'usger@example.com', N'USGER@EXAMPLE.COM', 0, N'AQAAAAIAAYagAAAAEOpT/V3Ys0L/7tbjIJTTaCHjtDKnEaaVgyH8LXTh7qPQLU8efHqhMoJIYjkQSCZ0XQ==', N'CARHMI2SCO4TOE67DLEIVD7U4JIFLRBM', N'a318c458-cb44-4f18-982d-f396ef2ba632', N'01543889566', 0, 0, CAST(N'2023-09-24T11:12:08.9021249+00:00' AS DateTimeOffset), 1, 0)
GO
INSERT [security].[UserRoles] ([UserId], [RoleId]) VALUES (N'51124', N'121c1742-99e7-4b61-ab2f-f748876e2975')
INSERT [security].[UserRoles] ([UserId], [RoleId]) VALUES (N'51188', N'6826ac7e-b4ae-47ff-8bf6-cc904db43d84')
GO
/****** Object:  Index [IX_ApplicationItAdmin_ApplicationId]    Script Date: 9/20/2023 8:35:42 PM ******/
CREATE NONCLUSTERED INDEX [IX_ApplicationItAdmin_ApplicationId] ON [dbo].[ApplicationItAdmin]
(
	[ApplicationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ApplicationUserRequest_RequestId]    Script Date: 9/20/2023 8:35:42 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_ApplicationUserRequest_RequestId] ON [dbo].[ApplicationUserRequest]
(
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Attachment_RequestId]    Script Date: 9/20/2023 8:35:42 PM ******/
CREATE NONCLUSTERED INDEX [IX_Attachment_RequestId] ON [dbo].[Attachment]
(
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CarRequest_RequestId]    Script Date: 9/20/2023 8:35:42 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_CarRequest_RequestId] ON [dbo].[CarRequest]
(
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_DefinedApplication_ApplicationOwnerId]    Script Date: 9/20/2023 8:35:42 PM ******/
CREATE NONCLUSTERED INDEX [IX_DefinedApplication_ApplicationOwnerId] ON [dbo].[DefinedApplication]
(
	[ApplicationOwnerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DefinedApplicationRole_RequestedApplicationId]    Script Date: 9/20/2023 8:35:42 PM ******/
CREATE NONCLUSTERED INDEX [IX_DefinedApplicationRole_RequestedApplicationId] ON [dbo].[DefinedApplicationRole]
(
	[RequestedApplicationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DefinedRequest_DepartmentId]    Script Date: 9/20/2023 8:35:42 PM ******/
CREATE NONCLUSTERED INDEX [IX_DefinedRequest_DepartmentId] ON [dbo].[DefinedRequest]
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_DefinedRequestReviewer_AssignedReviewerId]    Script Date: 9/20/2023 8:35:42 PM ******/
CREATE NONCLUSTERED INDEX [IX_DefinedRequestReviewer_AssignedReviewerId] ON [dbo].[DefinedRequestReviewer]
(
	[AssignedReviewerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DefinedRequestRole_DefinedRequestId]    Script Date: 9/20/2023 8:35:42 PM ******/
CREATE NONCLUSTERED INDEX [IX_DefinedRequestRole_DefinedRequestId] ON [dbo].[DefinedRequestRole]
(
	[DefinedRequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Department_ManagerId]    Script Date: 9/20/2023 8:35:42 PM ******/
CREATE NONCLUSTERED INDEX [IX_Department_ManagerId] ON [dbo].[Department]
(
	[ManagerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DomainAccountRequest_RequestId]    Script Date: 9/20/2023 8:35:42 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_DomainAccountRequest_RequestId] ON [dbo].[DomainAccountRequest]
(
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_PoRequest]    Script Date: 9/20/2023 8:35:42 PM ******/
ALTER TABLE [dbo].[PoRequest] ADD  CONSTRAINT [PK_PoRequest] PRIMARY KEY NONCLUSTERED 
(
	[PoNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_PoRequest_InvoiceNumber]    Script Date: 9/20/2023 8:35:42 PM ******/
CREATE NONCLUSTERED INDEX [IX_PoRequest_InvoiceNumber] ON [dbo].[PoRequest]
(
	[InvoiceNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_PoRequest_VendorName]    Script Date: 9/20/2023 8:35:42 PM ******/
CREATE NONCLUSTERED INDEX [IX_PoRequest_VendorName] ON [dbo].[PoRequest]
(
	[VendorName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Request_CreatorId]    Script Date: 9/20/2023 8:35:42 PM ******/
CREATE NONCLUSTERED INDEX [IX_Request_CreatorId] ON [dbo].[Request]
(
	[CreatorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Request_DefinedRequestId]    Script Date: 9/20/2023 8:35:42 PM ******/
CREATE NONCLUSTERED INDEX [IX_Request_DefinedRequestId] ON [dbo].[Request]
(
	[DefinedRequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_RequestApplicationRole_ApplicationId]    Script Date: 9/20/2023 8:35:42 PM ******/
CREATE NONCLUSTERED INDEX [IX_RequestApplicationRole_ApplicationId] ON [dbo].[RequestApplicationRole]
(
	[ApplicationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_RequestApplicationRole_RoleId]    Script Date: 9/20/2023 8:35:42 PM ******/
CREATE NONCLUSTERED INDEX [IX_RequestApplicationRole_RoleId] ON [dbo].[RequestApplicationRole]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_RequestReviewer_AssignedReviewerId]    Script Date: 9/20/2023 8:35:42 PM ******/
CREATE NONCLUSTERED INDEX [IX_RequestReviewer_AssignedReviewerId] ON [dbo].[RequestReviewer]
(
	[AssignedReviewerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Section_DepartmentId]    Script Date: 9/20/2023 8:35:42 PM ******/
CREATE NONCLUSTERED INDEX [IX_Section_DepartmentId] ON [dbo].[Section]
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Section_HeadId]    Script Date: 9/20/2023 8:35:42 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Section_HeadId] ON [dbo].[Section]
(
	[HeadId] ASC
)
WHERE ([HeadId] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_TravelDeskRequest_RequestId]    Script Date: 9/20/2023 8:35:42 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_TravelDeskRequest_RequestId] ON [dbo].[TravelDeskRequest]
(
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_VoucherRequest_RequestId]    Script Date: 9/20/2023 8:35:42 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_VoucherRequest_RequestId] ON [dbo].[VoucherRequest]
(
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 9/20/2023 8:35:42 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [security].[Role]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_RoleClaims_RoleId]    Script Date: 9/20/2023 8:35:42 PM ******/
CREATE NONCLUSTERED INDEX [IX_RoleClaims_RoleId] ON [security].[RoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 9/20/2023 8:35:42 PM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [security].[User]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_User_DepartmentId]    Script Date: 9/20/2023 8:35:42 PM ******/
CREATE NONCLUSTERED INDEX [IX_User_DepartmentId] ON [security].[User]
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_User_ManagerId]    Script Date: 9/20/2023 8:35:42 PM ******/
CREATE NONCLUSTERED INDEX [IX_User_ManagerId] ON [security].[User]
(
	[ManagerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_User_SectionId]    Script Date: 9/20/2023 8:35:42 PM ******/
CREATE NONCLUSTERED INDEX [IX_User_SectionId] ON [security].[User]
(
	[SectionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 9/20/2023 8:35:42 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [security].[User]
(
	[NormalizedUserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserClaims_UserId]    Script Date: 9/20/2023 8:35:42 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserClaims_UserId] ON [security].[UserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserLogin_UserId]    Script Date: 9/20/2023 8:35:42 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserLogin_UserId] ON [security].[UserLogin]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserRoles_RoleId]    Script Date: 9/20/2023 8:35:42 PM ******/
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
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ApplicationUserRequest] CHECK CONSTRAINT [FK_ApplicationUserRequest_Request]
GO
ALTER TABLE [dbo].[Attachment]  WITH CHECK ADD  CONSTRAINT [FK_Attachment_Request] FOREIGN KEY([RequestId])
REFERENCES [dbo].[Request] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Attachment] CHECK CONSTRAINT [FK_Attachment_Request]
GO
ALTER TABLE [dbo].[CarRequest]  WITH CHECK ADD  CONSTRAINT [FK_CarRequest_Request] FOREIGN KEY([RequestId])
REFERENCES [dbo].[Request] ([Id])
ON DELETE CASCADE
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
ALTER TABLE [dbo].[DefinedRequestReviewer]  WITH CHECK ADD  CONSTRAINT [FK_DefinedRequestReviewer_User] FOREIGN KEY([AssignedReviewerId])
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
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DomainAccountRequest] CHECK CONSTRAINT [FK_DomainAccountRequest_Request]
GO
ALTER TABLE [dbo].[PoRequest]  WITH CHECK ADD  CONSTRAINT [FK_PoRequest_Request] FOREIGN KEY([RequestId])
REFERENCES [dbo].[Request] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PoRequest] CHECK CONSTRAINT [FK_PoRequest_Request]
GO
ALTER TABLE [dbo].[Request]  WITH CHECK ADD  CONSTRAINT [FK_Request_DefinedRequest] FOREIGN KEY([DefinedRequestId])
REFERENCES [dbo].[DefinedRequest] ([Id])
GO
ALTER TABLE [dbo].[Request] CHECK CONSTRAINT [FK_Request_DefinedRequest]
GO
ALTER TABLE [dbo].[Request]  WITH CHECK ADD  CONSTRAINT [FK_Request_User] FOREIGN KEY([CreatorId])
REFERENCES [security].[User] ([Id])
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
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RequestApplicationRole] CHECK CONSTRAINT [FK_RequestApplicationRole_Request]
GO
ALTER TABLE [dbo].[RequestReviewer]  WITH CHECK ADD  CONSTRAINT [FK_RequestReviewer_Request] FOREIGN KEY([RequestId])
REFERENCES [dbo].[Request] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RequestReviewer] CHECK CONSTRAINT [FK_RequestReviewer_Request]
GO
ALTER TABLE [dbo].[RequestReviewer]  WITH CHECK ADD  CONSTRAINT [FK_RequestReviewer_User] FOREIGN KEY([AssignedReviewerId])
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
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TravelDeskRequest] CHECK CONSTRAINT [FK_TravelDeskRequest_Request]
GO
ALTER TABLE [dbo].[VoucherRequest]  WITH CHECK ADD  CONSTRAINT [FK_VoucherRequest_Request] FOREIGN KEY([RequestId])
REFERENCES [dbo].[Request] ([Id])
ON DELETE CASCADE
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
