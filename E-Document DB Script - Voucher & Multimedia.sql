USE [E-Document]
GO

/************** Update Finance Icon **************/
UPDATE [dbo].[Department] SET DepartmentIcon ='Finance.svg' WHERE Id=9;

/****** Object:  Table [audit].[AuditMultimediaRequest]    Script Date: 11/29/2023 3:00:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [audit].[AuditMultimediaRequest](
	[AuditId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[RequestType] [nvarchar](max) NULL,
	[ProjectDetails] [nvarchar](max) NULL,
	[DeliveryDate] [datetime2](7) NOT NULL,
	[VideoDuration] [time](7) NULL,
	[AnnouncementType] [nvarchar](max) NULL,
	[EstimatedDeliveryDate] [datetime2](7) NULL,
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
	[PrTeamAttachmentPath] [nvarchar](max) NULL,
 CONSTRAINT [PK_AuditMultimediaRequest] PRIMARY KEY CLUSTERED 
(
	[AuditId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [audit].[AuditVoucherRequest]    Script Date: 11/29/2023 3:00:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [audit].[AuditVoucherRequest](
	[AuditId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[VendorNumber] [int] NOT NULL,
	[VendorName] [nvarchar](max) NULL,
	[InvoiceNumber] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Amount] [real] NOT NULL,
	[AmountInWords] [nvarchar](max) NULL,
	[Currency] [nvarchar](max) NULL,
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
 CONSTRAINT [PK_AuditVoucherRequest] PRIMARY KEY CLUSTERED 
(
	[AuditId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/****** Object:  Table [dbo].[MultimediaRequest]    Script Date: 11/29/2023 3:00:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MultimediaRequest](
	[RequestNumber] [nvarchar](50) NOT NULL,
	[RequestType] [nvarchar](50) NOT NULL,
	[ProjectDetails] [nvarchar](1000) NOT NULL,
	[DeliveryDate] [smalldatetime] NOT NULL,
	[VideoDuration] [time](7) NULL,
	[AnnouncementType] [nvarchar](50) NULL,
	[EstimatedDeliveryDate] [smalldatetime] NULL,
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
	[PrTeamAttachmentPath] [nvarchar](max) NULL,
 CONSTRAINT [PK_MultimediaRequest] PRIMARY KEY CLUSTERED 
(
	[RequestNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VoucherRequest]    Script Date: 11/29/2023 3:00:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VoucherRequest](
	[RequestNumber] [nvarchar](50) NOT NULL,
	[VendorNumber] [int] NOT NULL,
	[VendorName] [nvarchar](200) NULL,
	[InvoiceNumber] [nvarchar](50) NULL,
	[Description] [nvarchar](max) NULL,
	[Amount] [real] NOT NULL,
	[AmountInWords] [nvarchar](500) NULL,
	[Currency] [nvarchar](50) NULL,
	[CreatedAt] [smalldatetime] NULL,
	[ModifiedAt] [smalldatetime] NULL,
	[CreatedBy] [nvarchar](200) NULL,
	[ModifiedBy] [nvarchar](200) NULL,
	[BeneficiaryId] [nvarchar](50) NOT NULL,
	[BeneficiaryName] [nvarchar](200) NOT NULL,
	[BeneficiaryEmail] [nvarchar](50) NULL,
	[BeneficiaryPosition] [nvarchar](200) NULL,
	[BeneficiaryDepartment] [nvarchar](200) NULL,
	[BeneficiaryCompany] [nvarchar](200) NULL,
	[BeneficiaryPhoneNumber] [nvarchar](50) NULL,
	[BeneficiaryExtention] [int] NULL,
	[RequestId] [bigint] NOT NULL,
 CONSTRAINT [PK_VoucherRequest] PRIMARY KEY CLUSTERED 
(
	[RequestNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[DefinedRequest] ([Id], [RequestName], [RouteName], [ReviewersNumber], [DepartmentId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023112709173645, N'Multimedia', N'/PublicRelations/Multimedia/', 3, 6, CAST(N'2023-11-27T09:18:00' AS SmallDateTime), NULL, N'E-Document', NULL)
GO
INSERT [dbo].[DefinedRequest] ([Id], [RequestName], [RouteName], [ReviewersNumber], [DepartmentId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023112802152106, N'Voucher', N'/Finance/Voucher/', 3, 9, CAST(N'2023-11-28T14:15:00' AS SmallDateTime), NULL, N'E-Document', NULL)
GO
SET IDENTITY_INSERT [dbo].[DefinedRequestReviewer] ON 
GO

INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (40191, 2023112709173645, NULL, N'Requester Department Head', 1, N'DepartmentManager', CAST(N'2023-11-27T09:18:00' AS SmallDateTime), NULL, N'E-Document', NULL)
GO
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (40192, 2023112709173645, N'51688', N'Public Relations Head', 2, N'DepartmentManager', CAST(N'2023-11-27T09:18:00' AS SmallDateTime), NULL, N'E-Document', NULL)
GO
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (40193, 2023112709173645, N'51414', N'Public Relations Specialist', 3, N'Basic', CAST(N'2023-11-27T09:18:00' AS SmallDateTime), NULL, N'E-Document', NULL)
GO

INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (40211, 2023112802152106, NULL, N'Requester Direct Manager', 1, N'DirectManager', CAST(N'2023-11-28T14:15:00' AS SmallDateTime), NULL, N'E-Document', NULL)
GO
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (40212, 2023112802152106, NULL, N'Requeter Department Head', 2, N'DepartmentManager', CAST(N'2023-11-28T14:15:00' AS SmallDateTime), NULL, N'E-Document', NULL)
GO
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (40213, 2023112802152106, N'51640', N'Finance Team', 3, N'Basic', CAST(N'2023-11-28T14:15:00' AS SmallDateTime), NULL, N'E-Document', NULL)
GO
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (40214, 2023112802152106, N'51682', N'Finance Team', 3, N'Basic', CAST(N'2023-11-28T14:15:00' AS SmallDateTime), NULL, N'E-Document', NULL)
GO
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (40215, 2023112802152106, N'51653', N'Finance Team', 3, N'Basic', CAST(N'2023-11-28T14:15:00' AS SmallDateTime), NULL, N'E-Document', NULL)
GO
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (40216, 2023112802152106, N'51510', N'Finance Team', 3, N'Basic', CAST(N'2023-11-28T14:15:00' AS SmallDateTime), NULL, N'E-Document', NULL)
GO
SET IDENTITY_INSERT [dbo].[DefinedRequestReviewer] OFF
GO

GO
INSERT [dbo].[DefinedRequestRole] ([RoleId], [DefinedRequestId], [Permission], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'7ef3ba68-78e3-457a-9419-aed440b0253b', 2023112709173645, N'All', CAST(N'2023-11-27T09:18:00' AS SmallDateTime), NULL, N'E-Document', NULL)
GO
INSERT [dbo].[DefinedRequestRole] ([RoleId], [DefinedRequestId], [Permission], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'7ef3ba68-78e3-457a-9419-aed440b0253b', 2023112802152106, N'All', CAST(N'2023-11-28T14:15:00' AS SmallDateTime), NULL, N'E-Document', NULL)
GO

ALTER TABLE [dbo].[MultimediaRequest]  WITH CHECK ADD  CONSTRAINT [FK_MultimediaRequest_Request] FOREIGN KEY([RequestId])
REFERENCES [dbo].[Request] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MultimediaRequest] CHECK CONSTRAINT [FK_MultimediaRequest_Request]
GO
ALTER TABLE [dbo].[VoucherRequest]  WITH CHECK ADD  CONSTRAINT [FK_VoucherRequest_Request] FOREIGN KEY([RequestId])
REFERENCES [dbo].[Request] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[VoucherRequest] CHECK CONSTRAINT [FK_VoucherRequest_Request]
GO
/****** Object:  Trigger [dbo].[TR_AuditMultimediaRequest]    Script Date: 11/29/2023 3:00:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TR_AuditMultimediaRequest]
ON [dbo].[MultimediaRequest]
AFTER UPDATE, DELETE
AS
BEGIN
    DECLARE @TransactionType NVARCHAR(max);

    -- Determine the operation type
    IF EXISTS (SELECT * FROM INSERTED)
    BEGIN
        SET @TransactionType = 'UPDATE';

        -- Insert the old record with status 'Old'
        INSERT INTO audit.AuditMultimediaRequest (RequestType, ProjectDetails, DeliveryDate, VideoDuration, AnnouncementType, EstimatedDeliveryDate, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryCompany, BeneficiaryPhoneNumber, BeneficiaryExtention, RequestId, PrTeamAttachmentPath)
        SELECT
            RequestType,
            ProjectDetails,
            DeliveryDate,
            VideoDuration,
            AnnouncementType,
            EstimatedDeliveryDate,
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
            BeneficiaryCompany,
            BeneficiaryPhoneNumber,
            BeneficiaryExtention,
            RequestId,
            PrTeamAttachmentPath
        FROM DELETED;

        -- Insert the new record with status 'New'
        INSERT INTO audit.AuditMultimediaRequest (RequestType, ProjectDetails, DeliveryDate, VideoDuration, AnnouncementType, EstimatedDeliveryDate, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryCompany, BeneficiaryPhoneNumber, BeneficiaryExtention, RequestId, PrTeamAttachmentPath)
        SELECT
            RequestType,
            ProjectDetails,
            DeliveryDate,
            VideoDuration,
            AnnouncementType,
            EstimatedDeliveryDate,
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
            BeneficiaryCompany,
            BeneficiaryPhoneNumber,
            BeneficiaryExtention,
            RequestId,
            PrTeamAttachmentPath
        FROM INSERTED;
    END
    ELSE 
    BEGIN
        -- This is a DELETE operation
        SET @TransactionType = 'DELETE';

        -- Insert the old record with status 'Old'
        INSERT INTO audit.AuditMultimediaRequest (RequestType, ProjectDetails, DeliveryDate, VideoDuration, AnnouncementType, EstimatedDeliveryDate, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryCompany, BeneficiaryPhoneNumber, BeneficiaryExtention, RequestId, PrTeamAttachmentPath)
        SELECT
            RequestType,
            ProjectDetails,
            DeliveryDate,
            VideoDuration,
            AnnouncementType,
            EstimatedDeliveryDate,
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
            BeneficiaryCompany,
            BeneficiaryPhoneNumber,
            BeneficiaryExtention,
            RequestId,
            PrTeamAttachmentPath
        FROM DELETED;
    END
END;
GO
ALTER TABLE [dbo].[MultimediaRequest] ENABLE TRIGGER [TR_AuditMultimediaRequest]
GO
/****** Object:  Trigger [dbo].[TR_AuditVoucherRequest]    Script Date: 11/29/2023 3:00:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TR_AuditVoucherRequest]
ON [dbo].[VoucherRequest]
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
        INSERT INTO audit.AuditVoucherRequest (VendorNumber, VendorName, InvoiceNumber, Description, Amount, AmountInWords, Currency, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryCompany, BeneficiaryPhoneNumber, BeneficiaryExtention, RequestId)
        SELECT
            VendorNumber,
            VendorName,
            InvoiceNumber,
            Description,
            Amount,
            AmountInWords,
            Currency,
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
        INSERT INTO audit.AuditVoucherRequest (VendorNumber, VendorName, InvoiceNumber, Description, Amount, AmountInWords, Currency, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryCompany, BeneficiaryPhoneNumber, BeneficiaryExtention, RequestId)
        SELECT
            VendorNumber,
            VendorName,
            InvoiceNumber,
            Description,
            Amount,
            AmountInWords,
            Currency,
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
        INSERT INTO audit.AuditVoucherRequest (VendorNumber, VendorName, InvoiceNumber, Description, Amount, AmountInWords, Currency, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryCompany, BeneficiaryPhoneNumber, BeneficiaryExtention, RequestId)
        SELECT
            VendorNumber,
            VendorName,
            InvoiceNumber,
            Description,
            Amount,
            AmountInWords,
            Currency,
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
ALTER TABLE [dbo].[VoucherRequest] ENABLE TRIGGER [TR_AuditVoucherRequest]
GO


