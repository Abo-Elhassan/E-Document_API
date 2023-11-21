USE [E-Document]
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

INSERT [dbo].[DefinedRequest] ([Id], [RequestName], [RouteName], [ReviewersNumber], [DepartmentId], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (2023101010522512, N'Refund', N'/CustomerService/Refund/', 5, 7, CAST(N'2023-10-09T09:20:00' AS SmallDateTime), NULL, N'E-Documnet', NULL)

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
INSERT [dbo].[DefinedRequestReviewer] ([Key], [DefinedRequestId], [AssignedReviewerId], [StageName], [StageNumber], [ReviewerType], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (25, 2023101010522512, NULL, N'Customer Service Team', 5, N'Basic', CAST(N'2023-10-09T11:39:00' AS SmallDateTime), NULL, N'E-Document', NULL)
SET IDENTITY_INSERT [dbo].[DefinedRequestReviewer] OFF
GO
INSERT [dbo].[DefinedRequestRole] ([RoleId], [DefinedRequestId], [Permission], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'7ef3ba68-78e3-457a-9419-aed440b0253b', 2023101010522512, N'Review', CAST(N'2023-10-09T10:30:00' AS SmallDateTime), NULL, N'E-Documnet', NULL)
INSERT [dbo].[DefinedRequestRole] ([RoleId], [DefinedRequestId], [Permission], [CreatedAt], [ModifiedAt], [CreatedBy], [ModifiedBy]) VALUES (N'c1566c45-954c-42b1-962c-d73fe026c7e2', 2023101010522512, N'Request', CAST(N'2023-10-09T10:30:00' AS SmallDateTime), NULL, N'E-Documnet', NULL)
GO
ALTER TABLE [dbo].[RefundRequest]  WITH CHECK ADD  CONSTRAINT [FK_RefundRequest_Request] FOREIGN KEY([RequestId])
REFERENCES [dbo].[Request] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RefundRequest] CHECK CONSTRAINT [FK_RefundRequest_Request]
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