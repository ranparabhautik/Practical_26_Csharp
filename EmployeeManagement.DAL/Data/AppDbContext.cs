using EmployeeManagement.DAL.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DAL.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Department>().HasData(

                new Department { Id = 1, Name = "IT", IsDeleted = false },
                new Department { Id = 2, Name = "HR", IsDeleted = false },
                new Department { Id = 3, Name = "Sales", IsDeleted = false },
                new Department { Id = 4, Name = "OnSite", IsDeleted = false },
                new Department { Id = 5, Name = "Admin", IsDeleted = false }
            );
        }
    }
}
