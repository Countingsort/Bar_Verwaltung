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
            double itemprice = list[ID].price;

            if(txtBPrice.Text != "")
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            String[] IDs = txtB1.Text.Split(";");
            txtB1.Text = "";
            for(int i = 0; i < IDs.Length-2; i++)
            {
                txtB1.Text += IDs[i];
                txtB1.Text += ";";
            }
        }
    }
}
