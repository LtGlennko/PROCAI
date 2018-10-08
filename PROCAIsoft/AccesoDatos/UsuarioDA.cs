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
    public class UsuarioDA
    {
        private MySqlConnection con;
        MySqlCommand comando;
        String sql;
        public BindingList<Usuario> listarUsuarios()
        {
            BindingList<Usuario> usuarios = new BindingList<Usuario>();
            con = new MySqlConnection(DBManager.cadena);
            con.Open();
            comando = new MySqlCommand();
            sql = "SELECT P.IdPersona, P.DNI, P.Nombres, P.ApellidoPaterno," +
                " P.ApellidoMaterno, P.celular, P.sexo, P.correoElectronico, U.IdUsuario, " +
                "U.fechaCreacion, U.nivelPermiso, C.IdCuenta, C.ultimaConexion, " +
                "C.nombreDeUsuario, C.contrasena FROM Usuario U " +
                "JOIN Persona P ON P.IdPersona = U.IdPersona " +
                "JOIN Cuenta C ON C.IdUsuario = U.IdUsuario;";
            comando.CommandText = sql;
            comando.Connection = con;
            MySqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                //Lectura de datos de la persona
                int idPersona = lector.GetInt32("IdPersona");
                string dni = lector.GetString("DNI");
                string nombres = lector.GetString("Nombres");
                string apellPat = lector.GetString("ApellidoPaterno");
                string apellMat = lector.GetString("ApellidoMaterno");
                int celular = lector.GetInt32("celular");
                char sexoC = lector.GetChar("sexo");
                TipoSexo sexo;
                if (sexoC == 'M') sexo = TipoSexo.Hombre;
                else if (sexoC == 'F') sexo = TipoSexo.Mujer;
                else sexo = TipoSexo.Personalizado;
                string correo = lector.GetString("correoElectronico");
                //Lectura de datos del usuario
                int idUsuario = lector.GetInt32("IdUsuario");
                DateTime fechaCreacion = lector.GetDateTime("fechaCreacion");
                int nivelPermiso = lector.GetInt32("nivelPermiso");
                //Creacion del usuario
                Usuario usu = new Usuario(dni, nombres, apellPat, apellMat, celular, sexo, correo, fechaCreacion, nivelPermiso);
                usu.IdPersona1 = idPersona;
                usu.IdUsuario1 = idUsuario;
                //Lectura de datos de la cuenta
                int idCuenta = lector.GetInt32("IdCuenta");
                DateTime ultimaConexion = lector.GetDateTime("ultimaConexion");
                string nombreUsuario = lector.GetString("nombreDeUsuario");
                string contrasena = lector.GetString("contrasena");
                //Creacion de la cuenta
                Cuenta cue = new Cuenta(ultimaConexion, nombreUsuario, contrasena);
                //Asigamos cuenta al usuario
                usu.setCuenta(cue);
                //Agregamos el usuario a la lista
                usuarios.Add(usu);
            }
            con.Close();
            return usuarios;
        }

        public int buscarUsuario(string username, string password)
        {
            con = new MySqlConnection(DBManager.cadena);
            con.Open();
            comando = new MySqlCommand();
            sql = "SELECT P.IdPersona, P.DNI, P.Nombres, P.ApellidoPaterno," +
                " P.ApellidoMaterno, P.celular, P.sexo, P.correoElectronico, U.IdUsuario, " +
                "U.fechaCreacion, U.nivelPermiso, C.IdCuenta, C.ultimaConexion, " +
                "C.nombreDeUsuario, C.contrasena FROM Usuario U " +
                "JOIN Persona P ON P.IdPersona = U.IdPersona " +
                "JOIN Cuenta C ON C.IdUsuario = U.IdUsuario " +
                "WHERE C.nombreDeUsuario = '" + username +"' AND C.contrasena = '" + password + "';";
            comando.CommandText = sql;
            comando.Connection = con;
            MySqlDataReader lector = comando.ExecuteReader();
            try
            {
                lector.Read();
                //Lectura de datos de la persona
                int idPersona = lector.GetInt32("IdPersona");
                string dni = lector.GetString("DNI");
                string nombres = lector.GetString("Nombres");
                string apellPat = lector.GetString("ApellidoPaterno");
                string apellMat = lector.GetString("ApellidoMaterno");
                int celular = lector.GetInt32("celular");
                char sexoC = lector.GetChar("sexo");
                TipoSexo sexo;
                if (sexoC == 'M') sexo = TipoSexo.Hombre;
                else if (sexoC == 'F') sexo = TipoSexo.Mujer;
                else sexo = TipoSexo.Personalizado;
                string correo = lector.GetString("correoElectronico");
                //Lectura de datos del usuario
                int idUsuario = lector.GetInt32("IdUsuario");
                DateTime fechaCreacion = lector.GetDateTime("fechaCreacion");
                int nivelPermiso = lector.GetInt32("nivelPermiso");
                //Creacion del usuario
                Usuario usu = new Usuario(dni, nombres, apellPat, apellMat, celular, sexo, correo, fechaCreacion, nivelPermiso);
                usu.IdPersona1 = idPersona;
                usu.IdUsuario1 = idUsuario;
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
                return usu.NivelPermiso;
            } catch (Exception)
            {
                //En caso no haya encontrado la cuenta asociada
                con.Close();
                return -1;
            }            
        }
    }
}
