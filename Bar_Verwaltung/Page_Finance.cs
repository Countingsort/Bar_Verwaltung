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
    }
}
