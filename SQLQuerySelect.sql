USE Market
GO
SELECT P.ProductName as [�������� ��������],
		C.CategoryName as [�������� ���������] 
	FROM  Product AS P
	LEFT JOIN Product_Category AS PC  ON P.ID = PC.ProductID
	LEFT JOIN Category AS C ON PC.CategoryID = C.ID
	GROUP BY P.ProductName, C.CategoryName