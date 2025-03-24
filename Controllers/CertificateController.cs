using AcunMedyaPortolfyoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortolfyoProject.Controllers
{
    public class CertificateController : Controller
    {
        // GET: Certificate

        DbAcunMedyaProject1Entities3 ua = new  DbAcunMedyaProject1Entities3();
        public ActionResult Index()
        {
            var values = ua.Certificate.ToList();
            return View(values);
        }

        public ActionResult DeleteCertificate(int id)
        {
            var values = ua.Certificate.Find(id);
            ua.Certificate.Remove(values);
            ua.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateCertificate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCertificate(Certificate certificate)
        {
            ua.Certificate.Add(certificate);
            ua.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateCertificate(int id)
        {
            var values = ua.Certificate.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateCertificate(Certificate model)
        {
            var value = ua.Certificate.Find(model.SertifikaID);
            value.SAdi= model.SAdi;
            value.SVeren = model.SVeren;
            ua.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}