using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DrSavvy2.Controllers
{
    public class ConsultationController : Controller
    {
        // GET: Consultation
        public ActionResult RecordConsultation()
        {
            ViewBag.Title = "Record Consultation";
            return View();
        }

        public ActionResult NewConsultation()
        {
            return View();
        }

        public ActionResult XRay()
        {
            return View();
        }

        public ActionResult RequestXRay()
        {
            return View();
        }

        public ActionResult UploadXRay()
        {
            return View();
        }
    }
}