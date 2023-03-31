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
    public partial class Page_Storage : UserControl
    {
        public Page_Storage()
        {
            InitializeComponent();
            dgv_Data.DataSource = SqlCom.DataGrid("TStock");
            txt_FSK.Items.Add("0");
            txt_FSK.Items.Add("16");
            txt_FSK.Items.Add("18");
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            int drink;
            double percent;
            string fsk;
            if (ckb_Drink.Checked)
            {
                drink = 1;
            }
            else
            {
                drink = 0;
            }

            if (ckb_Alcoholic.Checked)
            {
                percent = Convert.ToDouble(txt_Percantage.Text);
                fsk = txt_FSK.Text;
            }
            else
            {
                percent = 0;
                fsk = "0";
            }

            try
            {
                SqlCom.NewItem(drink, txt_Name.Text, Convert.ToInt32(txt_Quantaty.Text), Convert.ToDouble(txt_Price.Value), txt_Ingridiens.Text, percent, fsk);
            }
            catch
            {

            }
            
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int drink;
            double percent;
            string fsk;

            if (ckb_Drink.Checked)
            {
                drink = 1;
            }
            else
            {
                drink = 0;
            }

            if (ckb_Alcoholic.Checked)
            {
                percent = Convert.ToDouble(txt_Percantage.Text);
                fsk = txt_FSK.Text;
            }
            else
            {
                percent = 0;
                fsk = "0";
            }

            try
            {
                SqlCom.EditItem(drink, txt_Name.Text, Convert.ToInt32(txt_Quantaty.Text), Convert.ToDouble(txt_Price.Value), txt_Ingridiens.Text, percent, fsk, Convert.ToInt32(txt_ID.Text));
            }
            catch
            {

            }
            
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SqlCom.DelItem(Convert.ToInt32(txt_ID.Text));
        }
    }
}
