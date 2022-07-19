using System;
using System.Collections.Generic;
using System.Drawing;

namespace FinalProject.Models
{
    public class ShopProduct
    {
        public string Pictures { get; set; }
        public string Name { get; set; }
        public int ProductID { get; set; }
        public int Price { get; set; }
        public int StockLevel { get; set; }
        public string OnSale{ get; set; }

        public IEnumerable<Category> Categories { get; set; }
    }   
    
}

