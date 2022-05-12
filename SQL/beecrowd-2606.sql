SELECT p.id, p.name
FROM products p, categories c
WHERE c.id = p.id_categories AND c.name LIKE 'super%'