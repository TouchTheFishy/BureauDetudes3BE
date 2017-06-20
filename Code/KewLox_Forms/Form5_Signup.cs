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
        public static List<KeyValuePair<string, int>> nodup;
        public static List<KeyValuePair<string, int>> Nodup
        {
            get { return nodup; }
            set { nodup = value; }
        }
        public static decimal price;
        public static decimal Price
        {
            get { return price; }
            set { price = value; }
        }



        public Form5_Signup(List<KeyValuePair<string, int>> nodupli,decimal prix)
        {
                  
            InitializeComponent();
            Nodup = nodupli;
            Price = prix;
        }
        private void Form5_Signup_Load(object sender, EventArgs e)
        {

        }

        //To return to Main Menu
        private void Title_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            db.Cancel(Program.Id);
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
            Closet closet1= new Closet();
            bool done = false;
          
            if (firstname.Text.GetType() != typeof(string) || firstname.Text.GetType() == null || firstname.Text == ""
                || lastname.Text.GetType() != typeof(string) || lastname.Text.GetType() == null || lastname.Text == "")
            {
                MessageBox.Show("Please put your name");
            }
            //else if (Login.Text.GetType() != typeof(string) || Login.Text.GetType() == null 
            //    || Password.Text.GetType() != typeof(string) || Password.Text.GetType() == null)
            //{
            //    MessageBox.Show("Please put a Login and a Password");
            //}
            else if (address.Text.GetType() != typeof(string) || address.Text.GetType() == null 
                || phone.Text.GetType() != typeof(string) || phone.Text.GetType() == null 
                || mail.Text.GetType() != typeof(string) || mail.Text.GetType() == null)
            {
                MessageBox.Show("Please verify your contact information");
            }
            
            else
            {
                
                //Update(string table, string namecolumn1, string namecolumn2, string value1, int value2)
                //string query = "UPDATE " + table + " SET " + namecolumn1 + "='" + value1 + "' WHERE " + namecolumn2 + "='" + value2 + "'";
                string[] prixdb = (Price.ToString()).Split(Convert.ToChar(","));
                string prixDb = prixdb[0] + "." + prixdb[1];
                try
                {
                    //Convert.ToInt32(phone.Text);
                    //Convert.ToInt32(tva.Text);
                    database.Update("commandes", "TVA", "`id`", tva.Text, Convert.ToInt32(Program.Id));
                    database.Update("commandes", "Numero", "`id`", phone.Text, Convert.ToInt32(Program.Id));
                    database.Update("commandes", "Email", "`id`", mail.Text, Convert.ToInt32(Program.Id));
                    database.Update("commandes", "Prix", "`id`", Price.ToString("F"), Convert.ToInt32(Program.Id));
                    database.Update("commandes", "enterprise", "`id`", enterprise.Text, Convert.ToInt32(Program.Id));
                    database.Update("commandes", "FirstName", "`id`", firstname.Text, Convert.ToInt32(Program.Id));
                    database.Update("commandes", "LastName", "`id`", lastname.Text, Convert.ToInt32(Program.Id));
                    database.Update("commandes", "Address", "`id`", address.Text, Convert.ToInt32(Program.Id));
                    string[] customdata = new string[7] { firstname.Text, lastname.Text, address.Text, phone.Text, mail.Text, enterprise.Text, tva.Text };
                    closet1.MakeBill(prixDb, Nodup);
                    done = true;

                    
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Please verify your contact information");
                }
                if (done == true)
                {
                    Form7_Final_bill frm = new Form7_Final_bill();
                    frm.Show();
                    Hide();
                }
                
                
                
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
