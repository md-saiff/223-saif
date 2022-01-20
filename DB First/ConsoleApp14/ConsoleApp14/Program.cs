using System;

using System.Data.SqlClient;

namespace ConsoleApp14
{
    internal class Program
    {

        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                //Creating Connection
                con = new SqlConnection(@"data source=(localdb)\MSSQLLocalDB;database=NorthWind;
                                            integrated security=SSPI");
                //writing sql query
                SqlCommand cm = new SqlCommand("select * from Customers", con);

                //Open command
                con.Open();

                //Executing the sql 
                SqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["CompanyName"] + " " + sdr["Region"]);
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
