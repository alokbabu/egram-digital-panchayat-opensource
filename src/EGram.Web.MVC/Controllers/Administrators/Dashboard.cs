using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EGram.Data.SQL.Ef.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EGram.Web.MVC.Controllers.Administrators
{
    public class Dashboard : Controller
    {
        private readonly IUnitOfWork _uof;

        public Dashboard(IUnitOfWork uof)
        {
            _uof = uof;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
