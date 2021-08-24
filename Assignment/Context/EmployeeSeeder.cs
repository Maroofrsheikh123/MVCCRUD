using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Assignment.Context
{

    public class EmployeeSeeder : DropCreateDatabaseIfModelChanges<EmployeeDbContext>
    {
        protected override void Seed(EmployeeDbContext context)
        {
            Department DepartmentObject = new Department
            {
                Dept_Name = "HR",
                EmployeeList = new List<Employee>()
                {
                    new Employee()
                    {
                        EmpName="Maroof",
                        Emp_Manager_Name = "Dipak",
                        Salary = 1000,
                        Bonus = 1000 * 10/100,
                        YearsOfExp = 2
                    }
                }
            };


            Department DepartmentObject2 = new Department
            {
                Dept_Name = "DEV",
                EmployeeList = new List<Employee>()
                {
                    new Employee()
                    {
                        EmpName="Priyank",
                        Emp_Manager_Name = "Aniket",
                        Salary = 9999,
                        Bonus = 9999 * 12/100,
                        YearsOfExp = 12
                    }
                }
            };

            Department DepartmentObject3 = new Department
            {
                Dept_Name = "QA",
                EmployeeList = new List<Employee>()
                {
                    new Employee()
                    {
                        EmpName="Priyanka",
                        Emp_Manager_Name = "Anjali",
                        Salary = 8888,
                        Bonus = 8888 * 15/100,
                        YearsOfExp = 8
                    }
                }
            };
            context.Departments.Add(DepartmentObject);
            context.Departments.Add(DepartmentObject2);
            context.Departments.Add(DepartmentObject3);

            base.Seed(context);
        }
    }
}