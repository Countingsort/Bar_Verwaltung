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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_date = new System.Windows.Forms.Label();
            this.lb_titel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(14, 17);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(635, 317);
            this.flowLayoutPanel1.TabIndex = 0;
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
            this.lb_titel.Location = new System.Drawing.Point(666, 79);
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
            // Page_Finance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_titel);
            this.Controls.Add(this.lb_date);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Page_Finance";
            this.Size = new System.Drawing.Size(800, 375);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label lb_date;
        private Label lb_titel;
        private TextBox textBox1;
    }
}
