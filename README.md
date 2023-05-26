# Course Enrollment Management Application
This application helps manage student and teacher information, as well as the registration of course classes for students and the assignment of course classes for teachers.

## Link download file script sql

 - [QLDKHP.sql](https://drive.google.com/file/d/1YFcrwfYU9aNbCFDg0KuvKO6RsgosSfmn/view?usp=sharing)

 ## Features
  General:
- Manage application permissions for students, teachers, and admin.
- View and update personal information of students, teachers, and admin.

 For students:
- Search for course classes.
- Register for course classes.

 For teachers:
- View the list of students in their assigned course classes.
- Register for teaching courses.

 For admin:
- Perform various administrative functions, such as adding, modifying, and deleting student, teacher, and course class records.
- Define regulations and policies.
- Assign teaching responsibilities to teachers.
## Run Locally

Clone the project

```bash
  git clone https://github.com/Bang1710/CourseEnrollmentManagementApplication.git
```

Go to the project directory

```bash
  cd my-project
```
Open the DataConnection.cs file in your project.

Locate the "connectionString" section in the App.config file.

Modify the value of the "connectionString" property to a new connection string that matches your machine. For example:

```bash
  public DataConnection() {
            connectionString = "Data Source = ASUSVB\\ASUSVBSQLSERVER ; Initial Catalog=HeThongDangKyHocPhan; user id = MyASUS; pwd=17102002; Integrated Security = true";
        }
```

Run project
```bash
  Select IIS Express on Visual Studio
```
 
## Tech Stack

C#, Windows Form, ADO.NET, SQL Server


## Account demo
 Student:
- Username: sv001
- Login password: 17102002
- Account type: Student
  
 Teacher:
- Username: gv001
- Login password: 1111
- Account type: Lecturer

 Admin:
- Username: admin01
- Login password: 1122
- Account type: Admin

## Demo

link to demo: [demo](https://drive.google.com/drive/folders/1zFuNOU-P4rb8Am1elXswM473-mRD45yf)

## Authors

- [Văn Bang](https://github.com/Bang1710)


## Feedback

If you have any feedback, please reach out to us at nvbang1710@gmail.com


## 🚀 About Me
I'm a ... loading



