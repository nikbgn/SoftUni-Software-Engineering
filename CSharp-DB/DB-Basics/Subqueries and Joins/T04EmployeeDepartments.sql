SELECT e.EmployeeID, e.FirstName, e.Salary, d.[Name] AS [DepartmentName]
  FROM [Employees] AS e
  JOIN [Departments] AS d
  