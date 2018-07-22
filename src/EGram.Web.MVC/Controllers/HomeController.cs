using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EGram.Web.MVC.Models;
using EGram.Data.SQL.Ef.Repositories;

namespace EGram.Web.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _uof;
        public HomeController(IUnitOfWork uof)
        {
            _uof = uof;
        }

        public IActionResult Index()
        {
            //var education = _uof.Educations.GetAll();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
