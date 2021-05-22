﻿using Microsoft.AspNetCore.Mvc;
using FinalProject.Web.Areas.Administrative.Models;

namespace FinalProject.Web.Areas.Administrative.Controllers
{
    [Area("Administrative")]
    public class WebsiteController : Controller
    {
        public IActionResult Homepage()
        {
            var model = new HomePageModel();
            model.ModelBuilder.BuildHomepage();
            return View(model);
        }
        [HttpPost]
        public IActionResult Homepage(HomePageModel model)
        {
            if (ModelState.IsValid)
            {
               model.ModelBuilder.SaveHomePage(model);
            }
            return View(model);
        }


    }
}
