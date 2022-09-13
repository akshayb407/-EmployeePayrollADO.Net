using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EmployeePayrollService
{
    class EmployeeRepo
    {
        //DESKTOP-A89I0AG\AKSHAY
        public static string connectionString = @"Server=DESKTOP-A89I0AG;Database=Payroll_service;Trusted_Connection=true;";
        public bool GetAllEmployee(string name)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);

                EmployeeModel employeeModel = new EmployeeModel();
                using (connection)
                {
                    string query = @"select * from employee_payroll where name =" +name;
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            employeeModel.EmployeeID = Convert.ToInt32(dr[0]);
                            employeeModel.EmployeeName = dr[1].ToString();

                           

                            Console.WriteLine(employeeModel.EmployeeID + " " + employeeModel.EmployeeName);
                           // Console.WriteLine(employeeModel.EmployeeName+" "+employeeModel.BasicPay+ " "+employeeModel.StartDate +" "+ employeeModel.Gender+" "+ employeeModel.PhoneNumber+" "+employeeModel.Address+" "+ employeeModel.Department+" "+ employeeModel.Deductions+" "+ employeeModel.TaxablePay+" "+ employeeModel.Tax+" "+ employeeModel.NetPay);
                            System.Console.WriteLine("\n");
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("No data found");
                        return false;
                    }
                    return true;
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool AddEmployee(EmployeeModel model)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);

                using (connection)
                {
                    //var qury=values()
                    SqlCommand command = new SqlCommand("SpAddEmployeeDetails", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EmployeeName", model.EmployeeName);
                    command.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber);
                    command.Parameters.AddWithValue("@Address", model.Address);
                    command.Parameters.AddWithValue("@Department", model.Department);
                    command.Parameters.AddWithValue("@Gender", model.Gender);
                    command.Parameters.AddWithValue("@BasicPay", model.BasicPay);
                    command.Parameters.AddWithValue("@Deductions", model.Deductions);
                    command.Parameters.AddWithValue("@TaxablePay", model.TaxablePay);
                    command.Parameters.AddWithValue("@Tax", model.Tax);
                    command.Parameters.AddWithValue("@NetPay", model.NetPay);
                    command.Parameters.AddWithValue("@StartDate", DateTime.Now);
                    command.Parameters.AddWithValue("@City", model.City);
                    command.Parameters.AddWithValue("@Country", model.Country);
                    connection.Open();
                    var result = command.ExecuteNonQuery();
                    connection.Close();
                    if (result != 0)
                    {

                        return true;
                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
            }
            return false;
        }
    }
}
