USE master;
GO

IF EXISTS(SELECT * from sys.databases WHERE name='COMS')
BEGIN
	DROP DATABASE COMS;
END

CREATE DATABASE COMS;

USE COMS

GO

CREATE TABLE dbo.Customers(
	ID int PRIMARY KEY NOT NULL,
	Surname varchar(40) NOT NULL,
	Forename varchar(40) NOT NULL,
	Username varchar(100) NOT NULL
	)
GO

BULK INSERT dbo.Customers
	FROM 'C:\Users\Matt\Documents\Visual Studio 2015\Projects\CustomerOrderManagementSystem\CustomerOrderManagementSystem\Scripts\users.txt'
	WITH
	(
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)
GO
	
SELECT * FROM dbo.Customers
GO