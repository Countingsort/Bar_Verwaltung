namespace Bar_Verwaltung
{
    partial class Page_Finance
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_date = new System.Windows.Forms.Label();
            this.lb_titel = new System.Windows.Forms.Label();
            this.txtB1 = new System.Windows.Forms.TextBox();
            this.txtBPrice = new System.Windows.Forms.TextBox();
            this.TabLayPan = new System.Windows.Forms.TableLayoutPanel();
            this.btn_main = new System.Windows.Forms.Button();
            this.lb_Price = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Location = new System.Drawing.Point(666, 33);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(38, 15);
            this.lb_date.TabIndex = 1;
            this.lb_date.Text = "label1";
            // 
            // lb_titel
            // 
            this.lb_titel.AutoSize = true;
            this.lb_titel.Location = new System.Drawing.Point(666, 73);
            this.lb_titel.Name = "lb_titel";
            this.lb_titel.Size = new System.Drawing.Size(72, 15);
            this.lb_titel.TabIndex = 2;
            this.lb_titel.Text = "Tageslösung";
            // 
            // txtB1
            // 
            this.txtB1.Location = new System.Drawing.Point(14, 340);
            this.txtB1.Name = "txtB1";
            this.txtB1.Size = new System.Drawing.Size(635, 23);
            this.txtB1.TabIndex = 3;
            // 
            // txtBPrice
            // 
            this.txtBPrice.Location = new System.Drawing.Point(666, 149);
            this.txtBPrice.Name = "txtBPrice";
            this.txtBPrice.Size = new System.Drawing.Size(113, 23);
            this.txtBPrice.TabIndex = 4;
            // 
            // TabLayPan
            // 
            this.TabLayPan.AutoScroll = true;
            this.TabLayPan.ColumnCount = 4;
            this.TabLayPan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TabLayPan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TabLayPan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TabLayPan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TabLayPan.Location = new System.Drawing.Point(14, 23);
            this.TabLayPan.Name = "TabLayPan";
            this.TabLayPan.RowCount = 3;
            this.TabLayPan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TabLayPan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TabLayPan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TabLayPan.Size = new System.Drawing.Size(635, 311);
            this.TabLayPan.TabIndex = 6;
            // 
            // btn_main
            // 
            this.btn_main.Location = new System.Drawing.Point(675, 264);
            this.btn_main.Name = "btn_main";
            this.btn_main.Size = new System.Drawing.Size(75, 70);
            this.btn_main.TabIndex = 7;
            this.btn_main.Text = "Fertig";
            this.btn_main.UseVisualStyleBackColor = true;
            this.btn_main.Click += new System.EventHandler(this.btn_main_Click);
            // 
            // lb_Price
            // 
            this.lb_Price.AutoSize = true;
            this.lb_Price.Location = new System.Drawing.Point(669, 121);
            this.lb_Price.Name = "lb_Price";
            this.lb_Price.Size = new System.Drawing.Size(35, 15);
            this.lb_Price.TabIndex = 8;
            this.lb_Price.Text = "Preis:";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(666, 202);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(102, 41);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "Zurück";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Page_Finance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lb_Price);
            this.Controls.Add(this.btn_main);
            this.Controls.Add(this.TabLayPan);
            this.Controls.Add(this.txtBPrice);
            this.Controls.Add(this.txtB1);
            this.Controls.Add(this.lb_titel);
            this.Controls.Add(this.lb_date);
            this.Name = "Page_Finance";
            this.Size = new System.Drawing.Size(800, 375);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lb_date;
        private Label lb_titel;
        private TextBox txtB1;
        private TextBox txtBPrice;
        private TableLayoutPanel TabLayPan;
        private Button btn_main;
        private Label lb_Price;
        private Button btn_back;
    }
}
