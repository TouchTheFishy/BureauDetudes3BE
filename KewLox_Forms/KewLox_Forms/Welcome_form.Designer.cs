namespace KewLox_Forms
{
    partial class Welcome_form
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
            this.Customuer = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.Label();
            this.Admin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Customuer
            // 
            this.Customuer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Customuer.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customuer.Location = new System.Drawing.Point(255, 247);
            this.Customuer.Name = "Customuer";
            this.Customuer.Size = new System.Drawing.Size(118, 68);
            this.Customuer.TabIndex = 3;
            this.Customuer.Text = "Customer";
            this.Customuer.UseVisualStyleBackColor = true;
            this.Customuer.Click += new System.EventHandler(this.button_Customer_Click);
            // 
            // Logo
            // 
            this.Logo.AutoSize = true;
            this.Logo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Logo.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo.Location = new System.Drawing.Point(12, 9);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(199, 59);
            this.Logo.TabIndex = 4;
            this.Logo.Text = "KewLox";
            this.Logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Logo.Click += new System.EventHandler(this.label1_Click);
            // 
            // Admin
            // 
            this.Admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Admin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.Location = new System.Drawing.Point(508, 247);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(118, 68);
            this.Admin.TabIndex = 5;
            this.Admin.Text = "Admin";
            this.Admin.UseVisualStyleBackColor = true;
            this.Admin.Click += new System.EventHandler(this.button_Admin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Customuer);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Customuer;
        private System.Windows.Forms.Label Logo;
        private System.Windows.Forms.Button Admin;
    }
}

