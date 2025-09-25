using ADO.NET_Pragrams.Models;
using ADO.NET_Pragrams.Services.Defination;
using ADO.NET_Pragrams.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ADO.NET_Pragrams.Services.EmployeeServices.Implimentation
{
    class EmployeeServices : IEmployeeDefination
    {
       Utilitys ut =  Utilitys.GetUtilInstance();
        SqlConnection conn = null;
       public  void AddEmployee(Employee employee)
        {
            try 
            {
                // connection string pass keli 
                conn = new SqlConnection(ut.conString);
                conn.Open();
                // Connection start kele 

                // SQL_QUERY create karun tila dynamic values pass keliya
                string SQl_QUERY = "INSERT INTO EMPLOYEES ( EName , ESalary ) VALUES (@name , @salary);";

                // sql command madhe query + connection pass kele  
                SqlCommand sqlCon = new SqlCommand(SQl_QUERY , conn);

                // parameters dymanic pass kele 
                sqlCon.Parameters.AddWithValue("@name" , employee.EName);
                sqlCon.Parameters.AddWithValue("@salary" , employee.ESalary);

                // query execute keli
                int res = sqlCon.ExecuteNonQuery();

                // connection stop kela
                conn.Close();

                if (res > 0)
                    Console.WriteLine("Recourd Insteted Successfully...");
                else
                    Console.WriteLine("Something went wroung...?");
            }
            catch (SqlException ex) 
            {
                Console.WriteLine("Database Error Into the ( Add Employee ) Method . ");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        public void DeleteEmployee(int id)
        {
            conn = new SqlConnection(ut.conString);

            conn.Open();

            string SQL_QUERY = "DELETE FROM EMPLOYEES WHERE EID = @id";

            SqlCommand cmd = new SqlCommand( SQL_QUERY, conn);

            cmd.Parameters.AddWithValue("@id", id);

            int res = cmd.ExecuteNonQuery();

            conn.Close();

            if (res > 0)
                Console.WriteLine("Record Deleted Sunccessfully...");
            else
                Console.WriteLine("Record Not Deleted...");

            
        }

        public void ShowEmployee()
        {
            conn = new SqlConnection(ut.conString);
            conn.Open();
            string SQL_QUERY = "SELECT * FROM EMPLOYEES;";

            SqlCommand cmd = new SqlCommand( SQL_QUERY , conn);

            SqlDataReader reader =  cmd.ExecuteReader();
            
            List<Employee> empList = new List<Employee>();

            while (reader.Read())
            {
                int id = (int)(reader["EID"]);
                string name = (string)reader["EName"];
                double salary = Convert.ToDouble(reader["ESalary"]);

                empList.Add(new Employee { Id = id, EName = name, ESalary = salary });
            }
            conn.Close();

            empList.ForEach(Console.WriteLine);

        }

        public void UpadteEmployee(int id, Employee employee)
        {
            conn = new SqlConnection(ut.conString);
            conn.Open();
            string SQL_QUERY = $"UPDATE EMPLOYEES SET ENAME = @name, ESALARY = @salary WHERE EID = {id} ;";
            SqlCommand cmd = new SqlCommand(SQL_QUERY , conn);

            cmd.Parameters.AddWithValue("@name" , employee.EName);
            cmd.Parameters.AddWithValue("@salary" , employee.ESalary);

            int res = cmd.ExecuteNonQuery();

            conn.Close();

            if (res > 0)
                Console.WriteLine("Employee Updated Successfully...");
            else
                Console.WriteLine("Failed to Update...!");
        }
    }
}
