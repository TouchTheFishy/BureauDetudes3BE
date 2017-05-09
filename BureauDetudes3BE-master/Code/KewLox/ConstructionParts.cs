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
        private string depth = "0"; //p
        private string width = "0"; //L
        private string color = "White";
        private string code = "";

        private string prefix = "";
        private string dimensions = "";
        private string colorcode = "";
        private string postfix = "";

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
        public string Color
        {
            get
            {
                return Convert.ToString(color);
            }
            set
            {
                color = Convert.ToString(value);
            }
        }
        public string Code
        {
            get
            {
                return Convert.ToString(code);
            }
            set
            {
                code = Convert.ToString(value);
            }
        }

        //set needed??
        public string Prefix
        {
            get
            {
                return Convert.ToString(prefix);
            }
            set
            {
                prefix = Convert.ToString(value);
            }
        }
        public string Dimensions
        {
            get
            {
                return Convert.ToString(dimensions);
            }
            set
            {
                prefix = Convert.ToString(value);
            }
        }
        public string ColorCode { get; set; }
        public string PostFix { get; set; }


        public string Name { get; set; }
        public string Cup { get; set; }

        public string MakeCode()
        {
            List<KeyValuePair<string, string>> partscodes = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("Panneau Ar", "PAR"),
                new KeyValuePair<string, string>("Panneau GD", "PAG"),
                new KeyValuePair<string, string>("Panneau HB", "PAH"),
                new KeyValuePair<string, string>("Porte","POR"),
                new KeyValuePair<string, string>("Cornière","COR"),
                new KeyValuePair<string, string>("Coupelle","COUPEL"),
                new KeyValuePair<string, string>("Tasseau","TAS"),
                new KeyValuePair<string, string>("Traverse AR","TRR"),
                new KeyValuePair<string, string>("Traverse AV","TRF"),
                new KeyValuePair<string, string>("Traverse GD","TRG"),
            };

            List<KeyValuePair<string, string>> colorcodes = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("White","BL"),
                new KeyValuePair<string, string>("Brown","BR"),
                new KeyValuePair<string, string>("Black","NR"),
                new KeyValuePair<string, string>("Glass","VE"),
                new KeyValuePair<string, string>("Chromed","GL")
            };
            // Get the Prefix
            for (int i = 0; i<partscodes.Count; i++)
            {
                if (this.Name == partscodes[i].Key)
                {
                    this.prefix = partscodes[i].Value;
                }
            }
            // Get the Color Code
            for (int i = 0; i<colorcodes.Count; i++)
            {
                if (this.color == colorcodes[i].Key)
                {
                    this.colorcode = colorcodes[i].Value;
                }
            }
            //Get the Dimensions
            if (Int32.Parse(this.height) != 0)
            {
                this.dimensions += this.height.ToString();
            }
            if (Int32.Parse(this.depth) != 0)
            {
                this.dimensions += this.depth.ToString();
            }
            if (Int32.Parse(this.width) != 0)
            {
                this.dimensions += this.width.ToString();
            }

            //Get the Postfix
            if (this.Name == "Cornière")
            {
                for (int i = 1; i < 9; i++) {
                    if (Int32.Parse(this.height) == i * 36 || Int32.Parse(this.height) == i * 46 || Int32.Parse(this.height) == i * 56)
                    {
                        this.postfix = "";
                        // to get out of the loop
                        i = 9;
                    }
                    // we can have max 7 boxes so it's impossible to have 8, so no option above is valid
                    if (i == 8)
                    {
                        int realdimensions = 50;
                        while (realdimensions < int.Parse(this.dimensions))
                        {
                            realdimensions += 25;
                        }
                        this.dimensions = realdimensions.ToString();
                        this.postfix = "DEC";
                    }
                }
            }
            return this.code = this.prefix + this.dimensions + this.colorcode + this.postfix;
        }

        public string[] AddPart(int amount)
        {
            string qtty = Convert.ToString(amount);
            string id = Convert.ToString(Program.Id);
            string[] result = new string[7] { Name, Height, Depth, Width, qtty, id,Color};
            return result;
        }
        public string[] AddDoor()
        {
            string qtty = Convert.ToString(2);
            string id = Convert.ToString(Program.Id);
            
            string[] result = new string[7] { Name, Height, Depth, Width, qtty, id, Color};
            return result;
        }
    }
}
