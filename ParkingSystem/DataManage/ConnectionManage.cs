using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingSystem.DataManage
{
    class ConnectionManage
    {
        private const string SERVER = "localhost";
        private const string DATABASE = "parking";
        private const string UID = "root";
        private const string PASSWORD = "root1234";

        private static ConnectionManage instance;

        private MySqlConnection connectionDB;

        private ConnectionManage()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = SERVER;
            builder.Database = DATABASE;
            builder.UserID = UID;
            builder.Password = PASSWORD;

            string stringConnection = builder.ToString();
            //Console.WriteLine(stringConnection);
            builder = null;

            connectionDB = new MySqlConnection(stringConnection);
        }

        public static ConnectionManage GetInstance()
        {
            if (instance == null)
                instance = new ConnectionManage();

            return instance;
        }

        public MySqlConnection ConnectionDB
        {
            get { return this.connectionDB; }
        }
    }
}
