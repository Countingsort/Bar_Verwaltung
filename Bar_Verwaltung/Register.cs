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

        private void  button1_Click(object sender, EventArgs e) //markus why button1 as name
        {
            if (string.IsNullOrEmpty(button1.Text))
            {
                MessageBox.Show("The Username is empty");
                txtB_1.Clear();
                txtB_2.Clear();
                txtB_3.Clear();
            }
            else if (!txtB_2.Text.Equals(txtB_3.Text))
            {
                MessageBox.Show("The Password don't match up!");
            }
            //else if (txtB_2.Text is not null && txtB_2.Text.Equals(txtB_3.Text) || txtB_3.Text is not null && txtB_2.Text.Equals(txtB_3.Text)) 
            //{
            //    string user = txtB_1.Text;
            //    int password = Convert.ToInt32(txtB_2); // why is password a int?????
            //}
            else
            {
                SqlCom.Register(txtB_1.Text, txtB_2.Text);
                MessageBox.Show("You Account has been created!");
            }
        }
    }
}
