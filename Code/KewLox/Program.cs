
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static KewLox.DBConnect;
using System.Globalization;

namespace KewLox
{
    class Program
    {
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
            closet1.CalculateHeightOptions();
            closet1.AddBoxes();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            foreach (KeyValuePair<string,int> part in closet1.Parts)
            {
                string[,] prix = database.Select("`Prix-Client`", "stock", "`Code`='"+part.Key+"'");
                decimal priceperpart = Convert.ToDecimal(prix[0, 1].ToString());
                decimal nbparts = Convert.ToDecimal(part.Value);
                total += (priceperpart*nbparts);
            }
            values = total.ToString().Split(Convert.ToChar(","));
            totalstring = values[0] + "." + values[1];
            Console.WriteLine(totalstring);
            database.Update("commandes", "`Prix`", "`id`", totalstring, Convert.ToInt32(Id));
            //ChooseProvider bestprovider = new ChooseProvider("COR36BR", database);
            //Console.WriteLine(bestprovider.Provider);
            Console.ReadKey();
            
        }
    }
}
