using ADO.NET_Pragrams.Models;
using ADO.NET_Pragrams.Services.EmployeeServices.Implimentation;
using ADO.NET_Pragrams.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_Pragrams.Controllers
{
    public class EmployeeController
    {
        public void EmployeeContr() 
        {
          int Choise = 0;
          Employee emp = new Employee();
          EmployeeServices employeeServices = new EmployeeServices();
            do
            {
                Console.WriteLine("\n1.Add New Employee ");
                Console.WriteLine("2.Update Employee ");
                Console.WriteLine("3.Delete Employee ");
                Console.WriteLine("4.Show All Employee ");
                Console.WriteLine("=>Enter A Choise : ");

                Choise = int.Parse(Console.ReadLine());

                switch (Choise) 
                {
                    case 1:
                        Console.WriteLine("----- Add New Employee ----- ");
                        Console.WriteLine("Enter a Employee Name : ");
                        emp.EName = Console.ReadLine();

                        Console.WriteLine("Enter a Employee Salary : ");
                        emp.ESalary = double.Parse(Console.ReadLine());

                        employeeServices.AddEmployee(emp);
                        break;
                    case 2:
                        int id1 = 0;
                        Console.WriteLine("----- Update Employee Record ----- ");

                        Console.WriteLine("Enter a Employee ID Witch You Want To Update Details :");
                        id1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter a ( New ) Employee Name : ");
                        emp.EName = Console.ReadLine();

                        Console.WriteLine("Enter a ( New ) Employee Salary : ");
                        emp.ESalary = double.Parse(Console.ReadLine());

                        employeeServices.UpadteEmployee( id1 , emp);
                        break;
                    case 3:
                        Console.WriteLine("----- Delete Employee ----- ");
                        int id2 = 0;
                        Console.WriteLine("Enter a Employee ID Witch you want to delete : ");
                        id2 = int.Parse(Console.ReadLine());
                        employeeServices.DeleteEmployee(id2);
                        break;
                    case 4:
                        Console.WriteLine("----- Employee List ------ ");
                        employeeServices.ShowEmployee();
                        break;
                    default :
                        Console.WriteLine("Invalid Choice...!!!");
                        break;
                }
            } while (true);        
        }
    }
}
