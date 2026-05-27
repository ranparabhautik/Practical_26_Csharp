using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DAL.Models.Entities
{
    public class Employee:BaseEntity
    {
        public string Name { get; set; }

        public decimal Salary { get; set; }

        public int DepartmentId { get; set; }

        public string EmailId { get; set; }

        public DateTime JoiningDate { get; set; } = DateTime.Now;

        public bool Status { get; set; } = true;

        public Department Department { get; set; }
    }
}
