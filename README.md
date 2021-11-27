# Employee CRUDO perations

## Requirements
* Visual Studio
* Sql Server Management Studio
* IIS Express 
* .NET Framework 4.7.2
* Entity Framework 6

## Setting up the database
* Download Sql Server Management Studio.
* Open the Sql Server Management Studio and create a new connection to the local database.
* In the Server Name type **(LocalDb)\MSSQLLocalDB** and select Windows Authentication.
* Next, create a new query using the following script, execute it to setup your database.

````
create database employeeDB
GO
use employeeDB
GO
create table employees(empID int, empName varchar(20), empPhNo varchar(10), empEmail varchar(30) , empAdd varchar(30))
GO
INSERT INTO employees values(101, 'henry','1234567890', 'henry123@gmail.com', 'A/123 Los Santos')
GO
SELECT * FROM employees;
GO
ALTER TABLE employees ALTER COLUMN empID varchar(20) NOT NULL
GO
ALTER TABLE employees ADD PRIMARY KEY (empID)
````

## How to execute the project
* Clone the project
* Open EmployeeCRUDOperations.sln
* Goto View -> Solution Explorer and Right-Click on the Solution EmployeeCRUDOperations.
* Select Set Startup Projects. 
* A new wizard will get open, select multiple startup project and set Client and Server as startup projects.
* Start the project. Enjoy!!
