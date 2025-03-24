using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortolfyoProject.Models;

namespace AcunMedyaPortolfyoProject.Controllers
{
    public class SliderController : Controller
    {
        // GET: Slider

        DbAcunMedyaProject1Entities2 db = new DbAcunMedyaProject1Entities2();
        public ActionResult Index()
        {
            var values = db.Slider.ToList();
            return View(values);
        }

        public ActionResult DeleteSlider(int id)
        {
            var values = db.Slider.Find(id);
            db.Slider.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateSlider()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateSlider(Slider slider)
        {
            db.Slider.Add(slider);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateSlider(int id)
        {
            var values = db.Slider.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateSlider(Slider model)
        {
            var value = db.Slider.Find(model.SliderID);
            value.NameSurname = model.NameSurname;
            value.Description = model.Description;
            value.ImageUrl = model.ImageUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}