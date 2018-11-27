using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Testgit.Areas.Guest.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Guest/Default
        public ActionResult Index()
        {
            return View();
        }
    }
}