using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _23dh111859_DinhThiTrucLinh.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Photoshoot_Effect()
        {
            return View();
        }

        public ActionResult ancientarchitecture()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}