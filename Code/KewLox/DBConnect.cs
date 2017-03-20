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
        public class DBConnection
        {
            private MySqlConnection connection;
            private string server;
            private string database;
            private string uid;
            private string password;

            // Constructor
            public DBConnection()
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
                            Console.WriteLine("Can not connect to server. Contact administrator"); // avant il y avait ça: MessageBox.Show(ex.Message); mais MessageBox n'est pas reconnut
                            break;
                        case 1045:
                            Console.WriteLine("Invalid username/password, please try again"); // avant il y avait ça: MessageBox.Show(ex.Message); mais MessageBox n'est pas reconnut
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
                    Console.WriteLine(ex.Message); // avant il y avait ça: MessageBox.Show(ex.Message); mais MessageBox n'est pas reconnut
                    return false;
                }
            }

            // Create table
            public void CreateTable(string nametable) // Penser à avoir des "nametable" unique pour retrouver le client.
            {
                string query = "CREATE TABLE " + nametable +
                    " ( NameObject  varchar(255), Quantity int, Width int, Depth int, Height int, Color";

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

            // Insert statement
            public void Insert(string table, string namecolumn, string value)
            {
                string query = "INSERT INTO " + table + " (" + namecolumn + ") VALUES('" + value + "')";

                // Open connection
                if (this.OpenConnection() == true)
                {
                    // Create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    // Execute command
                    cmd.ExecuteNonQuery();

                    // Close connection
                    this.CloseConnection();
                }
            }

            // Update statement
            public void Update(string table, string namecolumn, string value, string exvalue)
            {
                string query = "UPDATE " + table + " SET " + namecolumn + "='" + value + "' WHERE " + namecolumn + "='" + exvalue + "'";

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

            // Delate statement
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
            public List<string>[] SelectAll(string table, int nbvalues)
            {
                string query = "SELECT * FROM " + table;

                // Create a list to store the result
                List<string>[] list = new List<string>[3]; // A voir comment on le modifie pour que ça colle bien à ce qu'on veut (ici j'ai mis comme dans le site : https://www.codeproject.com/Articles/43438/Connect-C-to-MySQL )
                list[0] = new List<string>();
                list[1] = new List<string>();
                list[2] = new List<string>();

                // Open connection
                if (this.OpenConnection() == true)
                {
                    // Create Command
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    // Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    // Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        list[0].Add(dataReader["id"] + ""); // Pareil ici il faut un peu voir ce qu'on veut mettre
                        list[1].Add(dataReader["name"] + "");
                        list[2].Add(dataReader["age"] + "");
                    }

                    // Close Data Reader
                    dataReader.Close();

                    // Close Connection
                    this.CloseConnection();

                    // return list to be displayed
                    return list;
                }
                else
                {
                    return list;
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
}
