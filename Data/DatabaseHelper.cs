using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace equipmentTracker.Data
{
    public class DatabaseHelper
    {

        public void Connect()
        {
            string constr;
            //SqlConnection conn;
            constr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EquipmentTrackerDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Application Name=\"SQL Server Management Studio\";Command Timeout=0";
            using (SqlConnection connection = new SqlConnection(constr))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection Opened");

                    List<SqlCommand> commands = new List<SqlCommand>();

                    //query commands
                    string query = "SELECT * FROM Equipment";

                    commands.Add(new SqlCommand(query, connection));

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");             
                }
            }
        }
        public bool TestConnection()
        {
            string conn;
            // SqlConnection conn;
            conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EquipmentTrackerDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Application Name=\"SQL Server Management Studio\";Command Timeout=0";
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    Console.WriteLine("Connection Opened");
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
