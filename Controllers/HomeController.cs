using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab02.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        public ActionResult Lab02_Baitap1()
        {
            ViewBag.Message = "Baitap1";

            return View();
        }
        public ActionResult Baitap2()
        {
            ViewBag.Message = "Baitap2";

            return View();
        }
        public ActionResult Baitap3()
        {
            ViewBag.Message = "baitap3";

            return View();
        }
        public ActionResult Baitap4()
        {
            ViewBag.Message = "baitap4";

            return View();
        }
        public ActionResult baitap1_lamtrangweb()
        {
            ViewBag.Message = "lamtrangweb1";

            return View();
        }
        public ActionResult baitap2_lamtrangweb()
        {
            ViewBag.Message = "lamtrangweb2";

            return View();
        }
        public ActionResult baitap3_lamtrangweb()
        {
            ViewBag.Message = "lamtrangweb3";

            return View();
        }
    }
}