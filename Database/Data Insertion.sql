-- Insert Branch Data:

BULK INSERT Branch
FROM 'E:\BI_Project\Data Source\Branch.csv'
WITH (
    FIELDTERMINATOR = ',',
    ROWTERMINATOR = '\n',
    FIRSTROW = 1
);
--------------------------------------------------------------
-- Insert Department Data:

BULK INSERT Department
FROM 'E:\BI_Project\Data Source\Department.csv'
WITH (
    FIELDTERMINATOR = ',',
    ROWTERMINATOR = '\n',
    FIRSTROW = 1
);
--------------------------------------------------------------
-- Insert Branch_Department Data:

BULK INSERT Branch_Department
FROM 'E:\BI_Project\Data Source\Branch_Department.csv'
WITH (
    FIELDTERMINATOR = ',',
    ROWTERMINATOR = '\n',
    FIRSTROW = 1
);
--------------------------------------------------------------
-- Insert Certificate Data:

BULK INSERT Certificate
FROM 'E:\BI_Project\Data Source\Certificate.csv'
WITH (
    FIELDTERMINATOR = ',',
    ROWTERMINATOR = '\n',
    FIRSTROW = 1
);
--------------------------------------------------------------
ALTER TABLE Instructor
ALTER COLUMN Password VARCHAR(MAX);

-- Insert Instructor Data:

BULK INSERT Instructor
FROM 'E:\BI_Project\Data Source\Instructor.csv'
WITH (
    FIELDTERMINATOR = ',',
    ROWTERMINATOR = '\n',
    FIRSTROW = 1
);
--------------------------------------------------------------
-- Insert Course Data:

BULK INSERT Course
FROM 'E:\BI_Project\Data Source\Course.csv'
WITH (
    FIELDTERMINATOR = ',',
    ROWTERMINATOR = '\n',
    FIRSTROW = 1
);
--------------------------------------------------------------
-- Insert Choice Data:

BULK INSERT Choice
FROM 'E:\BI_Project\Data Source\Choice.csv'
WITH (
    FIELDTERMINATOR = ',',
    ROWTERMINATOR = '\n',
    FIRSTROW = 1
);
--------------------------------------------------------------
-- Insert Exam Data:

BULK INSERT Exam
FROM 'E:\BI_Project\Data Source\Exam.csv'
WITH (
    FIELDTERMINATOR = ',',
    ROWTERMINATOR = '\n',
    FIRSTROW = 1
);
--------------------------------------------------------------
--ALTER TABLE Question
--ALTER COLUMN Question_Type VARCHAR(50);

ALTER TABLE Question
ALTER COLUMN Question_Marks bigint;

--Insert Question Data:

BULK INSERT Question
FROM 'E:\BI_Project\Data Source\Question.csv'
WITH (
    FIELDTERMINATOR = ',',
    ROWTERMINATOR = '\n',
    FIRSTROW = 1
);
--------------------------------------------------------------
ALTER TABLE Student
ALTER COLUMN Password VARCHAR(MAX);

-- Insert Student Data:

BULK INSERT Student
FROM 'E:\BI_Project\Data Source\Student.csv'
WITH (
    FIELDTERMINATOR = ',',
    ROWTERMINATOR = '\n',
    FIRSTROW = 1
);
--------------------------------------------------------------
-- Insert Topic Data:

BULK INSERT Topic
FROM 'E:\BI_Project\Data Source\Topic.csv'
WITH (
    FIELDTERMINATOR = ',',
    ROWTERMINATOR = '\n',
    FIRSTROW = 1
);
--------------------------------------------------------------
-- Insert Freelancing Data:

BULK INSERT Freelancing
FROM 'E:\BI_Project\Data Source\Freelancing.csv'
WITH (
    FIELDTERMINATOR = ',', 
    ROWTERMINATOR = '\n',    
    FIRSTROW = 2,            
    CODEPAGE = 'ACP'        
);
--------------------------------------------------------------
-- Insert Hiring Data:

BULK INSERT Hiring
FROM 'E:\BI_Project\Data Source\Hiring.csv'
WITH (
    FIELDTERMINATOR = ',', 
    ROWTERMINATOR = '\n',    
    FIRSTROW = 2,            
    CODEPAGE = 'ACP'        
);
--------------------------------------------------------------
-- Insert Student_Certificate Data:

BULK INSERT Student_Certificate
FROM 'E:\BI_Project\Data Source\Student_Certificate.csv'
WITH (
    FIELDTERMINATOR = ',', 
    ROWTERMINATOR = '\n',    
    FIRSTROW = 2,            
    CODEPAGE = 'ACP'        
);
--------------------------------------------------------------
-- Insert Student_Course Data:

BULK INSERT Student_Course
FROM 'E:\BI_Project\Data Source\Student_Course.csv'
WITH (
    FIELDTERMINATOR = ',', 
    ROWTERMINATOR = '\n',    
    FIRSTROW = 2,            
    CODEPAGE = 'ACP'        
);
--------------------------------------------------------------
-- Insert Student_Answer Data:

BULK INSERT Student_Answer
FROM 'E:\BI_Project\Data Source\Student_Answer.csv'
WITH (
    FIELDTERMINATOR = ',', 
    ROWTERMINATOR = '\n',    
    FIRSTROW = 2,            
    CODEPAGE = 'ACP'        
);
--------------------------------------------------------------
-- Insert Student_Phone Data:

BULK INSERT Student_Phone
FROM 'C:\Users\sohail\OneDrive\Desktop\Student_Phone.csv'
WITH (
    FIELDTERMINATOR = ',', 
    ROWTERMINATOR = '\n',    
    FIRSTROW = 2,            
    CODEPAGE = 'ACP'        
);
--------------------------------------------------------------