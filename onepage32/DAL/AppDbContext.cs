using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace onepage32.DAL
{
    public class AppDbContext : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
