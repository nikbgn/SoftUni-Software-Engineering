UPDATE [Employees]
SET Salary = Salary + Salary * 0.10
WHERE [Employees].Salary >= 0

SELECT [Salary] 
FROM [Employees]