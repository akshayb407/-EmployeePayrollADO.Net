using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeePayrollService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
       
        [TestMethod]
        public void TestMethod1()
        {
            EmployeeRepo repo = new EmployeeRepo();
            EmployeeModel employee = new EmployeeModel();
            employee.EmployeeName = "Satish";
            employee.Department = "Developer";
            employee.PhoneNumber = "5826357895";
            employee.Address = "Delhi";
            employee.Gender = 'M';
            employee.BasicPay = 15000.00M;
            employee.Deductions = 200.00;
            employee.StartDate = Convert.ToDateTime("2020-10-08");
            //Mock<EmployeeRepo> mockObj = new Mock<EmployeeRepo>();
            //mockObj.Setup(t=>t.AddEmployee(It.IsIn<EmployeeModel>)).return (true);
            var result = repo.AddEmployee(employee);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetAllEmployeeShouldReturnListOfRecords()
        {
            EmployeeRepo repo = new EmployeeRepo();
            var result = repo.GetAllEmployee();
            Assert.IsTrue(result);
        }
    }
}
