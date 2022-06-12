CREATE PROC usp_CalculateFutureValueForAccount (@AccountID INT, @yearlyInterestRate FLOAT)
AS
BEGIN

	SELECT a.Id AS [Account Id]
		 , ah.FirstName AS [First Name]
		 , ah.LastName AS [Last Name]
		 , a.Balance AS [Current Balance]
		 , dbo.ufn_CalculateFutureValue(a.Balance,@yearlyInterestRate,5) AS [Balance in 5 Years]
	  FROM [Accounts] AS a
	  JOIN [AccountHolders] AS ah
	    ON a.AccountHolderId = ah.Id
	 WHERE a.Id = @AccountID

END

GO
EXEC usp_CalculateFutureValueForAccount 1, 0.1