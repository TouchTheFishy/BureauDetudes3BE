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
        public static Closet closet1;
        public static Closet Armoire
        {
            get { return closet1; }
            set { closet1 = value; }
        }
        public Form6_Resume()
        {
            InitializeComponent();
            DBConnect db = new DBConnect();
            int i = 1;

            while (true)
            {
                string[,] missing = db.Select("Code", "missingcomponents", "Id = " + i);
               
                if (missing[0, 0] == "error")
                {
                    db.CloseConnection();
                    break;
                }
                MissingParts.Items.Add(missing[0,1]);

                i += 1;
            }
            
        }

        private void Form6_Resume_Load(object sender, EventArgs e)
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
            //Form5_Signup frm = new Form5_Signup(Armoire);
            //frm.Show();
            //Hide();
        }

        //To go forward
        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            Welcome_form frm = new Welcome_form(Armoire);
            frm.Show();
            Hide();

        }

        private void label15_Click(object sender, EventArgs e)
        {
            //Has to stay there
        }
    }
}
