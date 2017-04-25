
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

            
            DBConnect database = new DBConnect();
<<<<<<< HEAD
            database.CreateTable(idclient);
            // Trouver un moyen de générer un id unique pour les clients.
            Closet closet1 = new Closet();
            List<int> values=closet1.CalculateHeightOptions();
            List<KeyValuePair<int, List<KeyValuePair<ConstructionParts, int>>>> Parts = new List<KeyValuePair<int, List<KeyValuePair<ConstructionParts, int>>>>();
            Parts = closet1.AddBoxes( values);
            closet1.CalculateTotalParts(Parts);
            

=======
            string[] column = new string[1] { "FirstName" };
            string[] name = new string[1] { "temp" };
            Id = database.Insert("commandes", column, name);
            Closet closet1 = new Closet();
            closet1.CalculateHeightOptions();
            closet1.AddBoxes();
>>>>>>> 9c87ea15414078ab2f4f9922c6d74d2576c03ff8


            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            
        }
    }
}
