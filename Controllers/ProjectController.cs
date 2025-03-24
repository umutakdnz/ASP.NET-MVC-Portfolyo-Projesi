﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortolfyoProject.Models;

namespace AcunMedyaPortolfyoProject.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project

        DbAcunMedyaProject1Entities2 db = new DbAcunMedyaProject1Entities2();
        public ActionResult Index()
        {
            var values = db.Project.ToList();
            return View(values);
        }

        public ActionResult DeleteProject(int id)
        {
            var values = db.Project.Find(id);
            db.Project.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateProject()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateProject(Project project)
        {
            db.Project.Add(project);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateProject(int id)
        {
            var values = db.Project.Find(id);
            return View(values);
        }

        public ActionResult UpdateProject(Project model)
        {
            var value = db.Project.Find(model.ProjectID);
            value.ProjectName = model.ProjectName;
            value.Description = model.Description;
            value.ProjectLink = model.ProjectLink;
            value.Image1 = model.Image1;
            value.Image2 = model.Image2;
            value.Image3 = model.Image3;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}