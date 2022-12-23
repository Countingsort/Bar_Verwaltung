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

            cmd.CommandText = "CREATE DATABASE Bar3IT22";
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
                cmd.CommandText = "Create Table TLogin(UserID int IDENTITY (1,1) PRIMARY KEY,Username nvarchar(50),Password nvarchar(128));";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Create Table TStock(ID int identity(1,1),Boolean Drink,nvarchar(50) Item,int Quantaty, int Price,text Ingrediens;";//not finished
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }

        }
        public static string Login(string user)
        {
            string pw = string.Empty;

            cmd.CommandText = string.Format("Slect Password from TLogin where password = {0};",user);

            return pw;
        }
        public static void Register(string user, string pw)
        {
            string hpw = BCrypt.HashPassword(pw, BCrypt.GenerateSalt());//hasped password
            cmd.CommandText = string.Format("Insert into TLogin(Username,Password) Values ({0},{1});", user, hpw);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void NewItem()
        {
            cmd.CommandText = string.Format("Insert into TStock()");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
