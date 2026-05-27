using EmployeeManagement.DAL.Data;
using EmployeeManagement.DAL.Models.QueryModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DAL.Repository.Query
{
    public class EmployeeQueryRepository : IEmployeeQueryRepository
    {
        protected readonly AppDbContext _context;
        public EmployeeQueryRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<EmployeeQueryModel>> GetAll()
        {
            return await _context.Employees.Where(x => x.IsDeleted == false).Include(x=> x.Department).Select(x=> 
                new EmployeeQueryModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Salary = x.Salary,
                    Department = x.Department.Name,
                    EmailId = x.EmailId,
                    JoiningDate = x.JoiningDate,
                    Status = x.Status
                }
                ) .ToListAsync();
        }

        public async Task<EmployeeQueryModel> GetById(int id)
        {
            return await _context.Employees.Where(x => x.Id == id).Select(x=> new EmployeeQueryModel
            {
                Id = x.Id,
                Name = x.Name,
                Salary = x.Salary,
                Department = x.Department.Name,
                EmailId = x.EmailId,
                JoiningDate = x.JoiningDate,
                Status = x.Status
            }).FirstOrDefaultAsync();
        }
    }
}
