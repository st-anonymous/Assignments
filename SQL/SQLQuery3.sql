--1. Write a query to display the orders placed by customer with phone number 1094567890
SELECT * FROM [Order]
WHERE CustomerId = 
(SELECT Id FROM Customer
WHERE Phone = '1094567890');

--2. Fetching all the products which are available under Category ‘Seafood’.
SELECT ProductName FROM Product
WHERE Category = 'Seafood';

--3. Display the orders placed by customers not in Paris
SELECT * FROM [Order]
WHERE CustomerId IN
(SELECT Id FROM Customer
WHERE City NOT IN ('Paris'));

--4. Selects all the order which are placed for the product Studs.
SELECT * FROM [Order]
WHERE Id IN
(SELECT OrderId FROM OrderItem
WHERE ProductId IN
(SELECT Id FROM Product
WHERE ProductName='Studs'));

--5. Write a query to display the name, department name and rating  of any given employee.
--(Not Enough Data)