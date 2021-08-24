using Assignment.Context;
using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department

        EmployeeDbContext Entities = new EmployeeDbContext();

        public ActionResult Index()
        {

            return View(Entities.Departments.ToList());
        }

        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Employee/Create
        //[HttpPost]
        //public ActionResult Create(Department Dept)
        //{
        //    try
        //    {
        //        if (Dept.ID == 0)
        //            Entities.Departments.Add(Dept);
        //        else
        //        {
        //            var DeptDb = Entities.Employees.FirstOrDefault(e => e.ID == Dept.ID);
        //            if (DeptDb == null)
        //            {
        //                return HttpNotFound();
        //            }

        //            DeptDb.Department.Dept_Name = Dept.Dept_Name;
               

        //        }

        //        Entities.SaveChanges();


        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}