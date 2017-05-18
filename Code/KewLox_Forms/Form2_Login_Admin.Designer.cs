namespace KewLox_Forms
{
    partial class Form2_Login_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2_Login_Admin));
            this.Logo = new System.Windows.Forms.Label();
            this.Retrieve_btn = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.TextBox();
            this.Login_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Return_btn = new System.Windows.Forms.Button();
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
            this.Logo.TabIndex = 5;
            this.Logo.Text = "KewLox";
            this.Logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Logo.Click += new System.EventHandler(this.Title_Click);
            // 
            // Retrieve_btn
            // 
            this.Retrieve_btn.Location = new System.Drawing.Point(889, 510);
            this.Retrieve_btn.Name = "Retrieve_btn";
            this.Retrieve_btn.Size = new System.Drawing.Size(100, 30);
            this.Retrieve_btn.TabIndex = 8;
            this.Retrieve_btn.Text = "Confirm";
            this.Retrieve_btn.UseVisualStyleBackColor = true;
            this.Retrieve_btn.Click += new System.EventHandler(this.Retrieve_btn_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(426, 246);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(100, 20);
            this.Login.TabIndex = 9;
            // 
            // Login_label
            // 
            this.Login_label.AutoSize = true;
            this.Login_label.Location = new System.Drawing.Point(355, 246);
            this.Login_label.Name = "Login_label";
            this.Login_label.Size = new System.Drawing.Size(33, 13);
            this.Login_label.TabIndex = 10;
            this.Login_label.Text = "Login";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Location = new System.Drawing.Point(355, 287);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(53, 13);
            this.Password_label.TabIndex = 11;
            this.Password_label.Text = "Password";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(427, 287);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(100, 20);
            this.Password.TabIndex = 12;
            // 
            // Return_btn
            // 
            this.Return_btn.Location = new System.Drawing.Point(783, 510);
            this.Return_btn.Name = "Return_btn";
            this.Return_btn.Size = new System.Drawing.Size(100, 30);
            this.Return_btn.TabIndex = 13;
            this.Return_btn.Text = "Return";
            this.Return_btn.UseVisualStyleBackColor = true;
            this.Return_btn.Click += new System.EventHandler(this.Return_btn_Click);
            // 
            // Form2_Login_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.Return_btn);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Login_label);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Retrieve_btn);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2_Login_Admin";
            this.Text = "Form2_Login_Admin";
            this.Load += new System.EventHandler(this.Form2_Login_Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Logo;
        private System.Windows.Forms.Button Retrieve_btn;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Label Login_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button Return_btn;
    }
}