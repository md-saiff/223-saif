using System;

using System.Data.SqlClient;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                //Creating Connection
                con = new SqlConnection(@"data source=(localdb)\MSSQLLocalDB;database=Employee;
                                            integrated security=SSPI");
                //writing sql query
                SqlCommand cm = new SqlCommand("select * from EmployeeDetails", con);

                //Open command
                con.Open();

                //Executing the sql 
                SqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["FirstName"] +" "+sdr["LastName"] + " " + sdr["Salary"] + " " + sdr["Phone_No"] + " " + sdr["Address"]);
                }
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something is wrong " + e);
            }
        }
    }
}
