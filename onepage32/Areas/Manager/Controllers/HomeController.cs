using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace onepage32.Areas.Manager.Controllers
{
    public class HomeController : Controller
    {
        [Area("Manager")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
