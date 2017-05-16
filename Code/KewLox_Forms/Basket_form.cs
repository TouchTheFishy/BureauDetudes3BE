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
    public partial class Basket_form : Form
    {
        public static Closet closet1;
        public static Closet Armoire
        {
            get { return closet1; }
            set { closet1 = value; }
        }
        public Basket_form()
        {
            InitializeComponent();
        }

        private void Basket_form_Load(object sender, EventArgs e)
        {

        }
        //To return to Main Menu
        private void Title_Click(object sender, EventArgs e)
        {
            Welcome_form frm = new Welcome_form(Armoire);
            frm.Show();
            Hide();
        }

        //To go backward
        private void Return_btn_Click(object sender, EventArgs e)
        {
            Form3_Catalog frm = new Form3_Catalog(Armoire);
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




        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
