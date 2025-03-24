using AcunMedyaPortolfyoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortolfyoProject.Models;

namespace AcunMedyaPortolfyoProject.Controllers
{
    //DbAcunMedyaProject1Entities2 db = new DbAcunMedyaProject1Entities2();
    public class SkillController : Controller
    {
        // GET: Skill

        DbAcunMedyaProject1Entities2 db = new DbAcunMedyaProject1Entities2();
        public ActionResult Index()
        {
            var values = db.Skill.ToList();
            return View(values);
        }

        public ActionResult DeleteSkill(int id)
        {
            var values = db.Skill.Find(id);
            db.Skill.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateSkill()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateSkill(Skill skill)
        {
            db.Skill.Add(skill);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateSkill(int id)
        {
            var values = db.Skill.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateSkill(Skill model)
        {
            var value = db.Skill.Find(model.SkillID);
            value.SkillName = model.SkillName;
            value.Derece = model.Derece;
            value.Description = model.Description;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}