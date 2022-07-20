using System;
using System.Collections.Generic;
using System.Data;
using Dapper;

namespace FinalProject.Models
{
    public class AdminInventoryRepository : IAdminInventoryRepository
    {

        private readonly IDbConnection _conn;

        public AdminInventoryRepository(IDbConnection conn)
        {
            _conn = conn;
        }


        public ShopProduct AssignCategory()
        {
            var categoryList = GetCategories();
            var product = new ShopProduct();
            product.Categories = categoryList;

            return product;
        }

        public void DeleteProduct(ShopProduct product)
        {
            
            _conn.Execute("DELETE FROM Products WHERE ProductID = @id;", new { id = product.ProductID });
        }

        public IEnumerable<ShopProduct> GetAllProducts()
        {
            return _conn.Query<ShopProduct>("SELECT * FROM PRODUCTS;");
        }

        public IEnumerable<Category> GetCategories()
        {
            return _conn.Query<Category>("SELECT * FROM categories;");
        }

        public ShopProduct GetProduct(int id)
        {
            return _conn.QuerySingleOrDefault<ShopProduct>("SELECT * FROM PRODUCTS WHERE PRODUCTID = @id", new { id });
        }

        public void InsertProduct(ShopProduct productToInsert)
        {
            _conn.Execute("INSERT INTO products (NAME, PRICE, CATEGORY) VALUES (@name, @price, @category);",
               new { name = productToInsert.Name, price = productToInsert.Price, category = productToInsert.Categories });
        }

        public void UpdateProduct(ShopProduct product)
        {
            _conn.Execute("UPDATE products SET Name = @name, Price = @price WHERE ProductID = @id",
             new { name = product.Name, price = product.Price, id = product.ProductID });
        }

       
    }
}

