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
    public partial class Page_Settings : UserControl
    {
        public Page_Settings()
        {
            InitializeComponent();
            dgv_Data.DataSource = SqlCom.DataGrid("TFinance");
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            SqlCom.DataUpdate();
            dgv_Data.DataSource = SqlCom.DataGrid("TFinance");
            dgv_Data.Update();
            dgv_Data.Refresh();
        }
    }
}
