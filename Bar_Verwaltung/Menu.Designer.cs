namespace Bar_Verwaltung
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Storage = new System.Windows.Forms.Button();
            this.btn_Finance = new System.Windows.Forms.Button();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.page_Storage2 = new Bar_Verwaltung.Page_Storage();
            this.page_Settings1 = new Bar_Verwaltung.Page_Settings();
            this.page_Finance1 = new Bar_Verwaltung.Page_Finance();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Storage
            // 
            this.btn_Storage.Location = new System.Drawing.Point(12, 2);
            this.btn_Storage.Name = "btn_Storage";
            this.btn_Storage.Size = new System.Drawing.Size(75, 60);
            this.btn_Storage.TabIndex = 0;
            this.btn_Storage.Text = "Storage";
            this.btn_Storage.UseVisualStyleBackColor = true;
            this.btn_Storage.Click += new System.EventHandler(this.btn_Storage_Click);
            // 
            // btn_Finance
            // 
            this.btn_Finance.Location = new System.Drawing.Point(93, 2);
            this.btn_Finance.Name = "btn_Finance";
            this.btn_Finance.Size = new System.Drawing.Size(75, 60);
            this.btn_Finance.TabIndex = 1;
            this.btn_Finance.Text = "Finance";
            this.btn_Finance.UseVisualStyleBackColor = true;
            this.btn_Finance.Click += new System.EventHandler(this.btn_Finance_Click);
            // 
            // btn_Settings
            // 
            this.btn_Settings.Location = new System.Drawing.Point(174, 2);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(80, 60);
            this.btn_Settings.TabIndex = 2;
            this.btn_Settings.Text = "Accounting documents";
            this.btn_Settings.UseVisualStyleBackColor = true;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.page_Storage2);
            this.panel1.Controls.Add(this.page_Settings1);
            this.panel1.Controls.Add(this.page_Finance1);
            this.panel1.Location = new System.Drawing.Point(1, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 375);
            this.panel1.TabIndex = 3;
            // 
            // page_Storage2
            // 
            this.page_Storage2.Location = new System.Drawing.Point(0, 0);
            this.page_Storage2.Name = "page_Storage2";
            this.page_Storage2.Size = new System.Drawing.Size(800, 375);
            this.page_Storage2.TabIndex = 2;
            // 
            // page_Settings1
            // 
            this.page_Settings1.Location = new System.Drawing.Point(0, -3);
            this.page_Settings1.Name = "page_Settings1";
            this.page_Settings1.Size = new System.Drawing.Size(800, 375);
            this.page_Settings1.TabIndex = 1;
            // 
            // page_Finance1
            // 
            this.page_Finance1.Location = new System.Drawing.Point(0, 0);
            this.page_Finance1.Name = "page_Finance1";
            this.page_Finance1.Size = new System.Drawing.Size(800, 375);
            this.page_Finance1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Settings);
            this.Controls.Add(this.btn_Finance);
            this.Controls.Add(this.btn_Storage);
            this.Name = "Menu";
            this.Text = "Bar Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Storage;
        private Button btn_Finance;
        private Button btn_Settings;
        private Panel panel1;
        private Page_Storage page_Storage1;
        private Page_Settings page_Settings1;
        private Page_Finance page_Finance1;
        private Page_Storage page_Storage2;
    }
}