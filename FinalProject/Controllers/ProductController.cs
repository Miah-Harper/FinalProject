using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FinalProject.Controllers
{
    public class ProductController : Controller
    {
        private readonly ICategoryRepo _categoryRepo;
        private readonly IProductRepo _ProductRepo;

        public ProductController(ICategoryRepo categoryRepo, IProductRepo productRepo)
        {

            _categoryRepo = categoryRepo;
            _ProductRepo = productRepo;
        }

        public IActionResult List()
        {
            var products = _ProductRepo.Product;
            return View(products);
        }
        
     }
}





