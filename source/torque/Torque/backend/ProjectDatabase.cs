using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Torque.backend
{
    /// <summary>
    ///  The main class to handle the connection and queries to the database.
    ///  Currently, this connects directly to the database, should try and make
    ///  a REST sort of a thing here. Using parameters to build the SQL command.
    /// </summary>
    public class ProjectDatabase
    {
        public MySqlConnection connection;
        private string server;
        private string readserver;
        private string database;
        private string uid;
        private string password;
        private string connectionString;
        private string readConnString;
        private bool readHostNotFound = false;

        public ProjectDatabase(string host = "localhost", string db = "prototype", 
                               string uid = "root", string pwd = "root", string readhost = "gfx61")
        {
            Initialize(host, db, uid, pwd);
        }

        private void Initialize(string host = "localhost", string db = "prototype",
                                string dbuser = "root", string pwd = "root", string readhost = "gfx61")
        {
            this.server = host;
            this.database = db;
            this.uid = dbuser;
            this.password = pwd;
            this.readserver = readhost;

            this.connectionString = "server=" + this.server + ";" + "user id=" + this.uid + ";" + "password=" + this.password + ";";
            this.readConnString = "server=" + this.readserver + ";" + "user id=" + this.uid + ";" + "password=" + this.password + ";";

            this.connection = new MySqlConnection(this.connectionString);
        }

        public void SetDatabase(string database)
        {
            this.database = database;
        }

        public bool OpenConnection(bool readMode = false)
        {
            try
            {
                if (readMode && this.connection.ConnectionString != this.readConnString)
                {
                    this.connection.ConnectionString = this.readConnString;
                }
                this.connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                // Handle errors by basing your app response on 
                // the error number.
                // Two most common errors are:
                // 0: Cannot connect to server
                // 1045: Invalid user name and/or password
                switch (ex.Number)
                {
                    case 0:
                        // Ok, here's the thing. If, for some reason you can't reach the
                        // mirror, try the main server directly. This will make things
                        // *potentially* slow.
                        if (readMode)
                        {
                            try
                            {
                                this.connection.ConnectionString = this.connectionString;
                                this.connection.Open();
                                this.readHostNotFound = true;
                                return true;
                            }
                            catch (MySqlException ex2)
                            {
                                MessageBox.Show("Cannot connect to server. Contact admin.");
                            }
                        }
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password. Please try again.");
                        break;
                }
                return false;
            }
        }

        public bool CloseConnection(bool readMode = false)
        {
            try
            {
                if (readMode && this.readHostNotFound && this.connection.ConnectionString != "server=gfx61;user id=riva-root")
                {
                    this.connection.ConnectionString = this.readConnString;
                }
                this.connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void Insert(string tableName, Hashtable columnValHash)
        {
            string insertCmd = "INSERT INTO " + this.database + "." + tableName + " (";
            foreach (string key in columnValHash.Keys)
            {
                insertCmd += key + ",";
            }
            insertCmd = insertCmd.Remove(insertCmd.Length - 1) + ") VALUES (";

            foreach (string key in columnValHash.Keys)
            {
                insertCmd += "?" + key + ",";
            }
            insertCmd = insertCmd.Remove(insertCmd.Length - 1) + ");";

            MySqlCommand cmd = new MySqlCommand(insertCmd, connection);

            foreach (string key in columnValHash.Keys)
            {
                string rep_key = "?" + key;
                cmd.Parameters.AddWithValue(rep_key, columnValHash[key]);
            }

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Update(string tableName, Hashtable columnVals, Hashtable keyVals)
        {
            // Syntax:
            // UPDATE tableName SET columnVals[key]=columnVals[value] WHERE keyVals[key]=keyVals[value] AND keyVals[key]=keyVals[value];
            // TO-DO: Add support for OR, AND-OR, OR-AND queries in the WHERE clause
            string updateCmd = "UPDATE " + this.database + "." + tableName + " SET ";

            // Build the SET part of the command
            foreach (string key in columnVals.Keys)
            {
                updateCmd += key + "=?" + key + ", ";
            }
            updateCmd = updateCmd.Remove(updateCmd.Length - 2);

            // If we have been passed an empty hash table, skip it
            if (keyVals.Count != 0)
            {
                // Build the WHERE part of the command
                updateCmd += " WHERE ";
                foreach (string key in keyVals.Keys)
                {
                    updateCmd += key + "=?" + key + " AND ";
                }
                updateCmd = updateCmd.Remove(updateCmd.Length - 5);
            }
            updateCmd += ";";
            
            MySqlCommand cmd = new MySqlCommand(updateCmd, this.connection);

            foreach (string key in columnVals.Keys)
            {
                string repKey = "?" + key;
                cmd.Parameters.AddWithValue(repKey, columnVals[key]);
            }

            if (keyVals.Count != 0)
            {
                foreach (string key in keyVals.Keys)
                {
                    string repKey = "?" + key;
                    cmd.Parameters.AddWithValue(repKey, keyVals[key]);
                }
            }

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<Hashtable> Select(List<string> columns, string tableName, Hashtable columnVals)
        {
            // Syntax:
            // SELECT (column1, column2) FROM (table1, table2) WHERE columnVals[keys]=columnVals[value] AND columnVals[keys]=columnVals[value]
            // TO-DO: Add support for OR, AND-OR, OR-AND queries in the WHERE clause
            List<Hashtable> result = new List<Hashtable>();

            string selectCmd = "SELECT ";
            if (columns.Count == 0)
            {
                // If no columns are passed out here, assume
                // that we want to select all columns
                selectCmd += "*";
            }
            else
            {
                foreach (string col in columns)
                {
                    selectCmd += col + ", ";
                }
                selectCmd = selectCmd.Remove(selectCmd.Length - 2);
            }

            selectCmd += " FROM " + this.database + "." + tableName;

            // Add the WHERE clause, if applicable
            if (columnVals.Count != 0)
            {
                selectCmd += " WHERE ";
                foreach (string key in columnVals.Keys)
                {
                    selectCmd += key + "=?" + key + " AND ";
                }
                selectCmd = selectCmd.Remove(selectCmd.Length - 5);
            }
            selectCmd += ";";
            
            MySqlCommand cmd = new MySqlCommand(selectCmd, this.connection);

            if (columnVals.Count != 0)
            {
                foreach (string key in columnVals.Keys)
                {
                    string repKey = "?" + key;
                    cmd.Parameters.AddWithValue(repKey, columnVals[key]);
                }
            }

            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                Hashtable tableData = new Hashtable();
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    if (!tableData.Contains(dataReader.GetName(i)))
                        tableData.Add(dataReader.GetName(i), dataReader.GetFieldValue<object>(i));
                }
                result.Add(tableData);
            }

            dataReader.Close();

            return result;
        }

        private static string Base64Encode(string text)
        {
            var text_bytes = System.Text.Encoding.UTF8.GetBytes(text);
            return System.Convert.ToBase64String(text_bytes);
        }

        private static string Base64Decode(string base64Data)
        {
            var bytes_text = System.Convert.FromBase64String(base64Data);
            return System.Text.Encoding.UTF8.GetString(bytes_text);
        }

        public static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        public static string GetString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];

            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }

        internal string GetDatabase()
        {
            return this.database;
        }
    }
}
