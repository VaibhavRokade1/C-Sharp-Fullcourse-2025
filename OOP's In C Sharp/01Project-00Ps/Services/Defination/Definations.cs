using OOPsInCSharp._01Project_00Ps.Models;
using System;
using System.Linq;
namespace OOPsInCSharp._01Project_00Ps.Services.Defination
{
    public interface IEmployeeServices {
        void AddEmployee(Employee employee);
        void UpdateEmployee(int Id , Employee employee);
        void ShowEmployee();
        void RemoveEmployee(int Id);     
    }

    public interface IDepartmentServices {
        void AddDept(Department department);
        void UpdateDept(int id, Department department);
        void RemoveDept(int id);
    }
}
