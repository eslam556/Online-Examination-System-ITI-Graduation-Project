CREATE DATABASE [Institutional Performance Mart];

GO

USE [Institutional Performance Mart];

-- Dimension Table: Department
CREATE TABLE Dim_Department (
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(100) NOT NULL
);

-- Dimension Table: Branch
CREATE TABLE Dim_Branch (
    BranchID INT PRIMARY KEY,
    BranchName VARCHAR(100) NOT NULL
);

-- Dimension Table: Instructor
CREATE TABLE Dim_Instructor (
    InstructorID INT PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    BirthDate DATE NULL,
	Email VARCHAR(100) NULL
);

-- Fact Table: Institutional Metrics
CREATE TABLE Fact_Institutional_Metrics (
    MetricID INT IDENTITY(1,1) PRIMARY KEY,
    DepartmentID INT NOT NULL,
    BranchID INT NOT NULL,
    InstructorID INT NOT NULL,

    -- Metrics
    EnrollmentCount INT NULL,
    AvgGrades DECIMAL(5,2) NULL,
    CertificationRate DECIMAL(5,2) NULL,
    HiringRate DECIMAL(5,2) NULL,

    -- Constraints
    CONSTRAINT FK_Metrics_Department FOREIGN KEY (DepartmentID) REFERENCES Dim_Department(DepartmentID),
    CONSTRAINT FK_Metrics_Branch FOREIGN KEY (BranchID) REFERENCES Dim_Branch(BranchID),
    CONSTRAINT FK_Metrics_Instructor FOREIGN KEY (InstructorID) REFERENCES Dim_Instructor(InstructorID)
);