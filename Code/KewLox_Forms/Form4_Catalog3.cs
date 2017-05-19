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
    public partial class Form4_Catalog3 : Form
    {
        public static Closet closet1;
        public static Closet Armoire
        {
            get { return closet1; }
            set { closet1 = value; }
        }
        public Form4_Catalog3()
        {
            InitializeComponent();
        }

        //To return to Main Menu
        private void Title_Click(object sender, EventArgs e)
        {
            Welcome_form frm = new Welcome_form(Armoire);
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
            Form4_Catalog2 frm = new Form4_Catalog2();
            frm.Show();
            Hide();
        }

        //To go forward
        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            Form5_Signup frm = new Form5_Signup(Armoire);
            frm.Show();
            Hide();
        }




        // To define the color of the top panel
        private void T_Brown_Click(object sender, EventArgs e)
        {
            Top.Image = KewLox_Forms_.Properties.Resources.top_brown;
        }

        private void T_white_Click(object sender, EventArgs e)
        {
            Top.Image = KewLox_Forms_.Properties.Resources.top_white;
        }


        // To define the color or the materials of the angles
        private void A_Black_Click(object sender, EventArgs e)
        {
            Corniere.Image = KewLox_Forms_.Properties.Resources.corniere_black;
        }

        private void A_White_Click(object sender, EventArgs e)
        {
            Corniere.Image = KewLox_Forms_.Properties.Resources.closet_white;
        }

        private void A_chrom_Click(object sender, EventArgs e)
        {
            Corniere.Image = KewLox_Forms_.Properties.Resources.corniere_chrom;
        }
    }
}
