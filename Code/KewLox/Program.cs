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
            string idclient = "XXX";
            CreateTable(idclient); // Trouver un moyen de générer un id unique pour les clients.
            /*closet1.CalculateHeightOptions();
            List<KeyValuePair<int, List<KeyValuePair<ConstructionParts, int>>>> Parts = new List<KeyValuePair<int, List<KeyValuePair<ConstructionParts, int>>>>();
            Parts = closet1.AddBoxes();
            closet1.CalculateTotalParts(Parts);
            



            Console.ReadKey();
            */
        }
    }
}
