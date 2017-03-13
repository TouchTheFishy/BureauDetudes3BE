using System;
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
            List<KeyValuePair<int, List<KeyValuePair<ConstructionParts, int>>>> Parts = new List<KeyValuePair<int, List<KeyValuePair<ConstructionParts, int>>>>();
            Parts = closet1.AddBoxes();
            closet1.CalculateTotalParts(Parts);




            Console.ReadKey();

        }

    }
}
