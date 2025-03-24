using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortolfyoProject.Models;

namespace AcunMedyaPortolfyoProject.Controllers
{
    public class CommunicationController : Controller
    {
        // GET: Communication

        DbAcunMedyaProject1Entities2 db = new DbAcunMedyaProject1Entities2();
        public ActionResult Index()
        {
            var values = db.Communication.ToList();
            return View(values);
        }

        public ActionResult DeleteCommunication(int id)
        {
            var values = db.Communication.Find(id);
            db.Communication.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateCommunication()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCommunication(Communication communication)
        {
            db.Communication.Add(communication);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateCommunication(int id)
        {
            var values = db.Communication.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateCommunication(Communication model)
        {
            var value = db.Communication.Find(model.MessageID);
            value.NameSurname = model.NameSurname;
            value.Mail = model.Mail;
            value.MessageContent = model.MessageContent;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}