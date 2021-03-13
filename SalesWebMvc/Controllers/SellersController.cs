using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Services;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        //criando uma dependencia
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            this._sellerService = sellerService;
        }

        public IActionResult Index()
        {
            var list = this._sellerService.FindAll();

            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]//Definindo o Create como post
        [ValidateAntiForgeryToken]//Prevenir ataques CSRF
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }
    }
}
