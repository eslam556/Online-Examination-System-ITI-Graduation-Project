-- Ensure unique email addresses for students:
ALTER TABLE Student
ADD CONSTRAINT UQ_Student_Email UNIQUE (Email);

-- Ensure unique email addresses for instructors:
ALTER TABLE Instructor
ADD CONSTRAINT UQ_Instructor_Email UNIQUE (Email);

-- Password must not be NULL for instructors:
ALTER TABLE Instructor 
ALTER COLUMN Password VARCHAR(MAX) NOT NULL;

-- Password must not be NULL for students:
ALTER TABLE Student 
ALTER COLUMN Password VARCHAR(MAX) NOT NULL;

-- Students cannot have a birth date in the future:
ALTER TABLE Student 
ADD CONSTRAINT CK_Student_BirthDate CHECK (Birth_Date <= GETDATE());

-- Instructors cannot have a birth date in the future:
ALTER TABLE Instructor 
ADD CONSTRAINT CK_Instructor_BirthDate CHECK (Birth_Date <= GETDATE());

-- Freelance job start date must not be in the future:
ALTER TABLE Freelancing 
ADD CONSTRAINT CK_Job_StartDate CHECK (Job_Start_DATE <= GETDATE());

--  Prevent duplicate exam questions:
ALTER TABLE Question
ADD CONSTRAINT UQ_Question_Text_Per_Exam UNIQUE (Question_ID, Crs_ID);

-- Question marks must be greater than zero:
ALTER TABLE Question 
ADD CONSTRAINT CK_Question_Marks CHECK (Question_Marks > 0);

-- Question type must be either 'MCQ' or 'TF':
ALTER TABLE Question 
ADD CONSTRAINT CK_Question_Type CHECK (Question_Type IN ('MCQ', 'TF'));

-- Student answer marks must be zero or positive:
ALTER TABLE Student_Answer
ADD CONSTRAINT CK_Student_Answer_Mark CHECK (Student_Answer_Mark >= 0);

-- Check Exam time/duration:
ALTER TABLE Course 
ADD CONSTRAINT CK_Exam_Duration CHECK (Exam_Duration BETWEEN 45 AND 150);

-- Ensure feedback rating is between 1 and 5:
ALTER TABLE Freelancing
ADD CONSTRAINT CK_Feedback_Rating CHECK (Feedback_Rating BETWEEN 1 AND 5);

-- Prevent a branch that have the same department more than once:
ALTER TABLE Branch_Department
ADD CONSTRAINT UQ_Branch_Department UNIQUE (Branch_ID, Department_ID);

-- Prevent a student from registering in the same course more than once:
ALTER TABLE Student_Course 
ADD CONSTRAINT UQ_Student_Course UNIQUE (Student_ID, Course_ID);

-- Prevent a question that have the same choice more than once:
ALTER TABLE Choice
ADD CONSTRAINT UQ_Question_Choice UNIQUE (Choice_ID, Question_ID);

-- Prevent a student from earning the same certificate more than once:
ALTER TABLE Student_Certificate 
ADD CONSTRAINT UQ_Student_Certificate UNIQUE (Student_ID, Certificate_ID);

-- When a course is deleted, delete its topics:
ALTER TABLE Topic
ADD CONSTRAINT FK_Topic_Course
FOREIGN KEY (Course_ID) REFERENCES Course(Course_ID)
ON DELETE CASCADE;

-- When a question is deleted, delete its choices:
ALTER TABLE Choice
ADD CONSTRAINT FK_Choice_Question
FOREIGN KEY (Question_ID) REFERENCES Question(Question_ID)
ON DELETE CASCADE;

-- When an instructor is deleted, set null to its courses:
ALTER TABLE Course
ADD CONSTRAINT FK_Instructor_Course
FOREIGN KEY (Instructor_ID) REFERENCES Instructor(Instructor_ID)
ON DELETE SET NULL;
--------------------------------------------------------------------

-- Improves performance when filtering or joining questions by their course
CREATE INDEX IX_Question_CourseID ON Question(Crs_ID);

-- Speeds up queries that filter or group questions by their type (MCQ or TF)
CREATE INDEX IX_Question_Type ON Question(Question_Type);

-- Optimizes queries that filter or sort job postings by position type (Full Time, Part Time, Freelance Project)
CREATE INDEX IX_Position_Type ON Hiring(Position_Type);
--------------------------------------------------------------------