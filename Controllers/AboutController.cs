using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortolfyoProject.Models;

namespace AcunMedyaPortolfyoProject.Controllers
{
    public class AboutController : Controller
    {
        // GET: About

        DbAcunMedyaProject1Entities2 db = new DbAcunMedyaProject1Entities2();
        public ActionResult Index()
        {
            var values = db.About.ToList();
            return View(values);
        }

        public ActionResult DeleteAbout(int id)
        {
            var values = db.About.Find(id);
            db.About.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateAbout()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateAbout(About about)
        {
            db.About.Add(about);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var values = db.About.Find(id);
            return View(values);
        }

        [HttpPost]
        public  ActionResult UpdateAbout(About model)
        {
            var value = db.About.Find(model.AboutID);
            value.ImageURL = model.ImageURL;
            value.Title = model.Title;
            value.Birthday = model.Birthday;
            value.Website = model.Website;
            value.Phone = model.Phone;
            value.City = model.City;
            value.Age = model.Age;
            value.Email = model.Email;
            value.FreeLance = model.FreeLance;
            value.Description1 = model.Description1;
            value.Description2 = model.Description2;
            value.Degree = model.Degree;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}