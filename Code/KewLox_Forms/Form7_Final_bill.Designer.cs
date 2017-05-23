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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.AutoSize = true;
            this.Logo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Logo.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo.Location = new System.Drawing.Point(12, 9);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(199, 59);
            this.Logo.TabIndex = 53;
            this.Logo.Text = "KewLox";
            this.Logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // Return_btn
            // 
            this.Return_btn.Location = new System.Drawing.Point(782, 508);
            this.Return_btn.Name = "Return_btn";
            this.Return_btn.Size = new System.Drawing.Size(100, 30);
            this.Return_btn.TabIndex = 56;
            this.Return_btn.Text = "Return";
            this.Return_btn.UseVisualStyleBackColor = true;
            // 
            // Confirm_btn
            // 
            this.Confirm_btn.Location = new System.Drawing.Point(888, 508);
            this.Confirm_btn.Name = "Confirm_btn";
            this.Confirm_btn.Size = new System.Drawing.Size(100, 30);
            this.Confirm_btn.TabIndex = 55;
            this.Confirm_btn.Text = "Pay";
            this.Confirm_btn.UseVisualStyleBackColor = true;
            this.Confirm_btn.Click += new System.EventHandler(this.Pay_btn_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(267, 186);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(205, 13);
            this.label25.TabIndex = 57;
            this.label25.Text = "Here is the amount that you\'ll have to pay:";
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(478, 183);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(64, 20);
            this.Price.TabIndex = 58;
            this.Price.TextChanged += new System.EventHandler(this.Price_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Thank you for your choice, Mister :";
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(444, 142);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(156, 20);
            this.lastname.TabIndex = 60;
            this.lastname.TextChanged += new System.EventHandler(this.LastName_TextChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(548, 186);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(289, 13);
            this.label32.TabIndex = 61;
            this.label32.Text = "€  on the following account number : BE25 1234 5678 9012";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // Form7_Final_bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.pictureBox1);
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
            this.Name = "Form7_Final_bill";
            this.Text = "Form7_Final_bill";
            this.Load += new System.EventHandler(this.Form7_Final_bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}