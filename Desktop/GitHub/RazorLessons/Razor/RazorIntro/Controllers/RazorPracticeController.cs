using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorIntro.Controllers
{
    public class RazorPracticeController : Controller
    {
        // GET: RazorPractice
        public ActionResult Index()
        {
            return View();
        }
    }
}