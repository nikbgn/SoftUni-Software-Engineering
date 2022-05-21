CREATE TABLE [People]
(
	[Id] INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(200) NOT NULL,
	[Picture] VARBINARY(MAX),
	CHECK (DATALENGTH([Picture]) <= 2000000),
	[Height] DECIMAL(3,2),
	[Weight] DECIMAL(5,2),
	[Gender] CHAR(1) NOT NULL,
	CHECK ([Gender] = 'm' OR [Gender] = 'f'),
	[Birthdate] DATE NOT NULL,
	[Biography] NVARCHAR(MAX)
)


INSERT INTO People([Name],[Picture],[Height],[Weight],[Gender],[Birthdate],[Biography])
VALUES
		('Nikolai Goshev', 1, NULL, 50.0, 'm', '2000-02-21', 'Hahalol'),
		('Petur Goshev', 1, NULL, 51.0, 'm', '2001-03-21', 'Cool story bro'),
		('Vankata Stoev', 1, 2.00, 111.0, 'm', '2002-04-01', 'I kinda lied about my height haha, 2.00 and 1.90 is basically the same right?'),
		('Joni Kapahala', 1, NULL, 68.7, 'm', '1999-05-06', 'I like to surf'),
		('Justin The Third', 1, NULL, 100.95, 'm', '1998-02-21', 'Why is my name the third lmao??')
