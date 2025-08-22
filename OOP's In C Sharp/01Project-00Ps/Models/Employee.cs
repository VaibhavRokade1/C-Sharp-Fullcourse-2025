using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsInCSharp._01Project_00Ps.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public decimal EmpSalary { get; set; }
        public Department Department { get; set; }
        public override string ToString()
        {
            return $"Employee[Id :{EmpId} , Name :{EmpName} , Salary :{EmpSalary}] , {Department}";
        }
    }
}
