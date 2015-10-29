using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ORES.Controllers
{
    public class ExceptionsController : Controller
    {
        public ActionResult Exceptions(int Index)
        {   
            return View();
        }

        public ActionResult Exceptions()
        {
            return View();
        }

    }

}
