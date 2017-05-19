namespace KewLox_Forms
{
    partial class Form7_Final_bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7_Final_bill));
            this.Logo = new System.Windows.Forms.Label();
            this.Return_btn = new System.Windows.Forms.Button();
            this.Confirm_btn = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.AutoSize = true;
            this.Logo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Logo.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo.Location = new System.Drawing.Point(16, 11);
            this.Logo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(249, 72);
            this.Logo.TabIndex = 53;
            this.Logo.Text = "KewLox";
            this.Logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Return_btn
            // 
            this.Return_btn.Location = new System.Drawing.Point(1043, 625);
            this.Return_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Return_btn.Name = "Return_btn";
            this.Return_btn.Size = new System.Drawing.Size(133, 37);
            this.Return_btn.TabIndex = 56;
            this.Return_btn.Text = "Return";
            this.Return_btn.UseVisualStyleBackColor = true;
            // 
            // Confirm_btn
            // 
            this.Confirm_btn.Location = new System.Drawing.Point(1184, 625);
            this.Confirm_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Confirm_btn.Name = "Confirm_btn";
            this.Confirm_btn.Size = new System.Drawing.Size(133, 37);
            this.Confirm_btn.TabIndex = 55;
            this.Confirm_btn.Text = "Pay";
            this.Confirm_btn.UseVisualStyleBackColor = true;
            this.Confirm_btn.Click += new System.EventHandler(this.Pay_btn_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(164, 190);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(274, 17);
            this.label25.TabIndex = 57;
            this.label25.Text = "Here is the amount that you\'ll have to pay:";
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(445, 190);
            this.Price.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(132, 22);
            this.Price.TabIndex = 58;
            this.Price.TextChanged += new System.EventHandler(this.Price_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 17);
            this.label2.TabIndex = 59;
            this.label2.Text = "Thank you for your choice, Mister :";
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(400, 135);
            this.lastname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(132, 22);
            this.lastname.TabIndex = 60;
            this.lastname.TextChanged += new System.EventHandler(this.LastName_TextChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(587, 193);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(366, 17);
            this.label32.TabIndex = 61;
            this.label32.Text = "on the following account number : BE25 1234 5678 9012";
            // 
            // Form7_Final_bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1333, 677);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.Return_btn);
            this.Controls.Add(this.Confirm_btn);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form7_Final_bill";
            this.Text = "Form7_Final_bill";
            this.Load += new System.EventHandler(this.Form7_Final_bill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Logo;
        private System.Windows.Forms.Button Return_btn;
        private System.Windows.Forms.Button Confirm_btn;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.Label label32;
    }
}