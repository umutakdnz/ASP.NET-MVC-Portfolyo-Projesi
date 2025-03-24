using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortolfyoProject.Models;
using Microsoft.Ajax.Utilities;
using Newtonsoft.Json.Linq;

namespace AcunMedyaPortolfyoProject.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories 

        DbAcunMedyaProject1Entities2 db = new DbAcunMedyaProject1Entities2();
        public ActionResult Index()
        {
            var values = db.Category.ToList();
            return View(values);
        }

        public ActionResult DeleteCategory(int id)
        {
            var values = db.Category.Find(id);
            db.Category.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCategory(Category category)
        {
            db.Category.Add(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]

        public ActionResult UpdateCategory(int id)
        {
            var values = db.Category.Find(id);
            return View(values);
        }

        [HttpPost]

        public ActionResult UpdateCategory(Category model)
        {
            var value = db.Category.Find(model.CategoryID);
            value.CategoryName = model.CategoryName;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
