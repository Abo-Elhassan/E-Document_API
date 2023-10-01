USE [master]
GO
/****** Object:  Database [E-Document]    Script Date: 10/1/2023 12:35:51 PM ******/
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
/****** Object:  Schema [Audit]    Script Date: 10/1/2023 12:35:51 PM ******/
CREATE SCHEMA [Audit]
GO
/****** Object:  Schema [security]    Script Date: 10/1/2023 12:35:51 PM ******/
CREATE SCHEMA [security]
GO
/****** Object:  Table [Audit].[AuditApplicationUserRequest]    Script Date: 10/1/2023 12:35:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Audit].[AuditApplicationUserRequest](
	[Key] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[ModifiedBy] [nvarchar](max) NULL,
	[TransactionType] [nvarchar](max) NOT NULL,
	[DataStatus] [nvarchar](max) NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
	[RequestNumber] [nvarchar](max) NULL,
	[BeneficiaryId] [nvarchar](max) NULL,
	[BeneficiaryName] [nvarchar](max) NULL,
	[BeneficiaryEmail] [nvarchar](max) NULL,
	[BeneficiaryPosition] [nvarchar](max) NULL,
	[BeneficiaryDepartment] [nvarchar](max) NULL,
	[BeneficiaryPhoneNumber] [nvarchar](max) NULL,
	[BeneficiaryExtention] [nvarchar](max) NULL,
	[RequestId] [bigint] NOT NULL,
 CONSTRAINT [PK_AuditApplicationUserRequest] PRIMARY KEY CLUSTERED 
(
	[Key] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Audit].[AuditAttachment]    Script Date: 10/1/2023 12:35:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Audit].[AuditAttachment](
	[Key] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Id] [bigint] NOT NULL,
	[FilePath] [nvarchar](max) NULL,
	[RequestId] [bigint] NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[ModifiedBy] [nvarchar](max) NULL,
	[TransactionType] [nvarchar](max) NOT NULL,
	[DataStatus] [nvarchar](max) NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_AuditAttachment] PRIMARY KEY CLUSTERED 
(
	[Key] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Audit].[AuditDefinedApplication]    Script Date: 10/1/2023 12:35:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Audit].[AuditDefinedApplication](
	[Key] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Id] [bigint] NOT NULL,
	[ApplicationName] [nvarchar](max) NULL,
	[ApplicationOwnerId] [nvarchar](max) NULL,
	[CreatedAt] [datetime2](7) NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[ModifiedBy] [nvarchar](max) NULL,
	[TransactionType] [nvarchar](max) NOT NULL,
	[DataStatus] [nvarchar](max) NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_AuditDefinedApplication] PRIMARY KEY CLUSTERED 
(
	[Key] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Audit].[AuditDefinedApplicationRole]    Script Date: 10/1/2023 12:35:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Audit].[AuditDefinedApplicationRole](
	[Key] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Id] [bigint] NOT NULL,
	[RoleName] [nvarchar](max) NULL,
	[RequestedApplicationId] [bigint] NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[ModifiedBy] [nvarchar](max) NULL,
	[TransactionType] [nvarchar](max) NOT NULL,
	[DataStatus] [nvarchar](max) NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_AuditDefinedApplicationRole] PRIMARY KEY CLUSTERED 
(
	[Key] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Audit].[AuditDefinedRequest]    Script Date: 10/1/2023 12:35:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Audit].[AuditDefinedRequest](
	[Key] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Id] [bigint] NOT NULL,
	[RequestName] [nvarchar](max) NULL,
	[RouteName] [nvarchar](max) NULL,
	[ReviewersNumber] [int] NOT NULL,
	[DepartmentId] [bigint] NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[ModifiedBy] [nvarchar](max) NULL,
	[TransactionType] [nvarchar](max) NOT NULL,
	[DataStatus] [nvarchar](max) NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_AuditDefinedRequest] PRIMARY KEY CLUSTERED 
(
	[Key] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Audit].[AuditDefinedRequestReviewer]    Script Date: 10/1/2023 12:35:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Audit].[AuditDefinedRequestReviewer](
	[Key] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[DefinedRequestId] [bigint] NOT NULL,
	[AssignedReviewerId] [nvarchar](max) NULL,
	[DelegatedReviewerId] [nvarchar](max) NULL,
	[StageName] [nvarchar](max) NULL,
	[StageNumber] [int] NOT NULL,
	[ReviewerType] [nvarchar](max) NULL,
	[DelegatedUntil] [datetime2](7) NULL,
	[CreatedAt] [datetime2](7) NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[ModifiedBy] [nvarchar](max) NULL,
	[TransactionType] [nvarchar](max) NOT NULL,
	[DataStatus] [nvarchar](max) NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_AuditDefinedRequestReviewer] PRIMARY KEY CLUSTERED 
(
	[Key] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Audit].[AuditDefinedRequestRole]    Script Date: 10/1/2023 12:35:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Audit].[AuditDefinedRequestRole](
	[Key] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](max) NULL,
	[DefinedRequestId] [bigint] NOT NULL,
	[Permission] [nvarchar](max) NULL,
	[CreatedAt] [datetime2](7) NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[ModifiedBy] [nvarchar](max) NULL,
	[TransactionType] [nvarchar](max) NOT NULL,
	[DataStatus] [nvarchar](max) NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_AuditDefinedRequestRole] PRIMARY KEY CLUSTERED 
(
	[Key] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Audit].[AuditDepartment]    Script Date: 10/1/2023 12:35:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Audit].[AuditDepartment](
	[Key] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Id] [bigint] NOT NULL,
	[DepartmentName] [nvarchar](max) NULL,
	[DepartmentIcon] [nvarchar](max) NULL,
	[ManagerId] [nvarchar](max) NULL,
	[CreatedAt] [datetime2](7) NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[ModifiedBy] [nvarchar](max) NULL,
	[TransactionType] [nvarchar](max) NOT NULL,
	[DataStatus] [nvarchar](max) NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_AuditDepartment] PRIMARY KEY CLUSTERED 
(
	[Key] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Audit].[AuditDomainAccountRequest]    Script Date: 10/1/2023 12:35:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Audit].[AuditDomainAccountRequest](
	[Key] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[DisplayName] [nvarchar](max) NULL,
	[LoginName] [nvarchar](max) NULL,
	[OU] [nvarchar](max) NULL,
	[CreatedAt] [datetime2](7) NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[ModifiedBy] [nvarchar](max) NULL,
	[TransactionType] [nvarchar](max) NOT NULL,
	[DataStatus] [nvarchar](max) NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
	[RequestNumber] [nvarchar](max) NULL,
	[BeneficiaryId] [nvarchar](max) NULL,
	[BeneficiaryName] [nvarchar](max) NULL,
	[BeneficiaryEmail] [nvarchar](max) NULL,
	[BeneficiaryPosition] [nvarchar](max) NULL,
	[BeneficiaryDepartment] [nvarchar](max) NULL,
	[BeneficiaryPhoneNumber] [nvarchar](max) NULL,
	[BeneficiaryExtention] [nvarchar](max) NULL,
	[RequestId] [bigint] NOT NULL,
 CONSTRAINT [PK_AuditDomainAccountRequest] PRIMARY KEY CLUSTERED 
(
	[Key] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Audit].[AuditRequest]    Script Date: 10/1/2023 12:35:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Audit].[AuditRequest](
	[Key] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Id] [bigint] NOT NULL,
	[CurrentStage] [int] NOT NULL,
	[DataStatus] [nvarchar](max) NULL,
	[Justification] [nvarchar](max) NULL,
	[CreatorId] [nvarchar](max) NULL,
	[DefinedRequestId] [bigint] NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[ModifiedBy] [nvarchar](max) NULL,
	[TransactionType] [nvarchar](max) NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_AuditRequest] PRIMARY KEY CLUSTERED 
(
	[Key] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Audit].[AuditRequestApplicationRole]    Script Date: 10/1/2023 12:35:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Audit].[AuditRequestApplicationRole](
	[Key] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[RequestId] [bigint] NOT NULL,
	[ApplicationId] [bigint] NOT NULL,
	[RoleId] [bigint] NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[ModifiedBy] [nvarchar](max) NULL,
	[TransactionType] [nvarchar](max) NOT NULL,
	[DataStatus] [nvarchar](max) NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_AuditRequestApplicationRole] PRIMARY KEY CLUSTERED 
(
	[Key] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Audit].[AuditRequestReviewer]    Script Date: 10/1/2023 12:35:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Audit].[AuditRequestReviewer](
	[Key] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[RequestId] [bigint] NOT NULL,
	[AssignedReviewerId] [nvarchar](max) NULL,
	[ReviewedBy] [nvarchar](max) NULL,
	[StageName] [nvarchar](max) NULL,
	[StageNumber] [int] NOT NULL,
	[ReviewerType] [nvarchar](max) NULL,
	[Status] [nvarchar](max) NULL,
	[ReviewerNotes] [nvarchar](max) NULL,
	[CreatedAt] [datetime2](7) NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[ModifiedBy] [nvarchar](max) NULL,
	[TransactionType] [nvarchar](max) NOT NULL,
	[DataStatus] [nvarchar](max) NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_AuditRequestReviewer] PRIMARY KEY CLUSTERED 
(
	[Key] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Audit].[AuditRole]    Script Date: 10/1/2023 12:35:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Audit].[AuditRole](
	[Key] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NOT NULL,
	[ModifiedBy] [nvarchar](max) NOT NULL,
	[TransactionType] [nvarchar](max) NOT NULL,
	[DataStatus] [nvarchar](max) NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
	[Id] [nvarchar](max) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[NormalizedName] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AuditRole] PRIMARY KEY CLUSTERED 
(
	[Key] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Audit].[AuditSection]    Script Date: 10/1/2023 12:35:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Audit].[AuditSection](
	[Key] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Id] [bigint] NOT NULL,
	[SectionName] [nvarchar](max) NULL,
	[DepartmentId] [bigint] NULL,
	[HeadId] [nvarchar](max) NULL,
	[CreatedAt] [datetime2](7) NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[ModifiedBy] [nvarchar](max) NULL,
	[TransactionType] [nvarchar](max) NOT NULL,
	[DataStatus] [nvarchar](max) NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_AuditSection] PRIMARY KEY CLUSTERED 
(
	[Key] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Audit].[AuditTravelDeskRequest]    Script Date: 10/1/2023 12:35:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Audit].[AuditTravelDeskRequest](
	[Key] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[RequestType] [nvarchar](max) NULL,
	[BeneficiaryNationality] [nvarchar](max) NULL,
	[CostAllocation] [real] NOT NULL,
	[Currency] [nvarchar](max) NULL,
	[CheckIn] [datetime2](7) NULL,
	[CheckOut] [datetime2](7) NULL,
	[MissionAddress] [nvarchar](max) NULL,
	[PaymentMethod] [nvarchar](max) NULL,
	[FlightOrigin] [nvarchar](max) NULL,
	[FlightDestination] [nvarchar](max) NULL,
	[DepartureDate] [datetime2](7) NULL,
	[ReturnDate] [datetime2](7) NULL,
	[DestinationCountry] [nvarchar](max) NULL,
	[ExpectedTravelTime] [datetime2](7) NULL,
	[CreatedAt] [datetime2](7) NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[ModifiedBy] [nvarchar](max) NULL,
	[TransactionType] [nvarchar](max) NOT NULL,
	[DataStatus] [nvarchar](max) NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
	[RequestNumber] [nvarchar](max) NULL,
	[BeneficiaryId] [nvarchar](max) NULL,
	[BeneficiaryName] [nvarchar](max) NULL,
	[BeneficiaryEmail] [nvarchar](max) NULL,
	[BeneficiaryPosition] [nvarchar](max) NULL,
	[BeneficiaryDepartment] [nvarchar](max) NULL,
	[BeneficiaryPhoneNumber] [nvarchar](max) NULL,
	[BeneficiaryExtention] [nvarchar](max) NULL,
	[RequestId] [bigint] NOT NULL,
 CONSTRAINT [PK_AuditTravelDeskRequest] PRIMARY KEY CLUSTERED 
(
	[Key] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Audit].[AuditUser]    Script Date: 10/1/2023 12:35:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Audit].[AuditUser](
	[Key] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](max) NULL,
	[NormalizedUserName] [nvarchar](max) NULL,
	[FullName] [nvarchar](max) NULL,
	[Position] [nvarchar](max) NULL,
	[DepartmentId] [bigint] NULL,
	[SectionId] [bigint] NULL,
	[ManagerId] [nvarchar](max) NULL,
	[Company] [nvarchar](max) NULL,
	[IsEmployee] [bit] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[LastLogin] [datetime2](7) NULL,
	[CreatedAt] [datetime2](7) NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[ModifiedBy] [nvarchar](max) NULL,
	[TransactionType] [nvarchar](max) NULL,
	[DataStatus] [nvarchar](max) NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
	[Id] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NULL,
	[NormalizedEmail] [nvarchar](max) NULL,
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
 CONSTRAINT [PK_AuditUser] PRIMARY KEY CLUSTERED 
(
	[Key] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Audit].[AuditVehicleRequest]    Script Date: 10/1/2023 12:35:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Audit].[AuditVehicleRequest](
	[Key] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[DepartureAddress] [nvarchar](max) NULL,
	[DestinationAddress] [nvarchar](max) NULL,
	[DepartureDate] [datetime2](7) NOT NULL,
	[ReturnDate] [datetime2](7) NOT NULL,
	[LuggageDescription] [nvarchar](max) NULL,
	[VehicleType] [nvarchar](max) NULL,
	[CreatedAt] [datetime2](7) NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[ModifiedBy] [nvarchar](max) NULL,
	[TransactionType] [nvarchar](max) NOT NULL,
	[DataStatus] [nvarchar](max) NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
	[RequestNumber] [nvarchar](max) NULL,
	[BeneficiaryId] [nvarchar](max) NULL,
	[BeneficiaryName] [nvarchar](max) NULL,
	[BeneficiaryEmail] [nvarchar](max) NULL,
	[BeneficiaryPosition] [nvarchar](max) NULL,
	[BeneficiaryDepartment] [nvarchar](max) NULL,
	[BeneficiaryPhoneNumber] [nvarchar](max) NULL,
	[BeneficiaryExtention] [nvarchar](max) NULL,
	[RequestId] [bigint] NOT NULL,
 CONSTRAINT [PK_AuditVehicleRequest] PRIMARY KEY CLUSTERED 
(
	[Key] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Audit].[AuditVoucherRequest]    Script Date: 10/1/2023 12:35:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Audit].[AuditVoucherRequest](
	[Key] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[VendorNumber] [nvarchar](max) NULL,
	[VendorName] [nvarchar](max) NULL,
	[InvoiceDate] [datetime2](7) NOT NULL,
	[BeneficiaryName] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[VoucherAmount] [real] NOT NULL,
	[VoucherCurrency] [nvarchar](max) NULL,
	[VoucherType] [nvarchar](max) NULL,
	[RequestId] [bigint] NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[ModifiedBy] [nvarchar](max) NULL,
	[TransactionType] [nvarchar](max) NOT NULL,
	[DataStatus] [nvarchar](max) NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_AuditVoucherRequest] PRIMARY KEY CLUSTERED 
(
	[Key] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 10/1/2023 12:35:51 PM ******/
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
/****** Object:  Table [dbo].[ApplicationItAdmin]    Script Date: 10/1/2023 12:35:51 PM ******/
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
/****** Object:  Table [dbo].[ApplicationUserRequest]    Script Date: 10/1/2023 12:35:51 PM ******/
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
	[BeneficiaryPosition] [nvarchar](200) NULL,
	[BeneficiaryDepartment] [nvarchar](200) NULL,
	[BeneficiaryPhoneNumber] [nvarchar](50) NULL,
	[BeneficiaryExtention] [nvarchar](50) NULL,
	[RequestNumber] [nvarchar](max) NULL,
 CONSTRAINT [PK_ApplicationUserRequest] PRIMARY KEY CLUSTERED 
(
	[BeneficiaryId] ASC,
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Attachment]    Script Date: 10/1/2023 12:35:51 PM ******/
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
/****** Object:  Table [dbo].[DefinedApplication]    Script Date: 10/1/2023 12:35:51 PM ******/
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
/****** Object:  Table [dbo].[DefinedApplicationRole]    Script Date: 10/1/2023 12:35:51 PM ******/
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
/****** Object:  Table [dbo].[DefinedRequest]    Script Date: 10/1/2023 12:35:51 PM ******/
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
/****** Object:  Table [dbo].[DefinedRequestReviewer]    Script Date: 10/1/2023 12:35:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DefinedRequestReviewer](
	[DefinedRequestId] [bigint] NOT NULL,
	[AssignedReviewerId] [nvarchar](50) NULL,
	[DelegatedReviewerId] [nvarchar](50) NULL,
	[StageName] [nvarchar](50) NULL,
	[StageNumber] [int] NOT NULL,
	[ReviewerType] [nvarchar](50) NOT NULL,
	[DelegatedUntil] [smalldatetime] NULL,
	[CreatedAt] [smalldatetime] NULL,
	[ModifiedAt] [smalldatetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[ModifiedBy] [nvarchar](50) NULL,
	[Key] [bigint] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_DefinedRequestReviewer] PRIMARY KEY CLUSTERED 
(
	[Key] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DefinedRequestRole]    Script Date: 10/1/2023 12:35:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DefinedRequestRole](
	[RoleId] [nvarchar](450) NOT NULL,
	[DefinedRequestId] [bigint] NOT NULL,
	[Permission] [nvarchar](450) NOT NULL,
	[CreatedAt] [smalldatetime] NULL,
	[ModifiedAt] [smalldatetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[ModifiedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_DefinedRequestRole] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC,
	[DefinedRequestId] ASC,
	[Permission] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 10/1/2023 12:35:51 PM ******/
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
/****** Object:  Table [dbo].[DomainAccountRequest]    Script Date: 10/1/2023 12:35:51 PM ******/
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
	[BeneficiaryPosition] [nvarchar](200) NULL,
	[BeneficiaryDepartment] [nvarchar](200) NULL,
	[BeneficiaryPhoneNumber] [nvarchar](50) NULL,
	[BeneficiaryExtention] [nvarchar](50) NULL,
	[RequestNumber] [nvarchar](max) NULL,
 CONSTRAINT [PK_DomainAccountRequest] PRIMARY KEY CLUSTERED 
(
	[BeneficiaryId] ASC,
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PoRequest]    Script Date: 10/1/2023 12:35:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PoRequest](
	[PoNumber] [nvarchar](450) NULL,
	[PoDescription] [nvarchar](max) NOT NULL,
	[VendorName] [nvarchar](max) NOT NULL,
	[VendorNumber] [int] NOT NULL,
	[InvoiceNumber] [nvarchar](450) NOT NULL,
	[PoAttachmentPath] [nvarchar](max) NOT NULL,
	[InvoiceAttachmentPath] [nvarchar](max) NOT NULL,
	[RequestId] [bigint] NOT NULL,
	[CreatedAt] [smalldatetime] NULL,
	[ModifiedAt] [smalldatetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[ModifiedBy] [nvarchar](50) NULL,
	[RequestNumber] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PoRequest] PRIMARY KEY CLUSTERED 
(
	[RequestNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Request]    Script Date: 10/1/2023 12:35:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Request](
	[Id] [bigint] NOT NULL,
	[CurrentStage] [int] NOT NULL,
	[Status] [nvarchar](50) NULL,
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
/****** Object:  Table [dbo].[RequestApplicationRole]    Script Date: 10/1/2023 12:35:51 PM ******/
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
/****** Object:  Table [dbo].[RequestReviewer]    Script Date: 10/1/2023 12:35:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RequestReviewer](
	[RequestId] [bigint] NOT NULL,
	[AssignedReviewerId] [nvarchar](50) NOT NULL,
	[ReviewedBy] [nvarchar](200) NULL,
	[StageName] [nvarchar](max) NULL,
	[StageNumber] [int] NOT NULL,
	[ReviewerType] [nvarchar](50) NOT NULL,
	[Status] [nvarchar](50) NULL,
	[ReviewerNotes] [nvarchar](max) NULL,
	[CreatedAt] [smalldatetime] NULL,
	[ModifiedAt] [smalldatetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[ModifiedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_RequestReviewer] PRIMARY KEY CLUSTERED 
(
	[RequestId] ASC,
	[AssignedReviewerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Section]    Script Date: 10/1/2023 12:35:51 PM ******/
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
/****** Object:  Table [dbo].[TravelDeskRequest]    Script Date: 10/1/2023 12:35:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TravelDeskRequest](
	[BeneficiaryId] [nvarchar](50) NOT NULL,
	[RequestId] [bigint] NOT NULL,
	[RequestType] [nvarchar](200) NOT NULL,
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
	[BeneficiaryPosition] [nvarchar](200) NULL,
	[BeneficiaryDepartment] [nvarchar](200) NULL,
	[BeneficiaryPhoneNumber] [nvarchar](50) NULL,
	[BeneficiaryExtention] [nvarchar](50) NULL,
	[RequestNumber] [nvarchar](max) NULL,
 CONSTRAINT [PK_TravelDeskRequest] PRIMARY KEY CLUSTERED 
(
	[BeneficiaryId] ASC,
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VehicleRequest]    Script Date: 10/1/2023 12:35:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VehicleRequest](
	[DepartureAddress] [nvarchar](50) NOT NULL,
	[DestinationAddress] [nvarchar](50) NOT NULL,
	[DepartureDate] [smalldatetime] NOT NULL,
	[ReturnDate] [smalldatetime] NOT NULL,
	[LuggageDescription] [nvarchar](max) NOT NULL,
	[VehicleType] [nvarchar](50) NOT NULL,
	[CreatedAt] [smalldatetime] NULL,
	[ModifiedAt] [smalldatetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[ModifiedBy] [nvarchar](50) NULL,
	[BeneficiaryId] [nvarchar](50) NOT NULL,
	[BeneficiaryName] [nvarchar](200) NOT NULL,
	[BeneficiaryEmail] [nvarchar](50) NULL,
	[BeneficiaryPosition] [nvarchar](200) NULL,
	[BeneficiaryDepartment] [nvarchar](200) NULL,
	[BeneficiaryPhoneNumber] [nvarchar](50) NULL,
	[BeneficiaryExtention] [nvarchar](50) NULL,
	[RequestId] [bigint] NOT NULL,
	[RequestNumber] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_VehicleRequest] PRIMARY KEY CLUSTERED 
(
	[RequestNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VoucherRequest]    Script Date: 10/1/2023 12:35:51 PM ******/
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
/****** Object:  Table [security].[Role]    Script Date: 10/1/2023 12:35:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [security].[Role](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[CreatedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NOT NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[ModifiedBy] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [security].[RoleClaims]    Script Date: 10/1/2023 12:35:51 PM ******/
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
/****** Object:  Table [security].[User]    Script Date: 10/1/2023 12:35:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [security].[User](
	[Id] [nvarchar](50) NOT NULL,
	[UserName] [nvarchar](50) NULL,
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
/****** Object:  Table [security].[UserClaims]    Script Date: 10/1/2023 12:35:51 PM ******/
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
/****** Object:  Table [security].[UserLogin]    Script Date: 10/1/2023 12:35:51 PM ******/
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
/****** Object:  Table [security].[UserRoles]    Script Date: 10/1/2023 12:35:51 PM ******/
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
/****** Object:  Table [security].[UserToken]    Script Date: 10/1/2023 12:35:51 PM ******/
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
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230920173741_initial-Migration', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230920180025_addUsers', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230920180141_addDepartments', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230920180233_addSection', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230920180459_addrequestRoles', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230920180704_updateDepartmentAndSections', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230920195658_updatePoNumberIndex', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230920201156_updatePoNumberIndex2', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230923114703_addDefaultValueForReqeustNumber', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230923115000_makeRequetNumberPK', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230923131937_makeRequetNumberStringStep1', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230923132022_makeRequetNumberStringStep2', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230925082126_tryToMakeVendorNumberNullable', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230925082403_tryToMakeVendorNumberNullable1', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230925092626_makeCurrentStageNotNull', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230925102752_dddDefaultValueForStatus', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230925172345_makeVendorNumberRequired', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230926080119_changeBeneficiaryPhoneNumberColumnName', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230926080753_makeBeneficiaryPhoneNumberRequired', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230926081621_renameRetrunDate', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230926081952_renameBeneficiaryPosition', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230926082756_removeIdentityForRequestNumberVehicleRequestssssss', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230926082858_removeIdentityForRequestNumberVehicleRequestsssssssssss', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230926084052_updateDefinedRequestRole', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230926085029_updateDefinedRequestRoless', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230926085237_updateDefinedRequestRolessfas', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230926093015_makeAssignedReviewerIdInDefinedRequestReviewerNullables', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230927081942_makeRequestNumberAsStringFirstStep', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230927082030_makeRequestNumberAsStringSecondStep', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230927095020_setDefaultValuesAndMakeUserNameAllowNull', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230930072107_makeTravelDeskTypeString', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230930073957_changeNamefromIdToKey', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231001074749_addAuditTables', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231001091805_addCreatedandModifiedInfoForRoles', N'7.0.10')
GO
SET IDENTITY_INSERT [dbo].[Attachment] ON 

INSERT [dbo].[Attachment] ([Id], [FilePath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (1, N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092311405101\SEAL1.xlsx', 2023092311405101, CAST(N'2023-09-23T11:41:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[Attachment] ([Id], [FilePath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2, N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092311405101\DrayInList.xls', 2023092311405101, CAST(N'2023-09-23T11:41:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[Attachment] ([Id], [FilePath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (3, N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092311405101\المستندات.pdf', 2023092311405101, CAST(N'2023-09-23T11:53:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[Attachment] ([Id], [FilePath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (4, N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092311405101\ايصالات البريد.pdf', 2023092311405101, CAST(N'2023-09-23T11:53:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[Attachment] ([Id], [FilePath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (5, N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092311405101\المستندات.pdf', 2023092311405101, CAST(N'2023-09-23T11:54:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[Attachment] ([Id], [FilePath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (6, N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092311405101\ايصالات البريد.pdf', 2023092311405101, CAST(N'2023-09-23T11:54:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[Attachment] ([Id], [FilePath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (7, N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092311405101\المستندات.pdf', 2023092311405101, CAST(N'2023-09-23T11:57:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[Attachment] ([Id], [FilePath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (8, N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092311405101\ايصالات البريد.pdf', 2023092311405101, CAST(N'2023-09-23T11:57:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[Attachment] ([Id], [FilePath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (9, N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092311405101\المستندات.pdf', 2023092311405101, CAST(N'2023-09-23T12:01:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[Attachment] ([Id], [FilePath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10, N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092311405101\ايصالات البريد.pdf', 2023092311405101, CAST(N'2023-09-23T12:01:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[Attachment] ([Id], [FilePath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (11, N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092311405101\e-Document Scope - V__.cleaned.docx', 2023092311405101, CAST(N'2023-09-23T12:02:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[Attachment] ([Id], [FilePath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (12, N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092311405101\Gate Pass missing mandatory fields.docx', 2023092311405101, CAST(N'2023-09-23T12:02:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[Attachment] ([Id], [FilePath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (16, N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092312383635\ايصالات البريد.pdf', 2023092312383635, CAST(N'2023-09-23T12:45:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[Attachment] ([Id], [FilePath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (20, N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092303273296\DP WORLD-mServices Lite-MAPT-TR-Template-202212040.2.pdf', 2023092303273296, CAST(N'2023-09-23T15:31:00' AS SmallDateTime), NULL, N'Tamer Elsayed', N'Tamer Elsayed')
INSERT [dbo].[Attachment] ([Id], [FilePath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (25, N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092412465945\Container_List (8).xlsx', 2023092412465945, CAST(N'2023-09-24T12:59:00' AS SmallDateTime), NULL, N'Tamer Elsayed', NULL)
INSERT [dbo].[Attachment] ([Id], [FilePath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (26, N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092401520199\Trucker invoicing discussion sheet.xlsx', 2023092401520199, CAST(N'2023-09-24T13:52:00' AS SmallDateTime), NULL, N'Shireen Samy', NULL)
INSERT [dbo].[Attachment] ([Id], [FilePath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (30, N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092408082616\Technical Documentation -  VAS - Delete Containers from Load List and Cut-Off Load List.docx', 2023092408082616, CAST(N'2023-09-24T20:14:00' AS SmallDateTime), NULL, N'Tamer Elsayed', NULL)
INSERT [dbo].[Attachment] ([Id], [FilePath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (31, N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092408461019\Technical Documentation -  VAS - Reefer Cycle Modification - Technical&Planning.docx', 2023092408461019, CAST(N'2023-09-24T20:46:00' AS SmallDateTime), NULL, N'Tamer Elsayed', NULL)
INSERT [dbo].[Attachment] ([Id], [FilePath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (32, N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092408461019\Technical Documentation - Auto Generating Invoices for Overweight, X-Ray Services and manual inspection services.docx', 2023092408461019, CAST(N'2023-09-24T20:46:00' AS SmallDateTime), NULL, N'Tamer Elsayed', NULL)
INSERT [dbo].[Attachment] ([Id], [FilePath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (34, N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092412035534\Technical Documentation -  VAS - Delete Containers from Load List and Cut-Off Load List.docx', 2023092412035534, CAST(N'2023-09-24T20:56:00' AS SmallDateTime), NULL, N'Tamer Elsayed', NULL)
INSERT [dbo].[Attachment] ([Id], [FilePath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (35, N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092409363271\Technical Documentation -  VAS - Delete Containers from Load List and Cut-Off Load List.docx', 2023092409363271, CAST(N'2023-09-24T21:37:00' AS SmallDateTime), NULL, N'Shireen Samy', NULL)
INSERT [dbo].[Attachment] ([Id], [FilePath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (36, N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092407501144\Technical Documentation -  EXPRESS - Direct Delivery from IA.docx', 2023092407501144, CAST(N'2023-09-25T13:22:00' AS SmallDateTime), NULL, N'Shireen Samy', NULL)
INSERT [dbo].[Attachment] ([Id], [FilePath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (37, N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092501350165\Technical Documentation -  VAS - Export Inspection.docx', 2023092501350165, CAST(N'2023-09-25T13:35:00' AS SmallDateTime), NULL, N'Shireen Samy', NULL)
INSERT [dbo].[Attachment] ([Id], [FilePath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (43, N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092608120404\Technical Documentation -  VAS - CFS Line Hold-Fix.docx', 2023092608120404, CAST(N'2023-09-26T20:33:00' AS SmallDateTime), NULL, N'Shireen Samy', NULL)
INSERT [dbo].[Attachment] ([Id], [FilePath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10039, N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\VehicleRequest\2023092711241573\Technical Documentation -  VAS - CFS Line Hold-Fix.docx', 2023092711241573, CAST(N'2023-09-27T11:24:00' AS SmallDateTime), NULL, N'Rewan Hosny', NULL)
INSERT [dbo].[Attachment] ([Id], [FilePath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10040, N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\VehicleRequest\2023092711243793\Technical Documentation -  VAS - CFS Line Hold-Fix.docx', 2023092711243793, CAST(N'2023-09-27T11:26:00' AS SmallDateTime), NULL, N'Rewan Hosny', NULL)
INSERT [dbo].[Attachment] ([Id], [FilePath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10041, N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\VehicleRequest\2023092711332214\Technical Documentation -  Online Payment Project - Trucker Invoices.docx', 2023092711332214, CAST(N'2023-09-27T11:33:00' AS SmallDateTime), NULL, N'Rewan Hosny', NULL)
INSERT [dbo].[Attachment] ([Id], [FilePath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10042, N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\VehicleRequest\2023092711332214\Technical Documentation -  EXPRESS - SET_INSPECTION_SERIVEC.docx', 2023092711332214, CAST(N'2023-09-27T11:33:00' AS SmallDateTime), NULL, N'Rewan Hosny', NULL)
INSERT [dbo].[Attachment] ([Id], [FilePath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10044, N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\VehicleRequest\2023092711434278\Technical Documentation -  VAS - Delete Containers from Load List and Cut-Off Load List.docx', 2023092711434278, CAST(N'2023-09-27T11:53:00' AS SmallDateTime), NULL, N'Rewan Hosny', NULL)
INSERT [dbo].[Attachment] ([Id], [FilePath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (20039, N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\TravelDeskRequest\2023093001511959\Transit_List.xlsx', 2023093001511959, CAST(N'2023-09-30T13:51:00' AS SmallDateTime), NULL, N'Rewan Hosny', NULL)
INSERT [dbo].[Attachment] ([Id], [FilePath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (20041, N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\TravelDeskRequest\2023100111282815\Reefer_List.xlsx', 2023100111282815, CAST(N'2023-10-01T12:33:00' AS SmallDateTime), NULL, N'Rewan Hosny', NULL)
SET IDENTITY_INSERT [dbo].[Attachment] OFF
GO
SET IDENTITY_INSERT [dbo].[DefinedRequest] ON 

INSERT [dbo].[DefinedRequest] ([Id], [RequestName], [RouteName], [ReviewersNumber], [DepartmentId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (1, N'PO', N'/Procurement/PO/', 1, 16, NULL, NULL, NULL, NULL)
INSERT [dbo].[DefinedRequest] ([Id], [RequestName], [RouteName], [ReviewersNumber], [DepartmentId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (3, N'Vehicle', N'/Administration/Vehicle/', 3, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[DefinedRequest] ([Id], [RequestName], [RouteName], [ReviewersNumber], [DepartmentId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10002, N'Travel Desk', N'/Administration/TravelDesk/', 3, 1, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[DefinedRequest] OFF
GO
SET IDENTITY_INSERT [dbo].[DefinedRequestReviewer] ON 

INSERT [dbo].[DefinedRequestReviewer] ([DefinedRequestId], [AssignedReviewerId], [DelegatedReviewerId], [StageName], [StageNumber], [ReviewerType], [DelegatedUntil], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Key]) VALUES (3, NULL, NULL, N'Beneficiary Department Manager', 1, N'DepartmentManager', NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[DefinedRequestReviewer] ([DefinedRequestId], [AssignedReviewerId], [DelegatedReviewerId], [StageName], [StageNumber], [ReviewerType], [DelegatedUntil], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Key]) VALUES (3, N'50269', NULL, N'Admin Manager', 2, N'Basic', NULL, NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[DefinedRequestReviewer] ([DefinedRequestId], [AssignedReviewerId], [DelegatedReviewerId], [StageName], [StageNumber], [ReviewerType], [DelegatedUntil], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Key]) VALUES (3, N'55887', NULL, N'Transportation Team Leader', 3, N'Basic', NULL, NULL, NULL, NULL, NULL, 3)
INSERT [dbo].[DefinedRequestReviewer] ([DefinedRequestId], [AssignedReviewerId], [DelegatedReviewerId], [StageName], [StageNumber], [ReviewerType], [DelegatedUntil], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Key]) VALUES (1, N'51555', NULL, N'Finance Reviewer', 1, N'Basic', NULL, NULL, NULL, NULL, NULL, 5)
INSERT [dbo].[DefinedRequestReviewer] ([DefinedRequestId], [AssignedReviewerId], [DelegatedReviewerId], [StageName], [StageNumber], [ReviewerType], [DelegatedUntil], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Key]) VALUES (1, N'51585', NULL, N'Finance Reviewer', 1, N'Basic', NULL, NULL, NULL, NULL, NULL, 6)
INSERT [dbo].[DefinedRequestReviewer] ([DefinedRequestId], [AssignedReviewerId], [DelegatedReviewerId], [StageName], [StageNumber], [ReviewerType], [DelegatedUntil], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Key]) VALUES (10002, N'51111', NULL, N'Sr. Executive administration', 3, N'Basic', NULL, NULL, NULL, NULL, NULL, 10003)
INSERT [dbo].[DefinedRequestReviewer] ([DefinedRequestId], [AssignedReviewerId], [DelegatedReviewerId], [StageName], [StageNumber], [ReviewerType], [DelegatedUntil], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Key]) VALUES (10002, NULL, NULL, N'Beneficiary Department Manager', 1, N'DepartmentManager', NULL, NULL, NULL, NULL, NULL, 10006)
INSERT [dbo].[DefinedRequestReviewer] ([DefinedRequestId], [AssignedReviewerId], [DelegatedReviewerId], [StageName], [StageNumber], [ReviewerType], [DelegatedUntil], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Key]) VALUES (10002, N'50269', NULL, N'Admin Manager', 2, N'Basic', NULL, NULL, NULL, NULL, NULL, 10007)
SET IDENTITY_INSERT [dbo].[DefinedRequestReviewer] OFF
GO
INSERT [dbo].[DefinedRequestRole] ([RoleId], [DefinedRequestId], [Permission], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'04cd21f1-113b-477e-a517-7dcb1ea8a024', 3, N'All', NULL, NULL, NULL, NULL)
INSERT [dbo].[DefinedRequestRole] ([RoleId], [DefinedRequestId], [Permission], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'04cd21f1-113b-477e-a517-7dcb1ea8a024', 10002, N'All', NULL, NULL, NULL, NULL)
INSERT [dbo].[DefinedRequestRole] ([RoleId], [DefinedRequestId], [Permission], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'121c1742-99e7-4b61-ab2f-f748876e2975', 1, N'Review', NULL, NULL, NULL, NULL)
INSERT [dbo].[DefinedRequestRole] ([RoleId], [DefinedRequestId], [Permission], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'1ee5bd21-f548-47f6-918f-2b0b7625ded2', 3, N'All', NULL, NULL, NULL, NULL)
INSERT [dbo].[DefinedRequestRole] ([RoleId], [DefinedRequestId], [Permission], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'1ee5bd21-f548-47f6-918f-2b0b7625ded2', 10002, N'All', NULL, NULL, NULL, NULL)
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
INSERT [dbo].[Department] ([Id], [DepartmentName], [DepartmentIcon], [ManagerId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (16, N'Procurement', N'Procurment.svg', N'51188', NULL, NULL, NULL, NULL)
INSERT [dbo].[Department] ([Id], [DepartmentName], [DepartmentIcon], [ManagerId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (17, N'Projects & Facility Management', NULL, N'51659', NULL, NULL, NULL, NULL)
INSERT [dbo].[Department] ([Id], [DepartmentName], [DepartmentIcon], [ManagerId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (18, N'QHSE', NULL, N'50882', NULL, NULL, NULL, NULL)
INSERT [dbo].[Department] ([Id], [DepartmentName], [DepartmentIcon], [ManagerId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (19, N'Security', N'Security.svg', N'50263', NULL, NULL, NULL, NULL)
INSERT [dbo].[Department] ([Id], [DepartmentName], [DepartmentIcon], [ManagerId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (20, N'Store', N'Stores.svg', N'50000', NULL, NULL, NULL, NULL)
INSERT [dbo].[Department] ([Id], [DepartmentName], [DepartmentIcon], [ManagerId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (21, N'Engineering', N'Technical Engineering.svg', N'50136', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.88-88888', N'88888', N'8888', 888, N'888888', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092303273296\Container_List (7).xls', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092303273296\A3-Form.xlsx', 2023092303273296, CAST(N'2023-09-23T15:28:00' AS SmallDateTime), CAST(N'2023-09-23T15:30:00' AS SmallDateTime), N'Tamer Elsayed', N'Tamer Elsayed', N'0')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.11-11', N'TEST', N'TEST', 1111, N'TEST', N'TEST', N'TEST', 2023092103022776, CAST(N'2023-09-21T15:03:00' AS SmallDateTime), NULL, N'Tamer Elsayed', NULL, N'1')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.22-1+', N'Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus.', N'Carroll Banasiak', 13, N'3532846423299657', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 279, CAST(N'2023-05-29T00:00:00' AS SmallDateTime), CAST(N'2023-07-04T00:00:00' AS SmallDateTime), N'cbanasiakc', N'cbanasiakc', N'10')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.22-222', N'TEST', N'TEST', 2122, N'TEST', N'TEST', N'TEST', 2023092103122026, CAST(N'2023-09-21T15:12:00' AS SmallDateTime), NULL, N'Tamer Elsayed', NULL, N'11')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.25-805', N'csvcsvsv', N'fvv', 65, N'fs', N'fs', N'sf', 2023092009104220, CAST(N'2023-09-20T21:11:00' AS SmallDateTime), CAST(N'2023-09-20T23:19:00' AS SmallDateTime), N'procurment_manager', N'procurment_manager', N'12')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.27-2+', N'Etiam vel augue. Vestibulum rutrum rutrum neque. Aenean auctor gravida sem. Praesent id massa id nisl venenatis lacinia. Aenean sit amet justo. Morbi ut odio. Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo. In blandit ultrices enim.', N'Kaela Pirt', 8, N'3559293680994761', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 250, CAST(N'2023-03-22T00:00:00' AS SmallDateTime), CAST(N'2022-12-26T00:00:00' AS SmallDateTime), N'kpirt7', N'kpirt7', N'14')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.27-8+', N'Nulla nisl.', N'Terrance Willcocks', 34, N'06047395989808916', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 280, CAST(N'2023-03-10T00:00:00' AS SmallDateTime), CAST(N'2022-09-24T00:00:00' AS SmallDateTime), N'twillcocksx', N'twillcocksx', N'15')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.27-9+', N'Fusce consequat.', N'Pia McNess', 1, N'3573809752532338', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 224, CAST(N'2023-01-29T00:00:00' AS SmallDateTime), CAST(N'2023-06-25T00:00:00' AS SmallDateTime), N'pmcness0', N'pmcness0', N'16')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.29-7+', N'In eleifend quam a odio.', N'Liuka Neesham', 36, N'503888007560133212', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 282, CAST(N'2023-03-13T00:00:00' AS SmallDateTime), CAST(N'2022-10-16T00:00:00' AS SmallDateTime), N'lneeshamz', N'lneeshamz', N'17')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.30-7+', N'Vivamus vestibulum sagittis sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.', N'Celene Cordsen', 17, N'6334941117489021684', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 283, CAST(N'2023-09-02T00:00:00' AS SmallDateTime), CAST(N'2023-04-28T00:00:00' AS SmallDateTime), N'ccordseng', N'ccordseng', N'18')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.31-4+', N'Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat. Praesent blandit. Nam nulla.', N'Rowena Twaits', 40, N'56022171565601205', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 284, CAST(N'2022-10-23T00:00:00' AS SmallDateTime), CAST(N'2023-03-10T00:00:00' AS SmallDateTime), N'rtwaits13', N'rtwaits13', N'19')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.11-7+', N'In est risus, auctor sed, tristique in, tempus sit amet, sem. Fusce consequat. Nulla nisl. Nunc nisl. Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa.', N'Jarrad Biaggi', 24, N'5010129106754330', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 254, CAST(N'2022-11-18T00:00:00' AS SmallDateTime), CAST(N'2023-03-09T00:00:00' AS SmallDateTime), N'jbiaggin', N'jbiaggin', N'2')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.33-42788', N'string', N'string', 88, N'string', N'string', N'string', 2023092009521968, CAST(N'2023-09-20T21:52:00' AS SmallDateTime), NULL, N'procurment_manager', NULL, N'20')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.00-000', N'000', N'000', 0, N'000', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092303464478\mServices Lite.pdf', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092303464478\Mohamed Abo Elhassan - Warehouse Section Head.pdf', 2023092303464478, CAST(N'2023-09-23T15:47:00' AS SmallDateTime), CAST(N'2023-09-23T15:59:00' AS SmallDateTime), N'Tamer Elsayed', N'Tamer Elsayed', N'20230923034644')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.38-2+', N'Praesent id massa id nisl venenatis lacinia. Aenean sit amet justo. Morbi ut odio. Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo. In blandit ultrices enim. Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin interdum mauris non ligula pellentesque ultrices.', N'Clifford Peachey', 39, N'3579204957590915', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 285, CAST(N'2023-09-09T00:00:00' AS SmallDateTime), CAST(N'2023-01-24T00:00:00' AS SmallDateTime), N'cpeachey12', N'cpeachey12', N'21')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.38-9+', N'Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus.', N'Farra Patrickson', 25, N'6771344448383248875', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 281, CAST(N'2022-11-11T00:00:00' AS SmallDateTime), CAST(N'2023-04-18T00:00:00' AS SmallDateTime), N'fpatricksono', N'fpatricksono', N'22')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.43-8+', N'Maecenas tincidunt lacus at velit. Vivamus vel nulla eget eros elementum pellentesque. Quisque porta volutpat erat. Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus. Phasellus in felis. Donec semper sapien a libero. Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis.', N'Eugenius Dongall', 48, N'3557518638220907', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 286, CAST(N'2022-12-24T00:00:00' AS SmallDateTime), CAST(N'2023-02-16T00:00:00' AS SmallDateTime), N'edongall1b', N'edongall1b', N'23')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.45-7+', N'Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat.', N'Luz Harnott', 31, N'3528061060197505', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 287, CAST(N'2023-05-23T00:00:00' AS SmallDateTime), CAST(N'2023-04-26T00:00:00' AS SmallDateTime), N'lharnottu', N'lharnottu', N'24')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.46-7+', N'Cras pellentesque volutpat dui. Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti. Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum.', N'Christi Coggles', 41, N'3578607582022321', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 288, CAST(N'2023-04-22T00:00:00' AS SmallDateTime), CAST(N'2023-05-01T00:00:00' AS SmallDateTime), N'ccoggles14', N'ccoggles14', N'25')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.46-9+', N'Curabitur convallis. Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor. Morbi vel lectus in quam fringilla rhoncus. Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis. Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero.', N'Tanny Sporton', 49, N'3574363464482431', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 248, CAST(N'2023-03-14T00:00:00' AS SmallDateTime), CAST(N'2023-08-29T00:00:00' AS SmallDateTime), N'tsporton1c', N'tsporton1c', N'26')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.50-9+', N'Praesent lectus. Vestibulum quam sapien, varius ut, blandit non, interdum in, ante. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio. Curabitur convallis.', N'Lory Malacrida', 45, N'3554509272156914', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 259, CAST(N'2023-03-06T00:00:00' AS SmallDateTime), CAST(N'2022-10-18T00:00:00' AS SmallDateTime), N'lmalacrida18', N'lmalacrida18', N'27')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.52-1+', N'Vestibulum ac est lacinia nisi venenatis tristique. Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue. Aliquam erat volutpat.', N'Dev Brame', 5, N'6767147846678208065', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 271, CAST(N'2023-06-17T00:00:00' AS SmallDateTime), CAST(N'2023-01-11T00:00:00' AS SmallDateTime), N'dbrame4', N'dbrame4', N'28')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.53-3+', N'Suspendisse potenti.', N'Nicol Brea', 43, N'3557568285973316', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 289, CAST(N'2022-10-01T00:00:00' AS SmallDateTime), CAST(N'2023-05-08T00:00:00' AS SmallDateTime), N'nbrea16', N'nbrea16', N'29')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.15-3+', N'Duis bibendum. Morbi non quam nec dui luctus rutrum. Nulla tellus. In sagittis dui vel nisl.', N'Corrinne Braidford', 16, N'6334209994908064926', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 222, CAST(N'2023-08-24T00:00:00' AS SmallDateTime), CAST(N'2023-05-03T00:00:00' AS SmallDateTime), N'cbraidfordf', N'cbraidfordf', N'3')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.55-3+', N'Pellentesque ultrices mattis odio. Donec vitae nisi. Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus. Curabitur at ipsum ac tellus semper interdum.', N'Fidole Babcock', 22, N'3579409999230269', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 290, CAST(N'2023-03-31T00:00:00' AS SmallDateTime), CAST(N'2023-01-01T00:00:00' AS SmallDateTime), N'fbabcockl', N'fbabcockl', N'30')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.55-4+', N'Nunc purus. Phasellus in felis. Donec semper sapien a libero. Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla.', N'Sheelagh McCunn', 26, N'3576928668581804', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 291, CAST(N'2023-08-26T00:00:00' AS SmallDateTime), CAST(N'2023-04-06T00:00:00' AS SmallDateTime), N'smccunnp', N'smccunnp', N'31')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.55-5555', N'000000', N'00000', 0, N'0000000', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092312383635\mServices Lite.docx', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092312383635\المستندات.pdf', 2023092312383635, CAST(N'2023-09-23T12:39:00' AS SmallDateTime), CAST(N'2023-09-23T12:45:00' AS SmallDateTime), N'Tamer Elsayed', N'Tamer Elsayed', N'32')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.57-8+', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin interdum mauris non ligula pellentesque ultrices. Phasellus id sapien in sapien iaculis congue.', N'Nydia Colchett', 47, N'3573720130982808', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 292, CAST(N'2023-05-03T00:00:00' AS SmallDateTime), CAST(N'2023-09-12T00:00:00' AS SmallDateTime), N'ncolchett1a', N'ncolchett1a', N'33')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.62-7+', N'In eleifend quam a odio. In hac habitasse platea dictumst. Maecenas ut massa quis augue luctus tincidunt. Nulla mollis molestie lorem. Quisque ut erat. Curabitur gravida nisi at nibh. In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat.', N'Kania Danton', 2, N'6333956052258700933', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 293, CAST(N'2023-05-15T00:00:00' AS SmallDateTime), CAST(N'2023-07-15T00:00:00' AS SmallDateTime), N'kdanton1', N'kdanton1', N'34')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.68-7+', N'Nulla mollis molestie lorem. Quisque ut erat. Curabitur gravida nisi at nibh. In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat.', N'Max Dahlback', 11, N'3528961373803246', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 238, CAST(N'2023-07-24T00:00:00' AS SmallDateTime), CAST(N'2022-12-06T00:00:00' AS SmallDateTime), N'mdahlbacka', N'mdahlbacka', N'35')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.73-3+', N'Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl. Nunc rhoncus dui vel sem. Sed sagittis. Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus. Pellentesque at nulla. Suspendisse potenti. Cras in purus eu magna vulputate luctus. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.', N'Krisha Franciottoi', 10, N'3552245872273856', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 294, CAST(N'2023-08-16T00:00:00' AS SmallDateTime), CAST(N'2022-10-11T00:00:00' AS SmallDateTime), N'kfranciottoi9', N'kfranciottoi9', N'36')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.73-6+', N'Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh. In quis justo.', N'Irene Maddigan', 6, N'5018786633938378879', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 209, CAST(N'2023-01-30T00:00:00' AS SmallDateTime), CAST(N'2022-10-10T00:00:00' AS SmallDateTime), N'imaddigan5', N'imaddigan5', N'37')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.77-4+', N'Nullam molestie nibh in lectus. Pellentesque at nulla. Suspendisse potenti. Cras in purus eu magna vulputate luctus. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vivamus vestibulum sagittis sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Etiam vel augue.', N'Datha Blampied', 12, N'3562373062410845', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 239, CAST(N'2023-04-23T00:00:00' AS SmallDateTime), CAST(N'2023-05-23T00:00:00' AS SmallDateTime), N'dblampiedb', N'dblampiedb', N'38')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.82-0+', N'Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus. Phasellus in felis. Donec semper sapien a libero.', N'Avrit Blount', 46, N'3578244889741609', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 295, CAST(N'2023-08-12T00:00:00' AS SmallDateTime), CAST(N'2023-07-12T00:00:00' AS SmallDateTime), N'ablount19', N'ablount19', N'39')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.15-8+', N'Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Etiam vel augue. Vestibulum rutrum rutrum neque. Aenean auctor gravida sem. Praesent id massa id nisl venenatis lacinia. Aenean sit amet justo.', N'Jacky Woodhouse', 14, N'3552009821673925', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 278, CAST(N'2023-03-03T00:00:00' AS SmallDateTime), CAST(N'2023-06-27T00:00:00' AS SmallDateTime), N'jwoodhoused', N'jwoodhoused', N'4')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.82-2+', N'Vestibulum ac est lacinia nisi venenatis tristique. Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue. Aliquam erat volutpat. In congue. Etiam justo. Etiam pretium iaculis justo.', N'Marita Klaggeman', 4, N'6371622373105872', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 296, CAST(N'2023-04-02T00:00:00' AS SmallDateTime), CAST(N'2023-05-27T00:00:00' AS SmallDateTime), N'mklaggeman3', N'mklaggeman3', N'40')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.86-0+', N'Integer ac neque. Duis bibendum.', N'Frederica Pressman', 27, N'3561827226709773', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 297, CAST(N'2022-12-05T00:00:00' AS SmallDateTime), CAST(N'2023-07-29T00:00:00' AS SmallDateTime), N'fpressmanq', N'fpressmanq', N'41')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.86-1+', N'Aliquam erat volutpat. In congue. Etiam justo. Etiam pretium iaculis justo. In hac habitasse platea dictumst. Etiam faucibus cursus urna. Ut tellus. Nulla ut erat id mauris vulputate elementum. Nullam varius.', N'Arline Cossem', 19, N'4911613110784514267', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 298, CAST(N'2022-11-23T00:00:00' AS SmallDateTime), CAST(N'2022-11-07T00:00:00' AS SmallDateTime), N'acossemi', N'acossemi', N'42')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.86-4+', N'Phasellus id sapien in sapien iaculis congue. Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl.', N'Reina Stoves', 21, N'3544603271795203', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 218, CAST(N'2022-11-06T00:00:00' AS SmallDateTime), CAST(N'2023-01-01T00:00:00' AS SmallDateTime), N'rstovesk', N'rstovesk', N'43')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.87-6+', N'Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat. Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede. Morbi porttitor lorem id ligula. Suspendisse ornare consequat lectus. In est risus, auctor sed, tristique in, tempus sit amet, sem. Fusce consequat. Nulla nisl.', N'Jo Hanshaw', 3, N'3544715717139539', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 299, CAST(N'2023-04-19T00:00:00' AS SmallDateTime), CAST(N'2023-06-26T00:00:00' AS SmallDateTime), N'jhanshaw2', N'jhanshaw2', N'44')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.91-4+', N'Vestibulum ac est lacinia nisi venenatis tristique. Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue.', N'Gaven Ricart', 29, N'4026900139327814', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 205, CAST(N'2023-06-23T00:00:00' AS SmallDateTime), CAST(N'2023-09-04T00:00:00' AS SmallDateTime), N'procurment_manager', N'gricarts', N'45')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.99-99', N'99', N'99', 99, N'99', N'99', N'99', 2023092103300594, CAST(N'2023-09-21T15:30:00' AS SmallDateTime), NULL, N'Tamer Elsayed', NULL, N'46')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.99-9999', N'111', N'111111', 11111, N'1111111', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092311405101\deparmemt.xlsx', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092311405101\git-cheat-sheet-education.pdf', 2023092311405101, CAST(N'2023-09-23T11:41:00' AS SmallDateTime), CAST(N'2023-09-23T12:02:00' AS SmallDateTime), N'Tamer Elsayed', N'Tamer Elsayed', N'47')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.16-1+', N'Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat. Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede. Morbi porttitor lorem id ligula.', N'Yolane Padmore', 20, N'5280763276227918', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 208, CAST(N'2023-01-20T00:00:00' AS SmallDateTime), CAST(N'2023-07-04T00:00:00' AS SmallDateTime), N'procurment_manager', N'ypadmorej', N'5')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.20-16432928', N'po description', N'Test Vendor', 99, N'323242', N'string', N'string', 302, CAST(N'2023-09-20T20:17:00' AS SmallDateTime), NULL, N'procurement_manager', NULL, N'6')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.20-3+', N'Duis mattis egestas metus.', N'Killie Walthall', 50, N'5602223460289274', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 277, CAST(N'2023-01-02T00:00:00' AS SmallDateTime), CAST(N'2022-10-16T00:00:00' AS SmallDateTime), N'kwalthall1d', N'kwalthall1d', N'7')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.20-7+', N'Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Etiam vel augue. Vestibulum rutrum rutrum neque. Aenean auctor gravida sem. Praesent id massa id nisl venenatis lacinia. Aenean sit amet justo. Morbi ut odio. Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo. In blandit ultrices enim. Lorem ipsum dolor sit amet, consectetuer adipiscing elit.', N'Bronnie Dominguez', 35, N'3578659126215812', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 272, CAST(N'2023-04-13T00:00:00' AS SmallDateTime), CAST(N'2023-06-05T00:00:00' AS SmallDateTime), N'bdominguezy', N'bdominguezy', N'8')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.21-4+', N'Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue. Aliquam erat volutpat. In congue. Etiam justo.', N'Merline Fuzzens', 32, N'493666448873988516', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', N'F:\Work\My Projects\.Net\E-Document\EDocument_API', 276, CAST(N'2022-10-15T00:00:00' AS SmallDateTime), CAST(N'2023-06-03T00:00:00' AS SmallDateTime), N'mfuzzensv', N'mfuzzensv', N'9')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.66-66', N'666', N'666', 66, N'666', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092304214266\mServices Lite.pdf', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092304214266\mServices Lite.docx', 2023092304214266, CAST(N'2023-09-23T16:22:00' AS SmallDateTime), NULL, N'Tamer Elsayed', NULL, N'PO-20230923042142')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.12-123', N'some desciption for SOK.PO.12-123 po', N'Test Vendor', 123, N'134568789', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092401520199\git-cheat-sheet-education.pdf', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092401520199\Gate Pass missing mandatory fields.docx', 2023092401520199, CAST(N'2023-09-24T13:52:00' AS SmallDateTime), NULL, N'Shireen Samy', NULL, N'PO-20230924015201')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.78-7878', N'po description', N'test vendor', 56, N'2165489748947', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092402501896\DPW_IT_GL003_Secure Coding Guidlines_V1.0.cleaned (1).pdf', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092402501896\git-cheat-sheet-education.pdf', 2023092402501896, CAST(N'2023-09-24T14:50:00' AS SmallDateTime), NULL, N'Shireen Samy', NULL, N'PO-20230924025019')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.55-88', N'523', N'5235', 235, N'235', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092407501144\Technical Documentation -  CLMS.docx', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092407501144\Technical Documentation -  MTS - Seal Cut1.docx', 2023092407501144, CAST(N'2023-09-24T19:55:00' AS SmallDateTime), CAST(N'2023-09-25T13:22:00' AS SmallDateTime), NULL, N'Shireen Samy', N'PO-20230924075011')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.65-65', N'65', N'65', 56, N'65', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092408082616\Technical Documentation -  CLMS - PIR Bug Fixes .docx', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092408082616\Technical Documentation -  MTS - Seal Cut.docx', 2023092408082616, CAST(N'2023-09-24T20:14:00' AS SmallDateTime), NULL, NULL, N'Tamer Elsayed', N'PO-20230924080826')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.77-99', N'76654', N'8765', 876, N'8765', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092408461019\Technical Documentation -  CLMS - PIR Bug Fixes .docx', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092408461019\Technical Documentation -  VAS - DB for Trucks & Drivers.docx', 2023092408461019, CAST(N'2023-09-24T20:46:00' AS SmallDateTime), NULL, N'Tamer Elsayed', NULL, N'PO-20230924084610')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.99-000', N'2323', N'32', 23, N'23', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092409160738\Technical Documentation -  iLEAN - LEAN Application.docx', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092409160738\Technical Documentation -  CRM - KYC.docx', 2023092409160738, CAST(N'2023-09-24T21:16:00' AS SmallDateTime), NULL, N'Shireen Samy', NULL, N'PO-20230924091607')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.88-88', N'5325', N'5325', 23525, N'2353252', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092409363271\Technical Documentation -  CRM - KYC.docx', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092409363271\Technical Documentation -  EXPRESS Generic MTY Position.docx', 2023092409363271, CAST(N'2023-09-24T21:37:00' AS SmallDateTime), CAST(N'2023-09-24T21:58:00' AS SmallDateTime), N'Shireen Samy', N'Shireen Samy', N'PO-20230924093632')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.99-992242', N'424', N'2424', 4242, N'24', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092411313243\Technical Documentation -  EXPRESS - Direct Delivery from IA.docx', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092411313243\Technical Documentation - Auto Generating Invoices For Export X-Ray Services and manual inspection services.docx', 2023092411313243, CAST(N'2023-09-24T23:32:00' AS SmallDateTime), NULL, N'Shireen Samy', NULL, N'PO-20230924113132')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.65-65', N'65', N'65', 56, N'65', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092412035534\mServices Lite.docx', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092412035534\Technical Documentation -  MTS - Seal Cut.docx', 2023092412035534, CAST(N'2023-09-24T20:56:00' AS SmallDateTime), NULL, N'Tamer Elsayed', N'Tamer Elsayed', N'PO-20230924120355')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.66-66', N'66666', N'6666', 66666, N'66666666', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092412465945\hazem emam mohamed.cleaned (1).pdf', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092412465945\DPW_IT_GL003_Secure Coding Guidlines_V1.0.cleaned (2).pdf', 2023092412465945, CAST(N'2023-09-24T12:59:00' AS SmallDateTime), NULL, NULL, N'Tamer Elsayed', N'PO-20230924124659')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.45-54', N'345', N'34', 34, N'35', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092501350165\Technical Documentation -  MTS - Seal Cut.docx', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092501350165\Technical Documentation -  ORACLE FUSION - Fix fraction issue in receipt.docx', 2023092501350165, CAST(N'2023-09-25T13:35:00' AS SmallDateTime), NULL, N'Shireen Samy', NULL, N'PO-20230925013501')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.88-87', N'sf', N'fsfs', 4343, N'43434', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092507254291\Technical Documentation -  CLMS.docx', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092507254291\Technical Documentation -  LogStar -  WeighBridge System.docx', 2023092507254291, CAST(N'2023-09-25T19:26:00' AS SmallDateTime), CAST(N'2023-09-25T22:27:00' AS SmallDateTime), N'Afnan Ramzy', N'Afnan Ramzy', N'PO-20230925072542')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.24-234', N'4324', N'234324', 24324, N'23424', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092508373110\Technical Documentation -  CFS -Broker Fingerprint registration & SMS notification system V II.docx', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092508373110\Technical Documentation -  VAS - CFS Line Hold-Fix.docx', 2023092508373110, CAST(N'2023-09-25T08:38:00' AS SmallDateTime), NULL, N'Shireen Samy', NULL, N'PO-20230925083731')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.32-312', N'gtesgs', N'gseg', 432, N'343242424', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092508422125\Technical Documentation -  VAS - Smart Gate Modification.docx', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092508422125\Technical Documentation -  VAS - MTS Modification.docx', 2023092508422125, CAST(N'2023-09-25T08:42:00' AS SmallDateTime), NULL, N'Shireen Samy', NULL, N'PO-20230925084221')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.98-98', N'fef', N'fesfes4', 423424, N'23424242', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092510465625\Technical Documentation -  EXPRESS - Solve Duplicated Trucker Invoices.docx', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092510465625\Technical Documentation -  MTS - Seal Cut.docx', 2023092510465625, CAST(N'2023-09-25T22:47:00' AS SmallDateTime), NULL, N'Afnan Ramzy', NULL, N'PO-20230925104656')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.98-98', N'fef', N'fesfes4', 423424, N'23424242', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092510473787\Technical Documentation -  EXPRESS - Solve Duplicated Trucker Invoices.docx', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092510473787\Technical Documentation -  MTS - Seal Cut.docx', 2023092510473787, CAST(N'2023-09-25T22:48:00' AS SmallDateTime), NULL, N'Afnan Ramzy', NULL, N'PO-20230925104737')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.86-97', N'fafsaf', N'fsdfsf', 42324, N'234242', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092510514561\Technical Documentation -  EXPRESS - LG Check.docx', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092510514561\Technical Documentation -  Online Payment Project - Trucker Invoices.docx', 2023092510514561, CAST(N'2023-09-25T22:52:00' AS SmallDateTime), NULL, N'Afnan Ramzy', NULL, N'PO-20230925105145')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.23-232', N'fsafddsf', N'fdsfgdsg', 5435, N'54353535', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092512281585\Technical Documentation -  VAS - Export Inspection.docx', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092512281585\Technical Documentation -  EXPRESS - LG Check.docx', 2023092512281585, CAST(N'2023-09-25T12:28:00' AS SmallDateTime), NULL, N'Shireen Samy', NULL, N'PO-20230925122815')
INSERT [dbo].[PoRequest] ([PoNumber], [PoDescription], [VendorName], [VendorNumber], [InvoiceNumber], [PoAttachmentPath], [InvoiceAttachmentPath], [RequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [RequestNumber]) VALUES (N'SOK.PO.87-97', N'scs', N'cscs', 424, N'4242424', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092608120404\Technical Documentation -  INSPECTIONS.docx', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\PoRequest\2023092608120404\Technical Documentation -  VAS - CFS Line Hold-Fix.docx', 2023092608120404, CAST(N'2023-09-26T20:12:00' AS SmallDateTime), CAST(N'2023-09-26T20:33:00' AS SmallDateTime), N'Shireen Samy', N'Shireen Samy', N'PO-20230926081204')
GO
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (201, 1, N'Pending', N'Vestibulum quam sapien, varius ut, blandit non, interdum in, ante. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio. Curabitur convallis. Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor.', N'1396', 10002, CAST(N'2023-08-30T00:00:00' AS SmallDateTime), CAST(N'2023-03-11T00:00:00' AS SmallDateTime), N'ccanadas0', N'aleaver0')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (202, 1, N'Pending', N'Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus. Curabitur at ipsum ac tellus semper interdum. Mauris ullamcorper purus sit amet nulla. Quisque arcu libero, rutrum ac, lobortis vel, dapibus at, diam. Nam tristique tortor eu pede.', N'1396', 10002, CAST(N'2022-09-28T00:00:00' AS SmallDateTime), CAST(N'2023-07-14T00:00:00' AS SmallDateTime), N'pdewinton1', N'cmckirdy1')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (203, 1, N'Pending', N'Morbi vel lectus in quam fringilla rhoncus. Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis. Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh. In quis justo. Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet.', N'1396', 10002, CAST(N'2023-07-16T00:00:00' AS SmallDateTime), CAST(N'2023-09-08T00:00:00' AS SmallDateTime), N'sgreenlees2', N'mfawdrie2')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (204, 1, N'Pending', N'Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat.', N'1396', 1, CAST(N'2023-08-26T00:00:00' AS SmallDateTime), CAST(N'2023-04-06T00:00:00' AS SmallDateTime), N'mwharby3', N'rdobbins3')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (205, 1, N'Pending', N'Suspendisse ornare consequat lectus. In est risus, auctor sed, tristique in, tempus sit amet, sem. Fusce consequat. Nulla nisl. Nunc nisl. Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus. Duis at velit eu est congue elementum. In hac habitasse platea dictumst. Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante.', N'1396', 1, CAST(N'2023-02-25T00:00:00' AS SmallDateTime), CAST(N'2023-03-31T00:00:00' AS SmallDateTime), N'edenham4', N'jbatrim4')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (206, 1, N'Pending', N'Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum. Aliquam non mauris. Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet.', N'1396', 1, CAST(N'2023-08-14T00:00:00' AS SmallDateTime), CAST(N'2023-02-19T00:00:00' AS SmallDateTime), N'wdawidman5', N'pwoodsford5')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (207, 1, N'Pending', N'Vivamus vestibulum sagittis sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Etiam vel augue. Vestibulum rutrum rutrum neque. Aenean auctor gravida sem. Praesent id massa id nisl venenatis lacinia. Aenean sit amet justo. Morbi ut odio. Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo.', N'1396', 1, CAST(N'2022-11-16T00:00:00' AS SmallDateTime), CAST(N'2022-10-14T00:00:00' AS SmallDateTime), N'jmoine6', N'hrunnett6')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (208, 1, N'Pending', N'Donec vitae nisi. Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus. Curabitur at ipsum ac tellus semper interdum. Mauris ullamcorper purus sit amet nulla.', N'1396', 1, CAST(N'2023-04-11T00:00:00' AS SmallDateTime), CAST(N'2023-07-13T00:00:00' AS SmallDateTime), N'scristea7', N'dlerohan7')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (209, 1, N'Pending', N'Mauris sit amet eros. Suspendisse accumsan tortor quis turpis. Sed ante. Vivamus tortor. Duis mattis egestas metus.', N'1396', 1, CAST(N'2023-01-04T00:00:00' AS SmallDateTime), CAST(N'2023-03-15T00:00:00' AS SmallDateTime), N'blattey8', N'slavell8')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (210, 1, N'Pending', N'Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis. Ut at dolor quis odio consequat varius. Integer ac leo. Pellentesque ultrices mattis odio. Donec vitae nisi.', N'1396', 1, CAST(N'2023-09-04T00:00:00' AS SmallDateTime), CAST(N'2023-03-07T00:00:00' AS SmallDateTime), N'ebreese9', N'mpesselt9')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (211, 1, N'Pending', N'Suspendisse potenti. In eleifend quam a odio. In hac habitasse platea dictumst. Maecenas ut massa quis augue luctus tincidunt. Nulla mollis molestie lorem. Quisque ut erat. Curabitur gravida nisi at nibh.', N'1396', 1, CAST(N'2023-09-09T00:00:00' AS SmallDateTime), CAST(N'2023-07-15T00:00:00' AS SmallDateTime), N'mgavozzia', N'aabthorpea')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (212, 1, N'Pending', N'Donec posuere metus vitae ipsum. Aliquam non mauris. Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet.', N'1396', 1, CAST(N'2023-06-04T00:00:00' AS SmallDateTime), CAST(N'2023-09-12T00:00:00' AS SmallDateTime), N'sposnettb', N'aportwaineb')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (213, 1, N'Pending', N'In hac habitasse platea dictumst. Maecenas ut massa quis augue luctus tincidunt. Nulla mollis molestie lorem.', N'1396', 1, CAST(N'2023-05-31T00:00:00' AS SmallDateTime), CAST(N'2023-05-15T00:00:00' AS SmallDateTime), N'kmcleodc', N'lbalhatchetc')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (215, 1, N'Pending', N'Nunc purus. Phasellus in felis. Donec semper sapien a libero. Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis. Ut at dolor quis odio consequat varius.', N'1396', 1, CAST(N'2022-09-27T00:00:00' AS SmallDateTime), CAST(N'2023-06-07T00:00:00' AS SmallDateTime), N'rfarakere', N'ejoddense')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (216, 1, N'Approved', N'Donec posuere metus vitae ipsum. Aliquam non mauris. Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis.', N'1396', 1, CAST(N'2023-05-14T00:00:00' AS SmallDateTime), CAST(N'2023-10-01T12:15:00' AS SmallDateTime), N'araynorf', N'Amr Asem')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (217, 1, N'Pending', N'In hac habitasse platea dictumst.', N'1396', 1, CAST(N'2023-05-24T00:00:00' AS SmallDateTime), CAST(N'2023-09-04T00:00:00' AS SmallDateTime), N'dfindleyg', N'tsaterthwaitg')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (218, 1, N'Pending', N'Praesent lectus. Vestibulum quam sapien, varius ut, blandit non, interdum in, ante. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio. Curabitur convallis. Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor. Morbi vel lectus in quam fringilla rhoncus. Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis. Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero.', N'1396', 1, CAST(N'2023-08-04T00:00:00' AS SmallDateTime), CAST(N'2023-07-04T00:00:00' AS SmallDateTime), N'dleggitth', N'hramelh')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (219, 1, N'Pending', N'Phasellus sit amet erat. Nulla tempus. Vivamus in felis eu sapien cursus vestibulum. Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy.', N'1396', 1, CAST(N'2022-11-26T00:00:00' AS SmallDateTime), CAST(N'2022-10-06T00:00:00' AS SmallDateTime), N'mstollenwercki', N'akoppi')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (220, 1, N'Pending', N'Nulla tempus. Vivamus in felis eu sapien cursus vestibulum. Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy. Integer non velit. Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue.', N'1396', 1, CAST(N'2022-11-14T00:00:00' AS SmallDateTime), CAST(N'2023-02-18T00:00:00' AS SmallDateTime), N'sliffj', N'mbendlej')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (221, 1, N'Pending', N'In hac habitasse platea dictumst. Etiam faucibus cursus urna. Ut tellus. Nulla ut erat id mauris vulputate elementum.', N'1396', 1, CAST(N'2023-09-03T00:00:00' AS SmallDateTime), CAST(N'2023-08-04T00:00:00' AS SmallDateTime), N'adriuttik', N'klucak')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (222, 1, N'Pending', N'Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus. Suspendisse potenti. In eleifend quam a odio.', N'1396', 1, CAST(N'2022-09-20T00:00:00' AS SmallDateTime), CAST(N'2022-11-25T00:00:00' AS SmallDateTime), N'bmettsl', N'mandresl')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (223, 1, N'Pending', N'Morbi non quam nec dui luctus rutrum. Nulla tellus. In sagittis dui vel nisl.', N'1396', 1, CAST(N'2023-07-19T00:00:00' AS SmallDateTime), CAST(N'2023-01-10T00:00:00' AS SmallDateTime), N'cmccurleym', N'mduffillm')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (224, 1, N'Pending', N'Phasellus sit amet erat. Nulla tempus. Vivamus in felis eu sapien cursus vestibulum. Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy.', N'1396', 1, CAST(N'2023-08-30T00:00:00' AS SmallDateTime), CAST(N'2023-02-16T00:00:00' AS SmallDateTime), N'rwalderan', N'eboothebien')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (225, 1, N'Pending', N'Vestibulum rutrum rutrum neque.', N'1396', 1, CAST(N'2022-11-09T00:00:00' AS SmallDateTime), CAST(N'2023-05-21T00:00:00' AS SmallDateTime), N'ahouldino', N'rcraiggo')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (226, 1, N'Pending', N'Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis. Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl. Nunc rhoncus dui vel sem. Sed sagittis. Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci.', N'1396', 1, CAST(N'2023-04-29T00:00:00' AS SmallDateTime), CAST(N'2022-12-14T00:00:00' AS SmallDateTime), N'rdantuonip', N'mabbessp')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (227, 1, N'Pending', N'Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante.', N'1396', 1, CAST(N'2023-08-09T00:00:00' AS SmallDateTime), CAST(N'2022-10-18T00:00:00' AS SmallDateTime), N'vpierucciq', N'vbernardotteq')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (229, 1, N'Pending', N'Suspendisse ornare consequat lectus. In est risus, auctor sed, tristique in, tempus sit amet, sem. Fusce consequat. Nulla nisl. Nunc nisl. Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus. Duis at velit eu est congue elementum.', N'1396', 1, CAST(N'2022-11-24T00:00:00' AS SmallDateTime), CAST(N'2023-05-20T00:00:00' AS SmallDateTime), N'cjanneys', N'larmatyss')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (230, 1, N'Pending', N'Aenean auctor gravida sem. Praesent id massa id nisl venenatis lacinia. Aenean sit amet justo. Morbi ut odio. Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo. In blandit ultrices enim. Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin interdum mauris non ligula pellentesque ultrices. Phasellus id sapien in sapien iaculis congue. Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl.', N'1396', 1, CAST(N'2023-03-26T00:00:00' AS SmallDateTime), CAST(N'2023-01-21T00:00:00' AS SmallDateTime), N'calecockt', N'cbrotherhoodt')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (231, 1, N'Pending', N'Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui. Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc.', N'1396', 1, CAST(N'2023-01-13T00:00:00' AS SmallDateTime), CAST(N'2022-10-12T00:00:00' AS SmallDateTime), N'sbaylieu', N'ktomasianu')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (232, 1, N'Pending', N'Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque. Duis bibendum. Morbi non quam nec dui luctus rutrum. Nulla tellus. In sagittis dui vel nisl.', N'1396', 1, CAST(N'2022-09-19T00:00:00' AS SmallDateTime), CAST(N'2023-08-24T00:00:00' AS SmallDateTime), N'msanjav', N'misaaksohnv')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (233, 1, N'Pending', N'Integer non velit. Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque. Duis bibendum. Morbi non quam nec dui luctus rutrum. Nulla tellus. In sagittis dui vel nisl. Duis ac nibh. Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus.', N'1396', 1, CAST(N'2022-11-04T00:00:00' AS SmallDateTime), CAST(N'2023-04-30T00:00:00' AS SmallDateTime), N'omantlew', N'mlapsleyw')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (234, 1, N'Pending', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin risus. Praesent lectus. Vestibulum quam sapien, varius ut, blandit non, interdum in, ante. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio. Curabitur convallis.', N'1396', 1, CAST(N'2022-11-08T00:00:00' AS SmallDateTime), CAST(N'2022-12-21T00:00:00' AS SmallDateTime), N'ndeevesx', N'migonetx')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (235, 1, N'Pending', N'Proin interdum mauris non ligula pellentesque ultrices.', N'1396', 1, CAST(N'2023-05-10T00:00:00' AS SmallDateTime), CAST(N'2022-12-02T00:00:00' AS SmallDateTime), N'kmatiebey', N'choundsony')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (236, 1, N'Pending', N'Aenean auctor gravida sem. Praesent id massa id nisl venenatis lacinia. Aenean sit amet justo.', N'1396', 1, CAST(N'2023-06-05T00:00:00' AS SmallDateTime), CAST(N'2022-10-03T00:00:00' AS SmallDateTime), N'omacroriez', N'rmcmychemz')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (237, 1, N'Pending', N'Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci.', N'1396', 10002, CAST(N'2022-11-10T00:00:00' AS SmallDateTime), CAST(N'2023-02-12T00:00:00' AS SmallDateTime), N'aperfect10', N'jissacoff10')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (238, 1, N'Pending', N'Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante. Nulla justo. Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros. Suspendisse accumsan tortor quis turpis. Sed ante. Vivamus tortor.', N'1396', 10002, CAST(N'2023-02-27T00:00:00' AS SmallDateTime), CAST(N'2023-01-28T00:00:00' AS SmallDateTime), N'ccasswell11', N'eband11')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (239, 1, N'Pending', N'Aenean fermentum.', N'1396', 1, CAST(N'2023-07-14T00:00:00' AS SmallDateTime), CAST(N'2023-02-15T00:00:00' AS SmallDateTime), N'lcockle12', N'eyedy12')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (240, 1, N'Pending', N'Nulla tempus. Vivamus in felis eu sapien cursus vestibulum. Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy.', N'1396', 1, CAST(N'2023-02-16T00:00:00' AS SmallDateTime), CAST(N'2023-03-23T00:00:00' AS SmallDateTime), N'rlennox13', N'zrealph13')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (241, 1, N'Pending', N'Vestibulum quam sapien, varius ut, blandit non, interdum in, ante. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio. Curabitur convallis. Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor.', N'1396', 10002, CAST(N'2022-09-23T00:00:00' AS SmallDateTime), CAST(N'2023-03-30T00:00:00' AS SmallDateTime), N'atremollet14', N'sgiacobillo14')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (242, 1, N'Pending', N'Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis. Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh. In quis justo. Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet. Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo.', N'1396', 1, CAST(N'2022-10-20T00:00:00' AS SmallDateTime), CAST(N'2023-01-11T00:00:00' AS SmallDateTime), N'btenman15', N'ncamacho15')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (243, 1, N'Pending', N'Ut at dolor quis odio consequat varius. Integer ac leo. Pellentesque ultrices mattis odio. Donec vitae nisi. Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus. Curabitur at ipsum ac tellus semper interdum. Mauris ullamcorper purus sit amet nulla.', N'1396', 10002, CAST(N'2022-10-22T00:00:00' AS SmallDateTime), CAST(N'2023-07-20T00:00:00' AS SmallDateTime), N'eadamini16', N'awedmore16')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (244, 1, N'Pending', N'Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus. Phasellus in felis. Donec semper sapien a libero. Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis.', N'1396', 1, CAST(N'2023-01-15T00:00:00' AS SmallDateTime), CAST(N'2022-11-06T00:00:00' AS SmallDateTime), N'iambroix17', N'leitter17')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (245, 1, N'Pending', N'Sed accumsan felis. Ut at dolor quis odio consequat varius. Integer ac leo. Pellentesque ultrices mattis odio. Donec vitae nisi. Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus.', N'1396', 1, CAST(N'2023-03-09T00:00:00' AS SmallDateTime), CAST(N'2023-01-24T00:00:00' AS SmallDateTime), N'fsidworth18', N'vferrandez18')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (246, 1, N'Pending', N'Quisque ut erat. Curabitur gravida nisi at nibh. In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat.', N'1396', 1, CAST(N'2023-03-19T00:00:00' AS SmallDateTime), CAST(N'2023-04-12T00:00:00' AS SmallDateTime), N'wcheevers19', N'mmontel19')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (248, 1, N'Pending', N'Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante. Nulla justo.', N'1396', 1, CAST(N'2023-07-12T00:00:00' AS SmallDateTime), CAST(N'2022-10-18T00:00:00' AS SmallDateTime), N'smountford1b', N'bspeed1b')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (249, 1, N'Pending', N'Quisque porta volutpat erat. Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus. Phasellus in felis. Donec semper sapien a libero. Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla.', N'1396', 1, CAST(N'2023-09-17T00:00:00' AS SmallDateTime), CAST(N'2023-07-24T00:00:00' AS SmallDateTime), N'kbarz1c', N'cvicar1c')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (250, 1, N'Pending', N'Aliquam erat volutpat. In congue. Etiam justo. Etiam pretium iaculis justo. In hac habitasse platea dictumst.', N'1396', 1, CAST(N'2022-09-29T00:00:00' AS SmallDateTime), CAST(N'2023-07-24T00:00:00' AS SmallDateTime), N'spigne1d', N'relcom1d')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (251, 1, N'Pending', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin interdum mauris non ligula pellentesque ultrices. Phasellus id sapien in sapien iaculis congue. Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl. Aenean lectus. Pellentesque eget nunc.', N'1396', 1, CAST(N'2023-06-29T00:00:00' AS SmallDateTime), CAST(N'2022-12-20T00:00:00' AS SmallDateTime), N'traithbie1e', N'abordiss1e')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (252, 1, N'Pending', N'Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue. Aliquam erat volutpat. In congue. Etiam justo. Etiam pretium iaculis justo. In hac habitasse platea dictumst. Etiam faucibus cursus urna. Ut tellus. Nulla ut erat id mauris vulputate elementum. Nullam varius.', N'1396', 1, CAST(N'2022-09-19T00:00:00' AS SmallDateTime), CAST(N'2023-08-04T00:00:00' AS SmallDateTime), N'gcrofts1f', N'msomerled1f')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (253, 1, N'Pending', N'Aliquam erat volutpat. In congue. Etiam justo. Etiam pretium iaculis justo. In hac habitasse platea dictumst. Etiam faucibus cursus urna.', N'1396', 1, CAST(N'2023-06-11T00:00:00' AS SmallDateTime), CAST(N'2023-08-08T00:00:00' AS SmallDateTime), N'bbtham1g', N'avinas1g')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (254, 1, N'Pending', N'Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis. Ut at dolor quis odio consequat varius. Integer ac leo. Pellentesque ultrices mattis odio. Donec vitae nisi. Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus.', N'1396', 1, CAST(N'2023-02-13T00:00:00' AS SmallDateTime), CAST(N'2022-12-22T00:00:00' AS SmallDateTime), N'pwillison1h', N'fwyllis1h')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (255, 1, N'Pending', N'Integer ac neque. Duis bibendum. Morbi non quam nec dui luctus rutrum. Nulla tellus. In sagittis dui vel nisl. Duis ac nibh. Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus. Suspendisse potenti. In eleifend quam a odio. In hac habitasse platea dictumst.', N'1396', 1, CAST(N'2023-07-02T00:00:00' AS SmallDateTime), CAST(N'2023-01-14T00:00:00' AS SmallDateTime), N'gtuther1i', N'mhalden1i')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (256, 1, N'Pending', N'Suspendisse potenti. Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum. Aliquam non mauris. Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis. Fusce posuere felis sed lacus.', N'1396', 1, CAST(N'2023-05-31T00:00:00' AS SmallDateTime), CAST(N'2023-07-10T00:00:00' AS SmallDateTime), N'lgrealey1j', N'jfoxley1j')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (257, 1, N'Pending', N'In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy. Integer non velit. Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque. Duis bibendum.', N'1396', 1, CAST(N'2023-04-01T00:00:00' AS SmallDateTime), CAST(N'2022-11-20T00:00:00' AS SmallDateTime), N'dmacmakin1k', N'ewharby1k')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (258, 1, N'Pending', N'Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis. Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl. Nunc rhoncus dui vel sem. Sed sagittis. Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus. Pellentesque at nulla.', N'1396', 1, CAST(N'2023-08-01T00:00:00' AS SmallDateTime), CAST(N'2023-07-21T00:00:00' AS SmallDateTime), N'csyder1l', N'otolan1l')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (259, 1, N'Pending', N'Praesent blandit.', N'1396', 1, CAST(N'2023-06-18T00:00:00' AS SmallDateTime), CAST(N'2023-03-17T00:00:00' AS SmallDateTime), N'ncrum1m', N'pcallendar1m')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (260, 1, N'Pending', N'Mauris sit amet eros. Suspendisse accumsan tortor quis turpis. Sed ante. Vivamus tortor. Duis mattis egestas metus. Aenean fermentum. Donec ut mauris eget massa tempor convallis. Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh. Quisque id justo sit amet sapien dignissim vestibulum.', N'1396', 1, CAST(N'2023-06-20T00:00:00' AS SmallDateTime), CAST(N'2023-06-03T00:00:00' AS SmallDateTime), N'ascathard1n', N'ccastanone1n')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (261, 1, N'Pending', N'Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui. Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti.', N'1396', 1, CAST(N'2023-07-12T00:00:00' AS SmallDateTime), CAST(N'2023-07-18T00:00:00' AS SmallDateTime), N'ldannohl1o', N'mtabourin1o')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (262, 1, N'Pending', N'Vivamus vestibulum sagittis sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Etiam vel augue. Vestibulum rutrum rutrum neque.', N'1396', 1, CAST(N'2023-07-24T00:00:00' AS SmallDateTime), CAST(N'2023-04-24T00:00:00' AS SmallDateTime), N'swooderson1p', N'btildesley1p')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (263, 1, N'Pending', N'Sed accumsan felis. Ut at dolor quis odio consequat varius. Integer ac leo. Pellentesque ultrices mattis odio. Donec vitae nisi. Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus.', N'1396', 1, CAST(N'2022-10-10T00:00:00' AS SmallDateTime), CAST(N'2023-07-08T00:00:00' AS SmallDateTime), N'mhuerta1q', N'ndunleavy1q')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (264, 1, N'Pending', N'Quisque ut erat. Curabitur gravida nisi at nibh. In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat.', N'1396', 1, CAST(N'2023-01-28T00:00:00' AS SmallDateTime), CAST(N'2022-11-10T00:00:00' AS SmallDateTime), N'cmeneyer1r', N'lgiorgini1r')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (265, 1, N'Pending', N'Nulla suscipit ligula in lacus. Curabitur at ipsum ac tellus semper interdum. Mauris ullamcorper purus sit amet nulla.', N'1396', 1, CAST(N'2023-04-29T00:00:00' AS SmallDateTime), CAST(N'2023-03-19T00:00:00' AS SmallDateTime), N'ggelly1s', N'rkeam1s')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (267, 1, N'Pending', N'Aenean sit amet justo. Morbi ut odio. Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo. In blandit ultrices enim.', N'1396', 1, CAST(N'2023-01-15T00:00:00' AS SmallDateTime), CAST(N'2023-04-18T00:00:00' AS SmallDateTime), N'mblaschek1u', N'gaitkenhead1u')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (268, 1, N'Pending', N'Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor.', N'1396', 1, CAST(N'2023-02-04T00:00:00' AS SmallDateTime), CAST(N'2023-01-18T00:00:00' AS SmallDateTime), N'alerwell1v', N'mspindler1v')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (269, 1, N'Pending', N'Nulla justo. Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros. Suspendisse accumsan tortor quis turpis.', N'1396', 1, CAST(N'2023-05-19T00:00:00' AS SmallDateTime), CAST(N'2023-07-02T00:00:00' AS SmallDateTime), N'bpadrick1w', N'jsisley1w')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (270, 1, N'Pending', N'Quisque porta volutpat erat.', N'1396', 1, CAST(N'2022-10-25T00:00:00' AS SmallDateTime), CAST(N'2023-04-09T00:00:00' AS SmallDateTime), N'gkumar1x', N'gmellonby1x')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (271, 1, N'Pending', N'Nulla facilisi. Cras non velit nec nisi vulputate nonummy. Maecenas tincidunt lacus at velit. Vivamus vel nulla eget eros elementum pellentesque. Quisque porta volutpat erat. Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus. Phasellus in felis. Donec semper sapien a libero. Nam dui.', N'1396', 1, CAST(N'2022-09-26T00:00:00' AS SmallDateTime), CAST(N'2022-09-21T00:00:00' AS SmallDateTime), N'pmuscat1y', N'bwhettleton1y')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (272, 1, N'Pending', N'Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis. Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl. Nunc rhoncus dui vel sem. Sed sagittis. Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus.', N'1396', 1, CAST(N'2023-09-04T00:00:00' AS SmallDateTime), CAST(N'2022-11-13T00:00:00' AS SmallDateTime), N'rneicho1z', N'egoodayle1z')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (273, 1, N'Pending', N'Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est. Phasellus sit amet erat. Nulla tempus.', N'1396', 1, CAST(N'2023-06-05T00:00:00' AS SmallDateTime), CAST(N'2023-06-10T00:00:00' AS SmallDateTime), N'lbullocke20', N'pingraham20')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (274, 1, N'Pending', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin interdum mauris non ligula pellentesque ultrices. Phasellus id sapien in sapien iaculis congue. Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl. Aenean lectus. Pellentesque eget nunc. Donec quis orci eget orci vehicula condimentum.', N'1396', 1, CAST(N'2023-08-20T00:00:00' AS SmallDateTime), CAST(N'2023-04-17T00:00:00' AS SmallDateTime), N'dwoods21', N'acruise21')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (275, 1, N'Pending', N'Curabitur gravida nisi at nibh. In hac habitasse platea dictumst.', N'1396', 1, CAST(N'2023-06-15T00:00:00' AS SmallDateTime), CAST(N'2023-09-09T00:00:00' AS SmallDateTime), N'cblazeby22', N'cmaccahey22')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (276, 1, N'Pending', N'Phasellus sit amet erat. Nulla tempus. Vivamus in felis eu sapien cursus vestibulum. Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc.', N'1396', 1, CAST(N'2023-09-09T00:00:00' AS SmallDateTime), CAST(N'2022-11-14T00:00:00' AS SmallDateTime), N'jdjurdjevic23', N'dcoppens23')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (277, 1, N'Pending', N'Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti. Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum. Aliquam non mauris.', N'1396', 1, CAST(N'2023-01-17T00:00:00' AS SmallDateTime), CAST(N'2023-07-25T00:00:00' AS SmallDateTime), N'hmccudden24', N'gayres24')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (278, 1, N'Pending', N'Nulla nisl. Nunc nisl. Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa.', N'1396', 1, CAST(N'2023-04-29T00:00:00' AS SmallDateTime), CAST(N'2023-09-02T00:00:00' AS SmallDateTime), N'wreuter25', N'chundey25')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (279, 1, N'Pending', N'Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat. Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede.', N'1396', 1, CAST(N'2023-08-17T00:00:00' AS SmallDateTime), CAST(N'2022-12-30T00:00:00' AS SmallDateTime), N'cpeterson26', N'klaw26')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (280, 1, N'Pending', N'Donec quis orci eget orci vehicula condimentum. Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est. Phasellus sit amet erat. Nulla tempus.', N'1396', 1, CAST(N'2023-03-02T00:00:00' AS SmallDateTime), CAST(N'2023-01-26T00:00:00' AS SmallDateTime), N'jchrishop27', N'cpavic27')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (281, 1, N'Pending', N'Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat. Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede. Morbi porttitor lorem id ligula.', N'1396', 1, CAST(N'2023-06-30T00:00:00' AS SmallDateTime), CAST(N'2022-12-12T00:00:00' AS SmallDateTime), N'hkohter28', N'kborne28')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (282, 1, N'Pending', N'Curabitur gravida nisi at nibh. In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat. Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede. Morbi porttitor lorem id ligula.', N'1396', 1, CAST(N'2023-05-05T00:00:00' AS SmallDateTime), CAST(N'2023-03-07T00:00:00' AS SmallDateTime), N'bsandells29', N'fdaniely29')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (283, 1, N'Pending', N'Integer a nibh.', N'1396', 1, CAST(N'2022-12-16T00:00:00' AS SmallDateTime), CAST(N'2023-02-03T00:00:00' AS SmallDateTime), N'hnewband2a', N'gplumley2a')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (284, 1, N'Pending', N'In congue. Etiam justo. Etiam pretium iaculis justo. In hac habitasse platea dictumst. Etiam faucibus cursus urna.', N'1396', 1, CAST(N'2023-04-25T00:00:00' AS SmallDateTime), CAST(N'2023-01-01T00:00:00' AS SmallDateTime), N'rhartburn2b', N'uwyant2b')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (285, 1, N'Pending', N'Integer non velit. Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque. Duis bibendum. Morbi non quam nec dui luctus rutrum. Nulla tellus. In sagittis dui vel nisl. Duis ac nibh.', N'1396', 1, CAST(N'2023-04-17T00:00:00' AS SmallDateTime), CAST(N'2023-04-08T00:00:00' AS SmallDateTime), N'cnoe2c', N'lhamlin2c')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (286, 1, N'Pending', N'Nulla facilisi.', N'1396', 1, CAST(N'2022-11-30T00:00:00' AS SmallDateTime), CAST(N'2022-09-27T00:00:00' AS SmallDateTime), N'gtrebble2d', N'bpaliser2d')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (287, 1, N'Pending', N'Suspendisse potenti. Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum.', N'1396', 1, CAST(N'2023-01-14T00:00:00' AS SmallDateTime), CAST(N'2023-03-10T00:00:00' AS SmallDateTime), N'cellwand2e', N'neam2e')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (288, 1, N'Pending', N'Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh. In quis justo. Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet. Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam.', N'1396', 1, CAST(N'2023-01-04T00:00:00' AS SmallDateTime), CAST(N'2022-10-02T00:00:00' AS SmallDateTime), N'preeday2f', N'ggillcrist2f')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (289, 1, N'Pending', N'Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh.', N'1396', 1, CAST(N'2023-09-06T00:00:00' AS SmallDateTime), CAST(N'2023-09-01T00:00:00' AS SmallDateTime), N'sdeere2g', N'wabadam2g')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (290, 1, N'Pending', N'Nulla nisl. Nunc nisl. Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus.', N'1396', 1, CAST(N'2022-10-27T00:00:00' AS SmallDateTime), CAST(N'2022-09-20T00:00:00' AS SmallDateTime), N'ppitceathly2h', N'kpaumier2h')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (291, 1, N'Pending', N'Nulla justo. Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros. Suspendisse accumsan tortor quis turpis. Sed ante.', N'1396', 1, CAST(N'2023-01-23T00:00:00' AS SmallDateTime), CAST(N'2022-10-25T00:00:00' AS SmallDateTime), N'crounds2i', N'hatwill2i')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (292, 1, N'Pending', N'In est risus, auctor sed, tristique in, tempus sit amet, sem. Fusce consequat. Nulla nisl. Nunc nisl. Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus. Duis at velit eu est congue elementum.', N'1396', 1, CAST(N'2023-05-04T00:00:00' AS SmallDateTime), CAST(N'2022-10-27T00:00:00' AS SmallDateTime), N'asymper2j', N'gschindler2j')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (293, 1, N'Pending', N'Phasellus id sapien in sapien iaculis congue. Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl. Aenean lectus.', N'1396', 1, CAST(N'2023-02-23T00:00:00' AS SmallDateTime), CAST(N'2023-07-18T00:00:00' AS SmallDateTime), N'jstallard2k', N'msheaber2k')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (294, 1, N'Pending', N'Etiam vel augue. Vestibulum rutrum rutrum neque. Aenean auctor gravida sem. Praesent id massa id nisl venenatis lacinia. Aenean sit amet justo.', N'1396', 1, CAST(N'2022-10-27T00:00:00' AS SmallDateTime), CAST(N'2023-08-22T00:00:00' AS SmallDateTime), N'klemarquis2l', N'hgrewer2l')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (295, 1, N'Pending', N'Praesent id massa id nisl venenatis lacinia. Aenean sit amet justo. Morbi ut odio. Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo. In blandit ultrices enim. Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin interdum mauris non ligula pellentesque ultrices. Phasellus id sapien in sapien iaculis congue.', N'1396', 1, CAST(N'2022-11-24T00:00:00' AS SmallDateTime), CAST(N'2023-06-24T00:00:00' AS SmallDateTime), N'abamborough2m', N'epaske2m')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (296, 1, N'Pending', N'Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis. Fusce posuere felis sed lacus.', N'1396', 1, CAST(N'2022-11-23T00:00:00' AS SmallDateTime), CAST(N'2023-05-13T00:00:00' AS SmallDateTime), N'scotter2n', N'dmacconnechie2n')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (297, 1, N'Pending', N'Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis. Ut at dolor quis odio consequat varius. Integer ac leo. Pellentesque ultrices mattis odio. Donec vitae nisi. Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus.', N'1396', 1, CAST(N'2023-01-25T00:00:00' AS SmallDateTime), CAST(N'2022-12-12T00:00:00' AS SmallDateTime), N'hmottram2o', N'ncottesford2o')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (298, 1, N'Pending', N'Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus. Suspendisse potenti. In eleifend quam a odio.', N'1396', 1, CAST(N'2023-05-26T00:00:00' AS SmallDateTime), CAST(N'2023-07-06T00:00:00' AS SmallDateTime), N'smessitt2p', N'kjohnsee2p')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (299, 1, N'Pending', N'Cras in purus eu magna vulputate luctus. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vivamus vestibulum sagittis sapien.', N'1396', 1, CAST(N'2023-07-12T00:00:00' AS SmallDateTime), CAST(N'2023-08-29T00:00:00' AS SmallDateTime), N'aeldershaw2q', N'lechalie2q')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (302, 1, N'Pending', NULL, N'1396', 1, CAST(N'2023-09-20T20:17:00' AS SmallDateTime), NULL, N'procurement_manager', NULL)
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092009104220, 1, N'Pending', NULL, N'1396', 1, CAST(N'2023-09-20T21:11:00' AS SmallDateTime), CAST(N'2023-09-20T22:52:00' AS SmallDateTime), N'procurment_manager', N'procurment_manager')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092009521968, 1, N'Pending', NULL, N'1396', 1, CAST(N'2023-09-20T21:52:00' AS SmallDateTime), NULL, N'procurment_manager', NULL)
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092103022776, 0, N'Declined', NULL, N'1396', 1, CAST(N'2023-09-21T15:03:00' AS SmallDateTime), CAST(N'2023-09-21T15:06:00' AS SmallDateTime), N'Tamer Elsayed', N'finance_manager')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092103122026, 1, N'Approved', NULL, N'1396', 1, CAST(N'2023-09-21T15:12:00' AS SmallDateTime), CAST(N'2023-09-21T15:13:00' AS SmallDateTime), N'Tamer Elsayed', N'Mustafa Sultan')
GO
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092103300594, 1, N'Pending', NULL, N'1396', 1, CAST(N'2023-09-21T15:30:00' AS SmallDateTime), NULL, N'Tamer Elsayed', NULL)
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092303273296, 2, N'', NULL, N'1396', 1, CAST(N'2023-09-23T15:28:00' AS SmallDateTime), CAST(N'2023-09-23T15:30:00' AS SmallDateTime), N'Tamer Elsayed', N'Tamer Elsayed')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092303464478, 1, N'Declined', NULL, N'1396', 1, CAST(N'2023-09-23T15:47:00' AS SmallDateTime), CAST(N'2023-09-23T15:51:00' AS SmallDateTime), N'Tamer Elsayed', N'Tamer Elsayed')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092304214266, 1, N'Pending', NULL, N'1396', 1, CAST(N'2023-09-23T16:22:00' AS SmallDateTime), NULL, N'Tamer Elsayed', NULL)
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092311405101, 2, N'Declined', NULL, N'1396', 1, CAST(N'2023-09-23T11:41:00' AS SmallDateTime), CAST(N'2023-09-23T11:53:00' AS SmallDateTime), N'Tamer Elsayed', NULL)
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092312383635, 2, N'Declined', NULL, N'1396', 1, CAST(N'2023-09-23T12:39:00' AS SmallDateTime), CAST(N'2023-09-23T12:41:00' AS SmallDateTime), N'Tamer Elsayed', NULL)
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092401520199, 1, N'Pending', NULL, N'1396', 1, CAST(N'2023-09-24T13:52:00' AS SmallDateTime), NULL, N'Shireen Samy', NULL)
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092402501896, 1, N'Pending', NULL, N'1396', 1, CAST(N'2023-09-24T14:50:00' AS SmallDateTime), NULL, N'Shireen Samy', NULL)
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092407501144, 1, N'Pending', NULL, N'1396', 1, CAST(N'2023-09-24T19:50:00' AS SmallDateTime), CAST(N'2023-09-25T13:22:00' AS SmallDateTime), N'Shireen Samy', N'Shireen Samy')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092408082616, 1, N'Declined', N'65656565', N'1396', 1, CAST(N'2023-09-24T20:08:00' AS SmallDateTime), CAST(N'2023-09-24T20:14:00' AS SmallDateTime), N'Tamer Elsayed', N'Tamer Elsayed')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092408461019, 1, N'Declined', N'876r', N'1396', 1, CAST(N'2023-09-24T20:46:00' AS SmallDateTime), NULL, N'Tamer Elsayed', NULL)
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092409160738, 1, N'Declined', NULL, N'1396', 1, CAST(N'2023-09-24T21:16:00' AS SmallDateTime), NULL, N'Shireen Samy', NULL)
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092409363271, 1, N'Pending', NULL, N'1396', 1, CAST(N'2023-09-24T21:37:00' AS SmallDateTime), CAST(N'2023-09-24T21:58:00' AS SmallDateTime), N'Shireen Samy', N'Shireen Samy')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092411313243, 1, N'Pending', NULL, N'1396', 1, CAST(N'2023-09-24T23:32:00' AS SmallDateTime), NULL, N'Shireen Samy', NULL)
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092412035534, 1, N'Declined', N'65656565', N'1396', 1, CAST(N'2023-09-24T12:04:00' AS SmallDateTime), CAST(N'2023-09-24T20:56:00' AS SmallDateTime), N'Tamer Elsayed', N'Tamer Elsayed')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092412465945, 1, N'Declined', NULL, N'1396', 1, CAST(N'2023-09-24T12:47:00' AS SmallDateTime), CAST(N'2023-09-24T12:56:00' AS SmallDateTime), N'Tamer Elsayed', N'Tamer Elsayed')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092501350165, 1, N'Pending', N'sgseg', N'1396', 10002, CAST(N'2023-09-25T13:35:00' AS SmallDateTime), NULL, N'Shireen Samy', NULL)
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092507254291, 1, N'Pending', NULL, N'1396', 10002, CAST(N'2023-09-25T19:26:00' AS SmallDateTime), CAST(N'2023-09-25T22:27:00' AS SmallDateTime), N'Afnan Ramzy', N'Afnan Ramzy')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092508373110, 1, N'Pending', NULL, N'1396', 10002, CAST(N'2023-09-25T08:38:00' AS SmallDateTime), NULL, N'Shireen Samy', NULL)
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092508422125, 1, N'Pending', NULL, N'1396', 10002, CAST(N'2023-09-25T08:42:00' AS SmallDateTime), NULL, N'Shireen Samy', NULL)
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092510465625, 1, N'Pending', NULL, N'1396', 10002, CAST(N'2023-09-25T22:47:00' AS SmallDateTime), NULL, N'Afnan Ramzy', NULL)
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092510473787, 1, N'Pending', NULL, N'1396', 10002, CAST(N'2023-09-25T22:48:00' AS SmallDateTime), NULL, N'Afnan Ramzy', NULL)
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092510514561, 1, N'Pending', NULL, N'1396', 10002, CAST(N'2023-09-25T22:52:00' AS SmallDateTime), NULL, N'Afnan Ramzy', NULL)
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092512281585, 1, N'Pending', N'sgsedg', N'1396', 10002, CAST(N'2023-09-25T12:28:00' AS SmallDateTime), NULL, N'Shireen Samy', NULL)
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092608120404, 1, N'Approved', N'fdsew', N'51588', 10002, CAST(N'2023-09-26T20:12:00' AS SmallDateTime), CAST(N'2023-09-26T20:38:00' AS SmallDateTime), N'Shireen Samy', N'Alaa Hamad')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092711241573, 1, N'Pending', N'kefy kedyu', N'1396', 10002, CAST(N'2023-09-27T11:24:00' AS SmallDateTime), NULL, N'Rewan Hosny', NULL)
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092711243793, 1, N'Pending', N'kefy kedyu', N'1396', 10002, CAST(N'2023-09-27T11:26:00' AS SmallDateTime), NULL, N'Rewan Hosny', NULL)
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092711332214, 1, N'Pending', N'LuggageDescription ', N'1396', 10002, CAST(N'2023-09-27T11:33:00' AS SmallDateTime), NULL, N'Rewan Hosny', NULL)
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092711434278, 1, N'Pending', N'malaksh feeh', N'1396', 10002, CAST(N'2023-09-27T11:44:00' AS SmallDateTime), CAST(N'2023-09-27T11:53:00' AS SmallDateTime), N'Rewan Hosny', N'Rewan Hosny')
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023093001511959, 1, N'Pending', N'test', N'1396', 10002, CAST(N'2023-09-30T13:51:00' AS SmallDateTime), NULL, N'Rewan Hosny', NULL)
INSERT [dbo].[Request] ([Id], [CurrentStage], [Status], [Justification], [CreatorId], [DefinedRequestId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023100111282815, 1, N'Pending', N'hugf', N'1396', 10002, CAST(N'2023-10-01T11:28:00' AS SmallDateTime), CAST(N'2023-10-01T12:33:00' AS SmallDateTime), N'Rewan Hosny', N'Rewan Hosny')
GO
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (216, N'50128', N'Amr Asem', N'Finance Reviewer1', 1, N'Basic', N'Approved', N'', CAST(N'2023-03-11T00:00:00' AS SmallDateTime), CAST(N'2023-10-01T12:15:00' AS SmallDateTime), NULL, N'Amr Asem')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (216, N'50136', N'Amr Asem', N'Finance Reviewer2', 1, N'Basic', N'Approved', N'', CAST(N'2023-04-17T00:00:00' AS SmallDateTime), CAST(N'2023-10-01T12:15:00' AS SmallDateTime), NULL, N'Amr Asem')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (230, N'51331', NULL, N'Beneficiary Department Manager', 1, N'DepartmentManager', N'Pending', N'donec pharetra magna vestibulum aliquet ultrices erat tortor sollicitudin mi sit amet', CAST(N'2023-01-03T00:00:00' AS SmallDateTime), CAST(N'2023-01-03T00:00:00' AS SmallDateTime), N'gcastelinj', N'bmallabundj')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (231, N'51124', NULL, N'Finance Reviewer', 1, N'Basic', N'Declined', N'amet consectetuer adipiscing elit proin interdum mauris non ligula pellentesque ultrices phasellus id sapien in sapien', CAST(N'2023-08-28T00:00:00' AS SmallDateTime), CAST(N'2023-05-19T00:00:00' AS SmallDateTime), N'naspinal4', N'lyo4')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (232, N'51124', NULL, N'Finance Reviewer', 1, N'Basic', N'Approved', N'ridiculus mus etiam vel augue vestibulum rutrum rutrum neque aenean auctor gravida sem', CAST(N'2023-08-25T00:00:00' AS SmallDateTime), CAST(N'2023-05-23T00:00:00' AS SmallDateTime), N'iwarhurst1g', N'direland1g')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (235, N'51124', NULL, N'Finance Reviewer', 1, N'Basic', N'Declined', N'ut ultrices vel augue vestibulum ante ipsum primis in faucibus orci luctus', CAST(N'2023-01-06T00:00:00' AS SmallDateTime), CAST(N'2023-08-07T00:00:00' AS SmallDateTime), N'gblaydon2e', N'ladami2e')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (236, N'51124', NULL, N'Finance Reviewer', 1, N'Basic', N'Declined', N'pretium nisl ut volutpat sapien arcu sed augue aliquam erat volutpat in congue etiam justo etiam pretium', CAST(N'2023-07-21T00:00:00' AS SmallDateTime), CAST(N'2023-06-03T00:00:00' AS SmallDateTime), N'gjahnke1o', N'hvidler1o')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (237, N'51124', NULL, N'Finance Reviewer', 1, N'Basic', N'Approved', N'eget rutrum at lorem integer tincidunt ante vel ipsum praesent blandit lacinia erat vestibulum sed magna at', CAST(N'2023-04-18T00:00:00' AS SmallDateTime), CAST(N'2023-01-08T00:00:00' AS SmallDateTime), N'ahasluma', N'palloma')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (238, N'51124', NULL, N'Finance Reviewer', 1, N'Basic', N'Approved', N'nulla nisl nunc nisl duis bibendum felis sed interdum venenatis turpis enim blandit mi in', CAST(N'2022-10-02T00:00:00' AS SmallDateTime), CAST(N'2023-07-11T00:00:00' AS SmallDateTime), N'rleggana', N'tgoodbairna')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (239, N'51124', NULL, N'Finance Reviewer', 1, N'Basic', N'Declined', N'nulla ac enim in tempor turpis nec euismod scelerisque quam turpis adipiscing lorem vitae mattis nibh ligula', CAST(N'2023-04-27T00:00:00' AS SmallDateTime), CAST(N'2023-01-09T00:00:00' AS SmallDateTime), N'lvannet10', N'aneames10')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (241, N'50269', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', N'feugiat non pretium quis lectus suspendisse potenti in eleifend quam a odio in hac habitasse platea', CAST(N'2022-10-22T00:00:00' AS SmallDateTime), CAST(N'2022-12-01T00:00:00' AS SmallDateTime), N'fnickels1p', N'eskullet1p')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (246, N'50269', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', N'duis faucibus accumsan odio curabitur convallis duis consequat dui nec nisi volutpat eleifend donec ut dolor morbi vel', CAST(N'2023-01-11T00:00:00' AS SmallDateTime), CAST(N'2022-11-27T00:00:00' AS SmallDateTime), N'sgronallerq', N'agrenshieldsq')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (249, N'50269', NULL, N'Finance Reviewer', 1, N'Basic', N'Declined', N'viverra diam vitae quam suspendisse potenti nullam porttitor lacus at turpis donec posuere metus vitae ipsum aliquam', CAST(N'2023-06-16T00:00:00' AS SmallDateTime), CAST(N'2022-11-02T00:00:00' AS SmallDateTime), N'smcghee3', N'aridgley3')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (251, N'50269', NULL, N'Finance Reviewer', 1, N'Basic', N'Declined', N'metus arcu adipiscing molestie hendrerit at vulputate vitae nisl aenean lectus pellentesque', CAST(N'2023-03-13T00:00:00' AS SmallDateTime), CAST(N'2023-02-28T00:00:00' AS SmallDateTime), N'calban9', N'ntuson9')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (252, N'55887', NULL, N'Finance Reviewer', 1, N'Basic', N'Declined', N'nunc proin at turpis a pede posuere nonummy integer non velit donec diam', CAST(N'2023-02-26T00:00:00' AS SmallDateTime), CAST(N'2023-04-21T00:00:00' AS SmallDateTime), N'mmitchesont', N'hradket')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (253, N'55887', NULL, N'Finance Reviewer', 1, N'Basic', N'Approved', N'primis in faucibus orci luctus et ultrices posuere cubilia curae nulla dapibus dolor vel est donec odio', CAST(N'2022-12-27T00:00:00' AS SmallDateTime), CAST(N'2023-01-12T00:00:00' AS SmallDateTime), N'agilhouley14', N'acarrabott14')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (255, N'55887', NULL, N'Finance Reviewer', 1, N'Basic', N'Approved', N'parturient montes nascetur ridiculus mus vivamus vestibulum sagittis sapien cum sociis natoque penatibus et', CAST(N'2022-12-21T00:00:00' AS SmallDateTime), CAST(N'2022-11-06T00:00:00' AS SmallDateTime), N'smcgivenk', N'zmokesk')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (256, N'55887', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', N'tempor turpis nec euismod scelerisque quam turpis adipiscing lorem vitae mattis nibh ligula nec sem', CAST(N'2022-09-26T00:00:00' AS SmallDateTime), CAST(N'2023-09-05T00:00:00' AS SmallDateTime), N'bwanstall17', N'mpuddle17')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (257, N'55887', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', N'leo pellentesque ultrices mattis odio donec vitae nisi nam ultrices libero non mattis pulvinar nulla pede ullamcorper', CAST(N'2023-05-23T00:00:00' AS SmallDateTime), CAST(N'2023-04-30T00:00:00' AS SmallDateTime), N'rgooday16', N'kcawsby16')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (260, N'55887', NULL, N'Finance Reviewer', 1, N'Basic', N'Declined', N'posuere cubilia curae nulla dapibus dolor vel est donec odio justo sollicitudin ut suscipit a feugiat et', CAST(N'2023-08-28T00:00:00' AS SmallDateTime), CAST(N'2023-02-02T00:00:00' AS SmallDateTime), N'erobiot15', N'aquest15')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (264, N'55887', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', N'vestibulum velit id pretium iaculis diam erat fermentum justo nec condimentum neque sapien placerat ante nulla justo', CAST(N'2023-01-29T00:00:00' AS SmallDateTime), CAST(N'2023-08-22T00:00:00' AS SmallDateTime), N'bwortman2n', N'scuppitt2n')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (267, N'55887', NULL, N'Finance Reviewer', 1, N'Basic', N'Declined', N'est congue elementum in hac habitasse platea dictumst morbi vestibulum velit', CAST(N'2023-08-22T00:00:00' AS SmallDateTime), CAST(N'2023-07-11T00:00:00' AS SmallDateTime), N'clindstroms', N'mschruurss')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (268, N'55887', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', N'et ultrices posuere cubilia curae nulla dapibus dolor vel est donec odio justo sollicitudin', CAST(N'2023-06-08T00:00:00' AS SmallDateTime), CAST(N'2023-06-10T00:00:00' AS SmallDateTime), N'kmatusov1q', N'lbiddlecombe1q')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (269, N'55887', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', N'hendrerit at vulputate vitae nisl aenean lectus pellentesque eget nunc donec quis orci eget', CAST(N'2022-10-26T00:00:00' AS SmallDateTime), CAST(N'2023-06-30T00:00:00' AS SmallDateTime), N'gdearsleyx', N'tgramerx')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (275, N'51124', NULL, N'Finance Reviewer', 1, N'Basic', N'Declined', N'in faucibus orci luctus et ultrices posuere cubilia curae mauris viverra diam vitae quam suspendisse potenti nullam porttitor', CAST(N'2023-08-20T00:00:00' AS SmallDateTime), CAST(N'2023-02-16T00:00:00' AS SmallDateTime), N'lsurridge2b', N'rmacmeekan2b')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (276, N'51124', NULL, N'Finance Reviewer', 1, N'Basic', N'Approved', N'nulla nisl nunc nisl duis bibendum felis sed interdum venenatis turpis enim blandit mi in porttitor pede', CAST(N'2023-06-25T00:00:00' AS SmallDateTime), CAST(N'2023-04-01T00:00:00' AS SmallDateTime), N'coleszczak11', N'mwhitehouse11')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (279, N'51124', NULL, N'Finance Reviewer', 1, N'Basic', N'Approved', N'libero ut massa volutpat convallis morbi odio odio elementum eu interdum eu tincidunt in leo maecenas pulvinar lobortis est', CAST(N'2023-05-14T00:00:00' AS SmallDateTime), CAST(N'2023-04-16T00:00:00' AS SmallDateTime), N'aheinsius18', N'pcade18')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (280, N'51124', NULL, N'Finance Reviewer', 1, N'Basic', N'Declined', N'donec pharetra magna vestibulum aliquet ultrices erat tortor sollicitudin mi sit amet lobortis sapien sapien non mi integer ac', CAST(N'2023-01-15T00:00:00' AS SmallDateTime), CAST(N'2023-09-06T00:00:00' AS SmallDateTime), N'rvickars24', N'lbartot24')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (281, N'51124', NULL, N'Finance Reviewer', 1, N'Basic', N'Declined', N'nisi at nibh in hac habitasse platea dictumst aliquam augue quam sollicitudin vitae consectetuer eget rutrum at lorem integer tincidunt', CAST(N'2023-07-16T00:00:00' AS SmallDateTime), CAST(N'2022-10-31T00:00:00' AS SmallDateTime), N'jfigliovannif', N'kfrangletonf')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (283, N'51124', NULL, N'Finance Reviewer', 1, N'Basic', N'Declined', N'vel accumsan tellus nisi eu orci mauris lacinia sapien quis libero nullam sit amet turpis elementum ligula vehicula consequat', CAST(N'2023-02-18T00:00:00' AS SmallDateTime), CAST(N'2022-12-06T00:00:00' AS SmallDateTime), N'amirrleeso', N'tstillo')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (284, N'51124', NULL, N'Finance Reviewer', 1, N'Basic', N'Declined', N'donec ut dolor morbi vel lectus in quam fringilla rhoncus mauris enim leo rhoncus sed vestibulum sit', CAST(N'2023-03-30T00:00:00' AS SmallDateTime), CAST(N'2023-01-08T00:00:00' AS SmallDateTime), N'aeteen1l', N'nkeveren1l')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (285, N'51124', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', N'nulla neque libero convallis eget eleifend luctus ultricies eu nibh quisque id', CAST(N'2023-04-26T00:00:00' AS SmallDateTime), CAST(N'2023-06-20T00:00:00' AS SmallDateTime), N'jdanilevichg', N'cbardeg')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (286, N'51124', NULL, N'Finance Reviewer', 1, N'Basic', N'Approved', N'id nisl venenatis lacinia aenean sit amet justo morbi ut odio cras mi pede malesuada in imperdiet et commodo', CAST(N'2022-11-14T00:00:00' AS SmallDateTime), CAST(N'2022-10-23T00:00:00' AS SmallDateTime), N'cglencrossn', N'sbyshn')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (287, N'51124', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', N'bibendum felis sed interdum venenatis turpis enim blandit mi in porttitor pede', CAST(N'2023-04-20T00:00:00' AS SmallDateTime), CAST(N'2023-04-14T00:00:00' AS SmallDateTime), N'jboribal6', N'pdanelutti6')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (288, N'51124', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', N'dictumst morbi vestibulum velit id pretium iaculis diam erat fermentum justo nec condimentum neque sapien placerat ante nulla justo', CAST(N'2023-07-13T00:00:00' AS SmallDateTime), CAST(N'2023-06-19T00:00:00' AS SmallDateTime), N'jgammel12', N'rmitford12')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (293, N'51124', NULL, N'Finance Reviewer', 1, N'Basic', N'Declined', N'ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia', CAST(N'2023-04-19T00:00:00' AS SmallDateTime), CAST(N'2023-02-06T00:00:00' AS SmallDateTime), N'aanersen5', N'cahrens5')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (294, N'51124', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', N'sollicitudin ut suscipit a feugiat et eros vestibulum ac est lacinia nisi venenatis tristique', CAST(N'2022-11-01T00:00:00' AS SmallDateTime), CAST(N'2023-03-14T00:00:00' AS SmallDateTime), N'dcannell6', N'araeside6')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (297, N'51124', NULL, N'Finance Reviewer', 1, N'Basic', N'Declined', N'odio in hac habitasse platea dictumst maecenas ut massa quis augue luctus tincidunt nulla mollis molestie', CAST(N'2023-08-20T00:00:00' AS SmallDateTime), CAST(N'2023-06-10T00:00:00' AS SmallDateTime), N'mshorthousez', N'gtinstonz')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (298, N'51124', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', N'sed vel enim sit amet nunc viverra dapibus nulla suscipit ligula in lacus curabitur', CAST(N'2023-01-17T00:00:00' AS SmallDateTime), CAST(N'2023-03-19T00:00:00' AS SmallDateTime), N'aslevin2r', N'eredler2r')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (299, N'51124', NULL, N'Finance Reviewer', 1, N'Basic', N'Declined', N'risus semper porta volutpat quam pede lobortis ligula sit amet eleifend pede libero quis orci nullam molestie nibh', CAST(N'2023-06-03T00:00:00' AS SmallDateTime), CAST(N'2022-12-02T00:00:00' AS SmallDateTime), N'bsparsholt1d', N'ballpress1d')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092009104220, N'51124', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', NULL, CAST(N'2023-09-20T21:11:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092009521968, N'51124', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', NULL, CAST(N'2023-09-20T21:52:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092103022776, N'51124', N'finance_manager', N'Finance Reviewer', 1, N'Basic', N'Declined', N'test', CAST(N'2023-09-21T15:03:00' AS SmallDateTime), CAST(N'2023-09-21T15:06:00' AS SmallDateTime), NULL, N'finance_manager')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092103122026, N'51124', N'Mustafa Sultan', N'Finance Reviewer', 1, N'Basic', N'Approved', N'test', CAST(N'2023-09-21T15:12:00' AS SmallDateTime), CAST(N'2023-09-21T15:13:00' AS SmallDateTime), NULL, N'Mustafa Sultan')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092103300594, N'51124', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', NULL, CAST(N'2023-09-21T15:30:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092303273296, N'51331', NULL, N'Finance Reviewer', 1, N'Basic', N'Approved', NULL, CAST(N'2023-09-23T15:28:00' AS SmallDateTime), CAST(N'2023-09-23T15:28:00' AS SmallDateTime), NULL, N'E-Documnet')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092303464478, N'51124', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', NULL, CAST(N'2023-09-23T15:47:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092304214266, N'51331', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', NULL, CAST(N'2023-09-23T16:22:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092311405101, N'51331', NULL, N'Finance Reviewer', 1, N'Basic', N'Approved', NULL, CAST(N'2023-09-23T11:41:00' AS SmallDateTime), CAST(N'2023-09-23T11:41:00' AS SmallDateTime), NULL, N'E-Documnet')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092312383635, N'51124', NULL, N'Finance Reviewer', 1, N'Basic', N'Approved', NULL, CAST(N'2023-09-23T12:39:00' AS SmallDateTime), CAST(N'2023-09-23T12:39:00' AS SmallDateTime), NULL, N'E-Documnet')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092401520199, N'51331', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', NULL, CAST(N'2023-09-24T13:52:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092401520199, N'51555', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', NULL, CAST(N'2023-09-24T13:52:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092402501896, N'51555', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', NULL, CAST(N'2023-09-24T14:50:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092402501896, N'51585', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', NULL, CAST(N'2023-09-24T14:50:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092407501144, N'51331', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', NULL, CAST(N'2023-09-24T19:50:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092407501144, N'51555', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', NULL, CAST(N'2023-09-24T19:50:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092408082616, N'51331', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', NULL, CAST(N'2023-09-24T20:08:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092408082616, N'51555', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', NULL, CAST(N'2023-09-24T20:08:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092408461019, N'51331', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', NULL, CAST(N'2023-09-24T20:46:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092408461019, N'51585', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', NULL, CAST(N'2023-09-24T20:46:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092409160738, N'50269', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', NULL, CAST(N'2023-09-24T21:16:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092409160738, N'51555', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', NULL, CAST(N'2023-09-24T21:16:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092409363271, N'50269', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', NULL, CAST(N'2023-09-24T21:37:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092409363271, N'51585', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', NULL, CAST(N'2023-09-24T21:37:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092411313243, N'50269', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', NULL, CAST(N'2023-09-24T23:32:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092411313243, N'51555', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', NULL, CAST(N'2023-09-24T23:32:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092412035534, N'50269', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', NULL, CAST(N'2023-09-24T12:04:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092412465945, N'50269', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', NULL, CAST(N'2023-09-24T12:47:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092501350165, N'50269', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', NULL, CAST(N'2023-09-25T13:35:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092501350165, N'51555', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', NULL, CAST(N'2023-09-25T13:35:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092507254291, N'51555', NULL, N'51555', 51555, N'51555', N'Pending', NULL, CAST(N'2023-09-25T22:27:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092507254291, N'55887', NULL, N'51585', 51585, N'51585', N'Pending', NULL, CAST(N'2023-09-25T22:27:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092508373110, N'51555', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', NULL, CAST(N'2023-09-25T08:38:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092508373110, N'51585', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', NULL, CAST(N'2023-09-25T08:38:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092508422125, N'51555', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', NULL, CAST(N'2023-09-25T08:42:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092508422125, N'51585', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', NULL, CAST(N'2023-09-25T08:42:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092510514561, N'51555', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', NULL, CAST(N'2023-09-25T22:53:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092510514561, N'51585', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', NULL, CAST(N'2023-09-25T22:53:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092512281585, N'51555', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', NULL, CAST(N'2023-09-25T12:28:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092512281585, N'55887', NULL, N'Finance Reviewer', 1, N'Basic', N'Pending', NULL, CAST(N'2023-09-25T12:28:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092608120404, N'51555', N'Alaa Hamad', N'Finance Reviewer', 1, N'Basic', N'Approved', N'approve', CAST(N'2023-09-26T20:33:00' AS SmallDateTime), CAST(N'2023-09-26T20:38:00' AS SmallDateTime), NULL, N'Alaa Hamad')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092608120404, N'51585', N'Alaa Hamad', N'Finance Reviewer', 1, N'Basic', N'Approved', N'approve', CAST(N'2023-09-26T20:33:00' AS SmallDateTime), CAST(N'2023-09-26T20:38:00' AS SmallDateTime), NULL, N'Alaa Hamad')
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092711434278, N'50269', NULL, N'Admin Manager', 2, N'Basic', N'Pending', NULL, CAST(N'2023-09-27T11:53:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092711434278, N'51111', NULL, N'Sr. Executive administration', 3, N'Basic', N'Pending', NULL, CAST(N'2023-09-27T11:53:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023092711434278, N'51331', NULL, N'Beneficiary Department Manager', 1, N'DepartmentManager', N'Pending', NULL, CAST(N'2023-09-27T11:53:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023093001511959, N'50269', NULL, N'Admin Manager', 2, N'Basic', N'Pending', NULL, CAST(N'2023-09-30T13:51:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023093001511959, N'51111', NULL, N'Sr. Executive administration', 3, N'Basic', N'Pending', NULL, CAST(N'2023-09-30T13:51:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023093001511959, N'51331', NULL, N'Beneficiary Department Manager', 1, N'DepartmentManager', N'Pending', NULL, CAST(N'2023-09-30T13:51:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023100111282815, N'50269', NULL, N'Admin Manager', 2, N'Basic', N'Pending', NULL, CAST(N'2023-10-01T12:33:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023100111282815, N'51111', NULL, N'Sr. Executive administration', 3, N'Basic', N'Pending', NULL, CAST(N'2023-10-01T12:33:00' AS SmallDateTime), NULL, NULL, NULL)
INSERT [dbo].[RequestReviewer] ([RequestId], [AssignedReviewerId], [ReviewedBy], [StageName], [StageNumber], [ReviewerType], [Status], [ReviewerNotes], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023100111282815, N'51331', NULL, N'Beneficiary Department Manager', 1, N'DepartmentManager', N'Pending', NULL, CAST(N'2023-10-01T12:33:00' AS SmallDateTime), NULL, NULL, NULL)
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
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'0049-0052', 296, N'Visa', N'China', 53, N'USD', CAST(N'2022-12-03T00:00:00' AS SmallDateTime), CAST(N'2023-07-13T00:00:00' AS SmallDateTime), N'0x8409e4616c884ec3fbaa51c83c43cf0672d0e940', N'Company', N'Poland', N'China', CAST(N'2023-03-11T00:00:00' AS SmallDateTime), CAST(N'2023-02-22T00:00:00' AS SmallDateTime), N'Vietnam', CAST(N'2023-01-19T00:00:00' AS SmallDateTime), CAST(N'2022-11-05T00:00:00' AS SmallDateTime), CAST(N'2023-09-12T00:00:00' AS SmallDateTime), N'Peta Hedges', N'Greta McGuff', N'Dudley Master', N'dmaster2@examiner.com', N'Staff Accountant II', N'Research and Development', N'427-805-3374', N'973-388-5361', N'TRAVEL822335')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'0054-3294', 298, N'Visa', N'China', 1, N'USD', CAST(N'2022-11-03T00:00:00' AS SmallDateTime), CAST(N'2022-10-06T00:00:00' AS SmallDateTime), N'0xe5894afc0a5f8359b0817fa1d88ad1f691ee1e37', N'Cash', N'China', N'Brazil', CAST(N'2023-02-12T00:00:00' AS SmallDateTime), CAST(N'2023-03-14T00:00:00' AS SmallDateTime), N'Kyrgyzstan', CAST(N'2023-05-06T00:00:00' AS SmallDateTime), CAST(N'2023-05-28T00:00:00' AS SmallDateTime), CAST(N'2022-11-03T00:00:00' AS SmallDateTime), N'Randell Inman', N'Ardyce Styles', N'Grove Alishoner', N'galishonerb@naver.com', N'Assistant Media Planner', N'Human Resources', N'220-142-6771', N'734-355-3513', N'TRAVEL382464')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'0093-4234', 235, N'Visa', N'France', 88, N'USD', CAST(N'2023-03-20T00:00:00' AS SmallDateTime), CAST(N'2022-10-31T00:00:00' AS SmallDateTime), N'0x7f23bbfadd6c5eacb20b338d5b6ee42ed3314c61', N'Cash', N'Brazil', N'France', CAST(N'2023-09-07T00:00:00' AS SmallDateTime), CAST(N'2023-09-17T00:00:00' AS SmallDateTime), N'Japan', CAST(N'2023-08-24T00:00:00' AS SmallDateTime), CAST(N'2023-02-21T00:00:00' AS SmallDateTime), CAST(N'2023-03-23T00:00:00' AS SmallDateTime), N'Jessie Genery', N'Arlin O''Heaney', N'Odessa Carnilian', N'ocarnilianz@paypal.com', N'Account Representative III', N'Training', N'125-229-9850', N'818-189-6374', N'TRAVEL311402')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'0228-2890', 273, N'Visa', N'France', 63, N'USD', CAST(N'2023-01-18T00:00:00' AS SmallDateTime), CAST(N'2023-03-05T00:00:00' AS SmallDateTime), N'0x48c033b15bd5e0c8b453a40883bf7d726382489b', N'Company', N'Thailand', N'Israel', CAST(N'2023-08-31T00:00:00' AS SmallDateTime), CAST(N'2022-11-29T00:00:00' AS SmallDateTime), N'Russia', CAST(N'2023-04-01T00:00:00' AS SmallDateTime), CAST(N'2023-09-10T00:00:00' AS SmallDateTime), CAST(N'2023-06-06T00:00:00' AS SmallDateTime), N'Karylin Castel', N'Ofilia Hoovart', N'Eolanda Munday', N'emundaya@google.es', N'Nurse', N'Accounting', N'931-640-9659', N'621-632-3563', N'TRAVEL801471')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'0268-0030', 225, N'Visa', N'Greece', 44, N'USD', CAST(N'2023-03-30T00:00:00' AS SmallDateTime), CAST(N'2023-08-06T00:00:00' AS SmallDateTime), N'0xb7c0e03e1920abc58575de644bf57f36fc0379bb', N'Company', N'Indonesia', N'Bosnia and Herzegovina', CAST(N'2023-03-10T00:00:00' AS SmallDateTime), CAST(N'2022-12-09T00:00:00' AS SmallDateTime), N'Kazakhstan', CAST(N'2023-05-06T00:00:00' AS SmallDateTime), CAST(N'2023-08-04T00:00:00' AS SmallDateTime), CAST(N'2023-04-19T00:00:00' AS SmallDateTime), N'Diena Asbery', N'Avrom Eathorne', N'Pepita Mantle', N'pmantle1c@flavors.me', N'Financial Analyst', N'Engineering', N'755-707-7322', N'746-780-0649', N'TRAVEL110003')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'0406-1146', 201, N'Visa', N'Ukraine', 55, N'USD', CAST(N'2022-12-14T00:00:00' AS SmallDateTime), CAST(N'2023-04-01T00:00:00' AS SmallDateTime), N'0x9f01cdbaf1b16c20138d344c9097391be52bf81b', N'Cash', N'Brazil', N'United States', CAST(N'2022-12-27T00:00:00' AS SmallDateTime), CAST(N'2023-06-02T00:00:00' AS SmallDateTime), N'France', CAST(N'2023-05-09T00:00:00' AS SmallDateTime), CAST(N'2022-12-03T00:00:00' AS SmallDateTime), CAST(N'2023-09-14T00:00:00' AS SmallDateTime), N'Kristien Broadhead', N'Shannon Merrydew', N'Elberta Chatburn', N'echatburns@china.com.cn', N'Speech Pathologist', N'Sales', N'561-480-5222', N'934-626-6350', N'TRAVEL879924')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'0472-0403', 252, N'Visa', N'China', 44, N'USD', CAST(N'2023-08-17T00:00:00' AS SmallDateTime), CAST(N'2023-03-25T00:00:00' AS SmallDateTime), N'0x93d0abab27a1d37739df0f028d72d5370bb515a2', N'Company', N'East Timor', N'China', CAST(N'2023-07-05T00:00:00' AS SmallDateTime), CAST(N'2023-07-26T00:00:00' AS SmallDateTime), N'Philippines', CAST(N'2023-01-30T00:00:00' AS SmallDateTime), CAST(N'2023-06-15T00:00:00' AS SmallDateTime), CAST(N'2023-06-14T00:00:00' AS SmallDateTime), N'Elroy Bankes', N'Tami Deener', N'Peggi Gilluley', N'pgilluley2f@house.gov', N'Assistant Manager', N'Accounting', N'207-547-1073', N'448-353-2617', N'TRAVEL326671')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'0485-0155', 267, N'Visa', N'Chile', 86, N'USD', CAST(N'2023-06-12T00:00:00' AS SmallDateTime), CAST(N'2023-07-25T00:00:00' AS SmallDateTime), N'0x1dc066b543482210155efb7a2fc601a50e4039b8', N'Cash', N'Vietnam', N'Sweden', CAST(N'2023-05-16T00:00:00' AS SmallDateTime), CAST(N'2023-02-26T00:00:00' AS SmallDateTime), N'China', CAST(N'2023-05-17T00:00:00' AS SmallDateTime), CAST(N'2022-10-23T00:00:00' AS SmallDateTime), CAST(N'2022-10-26T00:00:00' AS SmallDateTime), N'Chaddy Eadmead', N'Essie Godlonton', N'Marianna Dowding', N'mdowding1y@wikispaces.com', N'Staff Accountant III', N'Legal', N'733-186-3505', N'357-117-9964', N'TRAVEL947993')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'0832-0302', 256, N'Visa', N'China', 68, N'USD', CAST(N'2022-12-10T00:00:00' AS SmallDateTime), CAST(N'2022-12-17T00:00:00' AS SmallDateTime), N'0xb34007e55cc503bf736e526b0dc2db874f78508e', N'Cash', N'Thailand', N'China', CAST(N'2023-05-27T00:00:00' AS SmallDateTime), CAST(N'2023-03-22T00:00:00' AS SmallDateTime), N'Philippines', CAST(N'2023-07-04T00:00:00' AS SmallDateTime), CAST(N'2023-09-27T00:00:00' AS SmallDateTime), CAST(N'2023-01-03T00:00:00' AS SmallDateTime), N'Milton Chesman', N'Rayna Refford', N'Anselm Ponton', N'aponton2b@miitbeian.gov.cn', N'Chief Design Engineer', N'Human Resources', N'593-736-1839', N'396-315-6708', N'TRAVEL421685')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'0904-7725', 231, N'Visa', N'Palau', 17, N'USD', CAST(N'2023-02-12T00:00:00' AS SmallDateTime), CAST(N'2023-04-03T00:00:00' AS SmallDateTime), N'0xabff4297debe1053ed2ad581f16bef4d5223cc37', N'Company', N'Afghanistan', N'Peru', CAST(N'2023-03-04T00:00:00' AS SmallDateTime), CAST(N'2023-04-01T00:00:00' AS SmallDateTime), N'Germany', CAST(N'2023-01-28T00:00:00' AS SmallDateTime), CAST(N'2023-05-23T00:00:00' AS SmallDateTime), CAST(N'2023-04-04T00:00:00' AS SmallDateTime), N'Sharl McDonell', N'Austin Issacson', N'Fawn Rentalll', N'frentalll1z@unc.edu', N'Database Administrator II', N'Support', N'813-480-6360', N'817-695-4552', N'TRAVEL760318')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'11697-373', 287, N'Visa', N'Philippines', 55, N'USD', CAST(N'2022-11-06T00:00:00' AS SmallDateTime), CAST(N'2023-05-02T00:00:00' AS SmallDateTime), N'0x1902e3ca914a9902ca478aed6b6f2a3db3e9519e', N'Cash', N'Japan', N'Belgium', CAST(N'2023-07-25T00:00:00' AS SmallDateTime), CAST(N'2023-08-09T00:00:00' AS SmallDateTime), N'Indonesia', CAST(N'2022-10-05T00:00:00' AS SmallDateTime), CAST(N'2022-12-02T00:00:00' AS SmallDateTime), CAST(N'2023-03-01T00:00:00' AS SmallDateTime), N'Moselle Pridding', N'Nikki Tideswell', N'Mab Pavlovsky', N'mpavlovskyf@issuu.com', N'Recruiter', N'Services', N'264-914-4116', N'588-610-5004', N'TRAVEL513921')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'11822-9016', 257, N'Visa', N'Brazil', 84, N'USD', CAST(N'2022-10-20T00:00:00' AS SmallDateTime), CAST(N'2023-07-22T00:00:00' AS SmallDateTime), N'0xb1fe4f787350d08b202b3c9b196961cbe6edeeff', N'Cash', N'France', N'Vietnam', CAST(N'2022-11-29T00:00:00' AS SmallDateTime), CAST(N'2022-10-17T00:00:00' AS SmallDateTime), N'Argentina', CAST(N'2023-08-18T00:00:00' AS SmallDateTime), CAST(N'2022-12-24T00:00:00' AS SmallDateTime), CAST(N'2023-02-19T00:00:00' AS SmallDateTime), N'Ashlie Galbraeth', N'Marga Chelley', N'Gerianne Griffitts', N'ggriffitts15@domainmarket.com', N'Office Assistant II', N'Business Development', N'462-486-2352', N'118-623-1288', N'TRAVEL350851')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'1396', 2023093001511959, N'Accomodation,FlightTicket,Visa', N'Egyptian', 2258, N'EURO', CAST(N'2023-09-25T00:00:00' AS SmallDateTime), CAST(N'2023-09-29T00:00:00' AS SmallDateTime), N'Egypt, Suez', N'Cash', N'Egypt', N'India', CAST(N'2023-09-25T00:00:00' AS SmallDateTime), CAST(N'2023-09-30T00:00:00' AS SmallDateTime), N'Egypt', CAST(N'2023-09-30T00:00:00' AS SmallDateTime), CAST(N'2023-09-30T13:51:00' AS SmallDateTime), CAST(N'2023-09-30T13:47:00' AS SmallDateTime), N'Rewan Hosny', NULL, N'Rewan Hosny', N'rhosny@dpwsapps.com', N'IT Developer', N'IT', N'01171769160', NULL, N'Travel-20230930015119')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'1396', 2023100111282815, N'FlightTicket', N'Egyptian', 225, N'EURO', NULL, NULL, NULL, NULL, N'Dubay', N'India', CAST(N'2023-05-22T00:00:00' AS SmallDateTime), CAST(N'2023-04-22T00:00:00' AS SmallDateTime), N'Egypt', CAST(N'2023-09-30T00:00:00' AS SmallDateTime), CAST(N'2023-09-26T12:02:00' AS SmallDateTime), CAST(N'2023-10-01T12:33:00' AS SmallDateTime), NULL, N'Rewan Hosny', N'Rewan Hosny', N'rhosny@dpwsapps.com', N'IT Developer', N'IT', N'01171769160', N'558', N'Travel-20231001112828')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'16571-441', 285, N'Visa', N'Indonesia', 56, N'USD', CAST(N'2023-04-13T00:00:00' AS SmallDateTime), CAST(N'2023-07-17T00:00:00' AS SmallDateTime), N'0xfacf04e8c48c70ed489f418c31e52afb8d97eac4', N'Company', N'Russia', N'China', CAST(N'2023-05-05T00:00:00' AS SmallDateTime), CAST(N'2022-12-30T00:00:00' AS SmallDateTime), N'Colombia', CAST(N'2023-03-01T00:00:00' AS SmallDateTime), CAST(N'2023-01-05T00:00:00' AS SmallDateTime), CAST(N'2022-11-05T00:00:00' AS SmallDateTime), N'Kaycee Dobsons', N'Abraham McGivena', N'Germayne Andrez', N'gandrez5@hubpages.com', N'Marketing Assistant', N'Training', N'442-877-0878', N'562-950-4179', N'TRAVEL792751')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'16714-395', 268, N'Visa', N'Afghanistan', 81, N'USD', CAST(N'2023-09-04T00:00:00' AS SmallDateTime), CAST(N'2023-04-05T00:00:00' AS SmallDateTime), N'0xe22aff9c6bb4019d9f9eee63be9a60a967432e64', N'Company', N'Philippines', N'Portugal', CAST(N'2023-08-29T00:00:00' AS SmallDateTime), CAST(N'2023-05-19T00:00:00' AS SmallDateTime), N'Lithuania', CAST(N'2023-03-24T00:00:00' AS SmallDateTime), CAST(N'2023-05-01T00:00:00' AS SmallDateTime), CAST(N'2023-01-08T00:00:00' AS SmallDateTime), N'Marlane Ingham', N'Allison Madgewick', N'Florrie Reveley', N'freveley0@epa.gov', N'Librarian', N'Research and Development', N'713-632-8220', N'202-470-4392', N'TRAVEL626021')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'16729-179', 207, N'Visa', N'Yemen', 96, N'USD', CAST(N'2023-04-18T00:00:00' AS SmallDateTime), CAST(N'2023-05-21T00:00:00' AS SmallDateTime), N'0x90a5d522ebbbca02434cbf6a5fb58331bf3b43e3', N'Company', N'Tunisia', N'United States', CAST(N'2023-03-01T00:00:00' AS SmallDateTime), CAST(N'2023-08-14T00:00:00' AS SmallDateTime), N'Greece', CAST(N'2022-10-23T00:00:00' AS SmallDateTime), CAST(N'2023-01-25T00:00:00' AS SmallDateTime), CAST(N'2023-09-05T00:00:00' AS SmallDateTime), N'Tiphany Adnam', N'Clem Torbet', N'Anastassia Cobbledick', N'acobbledick1n@epa.gov', N'Marketing Manager', N'Engineering', N'896-470-4634', N'419-494-7454', N'TRAVEL712214')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'17714-020', 241, N'Visa', N'Brazil', 42, N'USD', CAST(N'2023-06-23T00:00:00' AS SmallDateTime), CAST(N'2023-02-20T00:00:00' AS SmallDateTime), N'0xd6293b51156e75a982b037323d30f588075a57dd', N'Company', N'China', N'Thailand', CAST(N'2023-09-07T00:00:00' AS SmallDateTime), CAST(N'2023-03-01T00:00:00' AS SmallDateTime), N'Russia', CAST(N'2023-07-15T00:00:00' AS SmallDateTime), CAST(N'2023-07-11T00:00:00' AS SmallDateTime), CAST(N'2022-10-07T00:00:00' AS SmallDateTime), N'Ulises Foulks', N'Elsa Mayell', N'Corette Farden', N'cfarden8@ehow.com', N'Occupational Therapist', N'Sales', N'515-936-1476', N'403-922-8567', N'TRAVEL019197')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'23635-416', 275, N'Visa', N'Syria', 73, N'USD', CAST(N'2023-09-16T00:00:00' AS SmallDateTime), CAST(N'2023-02-25T00:00:00' AS SmallDateTime), N'0xc4d362f860734aeb59b27e6f7319ea67be16a04d', N'Company', N'Yemen', N'Yemen', CAST(N'2023-03-19T00:00:00' AS SmallDateTime), CAST(N'2023-02-21T00:00:00' AS SmallDateTime), N'Canada', CAST(N'2022-10-13T00:00:00' AS SmallDateTime), CAST(N'2023-04-12T00:00:00' AS SmallDateTime), CAST(N'2023-06-05T00:00:00' AS SmallDateTime), N'Kimble Strathern', N'Aguste Vitet', N'Ilysa Deporte', N'ideporte16@reverbnation.com', N'Graphic Designer', N'Human Resources', N'575-962-6258', N'953-127-7457', N'TRAVEL990453')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'24236-727', 218, N'Visa', N'China', 9, N'USD', CAST(N'2022-12-16T00:00:00' AS SmallDateTime), CAST(N'2023-09-06T00:00:00' AS SmallDateTime), N'0x5a9bdb2260327f767e171c3e636a9c7de415da0c', N'Company', N'China', N'Brazil', CAST(N'2023-09-20T00:00:00' AS SmallDateTime), CAST(N'2023-04-11T00:00:00' AS SmallDateTime), N'Indonesia', CAST(N'2023-08-17T00:00:00' AS SmallDateTime), CAST(N'2022-11-12T00:00:00' AS SmallDateTime), CAST(N'2023-01-20T00:00:00' AS SmallDateTime), N'Rubie Howood', N'Art Phaup', N'Vania Lumby', N'vlumbyy@lycos.com', N'Marketing Assistant', N'Engineering', N'565-245-5262', N'469-362-5215', N'TRAVEL813590')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'42507-489', 274, N'Visa', N'Myanmar', 63, N'USD', CAST(N'2023-07-26T00:00:00' AS SmallDateTime), CAST(N'2023-02-15T00:00:00' AS SmallDateTime), N'0x3d41de959f35754739acca299a3d991e516ec8b9', N'Company', N'Philippines', N'Colombia', CAST(N'2023-04-30T00:00:00' AS SmallDateTime), CAST(N'2023-01-07T00:00:00' AS SmallDateTime), N'France', CAST(N'2023-05-01T00:00:00' AS SmallDateTime), CAST(N'2023-08-13T00:00:00' AS SmallDateTime), CAST(N'2023-06-16T00:00:00' AS SmallDateTime), N'Kristal Bediss', N'Gipsy Cooley', N'Brear Harwood', N'bharwood1s@deviantart.com', N'Accounting Assistant III', N'Legal', N'672-945-7657', N'511-805-8074', N'TRAVEL584420')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'49288-0364', 226, N'Visa', N'China', 33, N'USD', CAST(N'2023-01-10T00:00:00' AS SmallDateTime), CAST(N'2022-11-22T00:00:00' AS SmallDateTime), N'0xdc67ed95bef62b989868782aa6bb1098464ec62c', N'Cash', N'Syria', N'Germany', CAST(N'2023-05-28T00:00:00' AS SmallDateTime), CAST(N'2023-06-29T00:00:00' AS SmallDateTime), N'Philippines', CAST(N'2023-03-11T00:00:00' AS SmallDateTime), CAST(N'2023-08-12T00:00:00' AS SmallDateTime), CAST(N'2023-05-15T00:00:00' AS SmallDateTime), N'Constantina Shimmans', N'Aldous Salthouse', N'Lorene Stute', N'lstute18@github.io', N'Dental Hygienist', N'Engineering', N'246-549-0466', N'675-702-9313', N'TRAVEL240137')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'49288-0490', 232, N'Visa', N'Thailand', 92, N'USD', CAST(N'2022-12-21T00:00:00' AS SmallDateTime), CAST(N'2023-05-21T00:00:00' AS SmallDateTime), N'0x6857b6e93862501ad2d4dd03ad9f00c3c2fabf99', N'Cash', N'Brazil', N'Indonesia', CAST(N'2022-12-19T00:00:00' AS SmallDateTime), CAST(N'2023-04-05T00:00:00' AS SmallDateTime), N'Sweden', CAST(N'2023-06-14T00:00:00' AS SmallDateTime), CAST(N'2022-12-11T00:00:00' AS SmallDateTime), CAST(N'2022-11-20T00:00:00' AS SmallDateTime), N'Arlin Floyde', N'Benji Burchmore', N'Curran Gatus', N'cgatus1k@wp.com', N'Computer Systems Analyst I', N'Human Resources', N'411-471-0226', N'482-507-5414', N'TRAVEL038060')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'49349-566', 299, N'Visa', N'China', 58, N'USD', CAST(N'2023-02-03T00:00:00' AS SmallDateTime), CAST(N'2023-06-05T00:00:00' AS SmallDateTime), N'0xeb68b48b93a03c0f1413d810222239232a846a22', N'Company', N'Portugal', N'United States', CAST(N'2022-10-25T00:00:00' AS SmallDateTime), CAST(N'2023-02-11T00:00:00' AS SmallDateTime), N'Iceland', CAST(N'2023-05-18T00:00:00' AS SmallDateTime), CAST(N'2023-04-07T00:00:00' AS SmallDateTime), CAST(N'2023-05-28T00:00:00' AS SmallDateTime), N'Elsey Chart', N'Marlo Hoofe', N'Madelaine Durram', N'mdurram19@fotki.com', N'Dental Hygienist', N'Legal', N'467-845-0199', N'478-720-8394', N'TRAVEL523163')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'50383-079', 291, N'Visa', N'Ireland', 18, N'USD', CAST(N'2023-05-20T00:00:00' AS SmallDateTime), CAST(N'2023-03-01T00:00:00' AS SmallDateTime), N'0x35b4fd2a601f8530157a96d5db769ce2216412f6', N'Cash', N'Ukraine', N'Portugal', CAST(N'2023-05-23T00:00:00' AS SmallDateTime), CAST(N'2023-05-19T00:00:00' AS SmallDateTime), N'Cambodia', CAST(N'2023-08-09T00:00:00' AS SmallDateTime), CAST(N'2023-07-25T00:00:00' AS SmallDateTime), CAST(N'2023-06-19T00:00:00' AS SmallDateTime), N'Jackqueline Allright', N'Rosemary Giannoni', N'Templeton Speddin', N'tspeddin27@google.de', N'Recruiting Manager', N'Business Development', N'601-901-4187', N'928-839-7272', N'TRAVEL183378')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'50942-001', 283, N'Visa', N'Sweden', 86, N'USD', CAST(N'2023-08-25T00:00:00' AS SmallDateTime), CAST(N'2023-07-02T00:00:00' AS SmallDateTime), N'0x4e253ffd51995f95e638da63da10820d20e2dcba', N'Company', N'Argentina', N'Indonesia', CAST(N'2023-02-28T00:00:00' AS SmallDateTime), CAST(N'2023-07-06T00:00:00' AS SmallDateTime), N'Argentina', CAST(N'2023-05-27T00:00:00' AS SmallDateTime), CAST(N'2023-07-29T00:00:00' AS SmallDateTime), CAST(N'2023-09-16T00:00:00' AS SmallDateTime), N'Gifford Kapiloff', N'Elizabeth Cottom', N'Cary Godfray', N'cgodfray2a@ifeng.com', N'Junior Executive', N'Research and Development', N'401-577-4144', N'408-357-3446', N'TRAVEL694744')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'52374-016', 221, N'Visa', N'Russia', 83, N'USD', CAST(N'2023-07-28T00:00:00' AS SmallDateTime), CAST(N'2023-05-01T00:00:00' AS SmallDateTime), N'0x0268f6790f0a3bd73678893002dd7cb290badb1a', N'Company', N'Vietnam', N'China', CAST(N'2023-03-20T00:00:00' AS SmallDateTime), CAST(N'2023-08-06T00:00:00' AS SmallDateTime), N'Canada', CAST(N'2023-08-14T00:00:00' AS SmallDateTime), CAST(N'2023-09-09T00:00:00' AS SmallDateTime), CAST(N'2022-12-17T00:00:00' AS SmallDateTime), N'Arley McReynold', N'Rebecka Chaperling', N'Eileen Strattan', N'estrattanl@jugem.jp', N'Senior Quality Engineer', N'Legal', N'209-517-1666', N'484-463-4508', N'TRAVEL204760')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'54569-2586', 245, N'Visa', N'Russia', 38, N'USD', CAST(N'2023-02-28T00:00:00' AS SmallDateTime), CAST(N'2023-02-22T00:00:00' AS SmallDateTime), N'0x911b88663c403fd43a94ebc8a383ee7e314c5a70', N'Cash', N'Mexico', N'Portugal', CAST(N'2023-04-17T00:00:00' AS SmallDateTime), CAST(N'2023-04-16T00:00:00' AS SmallDateTime), N'Czech Republic', CAST(N'2023-08-24T00:00:00' AS SmallDateTime), CAST(N'2022-12-26T00:00:00' AS SmallDateTime), CAST(N'2023-09-08T00:00:00' AS SmallDateTime), N'Ode Kovalski', N'Ebeneser Craythorne', N'Babbie Horley', N'bhorley1q@nhs.uk', N'Research Associate', N'Training', N'675-283-1990', N'673-821-4338', N'TRAVEL924827')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'54569-3354', 279, N'Visa', N'Moldova', 22, N'USD', CAST(N'2023-07-04T00:00:00' AS SmallDateTime), CAST(N'2023-04-03T00:00:00' AS SmallDateTime), N'0x6a683916c2e32a2ca3152fd94d0f44686869e2a7', N'Company', N'Canada', N'China', CAST(N'2023-01-30T00:00:00' AS SmallDateTime), CAST(N'2023-07-13T00:00:00' AS SmallDateTime), N'Portugal', CAST(N'2023-05-29T00:00:00' AS SmallDateTime), CAST(N'2023-05-25T00:00:00' AS SmallDateTime), CAST(N'2022-12-23T00:00:00' AS SmallDateTime), N'Bartholomew Jollie', N'Addie Tourville', N'Mick Kmiec', N'mkmiec4@ucsd.edu', N'Operator', N'Research and Development', N'433-482-0047', N'629-181-5975', N'TRAVEL004656')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'55154-6256', 237, N'Visa', N'Thailand', 6, N'USD', CAST(N'2023-04-01T00:00:00' AS SmallDateTime), CAST(N'2023-07-08T00:00:00' AS SmallDateTime), N'0xb59753f7c6b871cb65bbac0985dece6f70d20c74', N'Company', N'Philippines', N'Cuba', CAST(N'2023-06-27T00:00:00' AS SmallDateTime), CAST(N'2022-10-23T00:00:00' AS SmallDateTime), N'Denmark', CAST(N'2023-02-08T00:00:00' AS SmallDateTime), CAST(N'2023-07-15T00:00:00' AS SmallDateTime), CAST(N'2023-08-17T00:00:00' AS SmallDateTime), N'Kienan Johncey', N'Birgit Corkell', N'Eugenio Volett', N'evolett1u@europa.eu', N'Assistant Professor', N'Support', N'971-733-7104', N'284-227-7088', N'TRAVEL605957')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'55154-8385', 238, N'Visa', N'Indonesia', 84, N'USD', CAST(N'2023-07-10T00:00:00' AS SmallDateTime), CAST(N'2023-06-16T00:00:00' AS SmallDateTime), N'0x43d750cec2e23e626bcb0de749b342aec6a0343a', N'Company', N'United Kingdom', N'Czech Republic', CAST(N'2023-07-25T00:00:00' AS SmallDateTime), CAST(N'2023-07-07T00:00:00' AS SmallDateTime), N'China', CAST(N'2023-02-13T00:00:00' AS SmallDateTime), CAST(N'2022-10-06T00:00:00' AS SmallDateTime), CAST(N'2023-06-14T00:00:00' AS SmallDateTime), N'Eli Petit', N'Staci Grutchfield', N'Kirstin Mc Elory', N'kmc1f@harvard.edu', N'Actuary', N'Training', N'730-731-6352', N'394-477-1292', N'TRAVEL106244')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'55289-186', 216, N'Visa', N'Indonesia', 7, N'USD', CAST(N'2022-11-25T00:00:00' AS SmallDateTime), CAST(N'2023-07-31T00:00:00' AS SmallDateTime), N'0x1677a495497c9ce86918d175999619253cbacdd1', N'Company', N'Russia', N'China', CAST(N'2022-10-03T00:00:00' AS SmallDateTime), CAST(N'2023-03-20T00:00:00' AS SmallDateTime), N'Indonesia', CAST(N'2023-01-01T00:00:00' AS SmallDateTime), CAST(N'2022-11-06T00:00:00' AS SmallDateTime), CAST(N'2023-08-13T00:00:00' AS SmallDateTime), N'Florian Gutowska', N'Em Tubby', N'Derk Briggdale', N'dbriggdale10@tinyurl.com', N'Physical Therapy Assistant', N'Human Resources', N'841-942-6055', N'353-801-0579', N'TRAVEL754697')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'55533-529', 278, N'Visa', N'Greece', 37, N'USD', CAST(N'2023-05-28T00:00:00' AS SmallDateTime), CAST(N'2022-12-25T00:00:00' AS SmallDateTime), N'0x48bc2302b06cae62790cbab05c7f17750ec12be1', N'Company', N'China', N'Dominican Republic', CAST(N'2023-06-26T00:00:00' AS SmallDateTime), CAST(N'2023-09-02T00:00:00' AS SmallDateTime), N'Philippines', CAST(N'2023-02-13T00:00:00' AS SmallDateTime), CAST(N'2023-03-13T00:00:00' AS SmallDateTime), CAST(N'2022-12-08T00:00:00' AS SmallDateTime), N'Juditha Rayment', N'Lilyan Dow', N'Linn Meineck', N'lmeineckq@google.nl', N'Web Designer II', N'Engineering', N'113-813-8258', N'773-715-1825', N'TRAVEL830504')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'58414-3512', 271, N'Visa', N'China', 58, N'USD', CAST(N'2023-01-27T00:00:00' AS SmallDateTime), CAST(N'2023-03-06T00:00:00' AS SmallDateTime), N'0x337d88f2890992376b857598b0dd7cb57a8b2b45', N'Company', N'China', N'Afghanistan', CAST(N'2023-04-10T00:00:00' AS SmallDateTime), CAST(N'2023-06-14T00:00:00' AS SmallDateTime), N'South Korea', CAST(N'2023-03-14T00:00:00' AS SmallDateTime), CAST(N'2023-08-12T00:00:00' AS SmallDateTime), CAST(N'2023-08-27T00:00:00' AS SmallDateTime), N'Flinn McNiven', N'Rickert Sattin', N'Dougie Marciek', N'dmarciekd@va.gov', N'Nurse', N'Sales', N'945-703-6673', N'859-706-0743', N'TRAVEL572371')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'59779-203', 258, N'Visa', N'Peru', 52, N'USD', CAST(N'2023-01-01T00:00:00' AS SmallDateTime), CAST(N'2023-04-17T00:00:00' AS SmallDateTime), N'0x149faf5f62131cd62762b7aa4362db1229b1c6c6', N'Company', N'Belgium', N'Portugal', CAST(N'2023-07-03T00:00:00' AS SmallDateTime), CAST(N'2023-05-03T00:00:00' AS SmallDateTime), N'China', CAST(N'2023-08-10T00:00:00' AS SmallDateTime), CAST(N'2022-11-05T00:00:00' AS SmallDateTime), CAST(N'2023-02-06T00:00:00' AS SmallDateTime), N'Lesly Lagadu', N'Hilary Wale', N'Baillie Ledwith', N'bledwitho@hostgator.com', N'Environmental Tech', N'Research and Development', N'608-916-4688', N'898-852-6641', N'TRAVEL827355')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'60681-1285', 206, N'Visa', N'Albania', 68, N'USD', CAST(N'2023-04-19T00:00:00' AS SmallDateTime), CAST(N'2023-04-10T00:00:00' AS SmallDateTime), N'0x089b4692c52f38a04c0a9bbf1fc9b64be0d32870', N'Company', N'Sweden', N'China', CAST(N'2023-05-18T00:00:00' AS SmallDateTime), CAST(N'2023-02-17T00:00:00' AS SmallDateTime), N'China', CAST(N'2023-05-03T00:00:00' AS SmallDateTime), CAST(N'2023-05-28T00:00:00' AS SmallDateTime), CAST(N'2023-09-14T00:00:00' AS SmallDateTime), N'Darcy Sicely', N'Babette O''Fogarty', N'Damita McCowan', N'dmccowan2k@wufoo.com', N'Assistant Manager', N'Training', N'298-457-6891', N'361-699-4870', N'TRAVEL291585')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'63187-032', 249, N'Visa', N'Indonesia', 100, N'USD', CAST(N'2023-07-17T00:00:00' AS SmallDateTime), CAST(N'2023-08-15T00:00:00' AS SmallDateTime), N'0xa7cd7196f9bc8fef23af25b615cede32d6f23bf7', N'Company', N'Yemen', N'United States', CAST(N'2023-01-08T00:00:00' AS SmallDateTime), CAST(N'2023-09-17T00:00:00' AS SmallDateTime), N'Greece', CAST(N'2023-04-19T00:00:00' AS SmallDateTime), CAST(N'2023-07-01T00:00:00' AS SmallDateTime), CAST(N'2022-10-13T00:00:00' AS SmallDateTime), N'Roxine Malyan', N'Leonid Chatelain', N'Anallese Richardson', N'arichardson1i@hatena.ne.jp', N'Dental Hygienist', N'Services', N'188-748-5827', N'688-717-2769', N'TRAVEL504395')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'63509-002', 281, N'Visa', N'Sweden', 57, N'USD', CAST(N'2023-08-04T00:00:00' AS SmallDateTime), CAST(N'2023-09-02T00:00:00' AS SmallDateTime), N'0x2d8c1ed3453dc041127f1d9bdced2daeada63e7d', N'Cash', N'China', N'China', CAST(N'2022-10-28T00:00:00' AS SmallDateTime), CAST(N'2023-06-12T00:00:00' AS SmallDateTime), N'Mexico', CAST(N'2023-04-01T00:00:00' AS SmallDateTime), CAST(N'2023-08-06T00:00:00' AS SmallDateTime), CAST(N'2023-08-15T00:00:00' AS SmallDateTime), N'Halimeda Filipponi', N'Linette McTurk', N'Matthaeus Espinas', N'mespinasg@slashdot.org', N'Programmer Analyst I', N'Human Resources', N'667-898-2538', N'341-327-1077', N'TRAVEL536304')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'64117-545', 293, N'Visa', N'Russia', 6, N'USD', CAST(N'2023-08-09T00:00:00' AS SmallDateTime), CAST(N'2023-09-20T00:00:00' AS SmallDateTime), N'0x6f832cff8d195d637acc45692c936b796c2312cd', N'Company', N'China', N'Philippines', CAST(N'2023-07-19T00:00:00' AS SmallDateTime), CAST(N'2023-09-28T00:00:00' AS SmallDateTime), N'Bosnia and Herzegovina', CAST(N'2023-05-17T00:00:00' AS SmallDateTime), CAST(N'2023-01-05T00:00:00' AS SmallDateTime), CAST(N'2022-11-12T00:00:00' AS SmallDateTime), N'Deb Heinle', N'Anitra Sturror', N'Julee Hugnot', N'jhugnot9@de.vu', N'Research Assistant I', N'Product Management', N'801-415-5595', N'390-525-2041', N'TRAVEL023470')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'64980-162', 264, N'Visa', N'China', 8, N'USD', CAST(N'2023-05-07T00:00:00' AS SmallDateTime), CAST(N'2023-01-23T00:00:00' AS SmallDateTime), N'0x5d194b86dedc39b3931878f8d6c357bcad9b82c3', N'Cash', N'China', N'Indonesia', CAST(N'2023-09-17T00:00:00' AS SmallDateTime), CAST(N'2023-02-22T00:00:00' AS SmallDateTime), N'Afghanistan', CAST(N'2022-11-06T00:00:00' AS SmallDateTime), CAST(N'2022-10-09T00:00:00' AS SmallDateTime), CAST(N'2023-02-26T00:00:00' AS SmallDateTime), N'Pavla Haselhurst', N'Shantee Saunton', N'Cleopatra Boutcher', N'cboutcherc@rakuten.co.jp', N'Operator', N'Services', N'441-361-0244', N'213-213-3331', N'TRAVEL526605')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'67253-821', 262, N'Visa', N'China', 50, N'USD', CAST(N'2022-12-12T00:00:00' AS SmallDateTime), CAST(N'2023-03-11T00:00:00' AS SmallDateTime), N'0xb2a671cfa5c7bb082bea9d6ae99ec663bf0290f5', N'Company', N'Yemen', N'Iran', CAST(N'2023-03-09T00:00:00' AS SmallDateTime), CAST(N'2023-08-28T00:00:00' AS SmallDateTime), N'Poland', CAST(N'2023-03-28T00:00:00' AS SmallDateTime), CAST(N'2023-06-11T00:00:00' AS SmallDateTime), CAST(N'2023-04-18T00:00:00' AS SmallDateTime), N'Chevalier Buesden', N'Stinky Piddock', N'Dun MacIlhagga', N'dmacilhaggaw@sina.com.cn', N'Editor', N'Training', N'154-831-2352', N'560-851-6846', N'TRAVEL858580')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'68151-2958', 208, N'Visa', N'Indonesia', 36, N'USD', CAST(N'2023-06-11T00:00:00' AS SmallDateTime), CAST(N'2023-07-24T00:00:00' AS SmallDateTime), N'0xbeb358a595c4f7c487ec8e02208643c2603a0ca0', N'Cash', N'Portugal', N'Serbia', CAST(N'2023-03-31T00:00:00' AS SmallDateTime), CAST(N'2023-07-23T00:00:00' AS SmallDateTime), N'Indonesia', CAST(N'2022-11-21T00:00:00' AS SmallDateTime), CAST(N'2023-06-18T00:00:00' AS SmallDateTime), CAST(N'2023-01-10T00:00:00' AS SmallDateTime), N'Luisa Camamill', N'Alfreda Fear', N'Virgilio Palffy', N'vpalffy7@europa.eu', N'Research Nurse', N'Product Management', N'765-241-5770', N'872-852-0558', N'TRAVEL938120')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'68387-106', 251, N'Visa', N'Philippines', 99, N'USD', CAST(N'2023-07-14T00:00:00' AS SmallDateTime), CAST(N'2022-11-08T00:00:00' AS SmallDateTime), N'0x63da172c9b54b73f93ba864b3f17097afdbc488b', N'Company', N'United States', N'China', CAST(N'2023-05-29T00:00:00' AS SmallDateTime), CAST(N'2023-05-03T00:00:00' AS SmallDateTime), N'Greece', CAST(N'2023-07-24T00:00:00' AS SmallDateTime), CAST(N'2023-07-17T00:00:00' AS SmallDateTime), CAST(N'2023-06-21T00:00:00' AS SmallDateTime), N'Neddie Punton', N'Quent Puzey', N'Hershel Rizzardi', N'hrizzardi1l@walmart.com', N'Graphic Designer', N'Accounting', N'574-624-8250', N'916-228-0498', N'TRAVEL336055')
INSERT [dbo].[TravelDeskRequest] ([BeneficiaryId], [RequestId], [RequestType], [BeneficiaryNationality], [CostAllocation], [Currency], [CheckIn], [CheckOut], [MissionAddress], [PaymentMethod], [FlightOrigin], [FlightDestination], [DepartureDate], [ReturnDate], [DestinationCountry], [ExpectedTravelTime], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestNumber]) VALUES (N'76209-123', 2023092711434278, N'Visa, FlightTicket', N'Colombia', 17, N'USD', CAST(N'2022-11-20T00:00:00' AS SmallDateTime), CAST(N'2023-09-01T00:00:00' AS SmallDateTime), N'0x364979ec3199e67e4c252e0d3118d8ed750bbb94', N'Company', N'Colombia', N'France', CAST(N'2023-04-13T00:00:00' AS SmallDateTime), CAST(N'2023-08-28T00:00:00' AS SmallDateTime), N'China', CAST(N'2023-06-20T00:00:00' AS SmallDateTime), CAST(N'2023-02-03T00:00:00' AS SmallDateTime), CAST(N'2023-08-09T00:00:00' AS SmallDateTime), N'Trixy Bellocht', N'Boy Grissett', N'Con Wapple', N'cwapple13@ask.com', N'Human Resources Manager', N'Product Management', N'386-655-9498', N'803-854-0548', N'TRAVEL294352')
GO
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Pederneiras', N'Qianpai', CAST(N'2023-07-06T00:00:00' AS SmallDateTime), CAST(N'2023-01-15T00:00:00' AS SmallDateTime), N'a suscipit nulla elit ac nulla sed vel enim sit amet nunc viverra dapibus nulla suscipit ligula', N'Bus', NULL, NULL, NULL, NULL, N'36987-1959', N'Wilona Curee', N'wcuree9@studiopress.com', N'Senior Sales Associate', N'Product Management', N'696-561-7108', NULL, 234, N'10')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Nogueira', N'‘Anata', CAST(N'2023-04-27T00:00:00' AS SmallDateTime), CAST(N'2023-03-31T00:00:00' AS SmallDateTime), N'integer tincidunt ante vel ipsum praesent blandit lacinia erat vestibulum sed magna at nunc commodo placerat praesent', N'Bus', NULL, NULL, NULL, NULL, N'52682-026', N'Neville Suscens', N'nsuscens2r@soup.io', N'Tax Accountant', N'Legal', N'416-839-8234', NULL, 2023092311405101, N'100')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'La Floresta', N'Ujar', CAST(N'2022-12-14T00:00:00' AS SmallDateTime), CAST(N'2023-09-23T00:00:00' AS SmallDateTime), N'porta volutpat quam pede lobortis ligula sit amet eleifend pede libero quis orci nullam molestie', N'Car', NULL, NULL, NULL, NULL, N'60512-6611', N'Jermain O''Tierney', N'jotierneyb@com.com', N'Information Systems Manager', N'Sales', N'820-355-3483', NULL, 204, N'12')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Ekibastuz', N'Hanover', CAST(N'2023-04-20T00:00:00' AS SmallDateTime), CAST(N'2022-12-11T00:00:00' AS SmallDateTime), N'odio donec vitae nisi nam ultrices libero non mattis pulvinar nulla pede ullamcorper augue a suscipit nulla elit ac', N'Bus', NULL, NULL, NULL, NULL, N'50804-001', N'Ursa Avramchik', N'uavramchikf@storify.com', N'VP Quality Control', N'Legal', N'769-286-6345', NULL, 284, N'16')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Strezhevoy', N'Okazaki', CAST(N'2023-06-26T00:00:00' AS SmallDateTime), CAST(N'2022-12-20T00:00:00' AS SmallDateTime), N'diam id ornare imperdiet sapien urna pretium nisl ut volutpat sapien arcu sed augue aliquam erat volutpat in', N'Car', NULL, NULL, NULL, NULL, N'0132-0081', N'Wanids Carradice', N'wcarradiceg@blogtalkradio.com', N'Analyst Programmer', N'Legal', N'686-927-7739', NULL, 242, N'17')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Maintang', N'Primero de Mayo', CAST(N'2023-08-01T00:00:00' AS SmallDateTime), CAST(N'2023-07-29T00:00:00' AS SmallDateTime), N'cum sociis natoque penatibus et magnis dis parturient montes nascetur ridiculus', N'Microbus', NULL, NULL, NULL, NULL, N'49288-0577', N'Andreana Cradick', N'acradickh@accuweather.com', N'Professor', N'Human Resources', N'544-323-7719', NULL, 232, N'18')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Tateyama', N'Caper', CAST(N'2023-02-22T00:00:00' AS SmallDateTime), CAST(N'2023-01-27T00:00:00' AS SmallDateTime), N'mauris morbi non lectus aliquam sit amet diam in magna bibendum imperdiet nullam orci pede venenatis non sodales', N'Car', NULL, NULL, NULL, NULL, N'52609-0001', N'Kellina Mercey', N'kmercey1@prweb.com', N'Financial Analyst', N'Accounting', N'688-856-4049', NULL, 251, N'2')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Sakata', N'Treinta y Tres', CAST(N'2023-07-29T00:00:00' AS SmallDateTime), CAST(N'2022-12-08T00:00:00' AS SmallDateTime), N'dictumst morbi vestibulum velit id pretium iaculis diam erat fermentum justo nec condimentum neque sapien placerat ante', N'Bus', NULL, NULL, NULL, NULL, N'0409-7828', N'Colby Pollastrone', N'cpollastronel@woothemes.com', N'Web Developer I', N'Research and Development', N'294-667-7833', NULL, 246, N'22')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Shreveport', N'Lokoja', CAST(N'2023-04-15T00:00:00' AS SmallDateTime), CAST(N'2023-07-17T00:00:00' AS SmallDateTime), N'consectetuer adipiscing elit proin interdum mauris non ligula pellentesque ultrices phasellus id sapien in sapien iaculis congue', N'Bus', NULL, NULL, NULL, NULL, N'0338-0673', N'Conn Cranstoun', N'ccranstounm@ow.ly', N'Cost Accountant', N'Legal', N'318-618-9021', NULL, 235, N'23')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Namyangju', N'Derjan', CAST(N'2023-05-20T00:00:00' AS SmallDateTime), CAST(N'2023-04-16T00:00:00' AS SmallDateTime), N'vel enim sit amet nunc viverra dapibus nulla suscipit ligula in', N'Bus', NULL, NULL, NULL, NULL, N'41250-630', N'Frannie Corroyer', N'fcorroyerp@over-blog.com', N'Budget/Accounting Analyst III', N'Legal', N'374-932-3391', NULL, 283, N'26')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Baiyanghe', N'Dolores', CAST(N'2023-06-03T00:00:00' AS SmallDateTime), CAST(N'2023-01-04T00:00:00' AS SmallDateTime), N'proin risus praesent lectus vestibulum quam sapien varius ut blandit non interdum in ante vestibulum ante ipsum primis in faucibus', N'Microbus', NULL, NULL, NULL, NULL, N'49483-252', N'Mack Pavlovsky', N'mpavlovskyq@ucsd.edu', N'Biostatistician III', N'Support', N'379-853-6673', NULL, 237, N'27')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Hengshi', N'Brusy', CAST(N'2023-07-03T00:00:00' AS SmallDateTime), CAST(N'2022-12-26T00:00:00' AS SmallDateTime), N'nisl ut volutpat sapien arcu sed augue aliquam erat volutpat in', N'Microbus', NULL, NULL, NULL, NULL, N'37000-290', N'Kylie Lavallin', N'klavallins@technorati.com', N'Software Test Engineer III', N'Product Management', N'144-976-1354', NULL, 233, N'29')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Yangpu', N'Madinat ‘Isá', CAST(N'2023-01-11T00:00:00' AS SmallDateTime), CAST(N'2023-02-28T00:00:00' AS SmallDateTime), N'vivamus vel nulla eget eros elementum pellentesque quisque porta volutpat erat', N'Microbus', NULL, NULL, NULL, NULL, N'52125-135', N'Lanie Raynard', N'lraynardt@infoseek.co.jp', N'Occupational Therapist', N'Sales', N'284-343-8686', NULL, 292, N'30')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Saint-Jean-de-Védas', N'Rushanzhai', CAST(N'2023-08-10T00:00:00' AS SmallDateTime), CAST(N'2023-08-24T00:00:00' AS SmallDateTime), N'magnis dis parturient montes nascetur ridiculus mus etiam vel augue vestibulum', N'Bus', NULL, NULL, NULL, NULL, N'57344-028', N'Kathryne Coronas', N'kcoronasu@goo.gl', N'Senior Sales Associate', N'Legal', N'750-125-1062', NULL, 225, N'31')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Copa', N'Ballybofey', CAST(N'2023-09-21T00:00:00' AS SmallDateTime), CAST(N'2023-07-02T00:00:00' AS SmallDateTime), N'integer ac neque duis bibendum morbi non quam nec dui luctus rutrum nulla tellus in', N'Microbus', NULL, NULL, NULL, NULL, N'44924-011', N'Shea Bullas', N'sbullasw@tinypic.com', N'Biostatistician II', N'Accounting', N'892-987-2469', NULL, 291, N'33')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Kosum Phisai', N'Rudnya', CAST(N'2023-02-24T00:00:00' AS SmallDateTime), CAST(N'2023-02-21T00:00:00' AS SmallDateTime), N'donec quis orci eget orci vehicula condimentum curabitur in libero ut massa volutpat convallis morbi odio odio elementum', N'Microbus', NULL, NULL, NULL, NULL, N'55154-2655', N'Brock Bleacher', N'bbleacherx@dmoz.org', N'Budget/Accounting Analyst I', N'Sales', N'824-416-9952', NULL, 296, N'34')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Du Qal‘ah', N'Hayes', CAST(N'2023-07-23T00:00:00' AS SmallDateTime), CAST(N'2023-08-05T00:00:00' AS SmallDateTime), N'ut erat curabitur gravida nisi at nibh in hac habitasse platea dictumst aliquam', N'Car', NULL, NULL, NULL, NULL, N'56136-010', N'Tabby Badwick', N'tbadwicky@miibeian.gov.cn', N'Help Desk Operator', N'Human Resources', N'436-866-5043', NULL, 257, N'35')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Benito Juarez', N'Bulakan', CAST(N'2023-09-17T00:00:00' AS SmallDateTime), CAST(N'2023-04-03T00:00:00' AS SmallDateTime), N'sit amet nunc viverra dapibus nulla suscipit ligula in lacus curabitur at ipsum ac tellus semper', N'Car', NULL, NULL, NULL, NULL, N'47584-001', N'Tabbatha Izkovicz', N'tizkoviczz@tmall.com', N'Internal Auditor', N'Engineering', N'223-730-5517', NULL, 212, N'36')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Jahrom', N'Aibak', CAST(N'2023-03-18T00:00:00' AS SmallDateTime), CAST(N'2022-11-20T00:00:00' AS SmallDateTime), N'blandit nam nulla integer pede justo lacinia eget tincidunt eget tempus vel', N'Microbus', NULL, NULL, NULL, NULL, N'54569-1774', N'Gayel Warner', N'gwarner10@cbc.ca', N'Research Assistant IV', N'Legal', N'685-553-5942', NULL, 213, N'37')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Fengyan', N'Kalian', CAST(N'2022-09-27T00:00:00' AS SmallDateTime), CAST(N'2023-06-06T00:00:00' AS SmallDateTime), N'libero convallis eget eleifend luctus ultricies eu nibh quisque id', N'Bus', NULL, NULL, NULL, NULL, N'11673-094', N'Bel Yatman', N'byatman13@spiegel.de', N'Executive Secretary', N'Accounting', N'959-265-7820', NULL, 256, N'40')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Gunungpeundeuy', N'Hengli', CAST(N'2023-02-27T00:00:00' AS SmallDateTime), CAST(N'2023-01-12T00:00:00' AS SmallDateTime), N'suspendisse potenti in eleifend quam a odio in hac habitasse platea dictumst maecenas ut massa quis', N'Bus', NULL, NULL, NULL, NULL, N'50988-400', N'Annabelle Chidler', N'achidler17@economist.com', N'Quality Control Specialist', N'Support', N'673-647-8749', NULL, 286, N'44')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Adelaide Mail Centre', N'Kinsealy-Drinan', CAST(N'2023-06-07T00:00:00' AS SmallDateTime), CAST(N'2023-07-20T00:00:00' AS SmallDateTime), N'luctus et ultrices posuere cubilia curae duis faucibus accumsan odio curabitur convallis duis consequat dui nec nisi', N'Microbus', NULL, NULL, NULL, NULL, N'66758-047', N'Gerrie Welds', N'gwelds19@e-recht24.de', N'Staff Accountant III', N'Support', N'660-147-3512', NULL, 201, N'46')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Jalinan', N'Sylhet', CAST(N'2023-02-11T00:00:00' AS SmallDateTime), CAST(N'2023-08-20T00:00:00' AS SmallDateTime), N'vitae mattis nibh ligula nec sem duis aliquam convallis nunc proin at', N'Microbus', NULL, NULL, NULL, NULL, N'10424-164', N'Lorens Barnish', N'lbarnish1c@adobe.com', N'Senior Cost Accountant', N'Services', N'310-655-4765', NULL, 259, N'49')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Serpukhov', N'Oyem', CAST(N'2023-02-16T00:00:00' AS SmallDateTime), CAST(N'2023-01-23T00:00:00' AS SmallDateTime), N'nisl duis ac nibh fusce lacus purus aliquet at feugiat non pretium quis', N'Bus', NULL, NULL, NULL, NULL, N'49288-0063', N'Nora Geeraert', N'ngeeraert1d@t-online.de', N'Product Engineer', N'Engineering', N'515-885-5535', NULL, 269, N'50')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Ziftá', N'Dusun Desa Bunter', CAST(N'2023-02-17T00:00:00' AS SmallDateTime), CAST(N'2023-04-16T00:00:00' AS SmallDateTime), N'sapien quis libero nullam sit amet turpis elementum ligula vehicula consequat morbi a ipsum', N'Bus', NULL, NULL, NULL, NULL, N'55670-468', N'Cayla Leber', N'cleber1g@amazon.de', N'Budget/Accounting Analyst I', N'Services', N'779-956-4144', NULL, 226, N'53')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Orekhovo-Zuyevo', N'Yangyong', CAST(N'2023-05-17T00:00:00' AS SmallDateTime), CAST(N'2022-12-06T00:00:00' AS SmallDateTime), N'mattis odio donec vitae nisi nam ultrices libero non mattis pulvinar', N'Microbus', NULL, NULL, NULL, NULL, N'0904-6170', N'Mic Airth', N'mairth1h@vk.com', N'Tax Accountant', N'Marketing', N'514-656-1887', NULL, 230, N'54')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Shalazhi', N'Novyye Kuz’minki', CAST(N'2023-07-28T00:00:00' AS SmallDateTime), CAST(N'2023-01-07T00:00:00' AS SmallDateTime), N'facilisi cras non velit nec nisi vulputate nonummy maecenas tincidunt lacus at velit vivamus vel nulla eget', N'Bus', NULL, NULL, NULL, NULL, N'0517-5034', N'Mirilla Pargetter', N'mpargetter1m@exblog.jp', N'Legal Assistant', N'Engineering', N'746-135-1242', NULL, 206, N'59')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Cibeureum', N'Niihama', CAST(N'2022-12-24T00:00:00' AS SmallDateTime), CAST(N'2022-10-08T00:00:00' AS SmallDateTime), N'nam ultrices libero non mattis pulvinar nulla pede ullamcorper augue', N'Car', NULL, NULL, NULL, NULL, N'13537-114', N'August Dunton', N'adunton5@cyberchimps.com', N'Pharmacist', N'Sales', N'274-467-0496', NULL, 260, N'6')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Sandakan', N'Babakandesa', CAST(N'2022-12-02T00:00:00' AS SmallDateTime), CAST(N'2023-05-04T00:00:00' AS SmallDateTime), N'odio odio elementum eu interdum eu tincidunt in leo maecenas pulvinar lobortis est phasellus sit amet', N'Microbus', NULL, NULL, NULL, NULL, N'64679-312', N'Ulrika Truesdale', N'utruesdale1o@upenn.edu', N'VP Product Management', N'Business Development', N'580-770-0594', NULL, 207, N'61')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Quibdó', N'Javanrud', CAST(N'2023-04-29T00:00:00' AS SmallDateTime), CAST(N'2023-03-25T00:00:00' AS SmallDateTime), N'risus semper porta volutpat quam pede lobortis ligula sit amet eleifend', N'Bus', NULL, NULL, NULL, NULL, N'16590-022', N'Manda Raycroft', N'mraycroft1p@wikimedia.org', N'Structural Engineer', N'Engineering', N'315-782-0643', NULL, 267, N'62')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Funga', N'Surin', CAST(N'2023-09-10T00:00:00' AS SmallDateTime), CAST(N'2023-08-31T00:00:00' AS SmallDateTime), N'eleifend pede libero quis orci nullam molestie nibh in lectus pellentesque at nulla suspendisse potenti cras in purus', N'Bus', NULL, NULL, NULL, NULL, N'63629-4462', N'Gerick Rymill', N'grymill1s@is.gd', N'VP Marketing', N'Marketing', N'158-723-6177', NULL, 240, N'65')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Putrajaya', N'Zhaocun', CAST(N'2023-06-01T00:00:00' AS SmallDateTime), CAST(N'2023-02-26T00:00:00' AS SmallDateTime), N'placerat ante nulla justo aliquam quis turpis eget elit sodales scelerisque mauris sit amet eros suspendisse accumsan tortor quis', N'Microbus', NULL, NULL, NULL, NULL, N'54738-914', N'Johnnie Mowett', N'jmowett1t@pcworld.com', N'Computer Systems Analyst III', N'Legal', N'401-548-6324', NULL, 262, N'66')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Puyan', N'Manjo', CAST(N'2023-06-02T00:00:00' AS SmallDateTime), CAST(N'2023-06-22T00:00:00' AS SmallDateTime), N'nisi at nibh in hac habitasse platea dictumst aliquam augue quam sollicitudin', N'Microbus', NULL, NULL, NULL, NULL, N'51997-035', N'Colas Ralfe', N'cralfe1x@hp.com', N'Help Desk Operator', N'Human Resources', N'696-784-2918', NULL, 277, N'70')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Banjar Tengah', N'Hrtkovci', CAST(N'2023-08-09T00:00:00' AS SmallDateTime), CAST(N'2022-12-31T00:00:00' AS SmallDateTime), N'in leo maecenas pulvinar lobortis est phasellus sit amet erat nulla', N'Bus', NULL, NULL, NULL, NULL, N'0378-5445', N'Lotte Bouda', N'lbouda1y@howstuffworks.com', N'Nuclear Power Engineer', N'Accounting', N'538-455-7608', NULL, 268, N'71')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Nassarawa', N'Aguilares', CAST(N'2023-03-11T00:00:00' AS SmallDateTime), CAST(N'2023-02-14T00:00:00' AS SmallDateTime), N'tellus nulla ut erat id mauris vulputate elementum nullam varius nulla facilisi cras non velit nec nisi vulputate nonummy maecenas', N'Microbus', NULL, NULL, NULL, NULL, N'42002-514', N'Carolin Jellico', N'cjellico1z@hibu.com', N'Editor', N'Services', N'205-275-3763', NULL, 236, N'72')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Ibaté', N'Kremidivka', CAST(N'2022-09-29T00:00:00' AS SmallDateTime), CAST(N'2023-04-27T00:00:00' AS SmallDateTime), N'metus vitae ipsum aliquam non mauris morbi non lectus aliquam sit amet diam in magna bibendum imperdiet nullam orci', N'Bus', NULL, NULL, NULL, NULL, N'25021-101', N'Kyla McFfaden', N'kmcffaden21@free.fr', N'Civil Engineer', N'Marketing', N'392-595-5042', NULL, 299, N'74')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Vrdy', N'Nyzhni Sirohozy', CAST(N'2023-03-12T00:00:00' AS SmallDateTime), CAST(N'2023-08-22T00:00:00' AS SmallDateTime), N'at turpis donec posuere metus vitae ipsum aliquam non mauris morbi non lectus', N'Bus', NULL, NULL, NULL, NULL, N'66854-024', N'Sile Beeswing', N'sbeeswing22@tinypic.com', N'VP Product Management', N'Training', N'324-334-7971', NULL, 272, N'75')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Pulorejo', N'Buckland', CAST(N'2022-11-14T00:00:00' AS SmallDateTime), CAST(N'2022-09-30T00:00:00' AS SmallDateTime), N'tincidunt eu felis fusce posuere felis sed lacus morbi sem', N'Bus', NULL, NULL, NULL, NULL, N'66897-002', N'Dael Hasser', N'dhasser24@soundcloud.com', N'VP Sales', N'Legal', N'887-860-3150', NULL, 239, N'77')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Tampa', N'Garawati', CAST(N'2023-05-05T00:00:00' AS SmallDateTime), CAST(N'2023-06-28T00:00:00' AS SmallDateTime), N'ac consequat metus sapien ut nunc vestibulum ante ipsum primis in', N'Bus', NULL, NULL, NULL, NULL, N'42912-0152', N'Bibbye Dust', N'bdust28@bluehost.com', N'Recruiter', N'Business Development', N'813-865-5994', NULL, 241, N'81')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Linghu', N'Sernovodsk', CAST(N'2022-11-26T00:00:00' AS SmallDateTime), CAST(N'2023-03-31T00:00:00' AS SmallDateTime), N'a odio in hac habitasse platea dictumst maecenas ut massa', N'Car', NULL, NULL, NULL, NULL, N'0268-0650', N'Elysia Gladdis', N'egladdis2c@4shared.com', N'Legal Assistant', N'Support', N'229-372-4810', NULL, 222, N'85')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Casisang', N'Bralin', CAST(N'2023-01-10T00:00:00' AS SmallDateTime), CAST(N'2023-03-24T00:00:00' AS SmallDateTime), N'integer aliquet massa id lobortis convallis tortor risus dapibus augue vel', N'Microbus', NULL, NULL, NULL, NULL, N'13811-606', N'Charlotte Brameld', N'cbrameld2d@wp.com', N'Sales Representative', N'Legal', N'167-711-9200', NULL, 211, N'86')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Laban', N'Jocotán', CAST(N'2023-01-29T00:00:00' AS SmallDateTime), CAST(N'2023-06-22T00:00:00' AS SmallDateTime), N'nisi vulputate nonummy maecenas tincidunt lacus at velit vivamus vel nulla eget eros elementum pellentesque quisque porta volutpat erat', N'Microbus', NULL, NULL, NULL, NULL, N'64661-811', N'Skippie Swatten', N'sswatten2h@google.ru', N'Cost Accountant', N'Sales', N'706-175-6219', NULL, 288, N'90')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Tbilisskaya', N'Otavi', CAST(N'2022-10-22T00:00:00' AS SmallDateTime), CAST(N'2023-08-18T00:00:00' AS SmallDateTime), N'luctus et ultrices posuere cubilia curae duis faucibus accumsan odio curabitur convallis duis', N'Microbus', NULL, NULL, NULL, NULL, N'10019-506', N'Rolfe Petry', N'rpetry2m@reverbnation.com', N'Librarian', N'Research and Development', N'831-930-5741', NULL, 250, N'95')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Siparia', N'Zhangdian', CAST(N'2023-08-28T00:00:00' AS SmallDateTime), CAST(N'2023-05-06T00:00:00' AS SmallDateTime), N'a feugiat et eros vestibulum ac est lacinia nisi venenatis tristique fusce congue diam id ornare', N'Microbus', NULL, NULL, NULL, NULL, N'49349-069', N'Bryana Stainbridge', N'bstainbridge2o@hugedomains.com', N'Food Chemist', N'Research and Development', N'970-532-0254', NULL, 227, N'97')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Jinhe', N'Begejci', CAST(N'2022-11-01T00:00:00' AS SmallDateTime), CAST(N'2023-04-12T00:00:00' AS SmallDateTime), N'ultrices mattis odio donec vitae nisi nam ultrices libero non mattis pulvinar nulla pede', N'Microbus', NULL, NULL, NULL, NULL, N'0245-0041', N'Sallyann Dudley', N'sdudley2p@people.com.cn', N'Senior Financial Analyst', N'Training', N'387-250-1966', NULL, 265, N'98')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Suex', N'Cairo', CAST(N'2023-09-27T00:00:00' AS SmallDateTime), CAST(N'2023-09-28T00:00:00' AS SmallDateTime), N'Some Description ', N'Car', CAST(N'2023-09-27T11:24:00' AS SmallDateTime), NULL, N'Rewan Hosny', NULL, N'1396', N'Rewan Hosny', N'rhosny@dpwsapps.com', N'IT Developer', N'IT', N'01171769160', N'35998', 2023092711241573, N'Vehicle-20230927112415')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Suex', N'Cairo', CAST(N'2023-09-27T00:00:00' AS SmallDateTime), CAST(N'2023-09-28T00:00:00' AS SmallDateTime), N'Some Description ', N'Car', CAST(N'2023-09-27T11:26:00' AS SmallDateTime), NULL, N'Rewan Hosny', NULL, N'1396', N'Rewan Hosny', N'rhosny@dpwsapps.com', N'IT Developer', N'IT', N'01171769160', N'35998', 2023092711243793, N'Vehicle-20230927112438')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Suez', N'Cairo', CAST(N'2023-09-28T00:00:00' AS SmallDateTime), CAST(N'2023-09-29T00:00:00' AS SmallDateTime), N'LuggageDescription ', N'Car', CAST(N'2023-09-27T11:33:00' AS SmallDateTime), NULL, N'Rewan Hosny', NULL, N'1396', N'Rewan Hosny', N'rhosny@dpwsapps.com', N'IT Developer', N'IT', N'01171769160', N'2569', 2023092711332214, N'Vehicle-20230927113322')
INSERT [dbo].[VehicleRequest] ([DepartureAddress], [DestinationAddress], [DepartureDate], [ReturnDate], [LuggageDescription], [VehicleType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [RequestNumber]) VALUES (N'Suez', N'Aswan', CAST(N'2023-10-01T00:00:00' AS SmallDateTime), CAST(N'2023-10-10T00:00:00' AS SmallDateTime), N'fadya', N'Bus', CAST(N'2023-09-27T11:44:00' AS SmallDateTime), CAST(N'2023-09-27T11:53:00' AS SmallDateTime), N'Rewan Hosny', N'Rewan Hosny', N'1396', N'Rewan Hosny', N'rhosny@dpwsapps.com', N'IT Developer', N'IT', N'01171769160', N'2568', 2023092711434278, N'Vehicle-20230927114342')
GO
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp], [CreatedAt], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (N'04cd21f1-113b-477e-a517-7dcb1ea8a024', N'IT', N'IT', N'0cb746df-5bf7-497b-adec-21063f3e42bb', NULL, N'', NULL, N'')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp], [CreatedAt], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (N'120a9027-4229-4379-95ce-b6bfd1333e0c', N'CustomerService', N'CUSTOMERSERVICE', N'9d6e19e1-be12-42b0-bdcd-402fd83e7d74', NULL, N'', NULL, N'')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp], [CreatedAt], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (N'121c1742-99e7-4b61-ab2f-f748876e2975', N'Finance', N'FINANCE', N'47feedcb-d4df-44c5-9584-0da7edac1342', NULL, N'', NULL, N'')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp], [CreatedAt], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (N'1ee5bd21-f548-47f6-918f-2b0b7625ded2', N'Administration', N'ADMINISTRATION', N'abd87636-ff1d-4bdc-8960-f45eb4c66a22', NULL, N'', NULL, N'')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp], [CreatedAt], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (N'32044808-6d0e-4e18-be60-0606ae9d51ae', N'Security', N'SECURITY', N'2493c125-eb40-4344-abb8-6c95d270d54e', NULL, N'', NULL, N'')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp], [CreatedAt], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (N'3cb27f9e-80bf-4383-9aa2-e56f7b730b10', N'OperationBGC', N'OPERATIONBGC', N'5ec576a8-fd80-4004-9973-40ff6f834463', NULL, N'', NULL, N'')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp], [CreatedAt], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (N'6826ac7e-b4ae-47ff-8bf6-cc904db43d84', N'Procurement', N'PROCUREMENT', N'90904c3c-9b4a-4f7c-a44d-cc443612bf64', NULL, N'', NULL, N'')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp], [CreatedAt], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (N'7bf924d4-2d36-44b2-9dcd-be12b2593e54', N'InfoFort', N'INFOFORT', N'87164c35-3488-41e9-beb4-eaaa141514d1', NULL, N'', NULL, N'')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp], [CreatedAt], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (N'9580fd22-e5e7-4a6f-a316-30119f8c10fc', N'Engineering', N'ENGINEERING', N'1a2b457b-723e-4958-83f8-d0af4e675b02', NULL, N'', NULL, N'')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp], [CreatedAt], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (N'a4c5c4a0-6b0a-4639-a8eb-95d068413b24', N'SuperAdmin', N'SUPERADMIN', N'19341457-eaf0-481d-96d6-4839778c1f0b', NULL, N'', NULL, N'')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp], [CreatedAt], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (N'be82457f-910a-4e86-b95b-187c5af7980e', N'HR', N'HR', N'48e8b5f1-d719-4224-975d-1ceb0e6d6b96', NULL, N'', NULL, N'')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp], [CreatedAt], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (N'c08d8152-6409-46a2-b515-f5f10528a437', N'Store', N'STORE', N'4225b60a-7de8-4913-8b91-0ded0813743a', NULL, N'', NULL, N'')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp], [CreatedAt], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (N'cbbe579c-cf18-4975-aa7f-9f90d412c30e', N'OperationCT', N'OPERATIONCT', N'41aae6bd-346d-48a9-8ce6-7a7fc1a278ce', NULL, N'', NULL, N'')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp], [CreatedAt], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (N'd220a87b-7988-4e18-a15d-36277033f5e2', N'Commercial', N'COMMERCIAL', N'0301f15f-6cb7-4daa-9c97-eca012b4c10b', NULL, N'', NULL, N'')
INSERT [security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp], [CreatedAt], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (N'f6a9fa19-0beb-4c17-8c57-47cc6930d654', N'Communications', N'COMMUNICATIONS', N'18c91c20-b3f3-48b7-b691-d3c1171ffa1e', NULL, N'', NULL, N'')
GO
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'1396', N'rhosny', N'RHOSNY', N'Rewan Hosny', N'IT Developer', 12, 13, N'51331', N'DP World', 1, 1, CAST(N'2023-10-01T12:29:00' AS SmallDateTime), CAST(N'2023-09-26T12:02:00' AS SmallDateTime), CAST(N'2023-10-01T12:29:00' AS SmallDateTime), NULL, NULL, N'rhosny@dpwsapps.com', N'RHOSNY@DPWSAPPS.COM', 0, N'AQAAAAIAAYagAAAAEP/M9bYH0NOX64fb5Mjd1EM2XVHxAhFxblio5F9a77uCg4ilfcHr2mnj6ZbtTogn3w==', N'ZDYWSOAGDCOX7BUB23XYG2A7Q2NWHDCJ', N'ff5adf67-1d17-4ab9-aaed-188b19552c19', N'01171769160', 0, 0, NULL, 1, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50000', N'stores_manager', N'STORES_MANAGER', N'Ahmed Zaki', N'Head of Stores', 20, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'stores_manager@dpworld.com', N'STORES_MANAGER@DPWORLD.COM', 0, NULL, N'2115898c-b373-4dd3-942e-7afe6efbe475', N'08058637-5c78-4ee0-bf46-5289ce5a1d2a', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50128', N'ops-cfs_sec_head', N'OPS-CFS_SEC_HEAD', N'Ahmed Zaki', N'OPS-CFS Section Head', 14, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'ops-cfs_sec_head@dpworld.com', N'OPS-CFS_SEC_HEAD@DPWORLD.COM', 0, NULL, N'227bba2b-b407-41be-9524-2b91048537af', N'20fdd9e6-15fc-49a7-8b19-2448ed21bbf9', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50136', N'engineering_manager', N'ENGINEERING_MANAGER', N'Ahmed Zaki', N'Head of Engineering', 21, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'engineering_manager@dpworld.com', N'ENGINEERING_MANAGER@DPWORLD.COM', 0, NULL, N'9303e964-b5b0-4923-bf3b-1167d1a12567', N'9e4b7600-9e8e-4995-8294-d56d4ab91972', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50140', N'hc-ssp_manager', N'HC-SSP_MANAGER', N'Maged Mohsen', N'Head of HC - Samsung SDS project', 11, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'hc-ssp_manager@dpworld.com', N'HC-SSP_MANAGER@DPWORLD.COM', 0, NULL, N'9a1ceef9-bb1f-41ca-a6eb-45bc95d8d757', N'a343e06b-466d-4a56-b20b-0939f6bde527', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50141', N'ops-ct_manager', N'OPS-CT_MANAGER', N'Maged Mohsen', N'Head of OPS-Containers', 14, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'ops-ct_manager@dpworld.com', N'OPS-CT_MANAGER@DPWORLD.COM', 0, NULL, N'0d694f20-68d4-474a-85f0-cad6e322aa11', N'0e69d77a-bece-4fd5-8353-a3ea90ce46c6', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50263', N'security_manager', N'SECURITY_MANAGER', N'Ahmed Zaki', N'Head of Security', 19, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'security_manager@dpworld.com', N'SECURITY_MANAGER@DPWORLD.COM', 0, NULL, N'2f383b06-7418-4b37-a4a9-09976907bdd9', N'8e837158-4181-4d63-b995-c2d0cfb14797', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50269', N'azaki', N'ADMIN_MANAGER', N'Ahmed Zaki', N'Head of Administration', 1, NULL, NULL, N'DP World', 1, 1, CAST(N'2023-09-26T20:45:00' AS SmallDateTime), NULL, CAST(N'2023-09-26T20:45:00' AS SmallDateTime), NULL, NULL, N'admin_manager@dpworld.com', N'ADMIN_MANAGER@DPWORLD.COM', 0, NULL, N'3022d57b-ee8f-4c90-b006-ab6f100ebdd0', N'8a68c06e-2632-4056-8352-8c5f34dc88aa', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50279', N'people_manager', N'PEOPLE_MANAGER', N'Waleed Aboelgadayl', N'Head of People', 15, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'people_manager@dpworld.com', N'PEOPLE_MANAGER@DPWORLD.COM', 0, NULL, N'f86c3b61-a8e8-4f5e-987a-c8a519c37284', N'5c662483-b2b4-4303-93dc-d1ab8de84ff9', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50354', N'ops-bgc_manager', N'OPS-BGC_MANAGER', N'Mohamed Radwan', N'Head of OPS-Cargo & Bulk', 13, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'ops-bgc_manager@dpworld.com', N'OPS-BGC_MANAGER@DPWORLD.COM', 0, NULL, N'b59c1a3c-1c63-4c6c-81ef-2e2bae14313f', N'90855e54-a200-45c4-bab3-5f6194483d00', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50562', N'tec-planning_sec_head', N'TEC-PLANNING_SEC_HEAD', N'Ahmed Zaki', N'TEC-Planning Section Head', NULL, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'tec-planning_sec_head@dpworld.com', N'TEC-PLANNING_SEC_HEAD@DPWORLD.COM', 0, NULL, N'1ddabcbe-352b-4c7d-b2be-68dc73aef846', N'7ff6a734-6b38-4768-a2b8-5e1e28bd6152', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50670', N'ops-ct_sec_head', N'OPS-CT_SEC_HEAD', N'Ahmed Zaki', N'OPS-Containers Section Head', 14, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'ops-ct_sec_head@dpworld.com', N'OPS-DRI_SEC_HEAD@DPWORLD.COM', 0, NULL, N'eeeec46d-9eb7-4784-a1ba-bea2a0ef5826', N'e1e43d6e-4aa9-4d1d-96b0-9de9d7e6f431', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50844', N'ops-dri_sec_head', N'OPS-DRI_SEC_HEAD', N'Ahmed Zaki', N'OPS-DRI Section Head', 13, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'ops-dri_sec_head@dpworld.com', N'OPS-DRI_SEC_HEAD@DPWORLD.COM', 0, NULL, N'd1ebd188-8c51-4c0b-a362-03b0a79f6072', N'be4969d3-c125-47c8-8f61-a0f1729d6e84', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50882', N'qhse_manager', N'QHSE_MANAGER', N'Hassan Abdelghany', N'Head of QHSE', 18, NULL, NULL, N'DP World', 1, 1, NULL, NULL, CAST(N'2023-09-26T08:07:00' AS SmallDateTime), NULL, NULL, N'qhse_manager@dpworld.com', N'QHSE_MANAGER@DPWORLD.COM', 0, NULL, N'95875c11-ea31-4c7a-b846-53eca1eb23dc', N'd9a0491f-51c9-426c-b544-83de16a80b36', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'50962', N'gr_manager', N'GR_MANAGER', N'Mohamed Tarek', N'Head of Governmental Relation', 9, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'governmentalrelation_manager@dpworld.com', N'GOVERNMENTALRELATION_MANAGER@DPWORLD.COM', 0, NULL, N'50a51e20-4c69-4f0d-97cc-cac4255ab84e', N'3a9d0231-c45e-4e32-b9dd-9348b1a7e541', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51090', N'tec-crane_sec_head', N'TEC-CRANE_SEC_HEAD', N'Ahmed Zaki', N'TEC-Crane Section Head', 21, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'tec-crane_sec_head@dpworld.com', N'TEC-CRANE_SEC_HEAD@DPWORLD.COM', 0, NULL, N'50603250-1867-4f4e-9b19-cb56e1520c84', N'3ca49d77-f2de-4240-95e5-d8c55f0fa1e9', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51111', N'whegab', N'WHEGAB', N'Walid Hegab', N'Sr. Executive administration', 1, 1, N'50269', N'DP World', 1, 1, NULL, CAST(N'2023-09-17T15:31:00' AS SmallDateTime), NULL, NULL, NULL, N'whegab@dpwsapps.com', N'USER@EXAMPLE.COM', 0, N'AQAAAAIAAYagAAAAEAI5JGyKSLGlfkXRKZ0CbYuAzQUDkbdVPB93/F2kT6wcgWGklsWRUMM5g4QKyVunew==', N'RZNW7Y64POKQ3R56VLG3ZFZERIXNB2JU', N'facdd0ad-0ced-4a22-94e3-91b2c23ff61b', N'01543889566', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51124', N'finance_manager', N'FINANCE_MANAGER', N'Mustafa Sultan', N'Head of Finance', 8, NULL, NULL, N'DP World', 1, 1, CAST(N'2023-09-21T15:05:00' AS SmallDateTime), NULL, CAST(N'2023-09-21T15:05:00' AS SmallDateTime), NULL, NULL, N'finance_manager@dpworld.com', N'FINANCE_MANAGER@DPWORLD.COM', 0, NULL, N'55f99da3-494c-4c79-a982-f1b5cff02337', N'c83c4fd0-27db-4bfc-9136-3d509b449841', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51126', N'tec-workshop_sec_head', N'TEC-WORKSHOP_SEC_HEAD', N'Ahmed Zaki', N'TEC-Workshop Section Head', 21, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'tec-workshop_sec_head@dpworld.com', N'TEC-WORKSHOP_SEC_HEAD@DPWORLD.COM', 0, NULL, N'af616dc1-3c87-4b8b-913e-7b1415a28312', N'f067707d-6738-4240-8e9f-365f92787e66', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51188', N'procurment_manager', N'PROCURMENT_MANAGER', N'Tamer Elsayed', N'Head of Procurment', 16, NULL, NULL, N'DP World', 1, 1, CAST(N'2023-09-24T18:54:00' AS SmallDateTime), NULL, CAST(N'2023-09-24T18:54:00' AS SmallDateTime), NULL, NULL, N'procurement_manager@dpworld.com', N'PROCUREMENT_MANAGER@DPWORLD.COM', 0, NULL, N'c8e88d79-8d90-488f-b5a4-2b0450658ab4', N'88074d8c-f0dc-49df-8767-9aadff185df4', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51229', N'cs_manager', N'CS_MANAGER', N'Hassan Nagah', N'Head of Customer Service', 6, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'customerservice_manager@dpworld.com', N'CUSTOMERSERVICE_MANAGER@DPWORLD.COM', 0, NULL, N'd57f2a46-154a-4fd0-b57a-32ab5274a9ce', N'ae93a9ef-ccf9-4ab3-ba05-ded041592bae', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51330', N'bt_manager', N'BT_MANAGER', N'Alaa Nasr', N'Head of Business Transformation', 3, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'businesstransformation_manager@dpworld.com', N'BUSINESSTRANSFORMATION_MANAGER@DPWORLD.COM', 0, NULL, N'4067c183-f52f-4dd7-a0da-7d9ad1ed1248', N'44a8dcb1-37d9-4139-9620-162be1b386b2', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51331', N'anasr', N'IT_MANAGER', N'Alaa Nasr', N'Head of IT', 12, NULL, NULL, N'DP World', 1, 1, CAST(N'2023-10-01T12:24:00' AS SmallDateTime), NULL, CAST(N'2023-10-01T12:24:00' AS SmallDateTime), NULL, NULL, N'it_manager@dpworld.com', N'IT_MANAGER@DPWORLD.COM', 0, NULL, N'48b01c3d-fe95-40b8-843e-99b2ce95444c', N'8fa5f6e0-8cdc-4c43-a183-f3d33db6c65b', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51449', N'ops-cg_sec_head', N'OPS-CG_SEC_HEAD', N'Ahmed Zaki', N'OPS-Cargo & Bulk Section Head', 13, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'ops-cg_sec_head@dpworld.com', N'OPS-CG_SEC_HEAD@DPWORLD.COM', 0, NULL, N'203c9bad-ceba-443c-922d-df68c0fd7ae8', N'd215bffd-bfcd-4833-84ad-961c8205fbed', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51509', N'commercial-ct_sec_head', N'COMMERCIAL-CT_SEC_HEAD', N'Ahmed Zaki', N'Commercial / Containers Section Head', 4, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'commercial-ct_sec_head@dpworld.com', N'ECOMMERCIAL-CT_SEC_HEAD@DPWORLD.COM', 0, NULL, N'b36e2663-69da-4d7b-a0ce-ee1820c8bbc4', N'5a0e33e4-eeb3-4aef-aaf8-ea2a158502f6', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51520', N'qhse_sec_head', N'QHSE_SEC_HEAD', N'Ahmed Zaki', N'QHSE Section HEad', 18, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'qhse_sec_head@dpworld.com', N'QHSE_SEC_HEAD@DPWORLD.COM', 0, NULL, N'1b3f1fd0-52ec-4013-93f8-842d3c59f009', N'135c8667-b22c-4e8c-88f0-0debd0ff68e5', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51529', N'projects_sec_head', N'PROJECTS_SEC_HEAD', N'Ahmed Zaki', N'Projects Section Head', 21, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'projects_sec_head@dpworld.com', N'PROJECTS_SEC_HEAD@DPWORLD.COM', 0, NULL, N'074fa243-fc73-4473-be60-d4d34c5166b6', N'0b02eab9-3fb0-46e6-a0ab-fa3d6757b9eb', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51555', N'aasem', N'AASEM', N'Amr Asem', N'Chief Accountant', 8, 9, N'51124', N'DP World', 1, 1, CAST(N'2023-10-01T12:14:00' AS SmallDateTime), CAST(N'2023-09-24T13:45:00' AS SmallDateTime), CAST(N'2023-10-01T12:14:00' AS SmallDateTime), NULL, NULL, N'aasem@dpwsapps.com', N'AASEM@DPWSAPPS.COM', 0, N'AQAAAAIAAYagAAAAEIqeL+uOLUqHeJBUeuHslIIBCjG9KCp8gzXlEW5IDXEHCwpq50OMZaMLUSTBmPKlUg==', N'DEN73BT6UARRYU7P75AG7OV7TX474TR5', N'06ea6675-e503-4056-95ad-8ebabb114d31', N'01004454269', 0, 0, NULL, 1, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51572', N'hc-ds_manager', N'HC-DS_MANAGER', N'Aliaa Elgammal', N'Head of HC - DUBUY Sales', 10, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'hc-ds_manager@dpworld.com', N'HC-DS_MANAGER@DPWORLD.COM', 0, NULL, N'1518219d-b054-4c2d-8b92-63628e66a31e', N'd9769687-7427-4632-921b-eb1271d59ab1', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51573', N'commercial_manager', N'COMMERCIAL_MANAGER', N'Aliaa Elgammal', N'Head of Commercial', 4, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'commercial_manager@dpworld.com', N'COMMERCIAL_MANAGER@DPWORLD.COM', 0, NULL, N'6f8c9d1a-19af-4e10-b42f-00003a78393a', N'8faf76f3-4e71-4492-afcb-646dd49f796c', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51583', N'commercial-bgc_sec_head', N'COMMERCIAL-BGC_SEC_HEAD', N'Ahmed Zaki', N'CommercialBulk / GC Section Head', 4, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'commercial-bgc_sec_head@dpworld.com', N'ECOMMERCIAL-BGC_SEC_HEAD@DPWORLD.COM', 0, NULL, N'7d16ac0e-5aac-4d72-9cf8-e42d41bf376e', N'0c62b0aa-d590-45d3-971b-596406232aaa', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51585', N'ahamad', N'AHAMAD', N'Alaa Hamad', N'Accountant', 8, 9, N'51555', N'DP World', 1, 1, CAST(N'2023-09-25T19:29:00' AS SmallDateTime), CAST(N'2023-09-24T13:46:00' AS SmallDateTime), CAST(N'2023-09-25T19:29:00' AS SmallDateTime), NULL, NULL, N'ahamad@dpwsapps.com', N'AHAMAD@DPWSAPPS.COM', 0, N'AQAAAAIAAYagAAAAEBtFCipCq7exMAB6dPu//OIWiY7GxgI+smobyHn4EJebxPOmwS++f0s8yuXp7N8iBw==', N'HKPCZNZUCSMM4RLUGIDEAU3TLDPMH2RA', N'0e2532ec-34d6-4076-812a-c639696a118b', N'01004454269', 0, 0, NULL, 1, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51588', N'ssamy', N'SSAMY', N'Shireen Samy', N'Procurment Specialist', 16, 19, N'51188', N'DP World', 1, 1, CAST(N'2023-09-28T21:21:00' AS SmallDateTime), CAST(N'2023-09-24T13:47:00' AS SmallDateTime), CAST(N'2023-09-28T21:21:00' AS SmallDateTime), NULL, NULL, N'ssamy@dpwsapps.com', N'SSAMY@DPWSAPPS.COM', 0, N'AQAAAAIAAYagAAAAEOq0loiM3brmV1BE25iOpiODvZmQY5MdyvPx89GYvY2HIJ8TVubpKTUs8hbJKA7LyQ==', N'ZZWLKWMZN5F4VBRKSWSWHTAFTFZMTKAT', N'614f0387-87d4-4b44-be16-129a64e8f6c7', N'01004454269', 0, 0, NULL, 1, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51659', N'projects_manager', N'PROJECTS_MANAGER', N'Mohamed Mandour', N'Head of Projects & Facility Management', 17, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'projectsfacilitymanager_manager@dpworld.com', N'PROJECTSFACILITYMANAGER_MANAGER@DPWORLD.COM', 0, NULL, N'6bf3f026-4fef-4778-873f-71a64f524371', N'4222d63c-2131-4e7a-9c32-b3486764bfd1', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51668', N'communications_manager', N'COMMUNICATIONS_MANAGER', N'Amina Hatem', N'Head of Communications', 5, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'communications_manager@dpworld.com', N'COMMUNICATIONS_MANAGER@DPWORLD.COM', 0, NULL, N'01b5da8f-ca29-4f16-aa20-48f6a2f8f7f6', N'de3637c4-aefa-4be7-b079-bdadff880525', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'54339', N'aramzy', N'ARAMZY', N'Afnan Ramzy', N'Procurement Specialist', 16, 19, N'51188', N'DP World', 1, 1, CAST(N'2023-09-25T19:33:00' AS SmallDateTime), CAST(N'2023-09-25T19:22:00' AS SmallDateTime), CAST(N'2023-09-25T19:33:00' AS SmallDateTime), NULL, NULL, N'aramzy@dpwsapps.com', N'ARAMZY@DPWSAPPS.COM', 0, N'AQAAAAIAAYagAAAAEMBg2U+hdQxSX33HUQaOPd32NHQX72ZxzteAZwju/HN4HEYRkbBH8XrbyfJZHD132g==', N'PDQF67US5572Z6SZXRKHZEJ7GINU42ZJ', N'60e8f648-ddcf-4e4a-99de-b44d7a20b964', N'01247118183', 0, 0, NULL, 1, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'5587', N'test', N'TEST', N'test user', N'string', NULL, NULL, NULL, N'string', 0, 1, NULL, CAST(N'2023-09-18T08:49:00' AS SmallDateTime), CAST(N'2023-09-18T08:59:00' AS SmallDateTime), NULL, NULL, N'test@example.com', N'TEST@EXAMPLE.COM', 0, N'AQAAAAIAAYagAAAAEI8g/2wrzGNKcmcdDIHJ1BYRZt0YkhQv7gv8YxwZKCgWFbpxjRttXTCzvo2j92UUJA==', N'L6Q5LWF6LUJCEBPRVZHFSRSUTT6X6GO4', N'97a04829-0c7b-4c89-8e40-e74b87f3104b', N'01534278431', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'55887', N'mkamal', N'MKAMAL', N'Mohamed Kamal', N'Transportation Team Leader', 1, 1, N'50269', N'DP World', 1, 1, NULL, CAST(N'2023-09-26T12:41:00' AS SmallDateTime), CAST(N'2023-09-26T12:44:00' AS SmallDateTime), NULL, NULL, N'mkamal@dpwsapps.com', N'MKAMAL@DPWSAPPS.COM', 0, N'AQAAAAIAAYagAAAAEEGcc86ypGrdIKxNjmeGaVe/Td+8Y7eU2/Klw2wL+mpmkC5ixWgp0lMunXdoZeTERw==', N'4JZLXTFI7TMPQ7SD45NV2A6TYQF6NZCY', N'bf9fad90-d35f-4e43-bae3-d02d4a33e26f', N'01074262171', 0, 0, NULL, 1, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'90008', N'hc-ds_sec_head', N'HC-DS_SEC_HEAD', N'Ahmed Zaki', N'HC - DUBUY Sales Section Head', 11, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'hc-ds_sec_head@dpworld.com', N'HC-DS_SEC_HEAD@DPWORLD.COM', 0, NULL, N'ff4db77c-b9f9-4fba-aaa2-72fbe072ce01', N'b237d382-049a-4ea2-a20d-6c25098df559', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'90010', N'ff_manager', N'FF_MANAGER', N'Hanaa Mohamed', N'Head of Freight Forwarding', 2, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'freightforwarding_manager@dpworld.com', N'FREIGHTFORWARDING_MANAGER@DPWORLD.COM', 0, NULL, N'b536237a-795a-400c-82bb-e74f6841660e', N'0239bebb-79ab-4447-bf2a-66592f1fd18c', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'90015', N'hc-ssp_sec_head', N'HC-SSP_SEC_HEAD', N'Ahmed Zaki', N'HC - Samsung SDS project  Section Head', 10, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'hc-ssp_sec_head@dpworld.com', N'HC-SSP_SEC_HEAD@DPWORLD.COM', 0, NULL, N'960f5d16-4130-4961-b4d6-041d71b3865e', N'c9831840-2567-47aa-82fa-95c5160ba10e', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Exp-16', N'em_manager', N'EM_MANAGER', N'Urs Moll', N'Head of Executive Management', 7, NULL, NULL, N'DP World', 1, 1, NULL, NULL, NULL, NULL, NULL, N'executivemanagement_manager@dpworld.com', N'EXECUTIVEMANAGEMENT_MANAGER@DPWORLD.COM', 0, NULL, N'218e66d7-278e-42b0-871a-774b58a68da1', N'd81d2d17-2897-4f1d-a693-65d4b9f7c3e7', N'01002234498', 0, 0, NULL, 0, 0)
INSERT [security].[User] ([Id], [UserName], [NormalizedUserName], [FullName], [Position], [DepartmentId], [SectionId], [ManagerId], [Company], [IsEmployee], [IsActive], [LastLogin], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'stringg', N'stringg', N'STRINGG', N'stringg', N'string', NULL, NULL, NULL, N'string', 0, 1, NULL, CAST(N'2023-09-17T15:32:00' AS SmallDateTime), NULL, NULL, NULL, N'usger@example.com', N'USGER@EXAMPLE.COM', 0, N'AQAAAAIAAYagAAAAEOpT/V3Ys0L/7tbjIJTTaCHjtDKnEaaVgyH8LXTh7qPQLU8efHqhMoJIYjkQSCZ0XQ==', N'CARHMI2SCO4TOE67DLEIVD7U4JIFLRBM', N'a318c458-cb44-4f18-982d-f396ef2ba632', N'01543889566', 0, 0, CAST(N'2023-09-24T11:12:08.9021249+00:00' AS DateTimeOffset), 1, 0)
GO
INSERT [security].[UserRoles] ([UserId], [RoleId]) VALUES (N'1396', N'04cd21f1-113b-477e-a517-7dcb1ea8a024')
INSERT [security].[UserRoles] ([UserId], [RoleId]) VALUES (N'51331', N'04cd21f1-113b-477e-a517-7dcb1ea8a024')
INSERT [security].[UserRoles] ([UserId], [RoleId]) VALUES (N'51124', N'121c1742-99e7-4b61-ab2f-f748876e2975')
INSERT [security].[UserRoles] ([UserId], [RoleId]) VALUES (N'51555', N'121c1742-99e7-4b61-ab2f-f748876e2975')
INSERT [security].[UserRoles] ([UserId], [RoleId]) VALUES (N'51585', N'121c1742-99e7-4b61-ab2f-f748876e2975')
INSERT [security].[UserRoles] ([UserId], [RoleId]) VALUES (N'50269', N'1ee5bd21-f548-47f6-918f-2b0b7625ded2')
INSERT [security].[UserRoles] ([UserId], [RoleId]) VALUES (N'55887', N'1ee5bd21-f548-47f6-918f-2b0b7625ded2')
INSERT [security].[UserRoles] ([UserId], [RoleId]) VALUES (N'51188', N'6826ac7e-b4ae-47ff-8bf6-cc904db43d84')
INSERT [security].[UserRoles] ([UserId], [RoleId]) VALUES (N'51588', N'6826ac7e-b4ae-47ff-8bf6-cc904db43d84')
INSERT [security].[UserRoles] ([UserId], [RoleId]) VALUES (N'54339', N'6826ac7e-b4ae-47ff-8bf6-cc904db43d84')
GO
/****** Object:  Index [IX_ApplicationItAdmin_ApplicationId]    Script Date: 10/1/2023 12:35:52 PM ******/
CREATE NONCLUSTERED INDEX [IX_ApplicationItAdmin_ApplicationId] ON [dbo].[ApplicationItAdmin]
(
	[ApplicationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ApplicationUserRequest_RequestId]    Script Date: 10/1/2023 12:35:52 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_ApplicationUserRequest_RequestId] ON [dbo].[ApplicationUserRequest]
(
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Attachment_RequestId]    Script Date: 10/1/2023 12:35:52 PM ******/
CREATE NONCLUSTERED INDEX [IX_Attachment_RequestId] ON [dbo].[Attachment]
(
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_DefinedApplication_ApplicationOwnerId]    Script Date: 10/1/2023 12:35:52 PM ******/
CREATE NONCLUSTERED INDEX [IX_DefinedApplication_ApplicationOwnerId] ON [dbo].[DefinedApplication]
(
	[ApplicationOwnerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DefinedApplicationRole_RequestedApplicationId]    Script Date: 10/1/2023 12:35:52 PM ******/
CREATE NONCLUSTERED INDEX [IX_DefinedApplicationRole_RequestedApplicationId] ON [dbo].[DefinedApplicationRole]
(
	[RequestedApplicationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DefinedRequest_DepartmentId]    Script Date: 10/1/2023 12:35:52 PM ******/
CREATE NONCLUSTERED INDEX [IX_DefinedRequest_DepartmentId] ON [dbo].[DefinedRequest]
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_DefinedRequestReviewer_AssignedReviewerId]    Script Date: 10/1/2023 12:35:52 PM ******/
CREATE NONCLUSTERED INDEX [IX_DefinedRequestReviewer_AssignedReviewerId] ON [dbo].[DefinedRequestReviewer]
(
	[AssignedReviewerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DefinedRequestReviewer_DefinedRequestId]    Script Date: 10/1/2023 12:35:52 PM ******/
CREATE NONCLUSTERED INDEX [IX_DefinedRequestReviewer_DefinedRequestId] ON [dbo].[DefinedRequestReviewer]
(
	[DefinedRequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DefinedRequestRole_DefinedRequestId]    Script Date: 10/1/2023 12:35:52 PM ******/
CREATE NONCLUSTERED INDEX [IX_DefinedRequestRole_DefinedRequestId] ON [dbo].[DefinedRequestRole]
(
	[DefinedRequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Department_ManagerId]    Script Date: 10/1/2023 12:35:52 PM ******/
CREATE NONCLUSTERED INDEX [IX_Department_ManagerId] ON [dbo].[Department]
(
	[ManagerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DomainAccountRequest_RequestId]    Script Date: 10/1/2023 12:35:52 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_DomainAccountRequest_RequestId] ON [dbo].[DomainAccountRequest]
(
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_PoRequest_InvoiceNumber]    Script Date: 10/1/2023 12:35:52 PM ******/
CREATE NONCLUSTERED INDEX [IX_PoRequest_InvoiceNumber] ON [dbo].[PoRequest]
(
	[InvoiceNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_PoRequest_PoNumber]    Script Date: 10/1/2023 12:35:52 PM ******/
CREATE NONCLUSTERED INDEX [IX_PoRequest_PoNumber] ON [dbo].[PoRequest]
(
	[PoNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_PoRequest_RequestId]    Script Date: 10/1/2023 12:35:52 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_PoRequest_RequestId] ON [dbo].[PoRequest]
(
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Request_CreatorId]    Script Date: 10/1/2023 12:35:52 PM ******/
CREATE NONCLUSTERED INDEX [IX_Request_CreatorId] ON [dbo].[Request]
(
	[CreatorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Request_DefinedRequestId]    Script Date: 10/1/2023 12:35:52 PM ******/
CREATE NONCLUSTERED INDEX [IX_Request_DefinedRequestId] ON [dbo].[Request]
(
	[DefinedRequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_RequestApplicationRole_ApplicationId]    Script Date: 10/1/2023 12:35:52 PM ******/
CREATE NONCLUSTERED INDEX [IX_RequestApplicationRole_ApplicationId] ON [dbo].[RequestApplicationRole]
(
	[ApplicationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_RequestApplicationRole_RoleId]    Script Date: 10/1/2023 12:35:52 PM ******/
CREATE NONCLUSTERED INDEX [IX_RequestApplicationRole_RoleId] ON [dbo].[RequestApplicationRole]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_RequestReviewer_AssignedReviewerId]    Script Date: 10/1/2023 12:35:52 PM ******/
CREATE NONCLUSTERED INDEX [IX_RequestReviewer_AssignedReviewerId] ON [dbo].[RequestReviewer]
(
	[AssignedReviewerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Section_DepartmentId]    Script Date: 10/1/2023 12:35:52 PM ******/
CREATE NONCLUSTERED INDEX [IX_Section_DepartmentId] ON [dbo].[Section]
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Section_HeadId]    Script Date: 10/1/2023 12:35:52 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Section_HeadId] ON [dbo].[Section]
(
	[HeadId] ASC
)
WHERE ([HeadId] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_TravelDeskRequest_RequestId]    Script Date: 10/1/2023 12:35:52 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_TravelDeskRequest_RequestId] ON [dbo].[TravelDeskRequest]
(
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_VehicleRequest_RequestId]    Script Date: 10/1/2023 12:35:52 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_VehicleRequest_RequestId] ON [dbo].[VehicleRequest]
(
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_VoucherRequest_RequestId]    Script Date: 10/1/2023 12:35:52 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_VoucherRequest_RequestId] ON [dbo].[VoucherRequest]
(
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 10/1/2023 12:35:52 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [security].[Role]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_RoleClaims_RoleId]    Script Date: 10/1/2023 12:35:52 PM ******/
CREATE NONCLUSTERED INDEX [IX_RoleClaims_RoleId] ON [security].[RoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 10/1/2023 12:35:52 PM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [security].[User]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_User_DepartmentId]    Script Date: 10/1/2023 12:35:52 PM ******/
CREATE NONCLUSTERED INDEX [IX_User_DepartmentId] ON [security].[User]
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_User_ManagerId]    Script Date: 10/1/2023 12:35:52 PM ******/
CREATE NONCLUSTERED INDEX [IX_User_ManagerId] ON [security].[User]
(
	[ManagerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_User_SectionId]    Script Date: 10/1/2023 12:35:52 PM ******/
CREATE NONCLUSTERED INDEX [IX_User_SectionId] ON [security].[User]
(
	[SectionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 10/1/2023 12:35:52 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [security].[User]
(
	[NormalizedUserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserClaims_UserId]    Script Date: 10/1/2023 12:35:52 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserClaims_UserId] ON [security].[UserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserLogin_UserId]    Script Date: 10/1/2023 12:35:52 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserLogin_UserId] ON [security].[UserLogin]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserRoles_RoleId]    Script Date: 10/1/2023 12:35:52 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserRoles_RoleId] ON [security].[UserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[PoRequest] ADD  DEFAULT ((0)) FOR [VendorNumber]
GO
ALTER TABLE [dbo].[PoRequest] ADD  DEFAULT (N'') FOR [RequestNumber]
GO
ALTER TABLE [dbo].[Request] ADD  DEFAULT ((1)) FOR [CurrentStage]
GO
ALTER TABLE [dbo].[Request] ADD  DEFAULT (N'Pending') FOR [Status]
GO
ALTER TABLE [dbo].[RequestReviewer] ADD  DEFAULT (N'Pending') FOR [Status]
GO
ALTER TABLE [dbo].[VehicleRequest] ADD  DEFAULT (N'') FOR [RequestNumber]
GO
ALTER TABLE [security].[Role] ADD  DEFAULT (N'') FOR [CreatedBy]
GO
ALTER TABLE [security].[Role] ADD  DEFAULT (N'') FOR [ModifiedBy]
GO
ALTER TABLE [security].[User] ADD  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [security].[User] ADD  DEFAULT (CONVERT([bit],(0))) FOR [EmailConfirmed]
GO
ALTER TABLE [security].[User] ADD  DEFAULT (CONVERT([bit],(0))) FOR [PhoneNumberConfirmed]
GO
ALTER TABLE [security].[User] ADD  DEFAULT (CONVERT([bit],(0))) FOR [TwoFactorEnabled]
GO
ALTER TABLE [security].[User] ADD  DEFAULT (CONVERT([bit],(0))) FOR [LockoutEnabled]
GO
ALTER TABLE [security].[User] ADD  DEFAULT ((0)) FOR [AccessFailedCount]
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
ALTER TABLE [dbo].[VehicleRequest]  WITH CHECK ADD  CONSTRAINT [FK_VehicleRequest_Request] FOREIGN KEY([RequestId])
REFERENCES [dbo].[Request] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[VehicleRequest] CHECK CONSTRAINT [FK_VehicleRequest_Request]
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
