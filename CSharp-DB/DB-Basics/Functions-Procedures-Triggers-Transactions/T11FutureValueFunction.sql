CREATE OR ALTER FUNCTION ufn_CalculateFutureValue (@sum DECIMAL(8,4), @yearlyInterestRate FLOAT, @numOfYears INT)
RETURNS DECIMAL (8,4)
AS
BEGIN
	DECLARE @result DECIMAL(8,4) = @sum * (POWER((1+@yearlyInterestRate),@numOfYears))
	RETURN @result
END

SELECT dbo.ufn_CalculateFutureValue(1000,0.1,5)