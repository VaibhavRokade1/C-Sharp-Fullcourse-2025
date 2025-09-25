using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_Pragrams.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string EName { get; set; }
        public double ESalary { get; set; }

        public override string ToString()
        {
            return $"[ Id : {this.Id} , Name : {this.EName} , Salary : {this.ESalary} ]";
        }
    }
}


//Employee employee = new Employee() { Id = 1, EName = "Vaibhav", ESalary = 25000 };
       
            //SqlConnection con = new SqlConnection();

            //con.Open();

            //string query = "insert into Employees (EName,ESalary) values(@EName,@ESalary)";

            //con.CreateCommand();

            //SqlCommand cmd = new SqlCommand(query , con);


            //cmd.Parameters.AddWithValue("@EName","");
            //cmd.Parameters.AddWithValue("@ESalary", 20000);

            //int res =  cmd.ExecuteNonQuery();
            //string msg = (res > 0) ? "Data Insert Successfully..." : "Insertion  Failed...";

            //Console.WriteLine(msg);

            //con.Close();