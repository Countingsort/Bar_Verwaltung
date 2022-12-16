namespace Bar_Verwaltung
{
    partial class Register
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtB_1 = new System.Windows.Forms.TextBox();
            this.txtB_2 = new System.Windows.Forms.TextBox();
            this.txtB_3 = new System.Windows.Forms.TextBox();
            this.lb_1 = new System.Windows.Forms.Label();
            this.lb_2 = new System.Windows.Forms.Label();
            this.lb_3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtB_1
            // 
            this.txtB_1.Location = new System.Drawing.Point(32, 80);
            this.txtB_1.Name = "txtB_1";
            this.txtB_1.Size = new System.Drawing.Size(248, 23);
            this.txtB_1.TabIndex = 1;
            // 
            // txtB_2
            // 
            this.txtB_2.Location = new System.Drawing.Point(32, 138);
            this.txtB_2.Name = "txtB_2";
            this.txtB_2.Size = new System.Drawing.Size(248, 23);
            this.txtB_2.TabIndex = 2;
            // 
            // txtB_3
            // 
            this.txtB_3.Location = new System.Drawing.Point(32, 197);
            this.txtB_3.Name = "txtB_3";
            this.txtB_3.Size = new System.Drawing.Size(248, 23);
            this.txtB_3.TabIndex = 3;
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_1.Location = new System.Drawing.Point(85, 9);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(175, 32);
            this.lb_1.TabIndex = 4;
            this.lb_1.Text = "Regrestrieren ";
            // 
            // lb_2
            // 
            this.lb_2.AutoSize = true;
            this.lb_2.Location = new System.Drawing.Point(32, 62);
            this.lb_2.Name = "lb_2";
            this.lb_2.Size = new System.Drawing.Size(86, 15);
            this.lb_2.TabIndex = 5;
            this.lb_2.Text = "Benutzername:";
            // 
            // lb_3
            // 
            this.lb_3.AutoSize = true;
            this.lb_3.Location = new System.Drawing.Point(32, 120);
            this.lb_3.Name = "lb_3";
            this.lb_3.Size = new System.Drawing.Size(57, 15);
            this.lb_3.TabIndex = 6;
            this.lb_3.Text = "Passwort:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Passwort:";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 283);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_3);
            this.Controls.Add(this.lb_2);
            this.Controls.Add(this.lb_1);
            this.Controls.Add(this.txtB_3);
            this.Controls.Add(this.txtB_2);
            this.Controls.Add(this.txtB_1);
            this.Controls.Add(this.button1);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox txtB_1;
        private TextBox txtB_2;
        private TextBox txtB_3;
        private Label lb_1;
        private Label lb_2;
        private Label lb_3;
        private Label label4;
    }
}