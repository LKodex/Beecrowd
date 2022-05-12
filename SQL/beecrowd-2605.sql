SELECT a.name, b.name
FROM products a, providers b
WHERE a.id_categories = 6 AND b.id = a.id_providers