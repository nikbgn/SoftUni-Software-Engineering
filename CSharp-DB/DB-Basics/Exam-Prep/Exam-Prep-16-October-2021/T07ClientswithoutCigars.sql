SELECT c.Id, CONCAT(c.FirstName,' ',c.LastName) AS [ClientName], c.Email
  FROM Clients AS c
  LEFT
  JOIN ClientsCigars AS cc
    ON c.Id = cc.ClientId 
  LEFT
  JOIN Cigars AS cig
    ON cc.CigarId = cig.Id
 WHERE cc.ClientId IS NULL
 ORDER
    BY c.FirstName 