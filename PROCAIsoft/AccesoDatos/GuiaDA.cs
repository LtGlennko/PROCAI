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
        //public Guia crearGuia(Usuario usu)
        //{
        //    con = new MySqlConnection(DBManager.cadena);
        //    con.Open();
        //    comando = new MySqlCommand();
        //    sql = "SELECT * FROM Guia WHERE IdGuia = " + usu.IdUsuario1 + ";";
        //    comando.CommandText = sql;
        //    comando.Connection = con;
        //    MySqlDataReader lector = comando.ExecuteReader();
        //    try
        //    {
        //        lector.Read();
        //        //Lectura de datos del guía
        //        string tipoStr = lector.GetString("tipoGuia");
        //        TipoGuia tipo;
        //        if (tipoStr == "Expositor") tipo = TipoGuia.Expositor;
        //        else tipo = TipoGuia.Inscriptor;
        //        string licencia = lector.GetString("licencia");
        //        //Creacion del guia
        //        //Guia g = new Guia()
        //        //Lectura de datos de la cuenta
        //        int idCuenta = lector.GetInt32("IdCuenta");
        //        DateTime ultimaConexion = lector.GetDateTime("ultimaConexion");
        //        string nombreUsuario = lector.GetString("nombreDeUsuario");
        //        string contrasena = lector.GetString("contrasena");
        //        //Creacion de la cuenta
        //        Cuenta cue = new Cuenta(ultimaConexion, nombreUsuario, contrasena);
        //        //Asigamos cuenta al usuario
        //        usu.setCuenta(cue);
        //        con.Close();
        //        //return usu;
        //    }
        //    catch (Exception)
        //    {
        //        //En caso no haya encontrado la cuenta asociada
        //        con.Close();
        //        return null;
        //    }
        //}
    }
}
