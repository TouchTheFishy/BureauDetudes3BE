
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
        List<Options> OptParts = new List<Options>();

        List<string> DbLink = new List<string>(6);
        String[] DbColumn;
        
        public void AddConstructionParts(int height)
        {
            DBConnect database = new DBConnect();
            DbLink.Add("Name");
            DbLink.Add("Height");
            DbLink.Add("Width");
            DbLink.Add("Depth");
            DbLink.Add("Quantity");
            DbLink.Add("OrderId");
            DbColumn = DbLink.ToArray();

            ConstructionParts FrontBackCB = new ConstructionParts() { Width = Convert.ToString(Closet.Width) , Name="Tasseau"};
            ConstructionParts SideCB = new ConstructionParts() { Depth = Convert.ToString(Closet.Depth), Name = "Tasseau" };
            ConstructionParts SideP = new ConstructionParts() { Height = Convert.ToString(height), Depth = Convert.ToString(Closet.Depth), Name = "Panneau" };
            ConstructionParts BackP = new ConstructionParts { Height = Convert.ToString(height), Width = Convert.ToString(Closet.Width), Name = "Panneau" };
            ConstructionParts UpDnP = new ConstructionParts { Depth = Convert.ToString(Closet.Depth), Width = Convert.ToString(Closet.Width), Name = "Panneau" };
            ConstructionParts VertCB = new ConstructionParts { Height = Convert.ToString(Closet.Width), Name = "Tasseau" };

            string[]  request1 = FrontBackCB.AddPart(4);
            string[] request2 = SideCB.AddPart(4);
            string[] request3 = SideP.AddPart(2);
            string[] request4 = BackP.AddPart(1);
            string[] request5 = UpDnP.AddPart(2);
            string[] request6 = VertCB.AddPart(4);

            database.Insert("commandespieces", DbColumn, request1);
            database.Insert("commandespieces", DbColumn, request2);
            database.Insert("commandespieces", DbColumn, request3);
            database.Insert("commandespieces", DbColumn, request4);
            database.Insert("commandespieces", DbColumn, request5);
            database.Insert("commandespieces", DbColumn, request6);


        }
        

        

        
    }
}
