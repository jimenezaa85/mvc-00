using mvc_00.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FluentValidation;
using FluentValidation.Results;

namespace mvc_00.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Customer customer)
        {
            CustomerValidator validator = new CustomerValidator();
            ValidationResult results = validator.Validate(customer);

            if (!results.IsValid)
            {
                return View(customer);
            }

            //if(!ModelState.IsValid)
            //{
            //    return View(customer);
            //}

            return RedirectToAction(nameof(Index));
        }



        //public string Index()
        //{
        //    return "This is my <b>defaul</b> action...";
        //}

        //public string Welcome(string name, int numTimes)
        //{
        //    return HttpUtility.HtmlEncode("Hola " + name + " , NumTimes is: " + numTimes);
        //}
    }
}