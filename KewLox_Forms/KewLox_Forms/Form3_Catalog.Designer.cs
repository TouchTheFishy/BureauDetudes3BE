namespace KewLox_Forms
{
    partial class Form3_Catalog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3_Catalog));
            this.Basket = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.Label();
            this.Recommand = new System.Windows.Forms.ListBox();
            this.Personnalise = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Filter1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.Return_btn = new System.Windows.Forms.Button();
            this.Confirm_btn = new System.Windows.Forms.Button();
            this.tiny_closet = new System.Windows.Forms.PictureBox();
            this.closet_wood = new System.Windows.Forms.PictureBox();
            this.closet_white = new System.Windows.Forms.PictureBox();
            this.closet_orange_blue = new System.Windows.Forms.PictureBox();
            this.closet_glass = new System.Windows.Forms.PictureBox();
            this.closet_multicolor = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tiny_closet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closet_wood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closet_white)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closet_orange_blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closet_glass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closet_multicolor)).BeginInit();
            this.SuspendLayout();
            // 
            // Basket
            // 
            this.Basket.Location = new System.Drawing.Point(849, 14);
            this.Basket.Name = "Basket";
            this.Basket.Size = new System.Drawing.Size(137, 51);
            this.Basket.TabIndex = 0;
            this.Basket.Text = "Basket";
            this.Basket.UseVisualStyleBackColor = true;
            this.Basket.Click += new System.EventHandler(this.Basket_Click);
            // 
            // Logo
            // 
            this.Logo.AutoSize = true;
            this.Logo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Logo.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo.Location = new System.Drawing.Point(245, 9);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(199, 59);
            this.Logo.TabIndex = 5;
            this.Logo.Text = "KewLox";
            this.Logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Logo.Click += new System.EventHandler(this.Title_Click);
            // 
            // Recommand
            // 
            this.Recommand.FormattingEnabled = true;
            this.Recommand.Location = new System.Drawing.Point(245, 120);
            this.Recommand.MultiColumn = true;
            this.Recommand.Name = "Recommand";
            this.Recommand.ScrollAlwaysVisible = true;
            this.Recommand.Size = new System.Drawing.Size(681, 134);
            this.Recommand.TabIndex = 6;
            this.Recommand.Click += new System.EventHandler(this.list);
            // 
            // Personnalise
            // 
            this.Personnalise.FormattingEnabled = true;
            this.Personnalise.Location = new System.Drawing.Point(245, 307);
            this.Personnalise.MultiColumn = true;
            this.Personnalise.Name = "Personnalise";
            this.Personnalise.ScrollAlwaysVisible = true;
            this.Personnalise.Size = new System.Drawing.Size(681, 134);
            this.Personnalise.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Recommand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Personnalise";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Filter1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(108, 550);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // Filter1
            // 
            this.Filter1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.toolStripTextBox1,
            this.toolStripSeparator3,
            this.toolStripTextBox2});
            this.Filter1.Name = "Filter1";
            this.Filter1.Size = new System.Drawing.Size(101, 19);
            this.Filter1.Text = "Dimension Filter";
            this.Filter1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 23);
            this.toolStripSeparator1.Text = "Length";
            this.toolStripSeparator1.Click += new System.EventHandler(this.toolStripSeparator1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(206, 6);
            this.toolStripSeparator2.Click += new System.EventHandler(this.toolStripSeparator2_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "Width";
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(206, 6);
            this.toolStripSeparator3.Click += new System.EventHandler(this.toolStripSeparator3_Click);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox2.Text = "Number of Case required";
            this.toolStripTextBox2.Click += new System.EventHandler(this.toolStripTextBox2_Click);
            // 
            // Return_btn
            // 
            this.Return_btn.Location = new System.Drawing.Point(782, 508);
            this.Return_btn.Name = "Return_btn";
            this.Return_btn.Size = new System.Drawing.Size(100, 30);
            this.Return_btn.TabIndex = 15;
            this.Return_btn.Text = "Return";
            this.Return_btn.UseVisualStyleBackColor = true;
            this.Return_btn.Click += new System.EventHandler(this.Return_btn_Click);
            // 
            // Confirm_btn
            // 
            this.Confirm_btn.Location = new System.Drawing.Point(888, 508);
            this.Confirm_btn.Name = "Confirm_btn";
            this.Confirm_btn.Size = new System.Drawing.Size(100, 30);
            this.Confirm_btn.TabIndex = 14;
            this.Confirm_btn.Text = "Confirm";
            this.Confirm_btn.UseVisualStyleBackColor = true;
            this.Confirm_btn.Click += new System.EventHandler(this.Confirm_btn_Click);
            // 
            // tiny_closet
            // 
            this.tiny_closet.Image = ((System.Drawing.Image)(resources.GetObject("tiny_closet.Image")));
            this.tiny_closet.Location = new System.Drawing.Point(827, 138);
            this.tiny_closet.Name = "tiny_closet";
            this.tiny_closet.Size = new System.Drawing.Size(85, 92);
            this.tiny_closet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tiny_closet.TabIndex = 21;
            this.tiny_closet.TabStop = false;
            this.tiny_closet.Click += new System.EventHandler(this.tiny_closet_Click);
            // 
            // closet_wood
            // 
            this.closet_wood.Image = ((System.Drawing.Image)(resources.GetObject("closet_wood.Image")));
            this.closet_wood.Location = new System.Drawing.Point(718, 138);
            this.closet_wood.Name = "closet_wood";
            this.closet_wood.Size = new System.Drawing.Size(85, 92);
            this.closet_wood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closet_wood.TabIndex = 20;
            this.closet_wood.TabStop = false;
            this.closet_wood.Click += new System.EventHandler(this.closet_wood_Click);
            // 
            // closet_white
            // 
            this.closet_white.Image = ((System.Drawing.Image)(resources.GetObject("closet_white.Image")));
            this.closet_white.Location = new System.Drawing.Point(603, 138);
            this.closet_white.Name = "closet_white";
            this.closet_white.Size = new System.Drawing.Size(85, 92);
            this.closet_white.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closet_white.TabIndex = 19;
            this.closet_white.TabStop = false;
            this.closet_white.Click += new System.EventHandler(this.closet_white_Click);
            // 
            // closet_orange_blue
            // 
            this.closet_orange_blue.Image = ((System.Drawing.Image)(resources.GetObject("closet_orange_blue.Image")));
            this.closet_orange_blue.Location = new System.Drawing.Point(492, 138);
            this.closet_orange_blue.Name = "closet_orange_blue";
            this.closet_orange_blue.Size = new System.Drawing.Size(85, 92);
            this.closet_orange_blue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closet_orange_blue.TabIndex = 18;
            this.closet_orange_blue.TabStop = false;
            this.closet_orange_blue.Click += new System.EventHandler(this.closet_orange_blue_Click);
            // 
            // closet_glass
            // 
            this.closet_glass.Image = ((System.Drawing.Image)(resources.GetObject("closet_glass.Image")));
            this.closet_glass.Location = new System.Drawing.Point(376, 138);
            this.closet_glass.Name = "closet_glass";
            this.closet_glass.Size = new System.Drawing.Size(85, 92);
            this.closet_glass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closet_glass.TabIndex = 17;
            this.closet_glass.TabStop = false;
            this.closet_glass.Click += new System.EventHandler(this.closet_glass_Click);
            // 
            // closet_multicolor
            // 
            this.closet_multicolor.Image = ((System.Drawing.Image)(resources.GetObject("closet_multicolor.Image")));
            this.closet_multicolor.Location = new System.Drawing.Point(261, 138);
            this.closet_multicolor.Name = "closet_multicolor";
            this.closet_multicolor.Size = new System.Drawing.Size(85, 92);
            this.closet_multicolor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closet_multicolor.TabIndex = 16;
            this.closet_multicolor.TabStop = false;
            this.closet_multicolor.Click += new System.EventHandler(this.closet_multicolor_Click);
            // 
            // Form3_Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.tiny_closet);
            this.Controls.Add(this.closet_wood);
            this.Controls.Add(this.closet_white);
            this.Controls.Add(this.closet_orange_blue);
            this.Controls.Add(this.closet_glass);
            this.Controls.Add(this.closet_multicolor);
            this.Controls.Add(this.Return_btn);
            this.Controls.Add(this.Confirm_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Personnalise);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Basket);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Recommand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3_Catalog";
            this.Text = "Form3_Catalog";
            this.Load += new System.EventHandler(this.Form3_Catalog_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tiny_closet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closet_wood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closet_white)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closet_orange_blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closet_glass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closet_multicolor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Basket;
        private System.Windows.Forms.Label Logo;
        private System.Windows.Forms.ListBox Recommand;
        private System.Windows.Forms.ListBox Personnalise;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Filter1;
        private System.Windows.Forms.ToolStripTextBox toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.Button Return_btn;
        private System.Windows.Forms.Button Confirm_btn;
        private System.Windows.Forms.PictureBox closet_multicolor;
        private System.Windows.Forms.PictureBox closet_glass;
        private System.Windows.Forms.PictureBox closet_orange_blue;
        private System.Windows.Forms.PictureBox closet_white;
        private System.Windows.Forms.PictureBox closet_wood;
        private System.Windows.Forms.PictureBox tiny_closet;
    }
}