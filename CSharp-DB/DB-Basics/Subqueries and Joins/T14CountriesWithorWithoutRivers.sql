SELECT TOP(5) c.CountryName, r.RiverName
  FROM [Rivers] AS r
  LEFT
  JOIN [CountriesRivers] AS cr
    ON r.Id = cr.RiverId 
 RIGHT
  JOIN [Countries] AS c
    ON cr.CountryCode = c.CountryCode
 WHERE c.ContinentCode = 'AF'
 ORDER
    BY c.CountryName


