Use CoursesManagement
Go

Create Table Courses
(
	Code nvarchar(10) Primary key,
	Name nvarchar(10) not null,
	Credit int not null
)

Insert Courses (Code,Name,Credit) Values('PMN231','Code Java',3 )
Insert Courses (Code,Name,Credit) Values('ABC211','Code C#',2 )
Insert Courses (Code,Name,Credit) Values('KQP111','Code C++',5)
Insert Courses (Code,Name,Credit) Values( 'NMC312','Code PHP',1)