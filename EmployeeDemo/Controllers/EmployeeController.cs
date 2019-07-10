using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeDemo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;


namespace EmployeeDemo.Controllers
{

    [Route("api/Employee")]


    public class EmployeeController: Controller
    {
        
        private readonly IEmployee _employeeservices;
       
        public EmployeeController(IEmployee employeeservices )
        {
            _employeeservices = employeeservices;
        }

       

        EmpContext epmctx = new EmpContext();
        

        [HttpPost]
        public IActionResult Register(Employee employee)
        {
            _employeeservices.CreateEmployees(employee);


            epmctx.createdata(employee);
            return Ok("EmployeeData gets created");
        }

        [HttpGet]
        public IActionResult GetEmpdetails()
        {

            
            return Ok(_employeeservices.GetEmployees());
            
        }
        [HttpPut, Route("{id}")]
        public IActionResult UpdateData(int id)
        {
            _employeeservices.UpdateEmployees(id);
            return Ok("Updated Successfully");
        }
        [HttpDelete, Route("{id}")]
        public IActionResult DeleteData(int id)
        {
            _employeeservices.DeleteEmployees(id);
            return Ok("Deleted successfully");
        }
    }
}
