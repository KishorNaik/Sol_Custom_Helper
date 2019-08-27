using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sol_Custom_Helper.Models.Persons;

namespace Sol_Custom_Helper.Controllers
{
    public class PersonCustomHelperDemoController : Controller
    {

        public PersonCustomHelperDemoController()
        {
            Person = new PersonModel();
        }


        public IActionResult Index()
        {
            // Select User Model View
            Person.Users = new UsersModel();

            return View(Person);
        }

        [BindProperty]
        public PersonModel Person { get; set; }

        [HttpPost]
        public IActionResult OnSubmit()
        {
            return View("Index");
        }
    }
}