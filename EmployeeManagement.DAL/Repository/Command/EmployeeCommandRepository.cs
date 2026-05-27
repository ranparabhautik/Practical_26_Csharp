using EmployeeManagement.DAL.Data;
using EmployeeManagement.DAL.Models.CommandModel;
using EmployeeManagement.DAL.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DAL.Repository.Command
{
    public class EmployeeCommandRepository : IEmployeeCommandRepository
    {
        protected readonly AppDbContext _context;
        public EmployeeCommandRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task Create(EmployeeCommandModel entity)
        {
            Employee emp = new Employee()
            {
                Name = entity.Name,
                Salary = entity.Salary,
                DepartmentId = entity.DepartmentId,
                EmailId = entity.EmailId
            };
            await _context.Employees.AddAsync(emp);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var existing = await _context.Employees.FindAsync(id);
            existing.IsDeleted = true;
            await _context.SaveChangesAsync();
        }

        public async Task Update(int id,EmployeeCommandModel entity)
        {
            var existing = await _context.Employees.FindAsync(id);

            existing.Name = entity.Name;
            existing.DepartmentId = entity.DepartmentId;
            existing.EmailId = entity.EmailId;
            existing.Salary = entity.Salary;
                
            _context.Employees.Update(existing);
            await _context.SaveChangesAsync();
        }
    }
}
