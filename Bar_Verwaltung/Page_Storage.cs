﻿using System;
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
        }
    }
}
