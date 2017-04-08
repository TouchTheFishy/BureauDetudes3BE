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
            
            Console.WriteLine("Ground dimensions: " + Width + 'x' + Depth);
            
        }
        public void AddBoxes()
        {
            
            bool ok = false;
            while (ok == false)
            {
                Console.WriteLine("How many boxes would you like? (Max "+MaxNbBoxes+" boxes)");
                int boxamount = Convert.ToInt32(Console.ReadLine());
                if (boxamount>=1 && boxamount<=MaxNbBoxes )
                {
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

                Console.WriteLine("Which height for this box? "+i+" boxes (maximum " + ((Boxamount*52) - ActualHeight)+"cm left m)");
                ok = false;
                while (ok == false)
                {
                    Console.WriteLine("Available heights: 32, 42, 52. Select one");
                    int height = Convert.ToInt32(Console.ReadLine());
                    if (height == 32 || height == 42 || height == 52 && (ActualHeight+height)<=TotalHeight)
                    {
                        Box box = new Box();
                        box.AddConstructionParts(height);
                        ActualHeight = ActualHeight + height;
                        
                        ok = true;
                    }
                    else
                    {
                        Console.WriteLine("Select an available depth");
                    }

                }
                i += 1;

                //Ajout des cornières à la fin de la commande (hauteur = hauteur de toutes les boites +4)
                DBConnect database = new DBConnect();
                ConstructionParts angles= new ConstructionParts() { Name="Angles", Height=Convert.ToString(ActualHeight+4)};
                string[] query = new string[6] { "Name", "Height", "Depth", "Width", "Quantity", "OrderId" };
                string[] data = angles.AddPart(4);
                database.Insert("commandespieces", query, data);

                

            }

        }
        
    }
}
