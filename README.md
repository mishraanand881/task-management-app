# 🗂️ Task Management System

## 📌 Project Overview

This project is a **Task Management System** developed using **ASP.NET Core Web API** and **Angular**.
It allows users to manage tasks with full **CRUD (Create, Read, Update, Delete)** operations and search functionality.

---

## 🎯 Objective

The main objective of this project is to demonstrate:

* Full-stack development skills
* Understanding of MVC architecture
* Database design and integration
* API development and frontend integration

---

## 🛠️ Tech Stack

### 🔹 Backend

* ASP.NET Core Web API
* Entity Framework Core

### 🔹 Frontend

* Angular

### 🔹 Database

* SQL Server

---

## 📂 Project Structure

### Backend

* Controllers → API endpoints
* Services → Business logic
* Models → Data structure
* Data → DbContext

### Frontend

* Components → UI
* Services → API calls

---

## 🗄️ Database Design

### 📋 Table: Tasks

| Column Name | Data Type | Description      |
| ----------- | --------- | ---------------- |
| Id          | INT       | Primary Key      |
| Title       | NVARCHAR  | Task Title       |
| Description | NVARCHAR  | Task Details     |
| DueDate     | DATETIME  | Due Date         |
| Status      | NVARCHAR  | Task Status      |
| Remarks     | NVARCHAR  | Additional Notes |
| CreatedOn   | DATETIME  | Created Date     |
| UpdatedOn   | DATETIME  | Updated Date     |
| CreatedBy   | NVARCHAR  | Creator          |
| UpdatedBy   | NVARCHAR  | Last Modifier    |

---

## 🧩 ER Diagram (Text Format)

User → creates → Tasks
Tasks → contains → Title, Description, Status, Dates

---

## 🔁 Features

* ✅ Create Task
* ✅ View All Tasks
* ✅ Update Task
* ✅ Delete Task
* ✅ Search Task

---

## ⚙️ API Endpoints

| Method | Endpoint                   | Description    |
| ------ | -------------------------- | -------------- |
| GET    | /api/tasks                 | Get all tasks  |
| GET    | /api/tasks/{id}            | Get task by ID |
| POST   | /api/tasks                 | Create task    |
| PUT    | /api/tasks/{id}            | Update task    |
| DELETE | /api/tasks/{id}            | Delete task    |
| GET    | /api/tasks/search?keyword= | Search task    |

---

## 🔧 Setup Instructions

### 🗄️ Database Setup

1. Open SQL Server
2. Run the provided SQL script

---

### ▶️ Backend Setup

1. Open project in Visual Studio
2. Update connection string in `appsettings.json`
3. Run commands:

```
Add-Migration InitialCreate
Update-Database
```

4. Run project

---

### 🌐 Frontend Setup

1. Navigate to frontend folder
2. Run:

```
npm install
ng serve
```

3. Open browser:

```
http://localhost:4200
```

---

## 🔌 API Integration

Angular frontend communicates with backend using HTTP services.

---

## 📌 Assumptions

* User is familiar with Angular and .NET
* SQL Server is installed locally
* API runs on localhost

---

## ⚠️ Constraints

* No authentication implemented
* Single user system





## 📎 Conclusion

This project demonstrates a complete full-stack implementation using modern technologies and best practices.
