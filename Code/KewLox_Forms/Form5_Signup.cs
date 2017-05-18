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
    public partial class Form5_Signup : Form
    {
        public static Closet closet1;
        public static Closet Armoire
        {
            get { return closet1; }
            set { closet1 = value; }
        }



        public Form5_Signup(Closet closet)
        {
            Armoire = closet;       
            InitializeComponent();
        }
        private void Form5_Signup_Load(object sender, EventArgs e)
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
            Form4_Catalog3 frm = new Form4_Catalog3();
            frm.Show();
            Hide();
        }

        //To go forward
        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            Form6_Resume frm = new Form6_Resume();
            frm.Show();
            this.Close();

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string Name = Convert.ToString(sender);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }


    }
}
