﻿using Microsoft.AspNetCore.Mvc;

namespace GuitarShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("[action]")]
        public IActionResult About()
        {
            return View();
        }

        [Route("ContactUs")]
        public IActionResult ContactUs()
        {
            var contact = new Dictionary<string, string>
            {
                { "Phone", "555-123-4567" },
                { "Email", "info@myguitarshop.com" },
                { "Address", "123 Guitar Lane, Music City, USA" },
                { "Facebook", "facebook.com/myguitarshop" },
                { "Instagram", "instagram.com/myguitarshop" }
            };
            return View(contact);
        }
    }
}
