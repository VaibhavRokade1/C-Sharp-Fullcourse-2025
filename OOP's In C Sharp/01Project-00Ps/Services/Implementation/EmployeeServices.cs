using OOPsInCSharp._01Project_00Ps.Models;
using OOPsInCSharp._01Project_00Ps.Services.Defination;
using System;
using System.Linq;

namespace OOPsInCSharp._01Project_00Ps.Services.Implementation
{
    public class EmployeeServices : IEmployeeServices
    {
        public static Employee[] AllEmployeesList = new Employee[10];
        public static int i = 0;
        public void AddEmployee(Employee employee)
        {
            if(employee != null)
                AllEmployeesList[i++] = employee;
            else
                Console.WriteLine("Please Enter a Employee Details Properly...");
        }
        public void UpdateEmployee(int Id, Employee employee)
        {
            Console.WriteLine(employee);
            for (int i = 0; i < AllEmployeesList.GetLength(0); i++) {

                if (AllEmployeesList[i].EmpId == Id)
                {
                    AllEmployeesList[i] = employee;
                    Console.WriteLine("Employee Updated Successfully...");
                    break;

                }
            }
        }
        public void RemoveEmployee(int Id)
        {
            AllEmployeesList = AllEmployeesList.Where(emp => emp!=null && emp.EmpId != Id).ToArray();
        }
        public void ShowEmployee()
        {
            foreach (var employee in AllEmployeesList)
            {
                if (employee != null) {
                    Console.WriteLine(employee);
                }
            }
        }
    }
}
