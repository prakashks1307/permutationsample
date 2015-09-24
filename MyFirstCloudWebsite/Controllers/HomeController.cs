using MyFirstCloudWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstCloudWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Permutation perm)
        {
            if (perm.N < perm.R)
            {
                ViewBag.Result = "n cannot be less than r.";
            }
            else
            {
                ViewBag.Result = Calculator.GetPermutation(perm);
            }
            return View(perm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}