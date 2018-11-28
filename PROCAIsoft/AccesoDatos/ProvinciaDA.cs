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
    public class ProvinciaDA
    {
        private MySqlConnection con;
        MySqlCommand comando;
        String sql;
        public BindingList<Provincia> listarProvincia(string idr)
        {
            BindingList<Provincia> prov = new BindingList<Provincia>();
            con = new MySqlConnection(DBManager.cadena);
            con.Open();
            comando = new MySqlCommand();
            sql = "SELECT id, name, region_id "
                + "FROM provinces WHERE region_id='" + idr+"';";
            comando.CommandText = sql;
            comando.Connection = con;
            MySqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                int id = lector.GetInt32("id");
                string nombre = lector.GetString("name");
                string region_id = lector.GetString("region_id");
                
                Provincia m = new Provincia(id, nombre,region_id);
                prov.Add(m);
            }
            con.Close();
            return prov;
        }
    }
}
