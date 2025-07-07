CREATE DATABASE [Student Mart];

GO

USE [Student Mart];

-- Dimension Table: Students
CREATE TABLE Dim_Student (
    StudentID INT PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    BirthDate DATE NULL,
    Gender VARCHAR(10) CHECK (Gender IN ('Male', 'Female')),
	City VARCHAR(100) NULL,
	Email VARCHAR(100) NULL,
    DepartmentName VARCHAR(100) NULL
);

-- Dimension Table: Course
CREATE TABLE Dim_Course (
    CourseID INT PRIMARY KEY,
    CourseName VARCHAR(100) NOT NULL,
    InstructorName VARCHAR(100) NOT NULL,
    ExamDuration INT NULL,
    TotalMarks INT NULL
);

-- Dimension Table: Certificate
CREATE TABLE Dim_Certificate (
    CertificateID INT PRIMARY KEY,
    CertificateName VARCHAR(100) NOT NULL,
    CertificateDate DATE NULL,
	CertificateHour INT NULL,
	CertificateWeb VARCHAR(MAX) NULL
);

-- Dimension Table: Employment
CREATE TABLE Dim_Employment (
    EmploymentID INT PRIMARY KEY,
    CompanyName VARCHAR(MAX) NOT NULL,
	PositionName VARCHAR(MAX) NOT NULL,
    PositionType VARCHAR(100) NOT NULL,
	Location VARCHAR(100) NULL,
    HiringDate DATE NULL,
	FreelanceJobName VARCHAR(MAX) NULL,
	JobWebsite VARCHAR(100) NULL,
	JobStartDate DATE NULL,
	JobTools VARCHAR(100) NULL,
	FeedbackRating INT NULL
);

-- Dimension Table: Date
CREATE TABLE Dim_Date (
    DateID INT PRIMARY KEY IDENTITY(1,1),
    Date DATE NOT NULL,
    Day INT NOT NULL,
    Month INT NOT NULL,
    MonthName VARCHAR(20) NOT NULL,
    Year INT NOT NULL,
    Quarter VARCHAR(10) NOT NULL,
    WeekdayName VARCHAR(20) NOT NULL,
    IsWeekend BIT NOT NULL
);

-- Fact Table Student Activity
CREATE TABLE Fact_Student_Activity (
    ActivityID INT IDENTITY(1,1) PRIMARY KEY,
    StudentID INT NOT NULL,
    CourseID INT NULL,
	CertificateID INT NULL,
	EmploymentID INT NULL,
	DateID INT NOT NULL,
    RecordType VARCHAR(20) NOT NULL,

	-- Metrics
    GradeValue DECIMAL(5,2) NULL

    -- Constraints
    CONSTRAINT FK_Activity_Student FOREIGN KEY (StudentID) REFERENCES Dim_Student(StudentID),
    CONSTRAINT FK_Activity_Course FOREIGN KEY (CourseID) REFERENCES Dim_Course(CourseID),
    CONSTRAINT FK_Activity_Certificate FOREIGN KEY (CertificateID) REFERENCES Dim_Certificate(CertificateID),
	CONSTRAINT FK_Activity_Employment FOREIGN KEY (EmploymentID) REFERENCES Dim_Employment(EmploymentID),
    CONSTRAINT FK_Activity_Date FOREIGN KEY (DateID) REFERENCES Dim_Date(DateID)
);