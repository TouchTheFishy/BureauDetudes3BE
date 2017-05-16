using KewLox_Forms_.Properties;
using MySql.Data.MySqlClient.Properties;
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

        private void Form4_Catalog2_Load(object sender, EventArgs e)
        {

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

        // To change the color or the material of the door with button
        private void Blue_Click(object sender, EventArgs e)
        {
            Case.Image = KewLox_Forms_.Properties.Resources.case_blue;
        }

        private void Red_Click(object sender, EventArgs e)
        {
            Case.Image = KewLox_Forms_.Properties.Resources.case_red;
        }

        private void Green_Click(object sender, EventArgs e)
        {
            Case.Image = KewLox_Forms_.Properties.Resources.case_green;
        }

        private void Yellow_Click(object sender, EventArgs e)
        {
            Case.Image = KewLox_Forms_.Properties.Resources.case_yellow;
        }

        private void Orange_Click(object sender, EventArgs e)
        {
            Case.Image = KewLox_Forms_.Properties.Resources.case_orange;
        }

        private void Pink_Click(object sender, EventArgs e)
        {
            Case.Image = KewLox_Forms_.Properties.Resources.case_pink;
        }

        private void White_Click(object sender, EventArgs e)
        {
            Case.Image = KewLox_Forms_.Properties.Resources._case;
        }

        private void Cup_Click(object sender, EventArgs e)
        {
            Case.Image = KewLox_Forms_.Properties.Resources._case;
        }

        private void Glass_Click(object sender, EventArgs e)
        {
            Case.Image = KewLox_Forms_.Properties.Resources.case_glass;
        }



        //To choose a material for the door with the filter
        private void Cup_fltr_MouseHover(object sender, EventArgs e)
        {
            Case.Image = KewLox_Forms_.Properties.Resources._case;
        }

        private void Glass_fltr_MouseHover(object sender, EventArgs e)
        {
            Case.Image = KewLox_Forms_.Properties.Resources.case_glass;
        }

        // To choose the number of cases in one closet
        private void closet_1case_MouseHover(object sender, EventArgs e)
        {
            closet_multicolor.Image = KewLox_Forms_.Properties.Resources.closet_1case;
        }

        private void closet_2case_MouseHover(object sender, EventArgs e)
        {
            closet_multicolor.Image = KewLox_Forms_.Properties.Resources.closet_2case;
        }

        private void closet_3case_MouseHover(object sender, EventArgs e)
        {
            closet_multicolor.Image = KewLox_Forms_.Properties.Resources.closet_3case;
        }

        private void closet_4case_MouseHover(object sender, EventArgs e)
        {
            closet_multicolor.Image = KewLox_Forms_.Properties.Resources.closet_4case;
        }

        private void closet_5case_MouseHover(object sender, EventArgs e)
        {
            closet_multicolor.Image = KewLox_Forms_.Properties.Resources.closet_5case;
        }

        private void closet_6case_MouseHover(object sender, EventArgs e)
        {
            closet_multicolor.Image = KewLox_Forms_.Properties.Resources.closet_6case;
        }

        private void closet_7case_MouseHover(object sender, EventArgs e)
        {
            closet_multicolor.Image = KewLox_Forms_.Properties.Resources.closet_7case;
        }

        //The different values of Depth
        private void D_32_Click(object sender, EventArgs e)
        {

        }

        private void D_42_Click(object sender, EventArgs e)
        {

        }

        private void D_52_Click(object sender, EventArgs e)
        {

        }

        private void D_62_Click(object sender, EventArgs e)
        {

        }


        //The different values of Width
        private void W_32_Click(object sender, EventArgs e)
        {

        }

        private void W_42_Click(object sender, EventArgs e)
        {

        }

        private void W_52_Click(object sender, EventArgs e)
        {

        }

        private void W_62_Click(object sender, EventArgs e)
        {

        }

        private void W_80_Click(object sender, EventArgs e)
        {

        }

        private void W_100_Click(object sender, EventArgs e)
        {

        }

        private void W_120_Click(object sender, EventArgs e)
        {

        }


        //The total height
        private void Total_height_Click(object sender, EventArgs e)
        {

        }

        private void Filter1_Click(object sender, EventArgs e)
        {

        }
    }
}
