using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace KewLox_Forms
{
    public class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        // Constructor
        public DBConnect()
        {
            Initialize();
        }

        // Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "KewLox";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        // Open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                /* When handling errors, the application's response 
                 * can be based on the number. The most common are 
                    * 0: can not connect to server, 
                    * 1045: Invalid username and/or password. */
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Can not connect to server. Contact administrator");
                        break;
                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        // Close connection
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        // Create table
        public void CreateTable(string nametable)
        {
            string query = "CREATE TABLE " + nametable +
                " ( NameObject  varchar(255), Quantity int, Width int, Depth int, Height int, Color varchar(255))";
            
            // Open connection
            if (this.OpenConnection() == true)
            {
                // Create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                // Execute command
                cmd.ExecuteNonQuery();

                // Close connection
                this.CloseConnection();
            }

        }

        // Insert statement. Take the name of the table and two list, non restriction in length.
        public Int64 Insert(string table, string[] namecolumns, string[] namevalues)
        {
            Int64 id;
            int i = 0;
            string columns = namecolumns[i];
            string values = "'" + namevalues[i] + "'";
            if (namevalues.Length != namecolumns.Length)
            {
                Console.WriteLine("The number of columns and values are not the same");
            }
            else
            {
                i += 1;
                while (i < namecolumns.Length)
                {
                    columns += " ," + namecolumns[i];
                    values += " ,'" + namevalues[i] + "'";
                    i += 1;
                }
            }
            string query = "INSERT INTO " + table + " (" + columns + ") VALUES(" + values + ")";

            // Open connection

            if (this.OpenConnection() == true)
            {
                // Create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                // Execute command and get the ID back
                cmd.ExecuteNonQuery();
                id = Convert.ToInt64(cmd.LastInsertedId);

                // Close connection
                this.CloseConnection();
                return id;
            }

            else
            {
                return 0;
            }
        }

        // Update statement. The value2 is used for the id.
        public void Update(string table, string namecolumn1, string namecolumn2, string value1, int value2)
        {
            string query = "UPDATE " + table + " SET " + namecolumn1 + "='" + value1 + "' WHERE " + namecolumn2 + "='" + value2 + "'";

            // Open connection
            if (this.OpenConnection() == true)
            {
                // create mysql command
                MySqlCommand cmd = new MySqlCommand();

                // Assign the query using CommandText
                cmd.CommandText = query;

                // Assign the connection using Connection
                cmd.Connection = connection;

                // Execute query
                cmd.ExecuteNonQuery();

                // Close connection
                this.CloseConnection();
            }
        }

        // Delete statement
        public void Delete(string table, string value)
        {
            string query = "DELETE FROM " + table + " WHERE " + value;

            if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }
            }

        // Select statement
        public List<String> SelectCol(string columns, string table)
        {
            string query = "SELECT " + columns + " FROM " + table;

            //Divide columns string into an array with the different columns and compute the number of fields
            string[] allcolumns = columns.Split(Convert.ToChar(","));
            int nbfields = allcolumns.Length;

            // Create an array of arrays to store the result {{column1,value1},{column2,value2},...}

            List<String> values = new List<String>();
            if (this.OpenConnection() == true) //Try if the connection to the db worked
            {
                
                // Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                // Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //check that the part exists
                if (dataReader.HasRows)
                {
                    // Read the data and store in the array
                    while (dataReader.Read())
                    {
                        for (int i = 0; i < nbfields; i++)
                        {
                            values.Add( dataReader[i].ToString());
                        }
                    }

                    // Close Data Reader
                    dataReader.Close();

                    // Close Connection
                    this.CloseConnection();

                    // return list to be displayed
                    return values;

                }
                //if the part does not exist
                else
                {
                    // Close Connection
                    this.CloseConnection();

                    return values = new List<string> {  "error" };
                }
            }
            //if the connection failed
            else
            {
                return values = new List<string> { "error" };
            }
        }
        public string[,] Select(string columns, string table, string equal)
        {
            string query = "SELECT " +  columns + " FROM " + table + " WHERE " + equal;

            //Divide columns string into an array with the different columns and compute the number of fields
            string[] allcolumns = columns.Split(Convert.ToChar(","));
            int nbfields = allcolumns.Length;
            
            // Create an array of arrays to store the result {{column1,value1},{column2,value2},...}
            string[,] values = new string[nbfields,2]; 

            if (this.OpenConnection() == true) //Try if the connection to the db worked
            {
                // Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                // Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //check that the part exists
                if (dataReader.HasRows)
                {
                    // Read the data and store in the array
                    while (dataReader.Read())
                    {
                        for (int i = 0; i < nbfields; i++)
                        {
                            values[i, 0] = allcolumns[i];
                            values[i, 1] = dataReader[i].ToString();
                        }
                    }

                    // Close Data Reader
                    dataReader.Close();

                    // Close Connection
                    this.CloseConnection();

                    // return list to be displayed
                    return values;

                }
                //if the part does not exist
                else
                {
                    // Close Connection
                    this.CloseConnection();

                    return values = new string[,] { {"error","This part does not exist." } };
                }
            }
            //if the connection failed
            else
            {
                return values=new string[,] { { "error", "Connection failed." } };
            }
        }

        //Keep trace of how many pieces are sold. Each month the table can be print.
        public void Sold(string table, string namepart, decimal numberpart,
            string table2 = "stock", string col11 = "Quantity", string col12 = "Namepart", string col21 = "Enstock", string col22 = "Code")
        {
            string[,] m = Select(col21, table2, col22 + " = '" + namepart + "'");
            string[,] mini = Select("Stockminimum", table2, col22 + " = '" + namepart + "'");
            decimal stock = Convert.ToDecimal(m[0, 1].ToString());
            decimal stockmini = Convert.ToDecimal(mini[0, 1].ToString());
            if (stock <= stockmini)
            {
                string[] col = { col22 };
                string[] value = { namepart };
                string[,] check = Select("Id", "missingcomponents", col22 + " = '" + namepart + "'");
                if (check[0, 0] == "error")
                {
                    Insert("missingcomponents", col, value);
                }
                

            }
            stock = stock - numberpart;
            if (stock < 0)
            {
                Program.OutOfStock = true;
            }

            //Try the piece is already in the table
            try
            {
                string[,] n = Select(col11, table, col12 + " ='" + namepart + "'");
                decimal quantity = Convert.ToDecimal(n[0, 1].ToString());
                numberpart = numberpart + quantity;
            }

            //Create the piece
            catch (System.FormatException)
            {
                string num = numberpart.ToString();
                string[] colonnes = { col12, col11 };
                string[] values = { namepart, num };
                CloseConnection();
                Insert(table, colonnes, values);
            }
            finally
            {
                //Update the quantity
                UpdateDecString(table, col11, col12, numberpart, namepart);
                UpdateDecString(table2, col21, col22, stock, namepart);
            }
        }

        public void Cancel(decimal Id)
        {
            // Erase all the piece in sold and commandespieces until there is an error (no more right ID)
            while (true)
            {
                string columns = "Name, Height, Depth, Width, Quantity, Color";

                string[,] result = Select(columns, "commandespieces", "OrderId = '" + Id + "'");

                // error = no more ID
                if (result[0, 0] == "error")
                {
                    CloseConnection();
                    //Console.WriteLine("Canceled");
                    break;
                }

                decimal quantity = Convert.ToDecimal(result[4, 1]);

                // Translate from english to french
                string color = Translate(result[5, 1]);
                string reference = Translate(result[0, 1]);
                string hauteur = Translate(result[1, 1]);

                // To be sure to get the right piece
                string colstock = "Ref = '" + reference + "' AND hauteur = '" + hauteur + "' AND profondeur = '" +
                    result[2, 1] + "' AND largeur = '" + result[3, 1] + "' AND Couleur = '" + color + "'";

                string[,] stock = Select("Enstock, Code", "stock", colstock);
                string code = stock[1, 1];

                string[,] sold = Select("Enstock", "stock", "Code = '" + code + "'");
                decimal newsold = Convert.ToDecimal(sold[0, 1]);

                // +quantity in stock and -quantity in sold 
                newsold -= quantity;
                quantity += Convert.ToDecimal(stock[0, 1]);

                // Update stock and sold
                UpdateDecString("stock", "Enstock", "Code", quantity, code);
                UpdateDecString("sold", "Quantity", "NamePart", newsold, code);

                Delete("commandespieces", "OrderId = '" + Id + "' AND Name = '" + result[0, 1] + "'");
            }
        }

        // Update statement. The value1 is a decimal and value2 is a string.
        public void UpdateDecString(string table, string namecolumn1, string namecolumn2, decimal value1, string value2)
        {
            string query = "UPDATE " + table + " SET " + namecolumn1 + "='" + value1 + "' WHERE " + namecolumn2 + "='" + value2 + "'";

            // Open connection
            if (this.OpenConnection() == true)
            {
                // create mysql command
                MySqlCommand cmd = new MySqlCommand();

                // Assign the query using CommandText
                cmd.CommandText = query;

                // Assign the connection using Connection
                cmd.Connection = connection;

                // Execute query
                cmd.ExecuteNonQuery();

                // Close connection
                this.CloseConnection();
            }
        }
        public void UpdateInt(string table, string namecolumn1, string namecolumn2, int value1, string value2)
        {
            string query = "UPDATE " + table + " SET " + namecolumn1 + "='" + value1 + "' WHERE " + namecolumn2 + "='" + value2 + "'";

            // Open connection
            if (this.OpenConnection() == true)
            {
                // create mysql command
                MySqlCommand cmd = new MySqlCommand();

                // Assign the query using CommandText
                cmd.CommandText = query;

                // Assign the connection using Connection
                cmd.Connection = connection;

                // Execute query
                cmd.ExecuteNonQuery();

                // Close connection
                this.CloseConnection();
            }
        }
        public void Drop(string table)
        {
            string query = "DELETE FROM " + table +" WHERE 1";

            // Open connection
            if (this.OpenConnection() == true)
            {
                // create mysql command
                MySqlCommand cmd = new MySqlCommand();

                // Assign the query using CommandText
                cmd.CommandText = query;

                // Assign the connection using Connection
                cmd.Connection = connection;

                // Execute query
                cmd.ExecuteNonQuery();

                // Close connection
                this.CloseConnection();
            }
        }

        public string Translate(string s)
        {
            string m = s;
            if (s == "White")
            {
                m = "Blanc";
            }
            else if (s == "Black")
            {
                m = "Noir";
            }
            else if (s == "Brown")
            {
                m = "Brun";
            }
            else if (s == "Glass")
            {
                m = "Verre";
            }
            else if (s == "Chromed")
            {
                m = "Galvanise";
            }
            else if (s == "Cornière")
            {
                m = "Cornieres";
            }
            else if (s == "37")
            {
                m = "42";
            }
            else if (s == "27")
            {
                m = "32";
            }
            else if (s == "47")
            {
                m = "52";
            }
            else if (s == "Coupelle")
            {
                m = "Coupelles";
            }
            return m;
        }
    }
}