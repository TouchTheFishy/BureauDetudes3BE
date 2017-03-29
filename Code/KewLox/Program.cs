
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static KewLox.DBConnect;

namespace KewLox
{
    class Program
    {
        private static int id;
        public static int Id
        {
            get { return id; }
            set { id = value; }

        }
        static void Main(string[] args)
        {

            string table = "commandes";
            string[] columns = new string[] { "FirstName", "LastName", "Email", "Numero" };
            string[] donnee = new string[] { "William", "Chagnot", "carbure.de.tungstene@gmail.com", "0488577410" };
            DBConnect database = new DBConnect();

            int test = database.Insert(table, columns, donnee);

            string column1 = "Prix";
            string column2 = "id";
            string prix = "25";
            int id = 1;

            database.Update(table, column1, column2, prix, id);

            Console.WriteLine(test);
            Console.ReadKey();
            
        }
    }
}
