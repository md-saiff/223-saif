using System;
using System.Configuration;
using System.Text;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using System.Xml;
using System.Data.SqlClient;

namespace ConsoleApp15
{
    class Program
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
                SqlCommand cm = new SqlCommand("select * from Employees", con);

                //Open command
                con.Open();

                //Executing the sql 
                SqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["LastName"] + " " + sdr["Region"]);
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
