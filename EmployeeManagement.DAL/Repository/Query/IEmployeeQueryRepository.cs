using EmployeeManagement.DAL.Models.QueryModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DAL.Repository.Query
{
    public interface IEmployeeQueryRepository
    {
        Task<IEnumerable<EmployeeQueryModel>> GetAll();
        Task<EmployeeQueryModel> GetById(int id);
    }
}
