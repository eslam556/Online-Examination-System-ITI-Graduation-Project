# 📝 ONLINE EXAMINATION DATABASE SYSTEM

### 📅 July 13, 2025  
### 🏢 Information Technological Institute  
### 🎓 Power BI Development Track

---

## 👥 Team Members
- Mohamed Saeed  
- Eslam Mohamed  
- Kareem Emad  
- Mohamed Ahmed  

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

The development followed a systematic data pipeline:

1. **Date Dimension Generation**: Calendar attributes populated for academic periods.  
2. **ETL Process (SSIS)**: Operational data extracted, cleaned, and loaded into a Data Mart.  
3. **Data Mart Creation**: Star schema with dimensions for analysis and reporting.  
4. **SSRS Reports**: Built to visualize academic performance and certificate distribution.  
5. **Desktop Application (C#)**: Enables staff to manage exams, questions, and results.  
6. **Web Application (Bolt AI)**: Allows students to register, take exams, and view results.

![Project Workflow](https://github.com/eslam556/Online-Examination-Database-System/blob/main/Project%20Workflow.jpg)

---

## 🧩 ER Diagram

The ER diagram maps the academic ecosystem, defining relationships between entities:

- **One-to-Many**: Course → Exams  
- **One-to-Many**: Student → Grades  
- **One-to-Many**: Instructor → Courses  
- **One-to-Many**: Exam → Questions  
- **Many-to-Many**: Students ↔ Exams (via Grades)

![ER Diagram](https://github.com/eslam556/Online-Examination-Database-System/blob/main/Database/ERD.jpg)

---

## 🔗 Logical Mapping

The logical schema models real-world academic logic:

- `Students` ←→ `Grades`: Tracks student results  
- `Exams` ←→ `Questions` ←→ `Choices`: Defines exam content  
- `Departments`, `Branches`, and `Courses` are linked by hierarchy  
- `Certificates` issued based on performance  
- `Freelancing` table links companies to eligible certified students  

![Mapping](https://github.com/eslam556/Online-Examination-Database-System/blob/main/Database/Mapping.jpg)

---

## 🛠️ Database Implementation

Developed using **SQL Server**, the schema includes:

- Tables: `Students`, `Courses`, `Exams`, `Questions`, `Choices`, `Grades`, `Certificates`, `Instructors`, `Freelancing`, etc.  
- Integrity: All relationships enforced with primary and foreign keys  
- Optimized: Indexed and normalized for high performance

![Database Diagram](https://github.com/eslam556/Online-Examination-Database-System/blob/main/Database/Database%20Diagram.jpg)

---

## 🧱 Data Mart (Star Schema)

The Data Mart supports institutional analytics and reporting.

### Dimension Tables
- **Dim_Student**: Basic info, department, branch  
- **Dim_Course**: Course name, code, department  
- **Dim_Exam**: Date, duration, type  
- **Dim_Instructor**: Name, assigned courses  
- **Dim_Date**: Academic year, term, week

### Fact Table
- **Fact_ExamResults**: Holds exam results, scores, pass/fail status, certificate eligibility

![Data Mart Diagram](https://github.com/eslam556/Online-Examination-Database-System/blob/main/Data%20Mart/Data%20Mart%20Model.png)

---

## 🧪 SSIS (SQL Server Integration Services)

**SSIS** was used to create robust ETL pipelines that:

- Extract raw data from OLTP systems  
- Clean, standardize, and apply business logic  
- Load data into the star schema for reporting  
- Schedule updates and enforce data consistency

![ETL Pipeline](https://github.com/eslam556/Online-Examination-Database-System/blob/main/SSIS/ETL%20Pipeline.jpg)

---

## 📈 Database Reporting (SSRS)

Built with **SSRS**, reports include:

- **Student Grade Reports**: Per course, term, or department  
- **Exam Analysis Reports**: Difficulty trends and average performance  
- **Certificate Distribution**: Monitor how many and where certificates were issued  
- **Freelancing Matches**: Track job eligibility by certification  

Reports support drill-down, filters, and export options for institutional use.

---

## 💻 Desktop Application (C#)

A powerful admin tool developed in **C#** for:

- Managing student records and course registrations  
- Creating and assigning exams  
- Inserting questions and choices  
- Grading exams and issuing certificates  
- Viewing student performance history

The desktop app is role-based, supporting secure access for instructors and academic staff.

---

## 🌐 Web Application (Bolt AI)

The **Bolt AI** web app provides a user-friendly interface for students.

### ✅ Purpose

Simulate an online examination experience with instant scoring and certificate issuance.

### ⚙️ Key Features

- **Student Sign-Up/Login**  
  - Email & ID verification  
  - Select branch/department  

- **Exam Interface**  
  - View assigned exams  
  - Timer-enabled question navigation  
  - MCQ/TF support  

- **Results & Certificates**  
  - Score and feedback after submission  
  - Downloadable certificate if passed  

### 🔌 Backend Integration

- Fetch exams for student  
- Insert answers and compute score  
- Save grades, generate certificate  
- Connect certified students with freelance jobs  

## [App Walkthrough](https://drive.google.com/file/d/1XYZabcEXAMPLEDemo/view?usp=sharing)

---

## 🔮 Conclusion & Future Enhancements

This project delivers a robust online examination system for modern educational needs. Planned enhancements include:

- Proctored exam sessions with live monitoring  
- Instructor dashboard for content management  
- AI-generated adaptive testing  
- Integration with employer dashboards for student hiring
