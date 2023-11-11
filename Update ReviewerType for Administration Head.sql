USE [E-Document]
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
update DefinedRequestReviewer set ReviewerType = 'DepartmentManager' where AssignedReviewerId = '50269'