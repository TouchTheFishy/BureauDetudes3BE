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
        public List<int> CalculateHeightOptions()

        {
            Console.WriteLine("Wich height is available? (in cm)");
            totalHeight=Convert.ToInt32(Console.ReadLine());
            TotalHeight = totalHeight;
            MaxNbBoxes=Convert.ToInt32(Math.Floor(Convert.ToDouble((totalHeight-4)/32)));
            MinNbBoxes = Convert.ToInt32(Math.Floor(Convert.ToDouble((totalHeight - 4) / 52)));
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
                Console.WriteLine("Available width: 32, 42, 52, 62, 80, 100, 120. Select one");

                width = Convert.ToInt32(Console.ReadLine());
                if (width == 32 || width ==42 || width == 52 || width == 62 || width == 80 || width == 100 || width == 120)
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
                Console.WriteLine("Available depths: 32, 42, 52, 62. Select one");
                depth = Convert.ToInt32(Console.ReadLine());
                if (depth == 32 || depth == 42 || depth== 52 || depth==62)
                {
                    Depth = depth;
                    ok = true;
                }
                else
                {
                    Console.WriteLine("Select an available depth");
                }

            }
            
            Console.WriteLine("Ground dimensions: " + Width + 'x' + Depth);
            List<int> values = new List<int>();
            values.Add(MinNbBoxes);
            values.Add(MaxNbBoxes);
            values.Add(Width);
            values.Add(Depth);
            values.Add(TotalHeight);
            return values;
        }
<<<<<<< HEAD
        public List<KeyValuePair<int, List<KeyValuePair<ConstructionParts, int>>>> AddBoxes(List<int> values)
=======
        public void AddBoxes()
>>>>>>> 9c87ea15414078ab2f4f9922c6d74d2576c03ff8
        {
            MinNbBoxes = values[0];
            MaxNbBoxes = values[1];
            TotalHeight = values[4];
            bool ok = false;
            while (ok == false)
            {
                Console.WriteLine("How many boxes would you like? (Max "+MaxNbBoxes+" boxes)");
                int boxamount = Convert.ToInt32(Console.ReadLine());
                if (boxamount>=1 && boxamount<=MaxNbBoxes )
                {
<<<<<<< HEAD
                    Console.WriteLine("Select an available amount");
                }
                else
                {
                    Boxamount = boxamount;
                    ok = true;
                }
            }
            int i = 0;
            List<KeyValuePair<int,List<KeyValuePair<ConstructionParts, int>>>> PartsPerBox = new List<KeyValuePair<int, List<KeyValuePair<ConstructionParts, int>>>>();
            while (i < Boxamount)
            {
                Console.WriteLine("Which height for this box? Height remaining : " + (TotalHeight - ActualHeight));
=======
                    Boxamount = boxamount;
                    ok = true;
                    

                }
                else
                {
                    Console.WriteLine("Select a available amount");

                }
            }
            int i = 0;
            while (i < Boxamount)
            {

                Console.WriteLine("Which height for box number "+i+"? (maximum " + ((Boxamount*56) - ActualHeight)+"cm and"+ (boxamount-i) +" boxes left)");
>>>>>>> 9c87ea15414078ab2f4f9922c6d74d2576c03ff8
                ok = false;
                while (ok == false)
                {
                    //les boites font en fait 32/42/52 de haut + 2 pour chaque traverse horizontale
                    Console.WriteLine("Available heights: 36, 46, 56. Select one");
                    int height = Convert.ToInt32(Console.ReadLine());
                    if (height == 36 || height == 46 || height == 56 && (ActualHeight+height)<=TotalHeight)
                    {
                        Box box = new Box();
<<<<<<< HEAD
                        PartsPerBox.Add(new KeyValuePair<int, List<KeyValuePair<ConstructionParts, int>>>(i,box.AddConstructionParts(height)));
                        ActualHeight += height;
=======
                        box.AddConstructionParts(height);
                        ActualHeight = ActualHeight + height;
                        
>>>>>>> 9c87ea15414078ab2f4f9922c6d74d2576c03ff8
                        ok = true;
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Select an available height");
                    }

                }
                i += 1;
                
            }
            //Ajout des cornières à la fin de la commande 
            DBConnect database = new DBConnect();
            ok = false;
            while (ok == false)
            {
                Console.WriteLine("what Color would you like for your angles? Available: White, Black, Brown, Chromed");
                string answer = Console.ReadLine();
                if (answer == "Black" || answer == "White" || answer == "Brown" || answer == "Chromed")
                {
                    ConstructionParts angles = new ConstructionParts() { Name = "Angles", Height = Convert.ToString(ActualHeight), Color = answer };
                    string[] query = new string[7] { "Name", "Height", "Depth", "Width", "Quantity", "OrderId", "Color" };
                    string[] data = angles.AddPart(4);
                    database.Insert("commandespieces", query, data);
                    ok = true;
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }

        }
        
    }
}
