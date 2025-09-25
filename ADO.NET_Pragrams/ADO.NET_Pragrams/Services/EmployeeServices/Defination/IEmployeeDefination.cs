using ADO.NET_Pragrams.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_Pragrams.Services.Defination
{
    public interface IEmployeeDefination {

        void AddEmployee(Employee employee);
        void UpadteEmployee(int id , Employee employee);
        void DeleteEmployee(int id);
        void ShowEmployee();
    }
}
