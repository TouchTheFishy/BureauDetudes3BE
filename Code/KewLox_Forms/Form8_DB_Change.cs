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
    public partial class Form8_DB_Change : Form
    {
        public static Closet closet1;
        public static Closet Armoire
        {
            get { return closet1; }
            set { closet1 = value; }
        }
        public Form8_DB_Change()
        {
            InitializeComponent();
            

            

        }


        //To return to Main Menu
        private void Title_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            Welcome_form frm = new Welcome_form(Armoire);
            frm.Show();
            Hide();
        }

        //To go backward

        //To go forward

        private void label15_Click(object sender, EventArgs e)
        {
            //Has to stay there
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            string [,] instock=db.Select("Enstock", "stock", "Code = '" + textBox1.Text + "'");
            if (instock[0, 0]=="error")
            {
                MessageBox.Show("Wrong Code");
            }
            else
            {
                int available = Convert.ToInt32(instock[0, 1]);
                if (available < 0)
                {
                    available = 0;
                }
                try
                {
                    int newstock = available + Convert.ToInt32(numericUpDown1.Text);
                    db.UpdateInt("stock",  "enstock", "Code", newstock, textBox1.Text);
                    Form8_DB_Change frm = new Form8_DB_Change();
                    frm.Show();
                    Hide();

                }
                catch (FormatException)
                {
                    MessageBox.Show("Wrong amount");
                }
                
            }
        }
    }
}
