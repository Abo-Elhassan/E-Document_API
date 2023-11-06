USE [E-Document]
GO
/****** Object:  Table [audit].[AuditAccessControlRequest]    Script Date: 11/6/2023 10:31:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [audit].[AuditAccessControlRequest](
	[AuditId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[AccessedBlocks] [nvarchar](max) NULL,
	[AccessMethods] [nvarchar](max) NULL,
	[EmployeeSignaturePath] [nvarchar](max) NULL,
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
 CONSTRAINT [PK_AuditAccessControlRequest] PRIMARY KEY CLUSTERED 
(
	[AuditId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [audit].[AuditCCTVAccessRequest]    Script Date: 11/6/2023 10:31:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [audit].[AuditCCTVAccessRequest](
	[AuditId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[RequestedRoles] [nvarchar](max) NULL,
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
 CONSTRAINT [PK_AuditCCTVAccessRequest] PRIMARY KEY CLUSTERED 
(
	[AuditId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 11/6/2023 10:31:57 AM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AccessControlRequest]    Script Date: 11/6/2023 10:31:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccessControlRequest](
	[RequestNumber] [nvarchar](50) NOT NULL,
	[AccessedBlocks] [nvarchar](200) NULL,
	[EmployeeSignaturePath] [nvarchar](max) NULL,
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
	[BeneficiaryExtention] [nvarchar](50) NULL,
	[RequestId] [bigint] NOT NULL,
	[AccessMethods] [nvarchar](200) NULL,
 CONSTRAINT [PK_AccessControlRequest] PRIMARY KEY CLUSTERED 
(
	[RequestNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CCTVAccessRequest]    Script Date: 11/6/2023 10:31:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CCTVAccessRequest](
	[RequestNumber] [nvarchar](50) NOT NULL,
	[RequestedRoles] [nvarchar](max) NOT NULL,
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
	[BeneficiaryExtention] [nvarchar](50) NULL,
	[RequestId] [bigint] NOT NULL,
 CONSTRAINT [PK_CCTVAccessRequest] PRIMARY KEY CLUSTERED 
(
	[RequestNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231101085944_addBenificaryComapnyInVehicleAndTravelDesk', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231101090920_addBenificaryComapnyInDomainAccountApplicationUser', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231101191748_addAccessControlAndCCTVRequests', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231101191929_makeVehicleRequestPkLenghtequal50', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231102063917_trasnferCCTVAndAccessControlAuditTableToAuditScheme', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231102135745_changeAccessedBlockesAndAccessMethodsSize', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231106082550_renameAccessMethodsColumnInAccessControl', N'7.0.10')
GO
INSERT [dbo].[AccessControlRequest] ([RequestNumber], [AccessedBlocks], [EmployeeSignaturePath], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryCompany], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId], [AccessMethods]) VALUES (N'AccessControl-20231105120815', N'string', N'F:\Work\My Projects\.Net\E-Document\EDocument_API\EDocument_API\wwwroot\Attachments\AccessControlRequest\2023110512081558\user_7957_cont_TEMU8791428_seal__gang_80011_2023_04_20_06_34.jpg', CAST(N'2023-11-05T12:08:00' AS SmallDateTime), NULL, N'Abd-ElHakeem Mohamed Abd-ElHakeem Ali', NULL, N'51678', N'Alaa Abou EL-Hassan Mohamed Mohamed', N'Alaa.Muhammad@dpworld.com', N'Sales Officer', N'IT', N'DP World', N'01002721159', N'365665', 2023110512081558, N'string')
GO
INSERT [dbo].[CCTVAccessRequest] ([RequestNumber], [RequestedRoles], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy], [BeneficiaryId], [BeneficiaryName], [BeneficiaryEmail], [BeneficiaryPosition], [BeneficiaryDepartment], [BeneficiaryCompany], [BeneficiaryPhoneNumber], [BeneficiaryExtention], [RequestId]) VALUES (N'CCTVAccess-20231101103203', N'IT', CAST(N'2023-11-01T22:32:00' AS SmallDateTime), CAST(N'2023-11-02T08:18:00' AS SmallDateTime), N'Khaled Mohamed Ali ElNagdy', N'Khaled Mohamed Ali ElNagdy', N'51343', N'Khaled Mohamed Ali ElNagdy', N'khaled.ali@dpworld.com', N'Applications Team Leader', N'IT', N'DP World', N'01227476073', N'2558', 2023110110320396)
GO
INSERT [dbo].[DefinedRequest] ([Id], [RequestName], [RouteName], [ReviewersNumber], [DepartmentId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023110110291740, N'CCTVAccess', N'/Security/CCTVAccess/', 5, 19, CAST(N'2023-11-01T22:29:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequest] ([Id], [RequestName], [RouteName], [ReviewersNumber], [DepartmentId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023110204192566, N'Access Control', N'/Security/AccessControl/', 4, 19, CAST(N'2023-11-02T16:19:00' AS SmallDateTime), NULL, N'Khaled Mohamed Ali ElNagdy', NULL)
GO
SET IDENTITY_INSERT [dbo].[DefinedRequestReviewer] ON 
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [DelegatedReviewerId], [StageName], [StageNumber], [ReviewerType], [DelegatedUntil], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (35, 2023110110291740, NULL, NULL, N'Requester Department Head', 1, N'DepartmentManager', NULL, CAST(N'2023-11-01T22:29:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [DelegatedReviewerId], [StageName], [StageNumber], [ReviewerType], [DelegatedUntil], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (36, 2023110110291740, N'51247', NULL, N'Control Room Superintend ', 2, N'Basic', NULL, CAST(N'2023-11-01T22:29:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [DelegatedReviewerId], [StageName], [StageNumber], [ReviewerType], [DelegatedUntil], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (37, 2023110110291740, N'50263', NULL, N'Security Head', 3, N'DepartmentManager', NULL, CAST(N'2023-11-01T22:29:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [DelegatedReviewerId], [StageName], [StageNumber], [ReviewerType], [DelegatedUntil], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (38, 2023110110291740, N'51331', NULL, N'IT Head', 4, N'DepartmentManager', NULL, CAST(N'2023-11-01T22:29:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [DelegatedReviewerId], [StageName], [StageNumber], [ReviewerType], [DelegatedUntil], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (39, 2023110110291740, N'51334', NULL, N'IT Admin', 5, N'Basic', NULL, CAST(N'2023-11-01T22:29:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [DelegatedReviewerId], [StageName], [StageNumber], [ReviewerType], [DelegatedUntil], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (40, 2023110110291740, N'51337', NULL, N'IT Admin', 5, N'Basic', NULL, CAST(N'2023-11-01T22:29:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [DelegatedReviewerId], [StageName], [StageNumber], [ReviewerType], [DelegatedUntil], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (41, 2023110110291740, N'50271', NULL, N'IT Admin', 5, N'Basic', NULL, CAST(N'2023-11-01T22:29:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [DelegatedReviewerId], [StageName], [StageNumber], [ReviewerType], [DelegatedUntil], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10035, 2023110204192566, NULL, NULL, N'Requester Department Head', 1, N'DepartmentManager', NULL, CAST(N'2023-11-02T16:19:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [DelegatedReviewerId], [StageName], [StageNumber], [ReviewerType], [DelegatedUntil], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10036, 2023110204192566, N'50263', NULL, N'Security Head', 2, N'DepartmentManager', NULL, CAST(N'2023-11-02T16:19:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [DelegatedReviewerId], [StageName], [StageNumber], [ReviewerType], [DelegatedUntil], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10037, 2023110204192566, N'51331', NULL, N'IT Head', 3, N'DepartmentManager', NULL, CAST(N'2023-11-02T16:19:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [DelegatedReviewerId], [StageName], [StageNumber], [ReviewerType], [DelegatedUntil], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10038, 2023110204192566, N'51334', NULL, N'IT Admin', 4, N'Basic', NULL, CAST(N'2023-11-02T16:19:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [DelegatedReviewerId], [StageName], [StageNumber], [ReviewerType], [DelegatedUntil], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10039, 2023110204192566, N'51337', NULL, N'IT Admin', 4, N'Basic', NULL, CAST(N'2023-11-02T16:19:00' AS SmallDateTime), NULL, N'E-Document', NULL)
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [DelegatedReviewerId], [StageName], [StageNumber], [ReviewerType], [DelegatedUntil], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (10040, 2023110204192566, N'50271', NULL, N'IT Admin', 4, N'Basic', NULL, CAST(N'2023-11-02T16:19:00' AS SmallDateTime), NULL, N'Khaled Mohamed Ali ElNagdy', NULL)
SET IDENTITY_INSERT [dbo].[DefinedRequestReviewer] OFF
GO
INSERT [dbo].[DefinedRequestRole] ([RoleId], [DefinedRequestId], [Permission], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'7ef3ba68-78e3-457a-9419-aed440b0253b', 2023110110291740, N'All', CAST(N'2023-11-01T22:29:00' AS SmallDateTime), NULL, N'E-Documnet', NULL)
INSERT [dbo].[DefinedRequestRole] ([RoleId], [DefinedRequestId], [Permission], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'7ef3ba68-78e3-457a-9419-aed440b0253b', 2023110204192566, N'Review', CAST(N'2023-11-02T16:19:00' AS SmallDateTime), NULL, N'E-Documnet', NULL)
INSERT [dbo].[DefinedRequestRole] ([RoleId], [DefinedRequestId], [Permission], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'adc08f03-130c-4cf2-9cb2-a923d2ba1597', 2023110204192566, N'Request', CAST(N'2023-11-02T16:19:00' AS SmallDateTime), NULL, N'E-Documnet', NULL)
GO
ALTER TABLE [dbo].[AccessControlRequest]  WITH CHECK ADD  CONSTRAINT [FK_AccessControlRequest_Request] FOREIGN KEY([RequestId])
REFERENCES [dbo].[Request] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AccessControlRequest] CHECK CONSTRAINT [FK_AccessControlRequest_Request]
GO
ALTER TABLE [dbo].[CCTVAccessRequest]  WITH CHECK ADD  CONSTRAINT [FK_CCTVAccessRequest_Request] FOREIGN KEY([RequestId])
REFERENCES [dbo].[Request] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CCTVAccessRequest] CHECK CONSTRAINT [FK_CCTVAccessRequest_Request]
GO

/****** Object:  Trigger [dbo].[TR_AuditAccessControlRequest]    Script Date: 11/6/2023 10:31:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create TRIGGER [dbo].[TR_AuditAccessControlRequest]
ON [dbo].[AccessControlRequest]
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
        INSERT INTO audit.AuditAccessControlRequest (AccessedBlocks, EmployeeSignaturePath, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryPhoneNumber, BeneficiaryExtention, RequestId, AccessMethods)
        SELECT
            AccessedBlocks,
            EmployeeSignaturePath,
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
            BeneficiaryExtention,
            RequestId,
            AccessMethods
        FROM DELETED;

        -- Insert the new record with status 'New'
        INSERT INTO audit.AuditAccessControlRequest (AccessedBlocks, EmployeeSignaturePath, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryPhoneNumber, BeneficiaryExtention, RequestId, AccessMethods)
        SELECT
            AccessedBlocks,
            EmployeeSignaturePath,
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
            BeneficiaryExtention,
            RequestId,
            AccessMethods
        FROM INSERTED;
    END
    ELSE 
    BEGIN
        -- This is a DELETE operation
        SET @TransactionType = 'DELETE';

        -- Insert the old record with status 'Old'
        INSERT INTO audit.AuditAccessControlRequest (AccessedBlocks, EmployeeSignaturePath, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryPhoneNumber, BeneficiaryExtention, RequestId, AccessMethods)
        SELECT
            AccessedBlocks,
            EmployeeSignaturePath,
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
            BeneficiaryExtention,
            RequestId,
            AccessMethods
        FROM DELETED;
    END
END;
GO
ALTER TABLE [dbo].[AccessControlRequest] ENABLE TRIGGER [TR_AuditAccessControlRequest]
GO
/****** Object:  Trigger [dbo].[TR_AuditCCTVAccessRequest]    Script Date: 11/6/2023 10:31:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TR_AuditCCTVAccessRequest]
ON [dbo].[CCTVAccessRequest]
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
        INSERT INTO audit.AuditCCTVAccessRequest (RequestedRoles, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryPhoneNumber, BeneficiaryExtention, RequestId)
        SELECT
            RequestedRoles,
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
            BeneficiaryExtention,
            RequestId
        FROM DELETED;

        -- Insert the new record with status 'New'
        INSERT INTO audit.AuditCCTVAccessRequest (RequestedRoles, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryPhoneNumber, BeneficiaryExtention, RequestId)
        SELECT
            RequestedRoles,
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
            BeneficiaryExtention,
            RequestId
        FROM INSERTED;
    END
    ELSE 
    BEGIN
        -- This is a DELETE operation
        SET @TransactionType = 'DELETE';

        -- Insert the old record with status 'Old'
        INSERT INTO audit.AuditCCTVAccessRequest (RequestedRoles, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryPhoneNumber, BeneficiaryExtention, RequestId)
        SELECT
            RequestedRoles,
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
            BeneficiaryExtention,
            RequestId
        FROM DELETED;
    END
END;
GO
ALTER TABLE [dbo].[CCTVAccessRequest] ENABLE TRIGGER [TR_AuditCCTVAccessRequest]
GO
