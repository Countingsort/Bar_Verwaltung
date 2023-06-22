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
                SqlCom.NewItem(1, "Wasser", 500, 3.5, "Wasser",0,"0");
                SqlCom.NewItem(1, "Apfelsaft", 200, 4.5, "Apfel, zucker", 0, "0");
                SqlCom.NewItem(1, "Cola", 40, 4.5, "Cola", 0, "0");
                SqlCom.NewItem(1, "Bier 0,33", 50, 3.4, "Hefe, Hopfen, Wasser", 5, "16");
                SqlCom.NewItem(0, "Schnitzel", 80, 18, "Schwein, Kartoffel, Zitrone, Ei, Mehl", 0, "0");
                SqlCom.NewItem(0, "Pommes", 120, 5, "Kartoffel, Salz, Öl", 0, "0");
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
                cmd.CommandText = "Create Table TFinance(ID int identity(1,1),HMS int,PID int,Date nvarchar(128));";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Create Table TLogin(UserID int IDENTITY (1,1) PRIMARY KEY,Username nvarchar(50),Password nvarchar(128));";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Create Table TStock(ID int identity(1,1) PRIMARY KEY,Drink int,Item nvarchar(50),Quantaty int,Price decimal(15,2),Ingrediens text,Percentage decimal(15,2),FSK nvarchar(2));";//not finished
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
            try
            {
                return BCrypt.CheckPassword(password, pw);
            }
            catch
            {
                return false;
            }
            
        }
        public static void Register(string user, string pw)
        {
            string hpw = BCrypt.HashPassword(pw, BCrypt.GenerateSalt());//hasped password
            cmd.CommandText = string.Format("Insert into TLogin(Username,Password) Values ('{0}','{1}');", user, hpw);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void NewItem(int drink,string name, int quantaty, double price, string ingrediens, double percentage,string fsk)
        {
            string pri = price.ToString(new CultureInfo("en-US"));
            cmd.CommandText = string.Format("Insert into TStock Values({0},'{1}',{2},{3},'{4}',{5},'{6}');", drink,name,quantaty,pri,ingrediens,percentage,fsk);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void DelItem(int id)
        {
            cmd.CommandText = string.Format("Delete from TStock where ID={0};",id);
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
        public static void DataUpdate()
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            builder.GetInsertCommand();
            adapter.Update(dt);
        }
        public static void EditItem(int drink, string name, int quantaty, double price, string ingrediens, double percentage, string fsk, int ID)
        {
            string pri = price.ToString(new CultureInfo("en-US"));
            string per = percentage.ToString(new CultureInfo("en-US"));
            cmd.CommandText = string.Format("Update TStock Set Drink = {0},Item='{1}',Quantaty={2},Price={3},Ingrediens='{4}',Percentage={5},fsk='{6}' where ID={7};", drink, name, quantaty, pri, ingrediens, per, fsk,ID);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void newFinance(int HMS, int PID, string dateTime)
        {
            cmd.CommandText = String.Format("Insert into TFinance Values({0}, {1}, '{2}');", HMS, PID, dateTime);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
