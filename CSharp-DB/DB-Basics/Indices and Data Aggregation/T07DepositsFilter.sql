SELECT * FROM
(SELECT [DepositGroup], SUM([DepositAmount]) AS [TotalSum]
  FROM [WizzardDeposits]
 WHERE [MagicWandCreator] = 'Ollivander family'
 GROUP
    BY [DepositGroup]) AS temp
WHERE temp.TotalSum < 150000
ORDER BY temp.TotalSum DESC
