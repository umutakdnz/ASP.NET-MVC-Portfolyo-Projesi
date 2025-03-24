using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortolfyoProject.Models;

namespace AcunMedyaPortolfyoProject.Controllers
{
    public class JobsController : Controller
    {
        DbAcunMedyaProject1Entities2 db = new DbAcunMedyaProject1Entities2();
        // GET: Jobs
        public ActionResult Index()
        {
            var values = db.Job.ToList();
            return View(values);
        }

        public ActionResult DeleteJob(int id)
        {
            var values = db.Job.Find(id);
            db.Job.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateJob()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateJob(Job job)
        {
            db.Job.Add(job);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateJob(int id)
        {
            var values = db.Job.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateJob(Job model)
        {
            var value = db.Job.Find(model.JobID);
            value.Title = model.Title;
            value.StartDate = model.StartDate;
            value.EndDate = model.EndDate;
            value.CompanyName = model.CompanyName;
            value.Description = model.Description;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}