   SELECT Id,
          [Name],
          Size 
     FROM Files
    WHERE Size > 1000 AND [Name] LIKE '%html%'
 ORDER BY Size DESC, Id, [Name]