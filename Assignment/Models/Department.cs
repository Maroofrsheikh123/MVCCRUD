using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment.Models
{
    public class Department
    {
        [DisplayName("Department Name")]
        public string Dept_Name { get; set; }
        
        public int ID { get; set; }

        public List<Employee> EmployeeList { get; set; }

    }
}