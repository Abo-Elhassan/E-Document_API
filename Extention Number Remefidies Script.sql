USE [E-Document]
GO
ALTER TABLE VehicleRequest
ALTER COLUMN BeneficiaryExtention INT NULL;
ALTER TABLE VehicleRequest
ADD BeneficiaryCompany NVARCHAR(200) NULL;
GO
ALTER TABLE audit.AuditVehicleRequest
ALTER COLUMN BeneficiaryExtention INT NULL;
ALTER TABLE audit.AuditVehicleRequest
ADD BeneficiaryCompany NVARCHAR(200) NULL;
GO
------------------------------------------------

ALTER TABLE TravelDeskRequest
ALTER COLUMN BeneficiaryExtention INT NULL;
ALTER TABLE TravelDeskRequest
ADD BeneficiaryCompany NVARCHAR(200) NULL;
GO
ALTER TABLE audit.AuditTravelDeskRequest
ALTER COLUMN BeneficiaryExtention INT NULL;
ALTER TABLE audit.AuditTravelDeskRequest
ADD BeneficiaryCompany NVARCHAR(200) NULL;
GO
----------------------------------------------

ALTER TABLE DomainAccountRequest
ALTER COLUMN BeneficiaryExtention INT NULL;
ALTER TABLE DomainAccountRequest
ADD BeneficiaryCompany NVARCHAR(200) NULL;
GO
ALTER TABLE audit.AuditDomainAccountRequest
ALTER COLUMN BeneficiaryExtention INT NULL;
ALTER TABLE audit.AuditDomainAccountRequest
ADD BeneficiaryCompany NVARCHAR(200) NULL;
GO

-----------------------------------------------------
GO
ALTER TABLE ApplicationUserRequest
ALTER COLUMN BeneficiaryExtention INT NULL;
ALTER TABLE ApplicationUserRequest
ADD BeneficiaryCompany NVARCHAR(200) NULL;
GO
ALTER TABLE audit.AuditApplicationUserRequest
ALTER COLUMN BeneficiaryExtention INT NULL;
ALTER TABLE audit.AuditApplicationUserRequest
ADD BeneficiaryCompany NVARCHAR(200) NULL;
GO

-------------------------------------------------------

/****** Object:  Trigger [dbo].[TR_AuditVehicleRequest]    Script Date: 11/6/2023 3:08:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Create a trigger for the VehicleRequest table
ALTER TRIGGER [dbo].[TR_AuditVehicleRequest]
ON [dbo].[VehicleRequest]
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
        INSERT INTO Audit.AuditVehicleRequest (DepartureAddress, DestinationAddress, DepartureDate, ReturnDate, LuggageDescription, VehicleType, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryPhoneNumber, BeneficiaryExtention,BeneficiaryCompany, RequestId)
        SELECT
            DepartureAddress,
            DestinationAddress,
            DepartureDate,
            ReturnDate,
            LuggageDescription,
            VehicleType,
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
        INSERT INTO Audit.AuditVehicleRequest (DepartureAddress, DestinationAddress, DepartureDate, ReturnDate, LuggageDescription, VehicleType, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryPhoneNumber, BeneficiaryExtention,BeneficiaryCompany, RequestId)
        SELECT
            DepartureAddress,
            DestinationAddress,
            DepartureDate,
            ReturnDate,
            LuggageDescription,
            VehicleType,
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
        INSERT INTO Audit.AuditVehicleRequest (DepartureAddress, DestinationAddress, DepartureDate, ReturnDate, LuggageDescription, VehicleType, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryPhoneNumber, BeneficiaryExtention,BeneficiaryCompany, RequestId)
        SELECT
            DepartureAddress,
            DestinationAddress,
            DepartureDate,
            ReturnDate,
            LuggageDescription,
            VehicleType,
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
/****** Object:  Trigger [dbo].[TR_AuditTravelDeskRequest]    Script Date: 11/6/2023 3:09:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Create a trigger for the TravelDeskRequest table
ALTER TRIGGER [dbo].[TR_AuditTravelDeskRequest]
ON [dbo].[TravelDeskRequest]
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
        INSERT INTO Audit.AuditTravelDeskRequest (RequestType, BeneficiaryNationality, CostAllocation, CheckIn, CheckOut, MissionAddress, PaymentMethod, FlightOrigin, FlightDestination, DepartureDate, ReturnDate, DestinationCountry, ExpectedTravelTime, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryPhoneNumber, BeneficiaryExtention,BeneficiaryCompany, RequestId)
        SELECT
            RequestType,
            BeneficiaryNationality,
            CostAllocation,
            CheckIn,
            CheckOut,
            MissionAddress,
            PaymentMethod,
            FlightOrigin,
            FlightDestination,
            DepartureDate,
            ReturnDate,
            DestinationCountry,
            ExpectedTravelTime,
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
        INSERT INTO Audit.AuditTravelDeskRequest (RequestType, BeneficiaryNationality, CostAllocation, CheckIn, CheckOut, MissionAddress, PaymentMethod, FlightOrigin, FlightDestination, DepartureDate, ReturnDate, DestinationCountry, ExpectedTravelTime, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryPhoneNumber, BeneficiaryExtention,BeneficiaryCompany, RequestId)
        SELECT
            RequestType,
            BeneficiaryNationality,
            CostAllocation,
            CheckIn,
            CheckOut,
            MissionAddress,
            PaymentMethod,
            FlightOrigin,
            FlightDestination,
            DepartureDate,
            ReturnDate,
            DestinationCountry,
            ExpectedTravelTime,
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
        INSERT INTO Audit.AuditTravelDeskRequest (RequestType, BeneficiaryNationality, CostAllocation, CheckIn, CheckOut, MissionAddress, PaymentMethod, FlightOrigin, FlightDestination, DepartureDate, ReturnDate, DestinationCountry, ExpectedTravelTime, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryPhoneNumber, BeneficiaryExtention,BeneficiaryCompany, RequestId)
        SELECT
            RequestType,
            BeneficiaryNationality,
            CostAllocation,
            CheckIn,
            CheckOut,
            MissionAddress,
            PaymentMethod,
            FlightOrigin,
            FlightDestination,
            DepartureDate,
            ReturnDate,
            DestinationCountry,
            ExpectedTravelTime,
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
/****** Object:  Trigger [dbo].[TR_AuditDomainAccountRequest]    Script Date: 11/6/2023 3:14:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Create a trigger for the DomainAccountRequest table
ALTER TRIGGER [dbo].[TR_AuditDomainAccountRequest]
ON [dbo].[DomainAccountRequest]
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
        INSERT INTO [audit].[AuditDomainAccountRequest] (DisplayName, LoginName, OU, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryPhoneNumber, BeneficiaryExtention,BeneficiaryCompany, RequestId)
        SELECT
            DisplayName,
            LoginName,
            OU,
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
        INSERT INTO [audit].[AuditDomainAccountRequest] (DisplayName, LoginName, OU, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryPhoneNumber, BeneficiaryExtention,BeneficiaryCompany, RequestId)
        SELECT
            DisplayName,
            LoginName,
            OU,
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
        INSERT INTO [audit].[AuditDomainAccountRequest] (DisplayName, LoginName, OU, CreatedAt, ModifiedAt, CreatedBy, ModifiedBy, TransactionType, DataStatus, TimeStamp, RequestNumber, BeneficiaryId, BeneficiaryName, BeneficiaryEmail, BeneficiaryPosition, BeneficiaryDepartment, BeneficiaryPhoneNumber, BeneficiaryExtention,BeneficiaryCompany, RequestId)
        SELECT
            DisplayName,
            LoginName,
            OU,
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