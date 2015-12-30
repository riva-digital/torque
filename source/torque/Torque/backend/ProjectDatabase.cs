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
    class ProjectDatabase
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public ProjectDatabase(string host = "localhost", string db = "prototype", 
                               string uid = "root", string pwd = "root")
        {
            Initialize(host, db, uid, pwd);
        }

        private void Initialize(string host = "localhost", string db = "prototype",
                                string dbuser = "root", string pwd = "root")
        {
            server = host;
            database = db;
            uid = dbuser;
            password = pwd;

            string connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
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
                        MessageBox.Show("Cannot connect to server. Contact admin.");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password. Please try again.");
                        break;
                }
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
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
            string insertCmd = "INSERT INTO " + tableName + " (";
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
        }

        public Hashtable Select(List<string> columns, string tableName, Hashtable columnVals)
        {
            // Syntax:
            // SELECT (column1, column2) FROM (table1, table2) WHERE columnVals[keys]=columnVals[value] AND columnVals[keys]=columnVals[value]
            // TO-DO: Add support for OR, AND-OR, OR-AND queries in the WHERE clause
            Hashtable result = new Hashtable;
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
    }
}
