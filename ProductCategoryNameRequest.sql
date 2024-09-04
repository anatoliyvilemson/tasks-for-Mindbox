SELECT 
    p.name AS ProductName,
    c.name AS CategoryName
FROM 
    Products p
    LEFT JOIN ProductCategories pc ON p.id = pc.product_id
    LEFT JOIN Categories c ON pc.category_id = c.id;
/*
Структура базы данных
Для решения этой задачи мы предполагаем следующую структуру таблиц:

Products (id, name) - таблица продуктов с уникальным идентификатором и названием.
Categories (id, name) - таблица категорий с уникальным идентификатором и названием.
ProductCategories (product_id, category_id) - связующая таблица, которая хранит информацию о принадлежности продуктов к категориям.

Products
id   | name     |
-----+----------+
 1   | product1 |    
 2   | product2 |     
 3   | product3 | 
 4   | product4 |
 5   | product5 |

Categories
id   |  name       |
-----+-------------+
 a   | categories1 |    
 b   | categories2 |     
 c   | categories3 | 

ProductCategories
product_id  | category_id  |
------------+--------------+
 1          |            a |    
 2          |            b |     
 3          |            b | 
 4          |              | 
 5          |            c | 
*/
