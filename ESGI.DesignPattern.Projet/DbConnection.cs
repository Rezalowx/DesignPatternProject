using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Text;

namespace ESGI.DesignPattern.Projet
{
    public interface iDbConnection
    {
        bool Connect();
    }
   
    public class DbConnection : iDbConnection
    {
        public string Password { get; set; }
        private MySqlConnection connection = null;
        private string databaseName = string.Empty;
        private static DbConnection _instance = null;
        private DbConnection()
        {
        }

        
        public string DatabaseName
        {
            get { return databaseName; }
            set { databaseName = value; }
        }

        
        public MySqlConnection Connection
        {
            get { return connection; }
        }

       
        public static DbConnection Instance()
        {
            if (_instance == null)
                _instance = new DbConnection();
            return _instance;
        }

        public bool Connect()
        {
            if (Connection == null)
            {
                string connstring = string.Format("Server=localhost; database=myshop; UID=store; password=123456", databaseName);
                connection = new MySqlConnection(connstring);
                connection.Open();
            }

            return true;
        }

        public void Close()
        {

            connection.Close();
        }
    }
}
