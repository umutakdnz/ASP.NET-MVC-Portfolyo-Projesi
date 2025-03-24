using AcunMedyaPortolfyoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortolfyoProject.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact

        DbAcunMedyaProject1Entities2 db = new DbAcunMedyaProject1Entities2();
        public ActionResult Index()
        {
            var values = db.Contact.ToList();
            return View(values);
        }

        public ActionResult DeleteContact(int id)
        {
            var values = db.Contact.Find(id);
            db.Contact.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateContact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateContact(Contact contact)
        {
            db.Contact.Add(contact);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateContact(int id)
        {
            var values = db.Contact.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateContact(Contact model)
        {
            var value = db.Contact.Find(model.ContactID);
            value.Description = model.Description;
            value.Adress = model.Adress;
            value.Email = model.Email;
            value.Phone = model.Phone;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}