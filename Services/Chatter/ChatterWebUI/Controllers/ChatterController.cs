using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChatterWebUI.Controllers
{
    public class ChatterController : Controller
    {
        // GET: Chatter
        public ActionResult Index()
        {
            return View();
        }
    }
}