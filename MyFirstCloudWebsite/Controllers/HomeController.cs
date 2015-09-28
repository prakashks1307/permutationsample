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
        public ActionResult Index(FormCollection collection)
        {
            int nn, rr;
            var inputValues = new InputValues();
            string n = collection["N"];
            bool nOK = Int32.TryParse(n, out nn);
            string r = collection["R"];
            bool rOK = Int32.TryParse(r, out rr);
            if (nOK && rOK)
            {
                inputValues = new InputValues() { N = nn, R = rr };
                if (nn < rr)
                {
                    ViewBag.Result = "n cannot be less than r.";
                }
                else
                {
                    var result = 0;
                    var resultType = "";
                    var type = collection["hdnOperation"];
                    if (type.ToLower() == "per")
                    {
                        result = Calculator.GetPermutation(inputValues);
                        resultType = "P";
                    }
                    else
                    {
                        result = Calculator.GetCombination(inputValues);
                        resultType = "C";
                    }
                    ViewBag.Result = string.Format("<sub>{0}</sub>{1}<sub>{2}</sub> = {3}", nn, resultType, rr, result);
                }
            }
            else
            {
                ViewBag.Result = "Please enter valid numbers for N and R.";
            }
            return View(inputValues);
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