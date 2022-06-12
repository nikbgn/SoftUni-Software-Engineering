CREATE OR ALTER FUNCTION ufn_IsWordComprised(@setOfLetters NVARCHAR(MAX),@word NVARCHAR(MAX))
RETURNS BIT AS
BEGIN
	DECLARE @count INT = 1;
	DECLARE @currLetter NVARCHAR(1);
	WHILE @count <= LEN(@word)
	BEGIN
		--Set current letter
		SET @currLetter = SUBSTRING(@word,@count,1)
		--Try to find current letter in set of letters, on failure return false
		IF(CHARINDEX(@currLetter,@setOfLetters) <= 0) RETURN 0
		SET @count += 1;
	END
	--If the while loop finished without failure, we found that the word is comprised in the set of letters
	RETURN 1

END

GO

SELECT dbo.ufn_IsWordComprised('oistmiahf','Sofia') AS [Result]