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
        
        private static Int32 id;

        public static Int32 Id
        {
            get { return id; }
            set { id = value; }

        }

        static void Main(string[] args)
        {
            
            DBConnect database = new DBConnect();
            string[] column = new string[1] { "FirstName" };
            string[] name = new string[1] { "temp" };
            long tempId = database.Insert("commandes", column, name); //returns ID of command
            Id = Convert.ToInt32(tempId);
            Closet closet1 = new Closet();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Welcome_form(closet1));          
            //ChooseProvider bestprovider = new ChooseProvider("COR36BR", database);
            //Console.WriteLine(bestprovider.Provider);
            

        }
    }
}
