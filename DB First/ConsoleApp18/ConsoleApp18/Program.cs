using System;
using System.Data.SqlClient;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                //Creating Connection
                con = new SqlConnection(@"data source=(localdb)\MSSQLLocalDB;database=University;
                                            integrated security=SSPI");
                //writing sql query
                SqlCommand cm = new SqlCommand("select * from Department", con);

                //Open command
                con.Open();

                //Executing the sql 
                SqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["Id"] + " " + sdr["DeptName"] + " " + sdr["Location"] + " " + sdr["Num_Of_Staff"]);
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