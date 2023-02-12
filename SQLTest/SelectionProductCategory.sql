SELECT Product.name, Category.name
FROM Product
LEFT JOIN CategoryProduct ON Product.ID = CategoryProduct.product_ID
