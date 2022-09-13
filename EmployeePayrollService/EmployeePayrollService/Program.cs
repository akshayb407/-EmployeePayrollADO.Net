using System;
using EmployeePayrollService;
namespace EmployeePayrollService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            EmployeeRepo repo = new EmployeeRepo();
            EmployeeModel model = new EmployeeModel();
            Console.WriteLine("Enter the id");
            repo.GetAllEmployee(Console.ReadLine());
            Console.ReadLine();

        }
    }
}
