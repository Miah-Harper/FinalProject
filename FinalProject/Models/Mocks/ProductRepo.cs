using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Models;

namespace FinalProject.Models.Mocks
{
    public class ProductRepo : IProductRepo
    {
        private readonly ICategoryRepo _categoryRepo = new CategoryRepo();

        public IEnumerable<Product> Product
        {
            get

            {
                return new List<Product>
                {
                    new Product
                    {
                        Name ="Floral Bobcat Skull",
                        Price = 120,
                        ShortDescription = "Absolutely beautiful full Bobcat skull!",
                        LongDescription = "This is a hanging full Bobcat skull with hand painted upper gold teeth! It is missing it's bottom teeth.",
                       ImageUrl = "https://tinypic.host/images/2022/07/15/IMG_7716.jpg",
                       InStock = true,
                       ImageThumbnailUrl = "https://tinypic.host/images/2022/07/15/IMG_7716.th.jpg"

                    },

                    new Product
                    {
                         Name ="Raccoon Angel",
                        Price = 175,
                        ShortDescription = "Raccoon Angel with crystallized canines!",
                        LongDescription = "This is a hanging Raccoon skull with missing teeth, however, I added crystals to this skulls canines!",
                       ImageUrl = "https://tinypic.host/images/2022/07/21/IMG_7706.jpg",
                       InStock = true,
                       ImageThumbnailUrl = "https://tinypic.host/images/2022/07/21/IMG_7706.th.jpg"

                    },

                    new Product
                    {
                         Name ="Macrame Pig Skull",
                        Price = 195,
                        ShortDescription = "Stunning macrame pig skull",
                        LongDescription = "This is a magical pig skull that took me 1 1/2 years to clean! The moss and flowers are dried and preserved so they will stay this color! I created hte crystals myself, made the macrame, and added the cutest pastel mushrooms! ",
                       ImageUrl = "https://tinypic.host/images/2022/07/21/IMG_7697.jpg",
                       InStock = true,
                       ImageThumbnailUrl = "https://tinypic.host/images/2022/07/21/IMG_7697.th.jpg"

                    }
                };





             }
        }

     public IEnumerable<Product> Products { get; }
        IEnumerable<Product> IProductRepo.Product { get ; set; }

       
    }
}