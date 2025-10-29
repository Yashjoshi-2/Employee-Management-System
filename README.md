# Employee-Management-System
#  Employee Management System (ASP.NET Core MVC)

A simple **Employee Management System** built using **ASP.NET Core MVC (.NET 8)**.
This project demonstrates basic **CRUD (Create, Read, Update, Delete)** operations for managing employee records — all stored **in memory (no database)** for simplicity.

---

##  Features

*  View list of employees
*  Add a new employee
*  Edit existing employee details
*  Delete an employee
*  View employee details
*  Data stored in-memory (no DB setup required)

---

##  Tech Stack

* **Framework:** .NET 8
* **Language:** C#
* **Frontend:** Razor Views (HTML, CSS)
* **IDE (optional):** Visual Studio Code / Visual Studio
* **Runtime:** ASP.NET Core MVC

---

## ⚙️ Installation Steps

Follow these steps to set up and run the project locally.

### 1. Clone the repository

```bash
git clone https://github.com/<your-username>/EmployeeManagementSystem.git
```

### 2. Navigate to the project folder

```bash
cd EmployeeManagementSystem
```

### 3. Restore dependencies

```bash
dotnet restore
```

### 4. Build the project

```bash
dotnet build
```

### 5. Run the project

```bash
dotnet run
```

### 6. Open in browser

Once the app starts, open your browser and go to:

 **[http://localhost:5000](http://localhost:5031)**


---


##  How It Works

* The app uses an **in-memory list** (`List<Employee>`) inside the controller to store employee records.
* Each CRUD operation updates this list — meaning data resets when the app restarts.
* MVC Pattern:

  * **Model** → `Employee.cs`
  * **View** → Razor `.cshtml` pages
  * **Controller** → `EmployeesController.cs`

---

##  Example Employee Fields

* **Id** — Unique identifier
* **Name** — Employee’s full name
* **Position** — Job title
* **Department** — Department name
* **Salary** — Monthly salary


