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
            DataTable dt = new DataTable();
            dt = SqlCom.DataGrid("TStock");

            List<Stock> list = new List<Stock>{};
            foreach (DataRow row in dt.Rows)
            {
                int Id = Convert.ToInt32(row["ID"]);
                string name = row["Item"].ToString();
                double price = Convert.ToDouble(row["Price"]);

                Stock s = new Stock(Id, name, price);
                list.Add(s);
            }

            foreach(Stock i in list)
            {
                Button b = new Button();
                b.Name = "btn_" + counter1;
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

        }
    }
}
