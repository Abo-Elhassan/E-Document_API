--DROP PROCEDURE sp_seed_request_Roles 

CREATE OR ALTER PROCEDURE sp_seed_discount_request_Roles 
As
Begin

    -- Declare variables to store user ID, roles, department ID, and other necessary information
    DECLARE @UserId NVARCHAR(50)
    DECLARE @Roles NVARCHAR(MAX)
    DECLARE @DepartmentId INT
	DECLARE @RequestDiscountRole NVARCHAR(450) = '181b8d04-bd8c-4f88-b121-7c7623ee2c7e'
	DECLARE @ReviewDiscountRole NVARCHAR(450) = 'a86e86a2-746c-4f4f-b25f-d2abfb42dc0d'
	DECLARE @AllDiscountRole NVARCHAR(450) = '077ca99e-e9ca-4486-9e22-c5e842fe6c06'


	-- Cursor to loop through users in the User table where DepartmentId = 4

	DECLARE user_cursor CURSOR FOR
		SELECT Id, DepartmentId, Roles
		FROM [security].[User]
		WHERE 
		Company='DP World'AND
		(
		DepartmentId IN 
		(
		4, --Commercial
		7) --Customer Service
		OR 
		Id IN 
		(
		'EXP-16', --Urs
		'51124', --mustafa Sultan

		'50150', -- Finance Front Office Team
		'50628',-- Finance Front Office Team
		'50730',-- Finance Front Office Team
		'51056',-- Finance Front Office Team
		'51089',-- Finance Front Office Team
		'51182',-- Finance Front Office Team
		'51216')-- Finance Front Office Team
		)
		
		-- Open the cursor
		OPEN user_cursor
		
		-- Fetch the first row
		FETCH NEXT FROM user_cursor INTO @UserId, @DepartmentId, @Roles

		WHILE @@FETCH_STATUS = 0
		BEGIN 

			IF @DepartmentId = 4
			BEGIN
						
				INSERT INTO [security].[UserRoles] (UserId, RoleId)
				VALUES (@UserId, @AllDiscountRole)
				
				UPDATE [security].[User]
				SET 
				Roles = ISNULL(Roles, '') + ',Discount_All' ,
				ModifiedAt=GETDATE(),
				ModifiedBy='E-Document'
				WHERE Id = @UserId

			END
			ELSE IF @DepartmentId = 7
			BEGIN

				INSERT INTO [security].[UserRoles] (UserId, RoleId)
				VALUES (@UserId, @RequestDiscountRole)
				
				UPDATE [security].[User]
				SET 
				Roles = ISNULL(Roles, '') + ',Discount_Request',
				ModifiedAt=GETDATE(),
				ModifiedBy='E-Document'
				WHERE Id = @UserId

			END
			ELSE 
			BEGIN

				INSERT INTO [security].[UserRoles] (UserId, RoleId)
				VALUES (@UserId, @ReviewDiscountRole)
				
				UPDATE [security].[User]
				SET 
				Roles = ISNULL(Roles, '') + ',Discount_Review',
				ModifiedAt=GETDATE(),
				ModifiedBy='E-Document'
				WHERE Id = @UserId

			END


		-- Fetch the next row
        FETCH NEXT FROM user_cursor INTO @UserId, @DepartmentId, @Roles
		END


    -- Close and deallocate the cursor
    CLOSE user_cursor
    DEALLOCATE user_cursor
End;