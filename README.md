# Task Management Application

## 📌 Overview
This is a Task Management Application built using ASP.NET Core Web API and Angular.
The application allows users to perform CRUD operations on tasks.

---

## 🎯 Features
- Create Task
- View Tasks
- Update Task
- Delete Task
- Search Task

---

## 🏗️ Technology Stack
- Backend: ASP.NET Core Web API
- Frontend: Angular
- Database: SQL Server
- ORM: Entity Framework Core

---

## 🗄️ Database Design

### Tables:
#### Task Table
| Column Name       | Data Type     |
|------------------|--------------|
| Id               | int (PK)     |
| Title            | varchar      |
| Description      | varchar      |
| DueDate          | datetime     |
| Status           | varchar      |
| Remarks          | varchar      |
| CreatedOn        | datetime     |
| UpdatedOn        | datetime     |

---

### ER Diagram
(Add screenshot here)

---

### Data Dictionary
Explain each column briefly.

---

### Indexes
- Primary Key on Id
- Index on DueDate (optional)

---

### Approach
**Code First Approach** used because:
- Easy to maintain
- Fast development

---

## 🏛️ Application Structure

- Frontend: Angular SPA
- Backend: REST API

---

## 🎨 Frontend Structure
- Angular Reactive Forms used
- API integration via HttpClient

---

## ⚙️ Build & Run Instructions

### Backend
```bash
dotnet restore
dotnet build
dotnet run
