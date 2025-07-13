# 📝 ONLINE EXAMINATION DATABASE SYSTEM

### 📅 July 03, 2025  
### 🏢 Information Technological Institute  
### 🎓 Power BI Development Track

---

## 👥 Team Members
- Omart Ashraf 
- Eslam Mohamed  
- Sohail Ali
- Mokhtar Sameh 

---

## 📌 Executive Summary

The **Online Examination Database System** is a comprehensive platform for managing student exams, questions, grades, certificates, and academic structure. It features reliable ETL processes via **SSIS**, rich reporting using **SSRS**, a modern **Bolt AI**-powered web interface for students, and a robust **C#** desktop application for administrative operations.

---

## ❗ Problem Statement

Academic institutions face challenges in managing large volumes of student assessments, ensuring accuracy, issuing certifications, and facilitating transparency in grading. This system addresses those needs with centralized database architecture, automated workflows, and user-friendly applications.

---

## 💼 Business Case

- Students can take multiple exams across different courses.  
- Each course includes MCQ and True/False questions.  
- Exams are assigned to instructors and connected to departments and branches.  
- Exams include model answers and structured grading logic.  

---

## 🚀 Project Workflow

1. **Excel Data from Kaggle**  
   - Datasets related to students, courses, exams, and grades were sourced from Kaggle.

2. **Bulk Insert to SQL Server (Database Creation)**  
   - Cleaned and prepared data was bulk inserted into SQL Server.  
   - Database schema and relational constraints were defined.

3. **SSRS Reports**  
   - SSRS used to generate tabular and visual reports on grades, certifications, and exam analytics.

4. **Three Star Schema Data Marts**  
   - **Student Analytics**.  
   - **Course & Exam Analytics**.  
   - **Institutional Performance**.

5. **Power BI Reports**  
   - Interactive dashboards were built on top of each data mart for flexible slicing and drilldowns.

![Project Workflow](https://github.com/eslam556/Online-Examination-System-ITI-Graduation-Project/blob/main/Project%20WorkFlow.jpg)

---

## 🧩 ER Diagram

The ER diagram maps the academic ecosystem, defining relationships between entities:

- **One-to-Many**: Student → Freelance  
- **One-to-Many**: Student → Companies
- **One-to-Many**: Student → Department
- **One-to-Many**: Student → Student Answer
- **One-to-Many**: Course → Topic
- **One-to-Many**: Course → Instructor
- **One-to-Many**: Course → Exam
- **One-to-Many**: Course → Question Bank
- **One-to-Many**: Question Bank → Student Answer
- **One-to-Many**: Question Bank → Choices
- **Many-to-Many**: Department ↔ Branch
- **Many-to-Many**: Student ↔ Certificate
- **Many-to-Many**: Student ↔ Course
- **Many-to-Many**: Exam ↔ Question Bank

![ER Diagram](https://github.com/eslam556/Online-Examination-System-ITI-Graduation-Project/blob/main/Database/ERD.jpg)

---

## 🔗 Logical Mapping

The logical schema models real-world academic logic:

### 👩‍🎓 Student Relationships
- `Student` ⬌ `Student_Phone`: One-to-Many (a student may have multiple phone numbers)
- `Student` ⬌ `Student_Cert`: Many-to-Many (students can earn multiple certificates)
- `Student` ⬌ `Student_Crs`: Many-to-Many (tracks course enrollment and grades)
- `Student` ⬌ `StudentAnswer`: One-to-Many (each student submits multiple answers)
- `Student` ⬌ `Hiring`: One-to-Many (hired into multiple positions)
- `Student` ⬌ `Freelancing`: One-to-Many (can apply for multiple freelance jobs)

---

### 🏫 Academic Structure
- `Branch` ⬌ `Branch_Dept` ⬌ `Department`: Many-to-Many (departments exist across branches)
- `Student` → `Dept_ID` (Foreign Key) → `Department`: Many students belong to one department
- `Courses` → `Ins_ID` (Foreign Key) → `Instructor`: Courses are assigned to one instructor
- `Courses` ⬌ `Topic`: One-to-Many (each course has multiple topics)

---

### 🧪 Exam & Questions Mapping
- `Generated_Exam` → `Course_ID` (Foreign Key): Exams are created for specific courses
- `Exam_Questions` ⬌ `Generated_Exam` & `QuestionBank`: Many-to-Many (exams consist of many questions; questions may appear in many exams)
- `QuestionBank` ⬌ `Choices`: One-to-Many (each question has multiple answer choices)
- `StudentAnswer` → `Student_ID` & answer-specific data (text, mark, etc.)

---

### 🏆 Certification & Performance
- `Certificate` ⬌ `Student_Cert`: Many-to-Many (students may earn multiple certificates, and each certificate may apply to multiple students)
- `Student_Crs` stores final grade and links each student to their enrolled courses

--- 

![Mapping](https://github.com/eslam556/Online-Examination-System-ITI-Graduation-Project/blob/main/Database/Mappings.jpg)

---

## 🛠️ Database Implementation

Developed using **SQL Server**, the schema includes:

- Tables: `Students`, `Courses`, `Exams`, `Questions`, `Choices`, `Certificates`, `Instructors`, `Freelancing`, etc.  
- Integrity: All relationships enforced with primary and foreign keys  
- Optimized: Indexed and normalized for high performance

![Database Diagram](https://github.com/eslam556/Online-Examination-System-ITI-Graduation-Project/blob/main/Database/Database%20Digram.jpg)

---

## 🧱 Data Mart (Star Schema)

Three dedicated star schema data marts were created to serve targeted analytical needs:

---

### 📊 1. Student Data Mart

Focuses on individual student behavior and academic outcomes. Useful for tracking performance, dropout rates, and certificate generation trends.

- **Dim_Student**: Personal info including gender, city, department
- **Dim_Course**: Course details and instructor
- **Dim_Certificate**: Certificate name, date, hours, web
- **Dim_Employment**: Jobs, internships, freelancing (company, position, tools, feedback)
- **Dim_Date**: Calendar-based attributes (day, month, quarter, etc.) 
- **Fact_Student_Activity**: Stores metrics such as grade value, and links to certificate/employment records.

📷  
![Student Data Mart](https://github.com/eslam556/Online-Examination-System-ITI-Graduation-Project/blob/main/Data%20Marts/Student%20Mart.png)

---

### 📚 2. Course & Exam Analytics Data Mart

Designed to analyze course difficulty, question design, and exam outcomes across instructors and departments.

- **Dim_Course**: Instructor name, course duration, total marks
- **Dim_Exam**: Exam details such as total questions and time limits
- **Dim_Question**: Text, type, marks, and difficulty level
- **Dim_Topic**: Course topics used in performance tracking
- **Fact_Course_Performance**: Metrics like pass rate

📷  
![Course Exam Data Mart](https://github.com/eslam556/Online-Examination-System-ITI-Graduation-Project/blob/main/Data%20Marts/Course%20%26%20Exam%20Analytics%20Mart.png)

---

### 🏫 3. Institutional Performance Data Mart

Provides high-level performance indicators for academic institutions, supporting strategic decisions by stakeholders.

- **Dim_Branch**: Branch Name, Branch Id
- **Dim_Department**: Department Name, Department Id
- **Dim_Instructor**: Personal info including birth date, email, name
- **Fact_Institutional_Metrics**: Metrics like enrollment count, average grade, certification rate, hiring rate

📷  
![Institutional Data Mart](https://github.com/eslam556/Online-Examination-System-ITI-Graduation-Project/blob/main/Data%20Marts/Institutional%20Performance%20Mart.png)

---

Each data mart was used independently in **Power BI** to generate focused dashboards, enabling deep insight into specific academic KPIs.

---

## 🧪 SSIS (SQL Server Integration Services)

**SSIS** was used to create robust ETL pipelines that:

- Extract raw data from OLTP systems  
- Clean, standardize, and apply business logic  
- Load data into the star schema for reporting  
- Schedule updates and enforce data consistency

### 📊 1. Student Mart Pipeline
![ETL Pipeline](https://github.com/eslam556/Online-Examination-System-ITI-Graduation-Project/blob/main/SSIS/Student%20Data%20Mart.png)

### 📊 2. Course & Exam Analytics Mart Pipeline
![ETL Pipeline](https://github.com/eslam556/Online-Examination-System-ITI-Graduation-Project/blob/main/SSIS/Course%20%26%20Exam%20Analytics%20Data%20Mart.png)

### 📊 3. Institutional Performance Mart Pipeline
![ETL Pipeline](https://github.com/eslam556/Online-Examination-System-ITI-Graduation-Project/blob/main/SSIS/Institutional%20Performance%20Data%20Mart.png)

---

## 📈 Database Reporting (SSRS)

Built with **SSRS**, reports include:

- **Exam Questions & Choices**.
- **Examination Reports**.
- **Course Topics**.
- **Questions & Student Answers**.
- **Student Grades**
- **Student Information**

Reports support drill-down, filters, and export options for institutional use.

---

## 💻 Desktop Application (C#)

A powerful admin tool developed in **C#** for:

- **Report Access**: View and export performance, exam, and student-related reports
- **Password Management**: Allow users to securely update their login credentials
- **Exam Creation Access**: Integrated access point to the web application for exam creation and management

The desktop app is role-based, supporting secure access for instructors and academic staff.

---

## 🌐 Web Application (Bolt AI)

The **Bolt AI** web app provides a user-friendly interface for students.

### ✅ Purpose

Simulate an online examination experience with instant scoring.

### ⚙️ Key Features

- **Student Sign-Up/Login**  
  - Email & ID verification  
  - Select branch/department  

- **Exam Interface**  
  - View assigned exams  
  - Timer-enabled question navigation  
  - MCQ/TF support  

- **Results**  
  - Score and feedback after submission

### 🔌 Backend Integration

- Fetch exams for student  
- Insert answers and compute score  
- Save grades

## [App Walkthrough](https://drive.google.com/file/d/1maKzbPZ9i4VB5gAbV4uHpc1jCFIX1Psn/view?usp=sharing)
