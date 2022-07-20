using System;
using System.Collections.Generic;

namespace FinalProject.Models
{
    public interface IAdminInventoryRepository
    {
 
        
            public IEnumerable<ShopProduct> GetAllProducts();

            public ShopProduct GetProduct(int id);
            public void UpdateProduct(ShopProduct product);
            public void InsertProduct(ShopProduct productToInsert);
            public IEnumerable<Category> GetCategories();
            public ShopProduct AssignCategory();
            public void DeleteProduct(ShopProduct product);
            


    }



}


