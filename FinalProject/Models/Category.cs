using System;
using System.Collections.Generic;

namespace FinalProject.Models
{
    public class Category
    {
        public int CategoryName { get; set; }
        public string Name { get; set; }
        public int ProductID { get; set; }
        public int Price { get; set; }

        public IEnumerable<Category> Categories { get; set; }
    }
}

