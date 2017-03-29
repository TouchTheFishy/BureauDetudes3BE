
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
        static void Main(string[] args)
        {
            string table = "commandes";
            string[] columns = new string[] { "FirstName", "LastName", "Email", "Numero" };
            string[] donnee = new string[] { "William", "Chagnot", "carbure.de.tungstene@gmail.com", "0488577410" };
            DBConnect database = new DBConnect();

            database.Insert(table, columns, donnee);

            string column1 = "Prix";
            string column2 = "id";
            string prix = "25";
            int id = 1;

            database.Update(table, column1, column2, prix, id);

            // Trouver un moyen de générer un id unique pour les clients.
            /*closet1.CalculateHeightOptions();
            List<KeyValuePair<int, List<KeyValuePair<ConstructionParts, int>>>> Parts = new List<KeyValuePair<int, List<KeyValuePair<ConstructionParts, int>>>>();
            Parts = closet1.AddBoxes();
            closet1.CalculateTotalParts(Parts);
            



            Console.ReadKey();
            */
        }
    }
}
