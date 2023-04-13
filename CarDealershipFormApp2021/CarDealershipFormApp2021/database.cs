using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CarDealershipFormApp2021
{
    class database
    {
        // DB connection - DB for "dealershipdb"
        // for initial use of this code, you must replace "LOCAL ROOT PASSWORD" into your local root password...
        private MySqlConnection connection =
            new MySqlConnection("server = localhost; port=3306;username=root;password=toor;database=dealershipdb");

        public void openConnection() // for opening the DB connection
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            } // end of if
        } // end of openConnection()

        public void closeConnection() // for closing the DB connection
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            } // end of if
        } // end of closeConnection()

        public MySqlConnection getConnection() // for returning the DB connection
        {
            return connection;
        } // end of getConnection



    } // *** end of database classe ***
}
