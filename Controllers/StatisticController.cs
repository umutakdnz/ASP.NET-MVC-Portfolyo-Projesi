using AcunMedyaPortolfyoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortolfyoProject.Controllers
{
    public class StatisticController : Controller
    {
        // GET: Statistic

        DbAcunMedyaProject1Entities2 db = new DbAcunMedyaProject1Entities2();
        public ActionResult Index()
        {
            ViewBag.CategoryCount = db.Category.Count();
            ViewBag.TestimonialCount = db.Testimonial.Count();
            ViewBag.ProjectCount = db.Project.Count();
            ViewBag.JobsCount = db.Job.Count();
            ViewBag.SkillCount = db.Skill.Count();
            ViewBag.ServicesCount = db.Services.Count();
            ViewBag.CommunicationCount = db.Communication.Count();
            ViewBag.EducationCount = db.Education.Count();

            // Yeni Eklemeler
            ViewBag.LastProject = db.Project.OrderByDescending(p => p.ProjectID).Select(p => p.ProjectName).FirstOrDefault();
            ViewBag.LastMessage = db.Communication.OrderByDescending(c => c.MessageID).Select(c => c.MessageContent).FirstOrDefault();
            ViewBag.LastService = db.Services.OrderByDescending(s => s.ServicesID).Select(s => s.Title).FirstOrDefault();
            ViewBag.LastSkill = db.Skill.OrderByDescending(s => s.SkillID).Select(s => s.SkillName).FirstOrDefault();
            ViewBag.LastTestimonial = db.Testimonial.OrderByDescending(t => t.TestimonialID).Select(t => t.TestimonialName).FirstOrDefault();
            ViewBag.LastJob = db.Job.OrderByDescending(j => j.JobID).Select(j => j.Title).FirstOrDefault();
            ViewBag.LastEducation = db.Education.OrderByDescending(e => e.EducationID).Select(e => e.Name).FirstOrDefault();
            return View();
        }
    }
}

