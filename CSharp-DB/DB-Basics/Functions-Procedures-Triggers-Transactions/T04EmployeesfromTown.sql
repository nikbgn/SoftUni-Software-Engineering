CREATE PROC usp_GetEmployeesFromTown (@TownName NVARCHAR(MAX))
AS

	SELECT [FirstName],[LastName]
	  FROM 
		   (
		    SELECT e.FirstName, e.LastName, t.[Name]
			  FROM [Employees] AS e
			  JOIN [Addresses] AS a
				ON e.AddressID = a.AddressID
			  JOIN [Towns] AS t
				ON a.TownID = t.TownID
			) AS r
	 WHERE r.[Name] = @TownName
GO

EXEC usp_GetEmployeesFromTown 'Sofia'