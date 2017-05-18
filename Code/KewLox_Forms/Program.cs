using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KewLox_Forms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        private static Int64 id;

        public static Int64 Id
        {
            get { return id; }
            set { id = value; }

        }

        static void Main(string[] args)
        {
            
            decimal total = 0;
            string totalstring;
            string[] values;
            DBConnect database = new DBConnect();
            string[] column = new string[1] { "FirstName" };
            string[] name = new string[1] { "temp" };
            Id = database.Insert("commandes", column, name); //returns ID of command
            Closet closet1 = new Closet();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Welcome_form(closet1));            
            total = closet1.GetPrice();
            values = total.ToString().Split(Convert.ToChar(","));
            totalstring = values[0] + "." + values[1];
            Console.WriteLine("What is your firstname?");
            string firstname = Console.ReadLine();
            Console.WriteLine("What is your lastname?");
            string lastname = Console.ReadLine();
            database.Update("commandes", "FirstName", "`id`", firstname, Convert.ToInt32(Id));
            database.Update("commandes", "`LastName`", "`id`", lastname, Convert.ToInt32(Id));
            database.Update("commandes", "`Prix`", "`id`", totalstring, Convert.ToInt32(Id));
            //ChooseProvider bestprovider = new ChooseProvider("COR36BR", database);
            //Console.WriteLine(bestprovider.Provider);
            closet1.MakeBill(closet1, Id);
            
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
