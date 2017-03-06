using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KewLox
{
    

    class Closet
    {
        double totalHeight;
        public List<string> CalculateHeightOptions()

        {
            Console.WriteLine("Wich height is available? (in cm)");
            this.totalHeight=Convert.ToDouble(Console.ReadLine());
            int minNbBoxes=Convert.ToInt32(Math.Floor((this.totalHeight-4)/32));
            int maxNbBoxes = Convert.ToInt32(Math.Floor((this.totalHeight - 4) / 52));
            if (minNbBoxes > 7)
            {
                minNbBoxes = 7;
            }
            if (maxNbBoxes > 7)
            {
                maxNbBoxes = 7;
            }
            
            


            bool ok = false;
            while (ok == false)
            {
                Console.WriteLine("Available width: 32, 42, 52. Select one");
                int width = Convert.ToInt32(Console.ReadLine());
                if (width != 32 || width !=42 || width != 52)
                {
                    Console.WriteLine("Select an available width");
                }
                else
                {
                    ok = true;
                }

            }
            ok = false;
            while (ok == false)
            {
                Console.WriteLine("Available depth: 32, 42, 52. Select one");
                int width = Convert.ToInt32(Console.ReadLine());
                if (width != 32 || width != 42 || width != 52)
                {
                    Console.WriteLine("Select an available depth");
                }
                else
                {
                    ok = true;
                }

            }
            Console.WriteLine("Min boxes amount" + minNbBoxes);
            Console.ReadKey();

            List<string> heightOptions = new List<string>();

            return heightOptions;
        }

    }
}
