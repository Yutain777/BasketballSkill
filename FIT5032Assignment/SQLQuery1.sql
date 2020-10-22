
Create table [dbo].[ClassReport](
	[ClassId] int identity(1,1) NOT NULL,
	[StudentsNumber] int default(0),
	primary key(ClassId),
	Foreign key(ClassId) References Classes(Id)
);
GO



