namespace Bar_Verwaltung
{
    partial class Page_Storage
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
            this.txt_Price = new System.Windows.Forms.NumericUpDown();
            this.txt_FSK = new System.Windows.Forms.ComboBox();
            this.ckb_Drink = new System.Windows.Forms.CheckBox();
            this.ckb_Alcoholic = new System.Windows.Forms.CheckBox();
            this.txt_Percantage = new System.Windows.Forms.TextBox();
            this.txt_Ingridiens = new System.Windows.Forms.TextBox();
            this.txt_Quantaty = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_Storage = new System.Windows.Forms.Label();
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.btn_Update = new System.Windows.Forms.Button();
            this.lbl_Price = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(212, 210);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(75, 23);
            this.txt_Price.TabIndex = 30;
            this.txt_Price.Tag = "Price";
            // 
            // txt_FSK
            // 
            this.txt_FSK.FormattingEnabled = true;
            this.txt_FSK.Location = new System.Drawing.Point(212, 273);
            this.txt_FSK.Name = "txt_FSK";
            this.txt_FSK.Size = new System.Drawing.Size(75, 23);
            this.txt_FSK.TabIndex = 29;
            this.txt_FSK.Text = "FSK";
            // 
            // ckb_Drink
            // 
            this.ckb_Drink.AutoSize = true;
            this.ckb_Drink.Location = new System.Drawing.Point(156, 172);
            this.ckb_Drink.Name = "ckb_Drink";
            this.ckb_Drink.Size = new System.Drawing.Size(108, 19);
            this.ckb_Drink.TabIndex = 28;
            this.ckb_Drink.Text = "Drink? (Yes/No)";
            this.ckb_Drink.UseVisualStyleBackColor = true;
            // 
            // ckb_Alcoholic
            // 
            this.ckb_Alcoholic.AutoSize = true;
            this.ckb_Alcoholic.Location = new System.Drawing.Point(50, 277);
            this.ckb_Alcoholic.Name = "ckb_Alcoholic";
            this.ckb_Alcoholic.Size = new System.Drawing.Size(81, 19);
            this.ckb_Alcoholic.TabIndex = 27;
            this.ckb_Alcoholic.Text = "Alcoholic?";
            this.ckb_Alcoholic.UseVisualStyleBackColor = true;
            this.ckb_Alcoholic.CheckedChanged += new System.EventHandler(this.ckb_Alcoholic_CheckedChanged);
            // 
            // txt_Percantage
            // 
            this.txt_Percantage.Location = new System.Drawing.Point(137, 273);
            this.txt_Percantage.Name = "txt_Percantage";
            this.txt_Percantage.PlaceholderText = "Percantage";
            this.txt_Percantage.Size = new System.Drawing.Size(69, 23);
            this.txt_Percantage.TabIndex = 26;
            // 
            // txt_Ingridiens
            // 
            this.txt_Ingridiens.Location = new System.Drawing.Point(50, 238);
            this.txt_Ingridiens.Name = "txt_Ingridiens";
            this.txt_Ingridiens.PlaceholderText = "Ingridiens";
            this.txt_Ingridiens.Size = new System.Drawing.Size(237, 23);
            this.txt_Ingridiens.TabIndex = 25;
            // 
            // txt_Quantaty
            // 
            this.txt_Quantaty.Location = new System.Drawing.Point(156, 209);
            this.txt_Quantaty.Name = "txt_Quantaty";
            this.txt_Quantaty.PlaceholderText = "Quantaty";
            this.txt_Quantaty.Size = new System.Drawing.Size(50, 23);
            this.txt_Quantaty.TabIndex = 24;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(50, 209);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PlaceholderText = "Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 23);
            this.txt_Name.TabIndex = 23;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(50, 170);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.PlaceholderText = "ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 23);
            this.txt_ID.TabIndex = 22;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(212, 92);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 21;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(131, 92);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 20;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(50, 92);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 19;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_Storage
            // 
            this.lbl_Storage.AutoSize = true;
            this.lbl_Storage.Location = new System.Drawing.Point(50, 43);
            this.lbl_Storage.Name = "lbl_Storage";
            this.lbl_Storage.Size = new System.Drawing.Size(47, 15);
            this.lbl_Storage.TabIndex = 18;
            this.lbl_Storage.Text = "Storage";
            // 
            // dgv_Data
            // 
            this.dgv_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Data.Location = new System.Drawing.Point(326, 18);
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.RowTemplate.Height = 25;
            this.dgv_Data.Size = new System.Drawing.Size(455, 308);
            this.dgv_Data.TabIndex = 31;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(326, 332);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(142, 23);
            this.btn_Update.TabIndex = 32;
            this.btn_Update.Text = " Update / Save changes";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(212, 194);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(36, 15);
            this.lbl_Price.TabIndex = 33;
            this.lbl_Price.Text = "Price:";
            // 
            // Page_Storage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.dgv_Data);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.txt_FSK);
            this.Controls.Add(this.ckb_Drink);
            this.Controls.Add(this.ckb_Alcoholic);
            this.Controls.Add(this.txt_Percantage);
            this.Controls.Add(this.txt_Ingridiens);
            this.Controls.Add(this.txt_Quantaty);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_Storage);
            this.Name = "Page_Storage";
            this.Size = new System.Drawing.Size(800, 375);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown txt_Price;
        private ComboBox txt_FSK;
        private CheckBox ckb_Drink;
        private CheckBox ckb_Alcoholic;
        private TextBox txt_Percantage;
        private TextBox txt_Ingridiens;
        private TextBox txt_Quantaty;
        private TextBox txt_Name;
        private TextBox txt_ID;
        private Button btn_Delete;
        private Button btn_Edit;
        private Button btn_Add;
        private Label lbl_Storage;
        private DataGridView dgv_Data;
        private Button btn_Update;
        private Label lbl_Price;
    }
}
