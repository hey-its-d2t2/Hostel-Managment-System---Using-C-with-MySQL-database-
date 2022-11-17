using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
namespace Hostel_Managment_System
{
    internal class DB_Function
    {
        protected MySqlConnection GetConnection()
        {
            MySqlConnection conn = new MySqlConnection
            {
                ConnectionString = "data source  = MySQL Community Server - GPL;integrated security = True;server=localhost;user=root;database=Hostel;port=3306;password=jinu0292"
            }; 
            return conn;
        }
        public DataSet GetData(string query)
        {
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn,
                CommandText = query
            };
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            return dataSet;
        }
        public void SetData(string query, string msg)
        {
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn
            };
            conn.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public void SetData(string query)
        {
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn
            };
            conn.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            conn.Close();
            //MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
