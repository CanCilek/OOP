using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OOP.ProjeContext;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OOP.Controllers
{
    public class CustomerController : Controller
    {

        Context context = new Context();

        // GET: /<controller>/
        public IActionResult Index()
        {

            var values = context.Customers.ToList();

            return View(values);
        }
    }
}

