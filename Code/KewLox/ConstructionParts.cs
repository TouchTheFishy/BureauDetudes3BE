using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KewLox
{
    public class ConstructionParts
    {
        private string height = "0";
        private string depth = "0";
        private string width = "0";

        public string Height
        {
            get
            {
                return Convert.ToString(height);
            }
            set
            {
                height = Convert.ToString(value);
            }
        }
        public string Depth
        {
            get
            {
                return Convert.ToString(depth);
            }
            set
            {
                depth = Convert.ToString(value);
            }
        }
        public string Width
        {
            get
            {
                return Convert.ToString(width);
            }
            set
            {
                width = Convert.ToString(value);
            }
        }

        public string Name { get; set; }
        public string[] AddPart(int amount)
        {
            string qtty = Convert.ToString(amount);
            string id = Convert.ToString(Program.Id);
            string[] result = new string[6] { Name, Height, Depth, Width, qtty, id};
            return result;
        }
    }
}
