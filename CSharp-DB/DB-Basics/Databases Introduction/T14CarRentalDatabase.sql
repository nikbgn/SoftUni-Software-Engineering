GO
CREATE DATABASE [CarRental]
GO
USE CarRental
GO

--Categories (Id, CategoryName, DailyRate, WeeklyRate, MonthlyRate, WeekendRate)

CREATE TABLE [Categories]
(
	[Id] INT PRIMARY KEY IDENTITY,
	[CategoryName] NVARCHAR(30) NOT NULL,
	[DailyRate] INT NOT NULL,
	[WeeklyRate] INT NOT NULL,
	[MonthlyRate] INT NOT NULL,
	[WeekendRate] INT NOT NULL
)

GO
--Cars (Id, PlateNumber, Manufacturer, Model, CarYear, CategoryId, Doors, Picture, Condition, Available)

CREATE TABLE [Cars]
(
	[Id] INT PRIMARY KEY IDENTITY,
	[PlateNumber] VARCHAR(10) NOT NULL,
	[Manufacturer] NVARCHAR(30) NOT NULL,
	[Model] NVARCHAR (50) NOT NULL,
	[CarYear] INT NOT NULL,
	[CategoryID] INT FOREIGN KEY REFERENCES [Categories]([Id]),
	[Doors] INT NOT NULL,
	[Picture] VARBINARY(MAX),
	CHECK (DATALENGTH([Picture])<= 100000),
	[Condition] VARCHAR(4) NOT NULL,
	[Available] BIT NOT NULL
)
GO

--Employees (Id, FirstName, LastName, Title, Notes)

CREATE TABLE [Employees]
(
	[Id] INT PRIMARY KEY IDENTITY,
	[FirstName] NVARCHAR(50) NOT NULL,
	[LastName] NVARCHAR(50) NOT NULL,
	[Title] NVARCHAR(50) NOT NULL,
	[Notes] NVARCHAR(MAX)
)

GO

--Customers (Id, DriverLicenceNumber, FullName, Address, City, ZIPCode, Notes)
CREATE TABLE [Customers]
(
	[Id] INT PRIMARY KEY IDENTITY,
	[DriverLicenseNumber] NVARCHAR(50) NOT NULL,
	[FullName] NVARCHAR(50) NOT NULL,
	[Adress] NVARCHAR(50) NOT NULL,
	[City] NVARCHAR(50) NOT NULL,
	[ZipCode] NVARCHAR(10) NOT NULL,
	[Notes] NVARCHAR(MAX)
)

GO

-- RentalOrders (Id, EmployeeId, CustomerId, CarId, TankLevel, KilometrageStart, KilometrageEnd, TotalKilometrage, StartDate, EndDate, TotalDays, RateApplied, TaxRate, OrderStatus, Notes)

CREATE TABLE [RentalOrders]
(
	[Id] INT PRIMARY KEY IDENTITY,
	[EmployeeId] INT FOREIGN KEY REFERENCES [Employees]([Id]) NOT NULL,
	[CustomerId] INT FOREIGN KEY REFERENCES [Customers]([Id]) NOT NULL,
	[CarId] INT FOREIGN KEY REFERENCES [Cars]([Id]),
	[TankLevel] DECIMAL(3,1) NOT NULL,
	[KilometrageStart] INT NOT NULL,
	[KilometrageEnd] INT NOT NULL,
	[TotalKilometrage] INT NOT NULL,
	[StartDate] DATETIME NOT NULL,
	[EndDate] DATETIME NOT NULL,
	[TotalDays] INT NOT NULL,
	[RateApplied] DECIMAL(3,1) NOT NULL,
	[TaxRate] DECIMAL(3,1) NOT NULL,
	[OrderStatus] BIT NOT NULL,
	[Notes] NVARCHAR(MAX)

)

GO

INSERT INTO [Categories]([CategoryName],[DailyRate],[WeeklyRate],[MonthlyRate],[WeekendRate])
VALUES
	('Category1',1,1,1,1),
	('Category2',1,1,1,1),
	('Category3',1,1,1,1)

GO



INSERT INTO Employees([FirstName],[LastName],[Title],[Notes])
VALUES
	('Johnny','Johnes','Dentist',NULL),
	('Johnny','Johnes2','Vet',NULL),
	('Johnny','Johnes3','Engineer','Quite lazy')

GO


INSERT INTO Customers([DriverLicenseNumber],[FullName],[Adress],[City],[ZipCode],[Notes])
VALUES
	('123123211','Vankata','Ulica osem','Gradche','1111',NULL),
	('123123123','Diqnkata','Ulica devet','Gradche','1111',NULL),
	('322332131','Goshkata','Ulica deset','Gradche','1111',NULL)
GO


INSERT INTO [Cars]([PlateNumber],[Manufacturer],[Model],[CarYear], [CategoryID], [Doors],[Picture],[Condition],[Available])
VALUES
	('B 1111 HH','BMW', 'F10',2010,1,4,1,'Good',1),
	('B 1211 HH','BMW', 'F10',2011,2,4,1,'Good',1),
	('B 3123 HH','BMW', 'F10',2010,3,4,1,'Bad',1)
GO

INSERT INTO [RentalOrders]([EmployeeId],[CustomerId],[CarId],[TankLevel],[KilometrageStart],[KilometrageEnd],[TotalKilometrage],[StartDate],[EndDate],[TotalDays],[RateApplied],[TaxRate],[OrderStatus],[Notes])
VALUES
	(1,1,1,10.1,0,300,10000,'01-01-2010','01-01-2011',365,10.1,10.1,0,NULL),
	(2,2,2,10.1,0,300,10000,'01-01-2010','01-01-2011',365,10.1,10.1,0,NULL),
	(3,3,3,10.1,0,300,10000,'01-01-2010','01-01-2011',365,10.1,10.1,0,NULL)
GO







