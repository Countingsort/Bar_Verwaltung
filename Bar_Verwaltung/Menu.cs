namespace Bar_Verwaltung
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            SqlCom.CheckDatabaseExists("Bar3IT22");
        }

        private void btn_Storage_Click(object sender, EventArgs e)
        {
            page_Storage2.BringToFront();
        }

        private void btn_Finance_Click(object sender, EventArgs e)
        {
            page_Finance1.BringToFront();
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            page_Settings1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            page_Storage2.BringToFront();
        }
    }
}