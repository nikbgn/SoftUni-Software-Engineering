GO
CREATE DATABASE Hotel
GO
USE Hotel
GO
--Employees (Id, FirstName, LastName, Title, Notes)
CREATE TABLE Employees
(
	[Id] INT PRIMARY KEY IDENTITY,
	[FirstName] NVARCHAR(50) NOT NULL,
	[LastName] NVARCHAR(50) NOT NULL,
	[Title] NVARCHAR(30) NOT NULL,
	[Notes] NVARCHAR(MAX)
)
GO
--Customers (AccountNumber, FirstName, LastName, PhoneNumber, EmergencyName, EmergencyNumber, Notes)
CREATE TABLE Customers
(
	[AccountNumber] INT PRIMARY KEY IDENTITY,
	[FirstName] NVARCHAR(50) NOT NULL,
	[LastName] NVARCHAR(50) NOT NULL,
	[PhoneNumber] NVARCHAR(10) NOT NULL,
	[EmergencyName] NVARCHAR(50) ,
	[EmergencyNumber] NVARCHAR(10) ,
	[Notes] NVARCHAR(MAX)
)
GO
--RoomStatus (RoomStatus, Notes)
CREATE TABLE RoomStatus
(
	[RoomStatus] NVARCHAR(30) PRIMARY KEY ,
	[Notes] NVARCHAR(MAX)
)

GO
--RoomTypes (RoomType, Notes)
CREATE TABLE RoomTypes
(
	[RoomType] NVARCHAR(30) PRIMARY KEY ,
	[Notes] NVARCHAR(MAX)
)
GO
--BedTypes (BedType, Notes)
CREATE TABLE BedTypes
(
	[BedType] NVARCHAR(30) PRIMARY KEY,
	[Notes] NVARCHAR(MAX)
)
GO
--Rooms (RoomNumber, RoomType, BedType, Rate, RoomStatus, Notes)
CREATE TABLE Rooms
(
	[RoomNumber] INT PRIMARY KEY IDENTITY,
	[RoomType] NVARCHAR(30) FOREIGN KEY REFERENCES [RoomTypes]([RoomType]) NOT NULL,
	[BedType] NVARCHAR(30) FOREIGN KEY REFERENCES [BedTypes]([BedType]) NOT NULL,
	[Rate] INT NOT NULL,
	[RoomStatus] NVARCHAR(30) FOREIGN KEY REFERENCES [RoomStatus]([RoomStatus]) NOT NULL,
	[Notes] NVARCHAR(MAX)
)
GO
--Payments (Id, EmployeeId, PaymentDate, AccountNumber, FirstDateOccupied, LastDateOccupied, TotalDays, AmountCharged, TaxRate, TaxAmount, PaymentTotal, Notes)
CREATE TABLE Payments
(
	[Id] INT PRIMARY KEY IDENTITY,
	[EmployeeId] INT FOREIGN KEY REFERENCES [Employees]([Id]) NOT NULL,
	[AccountNumber] INT FOREIGN KEY REFERENCES [Customers]([AccountNumber]),
	[FirstDateOccupied] DATETIME NOT NULL,
	[LastDateOccupied] DATETIME NOT NULL,
	[TotalDays] INT NOT NULL,
	[AmountCharged] DECIMAL (4,1) NOT NULL,
	[TaxRate] INT,
	[TaxAmount] INT,
	[PaymentTotal] Decimal(4,1) NOT NULL,
	[Notes] NVARCHAR(MAX)
)
GO
--Occupancies (Id, EmployeeId, DateOccupied, AccountNumber, RoomNumber, RateApplied, PhoneCharge, Notes)
CREATE TABLE Occupancies
(
	[Id] INT PRIMARY KEY IDENTITY,
	[EmployeeId] INT FOREIGN KEY REFERENCES [Employees]([Id]) NOT NULL,
	[DateOccupied] DATETIME  NOT NULL,
	[AccountNumber] INT FOREIGN KEY REFERENCES [Customers]([AccountNumber]),
	[RoomNumber] INT NOT NULL,
	[RateApplied] INT,
	[PhoneCharge] INT,
	[Notes]NVARCHAR(MAX)

)
GO
INSERT INTO [Employees]
	    ([FirstName], [LastName], [Title], [Notes])
VALUES	    
	    ('Niki', 'Niki', 'employee1', NULL),
	    ('Niki', 'Niki2', 'employee2', NULL),
	    ('Niki', 'Niki3', 'employee3', NULL)
GO
INSERT INTO [Customers]
	    ([FirstName], [LastName], [PhoneNumber], [EmergencyName], [EmergencyNumber], [Notes])
VALUES	    
	    ('Nikolai', 'Nikolaiev', 899999999, NULL, NULL, NULL),
	    ('Nikolai', 'Nikolaiev', 899999991, NULL, NULL, NULL),
	    ('Nikolai', 'Nikolaiev', 899999992, NULL, NULL, NULL)
GO


INSERT INTO RoomStatus([RoomStatus], [Notes])
VALUES	('Status1', NULL),
	    ('Status2', NULL),
	    ('Status3', NULL)

INSERT INTO RoomTypes([RoomType], [Notes])
VALUES	('Type1', NULL),
	    ('Type2', NULL),
	    ('Type3', NULL)

INSERT INTO BedTypes([BedType], [Notes])
VALUES	('Bed1', NULL),
	    ('Bed2', NULL),
	    ('Bed3', NULL)
GO
INSERT INTO Rooms
	    ([RoomType], [BedType], [Rate], [RoomStatus], Notes)
VALUES     
	    ('Type1', 'Bed1', 5, 'Status1', NULL),
	    ('Type2', 'Bed2', 5, 'Status2', NULL),
	    ('Type3', 'Bed3', 5, 'Status3', NULL)
GO
INSERT INTO Payments
            ([EmployeeId],[AccountNumber], 
            [FirstDateOccupied], [LastDateOccupied], 
            [TotalDays], [AmountCharged], [TaxRate], 
            [TaxAmount], [PaymentTotal], [Notes])
VALUES            
            (1,  1, '2011-01-01', '2012-01-01', 5, 305.5, 8, 11, 341.2, NULL),
            (2,  2, '2011-01-01', '2012-01-01', 6, 301.0, 8, 11, 316.2, NULL),
            (3,  3, '2011-01-01', '2012-01-01', 7, 450.2, 8, 11, 475.4, NULL)

GO

INSERT INTO Occupancies
	    ([EmployeeId], [DateOccupied], [AccountNumber],
	     [RoomNumber], [RateApplied], [PhoneCharge], [Notes])
VALUES    
	    (1, '2011-01-01', 1, 1, 1, NULL, NULL),
	    (3, '2011-01-01', 2, 2, 2, NULL, NULL),
	    (2, '2011-01-01', 3, 3, 3, NULL, NULL)
GO