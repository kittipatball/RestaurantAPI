using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResturantAPI.Connection
{
    public class Database
    {
        public MySqlDataReader Query(String sql)
        {
            MySqlConnection con = new MySqlConnection("host=localhost;user=admin;password=P@ssw0rd;database=restaurant");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
    }
}