﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KewLox
{
    class Program
    {
        static void Main(string[] args)
        {
            Closet closet1 = new Closet();
            closet1.CalculateHeightOptions();
            closet1.AddBoxes();




            Console.ReadKey();

        }

    }
}
