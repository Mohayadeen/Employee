using System;
using System.Collections.Generic;

namespace EmployeeMgmt.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
    }
}
