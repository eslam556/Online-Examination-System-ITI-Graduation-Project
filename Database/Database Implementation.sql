CREATE PROCEDURE DatabaseGeneration AS
	BEGIN
		-- Switch to the newly created or existing database
		EXEC('USE [Examination System]');

		--Creating the Tables

		-- Department
		IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Department' AND schema_id = SCHEMA_ID('dbo'))
		BEGIN
			PRINT '=========================================';
			PRINT 'Creating [Department] table.';
			PRINT '=========================================';

			CREATE TABLE dbo.Department (
				Department_ID INT PRIMARY KEY,
				Department_Name VARCHAR(100),
				Department_Description VARCHAR(MAX)
			);

			PRINT '=========================================';
			PRINT 'Table [Department] created.';
			PRINT '=========================================';
		END

		-- Branch
		IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Branch' AND schema_id = SCHEMA_ID('dbo'))
		BEGIN
			PRINT '=========================================';
			PRINT 'Creating [Branch] table.';
			PRINT '=========================================';

			CREATE TABLE dbo.Branch (
				Branch_ID INT PRIMARY KEY,
				Branch_Name VARCHAR(100)
			);

			PRINT '=========================================';
			PRINT 'Table [Branch] created.';
			PRINT '=========================================';
		END

		--Branch_Department
		IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Branch_Department' AND schema_id = SCHEMA_ID('dbo'))
		BEGIN
			PRINT '=========================================';
			PRINT 'Creating [Branch_Department] table.';
			PRINT '=========================================';

			CREATE TABLE dbo.Branch_Department (
				Branch_ID INT,
				Department_ID INT,

				PRIMARY KEY(Branch_ID, Department_ID),
				FOREIGN KEY (Branch_ID) REFERENCES Branch(Branch_ID),
				FOREIGN KEY (Department_ID) REFERENCES Department(Department_ID)
			);

			PRINT '=========================================';
			PRINT 'Table [Branch_Department] created.';
			PRINT '=========================================';
		END

		--Student
		IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Student' AND schema_id = SCHEMA_ID('dbo'))
		BEGIN
			PRINT '=========================================';
			PRINT 'Creating [Student] table.';
			PRINT '=========================================';

			CREATE TABLE dbo.Student (
				Student_ID INT PRIMARY KEY,
				First_Name VARCHAR(100),
				Last_Name VARCHAR(100),
				Birth_Date DATE,
				Gender VARCHAR(10),
				City VARCHAR(50),
				Email VARCHAR(100),
				Password VARCHAR(10),
				Department_ID INT,

				FOREIGN KEY (Department_ID) REFERENCES Department(Department_ID)
			);

			PRINT '=========================================';
			PRINT 'Table [Student] created.';
			PRINT '=========================================';
		END

		--Student_Phone
		IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Student_Phone' AND schema_id = SCHEMA_ID('dbo'))
		BEGIN
			PRINT '=========================================';
			PRINT 'Creating [Student_Phone] table.';
			PRINT '=========================================';

			CREATE TABLE dbo.Student_Phone (
				Student_ID INT,
				Phone_Number VARCHAR(20),
        
				PRIMARY KEY(Student_ID, Phone_Number),
				FOREIGN KEY (Student_ID) REFERENCES Student(Student_ID)
			);

			PRINT '=========================================';
			PRINT 'Table [Student_Phone] created.';
			PRINT '=========================================';
		END

		--Certificate
		IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Certificate' AND schema_id = SCHEMA_ID('dbo'))
		BEGIN
			PRINT '=========================================';
			PRINT 'Creating [Certificate] table.';
			PRINT '=========================================';

			CREATE TABLE dbo.Certificate (
				Certificate_ID INT PRIMARY KEY,
				Certificate_Name VARCHAR(100),
				Certificate_Hour INT,
				Certificate_Website VARCHAR(100),
				Certificate_Date DATE
			);

			PRINT '=========================================';
			PRINT 'Table [Certificate] created.';
			PRINT '=========================================';
		END

		--Student_Certificate
		IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Student_Certificate' AND schema_id = SCHEMA_ID('dbo'))
		BEGIN
			PRINT '=========================================';
			PRINT 'Creating [Student_Certificate] table.';
			PRINT '=========================================';

			CREATE TABLE dbo.Student_Certificate (
				Certificate_ID INT,
				Student_ID INT,
        
				PRIMARY KEY(Certificate_ID, Student_ID),
				FOREIGN KEY (Certificate_ID) REFERENCES Certificate(Certificate_ID),
				FOREIGN KEY (Student_ID) REFERENCES Student(Student_ID)
			);

			PRINT '=========================================';
			PRINT 'Table [Student_Certificate] created.';
			PRINT '=========================================';
		END

		--Hiring
		IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Hiring' AND schema_id = SCHEMA_ID('dbo'))
		BEGIN
			PRINT '=========================================';
			PRINT 'Creating [Hiring] table.';
			PRINT '=========================================';

			CREATE TABLE dbo.Hiring (
				Hiring_ID INT PRIMARY KEY,
				Hiring_Position VARCHAR(MAX),
				Hiring_Date DATE,
				Hiring_Company VARCHAR(MAX),
				Hiring_Location VARCHAR(100),
				Position_Type VARCHAR(100),
				Student_ID INT,
        
				FOREIGN KEY (Student_ID) REFERENCES Student(Student_ID)
			);

			PRINT '=========================================';
			PRINT 'Table [Hiring] created.';
			PRINT '=========================================';
		END

		--Freelancing
		IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Freelancing' AND schema_id = SCHEMA_ID('dbo'))
		BEGIN
			PRINT '=========================================';
			PRINT 'Creating [Freelancing] table.';
			PRINT '=========================================';

			CREATE TABLE dbo.Freelancing (
				Job_ID INT PRIMARY KEY,
				Job_Name VARCHAR(MAX),
				Job_Website VARCHAR(100),
				Job_Start_DATE DATE,
				Job_Tools VARCHAR(100),
				Feedback_Rating INT,
				Student_ID INT,
        
				FOREIGN KEY (Student_ID) REFERENCES Student(Student_ID)
			);

			PRINT '=========================================';
			PRINT 'Table [Freelancing] created.';
			PRINT '=========================================';
		END

		--Instructor
		IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Instructor' AND schema_id = SCHEMA_ID('dbo'))
		BEGIN
			PRINT '=========================================';
			PRINT 'Creating [Instructor] table.';
			PRINT '=========================================';

			CREATE TABLE dbo.Instructor (
				Instructor_ID INT PRIMARY KEY,
				First_Name VARCHAR(100),
				Last_Name VARCHAR(100),
				Birth_Date DATE,
				Gender VARCHAR(10),
				City VARCHAR(50),
				Email VARCHAR(100),
				Password VARCHAR(10)
			);

			PRINT '=========================================';
			PRINT 'Table [Instructor] created.';
			PRINT '=========================================';
		END

		--Course
		IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Course' AND schema_id = SCHEMA_ID('dbo'))
		BEGIN
			PRINT '=========================================';
			PRINT 'Creating [Course] table.';
			PRINT '=========================================';

			CREATE TABLE dbo.Course (
				Course_ID INT PRIMARY KEY,
				Course_Name VARCHAR(100),
				Instructor_ID INT,

				FOREIGN KEY (Instructor_ID) REFERENCES Instructor(Instructor_ID)
			);

			PRINT '=========================================';
			PRINT 'Table [Course] created.';
			PRINT '=========================================';
		END

		--Student_Course
		IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Student_Course' AND schema_id = SCHEMA_ID('dbo'))
		BEGIN
			PRINT '=========================================';
			PRINT 'Creating [Student_Course] table.';
			PRINT '=========================================';

			CREATE TABLE dbo.Student_Course (
				Student_ID INT,
				Course_ID INT,
        
				PRIMARY KEY(Student_ID, Course_ID),
				FOREIGN KEY (Student_ID) REFERENCES Student(Student_ID),
				FOREIGN KEY (Course_ID) REFERENCES Course(Course_ID)
			);

			PRINT '=========================================';
			PRINT 'Table [Student_Course] created.';
			PRINT '=========================================';
		END

		--Topic
		IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Topic' AND schema_id = SCHEMA_ID('dbo'))
		BEGIN
			PRINT '=========================================';
			PRINT 'Creating [Topic] table.';
			PRINT '=========================================';

			CREATE TABLE dbo.Topic (
				Topic_ID INT PRIMARY KEY,
				Topic_Name VARCHAR(100),
				Course_ID INT,
        
				FOREIGN KEY (Course_ID) REFERENCES Course(Course_ID)
			);

			PRINT '=========================================';
			PRINT 'Table [Topic] created.';
			PRINT '=========================================';
		END

		--Exam
		IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Exam' AND schema_id = SCHEMA_ID('dbo'))
		BEGIN
			PRINT '=========================================';
			PRINT 'Creating [Exam] table.';
			PRINT '=========================================';

			CREATE TABLE dbo.Exam (
				Exam_ID INT PRIMARY KEY,
				Exam_Name VARCHAR(100),
				Exam_Duration INT,
				Exam_Marks INT,
				Course_ID INT,
        
				FOREIGN KEY (Course_ID) REFERENCES Course(Course_ID)
			);

			PRINT '=========================================';
			PRINT 'Table [Exam] created.';
			PRINT '=========================================';
		END

		--Question
		IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Question' AND schema_id = SCHEMA_ID('dbo'))
		BEGIN
			PRINT '=========================================';
			PRINT 'Creating [Question] table.';
			PRINT '=========================================';

			CREATE TABLE dbo.Question (
				Question_ID INT PRIMARY KEY,
				Question_Text VARCHAR(MAX),
				Question_Type VARCHAR(3),
				Question_Marks INT,
				Exam_ID INT,
        
				FOREIGN KEY (Exam_ID) REFERENCES Exam(Exam_ID)
			);

			PRINT '=========================================';
			PRINT 'Table [Question] created.';
			PRINT '=========================================';
		END

		--Choice
		IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Choice' AND schema_id = SCHEMA_ID('dbo'))
		BEGIN
			PRINT '=========================================';
			PRINT 'Creating [Choice] table.';
			PRINT '=========================================';

			CREATE TABLE dbo.Choice (
				Choice_ID INT PRIMARY KEY,
				Choice_Text VARCHAR(MAX),
				Is_Correct INT,
				Question_ID INT,
        
				FOREIGN KEY (Question_ID) REFERENCES Question(Question_ID)
			);

			PRINT '=========================================';
			PRINT 'Table [Choice] created.';
			PRINT '=========================================';
		END

		--Student_Answer
		IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Student_Answer' AND schema_id = SCHEMA_ID('dbo'))
		BEGIN
			PRINT '=========================================';
			PRINT 'Creating [Student_Answer] table.';
			PRINT '=========================================';

			CREATE TABLE dbo.Student_Answer (
				Student_Answer_ID INT PRIMARY KEY,
				Student_Answer_Text VARCHAR(MAX),
				Student_Answer_Mark INT,
				Question_ID INT,
				Student_ID INT,
        
				FOREIGN KEY (Question_ID) REFERENCES Question(Question_ID),
				FOREIGN KEY (Student_ID) REFERENCES Student(Student_ID)
			);

			PRINT '=========================================';
			PRINT 'Table [Student_Answer] created.';
			PRINT '=========================================';

			PRINT '-----------------------------------------';
			PRINT'All Tables Created Successfully.';
			PRINT '-----------------------------------------';
		END
	END;