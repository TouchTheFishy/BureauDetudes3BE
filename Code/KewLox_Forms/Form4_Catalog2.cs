using KewLox_Forms_.Properties;
using MySql.Data.MySqlClient.Properties;
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
    public partial class Form4_Catalog2 : Form
    {
        public static Closet closet1;
        public static Closet Armoire
        {
            get { return closet1; }
            set { closet1 = value; }
        }
        public static int boxstep = 1;
        public static int BoxStep
        {
            get { return boxstep; }
            set { boxstep = value; }
        }
        public static int closetwidth=80;
        public static int ClosetWidth
        {
            get { return closetwidth; }
            set { closetwidth = value; }
        }
        public static int closetdepth=62;
        public static int Depth
        {
            get { return closetdepth; }
            set { closetdepth = value; }
        }
        public static int totalHeight=125;
        public static int TotalHeight
        {
            get { return totalHeight; }
            set { totalHeight = value; }
        }
        public static int boxamount=1;
        public static int Boxamount
        {
            get { return boxamount; }
            set { boxamount = value; }
        }
        public static string lcolor="White";
        public static string Lcolor
        {
            get { return lcolor; }
            set { lcolor = value; }
        }
        public static string rcolor = "White";
        public static string Rcolor
        {
            get { return rcolor; }
            set { rcolor = value; }
        }
        public static string backcolor = "White";
        public static string Backcolor
        {
            get { return backcolor; }
            set { backcolor = value; }
        }
        public static string dcolor = "White";
        public static string Dcolor
        {
            get { return dcolor; }
            set { dcolor = value; }
        }
        public static string botcolor = "White";
        public static string Botcolor
        {
            get { return botcolor; }
            set { botcolor = value; }
        }
        public static string doormat = "Cup";
        public static string Doormat
        {
            get { return doormat; }
            set { doormat = value; }
        }
        public static int boxheight=46;
        public static int Boxheight
        {
            get { return boxheight; }
            set { boxheight = value; }
        }
        public static string tcolor = "White";
        public static string Tcolor
        {
            get { return tcolor; }
            set { tcolor = value; }
        }
        public static string acolor = "White";
        public static string Acolor
        {
            get { return acolor; }
            set { acolor = value; }
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
        public static int realheight=0;
        public static int RealHeight
        {
            get { return realheight; }
            set { realheight = value; }
        }
        public Form4_Catalog2()
        {
            BoxStep = 1;
            
            InitializeComponent();
            NextBox.Enabled = false;
            textBox1.Text = Convert.ToString(BoxStep);
            Closet closet = new Closet();
            
            Armoire = closet;

        }

        private void Form4_Catalog2_Load(object sender, EventArgs e)
        {

        }

        //To return to Main Menu
        private void Title_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            db.Cancel(Program.Id);
            Application.Restart();
            Hide();
        }
        
        //To show the Basket of the Client
        private void Basket_Click(object sender, EventArgs e)
        {
            Basket_form frm = new Basket_form();
            frm.Show();
            Hide();
        }

      

        // To change the color or the material of the door with button
        private void Blue_Click(object sender, EventArgs e)
        {
            Case.Image = KewLox_Forms_.Properties.Resources.case_blue;
        }

        private void Red_Click(object sender, EventArgs e)
        {
            Case.Image = KewLox_Forms_.Properties.Resources.case_red;
        }

        private void Green_Click(object sender, EventArgs e)
        {
            Case.Image = KewLox_Forms_.Properties.Resources.case_green;
        }

        private void Yellow_Click(object sender, EventArgs e)
        {
            Case.Image = KewLox_Forms_.Properties.Resources.case_yellow;
        }

        private void Orange_Click(object sender, EventArgs e)
        {
            Case.Image = KewLox_Forms_.Properties.Resources.case_orange;
        }

        private void Pink_Click(object sender, EventArgs e)
        {
            Case.Image = KewLox_Forms_.Properties.Resources.case_pink;
        }

        private void White_Click(object sender, EventArgs e)
        {
            Case.Image = KewLox_Forms_.Properties.Resources._case;
        }


        //To choose a material for the door with the filter
        private void Cup_fltr_MouseHover(object sender, EventArgs e)
        {
            Case.Image = KewLox_Forms_.Properties.Resources._case;
        }

        private void Glass_fltr_MouseHover(object sender, EventArgs e)
        {
            Case.Image = KewLox_Forms_.Properties.Resources.case_glass;
        }

        // To choose the number of cases in one closet
        private void closet_1case_MouseHover(object sender, EventArgs e)
        {
            closet_multicolor.Image = KewLox_Forms_.Properties.Resources.closet_1case;
            Boxamount = 1;
            NextBox.Enabled = true;

        }

        private void closet_2case_MouseHover(object sender, EventArgs e)
        {
           
            closet_multicolor.Image = KewLox_Forms_.Properties.Resources.closet_2case;
            Boxamount = 2;
            NextBox.Enabled = true;
        }

        private void closet_3case_MouseHover(object sender, EventArgs e)
        {
            closet_multicolor.Image = KewLox_Forms_.Properties.Resources.closet_3case;
            Boxamount = 3;
            NextBox.Enabled = true;
        }

        private void closet_4case_MouseHover(object sender, EventArgs e)
        {
            closet_multicolor.Image = KewLox_Forms_.Properties.Resources.closet_4case;
            Boxamount = 4;
            NextBox.Enabled = true;
        }

        private void closet_5case_MouseHover(object sender, EventArgs e)
        {
            
            closet_multicolor.Image = KewLox_Forms_.Properties.Resources.closet_5case;
            Boxamount = 5;
            NextBox.Enabled = true;
        }

        private void closet_6case_MouseHover(object sender, EventArgs e)
        {
            closet_multicolor.Image = KewLox_Forms_.Properties.Resources.closet_6case;
            Boxamount = 6;
            NextBox.Enabled = true;
        }

        private void closet_7case_MouseHover(object sender, EventArgs e)
        {
            closet_multicolor.Image = KewLox_Forms_.Properties.Resources.closet_7case;
            Boxamount = 7;
            NextBox.Enabled = true;
        }

        //The different values of Depth
        private void D_32_Click(object sender, EventArgs e)
        {
            Depth = 32;

        }

        private void D_42_Click(object sender, EventArgs e)
        {
            Depth = 42;
        }

        private void D_52_Click(object sender, EventArgs e)
        {
            Depth = 52;
        }

        private void D_62_Click(object sender, EventArgs e)
        {
            Depth = 62;
        }


        //The different values of Width
        private void W_32_Click(object sender, EventArgs e)
        {
            ClosetWidth = 32;
            Glass_btn.Enabled = false;
            Cup_btn.Enabled = false;
            No_cup.Enabled = false;
            nodoor.Enabled = false;
        }

        private void W_42_Click(object sender, EventArgs e)
        {
            ClosetWidth = 42;
            Glass_btn.Enabled = false;
            Cup_btn.Enabled = false;
            No_cup.Enabled = false;
            nodoor.Enabled = false;
        }

        private void W_52_Click(object sender, EventArgs e)
        {
            ClosetWidth = 52;
            Glass_btn.Enabled = false;
            Cup_btn.Enabled = false;
            No_cup.Enabled = false;
            nodoor.Enabled = false;
        }

        private void W_62_Click(object sender, EventArgs e)
        {
            ClosetWidth = 62;
            Glass_btn.Enabled = true;
            Cup_btn.Enabled = true;
            No_cup.Enabled = true;
            nodoor.Enabled = true;
        }

        private void W_80_Click(object sender, EventArgs e)
        {
            ClosetWidth = 80;
            Glass_btn.Enabled = true;
            Cup_btn.Enabled = true;
            No_cup.Enabled = true;
            nodoor.Enabled = true;
        }

        private void W_100_Click(object sender, EventArgs e)
        {
            ClosetWidth = 100;
            Glass_btn.Enabled = true;
            Cup_btn.Enabled = true;
            No_cup.Enabled = true;
            nodoor.Enabled = true;
        }

        private void W_120_Click(object sender, EventArgs e)
        {
            ClosetWidth = 120;
            Glass_btn.Enabled = true;
            Cup_btn.Enabled = true;
            No_cup.Enabled = true;
            nodoor.Enabled = true;
        }


        //The total height

        private void Total_height_Textbox_TextChanged(object sender, EventArgs e)
        {
            if (Total_height_Textbox.Text != ""){
                try
                {
                    int Total_height = Convert.ToInt32(Total_height_Textbox.Text);
                    int maxbox = Total_height / 56;
                    switch (maxbox)
                    {
                        case 0:
                            closet_1case.Enabled = false;
                            closet_2case.Enabled = false;
                            closet_3case.Enabled = false;
                            closet_4case.Enabled = false;
                            closet_5case.Enabled = false;
                            closet_6case.Enabled = false;
                            closet_7case.Enabled = false;
                            break;
                        case 1:
                            closet_1case.Enabled = true;
                            closet_2case.Enabled = false;
                            closet_3case.Enabled = false;
                            closet_4case.Enabled = false;
                            closet_5case.Enabled = false;
                            closet_6case.Enabled = false;
                            closet_7case.Enabled = false;
                            break;
                        case 2:
                            closet_1case.Enabled = true;
                            closet_2case.Enabled = true;
                            closet_3case.Enabled = false;
                            closet_4case.Enabled = false;
                            closet_5case.Enabled = false;
                            closet_6case.Enabled = false;
                            closet_7case.Enabled = false;
                            break;
                        case 3:
                            closet_1case.Enabled = true;
                            closet_2case.Enabled = true;
                            closet_3case.Enabled = true;
                            closet_4case.Enabled = false;
                            closet_5case.Enabled = false;
                            closet_6case.Enabled = false;
                            closet_7case.Enabled = false;
                            break;
                        case 4:
                            closet_1case.Enabled = true;
                            closet_2case.Enabled = true;
                            closet_3case.Enabled = true;
                            closet_4case.Enabled = true;
                            closet_5case.Enabled = false;
                            closet_6case.Enabled = false;
                            closet_7case.Enabled = false;
                            break;
                        case 5:
                            closet_1case.Enabled = true;
                            closet_2case.Enabled = true;
                            closet_3case.Enabled = true;
                            closet_4case.Enabled = true;
                            closet_5case.Enabled = true;
                            closet_6case.Enabled = false;
                            closet_7case.Enabled = false; ;
                            break;
                        case 6:
                            closet_1case.Enabled = true;
                            closet_2case.Enabled = true;
                            closet_3case.Enabled = true;
                            closet_4case.Enabled = true;
                            closet_5case.Enabled = true;
                            closet_6case.Enabled = true;
                            closet_7case.Enabled = false;
                            break;
                        case 7:
                            closet_1case.Enabled = true;
                            closet_2case.Enabled = true;
                            closet_3case.Enabled = true;
                            closet_4case.Enabled = true;
                            closet_5case.Enabled = true;
                            closet_6case.Enabled = true;
                            closet_7case.Enabled = true;
                            break;

                    }
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Please enter a number");
                }
            }
            
        }

        // To define the color of the Back panel
        private void B_Brown_Click(object sender, EventArgs e)
        {
            Backcolor = "Brown";
        }

        private void B_white_Click(object sender, EventArgs e)
        {
            Backcolor = "White";
        }


        // To define the color of the Left panel
        private void L_Brown_Click(object sender, EventArgs e)
        {
            Case.Image = KewLox_Forms_.Properties.Resources.L_brown;
            Lcolor = "Brown";
        }

        private void L_white_Click(object sender, EventArgs e)
        {
            Case.Image = KewLox_Forms_.Properties.Resources.L_white;
            Lcolor = "White";
        }



        // To define the color of the Right panel
        private void R_Brown_Click(object sender, EventArgs e)
        {
            Rcolor = "Brown";
        }

        private void R_white_Click(object sender, EventArgs e)
        {
            Rcolor = "White";
        }


        // To define the color of the Down panel
        private void D_Brown_Click(object sender, EventArgs e)
        {
            Botcolor = "Brown";
        }

        private void D_white_Click(object sender, EventArgs e)
        {
            Botcolor = "White";
        }

 

        // To define the color or the materials of the doors
        private void Door_Brown_Click(object sender, EventArgs e)
        {
            Dcolor = "Brown";
            Case.Image = KewLox_Forms_.Properties.Resources.case_brown;
        }

        private void Door_white_Click(object sender, EventArgs e)
        {
            Dcolor = "White";
            Case.Image = KewLox_Forms_.Properties.Resources._case;
        }

        private void Glass_Click(object sender, EventArgs e)
        {
            Doormat = "Glass";
            Case.Image = KewLox_Forms_.Properties.Resources.case_glass;
        }

        private void Cup_Click(object sender, EventArgs e)
        {
            Doormat = "Cup";
            Case.Image = KewLox_Forms_.Properties.Resources._case;
        }

        private void No_cup_Click(object sender, EventArgs e)
        {
            Doormat = "Nocup";
            Case.Image = KewLox_Forms_.Properties.Resources.case_no_cup;
        }


        private void nodoor_Click(object sender, EventArgs e)
        {
            Doormat = "None";
        }




        private void NextBox_Click(object sender, EventArgs e)
        {
            RealHeight += Boxheight;
            if (TotalHeight.GetType() == null || ClosetWidth.GetType() == null || Depth.GetType() == null)
            {
                MessageBox.Show("Please choose a total height, a width and a depth.");
            }
            else
            {
                if (BoxStep <= Boxamount)
                {
                    Armoire.AddBoxes(Lcolor, Rcolor, Backcolor, Botcolor, Dcolor, Doormat, RealHeight, ClosetWidth, Depth, Boxheight, Acolor, Tcolor, false);
                    BoxStep = BoxStep + 1;
                    textBox1.Text = Convert.ToString(BoxStep);
                }


                if (BoxStep > Boxamount)
                {

                    decimal total = 0;
                    string totalstring;
                    string[] values;
                    List<KeyValuePair<string, int>> Parts = Armoire.AddBoxes(Lcolor, Rcolor, Backcolor, Botcolor, Dcolor, Doormat, RealHeight, ClosetWidth, Depth, Boxheight, Acolor, Tcolor, true);
                    total = Armoire.GetPrice(Parts);
                    values = total.ToString().Split(Convert.ToChar(","));
                    totalstring = values[0] + "." + values[1];
                    Nodup = Armoire.RemoveDuplicates(Parts);


                    Form5_Signup frm = new Form5_Signup(Nodup, total);
                    frm.Show();
                    Hide();
                }
            }
        }

        private void height36_Click(object sender, EventArgs e)
        {
            Boxheight = 36;

        }

        private void height46_Click(object sender, EventArgs e)
        {
            Boxheight = 46;
        }

        private void height56_Click(object sender, EventArgs e)
        {
            Boxheight = 56;
        }



        // To define the color of the top panel
        private void T_Brown_Click(object sender, EventArgs e)
        {
            Case.Image = KewLox_Forms_.Properties.Resources.top_brown;
            Tcolor = "Brown";
        }

        private void T_white_Click(object sender, EventArgs e)
        {
            Case.Image = KewLox_Forms_.Properties.Resources.top_white;
            Tcolor = "White";
        }


        // To define the color or the materials of the angles
        private void A_Black_Click(object sender, EventArgs e)
        {
            closet_multicolor.Image = KewLox_Forms_.Properties.Resources.corniere_black;
            Acolor = "Black";
        }

        private void A_White_Click(object sender, EventArgs e)
        {
            closet_multicolor.Image = KewLox_Forms_.Properties.Resources.closet_white;
            Acolor = "White";
        }

        private void A_chrom_Click(object sender, EventArgs e)
        {
            
            closet_multicolor.Image = KewLox_Forms_.Properties.Resources.corniere_chrom;
            Acolor = "Chromed";
        }


        private void Futur_choices_Click(object sender, EventArgs e)
        {

        }

        private void ABrown_Click(object sender, EventArgs e)
        {
            closet_multicolor.Image = KewLox_Forms_.Properties.Resources.corniere_brown;
            Acolor = "Brown";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Continue_Click(object sender, EventArgs e)
        {
                   
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
