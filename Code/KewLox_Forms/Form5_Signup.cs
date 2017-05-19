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
            Form4_Catalog2 frm = new Form4_Catalog2();
            frm.Show();
            Hide();
        }

        //To go forward
        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            DBConnect database = new DBConnect();

            //Update(string table, string namecolumn1, string namecolumn2, string value1, int value2)
            //string query = "UPDATE " + table + " SET " + namecolumn1 + "='" + value1 + "' WHERE " + namecolumn2 + "='" + value2 + "'";
            database.Update("commandes", "Login", "`id`", Login.Text, Convert.ToInt32(Program.Id));
            database.Update("commandes", "Password", "`id`", Password.Text, Convert.ToInt32(Program.Id));

            database.Update("commandes", "FirstName", "`id`", firstname.Text, Convert.ToInt32(Program.Id));
            database.Update("commandes", "LastName", "`id`", lastname.Text, Convert.ToInt32(Program.Id));
            database.Update("commandes", "Address", "`id`", address.Text, Convert.ToInt32(Program.Id));
            database.Update("commandes", "Phone", "`id`", phone.Text, Convert.ToInt32(Program.Id));
            database.Update("commandes", "Mail", "`id`", mail.Text, Convert.ToInt32(Program.Id));
            database.Update("commandes", "enterprise", "`id`", enterprise.Text, Convert.ToInt32(Program.Id));
            database.Update("commandes", "TVA", "`id`", tva.Text, Convert.ToInt32(Program.Id));


            Form6_Resume frm = new Form6_Resume();
            frm.Show();
            this.Close();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
