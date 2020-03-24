Create Schema Emp;
Go

Create Table Emp.Department(
	DepartmentId Int Not Null Primary Key Identity,
	Name VarChar(30) Not Null,
	Location VarChar(30)
);

Create Table Emp.Employee(
	EmployeeId Int Not Null Primary Key Identity,
	FirstName VarChar(15) Not Null,
	LastName VarChar(15) Not Null,
	SSN Numeric(9),
	DeptId Int Foreign Key References Emp.Department(DepartmentId)
);

Create Table Emp.EmpDetails(
	EmpDetailId Int Not null Primary Key Identity,
	EmployeeId Int Not Null Foreign Key References Emp.Employee(EmployeeId),
	Salary Money,
	Address1 VarChar(30),
	Address2 VarChar(30),
	City VarChar(30),
	State VarChar(20),
	Country VarChar(20)
);


Insert Into Emp.Department(Name, Location) Values('Marketing','Business Bldg');
Insert Into Emp.Department(Name, Location) Values('Technical Support','CS Bldg');
Insert Into Emp.Department(Name, Location) Values('Management','HQ');

Insert Into Emp.Employee(FirstName, LastName, SSN, DeptId) Values ('Tina','Smith',123456789,1);
Insert Into Emp.Employee(FirstName, LastName, SSN, DeptId) Values ('Jacob','Lannery',123456780,2);
Insert Into Emp.Employee(FirstName, LastName, SSN, DeptId) Values ('John','Mclain',123456789,3);
Insert Into Emp.Employee(FirstName, LastName, SSN, DeptId) Values ('Maria','Smith',123456789,1);

Insert Into Emp.EmpDetails(EmployeeId, Salary, Address1, City) Values (1, 40000, '123 Street', 'Springfield');
Insert Into Emp.EmpDetails(EmployeeId, Salary, Address1, City) Values (2, 39000, '123 Street', 'Springfield');
Insert Into Emp.EmpDetails(EmployeeId, Salary, Address1, City) Values (3, 43000, '123 Street', 'Springfield');
Insert Into Emp.EmpDetails(EmployeeId, Salary, Address1, City) Values (7, 38000, '123 Street', 'Springfield');


Select * From Emp.Employee As em
Inner Join Emp.Department As dep On em.DeptId = dep.DepartmentId
Where dep.Name = 'Marketing';

Select dep.Name, SUM(Salary) As TotalSalary From Emp.Employee As em
Inner Join Emp.Department As dep On em.DeptId = dep.DepartmentId
Inner Join Emp.EmpDetails As emd On em.DeptId = emd.EmployeeId 
Where dep.Name = 'Marketing'
Group By dep.Name;

Select dep.Name, Count(EmployeeId) As NumberOfEmployees
From Emp.Employee as em
Inner Join Emp.Department As dep On em.DeptId = dep.DepartmentId
Group By dep.Name;

Update Emp.EmpDetails Set Salary = 90000.00 Where EmployeeId = 1;

Select * From Emp.EmpDetails As ed
Inner Join Emp.Employee As em On ed.EmployeeId = em.EmployeeId;