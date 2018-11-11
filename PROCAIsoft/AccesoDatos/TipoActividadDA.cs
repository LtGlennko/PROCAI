using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.ComponentModel;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class TipoActividadDA
    {
        private MySqlConnection con;
        MySqlCommand comando;
        String sql;
        public BindingList<TipoActividad> listarTipoActividades()
        {
            BindingList<TipoActividad> tactiviades = new BindingList<TipoActividad>();
            con = new MySqlConnection(DBManager.cadena);
            con.Open();
            comando = new MySqlCommand();
            sql = "SELECT IdTIpoActividad,Nombre,Descripcion FROM TipoActividad";
            comando.CommandText = sql;
            comando.Connection = con;
            MySqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                int idTipoActividad = lector.GetInt32("IdTipoActividad");
                string nombre = lector.GetString("Nombre");
                string descripcion = lector.GetString("Descripcion");
                TipoActividad a = new TipoActividad(nombre, descripcion);
                a.IdTipoActividad1 = idTipoActividad;
                tactiviades.Add(a);
            }
            con.Close();
            return tactiviades;
        }

        public BindingList<TipoActividad> buscarTA(string pista)
        {
            BindingList<TipoActividad> tactiviades = new BindingList<TipoActividad>();
            con = new MySqlConnection(DBManager.cadena);
            con.Open();
            comando = new MySqlCommand();
            sql = "SELECT IdTipoActividad, Nombre, Descripcion " +
                "FROM TipoActividad " +
                "WHERE Nombre LIKE '%" + pista + "%';";
            comando.CommandText = sql;
            comando.Connection = con;
            MySqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                int idTipoActividad = lector.GetInt32("IdTipoActividad");
                string nombre = lector.GetString("Nombre");
                string descripcion = lector.GetString("Descripcion");
                TipoActividad a = new TipoActividad(nombre, descripcion);
                a.IdTipoActividad1 = idTipoActividad;
                tactiviades.Add(a);
            }
            con.Close();
            return tactiviades;
        }
        public bool registrarTipoActividad(TipoActividad ta)
        {
            try
            {
                con = new MySqlConnection(DBManager.cadena);
                con.Open();
                comando = new MySqlCommand();
                sql = "INSERT INTO TipoActividad(Nombre,Descripcion) " +
                             "VALUES('" + ta.Nombre + "','" + ta.Descripcion + "')";
                comando.CommandText = sql;
                comando.Connection = con;
                comando.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool actualizarTipoActividad(TipoActividad ta)
        {
            try
            {
                con = new MySqlConnection(DBManager.cadena);
                con.Open();
                comando = new MySqlCommand();
                sql = "UPDATE Merchandising SET Nombre= '" + ta.Nombre + "'," + " Descripcion= " + ta.Descripcion + " WHERE IdMerchandising=" + ta.IdTipoActividad1;
                comando.CommandText = sql;
                comando.Connection = con;
                comando.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
