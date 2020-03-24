-- 1. which artists did not make any albums at all?
Select ArtistId From Artist
Except
Select ArtistId From Album;
 
SELECT ArtistId From Artist
WHERE ArtistId NOT IN (SELECT ArtistId FROM Album);

-- 2. which artists did not record any tracks of the Latin genre?
Select ArtistId From Artist
Except
Select Artist.ArtistId From Artist
Inner Join Album On Artist.ArtistId = Album.AlbumId
Inner Join Track On Album.AlbumId = Track.AlbumId
Inner Join Genre On Track.GenreId = Genre.GenreId
Where Genre.Name = 'Latin';


-- 3. which video track has the longest length? (use media type table)
Select MediaType.MediaTypeId, MAX(Track.Milliseconds) From MediaType
Inner Join Track On MediaType.MediaTypeId = Track.MediaTypeId
Where MediaType.Name = '%video%'
Group By MediaType.MediaTypeId;


Select MediaTypeId, Sum(Milliseconds) From Track Group By MediaTypeId;


-- 4. find the names of the customers who live in the same city as the
--    boss employee (the one who reports to nobody)
-- 5. how many audio tracks were bought by German customers, and what was
--    the total price paid for them?
-- 6. list the names and countries of the customers supported by an employee
--    who was hired younger than 35.

