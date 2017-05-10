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
    public partial class Form6_Resume : Form
    {
        public Form6_Resume()
        {
            InitializeComponent();
        }

        private void Form6_Resume_Load(object sender, EventArgs e)
        {

        }

        //To return to Main Menu
        private void Title_Click(object sender, EventArgs e)
        {
            Welcome_form frm = new Welcome_form();
            frm.Show();
            Hide();
        }

        //To go backward
        private void Return_btn_Click(object sender, EventArgs e)
        {
            Form5_Signup frm = new Form5_Signup();
            frm.Show();
            Hide();
        }

        //To go forward
        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            Form7_Final_bill frm = new Form7_Final_bill();
            frm.Show();
            Hide();

        }

        private void label15_Click(object sender, EventArgs e)
        {
            //Has to stay there
        }

        //Infos about the closet
        private void NbrBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NbrTasseau_TextChanged(object sender, EventArgs e)
        {

        }

        private void NbrTraverseAV_TextChanged(object sender, EventArgs e)
        {

        }

        private void NbrTraverseAR_TextChanged(object sender, EventArgs e)
        {

        }

        private void NbrTraverseGD_TextChanged(object sender, EventArgs e)
        {

        }

        private void NbrPanelHB_TextChanged(object sender, EventArgs e)
        {

        }

        private void NbrPanelGD_TextChanged(object sender, EventArgs e)
        {

        }

        private void NbrPanelAR_TextChanged(object sender, EventArgs e)
        {

        }

        private void NbrDoors_TextChanged(object sender, EventArgs e)
        {

        }

        private void NbrCup_TextChanged(object sender, EventArgs e)
        {

        }


        //Info about the Customer
        private void FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addres_TextChanged(object sender, EventArgs e)
        {

        }

        private void Phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Enterprise_TextChanged(object sender, EventArgs e)
        {

        }

        private void TVA_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
