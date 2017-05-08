
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
        private List<KeyValuePair<string, int>> parts = new List<KeyValuePair<string, int>>();
        public List<KeyValuePair<string,int>> Parts
        {
            get
            {
                return parts;
            }
            set
            {
                parts = value;
            }
        }

        List<string> DbLink = new List<string>(6);
        String[] DbColumn;
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

            bool check = false;
            while (check == false)
            {
                //each box has a down, a left, a right and a back pannel, only the last one has an up pannel! 
                ConstructionParts LeftP = new ConstructionParts() { Height = Convert.ToString(height), Depth = Convert.ToString(Closet.Depth), Name = "Panneau GD" };
                ConstructionParts RightP = new ConstructionParts() { Height = Convert.ToString(height), Depth = Convert.ToString(Closet.Depth), Name = "Panneau GD" };
                ConstructionParts BackP = new ConstructionParts { Height = Convert.ToString(height), Width = Convert.ToString(Closet.Width), Name = "Panneau Ar" };
                //ConstructionParts UpP = new ConstructionParts { Depth = Convert.ToString(Closet.Depth), Width = Convert.ToString(Closet.Width), Name = "Panneau HB" };
                ConstructionParts DnP = new ConstructionParts { Depth = Convert.ToString(Closet.Depth), Width = Convert.ToString(Closet.Width), Name = "Panneau HB" };
                
                
                Console.WriteLine("Do you want to customize pannels color? Default color is White for every pannel. Yes/No");
                string answer = Console.ReadLine();
                List<ConstructionParts> pannels = new List<ConstructionParts>() {LeftP,RightP,BackP,DnP };
                List<string> choices = new List<string>() { "Left Pannel", "Right Pannel", "Back Pannel", "Down Pannel" };
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
                    //Add codes for pannels to parts
                    List<KeyValuePair<string, int>> pannelcodes = new List<KeyValuePair<string, int>>() {
                        new KeyValuePair<string, int>(LeftP.Code=LeftP.MakeCode(), 1),
                        new KeyValuePair<string, int>(RightP.Code=RightP.MakeCode(), 1),
                        new KeyValuePair<string, int>(BackP.Code=BackP.MakeCode(), 1),
                        //new KeyValuePair<string, int>(UpP.Code=UpP.MakeCode(), 1),
                        new KeyValuePair<string, int>(DnP.Code=DnP.MakeCode(), 1)
                    };
                    parts.AddRange(pannelcodes);



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
                    //Add codes for pannels to parts
                    List<KeyValuePair<string, int>> pannelcodes = new List<KeyValuePair<string, int>>() {
                        new KeyValuePair<string, int>(LeftP.Code=LeftP.MakeCode(), 1),
                        new KeyValuePair<string, int>(RightP.Code=RightP.MakeCode(), 1),
                        new KeyValuePair<string, int>(BackP.Code=BackP.MakeCode(), 1),
                        //new KeyValuePair<string, int>(UpP.Code=UpP.MakeCode(), 1),
                        new KeyValuePair<string, int>(DnP.Code=DnP.MakeCode(), 1)
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
            }
            //each box has 1 front 1 back and 2 left/right traverses, only the last one has double so many
            ConstructionParts FrontCB = new ConstructionParts() { Width = Convert.ToString(Closet.Width) , Name="Traverse AV", Color=""};
            ConstructionParts BackCB = new ConstructionParts() { Width = Convert.ToString(Closet.Width), Name = "Traverse AR", Color = "" };
            ConstructionParts SideCB = new ConstructionParts() { Depth = Convert.ToString(Closet.Depth), Name = "Traverse GD", Color = "" };
            ConstructionParts VertCB = new ConstructionParts() { Height = Convert.ToString(height-5), Name = "Tasseau", Color = "" };

            //Build codes for tasseaux & traverses
            List<KeyValuePair<string, int>> tasseauxTraverses = new List<KeyValuePair<string, int>>()
            {
                new KeyValuePair<string, int>(FrontCB.Code = FrontCB.MakeCode(),1),
                new KeyValuePair<string, int>(BackCB.Code = BackCB.MakeCode(),1),
                new KeyValuePair<string, int>(SideCB.Code = SideCB.MakeCode(),2),
                new KeyValuePair<string, int>(VertCB.Code = VertCB.MakeCode(),4)
            };
            parts.AddRange(tasseauxTraverses);
            
            string[] request0 = VertCB.AddPart(4);
            string[] request1 = FrontCB.AddPart(1);
            string[] request1bis = BackCB.AddPart(1);
            string[] request2 = SideCB.AddPart(2);
            

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
                    //Black does not exist!!
                    Console.WriteLine("what Color would you like for your doors? Available: White, Brown, Glass");
                    string colordoor = Console.ReadLine();
                    if (colordoor == "White" || colordoor == "Brown" || colordoor == "Glass")
                    {
                        List<KeyValuePair<int, int>> doorwidths = new List<KeyValuePair<int, int>>()
                        {
                            new KeyValuePair<int, int>(62,32),
                            new KeyValuePair<int, int>(80,42),
                            new KeyValuePair<int, int>(100,52),
                            new KeyValuePair<int, int>(120,62)
                        };

                        int doorwidth = 0;
                        foreach (KeyValuePair<int, int> pair in doorwidths)
                        {
                            if (pair.Key == Closet.Width)
                            {
                                doorwidth = pair.Value;
                                break;
                            }
                        }

                        if (colordoor != "Glass")
                        {
                            while (ok == false)
                            {
                                Console.WriteLine("Do you want cups on these doors? Yes/No");
                                answer = Console.ReadLine();
                                //still need to add the door to this.parts (first make keyvaluepair)
                                if (answer == "Yes" || answer == "yes")
                                {
                                    ConstructionParts Door = new ConstructionParts { Color = colordoor, Height = Convert.ToString(height), Width = Convert.ToString(doorwidth), Name = "Porte"};
                                    string[] request = Door.AddDoor();
                                    Door.Code = Door.MakeCode();
                                    KeyValuePair<string, int> doors = new KeyValuePair<string, int>(Door.Code, 2);
                                    parts.Add(doors);
                                    ConstructionParts Cup = new ConstructionParts { Name = "Coupelle", Color = "" };
                                    Cup.Code = Cup.MakeCode();
                                    KeyValuePair<string, int> cups = new KeyValuePair<string, int>(Cup.Code, 2);
                                    parts.Add(cups);
                                    string[]cuprequest = Cup.AddPart(2);
                                    database.Insert("commandespieces", DbColumn, request);
                                    database.Insert("commandespieces", DbColumn, cuprequest);
                                    ok = true;

                                }

                                if (answer == "No" || answer == "no")
                                {
                                    ConstructionParts Door = new ConstructionParts { Color = colordoor, Height = Convert.ToString(height), Width = Convert.ToString(doorwidth), Name = "Porte"};
                                    string[] request = Door.AddDoor();
                                    Door.Code = Door.MakeCode();
                                    KeyValuePair<string, int> doors = new KeyValuePair<string, int>(Door.Code, 2);
                                    parts.Add(doors);
                                    database.Insert("commandespieces", DbColumn, request);
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
                            ConstructionParts Door = new ConstructionParts { Color = colordoor, Height = Convert.ToString(height), Width = Convert.ToString(doorwidth), Name = "Porte", Cup = "No" };
                            string[] request = Door.AddDoor();
                            Door.Code = Door.MakeCode();
                            KeyValuePair<string, int> doors = new KeyValuePair<string, int>(Door.Code, 2);
                            parts.Add(doors);
                            database.Insert("commandespieces", DbColumn, request);
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
