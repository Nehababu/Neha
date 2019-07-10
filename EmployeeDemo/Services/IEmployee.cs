using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDemo.Services
{
   public interface IEmployee
    {
         IEnumerable<Employee> GetEmployees();
       
        void CreateEmployees(Employee employee);
        void UpdateEmployees(int id);
        void DeleteEmployees(int id);

    }
}
