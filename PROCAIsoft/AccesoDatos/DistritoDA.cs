using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using Modelo;

namespace AccesoDatos
{
    public class DistritoDA
    {
        private MySqlConnection con;
        MySqlCommand comando;
        String sql;
        public BindingList<Distrito> listarDistrito(string idp)
        {
            BindingList<Distrito> dist = new BindingList<Distrito>();
            con = new MySqlConnection(DBManager.cadena);
            con.Open();
            comando = new MySqlCommand();
            sql = "SELECT id, name, region_id, province_id "
                + "FROM districts WHERE province_id='" + idp + "';" ;
            comando.CommandText = sql;
            comando.Connection = con;
            MySqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                int id = lector.GetInt32("id");
                string nombre = lector.GetString("name");
                string region_id = lector.GetString("region_id");
                string provincia_id = lector.GetString("province_id");
                Distrito m = new Distrito(id, nombre, region_id,provincia_id);
                dist.Add(m);
            }
            con.Close();
            return dist;
        }
    }
}
