CREATE DATABASE [Minions]

USE [Minions]

--Minions in CREATE TABLE is the name of the table, not the database.
CREATE TABLE [Minions]
(
	[Id] INT PRIMARY KEY, --If something is PK it CANNOT BE NULL
	[Name] NVARCHAR(50) NOT NULL,
	[Age] INT NOT NULL
)

CREATE TABLE [Towns]
(
	[Id] INT PRIMARY KEY,
	[Name] NVARCHAR(100) NOT NULL
)