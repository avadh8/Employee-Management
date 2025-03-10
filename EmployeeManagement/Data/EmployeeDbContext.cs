using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
             new Employee
             {
                 Id = 1,
                 Name = "John Smith",
                 Designation = "Software Developer",
                 Department = "IT",
                 DateOfJoining = new DateOnly(2020, 6, 15)
             },
    new Employee
    {
        Id = 2,
        Name = "Sarah Johnson",
        Designation = "Project Manager",
        Department = "IT",
        DateOfJoining = new DateOnly(2018, 3, 22)
    },
    new Employee
    {
        Id = 3,
        Name = "James Brown",
        Designation = "HR Manager",
        Department = "HR",
        DateOfJoining = new DateOnly(2019, 9, 10)
    },
    new Employee
    {
        Id = 4,
        Name = "Emily Davis",
        Designation = "Marketing Specialist",
        Department = "Marketing",
        DateOfJoining = new DateOnly(2021, 12, 5)
    },
    new Employee
    {
        Id = 5,
        Name = "Michael Wilson",
        Designation = "Data Analyst",
        Department = "Analytics",
        DateOfJoining = new DateOnly(2022, 1, 30)
    }
        );
        }



    }
}
    

