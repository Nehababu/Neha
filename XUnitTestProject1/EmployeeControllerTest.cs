using EmployeeDemo.Controllers;
using EmployeeDemo.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject1
{
    class EmployeeControllerTest
    {
        public EmployeeControllerTest()
        {
            var Empservice = new Mock<EmployeeService>();
            var _employeeController = new Mock<EmployeeController>(Empservice);

        }

        [Fact]
    }
}
