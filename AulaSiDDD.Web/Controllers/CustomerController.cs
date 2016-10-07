using AulaSiDDD.Domain.Interfaces.Service;
using AulaSiDDD.Domain.Services;
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

        public CustomerController()
        {
            _customerService = new CustomerService();
        }

        // GET: Customer
        public ActionResult Index()
        {
            ViewBag.HelloWorld = _customerService.reclamarPedido();
            return View();
        }
    }
}