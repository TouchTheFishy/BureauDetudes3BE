using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace KewLox
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
                        Console.WriteLine("Can not connect to server. Contact administrator"); // avant il y avait ça: MessageBox.Show(ex.Message); mais MessageBox n'est pas reconnu
                        break;
                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again"); // avant il y avait ça: MessageBox.Show(ex.Message); mais MessageBox n'est pas reconnu
                        break;
                }
                return false;
            }
        }

        // Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message); // avant il y avait ça: MessageBox.Show(ex.Message); mais MessageBox n'est pas reconnu
                return false;
            }
        }

        // Create table
        public void CreateTable(string nametable) // Penser à avoir des "nametable" unique pour retrouver le client.
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
        public int Insert(string table, string[] namecolumns, string[] namevalues)
        {
            int id;
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
            //Console.WriteLine(query);

            // Open connection

            if (this.OpenConnection() == true)
            {
                // Create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                // Execute command and get the ID back
                cmd.ExecuteNonQuery();
                id = Convert.ToInt32(cmd.LastInsertedId);

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
        public void Delete(string table, string namecolumn, string value)
            {
                string query = "DELETE FROM " + table + " WHERE " + namecolumn + "='" + value + "'";

                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }
            }

           // Select statement
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
                    return values = new string[,] { {"error","This part does not exist." } };
                }
                
            }
            //if the connection failed
            else
            {
                return values=new string[,] { { "error", "Connection failed." } };
            }
        }


            // A voir si c'est interessant à implanter.
            // Backup
            public void Backup()
            { }
            // Restor
            public void Restore()
            { }
    }
}
