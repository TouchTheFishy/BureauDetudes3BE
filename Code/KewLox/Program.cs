
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
<<<<<<< HEAD

            DBConnect database = new DBConnect();
            

        

            Id=database.Insert("commandes","`FirstName` ","'Temp'");
            // Trouver un moyen de générer un id unique pour les clients.
            /*closet1.CalculateHeightOptions();
            List<KeyValuePair<int, List<KeyValuePair<ConstructionParts, int>>>> Parts = new List<KeyValuePair<int, List<KeyValuePair<ConstructionParts, int>>>>();
            Parts = closet1.AddBoxes();
            closet1.CalculateTotalParts(Parts);*/
            
=======
            string table = "commandes";
            string[] columns = new string[] { "FirstName", "LastName", "Email", "Numero" };
            string[] donnee = new string[] { "William", "Chagnot", "carbure.de.tungstene@gmail.com", "0488577410" };
            DBConnect database = new DBConnect();

            int test = database.Insert(table, columns, donnee);
>>>>>>> 30396768bc22139f54802313e218c12b1407ccef

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
