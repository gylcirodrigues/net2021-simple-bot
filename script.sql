USE master
go

IF NOT EXISTS(SELECT * FROM SYS.databases WHERE name = 'SimpleBot')
	CREATE DATABASE SimpleBot;
go

use SimpleBot;
GO

IF OBJECT_ID('[User]') IS NULL
	CREATE TABLE [User]
	(
		Id VARCHAR(255) CONSTRAINT PK_USER PRIMARY KEY,
		Nome VARCHAR(125),
		Idade INT,
		Cor VARCHAR(25)
	)