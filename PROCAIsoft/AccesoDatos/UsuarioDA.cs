﻿using Modelo;
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

        //SOLO FUNCIONA CON LOS QUE TIENEN CUENTA
        public BindingList<Usuario> listarUsuarios()
        {
            BindingList<Usuario> usuarios = new BindingList<Usuario>();
            con = new MySqlConnection(DBManager.cadena);
            con.Open();
            comando = new MySqlCommand();
            sql = "SELECT P.IdPersona, P.DNI, P.Nombres, P.ApellidoPaterno," +
                " P.ApellidoMaterno, P.celular, P.sexo, P.correoElectronico, " +
                "U.fechaCreacion, U.nivelPermiso, C.IdCuenta, C.ultimaConexion, " +
                "C.nombreDeUsuario, C.contrasena FROM Usuario U " +
                "JOIN Persona P ON P.IdPersona = U.IdUsuario " +
                "JOIN Cuenta C ON C.IdUsuario = U.IdUsuario ORDER BY 9 DESC;";
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
                DateTime fechaCreacion = lector.GetDateTime("fechaCreacion");
                int nivelPermiso = lector.GetInt32("nivelPermiso");
                //Creacion del usuario
                Usuario usu = new Usuario(dni, nombres, apellPat, apellMat, celular, sexo, correo, fechaCreacion, nivelPermiso);
                usu.IdPersona1 = usu.IdUsuario1 = idPersona;
                //Lectura de datos de la cuenta
                int idCuenta = lector.GetInt32("IdCuenta");
                string nombreUsuario = lector.GetString("nombreDeUsuario");
                string contrasena = lector.GetString("contrasena");
                //Creacion de la cuenta
                Cuenta cue = new Cuenta(DateTime.Now, nombreUsuario, contrasena);
                //Asigamos cuenta al usuario
                usu.setCuenta(cue);
                //Agregamos el usuario a la lista solo si es guia, ejecutivo o administrativo
                if(usu.NivelPermiso >= 2) usuarios.Add(usu);
            }
            con.Close();
            return usuarios;
        }

        public BindingList<Usuario> listarUsuariosSinGestionador(int idJefe)
        {
            BindingList<Usuario> usuarios = new BindingList<Usuario>();
            con = new MySqlConnection(DBManager.cadena);
            con.Open();
            comando = new MySqlCommand();
            sql = "SELECT P.IdPersona, P.DNI, P.Nombres, P.ApellidoPaterno," +
                " P.ApellidoMaterno, P.celular, P.sexo, P.correoElectronico, " +
                "U.fechaCreacion, U.nivelPermiso, C.IdCuenta, C.ultimaConexion, " +
                "C.nombreDeUsuario, C.contrasena FROM Usuario U " +
                "JOIN Persona P ON P.IdPersona = U.IdUsuario " +
                "JOIN Cuenta C ON C.IdUsuario = U.IdUsuario " +
                "WHERE IdPersona <> " + idJefe + " ORDER BY 9 DESC;";
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
                DateTime fechaCreacion = lector.GetDateTime("fechaCreacion");
                int nivelPermiso = lector.GetInt32("nivelPermiso");
                //Creacion del usuario
                Usuario usu = new Usuario(dni, nombres, apellPat, apellMat, celular, sexo, correo, fechaCreacion, nivelPermiso);
                usu.IdPersona1 = usu.IdUsuario1 = idPersona;
                //Lectura de datos de la cuenta
                int idCuenta = lector.GetInt32("IdCuenta");
                string nombreUsuario = lector.GetString("nombreDeUsuario");
                string contrasena = lector.GetString("contrasena");
                //Creacion de la cuenta
                Cuenta cue = new Cuenta(DateTime.Now, nombreUsuario, contrasena);
                //Asigamos cuenta al usuario
                usu.setCuenta(cue);
                //Agregamos el usuario a la lista solo si es guia, ejecutivo o administrativo
                if (usu.NivelPermiso >= 2) usuarios.Add(usu);
            }
            con.Close();
            return usuarios;
        }

        public Usuario buscarUsuario(string username, string password)
        {
            con = new MySqlConnection(DBManager.cadena);
            con.Open();
            comando = new MySqlCommand();
            sql = "SELECT P.IdPersona, P.DNI, P.Nombres, P.ApellidoPaterno," +
                " P.ApellidoMaterno, P.celular, P.sexo, P.correoElectronico, " +
                "U.fechaCreacion, U.nivelPermiso, C.IdCuenta, C.ultimaConexion, " +
                "C.nombreDeUsuario, C.contrasena FROM Usuario U " +
                "JOIN Persona P ON P.IdPersona = U.IdUsuario " +
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
                DateTime fechaCreacion = lector.GetDateTime("fechaCreacion");
                int nivelPermiso = lector.GetInt32("nivelPermiso");
                //Creacion del usuario
                Usuario usu = new Usuario(dni, nombres, apellPat, apellMat, celular, sexo, correo, fechaCreacion, nivelPermiso);
                usu.IdPersona1 = usu.IdUsuario1 = idPersona;
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
                return usu;
            } catch (Exception)
            {
                //En caso no haya encontrado la cuenta asociada
                con.Close();                
                return null;
            }            
        }
        public bool actualizarNivelPermiso(int idUsuario, int nivelPermiso)
        {
            con = new MySqlConnection(DBManager.cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = con;
            try
            {
                comando.CommandText = "ACTUALIZAR_NIVEL_PERMISO";
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("_IdUsuario", MySqlDbType.Int32).Value = idUsuario;
                comando.Parameters.Add("_nivelPermiso", MySqlDbType.Int32).Value = nivelPermiso;
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
