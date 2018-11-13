using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class GuiaDA
    {
        private MySqlConnection con;
        MySqlCommand comando;
        string sql;
        //Este metodo recibe como parametro de entrada un usuario y crea un nuevo guia usando las características de este
        public Guia crearGuia(Usuario usu)
        {
            con = new MySqlConnection(DBManager.cadena);
            con.Open();
            comando = new MySqlCommand();
            sql = "SELECT G.tipoguia, T.fechaIngreso, T.telefonoOfi, T.celularOfi, T.correOfi, C.IdCargo, C.NombreCargo " +
                "FROM Guia G, TrabajadorOCAI T, Cargo C " +
                "WHERE G.IdGuia = T.IdTrabajadorOCAI AND C.IdCargo = T.IdCargo AND IdGuia = " + usu.IdUsuario1 + ";";
            comando.CommandText = sql;
            comando.Connection = con;
            MySqlDataReader lector = comando.ExecuteReader();
            try
            {
                lector.Read();
                //Lectura de datos del guía
                string tipoStr = lector.GetString("tipoGuia");
                TipoGuia tipo = TipoGuia.Inscriptor;
                if (tipoStr == "Expositor") tipo = TipoGuia.Expositor;
                DateTime fechaIn = lector.GetDateTime("fechaIngreso");
                int tlfOfi = 0;
                if (!lector.IsDBNull(2)) tlfOfi = lector.GetInt32("telefonoOfi");
                int celOfi = 0;
                if (!lector.IsDBNull(3)) celOfi = lector.GetInt32("celularOfi");
                string corOfi = "";
                if (!lector.IsDBNull(4)) corOfi = lector.GetString("correOfi");
                //Creacion del guia
                Guia g = new Guia(usu, fechaIn, tlfOfi, celOfi, corOfi, tipo);
                g.IdGuia1 = g.IdTrabajadorOCAI1 = g.IdUsuario1 = usu.IdUsuario1;
                //Lectura de datos su cargo
                int idCarg = lector.GetInt32("IdCargo");
                string nomCarg = lector.GetString("NombreCargo");
                if (nomCarg != "Guia")
                {
                    //En caso el guia no presente el cargo correcto
                    con.Close();
                    return null;
                }
                Cargo c = new Cargo(nomCarg);
                c.IdCargo1 = idCarg;
                //Asignacion del cargo
                g.Cargo = c;
                con.Close();
                return g;
            }
            catch (Exception)
            {
                //En caso no haya leido bien los datos del guia
                con.Close();
                return null;
            }
        }

        //public BindingList<Guia> listarGuias()
        ////{
        ////    BindingList<Guia> guias = new BindingList<Guia>();
        ////    con = new MySqlConnection(DBManager.cadena);
        //    con.Open();
        //    comando = new MySqlCommand();
        //    sql = "SELECT * FROM GUIA";
        //    comando.CommandText = sql;
        //    comando.Connection = con;
        //    MySqlDataReader lector = comando.ExecuteReader();
        //    while (lector.Read())
        //    {
        //        int id = lector.GetInt32("ID");
        //        //como llenar los otros
        //    }
        //    con.Close();
        //    return guias;
        //}
        public bool insertarGuia(int idTrabajadorOCAI)
        {
            con = new MySqlConnection(DBManager.cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = con;
            try
            {
                comando.CommandText = "CREAR_GUIA";
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("_IdTrabajadorOCAI", MySqlDbType.Int32).Value = idTrabajadorOCAI;
                comando.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception)
            {
                con.Close();
                return false;
            }
        }
        public bool eliminarGuia(int idGuia)
        {
            con = new MySqlConnection(DBManager.cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = con;
            try
            {
                comando.CommandText = "ELIMINAR_GUIA";
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("_IdGuia", MySqlDbType.Int32).Value = idGuia;
                comando.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception)
            {
                con.Close();
                return false;
            }
        }
    }
}
