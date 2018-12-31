using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_filters_partilaview_csrf.Controllers
{
    [HandleError(View ="Error")]
    public class HomeController : Controller
    {
        [OutputCache(Duration = 30)] //filter
        public ActionResult Getdetails()
        {
            ViewBag.msg = DateTime.Now.ToString();
            return View();
        }
        [HandleError(ExceptionType =typeof(DivideByZeroException),View ="Myerror")]
        public ActionResult Getupdate()
        {
            int i = 100;
            int y = 0;
            int total = i / y;
            return View();
        }
    }
}