
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
            string[] column = new string[1] { "FirstName" };
            string[] name = new string[1] { "temp" };
            Id = database.Insert("commandes", column, name); //returns ID of command
            Closet closet1 = new Closet();
            closet1.CalculateHeightOptions();
            closet1.AddBoxes();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

            ChooseProvider bestprovider = new ChooseProvider("COR36BR", database);
            Console.WriteLine(bestprovider.Provider);
            Console.ReadKey();
            
        }
    }
}
