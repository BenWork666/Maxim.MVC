using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Maxim.Service;

namespace Maxim.MVC.Controllers
{
    
    public class MaximController : Controller
    {
        // GET: Maxim
        private readonly IService _service;
        public MaximController(IService service)
        {
            _service = service;
        }
        public ActionResult Index()
        {
            var result = _service.GetNewest();
            return View(result);
        }
        public ActionResult ByAlpha()
        {
            var result = _service.GetByAlpha();
            return View(result);
        }
        public ActionResult ByPrice()
        {
            var result = _service.GetByPrice();
            return View(result);
        }
        public ActionResult GetNewest()
        {
            var result = _service.GetNewest();
            return View(result);
        }
        public ActionResult RandomCar()
        {
            var result = _service.RandomCar();
            return View(result);
        }
        public ActionResult BestValue()
        {
            var result = _service.BestValue();
            return View(result);
        }
    }
}