GO
CREATE DATABASE SoftUni
GO
USE SoftUni
GO
--Towns (Id, Name)
CREATE TABLE Towns
(
	[Id] INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(80) NOT NULL
)
GO
--Addresses (Id, AddressText, TownId)
CREATE TABLE Addresses
(
	[Id] INT PRIMARY KEY IDENTITY,
	[AddressText] NVARCHAR(50) NOT NULL,
	[TownId] INT FOREIGN KEY REFERENCES [Towns]([Id])
)
GO
--Departments (Id, Name)
CREATE TABLE Departments
(
	[Id] INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(50) NOT NULL
)
GO
--Employees (Id, FirstName, MiddleName, LastName, JobTitle, DepartmentId, HireDate, Salary, AddressId)
CREATE TABLE Employees
(
	[Id] INT PRIMARY KEY IDENTITY,
	[FirstName] NVARCHAR(50) NOT NULL,
	[MiddleName] NVARCHAR(50) NOT NULL,
	[LastName] NVARCHAR(50) NOT NULL,
	[JobTitle] NVARCHAR(50),
	[DepartmentId] INT FOREIGN KEY REFERENCES [Departments]([Id]),
	[HireDate] DATETIME,
	[Salary] DECIMAL (6,2),
	[AddressId] INT FOREIGN KEY REFERENCES [Addresses]([Id])
)
GO

