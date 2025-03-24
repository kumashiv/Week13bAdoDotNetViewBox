# Week13bAdoDotNetViewBox


Database created in SQL Server


Application Created
Connected to database via Model > Data > ADO.NET Entity Data MOdel







# SQL Query

Use Master
CREATE DATABASE Week13bAdoDotNetViewBoxDB
USE Week13bAdoDotNetViewBoxDB

CREATE TABLE Employees
(
	id int identity (1,1) primary key,
	FirstName varchar(50),
	LastName varchar(50),
	Email varchar(50),
	Gender varchar(10) CHECK (Gender IN ('Male', 'Female')) -- Restricts Gender to 'Male' or 'Female'
)

SELECT * FROM Employees
