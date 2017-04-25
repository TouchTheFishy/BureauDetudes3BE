
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KewLox.DBConnect;

namespace KewLox
{
    class Box
    {
        List<KeyValuePair<ConstructionParts,int>> Parts = new List<KeyValuePair<ConstructionParts, int>>();

        List<string> DbLink = new List<string>(6);
        String[] DbColumn;
        String[] DbWColor;
        String[] DbWDoor;

        public void AddConstructionParts(int boxheight)
        {
            int height = boxheight - 4;
            DBConnect database = new DBConnect();
            DbLink.Add("Name");
            DbLink.Add("Height");
            DbLink.Add("Depth");
            DbLink.Add("Width");
            DbLink.Add("Quantity");
            DbLink.Add("OrderId");
            DbLink.Add("Color");
            DbColumn = DbLink.ToArray();
            DbLink.Add("Cup");
            DbWDoor = DbLink.ToArray();

            bool check = false;
            while (check == false)
            {
                ConstructionParts LeftP = new ConstructionParts() { Height = Convert.ToString(height), Depth = Convert.ToString(Closet.Depth), Name = "Panneau GD" };
                ConstructionParts RightP = new ConstructionParts() { Height = Convert.ToString(height), Depth = Convert.ToString(Closet.Depth), Name = "Panneau GD" };
                ConstructionParts BackP = new ConstructionParts { Height = Convert.ToString(height), Width = Convert.ToString(Closet.Width), Name = "Panneau Ar" };
                ConstructionParts UpP = new ConstructionParts { Depth = Convert.ToString(Closet.Depth), Width = Convert.ToString(Closet.Width), Name = "Panneau HB" };
                ConstructionParts DnP = new ConstructionParts { Depth = Convert.ToString(Closet.Depth), Width = Convert.ToString(Closet.Width), Name = "Panneau HB" };

                Console.WriteLine("Do you want to customize pannels color? Default color is White for every pannel. Yes/No");
                string answer = Console.ReadLine();
                List<ConstructionParts> pannels = new List<ConstructionParts>() {LeftP,RightP,BackP,UpP,DnP };
                List<string> choices = new List<string>() { "Left Pannel", "Right Pannel", "Back Pannel", "Up Pannel", "Down Pannel" };
                if (answer == "Yes" || answer == "yes")
                {
                    int i = 0;
                    foreach (ConstructionParts component in pannels)
                    {
                        check = false;
                        while (check == false)
                        {
                            
                            Console.WriteLine("Which color for the " + choices[i]+" Brown or White?");
                            string color = Console.ReadLine();
                            if (color == "Brown" || color == "White")
                            {
                                component.Color = color;
                                string[] request = component.AddPart(1);
                                database.Insert("commandespieces", DbColumn, request);
                                check = true;
                            }
                            else
                            {
                                Console.WriteLine("Please select an available color");
                            }
                        }
                        i += 1;

                    }

                    

                }
                if (answer == "No" || answer == "no")
                {
                    foreach (ConstructionParts component in pannels)
                    {
                        check = false;
                        while (check == false)
                        {
                            component.Color = "White";
                            string[] request = component.AddPart(1);
                            database.Insert("commandespieces", DbColumn, request);
                            check = true;
                        }
                    }
                }
                else
                {
                    if (check == false)
                    {
                        Console.WriteLine("Please answer Yes Or No");
                    }
                }
            }

            ConstructionParts FrontCB = new ConstructionParts() { Width = Convert.ToString(Closet.Width) , Name="Traverse", Color=""};
            ConstructionParts BackCB = new ConstructionParts() { Width = Convert.ToString(Closet.Width), Name = "Traverse", Color = "" };
            ConstructionParts SideCB = new ConstructionParts() { Depth = Convert.ToString(Closet.Depth), Name = "Traverse", Color = "" };
            ConstructionParts VertCB = new ConstructionParts() { Height = Convert.ToString(height), Name = "Tasseau", Color = "" };

            string[] request0 = VertCB.AddPart(4);
            string[] request1 = FrontCB.AddPart(2);
            string[] request1bis = BackCB.AddPart(2);
            string[] request2 = SideCB.AddPart(4);
            

            database.Insert("commandespieces", DbColumn, request0);
            database.Insert("commandespieces", DbColumn, request1);
            database.Insert("commandespieces", DbColumn, request1bis);
            database.Insert("commandespieces", DbColumn, request2);
            


            bool ok = false;
            while (ok == false && Closet.Width>60)
            {
                Console.WriteLine("Do you want doors? Yes/No");
                string answer = Console.ReadLine();
                if (answer == "Yes" || answer == "yes")
                {
                    Console.WriteLine("what Color would you like for your doors? Available: White, Black, Brown, Glass");
                    string colordoor = Console.ReadLine();
                    if (colordoor == "Black" || colordoor == "White" || colordoor == "Brown" || colordoor == "Glass")
                    {
                        if (colordoor != "Glass")
                        {
                            while (ok == false)
                            {
                                Console.WriteLine("Do you want cups on these doors? Yes/No");
                                answer = Console.ReadLine();
                                string color = "white";

                                if (answer == "Yes" || answer == "yes")
                                {


                                    ConstructionParts Door = new ConstructionParts { Color = colordoor, Height = Convert.ToString(height), Width = Convert.ToString(Closet.Width / 2), Name = "Porte", Cup = "Yes" };
                                    string[] request = Door.AddDoor();
                                    database.Insert("commandespieces", DbWDoor, request);
                                    ok = true;

                                }

                                if (answer == "No" || answer == "no")
                                {
                                    ConstructionParts Door = new ConstructionParts { Color = colordoor, Height = Convert.ToString(height), Width = Convert.ToString(Closet.Width / 2), Name = "Porte", Cup = "No" };
                                    string[] request = Door.AddDoor();
                                    database.Insert("commandespieces", DbWDoor, request);
                                    ok = true;
                                }
                                else
                                {
                                    if (ok == false)
                                    {
                                        Console.WriteLine("Please answer Yes or No");
                                    }
                                }
                            }
                        }
                        else
                        {
                            ConstructionParts Door = new ConstructionParts { Color = colordoor, Height = Convert.ToString(height), Width = Convert.ToString(Closet.Width / 2), Name = "Porte", Cup = "No" };
                            string[] request = Door.AddDoor();
                            database.Insert("commandespieces", DbWDoor, request);
                            ok = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong input");
                    }
                }
                if (answer == "No" || answer == "no")
                {
                    ok = true;
                }
                else
                {
                    if (ok == false)
                    {
                        Console.WriteLine("Please answer Yes Or No");
                    }
                }
            }

        }
        

        

        
    }
}
