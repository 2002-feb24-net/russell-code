-- 1. List all customers (full names, customer ID, and country) who are not in the US
Select FirstName, LastName, CustomerId, Country
From Customer
Where Country != 'USA'
Order By Country;

-- 2. List all customers from brazil
Select *
From Customer
Where Country = 'Brazil';

-- 3. List all sales agents
Select *
From Employee
Where Title = 'Sales Support Agent';

-- 4. Show a list of all countries in billing addresses on invoices.
Select Distinct BillingCountry, BillingAddress
From Invoice
Order By BillingCountry;

-- 5. How many invoices were there in 2009, and what was the sales total for that year?
Select Count(InvoiceDate) As NumOfInvoices, Sum(Total) As SalesTotal
From Invoice
Where DatePart(yy, InvoiceDate) = 2009;

-- 6. How many line items were there for invoice #37?
Select Count(InvoiceLineId) As Invoice37
From InvoiceLine
Where InvoiceId = 37;

-- 7. How many invoices per country?
Select BillingCountry, Count(InvoiceId) As NumOfInvoices
From Invoice
Group By BillingCountry;

-- 8. Show total sales per country, ordered by highest sales first.
Select BillingCountry, Count(*) As NumOfSales, Sum(Total) As SalesTotals
From Invoice
Group By BillingCountry
Order By Count(*) Desc;

Select * From Track;