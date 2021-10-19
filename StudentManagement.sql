USE [StudentManagement]
GO
/*Object: Table [dbo].[tblUser]*/
CREATE TABLE [dbo].[tblUser]
(
	[email] [varchar] (20) NOT NULL,
	[password] [varchar] (50) NOT NULL
)


/*Object: Table [dbo].[tblMajor]*/
CREATE TABLE [dbo].[tblMajor]
(
	[majorID] [varchar](20) NOT NULL,
	[majorName] [varchar](50) NULL,
	[subjectID] [varchar](20) NOT NULL,
	CONSTRAINT [PK_tblMajor_majorID] PRIMARY KEY([majorID])
)

/*Object: Table [dbo].[tblSubject]*/
CREATE TABLE [dbo].[tblSubject]
(
	[subjectID] [varchar](20) NOT NULL,
	[subjectName] [varchar](50) NULL,
	[majorID] [varchar](20) NOT NULL, 
	CONSTRAINT [PK_tblSubject_subjectID] PRIMARY KEY([subjectID]),
	CONSTRAINT [FK_tblSubject_smajorID] FOREIGN KEY([majorID]) REFERENCES [dbo].[tblMajor]([majorID])
)

/*Object: Table [dbo].[tblCourse]*/
CREATE TABLE [dbo].[tblCourse]
(
	[courseID] [int] NOT NULL,
	[courseName] [varchar](50) NULL,
	[subjectID] [varchar](20) NOT NULL,
	CONSTRAINT [PK_tblCourse_courseID] PRIMARY KEY([courseID]),
	CONSTRAINT [FK_tblCourse_subjectID] FOREIGN KEY([subjectID]) REFERENCES [dbo].[tblSubject]([subjectID])
)

/*Object: Table [dto].[tblStudent]*/
CREATE TABLE [dbo].[tblStudent]
(
	[studentID] [varchar](20) NOT NULL,
	[fullname] [varchar](50) NULL,
	[birthday] [date] NULL,
	[gender] [int] NULL,
	[address] [varchar](50) NULL,
	[phone] [varchar](20) NULL,
	[email] [varchar](50) NULL,
	[birthplace] [varchar](50) NULL,
	[majorID] [varchar](20) NOT NULL,
	CONSTRAINT [PK_tblStudent_studentID] PRIMARY KEY([studentID]),
	CONSTRAINT [FK_tblStudent_majorID] FOREIGN KEY([majorID]) REFERENCES [dbo].[tblMajor]([majorID])
)

/*Object: Table [dbo].[tblMark]*/
CREATE TABLE [dbo].[tblMark]
(
	[Assignment] [int] NULL,
	[Practical] [int] NULL,
	[Final] [int] NULL,
	[courseID] [int] NOT NULL,
	[studentID] [varchar](20) NOT NULL,
	CONSTRAINT [PK_tblMark_studentID_courseID] PRIMARY KEY([studentID],[courseID]),
	CONSTRAINT [FK_tblMark_studentID] FOREIGN KEY([studentID]) REFERENCES [dbo].[tblStudent]([studentID]),
	CONSTRAINT [FK_tblMark_courseID] FOREIGN KEY([courseID]) REFERENCES [dbo].[tblCourse]([courseID])
)
