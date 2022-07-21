using System;
using System.Collections.Generic;

namespace FinalProject.Models.Mocks
{
    public class ProductRepo : IProductRepo
    {
        public ProductRepo()
        {
        }

        IEnumerable<Product> IProductRepo.Product { get; set; }

        Product IProductRepo.GetProductID(int productId)
        {
            throw new NotImplementedException();
        }
    }
}

