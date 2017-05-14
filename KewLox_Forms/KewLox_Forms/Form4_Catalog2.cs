using KewLox_Forms_.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KewLox_Forms
{
    public partial class Form4_Catalog2 : Form
    {
        public Form4_Catalog2()
        {
            InitializeComponent();
        }

        //To return to Main Menu
        private void Title_Click(object sender, EventArgs e)
        {
            Welcome_form frm = new Welcome_form();
            frm.Show();
            Hide();
        }
        
        //To show the Basket of the Client
        private void Basket_Click(object sender, EventArgs e)
        {
            Basket_form frm = new Basket_form();
            frm.Show();
            Hide();
        }

        //To go backward
        private void Return_btn_Click(object sender, EventArgs e)
        {
            Form3_Catalog frm = new Form3_Catalog();
            frm.Show();
            Hide();
        }

        //To go forward
        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            Form5_Signup frm = new Form5_Signup();
            frm.Show();
            Hide();
        }

        private void Blue_Click(object sender, EventArgs e)
        {
            Case.Image = Resources.case_blue;
        }

        private void Red_Click(object sender, EventArgs e)
        {
            Case.Image = Resources.case_red;
        }

        private void Green_Click(object sender, EventArgs e)
        {
            Case.Image = Resources.case_green;
        }

        private void Yellow_Click(object sender, EventArgs e)
        {
            Case.Image = Resources.case_yellow;
        }

        private void Orange_Click(object sender, EventArgs e)
        {
            Case.Image = Resources.case_orange;
        }

        private void Pink_Click(object sender, EventArgs e)
        {
            Case.Image = Resources.case_pink;
        }

        private void White_Click(object sender, EventArgs e)
        {
            Case.Image = Resources._case;
        }

        private void Cup_Click(object sender, EventArgs e)
        {
            Case.Image = Resources._case;
        }

        private void Glass_Click(object sender, EventArgs e)
        {
            Case.Image = Resources.case_glass;
        }
    }
}
