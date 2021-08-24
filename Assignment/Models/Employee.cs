using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Assignment.Models
{
 
    public class Employee
    {

        public int ID  { get; set; }

        [Required(ErrorMessage="Enter Employee Name :")]
        [DisplayName("Employee Name")]
        public string EmpName { get; set; }
        [DisplayName("Manager Name")]

        [Required(ErrorMessage = "Enter Manager Name :")]
        public string Emp_Manager_Name { get; set; }
        [DisplayName("Years Of Experience")]
        public int YearsOfExp { get; set; }
        [DisplayName("Yearly Salary")]
        public float Salary { get; set; }
        [DisplayName("Bonus")]
        public float Bonus { get; set; }


        public int Dept_ID { get; set; }
        [ForeignKey("Dept_ID")]
        public Department Department { get; set; }







    }
}