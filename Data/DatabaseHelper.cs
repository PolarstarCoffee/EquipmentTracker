using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace equipmentTracker.Data
{
    internal class DatabaseHelper
    {
        static void Connect()
        {
            string constr;
            SqlConnection conn;
            constr = "\"Server=(localdb)\\\\MSSQLLocalDB;Database=EquipmentTrackerDB;Trusted_Connection=True;\"";
            using (SqlConnection connection = new SqlConnection(constr))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection Opened");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");             }
            }
        }
    }
}
