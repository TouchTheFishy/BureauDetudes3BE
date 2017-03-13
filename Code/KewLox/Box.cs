using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KewLox
{
    class Box
    {
        List<KeyValuePair<ConstructionParts,int>> Parts = new List<KeyValuePair<ConstructionParts, int>>();
        List<Options> OptParts = new List<Options>();


        public List<KeyValuePair<ConstructionParts, int>> AddConstructionParts(int height)
        {
            Parts.Add(new KeyValuePair<ConstructionParts, int>(new Crossbars() {Dim = Closet.Width },2)); // Front crossbar (traverse avant) x2?
            Parts.Add(new KeyValuePair<ConstructionParts, int>(new Crossbars() { Dim = Closet.Width }, 2)); // Back crossbar (traverse arrière) x2?
            Parts.Add(new KeyValuePair<ConstructionParts, int>(new Crossbars() { Dim = Closet.Depth }, 4)); // Lateral crossbar x4?
            Parts.Add(new KeyValuePair<ConstructionParts, int>(new Pannel() { Height = height, Width = Closet.Depth },2)); // Lateral Pannel x2?
            Parts.Add(new KeyValuePair<ConstructionParts, int>(new Pannel() { Height = height, Width = Closet.Depth }, 1)); // Back pannel
            Parts.Add(new KeyValuePair<ConstructionParts, int>(new Pannel() { Height = height, Width = Closet.Depth }, 2)); // Up/Down pannel x2?
            Parts.Add(new KeyValuePair<ConstructionParts, int>(new Bracket() { Dim = Closet.Depth }, 4)); // Bracket (tasseaux verticaux) x4?
            return Parts;
        }
        
    }
}
