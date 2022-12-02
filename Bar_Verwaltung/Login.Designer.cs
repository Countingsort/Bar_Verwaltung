namespace Bar_Verwaltung
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtB_1 = new System.Windows.Forms.TextBox();
            this.txtB_2 = new System.Windows.Forms.TextBox();
            this.lb_3 = new System.Windows.Forms.Label();
            this.lb_2 = new System.Windows.Forms.Label();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.lb_1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtB_1
            // 
            this.txtB_1.Location = new System.Drawing.Point(12, 83);
            this.txtB_1.Name = "txtB_1";
            this.txtB_1.Size = new System.Drawing.Size(238, 23);
            this.txtB_1.TabIndex = 0;
            // 
            // txtB_2
            // 
            this.txtB_2.Location = new System.Drawing.Point(12, 151);
            this.txtB_2.Name = "txtB_2";
            this.txtB_2.Size = new System.Drawing.Size(238, 23);
            this.txtB_2.TabIndex = 1;
            // 
            // lb_3
            // 
            this.lb_3.AutoSize = true;
            this.lb_3.Location = new System.Drawing.Point(12, 121);
            this.lb_3.Name = "lb_3";
            this.lb_3.Size = new System.Drawing.Size(54, 15);
            this.lb_3.TabIndex = 2;
            this.lb_3.Text = "Passwort";
            // 
            // lb_2
            // 
            this.lb_2.AutoSize = true;
            this.lb_2.Location = new System.Drawing.Point(12, 56);
            this.lb_2.Name = "lb_2";
            this.lb_2.Size = new System.Drawing.Size(83, 15);
            this.lb_2.TabIndex = 3;
            this.lb_2.Text = "Benutzername";
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(20, 201);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(75, 23);
            this.btn_1.TabIndex = 4;
            this.btn_1.Text = "Login";
            this.btn_1.UseVisualStyleBackColor = true;
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(141, 201);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(75, 23);
            this.btn_2.TabIndex = 5;
            this.btn_2.Text = "New User";
            this.btn_2.UseVisualStyleBackColor = true;
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_1.Location = new System.Drawing.Point(101, 9);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(69, 30);
            this.lb_1.TabIndex = 6;
            this.lb_1.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 251);
            this.Controls.Add(this.lb_1);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.lb_2);
            this.Controls.Add(this.lb_3);
            this.Controls.Add(this.txtB_2);
            this.Controls.Add(this.txtB_1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtB_1;
        private TextBox txtB_2;
        private Label lb_3;
        private Label lb_2;
        private Button btn_1;
        private Button btn_2;
        private Label lb_1;
    }
}