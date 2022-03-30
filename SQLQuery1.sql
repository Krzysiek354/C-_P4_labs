SELECT *
FROM Territories as t inner join Region as r on t.RegionID=r.RegionID
WHERE t.TerritoryDescription like 'E%'