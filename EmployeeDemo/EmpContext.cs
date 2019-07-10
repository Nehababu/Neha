using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EmployeeDemo
{
    public class EmpContext:DbContext
    {
        public EmpContext()
        {
        }
        public IConfiguration configuration;

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionDb = configuration.GetConnectionString("MyConnection");
            optionsBuilder.UseSqlServer(@"Server=BLR-7033-WIN;Database=Employeeinfodb;Trusted_Connection=true");
        }
        public EmpContext(DbContextOptions<EmpContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        DbSet<Employee> Employees { get; set; }

        public void createdata( Employee employee)
        {
            var context = new EmpContext();
            context.Employees.Add(employee);
            context.SaveChanges();
        }

        public List<Employee> Getdata()
        {
            var context = new EmpContext();
            var EmpDetails = context.Employees.ToList();

            
            return EmpDetails;

           
        }

        public void UpdateData(int id)
        {
            var context = new EmpContext();

            var entity = context.Employees.FirstOrDefault(s => s.EmployeeId == id);


            if (entity != null)
            {

                entity.EmployeeName = "Neha";

                context.Employees.Update(entity);


                context.SaveChanges();
      
            }


        }
        public void DeleteData(int id)
        {
            var context = new EmpContext();

            var entity = context.Employees.FirstOrDefault(s => s.EmployeeId == id);


            if (entity != null)
            {

                context.Employees.Remove(entity);

                context.SaveChanges();

            }


        }

    }
}

