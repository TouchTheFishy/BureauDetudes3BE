namespace KewLox_Forms
{
    partial class Form4_Catalog2
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
            this.label1 = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.Label();
            this.Basket = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();

            this.Dimension_Filter = new System.Windows.Forms.ToolStripMenuItem();
            this.depth = new System.Windows.Forms.ToolStripMenuItem();
            this.D_32 = new System.Windows.Forms.ToolStripMenuItem();
            this.D_42 = new System.Windows.Forms.ToolStripMenuItem();
            this.D_52 = new System.Windows.Forms.ToolStripMenuItem();
            this.D_62 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.width = new System.Windows.Forms.ToolStripMenuItem();
            this.W_32 = new System.Windows.Forms.ToolStripMenuItem();
            this.W_42 = new System.Windows.Forms.ToolStripMenuItem();
            this.W_52 = new System.Windows.Forms.ToolStripMenuItem();
            this.W_62 = new System.Windows.Forms.ToolStripMenuItem();
            this.W_80 = new System.Windows.Forms.ToolStripMenuItem();
            this.W_100 = new System.Windows.Forms.ToolStripMenuItem();
            this.W_120 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Nbr_case = new System.Windows.Forms.ToolStripMenuItem();
            this.closet_1case = new System.Windows.Forms.ToolStripTextBox();
            this.closet_2case = new System.Windows.Forms.ToolStripTextBox();
            this.closet_3case = new System.Windows.Forms.ToolStripTextBox();
            this.closet_4case = new System.Windows.Forms.ToolStripTextBox();
            this.closet_5case = new System.Windows.Forms.ToolStripTextBox();
            this.closet_6case = new System.Windows.Forms.ToolStripTextBox();
            this.closet_7case = new System.Windows.Forms.ToolStripTextBox();
            this.totalHeightToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.totalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.Total_height_Textbox = new System.Windows.Forms.ToolStripTextBox();
            this.Accessories_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Glass_fltr = new System.Windows.Forms.ToolStripMenuItem();
            this.Cup_fltr = new System.Windows.Forms.ToolStripMenuItem();
            this.Return_btn = new System.Windows.Forms.Button();
            this.Confirm_btn = new System.Windows.Forms.Button();
            this.Glass_btn = new System.Windows.Forms.Button();
            this.Cup_btn = new System.Windows.Forms.Button();
            this.Blue = new System.Windows.Forms.Button();
            this.Red = new System.Windows.Forms.Button();
            this.Orange = new System.Windows.Forms.Button();
            this.Green = new System.Windows.Forms.Button();
            this.Pink = new System.Windows.Forms.Button();
            this.Yellow = new System.Windows.Forms.Button();
            this.Material = new System.Windows.Forms.Label();
            this.Color = new System.Windows.Forms.Label();
            this.White = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Case = new System.Windows.Forms.PictureBox();
            this.closet_multicolor = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Case)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closet_multicolor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Your Closet";
            // 
            // Logo
            // 
            this.Logo.AutoSize = true;
            this.Logo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Logo.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo.Location = new System.Drawing.Point(243, -5);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(199, 59);
            this.Logo.TabIndex = 17;
            this.Logo.Text = "KewLox";
            this.Logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Logo.Click += new System.EventHandler(this.Title_Click);
            // 
            // Basket
            // 
            this.Basket.Location = new System.Drawing.Point(847, 0);
            this.Basket.Name = "Basket";
            this.Basket.Size = new System.Drawing.Size(137, 51);
            this.Basket.TabIndex = 16;
            this.Basket.Text = "Basket";
            this.Basket.UseVisualStyleBackColor = true;
            this.Basket.Click += new System.EventHandler(this.Basket_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Dimension_Filter,
            this.Accessories_Menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(108, 550);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Dimension_Filter
            // 
            this.Dimension_Filter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depth,
            this.toolStripSeparator2,
            this.width,
            this.toolStripSeparator3,
            this.totalToolStripMenuItem,
            this.Total_height_Textbox,
            this.totalHeightToolStripMenuItem,
            this.Nbr_case});
            this.Dimension_Filter.Name = "Dimension_Filter";
            this.Dimension_Filter.Size = new System.Drawing.Size(101, 19);
            this.Dimension_Filter.Text = "Dimension Filter";
            // 
            // depth
            // 
            this.depth.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.D_32,
            this.D_42,
            this.D_52,
            this.D_62});
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(207, 22);
            this.depth.Text = "Depth";
            // 
            // D_32
            // 
            this.D_32.Name = "D_32";
            this.D_32.Size = new System.Drawing.Size(106, 22);
            this.D_32.Text = "32 cm";
            this.D_32.Click += new System.EventHandler(this.D_32_Click);
            // 
            // D_42
            // 
            this.D_42.Name = "D_42";
            this.D_42.Size = new System.Drawing.Size(106, 22);
            this.D_42.Text = "42 cm";
            this.D_42.Click += new System.EventHandler(this.D_42_Click);
            // 
            // D_52
            // 
            this.D_52.Name = "D_52";
            this.D_52.Size = new System.Drawing.Size(106, 22);
            this.D_52.Text = "52 cm";
            this.D_52.Click += new System.EventHandler(this.D_52_Click);
            // 
            // D_62
            // 
            this.D_62.Name = "D_62";
            this.D_62.Size = new System.Drawing.Size(106, 22);
            this.D_62.Text = "62 cm";
            this.D_62.Click += new System.EventHandler(this.D_62_Click);
            // 
            // depth
            // 
            this.depth.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.D_32,
            this.D_42,
            this.D_52,
            this.D_62});
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(207, 22);
            this.depth.Text = "Depth";
            // 
            // D_32
            // 
            this.D_32.Name = "D_32";
            this.D_32.Size = new System.Drawing.Size(106, 22);
            this.D_32.Text = "32 cm";
            this.D_32.Click += new System.EventHandler(this.D_32_Click);
            // 
            // D_42
            // 
            this.D_42.Name = "D_42";
            this.D_42.Size = new System.Drawing.Size(106, 22);
            this.D_42.Text = "42 cm";
            this.D_42.Click += new System.EventHandler(this.D_42_Click);
            // 
            // D_52
            // 
            this.D_52.Name = "D_52";
            this.D_52.Size = new System.Drawing.Size(106, 22);
            this.D_52.Text = "52 cm";
            this.D_52.Click += new System.EventHandler(this.D_52_Click);
            // 
            // D_62
            // 
            this.D_62.Name = "D_62";
            this.D_62.Size = new System.Drawing.Size(106, 22);
            this.D_62.Text = "62 cm";
            this.D_62.Click += new System.EventHandler(this.D_62_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(204, 6);
            // 
            // width
            // 
            this.width.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.W_32,
            this.W_42,
            this.W_52,
            this.W_62,
            this.W_80,
            this.W_100,
            this.W_120});
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(207, 22);
            this.width.Text = "Width";
            // 
            // W_32
            // 
            this.W_32.Name = "W_32";
            this.W_32.Size = new System.Drawing.Size(112, 22);
            this.W_32.Text = "32 cm";
            this.W_32.Click += new System.EventHandler(this.W_32_Click);
            // 
            // W_42
            // 
            this.W_42.Name = "W_42";
            this.W_42.Size = new System.Drawing.Size(112, 22);
            this.W_42.Text = "42 cm";
            this.W_42.Click += new System.EventHandler(this.W_42_Click);
            // 
            // W_52
            // 
            this.W_52.Name = "W_52";
            this.W_52.Size = new System.Drawing.Size(112, 22);
            this.W_52.Text = "52 cm";
            this.W_52.Click += new System.EventHandler(this.W_52_Click);
            // 
            // W_62
            // 
            this.W_62.Name = "W_62";
            this.W_62.Size = new System.Drawing.Size(112, 22);
            this.W_62.Text = "62 cm";
            this.W_62.Click += new System.EventHandler(this.W_62_Click);
            // 
            // W_80
            // 
            this.W_80.Name = "W_80";
            this.W_80.Size = new System.Drawing.Size(112, 22);
            this.W_80.Text = "80 cm";
            this.W_80.Click += new System.EventHandler(this.W_80_Click);
            // 
            // W_100
            // 
            this.W_100.Name = "W_100";
            this.W_100.Size = new System.Drawing.Size(112, 22);
            this.W_100.Text = "100 cm";
            this.W_100.Click += new System.EventHandler(this.W_100_Click);
            // 
            // W_120
            // 
            this.W_120.Name = "W_120";
            this.W_120.Size = new System.Drawing.Size(112, 22);
            this.W_120.Text = "120 cm";
            this.W_120.Click += new System.EventHandler(this.W_120_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(204, 6);
            // 
            // Nbr_case
            // 
            this.Nbr_case.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closet_1case,
            this.closet_2case,
            this.closet_3case,
            this.closet_4case,
            this.closet_5case,
            this.closet_6case,
            this.closet_7case});
            this.Nbr_case.Name = "Nbr_case";
            this.Nbr_case.Size = new System.Drawing.Size(207, 22);
            this.Nbr_case.Text = "Number of Case required";
            // 
            // closet_1case
            // 
            this.closet_1case.Name = "closet_1case";
            this.closet_1case.Size = new System.Drawing.Size(100, 23);
            this.closet_1case.Text = "1";
            this.closet_1case.MouseHover += new System.EventHandler(this.closet_1case_MouseHover);
            // 
            // closet_2case
            // 
            this.closet_2case.Name = "closet_2case";
            this.closet_2case.Size = new System.Drawing.Size(100, 23);
            this.closet_2case.Text = "2";
            this.closet_2case.MouseHover += new System.EventHandler(this.closet_2case_MouseHover);
            // 
            // closet_3case
            // 
            this.closet_3case.Name = "closet_3case";
            this.closet_3case.Size = new System.Drawing.Size(100, 23);
            this.closet_3case.Text = "3";
            this.closet_3case.MouseHover += new System.EventHandler(this.closet_3case_MouseHover);
            // 
            // closet_4case
            // 
            this.closet_4case.Name = "closet_4case";
            this.closet_4case.Size = new System.Drawing.Size(100, 23);
            this.closet_4case.Text = "4";
            this.closet_4case.MouseHover += new System.EventHandler(this.closet_4case_MouseHover);
            // 
            // closet_5case
            // 
            this.closet_5case.Name = "closet_5case";
            this.closet_5case.Size = new System.Drawing.Size(100, 23);
            this.closet_5case.Text = "5";
            this.closet_5case.MouseHover += new System.EventHandler(this.closet_5case_MouseHover);
            // 
            // closet_6case
            // 
            this.closet_6case.Name = "closet_6case";
            this.closet_6case.Size = new System.Drawing.Size(100, 23);
            this.closet_6case.Text = "6";
            this.closet_6case.MouseHover += new System.EventHandler(this.closet_6case_MouseHover);
            // 
            // closet_7case
            // 
            this.closet_7case.Name = "closet_7case";
            this.closet_7case.Size = new System.Drawing.Size(100, 23);
            this.closet_7case.Text = "7";
            this.closet_7case.MouseHover += new System.EventHandler(this.closet_7case_MouseHover);
            // 
            // totalHeightToolStripMenuItem
            // 
            this.totalHeightToolStripMenuItem.Name = "totalHeightToolStripMenuItem";
            this.totalHeightToolStripMenuItem.Size = new System.Drawing.Size(204, 6);
            // 
            // totalToolStripMenuItem
            // 
            this.totalToolStripMenuItem.Name = "totalToolStripMenuItem";
            this.totalToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.totalToolStripMenuItem.Text = "Total height:";
            // 

            // Total_height_Textbox
            // 
            this.Total_height_Textbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Total_height_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Total_height_Textbox.Name = "Total_height_Textbox";
            this.Total_height_Textbox.Size = new System.Drawing.Size(100, 23);
            this.Total_height_Textbox.TextChanged += new System.EventHandler(this.Total_height_Textbox_TextChanged);
            // 
            // Accessories_Menu
            // 
            this.Accessories_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Glass_fltr,
            this.Cup_fltr});
            this.Accessories_Menu.Name = "Accessories_Menu";
            this.Accessories_Menu.Size = new System.Drawing.Size(101, 19);
            this.Accessories_Menu.Text = "Accessories";
            // 
            // Glass_fltr
            // 
            this.Glass_fltr.Name = "Glass_fltr";
            this.Glass_fltr.Size = new System.Drawing.Size(101, 22);
            this.Glass_fltr.Text = "Glass";
            this.Glass_fltr.MouseHover += new System.EventHandler(this.Glass_fltr_MouseHover);
            // 
            // Cup_fltr
            // 
            this.Cup_fltr.Name = "Cup_fltr";
            this.Cup_fltr.Size = new System.Drawing.Size(101, 22);
            this.Cup_fltr.Text = "Cup";
            this.Cup_fltr.MouseHover += new System.EventHandler(this.Cup_fltr_MouseHover);
            // 
            // Return_btn
            // 
            this.Return_btn.Location = new System.Drawing.Point(780, 494);
            this.Return_btn.Name = "Return_btn";
            this.Return_btn.Size = new System.Drawing.Size(100, 30);
            this.Return_btn.TabIndex = 24;
            this.Return_btn.Text = "Return";
            this.Return_btn.UseVisualStyleBackColor = true;
            this.Return_btn.Click += new System.EventHandler(this.Return_btn_Click);
            // 
            // Confirm_btn
            // 
            this.Confirm_btn.Location = new System.Drawing.Point(886, 494);
            this.Confirm_btn.Name = "Confirm_btn";
            this.Confirm_btn.Size = new System.Drawing.Size(100, 30);
            this.Confirm_btn.TabIndex = 23;
            this.Confirm_btn.Text = "Confirm";
            this.Confirm_btn.UseVisualStyleBackColor = true;
            this.Confirm_btn.Click += new System.EventHandler(this.Confirm_btn_Click);
            // 
            // Glass_btn
            // 
            this.Glass_btn.Location = new System.Drawing.Point(731, 290);
            this.Glass_btn.Name = "Glass_btn";
            this.Glass_btn.Size = new System.Drawing.Size(48, 23);
            this.Glass_btn.TabIndex = 27;
            this.Glass_btn.Text = "Glass";
            this.Glass_btn.UseVisualStyleBackColor = true;
            this.Glass_btn.Click += new System.EventHandler(this.Glass_Click);
            // 
            // Cup_btn
            // 
            this.Cup_btn.Location = new System.Drawing.Point(731, 319);
            this.Cup_btn.Name = "Cup_btn";
            this.Cup_btn.Size = new System.Drawing.Size(48, 23);
            this.Cup_btn.TabIndex = 28;
            this.Cup_btn.Text = "Cup";
            this.Cup_btn.UseVisualStyleBackColor = true;
            this.Cup_btn.Click += new System.EventHandler(this.Cup_Click);
            // 
            // Blue
            // 
            this.Blue.Location = new System.Drawing.Point(825, 319);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(55, 23);
            this.Blue.TabIndex = 30;
            this.Blue.Text = "Blue";
            this.Blue.UseVisualStyleBackColor = true;
            this.Blue.Click += new System.EventHandler(this.Blue_Click);
            // 
            // Red
            // 
            this.Red.Location = new System.Drawing.Point(825, 290);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(55, 23);
            this.Red.TabIndex = 29;
            this.Red.Text = "Red";
            this.Red.UseVisualStyleBackColor = true;
            this.Red.Click += new System.EventHandler(this.Red_Click);
            // 
            // Orange
            // 
            this.Orange.Location = new System.Drawing.Point(883, 319);
            this.Orange.Name = "Orange";
            this.Orange.Size = new System.Drawing.Size(56, 23);
            this.Orange.TabIndex = 32;
            this.Orange.Text = "Orange";
            this.Orange.UseVisualStyleBackColor = true;
            this.Orange.Click += new System.EventHandler(this.Orange_Click);
            // 
            // Green
            // 
            this.Green.Location = new System.Drawing.Point(883, 290);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(56, 23);
            this.Green.TabIndex = 31;
            this.Green.Text = "Green";
            this.Green.UseVisualStyleBackColor = true;
            this.Green.Click += new System.EventHandler(this.Green_Click);
            // 
            // Pink
            // 
            this.Pink.Location = new System.Drawing.Point(945, 319);
            this.Pink.Name = "Pink";
            this.Pink.Size = new System.Drawing.Size(48, 23);
            this.Pink.TabIndex = 34;
            this.Pink.Text = "Pink";
            this.Pink.UseVisualStyleBackColor = true;
            this.Pink.Click += new System.EventHandler(this.Pink_Click);
            // 
            // Yellow
            // 
            this.Yellow.Location = new System.Drawing.Point(945, 290);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(48, 23);
            this.Yellow.TabIndex = 33;
            this.Yellow.Text = "Yellow";
            this.Yellow.UseVisualStyleBackColor = true;
            this.Yellow.Click += new System.EventHandler(this.Yellow_Click);
            // 
            // Material
            // 
            this.Material.AutoSize = true;
            this.Material.Font = new System.Drawing.Font("Cambria", 10.25F);
            this.Material.Location = new System.Drawing.Point(728, 271);
            this.Material.Name = "Material";
            this.Material.Size = new System.Drawing.Size(59, 16);
            this.Material.TabIndex = 35;
            this.Material.Text = "Material";
            // 
            // Color
            // 
            this.Color.AutoSize = true;
            this.Color.Font = new System.Drawing.Font("Cambria", 10.25F);
            this.Color.Location = new System.Drawing.Point(822, 271);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(40, 16);
            this.Color.TabIndex = 36;
            this.Color.Text = "Color";
            // 
            // White
            // 
            this.White.Location = new System.Drawing.Point(825, 348);
            this.White.Name = "White";
            this.White.Size = new System.Drawing.Size(114, 23);
            this.White.TabIndex = 37;
            this.White.Text = "Simple White";
            this.White.UseVisualStyleBackColor = true;
            this.White.Click += new System.EventHandler(this.White_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.25F);
            this.label2.Location = new System.Drawing.Point(240, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(433, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Please go to the dimension filter and select the number of case desired";
            // 
            // Case
            // 
            this.Case.Location = new System.Drawing.Point(756, 103);
            this.Case.Name = "Case";
            this.Case.Size = new System.Drawing.Size(203, 143);
            this.Case.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Case.TabIndex = 26;
            this.Case.TabStop = false;
            // 
            // closet_multicolor
            // 
            this.closet_multicolor.Location = new System.Drawing.Point(243, 138);
            this.closet_multicolor.Name = "closet_multicolor";
            this.closet_multicolor.Size = new System.Drawing.Size(245, 377);
            this.closet_multicolor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closet_multicolor.TabIndex = 25;
            this.closet_multicolor.TabStop = false;
            // 
            // Form4_Catalog2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.White);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.Material);
            this.Controls.Add(this.Pink);
            this.Controls.Add(this.Yellow);
            this.Controls.Add(this.Orange);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.Cup_btn);
            this.Controls.Add(this.Glass_btn);
            this.Controls.Add(this.Case);
            this.Controls.Add(this.closet_multicolor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Basket);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Return_btn);
            this.Controls.Add(this.Confirm_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4_Catalog2";
            this.Text = ":";
            this.Load += new System.EventHandler(this.Form4_Catalog2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Case)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closet_multicolor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Logo;
        private System.Windows.Forms.Button Basket;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Dimension_Filter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Button Return_btn;
        private System.Windows.Forms.Button Confirm_btn;
        private System.Windows.Forms.ToolStripMenuItem Accessories_Menu;
        private System.Windows.Forms.ToolStripMenuItem Glass_fltr;
        private System.Windows.Forms.ToolStripMenuItem Cup_fltr;
        private System.Windows.Forms.PictureBox closet_multicolor;
        private System.Windows.Forms.PictureBox Case;
        private System.Windows.Forms.Button Glass_btn;
        private System.Windows.Forms.Button Cup_btn;
        private System.Windows.Forms.Button Blue;
        private System.Windows.Forms.Button Red;
        private System.Windows.Forms.Button Orange;
        private System.Windows.Forms.Button Green;
        private System.Windows.Forms.Button Pink;
        private System.Windows.Forms.Button Yellow;
        private System.Windows.Forms.Label Material;
        private System.Windows.Forms.Label Color;
        private System.Windows.Forms.Button White;
        private System.Windows.Forms.ToolStripMenuItem Nbr_case;
        private System.Windows.Forms.ToolStripTextBox closet_1case;
        private System.Windows.Forms.ToolStripTextBox closet_2case;
        private System.Windows.Forms.ToolStripTextBox closet_3case;
        private System.Windows.Forms.ToolStripTextBox closet_4case;
        private System.Windows.Forms.ToolStripTextBox closet_5case;
        private System.Windows.Forms.ToolStripTextBox closet_6case;
        private System.Windows.Forms.ToolStripTextBox closet_7case;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem depth;
        private System.Windows.Forms.ToolStripMenuItem D_32;
        private System.Windows.Forms.ToolStripMenuItem D_42;
        private System.Windows.Forms.ToolStripMenuItem D_52;
        private System.Windows.Forms.ToolStripMenuItem D_62;
        private System.Windows.Forms.ToolStripMenuItem width;
        private System.Windows.Forms.ToolStripMenuItem W_32;
        private System.Windows.Forms.ToolStripMenuItem W_42;
        private System.Windows.Forms.ToolStripMenuItem W_52;
        private System.Windows.Forms.ToolStripMenuItem W_62;
        private System.Windows.Forms.ToolStripMenuItem W_80;
        private System.Windows.Forms.ToolStripMenuItem W_100;
        private System.Windows.Forms.ToolStripMenuItem W_120;
        private System.Windows.Forms.ToolStripSeparator totalHeightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox Total_height_Textbox;
    }
}