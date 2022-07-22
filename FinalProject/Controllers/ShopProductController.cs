﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;



namespace FinalProject.Controllers
{
    public class ShopProductController : Controller
    {
        private IShopProductRepository repo;

        public ShopProductController(IShopProductRepository repo)
        {
            this.repo = repo;
        }


        public IActionResult Index()
        {
            var products = repo.GetAllProducts();

            return View(products);
        }

        public IActionResult ViewProduct(int id)
        {
            var product = repo.GetProduct(id);
            return View(product);
        }

        public IActionResult UpdateProduct(int id)
        {
            ShopProduct prod = repo.GetProduct(id);
            if (prod == null)
            {
                return View("ProductNotFound");
            }
            return View(prod);
        }

        public IActionResult UpdateProductToDatabase(ShopProduct product)
        {
            repo.UpdateProduct(product);

            return RedirectToAction("ViewProduct", new { id = product.ProductID });
        }

        public IActionResult InsertProduct()
        {
            var prod = repo.AssignCategory();
            return View(prod);
        }

        public IActionResult InsertProductToDatabase(ShopProduct productToInsert)
        {
            repo.InsertProduct(productToInsert);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteProduct(ShopProduct product)
        {
            repo.DeleteProduct(product);
            return RedirectToAction("Index");
        }
    }
}
