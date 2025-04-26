using ProjectASP01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectASP01.Controllers
{
    public class DepartmentController : Controller
    {
        private companydbEntities _context;
        public DepartmentController()
        {
            this._context = new companydbEntities();   
        }
        // GET: Department
        public ActionResult Index()
        {
            List<department> list = _context.departments.ToList();
            ViewBag.departments = list;
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(string name)
        {
            return View();
        }
    }
}