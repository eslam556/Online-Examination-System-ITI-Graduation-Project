# 📝 ONLINE EXAMINATION DATABASE SYSTEM

### 📅 July 13, 2025  
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

Three dedicated star schema data marts were created to serve targeted analytical needs:

---

### 📊 1. Student Analytics Data Mart

Focuses on individual student behavior and academic outcomes. Useful for tracking performance, dropout rates, and certificate generation trends.

- **Dim_Student**: Personal details, department, branch, and demographic info  
- **Dim_Date**: Academic terms and exam dates  
- **Dim_Certificate**: Issued certificates with type and status  
- **Fact_StudentPerformance**: Stores total exams taken, passed/failed status, average scores, and certificate eligibility

📷  
![Student Data Mart](https://github.com/eslam556/Online-Examination-Database-System/blob/main/Data%20Mart/Student%20Analytics%20Mart.png)

---

### 📚 2. Course & Exam Analytics Data Mart

Designed to analyze course difficulty, question design, and exam outcomes across instructors and departments.

- **Dim_Course**: Title, department, level  
- **Dim_Exam**: Duration, type, total questions  
- **Dim_Instructor**: Instructor names and assignments  
- **Dim_Date**: Exam sessions and deadlines  
- **Fact_CourseExamStats**: Captures course pass rates, average scores, and number of attempts per course

📷  
![Course Exam Data Mart](https://github.com/eslam556/Online-Examination-Database-System/blob/main/Data%20Mart/Course%20Exam%20Analytics%20Mart.png)

---

### 🏫 3. Institutional Performance Data Mart

Provides high-level performance indicators for academic institutions, supporting strategic decisions by stakeholders.

- **Dim_Branch**: Institution locations and codes  
- **Dim_Department**: Academic departments and programs  
- **Dim_Date**: Academic years and terms  
- **Fact_InstitutionalKPIs**: Tracks metrics such as average scores per department, number of certified students, and exam participation rates

📷  
![Institutional Data Mart](https://github.com/eslam556/Online-Examination-Database-System/blob/main/Data%20Mart/Institutional%20Performance%20Mart.png)

---

Each data mart was used independently in **Power BI** to generate focused dashboards, enabling deep insight into specific academic KPIs.

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
