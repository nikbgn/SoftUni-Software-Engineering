/*
Pattern -> ***.1^.^.***
Legend: * - one symbol, ^ - one or more symbols
*/


SELECT [Username]
     , [IpAddress]
  FROM [Users]
  WHERE [IpAddress] LIKE '___.1_%._%.___'
  ORDER BY [Username]
  
