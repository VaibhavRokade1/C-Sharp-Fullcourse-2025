using ADO.NET_Pragrams.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_Pragrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeController employeeController = new EmployeeController();
            employeeController.EmployeeContr();
        }
    }
}
