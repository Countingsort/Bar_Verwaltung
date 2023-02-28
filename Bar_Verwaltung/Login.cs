﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar_Verwaltung
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            if (!SqlCom.CheckDatabaseExists("Bar3IT22"))
            {
                MessageBox.Show("Database error /Login/L20");
            }
        }

        private void btn_1_Click(object sender, EventArgs e) //Markus why btn_1 name
        {
            string user = txtB_1.Text;
            string pw = txtB_2.Text;        
            bool exist = SqlCom.Login(user, pw);
            if (exist)
            {
                Form1 Frm_Main = new Form1(); // opens main form
                this.Hide();
                Frm_Main.ShowDialog();
                this.Show();
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            Register f1 = new Register();
            this.Hide();
            f1.ShowDialog();
            this.Show();
        }
    }
}
