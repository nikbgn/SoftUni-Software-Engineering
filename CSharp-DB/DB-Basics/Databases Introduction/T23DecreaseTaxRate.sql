UPDATE [Payments]
SET [TaxRate] -= [TaxRate]*0.03
WHERE TaxRate IS NOT NULL

SELECT [TaxRate]
FROM [Payments]