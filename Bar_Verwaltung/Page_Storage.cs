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
            ckb_Alcoholic.Checked = true;
            txt_Percantage.Enabled = false;
            txt_FSK.Enabled = false;
            ckb_Alcoholic.Enabled = false;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            int drink;
            double percent = 0;
            string fsk = "0";
            byte error = 0;
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
                try
                {
                    percent = Convert.ToDouble(txt_Percantage.Text);
                    fsk = txt_FSK.Text;
                }
                catch (Exception ex)
                {
                    error = 1;
                }

            }
            else
            {
                percent = 0;
                fsk = "0";
            }

            try
            {
                SqlCom.NewItem(drink, txt_Name.Text, Convert.ToInt32(txt_Quantaty.Text), Convert.ToDouble(txt_Price.Value), txt_Ingridiens.Text, percent, fsk);
                dgv_Data.DataSource = SqlCom.DataGrid("TStock");//Updates the Dataggridview
                dgv_Data.Update();
                dgv_Data.Refresh();
            }
            catch (Exception ex)
            {
                error = 1;
            }

            if (error.Equals(1))
            {
                MessageBox.Show("Wrong or insufficient input!");
                error = 0;
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int drink;
            double percent = 0;
            string fsk = "0";
            byte error = 1;

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
                try
                {
                    percent = Convert.ToDouble(txt_Percantage.Text);
                    fsk = txt_FSK.Text;
                }
                catch (Exception ex)
                {
                    error = 1;
                }
            }
            else
            {
                percent = 0;
                fsk = "0";
            }

            try
            {
                SqlCom.EditItem(drink, txt_Name.Text, Convert.ToInt32(txt_Quantaty.Text), Convert.ToDouble(txt_Price.Value), txt_Ingridiens.Text, percent, fsk, Convert.ToInt32(txt_ID.Text));
                dgv_Data.DataSource = SqlCom.DataGrid("TStock"); //Updates the Dataggridview
                dgv_Data.Update();
                dgv_Data.Refresh();
            }
            catch
            {
                error = 1;
            }

            if (error.Equals(1))
            {
                MessageBox.Show("Wrong or insufficient input!");
                error = 0;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCom.DelItem(Convert.ToInt32(txt_ID.Text));
                dgv_Data.DataSource = SqlCom.DataGrid("TStock");//Updates the Dataggridview
                dgv_Data.Update();
                dgv_Data.Refresh();
            }
            catch
            {
                MessageBox.Show("No ID was entered or the ID is invalid!");
            }

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            SqlCom.DataUpdate();
            dgv_Data.DataSource = SqlCom.DataGrid("TStock");
            dgv_Data.Update();
            dgv_Data.Refresh();
        }

        private void ckb_Alcoholic_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_Alcoholic.Checked)
            {
                txt_Percantage.Enabled = true;
                txt_FSK.Enabled = true;
            }
            else
            {
                txt_Percantage.Enabled = false;
                txt_FSK.Enabled = false;
            }
        }

        private void ckb_Drink_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_Drink.Checked)
            {
                ckb_Alcoholic.Enabled = true;
                if (ckb_Alcoholic.Checked)
                {
                    txt_Percantage.Enabled = true;
                    txt_FSK.Enabled = true;
                }
                else
                {
                    txt_Percantage.Enabled = false;
                    txt_FSK.Enabled = false;
                }
            }
            else
            {
                txt_Percantage.Enabled = false;
                txt_FSK.Enabled = false;
                ckb_Alcoholic.Enabled = false;
            }
        }
    }
}
