using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class CuentaDA
    {
        private MySqlConnection con;
        public int existeNombreUsuario(string nombreUsuario)
        {
            con = new MySqlConnection(DBManager.cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = con;
            try
            {

                comando.CommandText = "EXISTE_NOMBRE_USUARIO";
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("_nombreDeUsuario", MySqlDbType.VarChar).Value = nombreUsuario;
                comando.Parameters.Add("_existe", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;
                comando.ExecuteNonQuery();
                int existe = Int32.Parse(comando.Parameters["_existe"].Value.ToString());
                con.Close();
                return existe;
            }
            catch (Exception)
            {
                con.Close();
                return 1;
            }
        }

        public bool registrarCuenta(int idUsuario, Cuenta C)
        {
            con = new MySqlConnection(DBManager.cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = con;
            try
            {
                comando.CommandText = "REGISTRAR_CUENTA";
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("_IdUsuario", MySqlDbType.Int32).Value = idUsuario;
                comando.Parameters.Add("_nombreDeUsuario", MySqlDbType.VarChar).Value = C.NombreDeUsuario;
                comando.Parameters.Add("_contrasena", MySqlDbType.Int32).Value = C.Contrasena;
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
