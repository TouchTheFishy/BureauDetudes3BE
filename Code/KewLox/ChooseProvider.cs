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
        private string datasource;// = "localhost"
        private string port;// = "3306"
        private string username;// = "root";
        private string password;// = "";
        private string connectionInfo;

        //Data of the database & server
        public List<string> Fournisseur
        {
            get { return new List<string> { datasource, port, username, password, connectionInfo }; }
        }

        //Constructor for the database
        public ChooseProvider(string Datasource, string Port, string Username, string Password)
        {
            this.datasource = Datasource;
            this.port = Port;
            this.username = Username;
            this.password = Password;
            this.connectionInfo = String.Format("datasource={0}; port={1}; username={2}; password={3}", Datasource, Port, Username, Password);
        }

        //Looks for part with code "code" in the database with connection info "connectionInfo"
        public string ChooseProv(string code, string connectionInfo)
        {
            try
            {
                //initialize variables
                double price1;
                double price2;

                //give infos to connect to the db, and open connection
                MySqlConnection connect = new MySqlConnection(connectionInfo);
                connect.Open();

                //SQL Command based on the part needed, & executing the command
                MySqlCommand cmd = new MySqlCommand("select `Prix-Fourn 1`,`Prix-Fourn2`,`Delai-Fourn 1`,`Delai-Fourn2` from csv_db.kewlox where `Code`='" + code + "';", connect);
                MySqlDataReader reader = cmd.ExecuteReader();

                //Looking through results of the command
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //Finding the prices for the different providers
                        price1 = Convert.ToDouble(reader[0]);
                        price2 = Convert.ToDouble(reader[1]);
                        //First scenario: prices are equal => check delays
                        if (price1 == price2)
                        {
                            int delay1 = Convert.ToInt32(reader[2]);
                            int delay2 = Convert.ToInt32(reader[3]);
                            reader.Close();
                            connect.Close();
                            //Returns the provider with better delay
                            return (delay1 <= delay2 ? "fourn1" : "fourn2");
                        }
                        reader.Close();
                        connect.Close();
                        //Returns the chosen provider
                        return (price1 < price2 ? "fourn1" : "fourn2");
                    }
                }
                //No row responds to request
                return "This part does not exist";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
    }
}
