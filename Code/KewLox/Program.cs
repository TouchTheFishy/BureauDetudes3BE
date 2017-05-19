
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
            total = closet1.GetPrice();
            values = total.ToString().Split(Convert.ToChar(","));
            totalstring = values[0] + "." + values[1];
            Console.WriteLine("What is your firstname or company name?");
            string firstname = Console.ReadLine();
            Console.WriteLine("What is your lastname or company representative?");
            string lastname = Console.ReadLine();
            Console.WriteLine("What are your street name and number?");
            string address = Console.ReadLine();
            Console.WriteLine("What are your postcode and your city?");
            string address2 = Console.ReadLine();
            Console.WriteLine("What is your email address?");
            string email = Console.ReadLine();
            Console.WriteLine("What is your telephone number?");
            string number =Console.ReadLine();
            Console.WriteLine("What is your VAT number?");
            string VAT = Console.ReadLine();
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
