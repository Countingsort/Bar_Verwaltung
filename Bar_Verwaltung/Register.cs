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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void  button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(button1.Text))
            {
                MessageBox.Show("Der Benutzername ist leer");
                txtB_1.Clear();
                txtB_2.Clear();
                txtB_3.Clear();
            }
            else if (txtB_2.Text is not null && txtB_2.Text.Equals(txtB_3.Text) || txtB_3.Text is not null && txtB_2.Text.Equals(txtB_3.Text)) 
            {
                string user = txtB_1.Text;
                int password = Convert.ToInt32(txtB_2);

            }
        }
    }
}
