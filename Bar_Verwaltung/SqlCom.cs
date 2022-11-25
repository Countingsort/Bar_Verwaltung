using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Bar_Verwaltung
{
    internal class SqlCom
    {
        public static SqlConnection con = new SqlConnection("Server = (localdb)\\MSSQLLocalDB; Integrated Security = true;");//   Database = Phil;      
        public static SqlCommand cmd = new SqlCommand("", con);
        public static int UID; // current UserID

        public static bool CheckDatabaseExists(string databaseName)
        {
            cmd.CommandText = "Select database_id From sys.databases Where Name = '" + databaseName + "'";
            con.Open();
            object temp = cmd.ExecuteScalar();
            con.Close();

            if (temp != null)
            {

                con = new SqlConnection("Server = (localdb)\\MSSQLLocalDB;Integrated Security = true;Database = Bar3IT22;");
                cmd.Connection = con;
                return true;
            }
            else
            {

                CreateDatabase();
                con = new SqlConnection("Server = (localdb)\\MSSQLLocalDB;Integrated Security = true;Database = Bar3IT22;");
                cmd.Connection = con;
                CreateTable();
                return false;
            }

        }
        private static void CreateDatabase()
        {

            cmd.CommandText = "CREATE DATABASE Bank3IT22";
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception x)
            {
                Console.Write(x);
            }

        }
        private static void CreateTable()
        {
            try
            {
                con.Open();
                cmd.CommandText = "Create Table TFinance(ID int identity(1,1),HMS nvarchar(50),PID int,Date Date);";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Create Table TLogin(UserID int,Username nvarchar(50),Password nvarchar(64),Permission nvarchar(1),Salt nvarchar(16));";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Create Table TStock(ID int identity(1,1),Date date,number1 nvarchar(50),number2 nvarchar(50),Amount int,Message nvarchar(50));";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }

        }
    }
}
