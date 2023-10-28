USE Market
GO
SELECT P.ProductName as [Название продукта],
		C.CategoryName as [Название категории] 
	FROM  Product AS P
	LEFT JOIN Product_Category AS PC  ON P.ID = PC.ProductID
	LEFT JOIN Category AS C ON PC.CategoryID = C.ID
	GROUP BY P.ProductName, C.CategoryName