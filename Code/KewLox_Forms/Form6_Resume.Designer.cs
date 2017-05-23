namespace KewLox_Forms
{
    partial class Form6_Resume
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6_Resume));
            this.Title = new System.Windows.Forms.Label();
            this.Return_btn = new System.Windows.Forms.Button();
            this.Confirm_btn = new System.Windows.Forms.Button();
            this.MissingParts = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Title.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(10, 16);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(199, 59);
            this.Title.TabIndex = 52;
            this.Title.Text = "KewLox";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // Return_btn
            // 
            this.Return_btn.Location = new System.Drawing.Point(785, 504);
            this.Return_btn.Name = "Return_btn";
            this.Return_btn.Size = new System.Drawing.Size(100, 30);
            this.Return_btn.TabIndex = 54;
            this.Return_btn.Text = "Return";
            this.Return_btn.UseVisualStyleBackColor = true;
            this.Return_btn.Click += new System.EventHandler(this.Return_btn_Click);
            // 
            // Confirm_btn
            // 
            this.Confirm_btn.Location = new System.Drawing.Point(891, 504);
            this.Confirm_btn.Name = "Confirm_btn";
            this.Confirm_btn.Size = new System.Drawing.Size(100, 30);
            this.Confirm_btn.TabIndex = 53;
            this.Confirm_btn.Text = "Confirm";
            this.Confirm_btn.UseVisualStyleBackColor = true;
            this.Confirm_btn.Click += new System.EventHandler(this.Confirm_btn_Click);
            // 
            // MissingParts
            // 
            this.MissingParts.FormattingEnabled = true;
            this.MissingParts.Location = new System.Drawing.Point(379, 147);
            this.MissingParts.Name = "MissingParts";
            this.MissingParts.Size = new System.Drawing.Size(170, 225);
            this.MissingParts.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Missing parts";
            // 
            // Form6_Resume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MissingParts);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Return_btn);
            this.Controls.Add(this.Confirm_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6_Resume";
            this.Text = "Form6_Resume";
            this.Load += new System.EventHandler(this.Form6_Resume_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button Return_btn;
        private System.Windows.Forms.Button Confirm_btn;
        private System.Windows.Forms.ListBox MissingParts;
        private System.Windows.Forms.Label label1;
    }
}