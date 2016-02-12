using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CustomerOrderManagementSystem.Data_Access_Objects {
    class DatabaseConnection {

        private static string server = "MATT-PC\\SQLEXPRESS";
        public string Server {
            set { server = value; }
            get { return server; }
        }

        public static SqlConnection GetConnection() {

            string connectionString = "server=" + server + ";Database=COMS;Trusted_Connection=Yes";

            SqlConnection conn = new SqlConnection(connectionString);

            return conn;
        }
    }
}
