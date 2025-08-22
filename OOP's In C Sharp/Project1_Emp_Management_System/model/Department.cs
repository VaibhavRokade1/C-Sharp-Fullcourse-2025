using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsInCSharp.Project1_Emp_Management_System.model
{
    public class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }

        public override string ToString()
        {
            return $"Deparment : [DeptId :{this.DeptId}]";
        }
    }
}
