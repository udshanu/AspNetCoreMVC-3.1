using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using UdShanu.BookStore.Models;

namespace UdShanu.BookStore.Controllers
{
    public class HomeController : Controller
    {
        [ViewData]
        public string CustomProperty { get; set; }
        [ViewData]
        public string TitleAsViewDataAttribute { get; set; }
        public ViewResult Index()
        {
            ViewBag.Title = "Roshan";

            dynamic data = new ExpandoObject();
            data.Id = 1;
            data.Name = "Shanu";

            ViewBag.Data = data;

            ViewBag.Type = new BookModel() { Id = 5, Author = "This is author." };

            ViewData["Property1"] = "View Data Value. Property1";
            ViewData["book"] = new BookModel() { Id = 55, Author = "Roshan Manoj" };

            CustomProperty = "View data as attribute.";
            TitleAsViewDataAttribute = "Home Form Controller";

            return View();
        }

        public ViewResult AboutUs()
        {
            TitleAsViewDataAttribute = "AboutUs Form Controller";

            return View();
        }

        public ViewResult ContactUs()
        {
            TitleAsViewDataAttribute = "ContactUs Form Controller";

            return View();
        }
    }
}
