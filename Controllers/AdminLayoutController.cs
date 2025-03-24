using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortolfyoProject.Controllers
{
    public class AdminLayoutController : Controller
    {
        // GET: AdminLayout
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialMenu()
        {
            return PartialView();
        }

        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
    }
}