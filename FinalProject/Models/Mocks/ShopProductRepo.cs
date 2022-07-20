using System;
using System.Collections.Generic;

namespace FinalProject.Models.Mocks
{
    public class ShopProductRepository : IShopProductRepo
    {
        public ShopProductRepository()
        {
        }

        IEnumerable<ShopProduct> IShopProductRepo.ShopProducts { get; set; }

        ShopProduct IShopProductRepo.GetProductID(int productId)
        {
            throw new NotImplementedException();
        }
    }
}

