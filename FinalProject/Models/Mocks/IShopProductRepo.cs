using System;
using System.Collections.Generic;

namespace FinalProject.Models
{
    public interface IShopProductRepo
    {
        IEnumerable<ShopProduct> ShopProducts { get; set; }
        ShopProduct GetProductID(int productId);
    }
}

