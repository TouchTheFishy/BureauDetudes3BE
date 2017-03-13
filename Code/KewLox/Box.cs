using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KewLox
{
    class Box
    {
        List<ConstructionParts> Parts = new List<ConstructionParts>();
        List<Options> OptParts = new List<Options>();


        public List<ConstructionParts> AddConstructionParts(int width, int depth, int nbbox)
        {
            int width = Closet.Width;
            int depth = Closet.Depth;
            List<int> dim = new List<int>();
            dim.Add(depth);
            dim.Add(width);
            for (int i = 1; i == nbbox; i++)
            {
                Console.WriteLine("Please chose the height of the box number " + i);
                Console.WriteLine("The possible heights are: 32, 42 and 52. Please select one.");
                int height = Convert.ToInt32(Console.ReadLine());
                if (height == 32 || height == 42 || height == 52)
                {
                    dim.Add(i); // number of the box.
                    Parts.Add(new Crossbars() {Dim = width }); // Front crossbar (traverse avant) x2?
                    Parts.Add(new Crossbars() { Dim = width }); // Back crossbar (traverse arrière) x2?
                    Parts.Add(new Crossbars() { Dim = depth }); // Lateral crossbar x4?
                    Parts.Add(new Pannel() { Height = height, Width = depth}); // Lateral Pannel x2?
                    Parts.Add(new Pannel() { Height = height, Width = width }); // Back pannel
                    Parts.Add(new Pannel() { Height = depth, Width = width }); // Up/Down pannel x2?
                    Parts.Add(new Bracket() { Dim = height }); // Bracket (tasseaux verticaux) x4?
                }
                else { /*retour au choix de la hauteur*/}
            }
            return Parts;
        }
    }
}
