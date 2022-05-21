GO
CREATE DATABASE [Movies]
GO
USE [Movies]

GO

CREATE TABLE [Directors]
(
	[Id] INT PRIMARY KEY IDENTITY,
	[DirectorName] NVARCHAR(50)  NOT NULL,
	[Notes] NVARCHAR(MAX)
)

GO

CREATE TABLE [Genres]
(
	[Id] INT PRIMARY KEY IDENTITY,
	[GenreName] NVARCHAR(50)  NOT NULL,
	[Notes] NVARCHAR(MAX)
)

GO

CREATE TABLE [Categories]
(
	[Id] INT PRIMARY KEY IDENTITY,
	[CategoryName] NVARCHAR(50)  NOT NULL,
	[Notes] NVARCHAR(MAX)
)

GO


CREATE TABLE [Movies]
(
	[Id] INT PRIMARY KEY IDENTITY,
	[Title] NVARCHAR(50) NOT NULL,
	[DirectorId] INT FOREIGN KEY REFERENCES [Directors]([Id]),
	[CopyrightYear] DATE,
	[Length] TIME NOT NULL,
	[GenreId] INT FOREIGN KEY REFERENCES [Genres]([Id]),
	[CategoryId] INT FOREIGN KEY REFERENCES [Categories]([Id]),
	[Rating] Decimal(2,1) NOT NULL,
	[Notes] NVARCHAR(MAX)
)

GO

INSERT INTO [Directors]([DirectorName],[Notes])
VALUES
	('Josepe Josepe','A good director'),
	('Johnny Johnny',NULL),
	('Josepe Josepe2','A good director'),
	('Johnny Johnny3',NULL),
	('Josepe Josepe5','A good director')



GO
INSERT INTO [Genres]([GenreName],[Notes])
VALUES
	('Comedy',NULL),
	('Horror',NULL),
	('Strange',NULL),
	('Strange2',NULL),
	('Strange21',NULL)

GO
INSERT INTO [Categories]([CategoryName],[Notes])
VALUES
	('Funny',NULL),
	('Scary',NULL),
	('Strange11',NULL),
	('Strange11111',NULL),
	('Strange111111',NULL)

GO

INSERT INTO [Movies]([Title],[DirectorId],[CopyrightYear],[Length],[GenreId],[CategoryId],[Rating],[Notes])
VALUES
	('A Fun Movie', 1, '2022-05-19','01:10:02',1,1,4.1,NULL),
	('A Fun Movie 2', 1, '2022-05-20','01:00:12',1,1,5.1,'Even better than the first part!'),
	('The Conjuring', 1, '2011-05-19','01:10:02',1,1,4.1,'Fake info lol'),
	('ShigiJigi', 1, '2021-05-20','01:00:12',1,1,5.1,'Oh'),
	('ShigiJigi 2', 1, '2022-05-20','01:00:12',1,1,5.1,'Even better than the first part!')

GO


