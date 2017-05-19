
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KewLox_Forms.DBConnect;

namespace KewLox_Forms
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

        public void AddConstructionParts(int boxheight, string lcol, string rcol, string bcol, string dcol, string doorcol, string doormat, int width, int depth)
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

            
            //each box has a down, a left, a right and a back pannel, only the last one has an up pannel! 
            ConstructionParts LeftP = new ConstructionParts() { Height = Convert.ToString(height), Depth = Convert.ToString(depth), Name = "Panneau GD",Color = rcol };
            ConstructionParts RightP = new ConstructionParts() { Height = Convert.ToString(height), Depth = Convert.ToString(depth), Name = "Panneau GD", Color = lcol };
            ConstructionParts BackP = new ConstructionParts { Height = Convert.ToString(height), Width = Convert.ToString(width), Name = "Panneau Ar", Color = bcol };
            //ConstructionParts UpP = new ConstructionParts { Depth = Convert.ToString(Closet.Depth), Width = Convert.ToString(Closet.Width), Name = "Panneau HB" };
            ConstructionParts DnP = new ConstructionParts { Depth = Convert.ToString(depth), Width = Convert.ToString(width), Name = "Panneau HB", Color=dcol};
            
            
            List<ConstructionParts> pannels = new List<ConstructionParts>() {LeftP,RightP,BackP,DnP };
            List<string> choices = new List<string>() { "Left Pannel", "Right Pannel", "Back Pannel", "Down Pannel" };
                
                foreach (ConstructionParts component in pannels)
                {
                    string[] request = component.AddPart(1);
                    database.Insert("commandespieces", DbColumn, request);
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

            //Remove the amount taken in db "stock" and update "sold"
            for (int j = 0; j < pannelcodes.Count; j++)
            {
                database.Sold("sold", pannelcodes[j].Key, pannelcodes[j].Value);
            }
            
            
            //each box has 1 front 1 back and 2 left/right traverses, only the last one has double so many
            ConstructionParts FrontCB = new ConstructionParts() { Width = Convert.ToString(width) , Name="Traverse AV", Color=""};
            ConstructionParts BackCB = new ConstructionParts() { Width = Convert.ToString(width), Name = "Traverse AR", Color = "" };
            ConstructionParts SideCB = new ConstructionParts() { Depth = Convert.ToString(depth), Name = "Traverse GD", Color = "" };
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

            //Remove the amount taken in db "stock" and update "sold"
            for (int i = 0; i < tasseauxTraverses.Count; i++)
            {
                database.Sold("sold", tasseauxTraverses[i].Key, tasseauxTraverses[i].Value);
            }

            
            if (width>60)
            {
                
                if (doormat !="None")
                {   
                    
                    if (doormat != "Glass")
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
                        if (pair.Key == width)
                        {
                            doorwidth = pair.Value;
                            break;
                        }
                    }



                    //still need to add the door to this.parts (first make keyvaluepair)
                    if (doormat == "Cup")
                        {
                            ConstructionParts Door = new ConstructionParts { Color = doorcol, Height = Convert.ToString(height), Width = Convert.ToString(doorwidth), Name = "Porte"};
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

                            //Remove the amount taken in db "stock" and update "sold"
                            database.Sold("sold", doors.Key, doors.Value);
                            database.Sold("sold", cups.Key, cups.Value);

                        }

                        if (doormat=="Nocup")
                        {
                            ConstructionParts Door = new ConstructionParts { Color = doorcol, Height = Convert.ToString(height), Width = Convert.ToString(doorwidth), Name = "Porte"};
                            string[] request = Door.AddDoor();
                            Door.Code = Door.MakeCode();
                            KeyValuePair<string, int> doors = new KeyValuePair<string, int>(Door.Code, 2);
                            parts.Add(doors);
                            database.Insert("commandespieces", DbColumn, request);
                        
                            //Remove the amount taken in db "stock" and update "sold"
                            database.Sold("sold", doors.Key, doors.Value);

                        }
                        
                    }
                    else
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
                            if (pair.Key == width)
                            {
                                doorwidth = pair.Value;
                                break;
                            }
                        }
                        ConstructionParts Door = new ConstructionParts { Color = doormat, Height = Convert.ToString(height), Width = Convert.ToString(doorwidth), Name = "Porte", Cup = "No" };
                        string[] request = Door.AddDoor();
                        Door.Code = Door.MakeCode();
                        KeyValuePair<string, int> doors = new KeyValuePair<string, int>(Door.Code, 2);
                        parts.Add(doors);
                        database.Insert("commandespieces", DbColumn, request);

                        //Remove the amount taken in db "stock" and update "sold"
                        database.Sold("sold", doors.Key, doors.Value);

                    }
                }
            }
        }
    } 
}

