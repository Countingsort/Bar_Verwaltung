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
        }
        public void AddButtons()
        {
            int counter = 0;
            DataTable dt = new DataTable();
            dt = SqlCom.DataGrid("TStock");
            foreach ()
            {
                Button b = new Button();
                b.Name = "btn_" + counter;
                b.Size = new Size(50, 50);
                b.Text = "";
                counter++;
            }
        }
    }
}
