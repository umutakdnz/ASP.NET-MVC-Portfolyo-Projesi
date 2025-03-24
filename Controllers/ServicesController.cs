using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortolfyoProject.Models;

namespace AcunMedyaPortolfyoProject.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services

        DbAcunMedyaProject1Entities2 db = new DbAcunMedyaProject1Entities2();
        public ActionResult Index()
        {
            var values = db.Services.ToList();
            return View(values);
        }

        public ActionResult DeleteServices(int id)
        {
            var values = db.Services.Find(id);
            db.Services.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateServices()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateServices(Services services)
        {
            db.Services.Add(services);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult UpdateServices(int id)
        {
            var values = db.Services.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateServices(Services model)
        {
            var value = db.Services.Find(model.ServicesID);
            value.Description = model.Description;
            value.Title = model.Title;
            value.IconUrl = model.IconUrl;
            value.Description2 = model.Description2;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}