
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KewLox.Program.DBConnect;

namespace KewLox
{
    class Box
    {
        List<KeyValuePair<ConstructionParts,int>> Parts = new List<KeyValuePair<ConstructionParts, int>>();
        List<Options> OptParts = new List<Options>();

        List<string> DbLink = new List<string>(6);
        
        public List<KeyValuePair<ConstructionParts, int>> AddConstructionParts(int height)
        {

            DbLink.Add("NameObject");
            DbLink.Add("Quantity");
            DbLink.Add("Height");
            DbLink.Add("Depth");
            DbLink.Add("Width");
            DbLink.Add("Color");
            string DbColumn = DbLink[0] + ", " + DbLink[1] + ", " + DbLink[2] + ", " + DbLink[3] + ", " + DbLink[4] + ", " + DbLink[5];

            Parts.Add(new KeyValuePair<ConstructionParts, int>(new Crossbars() {Dim = Closet.Width },2)); // Front crossbar (traverse avant) x2?
            Parts.Add(new KeyValuePair<ConstructionParts, int>(new Crossbars() { Dim = Closet.Width }, 2)); // Back crossbar (traverse arrière) x2?
            Parts.Add(new KeyValuePair<ConstructionParts, int>(new Crossbars() { Dim = Closet.Depth }, 4)); // Lateral crossbar x4?
            Parts.Add(new KeyValuePair<ConstructionParts, int>(new Pannel() { Height = height, Width = Closet.Depth },2)); // Lateral Pannel x2?
            Parts.Add(new KeyValuePair<ConstructionParts, int>(new Pannel() { Height = height, Width = Closet.Width }, 1)); // Back pannel
            Parts.Add(new KeyValuePair<ConstructionParts, int>(new Pannel() { Height = Closet.Depth, Width = Closet.Width }, 2)); // Up/Down pannel x2?
            Parts.Add(new KeyValuePair<ConstructionParts, int>(new Bracket() { Dim = height }, 4)); // Bracket (tasseaux verticaux) x4?

            // Add all this to the database.
            Program.DBConnect.Insert(iduser, DbColumn, "Front Crossbar" + ", " + "2" + ", " + Closet.Width + ", " + "0" + ", " + "0" + ", " + "none");
            DBConnection.Insert(iduser, DbColumn, "Back Crossbar" + ", " + "2" + ", " + Closet.Width + ", " + "0" + ", " + "0" + ", " + "none");
            DBConnection.Insert(iduser, DbColumn, "Lateral Crossbar" + ", " + "4" + ", " + Closet.Depth + ", " + "0" + ", " + "0" + ", " + "none");
            DBConnection.Insert(iduser, DbColumn, "Lateral Pannel" + ", " + "2" + ", " + height + ", " + Closet.Depth + ", " + "0" + ", " + Pannel.Color); 
            DBConnection.Insert(iduser, DbColumn, "Back Pannel" + ", " + "1" + ", " + height + ", " + Closet.Width + ", " + "0" + ", " + "none");
            DBConnection.Insert(iduser, DbColumn, "Up/Down Pannel" + ", " + "2" + ", " + Closet.Depth + ", " + Closet.Width + ", " + "0" + ", " + "none");
            DBConnection.Insert(iduser, DbColumn, "Bracket" + ", " + "2" + ", " + height + ", " + "0" + ", " + "0" + ", " + "none");

            return Parts;
        }
        
    }
}
