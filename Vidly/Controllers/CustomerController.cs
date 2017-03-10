using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        private List<Customer> _customers=new List<Customer>
        {
            new Customer {Id=1,Name = "Customer1"},
                new Customer {Id=2,Name = "Customer2"},
                new Customer {Id=3,Name = "Customer3"},
                new Customer {Id=4,Name = "Customer5"},
                new Customer {Id=5,Name = "Customer4"}
        };
        public ActionResult Index()
        {
            
            var data=new RandomMovieViewModel
            {
              Customers  = _customers
            };

            return View(data);
        }
        [Route("/Customer/Details/{id}")]
        public ActionResult Details(int id)
        {
            var customer = _customers.Find(c => c.Id == id);
            if (customer == null) return HttpNotFound();
            
            return View(customer);
        }
    }
}