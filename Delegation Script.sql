USE [E-Document]
GO

---------------------------------------------------------------------------------------------------------------------

ALTER TABLE DefinedRequestReviewer
DROP COLUMN DelegatedReviewerId,
DROP COLUMN DelegatedUntil;

GO
ALTER TABLE [audit].[AuditDefinedRequestReviewer]
DROP COLUMN DelegatedReviewerId,
DROP COLUMN DelegatedUntil;
GO
----------------------------------------------------------------------------------------------------------------------
ALTER TABLE [security].[User]
ADD DelegatedUntil smalldatetime NULL,
ADD DelegatedUserId nvarchar(50) NULL;

GO
ALTER TABLE [audit].[AuditUser]
ADD DelegatedUntil datetime2 NULL,
ADD DelegatedUserId nvarchar(max) NULL;
GO
------------------------------------------------------------------------------------------------------------------------
/****** Object:  Trigger [dbo].[TR_AuditDefinedRequestReviewer]    Script Date: 11/11/2023 1:03:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Create a trigger for the DefinedRequestReviewer table
ALTER TRIGGER [dbo].[TR_AuditDefinedRequestReviewer]
ON [dbo].[DefinedRequestReviewer]
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
        INSERT INTO Audit.AuditDefinedRequestReviewer ([Key],DefinedRequestId, AssignedReviewerId, StageName, StageNumber, ReviewerType,  CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp)
        SELECT
			[Key],
            DefinedRequestId,
            AssignedReviewerId,
           
            StageName,
            StageNumber,
            ReviewerType,
            
            CreatedAt,
            ModifiedAt,
            CreatedBy,
            ModifiedBy,
            @TransactionType,
            'Old' AS DataStatus,
            GETDATE() AS TimeStamp
        FROM DELETED;

        -- Insert the new record with status 'New'
        INSERT INTO Audit.AuditDefinedRequestReviewer ([Key],DefinedRequestId, AssignedReviewerId, StageName, StageNumber, ReviewerType,  CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp)
        SELECT
			[Key],
            DefinedRequestId,
            AssignedReviewerId,
           
            StageName,
            StageNumber,
            ReviewerType,
            
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
        INSERT INTO Audit.AuditDefinedRequestReviewer ([Key],DefinedRequestId, AssignedReviewerId, StageName, StageNumber, ReviewerType,  CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp)
        SELECT
			[Key],
            DefinedRequestId,
            AssignedReviewerId,
           
            StageName,
            StageNumber,
            ReviewerType,
            
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
/****** Object:  Trigger [security].[TR_AuditUser]    Script Date: 11/11/2023 1:03:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Create a trigger for the User table
ALTER TRIGGER [security].[TR_AuditUser]
ON [security].[User]
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
        INSERT INTO [Audit].[AuditUser] ( UserName, NormalizedUserName, FullName, Position, DepartmentId, SectionId, ManagerId, Company,Roles ,HasLDAP, DelegatedUserId,DelegatedUntil, LastLogin, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, Id, Email, NormalizedEmail, EmailConfirmed, PasswordHash, SecurityStamp, ConcurrencyStamp, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnd, LockoutEnabled, AccessFailedCount)
        SELECT
			
            UserName,
            NormalizedUserName,
            FullName,
            Position,
            DepartmentId,
            SectionId,
            ManagerId,
            Company,
			Roles,
            HasLDAP,
			DelegatedUserId,
			DelegatedUntil,
            LastLogin,
            CreatedAt,
            ModifiedAt,
            CreatedBy,
            ModifiedBy,
            @TransactionType,
            'Old' AS DataStatus,
            GETDATE() AS TimeStamp,
            Id,
            Email,
            NormalizedEmail,
            EmailConfirmed,
            PasswordHash,
            SecurityStamp,
            ConcurrencyStamp,
            PhoneNumber,
            PhoneNumberConfirmed,
            TwoFactorEnabled,
            LockoutEnd,
            LockoutEnabled,
            AccessFailedCount
        FROM DELETED;

 

        -- Insert the new record with status 'New'
        INSERT INTO [Audit].[AuditUser] ( UserName, NormalizedUserName, FullName, Position, DepartmentId, SectionId, ManagerId, Company, Roles, HasLDAP, DelegatedUserId,DelegatedUntil,LastLogin, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, Id, Email, NormalizedEmail, EmailConfirmed, PasswordHash, SecurityStamp, ConcurrencyStamp, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnd, LockoutEnabled, AccessFailedCount)
        SELECT
			
            UserName,
            NormalizedUserName,
            FullName,
            Position,
            DepartmentId,
            SectionId,
            ManagerId,
            Company,
			Roles,
            HasLDAP,
			DelegatedUserId,
			DelegatedUntil,
            LastLogin,
            CreatedAt,
            ModifiedAt,
            CreatedBy,
            ModifiedBy,
            @TransactionType,
            'New' AS DataStatus,
            GETDATE() AS TimeStamp,
            Id,
            Email,
            NormalizedEmail,
            EmailConfirmed,
            PasswordHash,
            SecurityStamp,
            ConcurrencyStamp,
            PhoneNumber,
            PhoneNumberConfirmed,
            TwoFactorEnabled,
            LockoutEnd,
            LockoutEnabled,
            AccessFailedCount
        FROM INSERTED;
    END
    ELSE 
    BEGIN
        -- This is a DELETE operation
        SET @TransactionType = 'DELETE';

 

        -- Insert the old record with status 'Old'
        INSERT INTO [Audit].[AuditUser] ( UserName, NormalizedUserName, FullName, Position, DepartmentId, SectionId, ManagerId, Company, Roles, HasLDAP, DelegatedUserId,DelegatedUntil, LastLogin, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, Id, Email, NormalizedEmail, EmailConfirmed, PasswordHash, SecurityStamp, ConcurrencyStamp, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnd, LockoutEnabled, AccessFailedCount)
        SELECT
			
            UserName,
            NormalizedUserName,
            FullName,
            Position,
            DepartmentId,
            SectionId,
            ManagerId,
            Company,
			Roles,
            HasLDAP,
            LastLogin,
			DelegatedUserId,
			DelegatedUntil,
            CreatedAt,
            ModifiedAt,
            CreatedBy,
            ModifiedBy,
            @TransactionType,
            'Old' AS DataStatus,
            GETDATE() AS TimeStamp,
            Id,
            Email,
            NormalizedEmail,
            EmailConfirmed,
            PasswordHash,
            SecurityStamp,
            ConcurrencyStamp,
            PhoneNumber,
            PhoneNumberConfirmed,
            TwoFactorEnabled,
            LockoutEnd,
            LockoutEnabled,
            AccessFailedCount
        FROM DELETED;
    END
END;
GO