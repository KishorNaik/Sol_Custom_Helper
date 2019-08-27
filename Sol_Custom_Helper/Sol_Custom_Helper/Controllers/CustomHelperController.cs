using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sol_Custom_Helper.Controllers
{
    public class CustomHelperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}