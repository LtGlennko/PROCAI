using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
                int tlfOfi = lector.GetInt32("telefonoOfi");
                int celOfi = lector.GetInt32("celularOfi");
                string corOfi = lector.GetString("correOfi");
                //Creacion del guia
                Guia g = new Guia(usu, fechaIn, tlfOfi, celOfi, corOfi, tipo);
                //Lectura de datos su cargo
                int idCarg = lector.GetInt32("IdCargo");
                string nomCarg = lector.GetString("NombreCargo");
                
                //Lectura de datos de la cuenta
                int idCuenta = lector.GetInt32("IdCuenta");
                DateTime ultimaConexion = lector.GetDateTime("ultimaConexion");
                string nombreUsuario = lector.GetString("nombreDeUsuario");
                string contrasena = lector.GetString("contrasena");
                //Creacion de la cuenta
                Cuenta cue = new Cuenta(ultimaConexion, nombreUsuario, contrasena);
                //Asigamos cuenta al usuario
                usu.setCuenta(cue);
                con.Close();
                //return usu;
            }
            catch (Exception)
            {
                //En caso no haya encontrado la cuenta asociada
                con.Close();
                return null;
            }
        }
    }
}
