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
    public partial class Form7_Final_bill : Form
    {
        public Form7_Final_bill()
        {
            InitializeComponent();
        }

        private void Form7_Final_bill_Load(object sender, EventArgs e)
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
            Form6_Resume frm = new Form6_Resume();
            frm.Show();
            Hide();
        }

        //To go forward
        private void Pay_btn_Click(object sender, EventArgs e)
        {
            //Open a browser to show the bill
        }

        //To show the result of the bill
        private void Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
