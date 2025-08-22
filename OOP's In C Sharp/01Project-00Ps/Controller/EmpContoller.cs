using OOPsInCSharp._01Project_00Ps.Models;
using OOPsInCSharp._01Project_00Ps.Services.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsInCSharp._01Project_00Ps.Controller
{
    public class EmpContoller
    {
        public static void EmpAppController()
        {
            EmployeeServices employeeServices = new EmployeeServices();

            while (1==1) {
                int Choise = 0;

                Console.WriteLine("1.Add Employee");
                Console.WriteLine("2.Update Employee");
                Console.WriteLine("3.Remove Employee");
                Console.WriteLine("4.Show Employee");
                Console.WriteLine("Enter a Choise : ");

                Choise = Convert.ToInt32(Console.ReadLine());

                int Eid;
                string Ename, DeptName;
                decimal ESalary;
                int DeptId;
                


                switch (Choise)
                {

                    case 1:
                        Console.WriteLine("------- Add Employee ---------");
                        Console.WriteLine();
                        Console.WriteLine("Enter a EmpId :");
                         Eid = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter a Employee Name : ");
                         Ename = Console.ReadLine();

                        Console.WriteLine("Enter a Employee Salary : ");
                         ESalary = Convert.ToDecimal(Console.ReadLine());

                        Console.WriteLine("Enter a DeptID :");
                         DeptId = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter a DeptName :");
                         DeptName = Console.ReadLine();

                        Department department = new Department() { DeptId = DeptId, DeptName = DeptName };

                        Employee employee = new Employee() { EmpId = Eid, EmpName = Ename, EmpSalary = ESalary, Department = department };

                        employeeServices.AddEmployee(employee);
                        break;
                    case 2:
                        Console.WriteLine("------- Update Employee ---------");
                        Console.WriteLine();
                        Console.WriteLine("Enter a Previous EmpId :");
                        Eid = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Update Employee Name : ");
                        Ename = Console.ReadLine();

                        Console.WriteLine("Update Employee Salary : ");
                        ESalary = Convert.ToDecimal(Console.ReadLine());

                        Console.WriteLine("Update DeptID :");
                        DeptId = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Update DeptName :");
                        DeptName = Console.ReadLine();
                       
                        Department DeptUpdate = new Department() { DeptId = DeptId, DeptName = DeptName };

                        Employee UpdatedEmp = new Employee() { EmpId = Eid, EmpName = Ename, EmpSalary = ESalary, Department = DeptUpdate };

                        employeeServices.UpdateEmployee(Eid , UpdatedEmp);

                        break;
                    case 3:
                        Console.WriteLine("------- Remove Employee ---------");
                        Console.WriteLine();
                        Console.WriteLine("Enter a EmpId witch you want to Remove :");
                        Eid = Convert.ToInt32(Console.ReadLine());
                        employeeServices.RemoveEmployee(Eid);
                        break;
                    case 4:
                        Console.WriteLine("All Employee List");
                        employeeServices.ShowEmployee();
                        break;
                    default:
                        Console.WriteLine("Please enter a valid choise...!!!");
                        break;

                }
            }


        }
    }
}
