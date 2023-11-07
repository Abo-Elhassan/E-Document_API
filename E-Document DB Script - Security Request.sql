USE [E-Document]
GO
update [security].[User] set roles= 'Basic' where id in (
'50239',
'50279',
'51092',
'51371',
'51399',
'51400',
'51490',
'51619',
'51680',
'80099');
GO
Delete [security].[UserRoles] where UserId in (
'50239',
'50279',
'51092',
'51371',
'51399',
'51400',
'51490',
'51619',
'51680',
'80099') and  RoleId ='adc08f03-130c-4cf2-9cb2-a923d2ba1597';
Go
/****** Object:  Table [audit].[AuditAccessControlRequest]    Script Date: 11/6/2023 3:37:20 PM ******/
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
	[BeneficiaryExtention] [int] NULL,
	[RequestId] [bigint] NOT NULL,
	[BeneficiaryCompany] [nvarchar](max) NULL,
 CONSTRAINT [PK_AuditAccessControlRequest] PRIMARY KEY CLUSTERED 
(
	[AuditId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [audit].[AuditCCTVAccessRequest]    Script Date: 11/6/2023 3:37:21 PM ******/
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
	[BeneficiaryExtention] [int] NULL,
	[RequestId] [bigint] NOT NULL,
	[BeneficiaryCompany] [nvarchar](max) NULL,
 CONSTRAINT [PK_AuditCCTVAccessRequest] PRIMARY KEY CLUSTERED 
(
	[AuditId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AccessControlRequest]    Script Date: 11/6/2023 3:37:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccessControlRequest](
	[RequestNumber] [nvarchar](50) NOT NULL,
	[AccessedBlocks] [nvarchar](max) NULL,
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
	[BeneficiaryExtention] [int] NULL,
	[RequestId] [bigint] NOT NULL,
	[AccessMethods] [nvarchar](200) NULL,
 CONSTRAINT [PK_AccessControlRequest] PRIMARY KEY CLUSTERED 
(
	[RequestNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CCTVAccessRequest]    Script Date: 11/6/2023 3:37:21 PM ******/
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
	[BeneficiaryExtention] [int] NULL,
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
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231106123452_makeExtentionNumberNullableInt', N'7.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231106170120_makeAccessBlocksMaxVarChar', N'7.0.10')
GO
INSERT [dbo].[DefinedRequest] ([Id], [RequestName], [RouteName], [ReviewersNumber], [DepartmentId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023110110291740, N'CCTV Access', N'/Security/CCTVAccess/', 5, 19, CAST(N'2023-11-01T22:29:00' AS SmallDateTime), NULL, N'E-Document', NULL)
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
/****** Object:  Trigger [dbo].[TR_AuditAccessControlRequest]    Script Date: 11/6/2023 3:37:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TR_AuditAccessControlRequest]
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
        INSERT INTO audit.AuditAccessControlRequest (AccessedBlocks, EmployeeSignaturePath, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryPhoneNumber, BeneficiaryExtention, BeneficiaryCompany, RequestId, AccessMethods)
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
			BeneficiaryCompany,
            RequestId,
            AccessMethods
        FROM DELETED;

        -- Insert the new record with status 'New'
        INSERT INTO audit.AuditAccessControlRequest (AccessedBlocks, EmployeeSignaturePath, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryPhoneNumber, BeneficiaryExtention,BeneficiaryCompany, RequestId, AccessMethods)
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
			BeneficiaryCompany,
            RequestId,
            AccessMethods
        FROM INSERTED;
    END
    ELSE 
    BEGIN
        -- This is a DELETE operation
        SET @TransactionType = 'DELETE';

        -- Insert the old record with status 'Old'
        INSERT INTO audit.AuditAccessControlRequest (AccessedBlocks, EmployeeSignaturePath, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryPhoneNumber, BeneficiaryExtention,BeneficiaryCompany, RequestId, AccessMethods)
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
			BeneficiaryCompany,
            RequestId,
            AccessMethods
        FROM DELETED;
    END
END;
GO
ALTER TABLE [dbo].[AccessControlRequest] ENABLE TRIGGER [TR_AuditAccessControlRequest]
GO
/****** Object:  Trigger [dbo].[TR_AuditCCTVAccessRequest]    Script Date: 11/6/2023 3:37:21 PM ******/
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
        INSERT INTO audit.AuditCCTVAccessRequest (RequestedRoles, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryPhoneNumber, BeneficiaryExtention,BeneficiaryCompany, RequestId)
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
			BeneficiaryCompany,
            RequestId
        FROM DELETED;

        -- Insert the new record with status 'New'
        INSERT INTO audit.AuditCCTVAccessRequest (RequestedRoles, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryPhoneNumber, BeneficiaryExtention,BeneficiaryCompany, RequestId)
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
			BeneficiaryCompany,
            RequestId
        FROM INSERTED;
    END
    ELSE 
    BEGIN
        -- This is a DELETE operation
        SET @TransactionType = 'DELETE';

        -- Insert the old record with status 'Old'
        INSERT INTO audit.AuditCCTVAccessRequest (RequestedRoles, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryPhoneNumber, BeneficiaryExtention,BeneficiaryCompany, RequestId)
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
			BeneficiaryCompany,
            RequestId
        FROM DELETED;
    END
END;
GO
ALTER TABLE [dbo].[CCTVAccessRequest] ENABLE TRIGGER [TR_AuditCCTVAccessRequest]
GO

