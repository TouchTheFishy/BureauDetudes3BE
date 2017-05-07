using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KewLox
{
    class Closet
    {
        private static List<KeyValuePair<string,int>> parts = new List<KeyValuePair<string, int>>();

        public List<KeyValuePair<string,int>> Parts
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
            MaxNbBoxes=Convert.ToInt32(Math.Floor(Convert.ToDouble((totalHeight-4)/36)));
            MinNbBoxes = Convert.ToInt32(Math.Floor(Convert.ToDouble((totalHeight - 4) / 56)));
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
            
        }
        public void AddBoxes()
        {
            bool ok = false;
            while (ok == false)
            {
                Console.WriteLine("How many boxes would you like? (Max " + MaxNbBoxes + " boxes)");
                int boxamount = Convert.ToInt32(Console.ReadLine());
                if (boxamount >= 1 && boxamount <= MaxNbBoxes)
                {

                    Boxamount = boxamount;
                    ok = true;
                }
                else
                {
                    Console.WriteLine("Select an available amount");
                }
            }
            int i = 0;
            //if boxamount*56 (max height of the closet) < total height: return boxamount*56
            //else: return totalHeight
            int maxheight = boxamount * 56 < totalHeight ? boxamount * 56 : totalHeight;
            while (i < boxamount)
            {

                int max = maxheight - actualHeight;
                if (max > 56 * (boxamount - i))
                {
                    max = 56 * (boxamount - i);
                }
                Console.WriteLine("Which height for box number " + i + "? (maximum " + max + "cm and" + (boxamount - i) + " boxes left)");
                ok = false;
                while (ok == false)
                {
                    //les boites font en fait 32/42/52 de haut + 2 pour chaque traverse horizontale
                    Console.WriteLine("Available heights: 36, 46, 56. Select one");
                    int height = Convert.ToInt32(Console.ReadLine());
                    if ((height == 36 || height == 46 || height == 56) && (ActualHeight + height + 36 * (boxamount - i - 1) <= TotalHeight))
                    {
                        Box box = new Box();
                        box.AddConstructionParts(height);
                        foreach (KeyValuePair<string, int> boxpart in box.Parts)
                        {
                            parts.Add(boxpart);
                        }
                        ActualHeight = ActualHeight + height;
                        ok = true;
                    }
                    else
                    {
                        Console.WriteLine("Select an available height");
                    }

                }
                i += 1;

            }
            // All boxes have been added
            //Ajout des cornières et du panneau et des traverses du dessus à la fin de la commande
            DBConnect database = new DBConnect();
            ok = false;
            // add corners
            string answer;
            while (ok == false)
            {
                Console.WriteLine("what Color would you like for your angles? Available: White, Black, Brown, Chromed");
                answer = Console.ReadLine();
                if (answer == "Black" || answer == "White" || answer == "Brown" || answer == "Chromed")
                {
                    ConstructionParts angles = new ConstructionParts() { Name = "Cornière", Height = Convert.ToString(ActualHeight), Color = answer };
                    angles.Code = angles.MakeCode();
                    KeyValuePair<string, int> anglesparts = new KeyValuePair<string, int>(angles.Code, 4);
                    parts.Add(anglesparts);
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
            //Add the up panel in the end
            ConstructionParts UpP = new ConstructionParts { Depth = Convert.ToString(Closet.Depth), Width = Convert.ToString(Closet.Width), Name = "Panneau HB" };
            Console.WriteLine("Do you want to customize the up pannel color? Default color is White for every pannel. Yes/No");
            answer = Console.ReadLine();
            List<string> DbLink = new List<string>(6);
            String[] DbColumn;
            DbLink.Add("Name");
            DbLink.Add("Height");
            DbLink.Add("Depth");
            DbLink.Add("Width");
            DbLink.Add("Quantity");
            DbLink.Add("OrderId");
            DbLink.Add("Color");
            DbColumn = DbLink.ToArray();
            bool check = false;
            if (answer == "Yes" || answer == "yes")
            {
                while (check == false)
                {

                    Console.WriteLine("Which color for the Up Pannel Brown or White?");
                    string color = Console.ReadLine();
                    if (color == "Brown" || color == "White")
                    {
                        UpP.Color = color;
                        string[] request = UpP.AddPart(1);
                        database.Insert("commandespieces", DbColumn, request);
                        check = true;
                    }
                    else
                    {
                        Console.WriteLine("Please select an available color");
                    }
                }
                //Add codes for pannels to parts
                List<KeyValuePair<string, int>> pannelcodes = new List<KeyValuePair<string, int>>() {
                new KeyValuePair<string, int>(UpP.Code=UpP.MakeCode(), 1),
                };
                parts.AddRange(pannelcodes);

            }
            check = false;

            if (answer == "No" || answer == "no")
            {

                UpP.Color = "White";
                string[] request = UpP.AddPart(1);
                database.Insert("commandespieces", DbColumn, request);
                check = true;
                //Add codes for pannels to parts
                List<KeyValuePair<string, int>> pannelcodes = new List<KeyValuePair<string, int>>() {
                new KeyValuePair<string, int>(UpP.Code=UpP.MakeCode(), 1),
                };
                parts.AddRange(pannelcodes);

            }
            else
            {
                if (check == false)
                {
                    Console.WriteLine("Please answer Yes Or No");
                }
            }

            //add the traverses for the last box (up pannel)
            ConstructionParts FrontCB = new ConstructionParts() { Width = Convert.ToString(Closet.Width), Name = "Traverse AV", Color = "" };
            ConstructionParts BackCB = new ConstructionParts() { Width = Convert.ToString(Closet.Width), Name = "Traverse AR", Color = "" };
            ConstructionParts SideCB = new ConstructionParts() { Depth = Convert.ToString(Closet.Depth), Name = "Traverse GD", Color = "" };

            //Build codes for tasseaux & traverses
            List<KeyValuePair<string, int>> tasseauxTraverses = new List<KeyValuePair<string, int>>()
            {
                new KeyValuePair<string, int>(FrontCB.Code = FrontCB.MakeCode(),1),
                new KeyValuePair<string, int>(BackCB.Code = BackCB.MakeCode(),1),
                new KeyValuePair<string, int>(SideCB.Code = SideCB.MakeCode(),2),
            };
            parts.AddRange(tasseauxTraverses);

            string[] request1 = FrontCB.AddPart(1);
            string[] request1bis = BackCB.AddPart(1);
            string[] request2 = SideCB.AddPart(2);


            database.Insert("commandespieces", DbColumn, request1);
            database.Insert("commandespieces", DbColumn, request1bis);
            database.Insert("commandespieces", DbColumn, request2);


        }

    }
}
