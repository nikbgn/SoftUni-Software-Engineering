SELECT mc.CountryCode, COUNT(m.MountainRange) AS [MountainRanges]
  FROM [Mountains] AS m
  JOIN [MountainsCountries] AS mc
    ON mc.MountainId = m.Id
  JOIN [Countries] AS c
    ON c.CountryCode = mc.CountryCode
 WHERE c.CountryCode IN ('RU','BG','US')
 GROUP
    BY mc.CountryCode
