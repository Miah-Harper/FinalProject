using System;
using System.Collections.Generic;

namespace FinalProject.Models
{
    public interface IProductRepo
    {
        IEnumerable<Product> Product { get; set; }
        /*Product GetProductID(int productId);*/
    }
}

