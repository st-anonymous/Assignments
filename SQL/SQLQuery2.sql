--1. Display Details of customer whose country is Germany
SELECT * FROM Customer
WHERE Country = 'Germany';

--2. Display Fullname of Customers
SELECT FirstName + ' ' + LastName AS FullName FROM Customer;

--3. Display the Customer details who has a fax Number
--(Not mentioned about fax Number)

--4. Display the Customer details whose name holds second letter as u
SELECT * FROM Customer
WHERE FirstName LIKE '_u%';

--5. Select order details where unitprice is greater than 10 and less than 20
SELECT * FROM [Order]
WHERE Id IN
(SELECT OrderId FROM OrderItem
WHERE UnitPrice>10 AND UnitPrice<20)

--6. Display order details contaning a shipping date & arrange the order by date.
--(No Mention about Shipping Date)

--7. (Shipment Details not provided)

--8. (Supplier Details not Provided)

--9. Print Average quantiny ordered for every product
SELECT
(SELECT ProductName FROM Product
WHERE Product.Id = OrderItem.ProductId) AS Product_Name,
AVG(Quantity) AS Average_Quantity
FROM OrderItem GROUP BY ProductId;

--10. (No Shipping company details provided)

--11. (No Employee Manager Database provided)

--12. (No database for discount is provided)

--13 (Insufficient Data Records)