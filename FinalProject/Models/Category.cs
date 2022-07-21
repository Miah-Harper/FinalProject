using System;
using System.Collections.Generic;

namespace FinalProject.Models
{
    public class Category
    {

        public int CategoryID { get; set; }
        public string Name { get; set; }
        public int ProductID { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        

        public List<Product> Product { get; set; }
    }
}

