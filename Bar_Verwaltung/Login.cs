using System;
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
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            string user = txtB_1.Text;
            string password = txtB_2.Text;

            Form1 f2 = new Form1();
            this.Hide();
            f2.ShowDialog();
            this.Show();
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
