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
    public class EscolarDA
    {
        private MySqlConnection con;
        MySqlCommand comando;
        public int registrarEscolar(Escolar E)
        {
            con = new MySqlConnection(DBManager.cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = con;
            try
            {
                comando.CommandText = "REGISTRAR_ESCOLAR";
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("_IdPersona", MySqlDbType.Int32).Value = E.IdEscolar1;
                comando.Parameters.Add("_fechaCreacion", MySqlDbType.Date).Value = E.FechaCreacion;
                int nroGrado = 3;
                if (E.Grado == TipoGrado.Cuarto) nroGrado = 4;
                if (E.Grado == TipoGrado.Quinto) nroGrado = 5;
                comando.Parameters.Add("_Grado", MySqlDbType.Int32).Value = nroGrado;
                comando.Parameters.Add("_telefonoApoderado", MySqlDbType.Int32).Value = E.TelefonoApoderado;
                comando.Parameters.Add("_IdColegio", MySqlDbType.Int32).Value = E.Colegio.IdColegio1;
                comando.ExecuteNonQuery();
                con.Close();
                return 1;
            }
            catch (Exception)
            {
                con.Close();
                return 0;
            }
        }

        public BindingList<Escolar> listarEscolares()
        {
            BindingList<Escolar> escolares = new BindingList<Escolar>();
            con = new MySqlConnection(DBManager.cadena);
            con.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = con;
                comando.CommandText = "CALL LISTAR_ESCOLARES";
                MySqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    string dni = lector.GetString("DNI");
                    string nombres = lector.GetString("nombres");
                    string apellidoPaterno = lector.GetString("apellidoPaterno");
                    string apellidoMaterno = lector.GetString("apellidoMaterno");

                    string sexoStr = lector.GetString("sexo");
                    TipoSexo sexo;
                    if (sexoStr == "M") sexo = TipoSexo.Hombre;
                    if (sexoStr == "F") sexo = TipoSexo.Mujer;
                    else sexo = TipoSexo.Personalizado;

                    int gradoInt = lector.GetInt32("Grado");
                    TipoGrado grado;
                    if (gradoInt == 3) grado = TipoGrado.Tercero;
                    if (gradoInt == 4) grado = TipoGrado.Cuarto;
                    else grado = TipoGrado.Quinto;

                    //int nCalif = lector.GetInt32("nCalif");
                    ////Verifica que la encuesta sea válida (posee cierto número de calificaciones registradas)
                    ////Creamos la encuesta
                    //if (nCalif == N_PREGUNTAS)
                    //{
                    //    Encuesta e = new Encuesta();
                    //    e.IdEncuesta1 = idEncuesta;
                    //    e.GrupoPerteneciente = G;
                    //    escolares.Add(e);
                    //}
                }
                con.Close();
            }
            catch (Exception)
            {
                con.Close();
            }
            return escolares;
        }
    }
}
