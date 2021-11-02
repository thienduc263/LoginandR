using LoginandR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginandR.Controllers
{
    public class FeedbackController : Controller
    {
        DB_Entities _db = new DB_Entities();
        // GET: Feedback
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Feedback f)
        {
            _db.Feedbacks.Add(f);
            _db.SaveChanges();
            return RedirectToAction("Success");
        }
        public ActionResult Success()
        {
            return View();
        }
    }
}