DECLARE @passwordHash nvarchar(256)
SET @passwordHash = HASHBYTES('SHA2_256', '123')



INSERT INTO TaiKhoan 
VALUES ('admin', @passwordHash, 1, 1);