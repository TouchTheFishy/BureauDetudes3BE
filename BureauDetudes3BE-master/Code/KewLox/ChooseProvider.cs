using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace KewLox
{
    public class ChooseProvider
    {
        private string provider;
        public string Provider
        {
            get { return provider; }
            set { provider = value; }
        }

        //choose provider for a part with code "code" in the database, calls method "ChooseProv"
        public ChooseProvider(string code,DBConnect database)
        {
            this.Provider = ChooseProv(code,database);
        }

        private string ChooseProv(string code, DBConnect database)
        {
            try
            {
                //initialize variables
                double price1;
                double price2;

                //SQL Command based on the part needed, & executing the command
                string[,] values = database.Select("`Prix-Fourn 1`,`Prix-Fourn2`,`Delai-Fourn 1`,`Delai-Fourn2`", "stock", "`Code`='" + code + "'");

                //checks if there is an error (dbconnect failed or piece doesn't exist)
                if (values[0, 0] == "error")
                {
                    return values[0,1];
                }
                price1 = Convert.ToDouble(values[0, 1]);
                price2 = Convert.ToDouble(values[1, 1]);
                //First scenario: prices are equal => check delays
                if (price1 == price2)
                {
                    int delay1 = Convert.ToInt32(values[2,1]);
                    int delay2 = Convert.ToInt32(values[3,1]);
                    //Returns the provider with better delay
                    return (delay1 <= delay2 ? "fourn1" : "fourn2");
                }
                //Returns the chosen provider
                return (price1 < price2 ? "fourn1" : "fourn2");
            }
            catch (Exception ex)
            {
                return(ex.Message);
            }

        }
    }
}
