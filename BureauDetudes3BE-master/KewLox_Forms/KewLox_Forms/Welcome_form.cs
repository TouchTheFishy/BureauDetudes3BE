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
    public partial class Welcome_form: Form
    {
        public Welcome_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Customer_Click(object sender, EventArgs e)
        {
            Form3_Catalog frm = new Form3_Catalog();
            frm.Show();
            Hide();
        }

        private void button_Admin_Click(object sender, EventArgs e)
        {
            Form2_Login_Admin frm = new Form2_Login_Admin();
            frm.Show();
            Hide();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
