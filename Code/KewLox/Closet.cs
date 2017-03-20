using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KewLox
{
    

    class Closet
    {
        private static List<ConstructionParts> parts;

        public static List<ConstructionParts> Parts
        {
            get { return parts; }
            set { parts = value; }

        }

        private static int width;

        public static int Width
        {
            get { return width; }
            set { width = value; }

        }
        public static int maxNbBoxes;
        public static int MaxNbBoxes
        {
            get { return maxNbBoxes; }
            set { maxNbBoxes = value; }

        }
        public static int minNbBoxes;
        public static int MinNbBoxes
        {
            get { return minNbBoxes; }
            set { minNbBoxes = value; }

        }
        public static int boxamount;
        public static int Boxamount
        {
            get { return boxamount; }
            set { boxamount= value; }

        }
        private static int depth;

        public static int Depth
        {
            get { return depth; }
            set { depth = value; }

        }
        private static int totalHeight;
        public static int TotalHeight
        {
            get { return totalHeight; }
            set { depth = value; }

        }
        private static int actualHeight=0;
        public static int ActualHeight
        {
            get { return actualHeight; }
            set { actualHeight = value; }

        }
        public void CalculateHeightOptions()

        {
            Console.WriteLine("Wich height is available? (in cm)");
            totalHeight=Convert.ToInt32(Console.ReadLine());
            TotalHeight = totalHeight;
            int MaxNbBoxes=Convert.ToInt32(Math.Floor(Convert.ToDouble((totalHeight-4)/32)));
            int MinNbBoxes = Convert.ToInt32(Math.Floor(Convert.ToDouble((totalHeight - 4) / 52)));
            if (MinNbBoxes > 7)
            {
                MinNbBoxes = 7;
            }
            if (MaxNbBoxes > 7)
            {
                MaxNbBoxes = 7;
            }


            bool ok = false;
            while (ok == false)
            {
                Console.WriteLine("Available width: 32, 42, 52. Select one");

                width = Convert.ToInt32(Console.ReadLine());
                if (width == 32 || width ==42 || width == 52)
                {
                    Width = width;
                    ok = true;
                }
                else
                {
                    Console.WriteLine("Select an available width");
                }

            }
            ok = false;
            while (ok == false)
            {
                Console.WriteLine("Available depth: 32, 42, 52. Select one");
                depth = Convert.ToInt32(Console.ReadLine());
                if (depth == 32 || depth == 42 || depth== 52)
                {
                    Depth = depth;
                    ok = true;
                }
                else
                {
                    Console.WriteLine("Select an available depth");
                }

            }
            Console.WriteLine("Min boxes amount = " + MinNbBoxes);
            Console.WriteLine("Max boxes amount = " + MaxNbBoxes);
            Console.WriteLine("Ground dimensions: " + Width + 'x' + Depth);
            
        }
        public List<KeyValuePair<int, List<KeyValuePair<ConstructionParts, int>>>> AddBoxes()
        {
            
            bool ok = false;
            while (ok == false)
            {
                Console.WriteLine("How many boxes would you like?");
                int boxamount = Convert.ToInt32(Console.ReadLine());
                if (boxamount > MaxNbBoxes || boxamount < MinNbBoxes)
                {
                    Console.WriteLine("Select a available amount");

                }
                else
                {
                    Boxamount = boxamount;
                    ok = true;

                }
            }
            int i = 1;
            List<KeyValuePair<int,List<KeyValuePair<ConstructionParts, int>>>> PartsPerBox = new List<KeyValuePair<int, List<KeyValuePair<ConstructionParts, int>>>>();
            while (i < Boxamount)
            {
                Console.WriteLine("Whcih height for this box? Height remaining : " + (TotalHeight - ActualHeight));
                ok = false;
                while (ok == false)
                {
                    Console.WriteLine("Available heights: 32, 42, 52. Select one");
                    int height = Convert.ToInt32(Console.ReadLine());
                    if (height == 32 || height == 42 || height == 52 && (ActualHeight+height)<=TotalHeight)
                    {
                        Box box = new Box();
                        PartsPerBox.Add(new KeyValuePair<int, List<KeyValuePair<ConstructionParts, int>>>(i,box.AddConstructionParts(height)));
                        
                        ok = true;
                    }
                    else
                    {
                        Console.WriteLine("Select an available depth");
                    }

                }
                

            }
            return PartsPerBox;

        }
        public List<KeyValuePair<ConstructionParts, int>> CalculateTotalParts(List<KeyValuePair<int, List<KeyValuePair<ConstructionParts, int>>>> partsperbox)
        {
            List<KeyValuePair<ConstructionParts, int>> TotalParts = new List<KeyValuePair<ConstructionParts, int>>();
            foreach (KeyValuePair<int, List<KeyValuePair<ConstructionParts, int>>> box in partsperbox)
            {

            }
        }
    }
}
