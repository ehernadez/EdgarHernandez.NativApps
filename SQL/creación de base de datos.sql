CREATE DATABASE NativApps;
GO

USE NativApps;
GO

-- Tabla Users
CREATE TABLE Users (
    Id INT PRIMARY KEY IDENTITY(1,1),
    UserName NVARCHAR(50) NOT NULL,
    Password NVARCHAR(100) NOT NULL,
    Role NVARCHAR(50) NOT NULL
);
GO

-- Tabla Products
CREATE TABLE Products (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Detail NVARCHAR(MAX),
    Category NVARCHAR(100),
    Price INT NOT NULL,
    InitialQuantity INT NOT NULL,
    AvailableQuantity INT,
    CreatedBy INT NOT NULL,
    CreatedOn DATETIME NOT NULL,
    ModifiedBy INT,
    ModifiedOn DATETIME
);
GO

-- Insertar usuario
INSERT INTO Users (UserName, Password, Role)
VALUES ('nativapps', 'test1', 'Admin'),
		('client', 'test1', 'Client');
GO

-- Insertar 30 registros de productos aleatorios
DECLARE @counter INT = 1;
WHILE @counter <= 30
BEGIN
    INSERT INTO Products (Name, Detail, Category, Price, InitialQuantity, AvailableQuantity, CreatedBy, CreatedOn)
    VALUES (
        'Product' + CONVERT(NVARCHAR(10), @counter),
        'Detail for Product' + CONVERT(NVARCHAR(10), @counter),
        'Category' + CONVERT(NVARCHAR(10), ABS(CHECKSUM(NEWID())) % 5 + 1),
        ABS(CHECKSUM(NEWID())) % 500 + 50,
        ABS(CHECKSUM(NEWID())) % 100 + 1,
        ABS(CHECKSUM(NEWID())) % 100,
        1,
        GETDATE()
    );
    SET @counter = @counter + 1;
END;
