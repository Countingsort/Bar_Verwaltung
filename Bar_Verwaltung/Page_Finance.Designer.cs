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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TabLayPan = new System.Windows.Forms.TableLayoutPanel();
            this.btn_main = new System.Windows.Forms.Button();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 340);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(635, 23);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(655, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(113, 23);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(655, 226);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(113, 23);
            this.textBox3.TabIndex = 5;
            // 
            // TabLayPan
            // 
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
            // 
            // Page_Finance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_main);
            this.Controls.Add(this.TabLayPan);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TableLayoutPanel TabLayPan;
        private Button btn_main;
    }
}
