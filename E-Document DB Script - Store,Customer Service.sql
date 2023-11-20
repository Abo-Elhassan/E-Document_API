USE [E-Document]
GO
/****** Object:  Table [audit].[AuditFuelOilInvoiceRequest]    Script Date: 11/18/2023 10:36:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [audit].[AuditFuelOilInvoiceRequest](
	[AuditId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[ProductType] [nvarchar](max) NULL,
	[InvoiceNumber] [nvarchar](max) NULL,
	[ReceiptNumber] [int] NOT NULL,
	[RequestedDate] [datetime2](7) NOT NULL,
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
	[BeneficiaryCompany] [nvarchar](max) NULL,
	[BeneficiaryExtention] [int] NULL,
	[RequestId] [bigint] NOT NULL,
	[SwiftNumber] [int] NULL,
 CONSTRAINT [PK_AuditFuelOilInvoiceRequest] PRIMARY KEY CLUSTERED 
(
	[AuditId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [audit].[AuditManliftReservationRequest]    Script Date: 11/18/2023 10:36:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [audit].[AuditManliftReservationRequest](
	[AuditId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[ManliftNumber] [nvarchar](max) NULL,
	[RequestedFrom] [datetime2](7) NOT NULL,
	[RequestedTo] [datetime2](7) NOT NULL,
	[SupervisorId] [nvarchar](max) NULL,
	[SupervisorName] [nvarchar](max) NULL,
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
	[BeneficiaryCompany] [nvarchar](max) NULL,
	[BeneficiaryExtention] [int] NULL,
	[RequestId] [bigint] NOT NULL,
 CONSTRAINT [PK_AuditManliftReservationRequest] PRIMARY KEY CLUSTERED 
(
	[AuditId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [audit].[AuditNewItemRequest]    Script Date: 11/18/2023 10:36:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [audit].[AuditNewItemRequest](
	[AuditId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[ItemDescription] [nvarchar](max) NULL,
	[EquipmentType] [nvarchar](max) NULL,
	[PartNumber] [nvarchar](max) NULL,
	[Manufacturing] [nvarchar](max) NULL,
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
	[BeneficiaryCompany] [nvarchar](max) NULL,
	[BeneficiaryExtention] [int] NULL,
	[RequestId] [bigint] NOT NULL,
 CONSTRAINT [PK_AuditNewItemRequest] PRIMARY KEY CLUSTERED 
(
	[AuditId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [audit].[AuditPrRequest]    Script Date: 11/18/2023 10:36:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [audit].[AuditPrRequest](
	[AuditId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[PrSubject] [nvarchar](max) NULL,
	[AfeNumber] [nvarchar](max) NULL,
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
	[BeneficiaryCompany] [nvarchar](max) NULL,
	[BeneficiaryExtention] [int] NULL,
	[RequestId] [bigint] NOT NULL,
 CONSTRAINT [PK_AuditPrRequest] PRIMARY KEY CLUSTERED 
(
	[AuditId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [audit].[AuditRefundRequest]    Script Date: 11/18/2023 10:36:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [audit].[AuditRefundRequest](
	[AuditId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[RequestNumber] [nvarchar](max) NULL,
	[RequestId] [bigint] NOT NULL,
	[CustomerName] [nvarchar](max) NULL,
	[CustomerMobileNumber] [nvarchar](max) NULL,
	[RefundSubject] [nvarchar](max) NULL,
	[RefundDescription] [nvarchar](max) NULL,
	[RefundType] [nvarchar](max) NULL,
	[ShipmentType] [nvarchar](max) NULL,
	[DocumentNumber] [nvarchar](max) NULL,
	[RelatedContainers] [nvarchar](max) NULL,
	[ConcernedEmployeeId] [nvarchar](max) NULL,
	[ConcernedEmployeeName] [nvarchar](max) NULL,
	[CreditNote] [nvarchar](max) NULL,
	[Amount] [nvarchar](max) NULL,
	[CreatedAt] [datetime2](7) NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[ModifiedBy] [nvarchar](max) NULL,
	[TransactionType] [nvarchar](max) NOT NULL,
	[DataStatus] [nvarchar](max) NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_AuditRefundRequest] PRIMARY KEY CLUSTERED 
(
	[AuditId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [audit].[AuditRequestedItem]    Script Date: 11/18/2023 10:36:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [audit].[AuditRequestedItem](
	[AuditId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[BudgetType] [nvarchar](max) NULL,
	[CommodityCode] [nvarchar](max) NULL,
	[StoreRoom] [nvarchar](max) NULL,
	[Unit] [nvarchar](max) NULL,
	[CreatedAt] [datetime2](7) NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[ModifiedBy] [nvarchar](max) NULL,
	[TransactionType] [nvarchar](max) NOT NULL,
	[DataStatus] [nvarchar](max) NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
	[ItemNumber] [nvarchar](max) NULL,
	[RequestedItemId] [bigint] NOT NULL,
	[RequestId] [bigint] NOT NULL,
 CONSTRAINT [PK_AuditRequestedItem] PRIMARY KEY CLUSTERED 
(
	[AuditId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [audit].[AuditRequestedPr]    Script Date: 11/18/2023 10:36:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [audit].[AuditRequestedPr](
	[AuditId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[RequestedPrId] [bigint] NOT NULL,
	[PrNumber] [nvarchar](max) NULL,
	[RequestType] [nvarchar](max) NULL,
	[PrDescription] [nvarchar](max) NULL,
	[BudgetType] [nvarchar](max) NULL,
	[Quantity] [int] NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[ModifiedBy] [nvarchar](max) NULL,
	[TransactionType] [nvarchar](max) NOT NULL,
	[DataStatus] [nvarchar](max) NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
	[RequestId] [bigint] NOT NULL,
	[ItemNumber] [nvarchar](max) NULL,
 CONSTRAINT [PK_AuditRequestedPr] PRIMARY KEY CLUSTERED 
(
	[AuditId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FuelOilInvoiceRequest]    Script Date: 11/18/2023 10:36:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FuelOilInvoiceRequest](
	[RequestNumber] [nvarchar](50) NOT NULL,
	[ProductType] [nvarchar](50) NOT NULL,
	[InvoiceNumber] [nvarchar](200) NOT NULL,
	[ReceiptNumber] [int] NOT NULL,
	[RequestedDate] [smalldatetime] NOT NULL,
	[CreatedAt] [smalldatetime] NULL,
	[ModifiedAt] [smalldatetime] NULL,
	[CreatedBy] [varchar](200) NULL,
	[ModifiedBy] [varchar](200) NULL,
	[BeneficiaryId] [nvarchar](50) NOT NULL,
	[BeneficiaryName] [nvarchar](200) NOT NULL,
	[BeneficiaryEmail] [nvarchar](50) NULL,
	[BeneficiaryPosition] [nvarchar](200) NULL,
	[BeneficiaryDepartment] [nvarchar](200) NULL,
	[BeneficiaryCompany] [nvarchar](200) NULL,
	[BeneficiaryPhoneNumber] [nvarchar](50) NULL,
	[BeneficiaryExtention] [int] NULL,
	[RequestId] [bigint] NOT NULL,
	[SwiftNumber] [int] NULL,
 CONSTRAINT [PK_FuelOilInvoiceRequest] PRIMARY KEY CLUSTERED 
(
	[RequestNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ManliftReservationRequest]    Script Date: 11/18/2023 10:36:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ManliftReservationRequest](
	[RequestNumber] [nvarchar](50) NOT NULL,
	[ManliftNumber] [nvarchar](50) NOT NULL,
	[RequestedFrom] [smalldatetime] NOT NULL,
	[RequestedTo] [smalldatetime] NOT NULL,
	[SupervisorId] [nvarchar](50) NOT NULL,
	[SupervisorName] [nvarchar](200) NOT NULL,
	[CreatedAt] [smalldatetime] NULL,
	[ModifiedAt] [smalldatetime] NULL,
	[CreatedBy] [nvarchar](200) NULL,
	[ModifiedBy] [nvarchar](200) NULL,
	[BeneficiaryId] [nvarchar](max) NULL,
	[BeneficiaryName] [nvarchar](max) NULL,
	[BeneficiaryEmail] [nvarchar](max) NULL,
	[BeneficiaryPosition] [nvarchar](max) NULL,
	[BeneficiaryDepartment] [nvarchar](max) NULL,
	[BeneficiaryCompany] [nvarchar](max) NULL,
	[BeneficiaryPhoneNumber] [nvarchar](max) NULL,
	[BeneficiaryExtention] [int] NULL,
	[RequestId] [bigint] NOT NULL,
 CONSTRAINT [PK_ManliftReservationRequest] PRIMARY KEY CLUSTERED 
(
	[RequestNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NewItemRequest]    Script Date: 11/18/2023 10:36:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NewItemRequest](
	[RequestNumber] [nvarchar](50) NOT NULL,
	[ItemDescription] [nvarchar](max) NOT NULL,
	[EquipmentType] [nvarchar](50) NOT NULL,
	[PartNumber] [nvarchar](50) NULL,
	[Manufacturing] [nvarchar](50) NULL,
	[CreatedAt] [smalldatetime] NULL,
	[ModifiedAt] [smalldatetime] NULL,
	[CreatedBy] [varchar](200) NULL,
	[ModifiedBy] [varchar](200) NULL,
	[BeneficiaryId] [nvarchar](50) NOT NULL,
	[BeneficiaryName] [nvarchar](200) NOT NULL,
	[BeneficiaryEmail] [nvarchar](50) NULL,
	[BeneficiaryPosition] [nvarchar](200) NULL,
	[BeneficiaryDepartment] [nvarchar](200) NULL,
	[BeneficiaryCompany] [nvarchar](200) NULL,
	[BeneficiaryPhoneNumber] [nvarchar](50) NULL,
	[BeneficiaryExtention] [int] NULL,
	[RequestId] [bigint] NOT NULL,
 CONSTRAINT [PK_NewItemRequest] PRIMARY KEY CLUSTERED 
(
	[RequestNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PrRequest]    Script Date: 11/18/2023 10:36:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PrRequest](
	[RequestNumber] [nvarchar](50) NOT NULL,
	[PrSubject] [nvarchar](200) NOT NULL,
	[AfeNumber] [nvarchar](50) NULL,
	[CreatedAt] [smalldatetime] NULL,
	[ModifiedAt] [smalldatetime] NULL,
	[CreatedBy] [varchar](200) NULL,
	[ModifiedBy] [varchar](200) NULL,
	[BeneficiaryId] [nvarchar](50) NOT NULL,
	[BeneficiaryName] [nvarchar](200) NOT NULL,
	[BeneficiaryEmail] [nvarchar](50) NULL,
	[BeneficiaryPosition] [nvarchar](200) NULL,
	[BeneficiaryDepartment] [nvarchar](200) NULL,
	[BeneficiaryCompany] [nvarchar](200) NULL,
	[BeneficiaryPhoneNumber] [nvarchar](50) NULL,
	[BeneficiaryExtention] [int] NULL,
	[RequestId] [bigint] NOT NULL,
 CONSTRAINT [PK_PrRequest] PRIMARY KEY CLUSTERED 
(
	[RequestNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RefundRequest]    Script Date: 11/18/2023 10:36:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RefundRequest](
	[RequestNumber] [nvarchar](50) NOT NULL,
	[RequestId] [bigint] NOT NULL,
	[CustomerName] [nvarchar](200) NOT NULL,
	[CustomerMobileNumber] [nvarchar](50) NOT NULL,
	[RefundSubject] [nvarchar](200) NOT NULL,
	[RefundDescription] [nvarchar](max) NULL,
	[RefundType] [nvarchar](50) NOT NULL,
	[ShipmentType] [nvarchar](50) NULL,
	[DocumentNumber] [nvarchar](50) NOT NULL,
	[RelatedContainers] [nvarchar](max) NULL,
	[ConcernedEmployeeId] [nvarchar](50) NOT NULL,
	[ConcernedEmployeeName] [nvarchar](200) NOT NULL,
	[CreditNote] [bigint] NULL,
	[Amount] [nvarchar](50) NULL,
	[CreatedAt] [smalldatetime] NULL,
	[ModifiedAt] [smalldatetime] NULL,
	[CreatedBy] [nvarchar](200) NULL,
	[ModifiedBy] [nvarchar](200) NULL,
 CONSTRAINT [PK_RefundRequest] PRIMARY KEY CLUSTERED 
(
	[RequestNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RequestedItem]    Script Date: 11/18/2023 10:36:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RequestedItem](
	[RequestedItemId] [bigint] IDENTITY(1,1) NOT NULL,
	[BudgetType] [nvarchar](50) NOT NULL,
	[CommodityCode] [nvarchar](50) NOT NULL,
	[StoreRoom] [nvarchar](50) NOT NULL,
	[Unit] [nvarchar](50) NOT NULL,
	[CreatedAt] [smalldatetime] NULL,
	[ModifiedAt] [smalldatetime] NULL,
	[CreatedBy] [varchar](200) NULL,
	[ModifiedBy] [varchar](200) NULL,
	[ItemNumber] [nvarchar](50) NULL,
	[RequestId] [bigint] NOT NULL,
 CONSTRAINT [PK_RequestedItem] PRIMARY KEY CLUSTERED 
(
	[RequestedItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RequestedPr]    Script Date: 11/18/2023 10:36:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RequestedPr](
	[RequestedPrId] [bigint] IDENTITY(1,1) NOT NULL,
	[PrNumber] [nvarchar](50) NULL,
	[RequestType] [nvarchar](50) NOT NULL,
	[PrDescription] [nvarchar](max) NOT NULL,
	[BudgetType] [nvarchar](50) NOT NULL,
	[Quantity] [int] NOT NULL,
	[CreatedAt] [smalldatetime] NULL,
	[ModifiedAt] [smalldatetime] NULL,
	[CreatedBy] [varchar](200) NULL,
	[ModifiedBy] [varchar](200) NULL,
	[RequestId] [bigint] NOT NULL,
	[ItemNumber] [nvarchar](50) NULL,
 CONSTRAINT [PK_RequestedPr] PRIMARY KEY CLUSTERED 
(
	[RequestedPrId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231109132917_addFuelOilInvoiceRequest', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231110114347_OperationsRequest', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231110115958_AuditTableOperationsRequest', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231110121134_SchemaAuditTableOperationsRequest', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231110125756_EditAuditTableOperationsRequest', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231110131738_EditDateOperationsRequest', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231110142811_AddAdditionalToolOperationsRequest', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231111092926_migrateDelegationFromRequestReviewerToUser', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231111151335_addNewItemRequest', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231111154908_addMissingFieldsInNewItemRequest', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231111155223_makeCommodityCodeString', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231112102852_AddPRRequestAndRequestedPR', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231112124109_AdditionaltoolsInAuditOperation', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231113141751_FixfilterBugInPRRequest', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231113154113_AddMaliftRequest', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231115070532_LinkRequestedPR_RequestedItem_With_RequestId_Instead_Of_RequestNumber', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231116075927_makeCreditNoteNullable', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231116140010_FixInternalTestingCommentsForStoreAndCS', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231118061728_makeInvoiceNumberUniqueForFuelOilReq', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231118065720_Rename_PR_Pr', N'7.0.10')
GO
INSERT [security].[Role] ([Id], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'2c5b54b5-9fc3-4025-8324-bb4fa3582f49', CAST(N'2023-11-18T11:04:13.6367669' AS DateTime2), NULL, N'E-Document', NULL, N'Finance_FuelOil', N'FINANCE_FUELOIL', N'276a2a38-0589-4ac0-bdfd-ae4d4f5c8f9c')
INSERT [security].[UserRoles] (RoleId,UserId) VALUES ('2c5b54b5-9fc3-4025-8324-bb4fa3582f49','51510');
INSERT [security].[UserRoles] (RoleId,UserId) VALUES ('2c5b54b5-9fc3-4025-8324-bb4fa3582f49','51605');
GO
INSERT [dbo].[DefinedRequest] ([Id], [RequestName], [RouteName], [ReviewersNumber], [DepartmentId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023101010522512, N'Refund', N'/CustomerService/Refund/', 4, 7, CAST(N'2023-10-09T09:20:00' AS SmallDateTime), NULL, N'E-Documnet', NULL)
INSERT [dbo].[DefinedRequest] ([Id], [RequestName], [RouteName], [ReviewersNumber], [DepartmentId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023110902494107, N'Fuel Oil Invoice', N'/Store/FuelOilInvoice/', 1, 20, CAST(N'2023-11-09T14:50:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequest] ([Id], [RequestName], [RouteName], [ReviewersNumber], [DepartmentId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023110902543453, N'New Item', N'/Store/NewItem/', 1, 20, CAST(N'2023-11-09T14:55:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequest] ([Id], [RequestName], [RouteName], [ReviewersNumber], [DepartmentId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023110902550379, N'PR', N'/Store/PR/', 1, 20, CAST(N'2023-11-09T14:55:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequest] ([Id], [RequestName], [RouteName], [ReviewersNumber], [DepartmentId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023110902555103, N'Manlift Reservation', N'/Store/ManliftReservation/', 1, 20, CAST(N'2023-11-09T14:56:00' AS SmallDateTime), NULL, N'E-Document', NULL)
GO
SET IDENTITY_INSERT [dbo].[DefinedRequestReviewer] ON 
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (24, 2023101010522512, N'51229', N'Customer Service Head', 1, N'DepartmentManager', CAST(N'2023-10-09T11:39:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (14, 2023101010522512, NULL, N'Concerned Employee', 2, N'NominatedReviewer', CAST(N'2023-10-09T11:39:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (15, 2023101010522512, N'50150', N'Finance Front Office Team', 3, N'Basic', CAST(N'2023-10-09T11:39:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (17, 2023101010522512, N'50628', N'Finance Front Office Team', 3, N'Basic', CAST(N'2023-10-09T11:39:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (18, 2023101010522512, N'50730', N'Finance Front Office Team', 3, N'Basic', CAST(N'2023-10-09T11:39:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (19, 2023101010522512, N'51056', N'Finance Front Office Team', 3, N'Basic', CAST(N'2023-10-09T11:39:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (20, 2023101010522512, N'51089', N'Finance Front Office Team', 3, N'Basic', CAST(N'2023-10-09T11:39:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (21, 2023101010522512, N'51182', N'Finance Front Office Team', 3, N'Basic', CAST(N'2023-10-09T11:39:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (22, 2023101010522512, N'51216', N'Finance Front Office Team', 3, N'Basic', CAST(N'2023-10-09T11:39:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (23, 2023101010522512, N'51124', N'Finance Head', 4, N'DepartmentManager', CAST(N'2023-10-09T11:39:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10054, 2023110902543453, N'50433', N'Store Team', 1, N'Basic', CAST(N'2023-11-09T14:55:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10055, 2023110902543453, N'50439', N'Store Team', 1, N'Basic', CAST(N'2023-11-09T14:55:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10056, 2023110902543453, N'50443', N'Store Team', 1, N'Basic', CAST(N'2023-11-09T14:55:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10057, 2023110902543453, N'50457', N'Store Team', 1, N'Basic', CAST(N'2023-11-09T14:55:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10058, 2023110902543453, N'50646', N'Store Team', 1, N'Basic', CAST(N'2023-11-09T14:55:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10059, 2023110902543453, N'50937', N'Store Team', 1, N'Basic', CAST(N'2023-11-09T14:55:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10060, 2023110902543453, N'51093', N'Store Team', 1, N'Basic', CAST(N'2023-11-09T14:55:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10061, 2023110902543453, N'51163', N'Store Team', 1, N'Basic', CAST(N'2023-11-09T14:55:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10062, 2023110902543453, N'51251', N'Store Team', 1, N'Basic', CAST(N'2023-11-09T14:55:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10063, 2023110902543453, N'51255', N'Store Team', 1, N'Basic', CAST(N'2023-11-09T14:55:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10064, 2023110902543453, N'51256', N'Store Team', 1, N'Basic', CAST(N'2023-11-09T14:55:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10065, 2023110902543453, N'51259', N'Store Team', 1, N'Basic', CAST(N'2023-11-09T14:55:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10066, 2023110902550379, N'50433', N'Store Team', 1, N'Basic', CAST(N'2023-11-09T14:55:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10067, 2023110902550379, N'50439', N'Store Team', 1, N'Basic', CAST(N'2023-11-09T14:55:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10068, 2023110902550379, N'50443', N'Store Team', 1, N'Basic', CAST(N'2023-11-09T14:55:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10069, 2023110902550379, N'50457', N'Store Team', 1, N'Basic', CAST(N'2023-11-09T14:55:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10070, 2023110902550379, N'50646', N'Store Team', 1, N'Basic', CAST(N'2023-11-09T14:55:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10071, 2023110902550379, N'50937', N'Store Team', 1, N'Basic', CAST(N'2023-11-09T14:55:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10072, 2023110902550379, N'51093', N'Store Team', 1, N'Basic', CAST(N'2023-11-09T14:55:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10073, 2023110902550379, N'51163', N'Store Team', 1, N'Basic', CAST(N'2023-11-09T14:55:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10074, 2023110902550379, N'51251', N'Store Team', 1, N'Basic', CAST(N'2023-11-09T14:55:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10075, 2023110902550379, N'51255', N'Store Team', 1, N'Basic', CAST(N'2023-11-09T14:55:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10076, 2023110902550379, N'51256', N'Store Team', 1, N'Basic', CAST(N'2023-11-09T14:55:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10077, 2023110902550379, N'51259', N'Store Team', 1, N'Basic', CAST(N'2023-11-09T14:55:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10078, 2023110902555103, N'50433', N'Store Team', 1, N'Basic', CAST(N'2023-11-09T14:56:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10079, 2023110902555103, N'50439', N'Store Team', 1, N'Basic', CAST(N'2023-11-09T14:56:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10080, 2023110902555103, N'50443', N'Store Team', 1, N'Basic', CAST(N'2023-11-09T14:56:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10081, 2023110902555103, N'50457', N'Store Team', 1, N'Basic', CAST(N'2023-11-09T14:56:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10082, 2023110902555103, N'50646', N'Store Team', 1, N'Basic', CAST(N'2023-11-09T14:56:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10083, 2023110902555103, N'50937', N'Store Team', 1, N'Basic', CAST(N'2023-11-09T14:56:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10084, 2023110902555103, N'51093', N'Store Team', 1, N'Basic', CAST(N'2023-11-09T14:56:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10085, 2023110902555103, N'51163', N'Store Team', 1, N'Basic', CAST(N'2023-11-09T14:56:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10086, 2023110902555103, N'51251', N'Store Team', 1, N'Basic', CAST(N'2023-11-09T14:56:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10087, 2023110902555103, N'51255', N'Store Team', 1, N'Basic', CAST(N'2023-11-09T14:56:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10088, 2023110902555103, N'51256', N'Store Team', 1, N'Basic', CAST(N'2023-11-09T14:56:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10089, 2023110902555103, N'51259', N'Store Team', 1, N'Basic', CAST(N'2023-11-09T14:56:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (30157, 2023110902494107, N'51510', N'Finance Team', 1, N'Basic', CAST(N'2023-11-11T10:31:00' AS SmallDateTime), NULL, N'E-Document', NULL)
SET IDENTITY_INSERT [dbo].[DefinedRequestReviewer] OFF
GO
INSERT [dbo].[DefinedRequestRole] ([RoleId], [DefinedRequestId], [Permission], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'7ef3ba68-78e3-457a-9419-aed440b0253b', 2023101010522512, N'Review', CAST(N'2023-10-09T10:30:00' AS SmallDateTime), NULL, N'E-Documnet', NULL)
INSERT [dbo].[DefinedRequestRole] ([RoleId], [DefinedRequestId], [Permission], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'810c84df-19ab-4d1f-be83-c40261fd9368', 2023110902494107, N'Request', CAST(N'2023-11-11T10:31:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestRole] ([RoleId], [DefinedRequestId], [Permission], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'7ef3ba68-78e3-457a-9419-aed440b0253b', 2023110902543453, N'Request', CAST(N'2023-11-09T14:55:00' AS SmallDateTime), NULL, N'E-Documnet', NULL)
INSERT [dbo].[DefinedRequestRole] ([RoleId], [DefinedRequestId], [Permission], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'7ef3ba68-78e3-457a-9419-aed440b0253b', 2023110902550379, N'Request', CAST(N'2023-11-09T14:55:00' AS SmallDateTime), NULL, N'E-Documnet', NULL)
INSERT [dbo].[DefinedRequestRole] ([RoleId], [DefinedRequestId], [Permission], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'7ef3ba68-78e3-457a-9419-aed440b0253b', 2023110902555103, N'Request', CAST(N'2023-11-09T14:56:00' AS SmallDateTime), NULL, N'E-Documnet', NULL)
INSERT [dbo].[DefinedRequestRole] ([RoleId], [DefinedRequestId], [Permission], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'810c84df-19ab-4d1f-be83-c40261fd9368', 2023110902543453, N'Review', CAST(N'2023-11-09T14:55:00' AS SmallDateTime), NULL, N'E-Documnet', NULL)
INSERT [dbo].[DefinedRequestRole] ([RoleId], [DefinedRequestId], [Permission], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'810c84df-19ab-4d1f-be83-c40261fd9368', 2023110902550379, N'Review', CAST(N'2023-11-09T14:55:00' AS SmallDateTime), NULL, N'E-Documnet', NULL)
INSERT [dbo].[DefinedRequestRole] ([RoleId], [DefinedRequestId], [Permission], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'810c84df-19ab-4d1f-be83-c40261fd9368', 2023110902555103, N'Review', CAST(N'2023-11-09T14:56:00' AS SmallDateTime), NULL, N'E-Documnet', NULL)
INSERT [dbo].[DefinedRequestRole] ([RoleId], [DefinedRequestId], [Permission], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'c1566c45-954c-42b1-962c-d73fe026c7e2', 2023101010522512, N'Request', CAST(N'2023-10-09T10:30:00' AS SmallDateTime), NULL, N'E-Documnet', NULL)
INSERT [dbo].[DefinedRequestRole] ([RoleId], [DefinedRequestId], [Permission], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'2c5b54b5-9fc3-4025-8324-bb4fa3582f49', 2023110902494107, N'Review', CAST(N'2023-11-11T10:31:00' AS SmallDateTime), NULL, N'E-Document', NULL)

GO
ALTER TABLE [audit].[AuditRequestedItem] ADD  DEFAULT (CONVERT([bigint],(0))) FOR [RequestedItemId]
GO
ALTER TABLE [audit].[AuditRequestedItem] ADD  DEFAULT (CONVERT([bigint],(0))) FOR [RequestId]
GO
ALTER TABLE [audit].[AuditRequestedPr] ADD  DEFAULT (CONVERT([bigint],(0))) FOR [RequestId]
GO
ALTER TABLE [dbo].[RequestedItem] ADD  DEFAULT (CONVERT([bigint],(0))) FOR [RequestId]
GO
ALTER TABLE [dbo].[RequestedPr] ADD  DEFAULT (CONVERT([bigint],(0))) FOR [RequestId]
GO
ALTER TABLE [dbo].[FuelOilInvoiceRequest]  WITH CHECK ADD  CONSTRAINT [FK_FuelOilInvoiceRequest_Request] FOREIGN KEY([RequestId])
REFERENCES [dbo].[Request] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[FuelOilInvoiceRequest] CHECK CONSTRAINT [FK_FuelOilInvoiceRequest_Request]
GO
ALTER TABLE [dbo].[ManliftReservationRequest]  WITH CHECK ADD  CONSTRAINT [FK_ManliftReservationRequest_Request] FOREIGN KEY([RequestId])
REFERENCES [dbo].[Request] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ManliftReservationRequest] CHECK CONSTRAINT [FK_ManliftReservationRequest_Request]
GO
ALTER TABLE [dbo].[NewItemRequest]  WITH CHECK ADD  CONSTRAINT [FK_NewItemRequest_Request] FOREIGN KEY([RequestId])
REFERENCES [dbo].[Request] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NewItemRequest] CHECK CONSTRAINT [FK_NewItemRequest_Request]
GO
ALTER TABLE [dbo].[PrRequest]  WITH CHECK ADD  CONSTRAINT [FK_PrRequest_Request] FOREIGN KEY([RequestId])
REFERENCES [dbo].[Request] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PrRequest] CHECK CONSTRAINT [FK_PrRequest_Request]
GO
ALTER TABLE [dbo].[RefundRequest]  WITH CHECK ADD  CONSTRAINT [FK_RefundRequest_Request] FOREIGN KEY([RequestId])
REFERENCES [dbo].[Request] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RefundRequest] CHECK CONSTRAINT [FK_RefundRequest_Request]
GO
ALTER TABLE [dbo].[RequestedItem]  WITH CHECK ADD  CONSTRAINT [FK_RequestedItem_Request] FOREIGN KEY([RequestId])
REFERENCES [dbo].[Request] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RequestedItem] CHECK CONSTRAINT [FK_RequestedItem_Request]
GO
ALTER TABLE [dbo].[RequestedPr]  WITH CHECK ADD  CONSTRAINT [FK_RequestedPr_Request] FOREIGN KEY([RequestId])
REFERENCES [dbo].[Request] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RequestedPr] CHECK CONSTRAINT [FK_RequestedPr_Request]
GO
/****** Object:  Trigger [dbo].[TR_AuditFuelOilInvoiceRequest]    Script Date: 11/18/2023 10:36:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TR_AuditFuelOilInvoiceRequest]
ON [dbo].[FuelOilInvoiceRequest]
AFTER UPDATE, DELETE
AS
BEGIN
    DECLARE @TransactionType NVARCHAR(max);

    -- Get the operation type
    IF EXISTS (SELECT * FROM INSERTED)
    BEGIN
        -- This is an UPDATE operation
        SET @TransactionType = 'UPDATE';

        -- Insert the old record with status 'Old'
        INSERT INTO audit.AuditFuelOilInvoiceRequest (ProductType, InvoiceNumber, ReceiptNumber, RequestedDate, SwiftNumber, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryPhoneNumber, BeneficiaryCompany, BeneficiaryExtention, RequestId)
        SELECT
            ProductType,
            InvoiceNumber,
            ReceiptNumber,
            RequestedDate,
			SwiftNumber,
            CreatedAt,
            ModifiedAt,
            CreatedBy,
            ModifiedBy,
            @TransactionType,
            'Old' AS DataStatus,
            GETDATE() AS TimeStamp,
            RequestNumber,
            BeneficiaryId,
            BeneficiaryName,
            BeneficiaryEmail,
            BeneficiaryPosition,
            BeneficiaryDepartment,
            BeneficiaryPhoneNumber,
            BeneficiaryCompany,
            BeneficiaryExtention,
            RequestId
        FROM DELETED;

        -- Insert the new record with status 'New'
        INSERT INTO audit.AuditFuelOilInvoiceRequest (ProductType, InvoiceNumber, ReceiptNumber, RequestedDate, SwiftNumber, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryPhoneNumber, BeneficiaryCompany, BeneficiaryExtention, RequestId)
        SELECT
            ProductType,
            InvoiceNumber,
            ReceiptNumber,
            RequestedDate,
			SwiftNumber,
            CreatedAt,
            ModifiedAt,
            CreatedBy,
            ModifiedBy,
            @TransactionType,
            'New' AS DataStatus,
            GETDATE() AS TimeStamp,
            RequestNumber,
            BeneficiaryId,
            BeneficiaryName,
            BeneficiaryEmail,
            BeneficiaryPosition,
            BeneficiaryDepartment,
            BeneficiaryPhoneNumber,
            BeneficiaryCompany,
            BeneficiaryExtention,
            RequestId
        FROM INSERTED;
    END
    ELSE 
    BEGIN
        -- This is a DELETE operation
        SET @TransactionType = 'DELETE';

        -- Insert the old record with status 'Old'
        INSERT INTO audit.AuditFuelOilInvoiceRequest (ProductType, InvoiceNumber, ReceiptNumber, RequestedDate, SwiftNumber, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryPhoneNumber, BeneficiaryCompany, BeneficiaryExtention, RequestId)
        SELECT
            ProductType,
            InvoiceNumber,
            ReceiptNumber,
            RequestedDate,
			SwiftNumber,
            CreatedAt,
            ModifiedAt,
            CreatedBy,
            ModifiedBy,
            @TransactionType,
            'Old' AS DataStatus,
            GETDATE() AS TimeStamp,
            RequestNumber,
            BeneficiaryId,
            BeneficiaryName,
            BeneficiaryEmail,
            BeneficiaryPosition,
            BeneficiaryDepartment,
            BeneficiaryPhoneNumber,
            BeneficiaryCompany,
            BeneficiaryExtention,
            RequestId
        FROM DELETED;
    END
END;
GO
ALTER TABLE [dbo].[FuelOilInvoiceRequest] ENABLE TRIGGER [TR_AuditFuelOilInvoiceRequest]
GO
/****** Object:  Trigger [dbo].[TR_AuditManliftReservationRequest]    Script Date: 11/18/2023 10:36:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TR_AuditManliftReservationRequest]
ON [dbo].[ManliftReservationRequest]
AFTER UPDATE, DELETE
AS
BEGIN
    DECLARE @TransactionType NVARCHAR(max);

    -- Get the operation type
    IF EXISTS (SELECT * FROM INSERTED)
    BEGIN
        -- This is an UPDATE operation
        SET @TransactionType = 'UPDATE';

        -- Insert the old record with status 'Old'
        INSERT INTO audit.AuditManliftReservationRequest (ManliftNumber, RequestedFrom, RequestedTo, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryPhoneNumber, BeneficiaryCompany, BeneficiaryExtention, RequestId)
        SELECT
            ManliftNumber,
            RequestedFrom,
            RequestedTo,
            CreatedAt,
            ModifiedAt,
            CreatedBy,
            ModifiedBy,
            @TransactionType,
            'Old' AS DataStatus,
            GETDATE() AS TimeStamp,
            RequestNumber,
            BeneficiaryId,
            BeneficiaryName,
            BeneficiaryEmail,
            BeneficiaryPosition,
            BeneficiaryDepartment,
            BeneficiaryPhoneNumber,
            BeneficiaryCompany,
            BeneficiaryExtention,
            RequestId
        FROM DELETED;

        -- Insert the new record with status 'New'
        INSERT INTO audit.AuditManliftReservationRequest (ManliftNumber, RequestedFrom, RequestedTo, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryPhoneNumber, BeneficiaryCompany, BeneficiaryExtention, RequestId)
        SELECT
            ManliftNumber,
            RequestedFrom,
            RequestedTo,
            CreatedAt,
            ModifiedAt,
            CreatedBy,
            ModifiedBy,
            @TransactionType,
            'New' AS DataStatus,
            GETDATE() AS TimeStamp,
            RequestNumber,
            BeneficiaryId,
            BeneficiaryName,
            BeneficiaryEmail,
            BeneficiaryPosition,
            BeneficiaryDepartment,
            BeneficiaryPhoneNumber,
            BeneficiaryCompany,
            BeneficiaryExtention,
            RequestId
        FROM INSERTED;
    END
    ELSE 
    BEGIN
        -- This is a DELETE operation
        SET @TransactionType = 'DELETE';

        -- Insert the old record with status 'Old'
        INSERT INTO audit.AuditManliftReservationRequest (ManliftNumber, RequestedFrom, RequestedTo, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryPhoneNumber, BeneficiaryCompany, BeneficiaryExtention, RequestId)
        SELECT
            ManliftNumber,
            RequestedFrom,
            RequestedTo,
            CreatedAt,
            ModifiedAt,
            CreatedBy,
            ModifiedBy,
            @TransactionType,
            'Old' AS DataStatus,
            GETDATE() AS TimeStamp,
            RequestNumber,
            BeneficiaryId,
            BeneficiaryName,
            BeneficiaryEmail,
            BeneficiaryPosition,
            BeneficiaryDepartment,
            BeneficiaryPhoneNumber,
            BeneficiaryCompany,
            BeneficiaryExtention,
            RequestId
        FROM DELETED;
    END
END;
GO
ALTER TABLE [dbo].[ManliftReservationRequest] ENABLE TRIGGER [TR_AuditManliftReservationRequest]
GO
/****** Object:  Trigger [dbo].[TR_AuditNewItemRequest]    Script Date: 11/18/2023 10:36:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TR_AuditNewItemRequest]
ON [dbo].[NewItemRequest]
AFTER UPDATE, DELETE
AS
BEGIN
    DECLARE @TransactionType NVARCHAR(max);

    -- Get the operation type
    IF EXISTS (SELECT * FROM INSERTED)
    BEGIN
        -- This is an UPDATE operation
        SET @TransactionType = 'UPDATE';

        -- Insert the old record with status 'Old'
        INSERT INTO audit.AuditNewItemRequest ( CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryPhoneNumber, BeneficiaryCompany, BeneficiaryExtention, RequestId)
        SELECT
            CreatedAt,
            ModifiedAt,
            CreatedBy,
            ModifiedBy,
            @TransactionType,
            'Old' AS DataStatus,
            GETDATE() AS TimeStamp,
            RequestNumber,
            BeneficiaryId,
            BeneficiaryName,
            BeneficiaryEmail,
            BeneficiaryPosition,
            BeneficiaryDepartment,
            BeneficiaryPhoneNumber,
            BeneficiaryCompany,
            BeneficiaryExtention,
            RequestId
        FROM DELETED;

        -- Insert the new record with status 'New'
        INSERT INTO audit.AuditNewItemRequest ( CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryPhoneNumber, BeneficiaryCompany, BeneficiaryExtention, RequestId)
        SELECT
            CreatedAt,
            ModifiedAt,
            CreatedBy,
            ModifiedBy,
            @TransactionType,
            'New' AS DataStatus,
            GETDATE() AS TimeStamp,
            RequestNumber,
            BeneficiaryId,
            BeneficiaryName,
            BeneficiaryEmail,
            BeneficiaryPosition,
            BeneficiaryDepartment,
            BeneficiaryPhoneNumber,
            BeneficiaryCompany,
            BeneficiaryExtention,
            RequestId
        FROM INSERTED;
    END
    ELSE 
    BEGIN
        -- This is a DELETE operation
        SET @TransactionType = 'DELETE';

        -- Insert the old record with status 'Old'
        INSERT INTO audit.AuditNewItemRequest ( CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryPhoneNumber, BeneficiaryCompany, BeneficiaryExtention, RequestId)
        SELECT
            CreatedAt,
            ModifiedAt,
            CreatedBy,
            ModifiedBy,
            @TransactionType,
            'Old' AS DataStatus,
            GETDATE() AS TimeStamp,
            RequestNumber,
            BeneficiaryId,
            BeneficiaryName,
            BeneficiaryEmail,
            BeneficiaryPosition,
            BeneficiaryDepartment,
            BeneficiaryPhoneNumber,
            BeneficiaryCompany,
            BeneficiaryExtention,
            RequestId
        FROM DELETED;
    END
END;
GO
ALTER TABLE [dbo].[NewItemRequest] ENABLE TRIGGER [TR_AuditNewItemRequest]
GO
/****** Object:  Trigger [dbo].[TR_AuditPrRequest]    Script Date: 11/18/2023 10:36:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TR_AuditPrRequest]
ON [dbo].[PrRequest]
AFTER UPDATE, DELETE
AS
BEGIN
    DECLARE @TransactionType NVARCHAR(max);

    -- Get the operation type
    IF EXISTS (SELECT * FROM INSERTED)
    BEGIN
        -- This is an UPDATE operation
        SET @TransactionType = 'UPDATE';

        -- Insert the old record with status 'Old'
        INSERT INTO audit.AuditPrRequest (PrSubject, BudgetType, AfeNumber, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryPhoneNumber, BeneficiaryCompany, BeneficiaryExtention, RequestId)
        SELECT
            PrSubject, 
			BudgetType,
            AfeNumber,
            CreatedAt,
            ModifiedAt,
            CreatedBy,
            ModifiedBy,
            @TransactionType,
            'Old' AS DataStatus,
            GETDATE() AS TimeStamp,
            RequestNumber,
            BeneficiaryId,
            BeneficiaryName,
            BeneficiaryEmail,
            BeneficiaryPosition,
            BeneficiaryDepartment,
            BeneficiaryPhoneNumber,
            BeneficiaryCompany,
            BeneficiaryExtention,
            RequestId
        FROM DELETED;

        -- Insert the new record with status 'New'
        INSERT INTO audit.AuditPrRequest (PrSubject,BudgetType, AfeNumber, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryPhoneNumber, BeneficiaryCompany, BeneficiaryExtention, RequestId)
        SELECT
            PrSubject,  
			BudgetType,
            AfeNumber,
            CreatedAt,
            ModifiedAt,
            CreatedBy,
            ModifiedBy,
            @TransactionType,
            'New' AS DataStatus,
            GETDATE() AS TimeStamp,
            RequestNumber,
            BeneficiaryId,
            BeneficiaryName,
            BeneficiaryEmail,
            BeneficiaryPosition,
            BeneficiaryDepartment,
            BeneficiaryPhoneNumber,
            BeneficiaryCompany,
            BeneficiaryExtention,
            RequestId
        FROM INSERTED;
    END
    ELSE 
    BEGIN
        -- This is a DELETE operation
        SET @TransactionType = 'DELETE';

        -- Insert the old record with status 'Old'
        INSERT INTO audit.AuditPrRequest (PrSubject, BudgetType, AfeNumber, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryPhoneNumber, BeneficiaryCompany, BeneficiaryExtention, RequestId)
        SELECT
            PrSubject,   
			BudgetType,
            AfeNumber,
            CreatedAt,
            ModifiedAt,
            CreatedBy,
            ModifiedBy,
            @TransactionType,
            'Old' AS DataStatus,
            GETDATE() AS TimeStamp,
            RequestNumber,
            BeneficiaryId,
            BeneficiaryName,
            BeneficiaryEmail,
            BeneficiaryPosition,
            BeneficiaryDepartment,
            BeneficiaryPhoneNumber,
            BeneficiaryCompany,
            BeneficiaryExtention,
            RequestId
        FROM DELETED;
    END
END;
GO
ALTER TABLE [dbo].[PrRequest] ENABLE TRIGGER [TR_AuditPrRequest]
GO
/****** Object:  Trigger [dbo].[TR_AuditRefundRequest]    Script Date: 11/18/2023 10:36:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Create a trigger for the RefundRequest table
CREATE TRIGGER [dbo].[TR_AuditRefundRequest]
ON [dbo].[RefundRequest]
AFTER UPDATE, DELETE
AS
BEGIN
    DECLARE @TransactionType NVARCHAR(max);

    -- Get the operation type
    IF EXISTS (SELECT * FROM INSERTED)
    BEGIN
        -- This is an UPDATE operation
        SET @TransactionType = 'UPDATE';

        -- Insert the old record with status 'Old'
        INSERT INTO Audit.AuditRefundRequest (RequestNumber, RequestId, CustomerName, CustomerMobileNumber, RefundSubject, RefundDescription, RefundType, ShipmentType, DocumentNumber, RelatedContainers, ConcernedEmployeeId, ConcernedEmployeeName, Amount, CreditNote, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp)
        SELECT
            RequestNumber,
            RequestId,
            CustomerName,
            CustomerMobileNumber,
            RefundSubject,
            RefundDescription,
            RefundType,
            ShipmentType,
            DocumentNumber,
            RelatedContainers,
            ConcernedEmployeeId,
            ConcernedEmployeeName,
            Amount,
            CreditNote,
            CreatedAt,
            ModifiedAt,
            CreatedBy,
            ModifiedBy,
            @TransactionType,
            'Old' AS DataStatus,
            GETDATE() AS TimeStamp
        FROM DELETED;

        -- Insert the new record with status 'New'
        INSERT INTO Audit.AuditRefundRequest (RequestNumber, RequestId, CustomerName, CustomerMobileNumber, RefundSubject, RefundDescription, RefundType, ShipmentType, DocumentNumber, RelatedContainers, ConcernedEmployeeId, ConcernedEmployeeName, Amount, CreditNote, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp)
        SELECT
            RequestNumber,
            RequestId,
            CustomerName,
            CustomerMobileNumber,
            RefundSubject,
            RefundDescription,
            RefundType,
            ShipmentType,
            DocumentNumber,
            RelatedContainers,
            ConcernedEmployeeId,
            ConcernedEmployeeName,
            Amount,
            CreditNote,
            CreatedAt,
            ModifiedAt,
            CreatedBy,
            ModifiedBy,
            @TransactionType,
            'New' AS DataStatus,
            GETDATE() AS TimeStamp
        FROM INSERTED;
    END
    ELSE 
    BEGIN
        -- This is a DELETE operation
        SET @TransactionType = 'DELETE';

        -- Insert the old record with status 'Old'
        INSERT INTO Audit.AuditRefundRequest (RequestNumber, RequestId, CustomerName, CustomerMobileNumber, RefundSubject, RefundDescription, RefundType, ShipmentType, DocumentNumber, RelatedContainers, ConcernedEmployeeId, ConcernedEmployeeName, Amount, CreditNote, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp)
        SELECT
            RequestNumber,
            RequestId,
            CustomerName,
            CustomerMobileNumber,
            RefundSubject,
            RefundDescription,
            RefundType,
            ShipmentType,
            DocumentNumber,
            RelatedContainers,
            ConcernedEmployeeId,
            ConcernedEmployeeName,
            Amount,
            CreditNote,
            CreatedAt,
            ModifiedAt,
            CreatedBy,
            ModifiedBy,
            @TransactionType,
            'Old' AS DataStatus,
            GETDATE() AS TimeStamp
        FROM DELETED;
    END
END;
GO
ALTER TABLE [dbo].[RefundRequest] ENABLE TRIGGER [TR_AuditRefundRequest]
GO
/****** Object:  Trigger [dbo].[TR_AuditRequestedItem]    Script Date: 11/18/2023 10:36:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TR_AuditRequestedItem]
ON [dbo].[RequestedItem]
AFTER UPDATE, DELETE
AS
BEGIN
    DECLARE @TransactionType NVARCHAR(max);

    -- Get the operation type
    IF EXISTS (SELECT * FROM INSERTED)
    BEGIN
        -- This is an UPDATE operation
        SET @TransactionType = 'UPDATE';

        -- Insert the old record with status 'Old'
        INSERT INTO audit.AuditRequestedItem (ItemDescription, EquipmentType, PartNumber, Manufacturing,BudgetType, CommodityCode, StoreRoom, Unit, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, ItemNumber, RequestedItemId, RequestId)
        SELECT
			ItemDescription,
			EquipmentType, 
			PartNumber, 
			Manufacturing,
            BudgetType,
            CommodityCode,
            StoreRoom,
            Unit,
            CreatedAt,
            ModifiedAt,
            CreatedBy,
            ModifiedBy,
            @TransactionType,
            'Old' AS DataStatus,
            GETDATE() AS TimeStamp,
            ItemNumber,
            RequestedItemId,
            RequestId
        FROM DELETED;

        -- Insert the new record with status 'New'
        INSERT INTO audit.AuditRequestedItem (ItemDescription, EquipmentType, PartNumber, Manufacturing,BudgetType, CommodityCode, StoreRoom, Unit, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, ItemNumber, RequestedItemId, RequestId)
        SELECT
			ItemDescription, 
			EquipmentType,
			PartNumber,
			Manufacturing,
            BudgetType,
            CommodityCode,
            StoreRoom,
            Unit,
            CreatedAt,
            ModifiedAt,
            CreatedBy,
            ModifiedBy,
            @TransactionType,
            'New' AS DataStatus,
            GETDATE() AS TimeStamp,
            ItemNumber,
            RequestedItemId,
            RequestId
        FROM INSERTED;
    END
    ELSE 
    BEGIN
        -- This is a DELETE operation
        SET @TransactionType = 'DELETE';

        -- Insert the old record with status 'Old'
        INSERT INTO audit.AuditRequestedItem (ItemDescription, EquipmentType, PartNumber, Manufacturing,BudgetType, CommodityCode, StoreRoom, Unit, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, ItemNumber, RequestedItemId, RequestId)
        SELECT
			ItemDescription, 
			EquipmentType,
			PartNumber, 
			Manufacturing,
            BudgetType,
            CommodityCode,
            StoreRoom,
            Unit,
            CreatedAt,
            ModifiedAt,
            CreatedBy,
            ModifiedBy,
            @TransactionType,
            'Old' AS DataStatus,
            GETDATE() AS TimeStamp,
            ItemNumber,
            RequestedItemId,
            RequestId
        FROM DELETED;
    END
END;
GO
ALTER TABLE [dbo].[RequestedItem] ENABLE TRIGGER [TR_AuditRequestedItem]
GO
/****** Object:  Trigger [dbo].[TR_AuditRequestedPr]    Script Date: 11/18/2023 10:36:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TR_AuditRequestedPr]
ON [dbo].[RequestedPr]
AFTER UPDATE, DELETE
AS
BEGIN
    DECLARE @TransactionType NVARCHAR(max);

    -- Get the operation type
    IF EXISTS (SELECT * FROM INSERTED)
    BEGIN
        -- This is an UPDATE operation
        SET @TransactionType = 'UPDATE';

        -- Insert the old record with status 'Old'
        INSERT INTO audit.AuditRequestedPr (RequestedPrId, PrNumber, RequestType, PrDescription, Quantity, ItemNumber, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestId)
        SELECT
            RequestedPrId,
            PrNumber,
            RequestType,
            PrDescription,
            Quantity,
			ItemNumber,
            CreatedAt,
            ModifiedAt,
            CreatedBy,
            ModifiedBy,
            @TransactionType,
            'Old' AS DataStatus,
            GETDATE() AS TimeStamp,
            RequestId
        FROM DELETED;

        -- Insert the new record with status 'New'
        INSERT INTO audit.AuditRequestedPr (RequestedPrId, PrNumber, RequestType, PrDescription, Quantity,ItemNumber, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestId)
        SELECT
            RequestedPrId,
            PrNumber,
            RequestType,
            PrDescription,
            Quantity,
			ItemNumber,
            CreatedAt,
            ModifiedAt,
            CreatedBy,
            ModifiedBy,
            @TransactionType,
            'New' AS DataStatus,
            GETDATE() AS TimeStamp,
            RequestId
        FROM INSERTED;
    END
    ELSE 
    BEGIN
        -- This is a DELETE operation
        SET @TransactionType = 'DELETE';

        -- Insert the old record with status 'Old'
        INSERT INTO audit.AuditRequestedPR (RequestedPrId, PrNumber, RequestType, PrDescription, Quantity,ItemNumber, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestId)
        SELECT
            RequestedPRId,
            PrNumber,
            RequestType,
            PrDescription,
            Quantity,
			ItemNumber,
            CreatedAt,
            ModifiedAt,
            CreatedBy,
            ModifiedBy,
            @TransactionType,
            'Old' AS DataStatus,
            GETDATE() AS TimeStamp,
            RequestId
        FROM DELETED;
    END
END;
GO
ALTER TABLE [dbo].[RequestedPr] ENABLE TRIGGER [TR_AuditRequestedPr]
GO
