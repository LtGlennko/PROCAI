using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Modelo;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class RegionDA
    {
        private MySqlConnection con;
        MySqlCommand comando;
        String sql;
        public BindingList<Region> listarRegion()
        {
            BindingList<Region> reg = new BindingList<Region>();
            con = new MySqlConnection(DBManager.cadena);
            con.Open();
            comando = new MySqlCommand();
            sql = "SELECT id, name "
                + "FROM regions";
            comando.CommandText = sql;
            comando.Connection = con;
            MySqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                int id = lector.GetInt32("id");
                string nombre = lector.GetString("name");

                Region m = new Region(id, nombre);
                reg.Add(m);
            }
            con.Close();
            return reg;
        }
    }
}
