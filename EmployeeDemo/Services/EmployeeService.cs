using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDemo.Services
{

    public class EmployeeService : IEmployee
    {
        EmpContext emp = new EmpContext();

     

        public void CreateEmployees(Employee employee)
        {
            emp.createdata(employee);
        }

        public void DeleteEmployees(int id)
        {
            emp.DeleteData(id);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return emp.Getdata();
        }

        public void UpdateEmployees(int id)
        {
            emp.UpdateData(id);
        }
    }
}
