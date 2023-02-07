using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laundry_App
{
    internal class Function
    {
        public static string con = "Server=localhost;Database=laundry;user=root;Pwd= ;SslMode=none";

        MySqlConnection koneksi = new MySqlConnection(con);

        public object ShowData(string query)
        {
            MySqlDataAdapter sda = new MySqlDataAdapter(query, koneksi);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds.Tables[0];
        }

        public DataRowCollection GetData(string query)
        {
            MySqlDataAdapter sda = new MySqlDataAdapter(query, koneksi);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt.Rows;
        }
    }
}
