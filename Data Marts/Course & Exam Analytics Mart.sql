CREATE DATABASE [Course & Exam Analytics Mart];

GO

USE [Course & Exam Analytics Mart];

-- Dimension Tables
CREATE TABLE Dim_Course (
    CourseID INT PRIMARY KEY,
    CourseName VARCHAR(100) NOT NULL,
    InstructorName VARCHAR(100) NOT NULL,
    ExamDuration INT NULL,
    TotalMarks INT NULL
);

CREATE TABLE Dim_Exam (
    ExamID INT PRIMARY KEY,
    CourseName VARCHAR(100) NULL,
    TotalQuestions INT NOT NULL,
    TimeLimitMinutes INT NOT NULL
);

CREATE TABLE Dim_Question (
    QuestionID INT PRIMARY KEY,
    QuestionText NVARCHAR(MAX) NOT NULL,
    QuestionType VARCHAR(10) NOT NULL CHECK (QuestionType IN ('MCQ', 'TF')),
    Marks INT NOT NULL,
    DifficultyLevel VARCHAR(20) NULL CHECK (DifficultyLevel IN ('Easy', 'Medium', 'Hard'))
);

CREATE TABLE Dim_Topic(
	TopicID INT PRIMARY KEY,
	TopicName VARCHAR(100)
);

-- Fact Table
CREATE TABLE Fact_Course_Performance (
    MetricID INT IDENTITY(1,1) PRIMARY KEY,
    CourseID INT NOT NULL,
    ExamID INT NULL,
    QuestionID INT NULL,
	TopicID INT NULL,
    
    -- Metrics
    PassRate DECIMAL(5,2) NULL
    
    -- Constraints (only fact-to-dimension)
    CONSTRAINT FK_Performance_Course FOREIGN KEY (CourseID) REFERENCES Dim_Course(CourseID),
    CONSTRAINT FK_Performance_Exam FOREIGN KEY (ExamID) REFERENCES Dim_Exam(ExamID),
    CONSTRAINT FK_Performance_Question FOREIGN KEY (QuestionID) REFERENCES Dim_Question(QuestionID),
	CONSTRAINT FK_Performance_Topic FOREIGN KEY (TopicID) REFERENCES Dim_Topic(TopicID)
);