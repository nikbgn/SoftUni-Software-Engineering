CREATE TABLE [Users]
(
	[Id] BIGINT PRIMARY KEY IDENTITY,
	[Username] VARCHAR(30) NOT NULL,
	[Password] VARCHAR(26) NOT NULL,
	[ProfilePicture] VARBINARY(MAX)
	CHECK (DATALENGTH([ProfilePicture])<= 900000),
	[LastLoginTime] DATETIME2,
	[IsDeleted] BIT

)



INSERT INTO [Users]([Username],[Password],[ProfilePicture],[LastLoginTime],[IsDeleted])
VALUES
	('Jetski61','FikiMiki2',1,NULL,1),
	('Jetski62','FikiMiki2',22,NULL,1),
	('Jetski63','FikiMiki2',13231,'2022-12-23 15:40:45',0),
	('Jetski64','FikiMiki2',23231,'2022-08-08 16:20:15',0),
	('Jetski65','FikiMiki2',13312,'2022-11-13 07:00:01',0)

