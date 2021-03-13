﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Services;

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
    }
}