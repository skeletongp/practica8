using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_8
{
    class Conexion
    {
        public SqlConnection con;

        public SqlConnection Conectar()
        {
            con = new SqlConnection("Server=localhost; DataBase=Safecare; Trusted_Connection=true");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public bool Login(string user, string pass)
        {
            SqlCommand cmd = new SqlCommand("userLogin", Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("user", user);
            cmd.Parameters.AddWithValue("pass", pass);
            int result = int.Parse(cmd.ExecuteScalar().ToString());
            if (result == 1)
            {
                con.Close();
                return true;
            }
            con.Close();
            return false;
        }
        public DataTable Registros()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("getRecords", Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }
    }
}
