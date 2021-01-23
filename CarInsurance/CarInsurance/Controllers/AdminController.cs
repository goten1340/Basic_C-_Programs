using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        private InsuranceEntities db = new InsuranceEntities();
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }
    }
}