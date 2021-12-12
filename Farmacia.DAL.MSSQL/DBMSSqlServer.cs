using Farmacia.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.DAL.MSSQL
{
    public class DBMSSqlServer : IDB
    {
        SqlConnection connection;
        public string Error { get; private set; }

        public DBMSSqlServer()
        {
            string server = @"DESKTOP-QBHLAER";
            string DB = "Tienda";
            string usr = "tiendauser";
            string pass = "12345";
            connection = new SqlConnection($"Data Source={server};Initial Catalog={DB};Persist Security Info=true;User ID={usr};Password={pass}");
            conectar();
        }

        private bool conectar()
        {
            try
            {
                connection.Open();
                Error = "";
                return true;

            }
            catch (SqlException ex)
            {

                Error = ex.Message;
                return true;
            }
        }

        public bool Comando(string command)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(command, connection);
                cmd.ExecuteNonQuery();
                Error = "";
                return true;

            }
            catch (SqlException ex)
            {

                Error = ex.Message;
                return false;
            }
        }

        public object Consulta(string consulta)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(consulta, connection);
                SqlDataReader dr = cmd.ExecuteReader();
                Error = "";
                return dr;

            }
            catch (SqlException ex)
            {

                Error = ex.Message;
                return null;
            }
        }

    }
}
