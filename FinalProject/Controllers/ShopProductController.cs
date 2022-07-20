using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FinalProject.Controllers
{
    public class ShopProductController : Controller
    {
        private readonly ICategoryRepo _categoryRepo;
        private readonly IShopProductRepo _shopProductRepo;

        public ShopProductController(ICategoryRepo categoryRepo, IShopProductRepo shopProductRepo)
        {

            _categoryRepo = categoryRepo;
            _shopProductRepo = shopProductRepo;
        }

        public ViewResult List()
        {
            var products = _shopProductRepo.ShopProducts;
            return View(products);
        }
        
     }
}





