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
    public partial class Form2_Login_Admin : Form
    {
        public static Closet closet1;
        public static Closet Closet
        {
            get { return closet1; }
            set { closet1 = value; }
        }
        public Form2_Login_Admin()
        {
            InitializeComponent();
        }

        private void Form2_Login_Admin_Load(object sender, EventArgs e)
        {

        }
        //To return to Main Menu
        private void Title_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            db.Cancel(Program.Id);
            Welcome_form frm = new Welcome_form(Closet);
            frm.Show();
            Hide();
        }

        //To go backward
        private void Return_btn_Click(object sender, EventArgs e)
        {
            Welcome_form frm = new Welcome_form(Closet);
            frm.Show();
            Hide();
        }

        //To check the login and the password of the manager
        private void Retrieve_btn_Click(object sender, EventArgs e)
        {
            //Tiny test to retrieve the value
            MessageBox.Show(this.Login.Text + this.Password.Text);
            MessageBox.Show(this.Password.Text);
            
            //To save the two value given by the user
            string Log = Login.Text;
            string Pass = Password.Text;

        }
    }
}
