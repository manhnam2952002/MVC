using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Employee
    {
        public string EmployeeID { get; set; }
        public string Name { get; set; }

        public string Department { get; set; }

        public decimal Salary { get; set; }
    }
}
