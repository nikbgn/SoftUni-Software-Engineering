SELECT [EmployeeID], [JobTitle], [e].[AddressID]
  FROM [Employees] AS [e]
LEFT JOIN [Addresses] AS [a]
	ON [e].[AddressID] = [a].[AddressID]
