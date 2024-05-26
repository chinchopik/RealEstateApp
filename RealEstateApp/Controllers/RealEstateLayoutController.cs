﻿using Microsoft.AspNetCore.Mvc;
using RealEstateApp.Models.RealEstateList;

namespace RealEstateApp.Controllers
{
    public class RealEstateLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Clients()
        {
            return View("~/Views/RealEstate/Clients.cshtml");
        }

        public IActionResult Deals()
        {
            return View("~/Views/RealEstate/Deals.cshtml");
        }

    }
}