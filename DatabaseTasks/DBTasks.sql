
-- COMPANY DATABASE
-- SQL Server Implementation



-- PART 1 - DATABASE CREATION


CREATE DATABASE CompanyDB;
GO

USE CompanyDB;
GO


--  TABLE CREATION
-- 1. DEPARTMENT TABLE


CREATE TABLE Department1
(
    DeptNumber INT PRIMARY KEY,
    Name VARCHAR(50) NOT NULL UNIQUE,
    NumberOfEmployees INT NOT NULL DEFAULT 0
        CHECK (NumberOfEmployees >= 0),

    ManagerSsn CHAR(9) NULL,
    ManagerStartDate DATE NULL
);
GO


-- 2. EMPLOYEE TABLE

CREATE TABLE Employee1
(
    Ssn CHAR(9) PRIMARY KEY,

    Fname VARCHAR(30) NOT NULL,
    Minit CHAR(1) NULL,
    Lname VARCHAR(30) NOT NULL,

    Address VARCHAR(100) NOT NULL,

    Sex CHAR(1) NOT NULL
        CHECK (Sex IN ('M', 'F')),

    Bdate DATE NOT NULL,

    Salary DECIMAL(10,2) NOT NULL
        CHECK (Salary > 0),

    DepartmentNumber INT NOT NULL,

    SupervisorSsn CHAR(9) NULL,

    -- Employee belong to a Department
    CONSTRAINT FK_Employee_Department
        FOREIGN KEY (DepartmentNumber)
        REFERENCES Department(DeptNumber),

    -- SUPERVISION relationship
    CONSTRAINT FK_Employee_Supervisor
        FOREIGN KEY (SupervisorSsn)
        REFERENCES Employee(Ssn)
);
GO



-- 3. DEPARTMENT MANAGER FOREIGN KEY

ALTER TABLE Department
ADD CONSTRAINT FK_Department_Manager
    FOREIGN KEY (ManagerSsn)
    REFERENCES Employee(Ssn);
GO


-- 4. DEPARTMENT LOCATIONS TABLE

CREATE TABLE Department_Location1
(
    DeptNumber INT NOT NULL,
    Location VARCHAR(50) NOT NULL,

    PRIMARY KEY (DeptNumber, Location),

    CONSTRAINT FK_DepartmentLocation_Department
        FOREIGN KEY (DeptNumber)
        REFERENCES Department(DeptNumber)
        ON DELETE CASCADE
);
GO



-- 5. PROJECT TABLE

CREATE TABLE Project1
(
    ProjectNumber INT PRIMARY KEY,

    Name VARCHAR(50) NOT NULL UNIQUE,

    Location VARCHAR(50) NOT NULL,

    ControllingDepartmentNumber INT NOT NULL,

    CONSTRAINT FK_Project_Department
        FOREIGN KEY (ControllingDepartmentNumber)
        REFERENCES Department(DeptNumber)
);
GO



-- 6. WORKS_ON TABLE


CREATE TABLE Works_On1
(
    EmployeeSsn CHAR(9) NOT NULL,
    ProjectNumber INT NOT NULL,

    Hours DECIMAL(5,2) NOT NULL
        CHECK (Hours >= 0),

    PRIMARY KEY (EmployeeSsn, ProjectNumber),

    CONSTRAINT FK_WorksOn_Employee
        FOREIGN KEY (EmployeeSsn)
        REFERENCES Employee(Ssn),

    CONSTRAINT FK_WorksOn_Project
        FOREIGN KEY (ProjectNumber)
        REFERENCES Project(ProjectNumber)
);
GO


-- 7. DEPENDENT TABLE

CREATE TABLE Dependent1
(
    EmployeeSsn CHAR(9) NOT NULL,

    Name VARCHAR(50) NOT NULL,

    Sex CHAR(1) NOT NULL
        CHECK (Sex IN ('M', 'F')),

    Birthdate DATE NOT NULL,

    Relationship VARCHAR(30) NOT NULL,

    PRIMARY KEY (EmployeeSsn, Name),

    CONSTRAINT FK_Dependent_Employee
        FOREIGN KEY (EmployeeSsn)
        REFERENCES Employee(Ssn)
);
GO



-- PART 3 - INSERT OPERATIONS

-- INSERT 1 - Departments


INSERT INTO Department
    (DeptNumber, Name, NumberOfEmployees)
VALUES
    (1, 'Research', 3),
    (2, 'Administration', 2),
    (3, 'IT', 2);
GO



-- INSERT 2 - Employees

-- First insert employees without supervisors
INSERT INTO Employee
    (Ssn, Fname, Minit, Lname, Address, Sex, Bdate,
     Salary, DepartmentNumber, SupervisorSsn)
VALUES
    ('111111111', 'John', 'A', 'Smith',
     'Muscat, Oman', 'M', '1985-05-10',
     90000.00, 1, NULL),

    ('222222222', 'Sarah', 'B', 'Ahmed',
     'Muscat, Oman', 'F', '1990-03-15',
     70000.00, 1, NULL),

    ('333333333', 'Ali', 'C', 'Hassan',
     'Rustaq, Oman', 'M', '1992-08-20',
     60000.00, 1, NULL),

    ('444444444', 'Mariam', 'D', 'Salim',
     'Muscat, Oman', 'F', '1988-11-25',
     65000.00, 2, NULL),

    ('555555555', 'Khalid', 'E', 'Said',
     'Sohar, Oman', 'M', '1995-01-12',
     55000.00, 2, NULL),

    ('666666666', 'Aisha', 'F', 'Omar',
     'Sohar, Oman', 'F', '1993-07-30',
     68000.00, 3, NULL),

    ('777777777', 'Omar', 'G', 'Nasser',
     'Sohar, Oman', 'M', '1996-09-18',
     50000.00, 3, NULL);
GO


-- INSERT 3 - Supervisors

UPDATE Employee
SET SupervisorSsn = '111111111'
WHERE Ssn = '333333333';

UPDATE Employee
SET SupervisorSsn = '444444444'
WHERE Ssn = '555555555';

UPDATE Employee
SET SupervisorSsn = '666666666'
WHERE Ssn = '777777777';
GO



-- INSERT 4 - Department Managers

UPDATE Department
SET ManagerSsn = '111111111',
    ManagerStartDate = '2020-01-01'
WHERE DeptNumber = 1;

UPDATE Department
SET ManagerSsn = '444444444',
    ManagerStartDate = '2021-06-01'
WHERE DeptNumber = 2;

UPDATE Department
SET ManagerSsn = '666666666',
    ManagerStartDate = '2022-03-15'
WHERE DeptNumber = 3;
GO


-- INSERT 5 - Department Locations


INSERT INTO Department_Location
    (DeptNumber, Location)
VALUES
    (1, 'Muscat'),
    (1, 'Nizwa'),
    (2, 'Muscat'),
    (3, 'Sohar');
GO


-- INSERT 6 - Projects

INSERT INTO Project
    (ProjectNumber, Name, Location, ControllingDepartmentNumber)
VALUES
    (101, 'AI Research', 'Muscat', 1),
    (102, 'ERP Implementation', 'Nizwa', 2),
    (103, 'Network Upgrade', 'Sohar', 3);
GO


-- INSERT 7 - Works_On

INSERT INTO Works_On
    (EmployeeSsn, ProjectNumber, Hours)
VALUES
    ('111111111', 101, 20.00),
    ('222222222', 101, 15.00),
    ('333333333', 101, 10.00),
    ('444444444', 102, 25.00),
    ('666666666', 103, 30.00);
GO



-- INSERT 8 - Dependents

INSERT INTO Dependent
    (EmployeeSsn, Name, Sex, Birthdate, Relationship)
VALUES
    ('111111111', 'Adam Smith', 'M', '2015-04-10', 'Son'),
    ('111111111', 'Lina Smith', 'F', '2018-09-20', 'Daughter'),
    ('444444444', 'Noor Salim', 'F', '2016-02-14', 'Daughter');
GO



-- PART 3 - UPDATE OPERATIONS
-- UPDATE 1 - Give an employee a raise


UPDATE Employee
SET Salary = Salary + 5000
WHERE Ssn = '333333333';
GO

-- UPDATE 2 - Reassign an employee to another department

UPDATE Employee
SET DepartmentNumber = 3
WHERE Ssn = '222222222';
GO



-- UPDATE 3 - Change a project's location


UPDATE Project
SET Location = 'Muscat'
WHERE ProjectNumber = 102;
GO



-- UPDATE 4 - Update hours worked


UPDATE Works_On
SET Hours = 25.00
WHERE EmployeeSsn = '111111111'
  AND ProjectNumber = 101;
GO



-- UPDATE 5 - Correct a dependent's relationship


UPDATE Dependent
SET Relationship = 'Daughter'
WHERE EmployeeSsn = '111111111'
  AND Name = 'Lina Smith';
GO



-- PART 3 - DELETE OPERATIONS

-- DELETE 1
-- Delete a dependent

DELETE FROM Dependent
WHERE EmployeeSsn = '111111111'
  AND Name = 'Adam Smith';
GO


-- DELETE 2

-- 1. Works_On
-- 2. Dependent
-- Then delete Employee


DELETE FROM Works_On
WHERE EmployeeSsn = '333333333';

DELETE FROM Dependent
WHERE EmployeeSsn = '333333333';

DELETE FROM Employee
WHERE Ssn = '333333333';
GO



-- VERIFICATION QUERIES


SELECT * FROM Department;

SELECT * FROM Employee;

SELECT * FROM Department_Location;

SELECT * FROM Project;

SELECT * FROM Works_On;

SELECT * FROM Dependent;
GO