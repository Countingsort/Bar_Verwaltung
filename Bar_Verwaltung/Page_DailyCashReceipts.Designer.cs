namespace Bar_Verwaltung
{
    partial class Page_DailyCashReceipts
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
            this.cB_Date = new System.Windows.Forms.ComboBox();
            this.lab_Date = new System.Windows.Forms.Label();
            this.cB_Product = new System.Windows.Forms.ComboBox();
            this.lab_Product = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cB_Date
            // 
            this.cB_Date.FormattingEnabled = true;
            this.cB_Date.Location = new System.Drawing.Point(35, 42);
            this.cB_Date.Name = "cB_Date";
            this.cB_Date.Size = new System.Drawing.Size(121, 23);
            this.cB_Date.TabIndex = 0;
            // 
            // lab_Date
            // 
            this.lab_Date.AutoSize = true;
            this.lab_Date.Location = new System.Drawing.Point(35, 18);
            this.lab_Date.Name = "lab_Date";
            this.lab_Date.Size = new System.Drawing.Size(34, 15);
            this.lab_Date.TabIndex = 1;
            this.lab_Date.Text = "Date ";
            // 
            // cB_Product
            // 
            this.cB_Product.FormattingEnabled = true;
            this.cB_Product.Location = new System.Drawing.Point(185, 42);
            this.cB_Product.Name = "cB_Product";
            this.cB_Product.Size = new System.Drawing.Size(121, 23);
            this.cB_Product.TabIndex = 2;
            // 
            // lab_Product
            // 
            this.lab_Product.AutoSize = true;
            this.lab_Product.Location = new System.Drawing.Point(197, 18);
            this.lab_Product.Name = "lab_Product";
            this.lab_Product.Size = new System.Drawing.Size(49, 15);
            this.lab_Product.TabIndex = 3;
            this.lab_Product.Text = "Product";
            // 
            // Page_DailyCashReceipts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lab_Product);
            this.Controls.Add(this.cB_Product);
            this.Controls.Add(this.lab_Date);
            this.Controls.Add(this.cB_Date);
            this.Name = "Page_DailyCashReceipts";
            this.Size = new System.Drawing.Size(800, 375);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cB_Date;
        private Label lab_Date;
        private ComboBox cB_Product;
        private Label lab_Product;
    }
}
