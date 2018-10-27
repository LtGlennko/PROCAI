using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class DBManager
    {
        public static string cadena = "server = quilla.lab.inf.pucp.edu.pe;" +
             "user = inf282g3;" +
             "password = sSZf0D;" +
             "database = inf282g3;" +
             "port = 3306;" +
             "SslMode = none;";

        private MySqlConnection con;
        private MySqlCommand comando;

        public MySqlConnection Con { get => con; set => con = value; }
        public MySqlCommand Comando { get => comando; set => comando = value; }

        public bool initialize_conection() {
            bool status = false;
            try {
                con = new MySqlConnection(cadena);
                con.Open();
                comando = new MySqlCommand();
                comando.Connection = con;
                status = true;
            } catch {
                status = false;
            };
            return status;
        }

        public bool finalize_conection()
        {
            bool status = false;
            try
            {
                con.Close();
                status = true;
            }
            catch
            {
                status = false;
            };
            return status;
        }

    }
    
}
