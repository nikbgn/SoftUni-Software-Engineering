SELECT TOP(5)
	   c.CigarName
     , c.PriceForSingleCigar
	 , c.ImageURL
  FROM Cigars AS c
  JOIN Sizes AS s
    ON c.SizeId = s.Id
 WHERE s.[Length] >= 12 
   AND (CHARINDEX('ci',c.CigarName,1) > 0 OR c.PriceForSingleCigar > 50)
   AND s.RingRange > 2.55
 ORDER
    BY c.CigarName ASC, c.PriceForSingleCigar DESC


