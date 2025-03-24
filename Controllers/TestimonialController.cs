using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortolfyoProject.Models;

namespace AcunMedyaPortolfyoProject.Controllers
{
    public class TestimonialController : Controller
    {
        // GET: Testimonial

        DbAcunMedyaProject1Entities2 db = new DbAcunMedyaProject1Entities2();
        public ActionResult Index()
        {
            var values = db.Testimonial.ToList();
            return View(values);
        }

        public ActionResult DeleteTestimonial(int id)
        {
            var values = db.Testimonial.Find(id);
            db.Testimonial.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateTestimonial(Testimonial testimonial)
        {
            db.Testimonial.Add(testimonial);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var values = db.Testimonial.Find(id);
            return View(values);
        }

        public ActionResult UpdateTestimonial(Testimonial model)
        {
            var value = db.Testimonial.Find(model.TestimonialID);
            value.Description1 = model.Description1;
            value.TestimonialName = model.TestimonialName;
            value.Description2 = model.Description2;
            value.ImageUrl = model.ImageUrl;
            value.Title = model.Title;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}