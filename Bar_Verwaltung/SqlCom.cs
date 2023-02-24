using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Globalization;
using System.Data;

namespace Bar_Verwaltung
{
    internal class SqlCom
    {
        public static SqlConnection con = new SqlConnection("Server = (localdb)\\MSSQLLocalDB; Integrated Security = true;");//   Database = Phil;      
        public static SqlCommand cmd = new SqlCommand("", con);
        public static int UID; // current UserID
        static SqlDataAdapter adapter;
        static DataTable dt;

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
                SqlCom.NewItem(1, "Wasser", 500, 3.5, "Wasser");
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
                con.Open(); //coment
                cmd.CommandText = "Create Table TFinance(ID int identity(1,1),HMS nvarchar(50),PID int,Date Date);";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Create Table TLogin(UserID int IDENTITY (1,1) PRIMARY KEY,Username nvarchar(50),Password nvarchar(128));";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Create Table TStock(ID int identity(1,1) PRIMARY KEY,Drink int,Item nvarchar(50),Quantaty int,Price int,Ingrediens text);";//not finished
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }

        }
        public static bool Login(string user, string password)
        {
            string pw = string.Empty;
            cmd.CommandText = string.Format("Select Password from TLogin where Username = '{0}';",user);
            con.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    pw = reader.GetString(0);
                }
            }

            reader.Close();
            con.Close();

            return BCrypt.CheckPassword(password,pw);
        }
        public static void Register(string user, string pw)
        {
            string hpw = BCrypt.HashPassword(pw, BCrypt.GenerateSalt());//hasped password
            cmd.CommandText = string.Format("Insert into TLogin(Username,Password) Values ('{0}','{1}');", user, hpw);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void NewItem(int drink,string name, int quantaty, double price, string ingrediens)
        {
            string pri = price.ToString(new CultureInfo("en-US"));
            cmd.CommandText = string.Format("Insert into TStock(Drink, Item, Quantaty, Price,Ingrediens) Values({0},'{1}',{2},{3},'{4}');",drink,name,quantaty,pri,ingrediens);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static DataTable DataGrid(string tablename)
        {
            //ds = new DataSet();
            dt = new DataTable();
            adapter = new SqlDataAdapter("Select * from " + tablename, con);
            //adapter.Fill(ds,"MyData");
            adapter.Fill(dt);
            return dt;
        }
    }
}
