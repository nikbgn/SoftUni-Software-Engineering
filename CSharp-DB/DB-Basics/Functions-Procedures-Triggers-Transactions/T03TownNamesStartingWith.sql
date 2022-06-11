CREATE PROC usp_GetTownsStartingWith (@startLetter NVARCHAR(MAX))
AS
	SELECT [Name] AS [Town]
	  FROM [Towns]
	 WHERE LEFT([Name],LEN(@startLetter)) = @startLetter
GO

EXEC usp_GetTownsStartingWith 'bell'