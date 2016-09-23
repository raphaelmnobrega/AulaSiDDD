using AulaSiDDD.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AulaSiDDD.Web.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerService _customerService;
        public CustomerController(ICustomerService service)
        {
            _customerService = service;
        }

        // GET: Customer
        public ActionResult Index()
        {
            return View(_customerService.HelloWorld());
        }
    }
}