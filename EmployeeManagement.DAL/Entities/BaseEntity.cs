using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DAL.Models.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
