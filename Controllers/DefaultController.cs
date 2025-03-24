using AcunMedyaPortolfyoProject.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace AcunMedyaPortolfyoProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default

        DbAcunMedyaProject1Entities2 db = new DbAcunMedyaProject1Entities2();
        DbAcunMedyaProject1Entities3 ua = new DbAcunMedyaProject1Entities3();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialTestimonial()
        {
            var values = db.Testimonial.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialServices()
        {
            var values = db.Services.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialContact()
        {
            var values = db.Contact.ToList();
            return PartialView(values);
        }

        public ActionResult PartialMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult PartialMessage(Communication communication)
        {
            db.Communication.Add(communication);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public PartialViewResult PartialSkill()
        {
            var values = db.Skill.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialAbout()
        {
            var values = db.About.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialSlider()
        {
            var values = db.Slider.ToList();
            return PartialView(values);
        } 

        public PartialViewResult PartialEducation()
        {
            var values = db.Education.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialJobs()
        {
            var values = db.Job.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialProject()
        {
            var values = db.Project.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialCertificate()
        {
            var values = ua.Certificate.ToList();
            return PartialView(values);
        }

        public ActionResult PartialScript()
        {
            return PartialView();
        }

        public ActionResult PartialHead()
        {
            return PartialView();
        }

        public ActionResult PartialMenu()
        {
            return PartialView();
        }
    }
}