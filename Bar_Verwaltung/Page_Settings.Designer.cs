namespace Bar_Verwaltung
{
    partial class Page_Settings
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
            this.btn_Darkmode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Darkmode
            // 
            this.btn_Darkmode.Location = new System.Drawing.Point(63, 59);
            this.btn_Darkmode.Name = "btn_Darkmode";
            this.btn_Darkmode.Size = new System.Drawing.Size(75, 23);
            this.btn_Darkmode.TabIndex = 0;
            this.btn_Darkmode.Text = "Darkmode";
            this.btn_Darkmode.UseVisualStyleBackColor = true;
            // 
            // Page_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Darkmode);
            this.Name = "Page_Settings";
            this.Size = new System.Drawing.Size(800, 375);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Darkmode;
    }
}
