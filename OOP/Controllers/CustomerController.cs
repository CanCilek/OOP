using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OOP.Entity;
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

        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCustomer(Customer c)
        {
            if(c.Name.Length >= 6 && c.City != "" && c.City.Length >= 3)
            {
                context.Add(c);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }

            
        }
        public IActionResult DeleteCustomer(int Id)
        {
            var value = context.Customers.Where(x => x.Id == Id).FirstOrDefault();
            context.Customers.Remove(value);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCustomer(int id)
        {
            var value = context.Customers.Where(x => x.Id == id).FirstOrDefault();
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCustomer(Customer c)
        {

            if (c.Name.Length >= 6 && c.City != "" && c.City.Length >= 3)
            {
                var value = context.Customers.Where(x => x.Id == c.Id).FirstOrDefault();
                value.Name = c.Name;
                value.City = c.City;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}

