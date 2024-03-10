select p.Name as [Имя продукта], c.Name as [Имя категории] from dbo.Product p
LEFT JOIN dbo.ProductCategory pc ON pc.ProductId = p.Id
LEFT JOIN dbo.Category c ON pc.CategoryId = c.Id
