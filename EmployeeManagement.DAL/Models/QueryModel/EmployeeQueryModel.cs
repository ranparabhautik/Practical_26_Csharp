using EmployeeManagement.DAL.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DAL.Models.QueryModel;

public class EmployeeQueryModel
{
    public int Id { get; set; }
    public bool IsDeleted { get; set; }
    public string Name { get; set; }

    public decimal Salary { get; set; }

    public int DepartmentId { get; set; }

    public string EmailId { get; set; }

    public DateTime JoiningDate { get; set; } 

    public bool Status { get; set; } 

    public string Department { get; set; }
}
