-- 1. show all invoices of customers from brazil (mailing address not billing)
Select *
From Customer
Inner Join Invoice On Customer.CustomerId = Invoice.CustomerId  
Where Country = 'Brazil';

-- 2. show all invoices together with the name of the sales agent of each one
Select *
From Employee
Cross Join Invoice
Where Title = 'Sales Support Agent';

-- 3. show all playlists ordered by the total number of tracks they have
SELECT PlayList.PlayListId, Name, Count(Track.TrackId)
From Playlist
Inner Join PlayListTrack On Playlist.PlaylistId = PlaylistTrack.PlaylistId
Inner Join Track On PlaylistTrack.TrackId = Track.TrackId
Group By PlayList.PlaylistId
Order By 

-- 4. which sales agent made the most in sales in 2009?
-- 5. how many customers are assigned to each sales agent?
-- 6. which track was purchased the most since 2010?
-- 7. show the top three best-selling artists.
-- 8. which customers have the same initials as at least one other customer?