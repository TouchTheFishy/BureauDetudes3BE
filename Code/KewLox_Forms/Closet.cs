﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KewLox_Forms
{
    public class Closet
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
        public void setDims(int width, int depth, int totalHeight, int boxamount)
        {
            Width = width;
            Depth = depth;
            TotalHeight = totalHeight;
            Boxamount = boxamount;
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

                //Remove the amount taken in db "stock" and update "sold"
                for (int j = 0; j < pannelcodes.Count; j++)
                {
                    database.Sold("sold", pannelcodes[j].Key, pannelcodes[j].Value);
                }
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
                //Remove the amount taken in db "stock" and update "sold"
                for (int j = 0; j < pannelcodes.Count; j++)
                {
                    database.Sold("sold", pannelcodes[j].Key, pannelcodes[j].Value);
                }

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

            //Remove the amount taken in db "stock" and update "sold"
            for (int j = 0; j < tasseauxTraverses.Count; j++)
            {
                database.Sold("sold", tasseauxTraverses[j].Key, tasseauxTraverses[j].Value);
            }

            string[] request1 = FrontCB.AddPart(1);
            string[] request1bis = BackCB.AddPart(1);
            string[] request2 = SideCB.AddPart(2);


             database.Insert("commandespieces", DbColumn, request1);
            database.Insert("commandespieces", DbColumn, request1bis);
            database.Insert("commandespieces", DbColumn, request2);


        }

        public decimal GetPrice()
        {
            DBConnect database = new DBConnect();
            decimal total = 0;
            foreach (KeyValuePair<string, int> part in this.Parts)
            {
                string[,] prix = database.Select("`Prix-Client`", "stock", "`Code`='" + part.Key + "'");
                decimal priceperpart = Convert.ToDecimal(prix[0, 1]);
                decimal nbparts = Convert.ToDecimal(part.Value);
                total += (priceperpart * nbparts);
            }
            return total;
        }

        public void MakeBill(Closet closet, long CommandID)
        {
            string text="";
            string header = "";
            string kewloxaddress="<table id='addresses'><tr><td>Kewlox SPRL<br>Rue et Numéro de maison<br>Code Postal et Commune<br>Telephone<br>Email<br>VAT<br>Account number & BIC</td>";
            string companyaddress="<td>Client name <br> Client address & number <br> Post Code & town<br>Telephone<br>Email address <br>VAT number <br> Account number & BIC</td>";
            string bodyheader;
            string body = "";
            string bodyfooter;
            string footer = "\u00a9 Kewlox 2017"; //alt 0169 release alt 
            DBConnect database = new DBConnect();
            header = String.Format("<html>\n<head>\n<style>table, th, td {{{0}}},table, td.addresses{{{1}}}</style>\n</head>\n<body>\n<h1>Bill " +
                "n°{2}</h1>\n<h2>Kewlox thanks you for your purchase.</h2>\n</body>", "border:1px solid black;\nborder-collapse:" +
                "collapse;","border:no-border",Convert.ToString(Program.Id));
            bodyheader = "<table>\n<tr>\n<th>Part Name</th>\n<th>Description</th>\n<th>Amount</th>\n<th>Price per part</th>\n<th>Total</th>\n</tr>";
            bodyfooter = String.Format("<td><b>Total</b></td>\n<td></td>\n<td></td>\n<td></td>\n<td>{0}</td>\n</table>", closet.GetPrice());
            string path = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()))+String.Format("/Bills/bill{0}.html",Convert.ToString(Program.Id));
            text = header +kewloxaddress+companyaddress+ bodyheader;
            File.AppendAllText(path, text);
            List<KeyValuePair<string, int>> nodup = RemoveDuplicates(closet.Parts);
            foreach (KeyValuePair<string, int> part in nodup)
            {
                string[,] price = database.Select("`Prix-Client`,`Ref`,`Dimensions(cm)`,`Couleur`", "stock", "`Code`='" + part.Key + "'");
                string description = String.Join(" ", price[1, 1], price[2, 1], price[3, 1]);
                body = String.Format("<tr>\n<td>{0}</td>\n<td>{1}</td>\n<td>{2}</td>\n", part.Key, description, part.Value);
                body += String.Format("<td>{0}</td>\n<td>{1}</td>\n</tr>\n", price[0, 1], (Convert.ToDecimal(price[0, 1]) * Convert.ToInt32(part.Value)).ToString());
                File.AppendAllText(path, body);
            }
            //byte[] toBytes = Encoring.ASCII.GetBytes(somestring);
            //System.IO.File.WriteAllBytes("hello.pdf", fileContent);
            File.AppendAllText(path,bodyfooter+footer);
        }

        //Method to remove duplicate names from the list of parts, changes the number of parts from one pair and deletes the other one
        private List<KeyValuePair<string,int>> RemoveDuplicates(List<KeyValuePair<string,int>> parts) //make private
        {
            List<string> keys = new List<string>();
            List<int> values = new List<int>();
            int duplicate = 0;
            List<KeyValuePair<string, int>> nodupparts = new List<KeyValuePair<string,int>>();
            foreach (KeyValuePair<string,int> pair in parts)
            {
                keys.Add(pair.Key);
                values.Add(pair.Value);
            }
            int i = 0;
            while (i<keys.Count-1)
            {
                while (keys.IndexOf(keys[i], i + 1) > i && keys.IndexOf(keys[i], i + 1) <= keys.Count)
                {
                    duplicate = keys.IndexOf(keys[i], i + 1);
                    values[i] += values[duplicate];
                    keys.RemoveAt(duplicate);
                    values.RemoveAt(duplicate);
                }
                i++;
            }
            for (int j = 0; j< keys.Count;j++)
            {
                nodupparts.Add(new KeyValuePair<string, int>(keys[j],values[j]));
            }
            foreach (KeyValuePair<string,int> pair in nodupparts)
            {
                Console.WriteLine(pair.Key + " " + pair.Value);
            }
            return nodupparts;
        }

    }
}
