using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exam.Models;
namespace Exam.Controllers
{
    public class HomeController : Controller
    {
        private dbContext db = new dbContext();
        // GET: Home
        public ActionResult Index()
        {
            var list = db.Students.ToList();
            return View(list);
        }
    public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student S)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(S);
                db.SaveChanges();
                return Redirect(Index);
            }
            return View(S);
            
        }
       
    }
}