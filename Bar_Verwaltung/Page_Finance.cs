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
    public partial class Page_Finance : UserControl
    {
        public Page_Finance()
        {
            InitializeComponent();
            lb_date.Text = DateTime.Now.ToString("dd-MM-yyyy");
            AddButtons();
        }
        public void AddButtons()
        {
            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;
            List<Stock> list = Stock.getItems();

            foreach (Stock i in list)
            {
                Button b = new Button();
                b.Name = "btn_" + i.ID;
                b.Size = new Size(90, 90);
                b.Text = list[counter1].Item;
                b.Click += new EventHandler(this.button_click);
                if (counter2 <= 3)
                {
                    TabLayPan.Controls.Add(b, counter2, counter3);
                    counter2++;
                }
                else
                {
                    TabLayPan.Controls.Add(b, counter2, counter3);
                    counter2 = 0;
                    counter3++;
                }
                counter1++;
            }
        }
        void button_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string BtnName = btn.Name;
            string[] IDs = BtnName.Split("_");
            int ID = Convert.ToInt32(IDs[1]);
            txtB1.Text += ID;
            txtB1.Text += ";";

            List<Stock> list = Stock.getItems();
            try
            {
                double itemprice = list[ID - 1].price;
                if (txtBPrice.Text != "")
                {
                    double currentPrice = Convert.ToDouble(txtBPrice.Text);
                    double nextprice = currentPrice + itemprice;
                    txtBPrice.Text = nextprice.ToString();
                }
                else
                {
                    txtBPrice.Text = itemprice.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Fehler");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            List<Stock> list = Stock.getItems();
            String[] IDs = txtB1.Text.Split(";");
            txtB1.Text = "";
            double nextprice = 0.0;
            for (int i = 0; i < IDs.Length - 2; i++)
            {
                txtB1.Text += IDs[i];
                txtB1.Text += ";";
                nextprice += list[Convert.ToInt32(IDs[i]) - 1].price;
            }
            txtBPrice.Text = nextprice.ToString();
        }

        private void btn_main_Click(object sender, EventArgs e)
        {
            String[] IDs = txtB1.Text.Split(";");

            List<int> ID = new List<int> { };
            foreach (String i in IDs)
            {
                if (i != "")
                {
                    ID.Add(Convert.ToInt32(i));
                }
            }

            int[] sortedID = Finance.getSortedArray(ID);

            for (int i = 0; i < sortedID.Length; i++)
            {
                if (sortedID[i] != 0)
                {
                    try 
                    { 
                        SqlCom.newFinance(sortedID[i], i, lb_date.Text);
                        MessageBox.Show("Erfolgreich");
                        txtB1.Text = "";
                        txtBPrice.Text = "";
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.ToString());
                    }
                }
            }
        }

        private void lb_titel_Click(object sender, EventArgs e)
        {

        }
    }
}
