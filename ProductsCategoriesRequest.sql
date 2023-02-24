SELECT p.Name Product, c.Name Category
FROM Product p
	LEFT JOIN ProductCategory pc ON p.ProductId = pc.ProductId
	LEFT JOIN Category c ON c.CategoryId = pc.CategoryId;
