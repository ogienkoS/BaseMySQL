using MySql.Data.MySqlClient;
namespace BaseSQL
{

    public static class DataBase
    {
        
        public static MySqlConnection connect;

        public static string _host = "";
        public static int _port = 3306;
        public static string _user = "";
        public static string _password = "";
        public static string _DB = "";

        public static bool connectDB(string host, int port, string user, string password, string DB)
        {
            try
            {
                _host = host;
                _port = port;
                _user = user;
                _password = password;
                _DB = DB;
                string connsql = "server = " + host + "; port = " + port + "; user = " + user + "; database = " + DB + "; password = " + password + ";SslMode=none";
                connect = new MySqlConnection(connsql);
                connect.Open();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public static bool connectDB()
        {
            try
            {
                string connsql = "server = " + _host + "; port = " + _port + "; user = " + _user + "; database = " + _DB + "; password = " + _password + ";SslMode=nonel";
                connect = new MySqlConnection(connsql);
                connect.Open();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public static bool CheckDB()
        {
            try
            {
                string query_Test = "SELECT 1";
                MySqlCommand command_Test = new MySqlCommand(query_Test, connect);
                command_Test.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
