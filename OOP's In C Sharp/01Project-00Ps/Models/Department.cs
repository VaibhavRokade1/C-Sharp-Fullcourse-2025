using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsInCSharp._01Project_00Ps.Models
{
    public class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public override string ToString()
        {
            return $" Deparatment : [ DeptId : {DeptId} , DeptName : {DeptName} ]";
        }
    }
}
