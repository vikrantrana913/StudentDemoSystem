Create database Techno
Use Techno

Create table Student(
StudentID bigint primary key identity(1,1),
FullName nvarchar(50),
DateOfBirth Date,
Gender nvarchar(10),
Address nvarchar(100),
Country bigint,
[State] bigint,
City bigint,
ContactNumber nvarchar(12),
Email nvarchar(50),
Photo nvarchar(max),
IsDeleted bit default 0,
CreatedOn Datetime default(GetDate())
)
drop table Student
Select * from Student

Create table Class
(
ClassID bigint primary key identity(1,1),
ClassName nvarchar(50),
TeacherID bigint,
IsDeleted bit default 0,
CreatedOn Datetime default(GetDate())
)


Create table Teacher
(
TeacherID bigint primary key identity(1,1),
FullName nvarchar(50),
SubjectID bigint,
ContactNumber nvarchar(12),
Email nvarchar(50),
IsDeleted bit default 0,
CreatedOn Datetime default(GetDate())
)

Create table Subject(
SubjectID bigint primary key identity(1,1),
SubjectName nvarchar(50),
Description nvarchar(500),
IsDeleted bit default 0,
CreatedOn Datetime default(GetDate())
)

Create table Enrollment
(
EnrollmentID bigint primary key identity(1,1),
StudentID bigint,
ClassID bigint,
EnrollmentDate Datetime default(GetDate()),
IsDeleted bit default 0,
CreatedOn Datetime default(GetDate())
)

Create table Attendance
(
AttendanceID bigint primary key identity(1,1),
StudentID bigint,
ClassID bigint,
Date Datetime Default(GetDate()),
Status bit,
IsDeleted bit default 0,
CreatedOn Datetime default(GetDate())
)

Create table Grade
(
GradeID bigint primary key identity(1,1),
StudentID bigint,
SubjectID bigint,
ClassID bigint,
Marks bigint,
IsDeleted bit default 0,
CreatedOn Datetime default(GetDate())
)

Create Table dbo.tbl_Countries
(
CountryId Bigint primary key identity(1,1),
CountryName nvarchar(50)not null
)

Create table dbo.tbl_States
(
StateId bigint primary key identity(1,1),
StateName nvarchar(50)not null,
CountryCode bigint foreign key references tbl_Countries(CountryId)
)

Create table dbo.tbl_City
(
CityId bigint primary key identity(1,1),
CityName nvarchar(50)not null,
StateCode bigint foreign key references tbl_States(StateId)
)
