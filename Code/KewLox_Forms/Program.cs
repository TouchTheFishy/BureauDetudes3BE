/*
            string[] client = new string[7] {firstname,lastname,address,address2,email,number,VAT};
            closet1.MakeBill(closet1,Id, client);
            database.Update("commandes", "FirstName", "`id`", firstname, Convert.ToInt32(Id));
            database.Update("commandes", "`LastName`", "`id`", lastname, Convert.ToInt32(Id));
            database.Update("commandes", "`Price`", "`id`", totalstring, Convert.ToInt32(Id));
            database.Update("commandes", "`Address`", "`id`", address, Convert.ToInt32(Id));
            database.Update("commandes", "`Email`", "`id`", email, Convert.ToInt32(Id));
            database.Update("commandes", "`Number`", "`id`", number, Convert.ToInt32(Id));
            database.Update("commandes", "`Date`", "`id`", DateTime.Today.ToString("yyyy-MM-dd"), Convert.ToInt32(Id));
            //ChooseProvider bestprovider = new ChooseProvider("COR36BR", database);
            //Console.WriteLine(bestprovider.Provider);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            
        }
    }
}
=======*/
﻿using System;
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
            
            
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
