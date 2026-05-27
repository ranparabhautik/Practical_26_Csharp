using EmployeeManagement.DAL.Models.CommandModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DAL.Repository.Command
{
    public interface IEmployeeCommandRepository
    {
        Task Create(EmployeeCommandModel entity);
        Task Update(int id,EmployeeCommandModel entity);
        Task Delete(int id);
    }
}
