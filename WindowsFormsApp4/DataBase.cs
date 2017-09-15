﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace WindowsFormsApp4
{
    public static class DataBase
    {
        public static MySqlConnection connect;
        public static bool connectDB(string host, int port, string user, string password, string DB)
        {
            try
            {
                string connsql = "server = " + host + "; port = " + port + "; user = " + user + "; database = " + DB + "; password = " + password + ";";
                connect = new MySqlConnection(connsql);
                connect.Open();
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
