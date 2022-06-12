CREATE PROC usp_GetHoldersWithBalanceHigherThan (@balance MONEY)
AS
BEGIN
	SELECT ah.FirstName,ah.LastName
	  FROM [AccountHolders] AS ah
	  JOIN [Accounts] AS a
	    ON a.AccountHolderId = ah.Id
	 GROUP
	    BY ah.FirstName,ah.LastName
	HAVING SUM(Balance) > @balance
	 ORDER
	    BY ah.FirstName,ah.LastName
END



EXEC usp_GetHoldersWithBalanceHigherThan 1000