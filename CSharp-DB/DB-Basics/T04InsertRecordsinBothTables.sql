ALTER TABLE [Minions]
ADD [TownID] INT FOREIGN KEY REFERENCES [Towns]([Id]) NOT NULL

ALTER TABLE [Minions]
ALTER COLUMN [Age] INT

GO 
INSERT INTO [Towns]([Id],[Name])
	VALUES
(1, 'Sofia'),
(2, 'Plovdiv'),
(3, 'Varna')


INSERT INTO [Minions]([Id],[Name],[Age],[TownID])
	VALUES
(1,'Kevin',22,1),
(2,'Bob',15,3),
(3,'Steward',NULL,2)

SELECT * FROM [Minions]
SELECT * FROM [Towns]
