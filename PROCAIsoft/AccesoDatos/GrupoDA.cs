using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using MySql.Data.MySqlClient;

//PARA LA VENTANA BUSCAR GROUPO, DE VISUALIZAR ENCUESTA

namespace AccesoDatos
{
    public class GrupoDA
    {
        private MySqlConnection con;
        MySqlCommand comando;
        String sql;
        public BindingList<GrupoEncuestas> listarGrupos(){
            BindingList<GrupoEncuestas> grupos = new BindingList<GrupoEncuestas>();
            con = new MySqlConnection(DBManager.cadena);
            comando = new MySqlCommand();
            con.Open();
            sql = "SELECT GE.IdGrupoEncuesta, " +
                        "A.IdActividad, " +
                        "A.fechaProgramada, " +
                        "A.estadoActividad, " +
                        "A.cantEstudiantes, " +
                        "TA.IdTipoActividad, " +
                        "TA.Nombre, " +
                        "TA.descripcion " +
                        "FROM GrupoEncuesta GE, Actividad A, TipoActividad TA " +
                        "WHERE GE.IdActividad = A.IdActividad AND " +
                        "A.IdTipoActividad = TA.IdTipoActividad;";
            comando.CommandText = sql;
            comando.Connection = con;

            MySqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                //BuscarGrupoEncuesta grupo = new BuscarGrupoEncuesta(); NO ES NECESARIO
                //Leer Id del grupo de encuestas
                int idGrupoEncuesta = lector.GetInt32("IdActividad");
                //Crear grupo de encuestas
                GrupoEncuestas grupo = new GrupoEncuestas();
                grupo.IdGrupoEncuestas1 = idGrupoEncuesta;
                //Leer datos de actividad
                int idActividad = lector.GetInt32("IdActividad");
                DateTime fechaProgram = lector.GetDateTime("fechaProgramada");
                int estadoActividad = lector.GetInt32("estadoActividad");
                int cantEstudiantes = lector.GetInt32("cantEstudiantes");
                //Crear actividad
                Actividad actividad = new Actividad(fechaProgram, estadoActividad, cantEstudiantes);
                actividad.IdActividad1 = idActividad;
                //Leer datos de tipo actividad
                int idTipoActividad = lector.GetInt32("IdTipoActividad");
                string nombreTipoAct = lector.GetString("Nombre");
                string descTipoAct = lector.GetString("descripcion");
                //Crear tipo actividad
                TipoActividad tipoAct = new TipoActividad(nombreTipoAct, descTipoAct);
                tipoAct.IdTipoActividad1 = idTipoActividad;
                //Devolver lista de preguntas según el id del tipo de actividad
                PreguntaDA preguntaDA = new PreguntaDA();
                BindingList<Pregunta> listaPreguntas = preguntaDA.listaPreguntasSegunActividad(idTipoActividad);
                //Agregar lista al tipo de actividad
                tipoAct.Preguntas = listaPreguntas;
                //Asignar tipo actividad a actividad y grupo de encuestas a actividad
                actividad.setTipoActividad(tipoAct);
                grupo.setActividad(actividad);
                //Agregar grupo a la lista
                grupos.Add(grupo);
            }
           
            return grupos;
        }
    }
}
