using Assignment.Context;
using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace Assignment.Controllers
{
    public class EmployeeController : Controller
    {

        EmployeeDbContext Entities = new EmployeeDbContext();

        public ActionResult Index()
        {
            return View(Entities.Employees.Include("Department").ToList());
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            try
            {
                Entities.Employees.Add(employee);


                if (employee.Dept_ID == 1)
                {
                    employee.Bonus = employee.Salary * 10 / 100;
                }
                else if (employee.Dept_ID == 2)
                {
                    employee.Bonus = employee.Salary * 12 / 100;
                }
                else
                {
                    employee.Bonus = employee.Salary * 15 / 100;
                }



                Entities.SaveChanges();


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        [HttpPost]
        public ActionResult Edit(int? id, Employee employee)
        {
            try
            {

                var employeeDb = Entities.Employees.Include("Department").FirstOrDefault(e => e.ID == id);
                if (employeeDb == null)
                {
                    return HttpNotFound();
                }

                employeeDb.EmpName = employee.EmpName;
                employeeDb.Emp_Manager_Name = employee.Emp_Manager_Name;
                employeeDb.Salary = employee.Salary;
                employeeDb.YearsOfExp = employee.YearsOfExp;
                employeeDb.Dept_ID = employee.Dept_ID;

                if (employee.Dept_ID == 1)
                {
                    employee.Bonus = employee.Salary * 10 / 100;
                }
                else if (employee.Dept_ID == 2)
                {
                    employee.Bonus = employee.Salary * 12 / 100;
                }
                else
                {
                    employee.Bonus = employee.Salary * 15 / 100;
                }



                Entities.SaveChanges();


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int? id)
        {
            var employeeDb = Entities.Employees.Include("Department").FirstOrDefault(e => e.ID == id);
            if (employeeDb == null)
            {
                return HttpNotFound();
            }

            return View("Edit", employeeDb);
        }


        // GET: Employee/Delete/5
        public ActionResult Delete(int? id)
        {

            if (id == null)
            {
                return HttpNotFound();
            }
            var employeeDb = Entities.Employees.FirstOrDefault(e => e.ID == id);

            if (employeeDb == null)
            {
                return HttpNotFound();
            }

            Entities.Employees.Remove(employeeDb);

            Entities.SaveChanges();



            return RedirectToAction("Index");
        }


    }
}
