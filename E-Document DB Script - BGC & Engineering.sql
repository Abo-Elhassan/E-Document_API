USE [E-Document]
GO
/****** Object:  Table [audit].[AuditEquipmentRequestIn]    Script Date: 11/26/2023 1:07:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [audit].[AuditEquipmentRequestIn](
	[AuditId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[CommunicationFacility] [nvarchar](max) NULL,
	[Area] [nvarchar](max) NULL,
	[EquipmentType] [nvarchar](max) NULL,
	[RequestedDateFrom] [datetime2](7) NOT NULL,
	[RequestedDateTo] [datetime2](7) NOT NULL,
	[Additionaltools] [nvarchar](max) NULL,
	[SupervisorId] [nvarchar](max) NULL,
	[SupervisorName] [nvarchar](max) NULL,
	[SupervisorPhoneNumber] [nvarchar](max) NULL,
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
 CONSTRAINT [PK_AuditEquipmentRequestIn] PRIMARY KEY CLUSTERED 
(
	[AuditId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [audit].[AuditEquipmentRequestOut]    Script Date: 11/26/2023 1:07:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [audit].[AuditEquipmentRequestOut](
	[AuditId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[CommunicationFacility] [nvarchar](max) NULL,
	[Area] [nvarchar](max) NULL,
	[EquipmentType] [nvarchar](max) NULL,
	[RequestedDateFrom] [datetime2](7) NOT NULL,
	[RequestedDateTo] [datetime2](7) NOT NULL,
	[Additionaltools] [nvarchar](max) NULL,
	[SupervisorId] [nvarchar](max) NULL,
	[SupervisorName] [nvarchar](max) NULL,
	[SupervisorPhoneNumber] [nvarchar](max) NULL,
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
 CONSTRAINT [PK_AuditEquipmentRequestOut] PRIMARY KEY CLUSTERED 
(
	[AuditId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [audit].[AuditPmJpRequest]    Script Date: 11/26/2023 1:07:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [audit].[AuditPmJpRequest](
	[AuditId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[RequestNumber] [nvarchar](max) NULL,
	[DescriptionOfChange] [nvarchar](max) NULL,
	[ChangeType] [nvarchar](max) NULL,
	[StartDate] [datetime2](7) NOT NULL,
	[EndDate] [datetime2](7) NULL,
	[PmJpCode] [nvarchar](max) NULL,
	[AssetType] [nvarchar](max) NULL,
	[AssetCode] [nvarchar](max) NULL,
	[CurrentInterval] [nvarchar](max) NULL,
	[NewInterval] [nvarchar](max) NULL,
	[AddedMaterials] [nvarchar](max) NULL,
	[RemovedMaterials] [nvarchar](max) NULL,
	[AddedLaborCraft] [nvarchar](max) NULL,
	[RemovedLaborCraft] [nvarchar](max) NULL,
	[AddedTask] [nvarchar](max) NULL,
	[RemovedTask] [nvarchar](max) NULL,
	[AddedMeter] [nvarchar](max) NULL,
	[RemovedMeter] [nvarchar](max) NULL,
	[PmPriority] [int] NULL,
	[RequestId] [bigint] NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[ModifiedBy] [nvarchar](max) NULL,
	[TransactionType] [nvarchar](max) NOT NULL,
	[DataStatus] [nvarchar](max) NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
	[ChangeReason] [nvarchar](max) NULL,
	[RequesterSection] [nvarchar](max) NULL,
 CONSTRAINT [PK_AuditPmJpRequest] PRIMARY KEY CLUSTERED 
(
	[AuditId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [audit].[AuditReschedulePmWoRequest]    Script Date: 11/26/2023 1:07:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [audit].[AuditReschedulePmWoRequest](
	[AuditId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[RequestNumber] [nvarchar](max) NULL,
	[DescriptionOfChange] [nvarchar](max) NULL,
	[ReasonForRescheduling] [nvarchar](max) NULL,
	[RescheduleFrom] [datetime2](7) NOT NULL,
	[RescheduleTo] [datetime2](7) NOT NULL,
	[WoNumber] [nvarchar](max) NULL,
	[RequestId] [bigint] NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[ModifiedBy] [nvarchar](max) NULL,
	[TransactionType] [nvarchar](max) NOT NULL,
	[DataStatus] [nvarchar](max) NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
	[RequesterSection] [nvarchar](max) NULL,
 CONSTRAINT [PK_AuditReschedulePmWoRequest] PRIMARY KEY CLUSTERED 
(
	[AuditId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/****** Object:  Table [dbo].[EquipmentRequestIn]    Script Date: 11/26/2023 1:07:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EquipmentRequestIn](
	[RequestNumber] [nvarchar](50) NOT NULL,
	[CommunicationFacility] [nvarchar](300) NOT NULL,
	[EquipmentType] [nvarchar](300) NOT NULL,
	[Area] [nvarchar](300) NOT NULL,
	[RequestedDateFrom] [smalldatetime] NOT NULL,
	[RequestedDateTo] [smalldatetime] NOT NULL,
	[SupervisorId] [nvarchar](50) NOT NULL,
	[SupervisorName] [nvarchar](200) NOT NULL,
	[RequestId] [bigint] NOT NULL,
	[CreatedAt] [smalldatetime] NULL,
	[ModifiedAt] [smalldatetime] NULL,
	[CreatedBy] [nvarchar](200) NULL,
	[ModifiedBy] [nvarchar](200) NULL,
	[Additionaltools] [nvarchar](300) NULL,
	[BeneficiaryCompany] [nvarchar](200) NULL,
	[BeneficiaryDepartment] [nvarchar](200) NULL,
	[BeneficiaryEmail] [nvarchar](50) NULL,
	[BeneficiaryExtention] [int] NULL,
	[BeneficiaryId] [nvarchar](50) NOT NULL,
	[BeneficiaryName] [nvarchar](200) NOT NULL,
	[BeneficiaryPhoneNumber] [nvarchar](50) NULL,
	[BeneficiaryPosition] [nvarchar](200) NULL,
	[SupervisorPhoneNumber] [nvarchar](50) NULL,
 CONSTRAINT [PK_EquipmentRequestIn] PRIMARY KEY CLUSTERED 
(
	[RequestNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EquipmentRequestOut]    Script Date: 11/26/2023 1:07:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EquipmentRequestOut](
	[RequestNumber] [nvarchar](50) NOT NULL,
	[CommunicationFacility] [nvarchar](300) NOT NULL,
	[EquipmentType] [nvarchar](300) NOT NULL,
	[Area] [nvarchar](300) NOT NULL,
	[RequestedDateFrom] [smalldatetime] NOT NULL,
	[RequestedDateTo] [smalldatetime] NOT NULL,
	[SupervisorId] [nvarchar](50) NOT NULL,
	[SupervisorName] [nvarchar](200) NOT NULL,
	[RequestId] [bigint] NOT NULL,
	[CreatedAt] [smalldatetime] NULL,
	[ModifiedAt] [smalldatetime] NULL,
	[CreatedBy] [nvarchar](200) NULL,
	[ModifiedBy] [nvarchar](200) NULL,
	[Additionaltools] [nvarchar](300) NULL,
	[BeneficiaryCompany] [nvarchar](200) NULL,
	[BeneficiaryDepartment] [nvarchar](200) NULL,
	[BeneficiaryEmail] [nvarchar](50) NULL,
	[BeneficiaryExtention] [int] NULL,
	[BeneficiaryId] [nvarchar](50) NOT NULL,
	[BeneficiaryName] [nvarchar](200) NOT NULL,
	[BeneficiaryPhoneNumber] [nvarchar](50) NULL,
	[BeneficiaryPosition] [nvarchar](200) NULL,
	[SupervisorPhoneNumber] [nvarchar](50) NULL,
 CONSTRAINT [PK_EquipmentRequestOut] PRIMARY KEY CLUSTERED 
(
	[RequestNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PmJpRequest]    Script Date: 11/26/2023 1:07:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PmJpRequest](
	[RequestNumber] [nvarchar](50) NOT NULL,
	[DescriptionOfChange] [nvarchar](max) NULL,
	[ChangeType] [nvarchar](50) NOT NULL,
	[StartDate] [smalldatetime] NOT NULL,
	[EndDate] [smalldatetime] NULL,
	[PmJpCode] [nvarchar](50) NULL,
	[AssetType] [nvarchar](50) NULL,
	[AssetCode] [nvarchar](50) NULL,
	[CurrentInterval] [nvarchar](50) NULL,
	[NewInterval] [nvarchar](50) NULL,
	[AddedMaterials] [nvarchar](500) NULL,
	[RemovedMaterials] [nvarchar](500) NULL,
	[AddedLaborCraft] [nvarchar](500) NULL,
	[RemovedLaborCraft] [nvarchar](500) NULL,
	[AddedTask] [nvarchar](max) NULL,
	[RemovedTask] [nvarchar](max) NULL,
	[AddedMeter] [nvarchar](500) NULL,
	[RemovedMeter] [nvarchar](500) NULL,
	[PmPriority] [int] NULL,
	[RequestId] [bigint] NOT NULL,
	[CreatedAt] [smalldatetime] NULL,
	[ModifiedAt] [smalldatetime] NULL,
	[CreatedBy] [nvarchar](200) NULL,
	[ModifiedBy] [nvarchar](200) NULL,
	[ChangeReason] [nvarchar](max) NULL,
	[RequesterSection] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PmJpRequest] PRIMARY KEY CLUSTERED 
(
	[RequestNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReschedulePmWoRequest]    Script Date: 11/26/2023 1:07:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReschedulePmWoRequest](
	[RequestNumber] [nvarchar](50) NOT NULL,
	[DescriptionOfChange] [nvarchar](max) NULL,
	[ReasonForRescheduling] [nvarchar](max) NULL,
	[RescheduleFrom] [smalldatetime] NOT NULL,
	[RescheduleTo] [smalldatetime] NOT NULL,
	[WoNumber] [nvarchar](50) NOT NULL,
	[RequestId] [bigint] NOT NULL,
	[CreatedAt] [smalldatetime] NULL,
	[ModifiedAt] [smalldatetime] NULL,
	[CreatedBy] [nvarchar](200) NULL,
	[ModifiedBy] [nvarchar](200) NULL,
	[RequesterSection] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ReschedulePmWoRequest] PRIMARY KEY CLUSTERED 
(
	[RequestNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231121092055_addReschedulePmWoRequest', N'7.0.10')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231121125111_AddConcernedDepartmentRefundRequest', N'7.0.10')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231122064643_addWorkingAreaField', N'7.0.10')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231122110134_addPmJpRequest', N'7.0.10')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231122124420_addChangeReasonInPmJpRequest', N'7.0.10')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231123063814_AdjustEquipmentRequests-BGC', N'7.0.10')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231123064016_AddAuditTablesEquipmentRequests-BGC', N'7.0.10')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231123130729_addMultimediaRequest', N'7.0.10')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231126062558_addRequesterSectionForMOCRequests', N'7.0.10')
GO
INSERT [dbo].[DefinedRequest] ([Id], [RequestName], [RouteName], [ReviewersNumber], [DepartmentId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023111310582624, N'Equipment Request - (In Concession Area)', N'/OPS-BGC/InConcessionArea/', 2, 26, CAST(N'2023-11-13T10:58:00' AS SmallDateTime), NULL, N'E-Document', NULL)
GO
INSERT [dbo].[DefinedRequest] ([Id], [RequestName], [RouteName], [ReviewersNumber], [DepartmentId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023111311113090, N'Equipment Request - (Out Concession Area)', N'/OPS-BGC/OutConcessionArea/', 3, 26, CAST(N'2023-11-13T11:12:00' AS SmallDateTime), NULL, N'E-Document', NULL)
GO
INSERT [dbo].[DefinedRequest] ([Id], [RequestName], [RouteName], [ReviewersNumber], [DepartmentId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023112111535000, N'Reschedule PM/WO', N'/Engineering/ReschedulePmWo/', 3, 21, CAST(N'2023-11-21T11:54:00' AS SmallDateTime), NULL, N'E-Document', NULL)
GO
INSERT [dbo].[DefinedRequest] ([Id], [RequestName], [RouteName], [ReviewersNumber], [DepartmentId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023112307532308, N'PM/JP', N'/Engineering/PmJp/', 3, 21, CAST(N'2023-11-23T07:53:00' AS SmallDateTime), NULL, N'E-Document', NULL)
GO
SET IDENTITY_INSERT [dbo].[DefinedRequestReviewer] ON 
GO
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (30163, 2023111310582624, NULL, N'Requester Direct Manager', 1, N'DirectManager', CAST(N'2023-11-13T10:58:00' AS SmallDateTime), NULL, N'E-Documnet', NULL)
GO
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (30164, 2023111310582624, N'51450', N'BGC Supervisor', 2, N'Basic', CAST(N'2023-11-13T10:58:00' AS SmallDateTime), NULL, N'E-Documnet', NULL)
GO
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (30165, 2023111310582624, N'50844', N'BGC Supervisor', 2, N'Basic', CAST(N'2023-11-13T10:58:00' AS SmallDateTime), NULL, N'E-Documnet', NULL)
GO
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (30166, 2023111310582624, N'51474', N'BGC Supervisor', 2, N'Basic', CAST(N'2023-11-13T10:58:00' AS SmallDateTime), NULL, N'E-Documnet', NULL)
GO
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (30167, 2023111310582624, N'51630', N'BGC Supervisor', 2, N'Basic', CAST(N'2023-11-13T10:58:00' AS SmallDateTime), NULL, N'E-Documnet', NULL)
GO
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (30168, 2023111310582624, N'50875', N'BGC Supervisor', 2, N'Basic', CAST(N'2023-11-13T10:58:00' AS SmallDateTime), NULL, N'E-Documnet', NULL)
GO
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (30169, 2023111310582624, N'51475', N'BGC Supervisor', 2, N'Basic', CAST(N'2023-11-13T10:58:00' AS SmallDateTime), NULL, N'E-Documnet', NULL)
GO
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (30170, 2023111310582624, N'50236', N'BGC Supervisor', 2, N'Basic', CAST(N'2023-11-13T10:58:00' AS SmallDateTime), NULL, N'E-Documnet', NULL)
GO
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (30171, 2023111310582624, N'50972', N'BGC Supervisor', 2, N'Basic', CAST(N'2023-11-13T10:58:00' AS SmallDateTime), NULL, N'E-Documnet', NULL)
GO
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (30172, 2023111310582624, N'51452', N'BGC Supervisor', 2, N'Basic', CAST(N'2023-11-13T10:58:00' AS SmallDateTime), NULL, N'E-Documnet', NULL)
GO
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (30173, 2023111311113090, NULL, N'Requester Direct Manager', 1, N'DirectManager', CAST(N'2023-11-13T11:12:00' AS SmallDateTime), NULL, N'E-Documnet', NULL)
GO
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (30174, 2023111311113090, N'50354', N'BGC-OPS Head', 2, N'DepartmentManager', CAST(N'2023-11-13T11:12:00' AS SmallDateTime), NULL, N'E-Documnet', NULL)
GO
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (30175, 2023111311113090, N'50845', N'BGC-OPS Head', 2, N'DepartmentManager', CAST(N'2023-11-13T11:12:00' AS SmallDateTime), NULL, N'E-Documnet', NULL)
GO
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (30176, 2023111311113090, N'51449', N'BGC-OPS Head', 2, N'DepartmentManager', CAST(N'2023-11-13T11:12:00' AS SmallDateTime), NULL, N'E-Documnet', NULL)
GO
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (30177, 2023111311113090, N'50263', N'Security Head', 3, N'DepartmentManager', CAST(N'2023-11-13T11:12:00' AS SmallDateTime), NULL, N'E-Documnet', NULL)
GO
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (30178, 2023112111535000, NULL, N'Section Head', 1, N'SectionHead', CAST(N'2023-11-21T11:54:00' AS SmallDateTime), NULL, N'E-Documnet', NULL)
GO
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (30179, 2023112111535000, N'50136', N'Engineering Head', 2, N'DepartmentManager', CAST(N'2023-11-21T11:54:00' AS SmallDateTime), NULL, N'E-Document', NULL)
GO
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (40178, 2023112307532308, NULL, N'Section Head', 1, N'SectionHead', CAST(N'2023-11-23T07:53:00' AS SmallDateTime), NULL, N'E-Document', NULL)
GO
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (40179, 2023112307532308, N'50136', N'Engineering Head', 2, N'DepartmentManager', CAST(N'2023-11-23T07:53:00' AS SmallDateTime), NULL, N'E-Document', NULL)
GO
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (40180, 2023112111535000, N'51250', N'Technical Planning Team', 3, N'Basic', CAST(N'2023-11-23T07:53:00' AS SmallDateTime), NULL, N'E-Document', NULL)
GO
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (40182, 2023112111535000, N'51258', N'Technical Planning Team', 3, N'Basic', CAST(N'2023-11-23T07:53:00' AS SmallDateTime), NULL, N'E-Document', NULL)
GO
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (40183, 2023112111535000, N'51277', N'Technical Planning Team', 3, N'Basic', CAST(N'2023-11-23T07:53:00' AS SmallDateTime), NULL, N'E-Document', NULL)
GO
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (40184, 2023112111535000, N'51459', N'Technical Planning Team', 3, N'Basic', CAST(N'2023-11-23T07:53:00' AS SmallDateTime), NULL, N'E-Document', NULL)
GO
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (40185, 2023112111535000, N'51545', N'Technical Planning Team', 3, N'Basic', CAST(N'2023-11-23T07:53:00' AS SmallDateTime), NULL, N'E-Document', NULL)
GO
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (40186, 2023112307532308, N'51250', N'Technical Planning Team', 3, N'Basic', CAST(N'2023-11-23T07:53:00' AS SmallDateTime), NULL, N'E-Document', NULL)
GO
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (40187, 2023112307532308, N'51258', N'Technical Planning Team', 3, N'Basic', CAST(N'2023-11-23T07:53:00' AS SmallDateTime), NULL, N'E-Document', NULL)
GO
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (40188, 2023112307532308, N'51277', N'Technical Planning Team', 3, N'Basic', CAST(N'2023-11-23T07:53:00' AS SmallDateTime), NULL, N'E-Document', NULL)
GO
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (40189, 2023112307532308, N'51459', N'Technical Planning Team', 3, N'Basic', CAST(N'2023-11-23T07:53:00' AS SmallDateTime), NULL, N'E-Document', NULL)
GO
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (40190, 2023112307532308, N'51545', N'Technical Planning Team', 3, N'Basic', CAST(N'2023-11-23T07:53:00' AS SmallDateTime), NULL, N'E-Document', NULL)
GO
SET IDENTITY_INSERT [dbo].[DefinedRequestReviewer] OFF
GO
ALTER TABLE [dbo].[EquipmentRequestIn]  WITH CHECK ADD  CONSTRAINT [FK_EquipmentRequestIn_Request] FOREIGN KEY([RequestId])
REFERENCES [dbo].[Request] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EquipmentRequestIn] CHECK CONSTRAINT [FK_EquipmentRequestIn_Request]
GO
ALTER TABLE [dbo].[EquipmentRequestOut]  WITH CHECK ADD  CONSTRAINT [FK_EquipmentRequestOut_Request] FOREIGN KEY([RequestId])
REFERENCES [dbo].[Request] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EquipmentRequestOut] CHECK CONSTRAINT [FK_EquipmentRequestOut_Request]
GO
ALTER TABLE [dbo].[PmJpRequest]  WITH CHECK ADD  CONSTRAINT [FK_PmJpRequest_Request] FOREIGN KEY([RequestId])
REFERENCES [dbo].[Request] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PmJpRequest] CHECK CONSTRAINT [FK_PmJpRequest_Request]
GO
ALTER TABLE [dbo].[ReschedulePmWoRequest]  WITH CHECK ADD  CONSTRAINT [FK_ReschedulePmWoRequest_Request] FOREIGN KEY([RequestId])
REFERENCES [dbo].[Request] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ReschedulePmWoRequest] CHECK CONSTRAINT [FK_ReschedulePmWoRequest_Request]
GO
/****** Object:  Trigger [dbo].[TR_AuditEquipmentRequestIn]    Script Date: 11/26/2023 1:07:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TR_AuditEquipmentRequestIn]
ON [dbo].[EquipmentRequestIn]
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
        INSERT INTO audit.AuditEquipmentRequestIn (CommunicationFacility, Area, EquipmentType, RequestedDateFrom, RequestedDateTo, Additionaltools, SupervisorId, SupervisorName, SupervisorPhoneNumber, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryPhoneNumber, BeneficiaryCompany, BeneficiaryExtention, RequestId)
        SELECT
            CommunicationFacility,
            Area,
            EquipmentType,
            RequestedDateFrom,
            RequestedDateTo,
            Additionaltools,
            SupervisorId,
            SupervisorName,
            SupervisorPhoneNumber,
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
        INSERT INTO audit.AuditEquipmentRequestIn (CommunicationFacility, Area, EquipmentType, RequestedDateFrom, RequestedDateTo, Additionaltools, SupervisorId, SupervisorName, SupervisorPhoneNumber, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryPhoneNumber, BeneficiaryCompany, BeneficiaryExtention, RequestId)
        SELECT
            CommunicationFacility,
            Area,
            EquipmentType,
            RequestedDateFrom,
            RequestedDateTo,
            Additionaltools,
            SupervisorId,
            SupervisorName,
            SupervisorPhoneNumber,
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
        INSERT INTO audit.AuditEquipmentRequestIn (CommunicationFacility, Area, EquipmentType, RequestedDateFrom, RequestedDateTo, Additionaltools, SupervisorId, SupervisorName, SupervisorPhoneNumber, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryPhoneNumber, BeneficiaryCompany, BeneficiaryExtention, RequestId)
        SELECT
            CommunicationFacility,
            Area,
            EquipmentType,
            RequestedDateFrom,
            RequestedDateTo,
            Additionaltools,
            SupervisorId,
            SupervisorName,
            SupervisorPhoneNumber,
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
ALTER TABLE [dbo].[EquipmentRequestIn] ENABLE TRIGGER [TR_AuditEquipmentRequestIn]
GO
/****** Object:  Trigger [dbo].[TR_AuditEquipmentRequestOut]    Script Date: 11/26/2023 1:07:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TR_AuditEquipmentRequestOut]
ON [dbo].[EquipmentRequestOut]
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
        INSERT INTO audit.AuditEquipmentRequestOut (CommunicationFacility, Area, EquipmentType, RequestedDateFrom, RequestedDateTo, Additionaltools, SupervisorId, SupervisorName, SupervisorPhoneNumber, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryPhoneNumber, BeneficiaryCompany, BeneficiaryExtention, RequestId)
        SELECT
            CommunicationFacility,
            Area,
            EquipmentType,
            RequestedDateFrom,
            RequestedDateTo,
            Additionaltools,
            SupervisorId,
            SupervisorName,
            SupervisorPhoneNumber,
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
        INSERT INTO audit.AuditEquipmentRequestOut (CommunicationFacility, Area, EquipmentType, RequestedDateFrom, RequestedDateTo, Additionaltools, SupervisorId, SupervisorName, SupervisorPhoneNumber, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryPhoneNumber, BeneficiaryCompany, BeneficiaryExtention, RequestId)
        SELECT
            CommunicationFacility,
            Area,
            EquipmentType,
            RequestedDateFrom,
            RequestedDateTo,
            Additionaltools,
            SupervisorId,
            SupervisorName,
            SupervisorPhoneNumber,
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
        INSERT INTO audit.AuditEquipmentRequestOut (CommunicationFacility, Area, EquipmentType, RequestedDateFrom, RequestedDateTo, Additionaltools, SupervisorId, SupervisorName, SupervisorPhoneNumber, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryPhoneNumber, BeneficiaryCompany, BeneficiaryExtention, RequestId)
        SELECT
            CommunicationFacility,
            Area,
            EquipmentType,
            RequestedDateFrom,
            RequestedDateTo,
            Additionaltools,
            SupervisorId,
            SupervisorName,
            SupervisorPhoneNumber,
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
ALTER TABLE [dbo].[EquipmentRequestOut] ENABLE TRIGGER [TR_AuditEquipmentRequestOut]
GO
/****** Object:  Trigger [dbo].[TR_AuditPmJpRequest]    Script Date: 11/26/2023 1:07:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TR_AuditPmJpRequest]
ON [dbo].[PmJpRequest]
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
        INSERT INTO audit.AuditPmJpRequest (RequestNumber,RequesterSection, DescriptionOfChange, ChangeType, StartDate, EndDate, PmJpCode, AssetType, AssetCode, CurrentInterval, NewInterval, AddedMaterials, RemovedMaterials, AddedLaborCraft, RemovedLaborCraft, AddedTask, RemovedTask, AddedMeter, RemovedMeter, PmPriority, RequestId, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, ChangeReason)
        SELECT
            RequestNumber,
			RequesterSection,
            DescriptionOfChange,
            ChangeType,
            StartDate,
            EndDate,
            PmJpCode,
            AssetType,
            AssetCode,
            CurrentInterval,
            NewInterval,
            AddedMaterials,
            RemovedMaterials,
            AddedLaborCraft,
            RemovedLaborCraft,
            AddedTask,
            RemovedTask,
            AddedMeter,
            RemovedMeter,
            PmPriority,
            RequestId,
            CreatedAt,
            ModifiedAt,
            CreatedBy,
            ModifiedBy,
            @TransactionType,
            'Old' AS DataStatus,
            GETDATE() AS TimeStamp,
            ChangeReason
        FROM DELETED;

        -- Insert the new record with status 'New'
        INSERT INTO audit.AuditPmJpRequest (RequestNumber,RequesterSection, DescriptionOfChange, ChangeType, StartDate, EndDate, PmJpCode, AssetType, AssetCode, CurrentInterval, NewInterval, AddedMaterials, RemovedMaterials, AddedLaborCraft, RemovedLaborCraft, AddedTask, RemovedTask, AddedMeter, RemovedMeter, PmPriority, RequestId, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, ChangeReason)
        SELECT
            RequestNumber,
			RequesterSection,
            DescriptionOfChange,
            ChangeType,
            StartDate,
            EndDate,
            PmJpCode,
            AssetType,
            AssetCode,
            CurrentInterval,
            NewInterval,
            AddedMaterials,
            RemovedMaterials,
            AddedLaborCraft,
            RemovedLaborCraft,
            AddedTask,
            RemovedTask,
            AddedMeter,
            RemovedMeter,
            PmPriority,
            RequestId,
            CreatedAt,
            ModifiedAt,
            CreatedBy,
            ModifiedBy,
            @TransactionType,
            'New' AS DataStatus,
            GETDATE() AS TimeStamp,
            ChangeReason
        FROM INSERTED;
    END
    ELSE 
    BEGIN
        -- This is a DELETE operation
        SET @TransactionType = 'DELETE';

        -- Insert the old record with status 'Old'
        INSERT INTO audit.AuditPmJpRequest (RequestNumber,RequesterSection, DescriptionOfChange, ChangeType, StartDate, EndDate, PmJpCode, AssetType, AssetCode, CurrentInterval, NewInterval, AddedMaterials, RemovedMaterials, AddedLaborCraft, RemovedLaborCraft, AddedTask, RemovedTask, AddedMeter, RemovedMeter, PmPriority, RequestId, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, ChangeReason)
        SELECT
            RequestNumber,
			RequesterSection,
            DescriptionOfChange,
            ChangeType,
            StartDate,
            EndDate,
            PmJpCode,
            AssetType,
            AssetCode,
            CurrentInterval,
            NewInterval,
            AddedMaterials,
            RemovedMaterials,
            AddedLaborCraft,
            RemovedLaborCraft,
            AddedTask,
            RemovedTask,
            AddedMeter,
            RemovedMeter,
            PmPriority,
            RequestId,
            CreatedAt,
            ModifiedAt,
            CreatedBy,
            ModifiedBy,
            @TransactionType,
            'Old' AS DataStatus,
            GETDATE() AS TimeStamp,
            ChangeReason
        FROM DELETED;
    END
END;
GO
ALTER TABLE [dbo].[PmJpRequest] ENABLE TRIGGER [TR_AuditPmJpRequest]
GO
/****** Object:  Trigger [dbo].[TR_AuditReschedulePmWoRequest]    Script Date: 11/26/2023 1:07:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TR_AuditReschedulePmWoRequest]
ON [dbo].[ReschedulePmWoRequest]
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
        INSERT INTO audit.AuditReschedulePmWoRequest (RequestNumber,RequesterSection, DescriptionOfChange, ReasonForRescheduling, RescheduleFrom, RescheduleTo, WoNumber, RequestId, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp)
        SELECT
            RequestNumber,
			RequesterSection,
            DescriptionOfChange,
            ReasonForRescheduling,
            RescheduleFrom,
            RescheduleTo,
            WoNumber,
            RequestId,
            CreatedAt,
            ModifiedAt,
            CreatedBy,
            ModifiedBy,
            @TransactionType,
            'Old' AS DataStatus,
            GETDATE() AS TimeStamp
        FROM DELETED;

        -- Insert the new record with status 'New'
        INSERT INTO audit.AuditReschedulePmWoRequest (RequestNumber,RequesterSection, DescriptionOfChange, ReasonForRescheduling, RescheduleFrom, RescheduleTo, WoNumber, RequestId, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp)
        SELECT
            RequestNumber,
			RequesterSection,
            DescriptionOfChange,
            ReasonForRescheduling,
            RescheduleFrom,
            RescheduleTo,
            WoNumber,
            RequestId,
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
        INSERT INTO audit.AuditReschedulePmWoRequest (RequestNumber,RequesterSection, DescriptionOfChange, ReasonForRescheduling, RescheduleFrom, RescheduleTo, WoNumber, RequestId, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp)
        SELECT
            RequestNumber,
			RequesterSection,
            DescriptionOfChange,
            ReasonForRescheduling,
            RescheduleFrom,
            RescheduleTo,
            WoNumber,
            RequestId,
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
ALTER TABLE [dbo].[ReschedulePmWoRequest] ENABLE TRIGGER [TR_AuditReschedulePmWoRequest]
GO
