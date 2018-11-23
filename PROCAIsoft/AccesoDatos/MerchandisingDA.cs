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
    public class MerchandisingDA
    {
        private MySqlConnection con;
        MySqlCommand comando;
        String sql;
        public BindingList<Merchandising> listarMerchandising()
        {
            BindingList<Merchandising> mer = new BindingList<Merchandising>();
            con = new MySqlConnection(DBManager.cadena);
            con.Open();
            comando = new MySqlCommand();
            sql = "SELECT IdMerchandising, nombre ,descripcion, stock "
                + "FROM Merchandising WHERE estado=1;";
            comando.CommandText = sql;
            comando.Connection = con;
            MySqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                int idMerchandising = lector.GetInt32("IdMerchandising");
                string nombre = lector.GetString("nombre");
                string descripcion = lector.GetString("descripcion");
                int stock = lector.GetInt32("stock");
                Merchandising m = new Merchandising(idMerchandising,nombre,descripcion,stock);
                mer.Add(m);
            }
            con.Close();
            return mer;
        }

        public BindingList<Merchandising> buscarMerchandising(string pista)
        {
            BindingList<Merchandising> mer = new BindingList<Merchandising>();
            con = new MySqlConnection(DBManager.cadena);
            con.Open();
            comando = new MySqlCommand();
            sql = "SELECT IdMerchandising, nombre, descripcion, stock " +
                "FROM Merchandising "+
                "WHERE nombre LIKE '%"+pista+"%' AND estado=1;";
            comando.CommandText = sql;
            comando.Connection = con;
            MySqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                int idMerchandising = lector.GetInt32("IdMerchandising");
                string nombre = lector.GetString("nombre");
                string descripcion = lector.GetString("descripcion");
                int stock = lector.GetInt32("stock");
                Merchandising m = new Merchandising(idMerchandising, nombre, descripcion, stock);
                mer.Add(m);
            }
            con.Close();
            return mer;
        }

        public BindingList<Merchandising> buscarMerchandisingS(int st)
        {
            BindingList<Merchandising> mer = new BindingList<Merchandising>();
            con = new MySqlConnection(DBManager.cadena);
            con.Open();
            comando = new MySqlCommand();
            sql = "SELECT IdMerchandising, nombre, descripcion, stock " +
                "FROM Merchandising " +
                "WHERE stock='"+st+"';";
            comando.CommandText = sql;
            comando.Connection = con;
            MySqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                int idMerchandising = lector.GetInt32("IdMerchandising");
                string nombre = lector.GetString("nombre");
                string descripcion = lector.GetString("descripcion");
                int stock = lector.GetInt32("stock");
                Merchandising m = new Merchandising(idMerchandising, nombre, descripcion, stock);
                mer.Add(m);
            }
            con.Close();
            return mer;
        }

        public BindingList<Merchandising> buscarMerchandisingId(int id)
        {
            BindingList<Merchandising> mer = new BindingList<Merchandising>();
            con = new MySqlConnection(DBManager.cadena);
            con.Open();
            comando = new MySqlCommand();
            sql = "SELECT IdMerchandising, nombre, descripcion, stock " +
                "FROM Merchandising " +
                "WHERE IdMerchandising="+id;
            comando.CommandText = sql;
            comando.Connection = con;
            MySqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                int idMerchandising = lector.GetInt32("IdMerchandising");
                string nombre = lector.GetString("nombre");
                string descripcion = lector.GetString("descripcion");
                int stock = lector.GetInt32("stock");
                Merchandising m = new Merchandising(idMerchandising, nombre, descripcion, stock);
                mer.Add(m);
            }
            con.Close();
            return mer;
        }
        public bool eliminarMerchandising(int id)
        {
            try
            {
                con = new MySqlConnection(DBManager.cadena);
                con.Open();
                comando = new MySqlCommand();
                sql = "UPDATE Merchandising "+
                    "SET estado = 0 WHERE IdMerchandising = "+id+";";
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
        public bool registrarMerchandising(Merchandising m)
        {
            try
            {
                con = new MySqlConnection(DBManager.cadena);
                con.Open();
                comando = new MySqlCommand();
                sql = "INSERT INTO Merchandising(nombre,descripcion,stock) " +
                             "VALUES('" + m.Nombre+ "','" + m.Descripcion + "'," +
                                            m.Stock +  ")";
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

        public void actualizarMerchandising(Merchandising m)
        {
            con = new MySqlConnection(DBManager.cadena);
            con.Open();
            comando = new MySqlCommand();
            sql = "UPDATE Merchandising SET nombre= '" + m.Nombre + "',"+" stock= "+ m.Stock +", descripcion='"+m.Descripcion+"'" +" WHERE IdMerchandising=" + m.IdMerchandising1;
            comando.CommandText = sql;
            comando.Connection = con;
            comando.ExecuteNonQuery();
            con.Close();

        }

    }      
}