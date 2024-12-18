CREATE DATABASE QuanLySinhVien
GO

USE QuanLySinhVien
GO

CREATE TABLE SINH_VIEN
(
	Id nvarchar(5) primary key,
	FullName nvarchar(50),
	AverageScore float,
	FacultyId nvarchar(5),

	foreign key (FacultyId) references dbo.Khoa(FacultyId)
)
go

CREATE TABLE KHOA
(
	FacultyId nvarchar(5) primary key,
	FacultyName nvarchar(50) 
)
GO


INSERT INTO SINH_VIEN(Id,FullName,AverageScore,FacultyId) values
('01','QuocDai',8,'01')