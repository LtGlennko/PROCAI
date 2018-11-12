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
                        "GE.idGuia, P.nombres, " +
                        "P.apellidoPaterno, " +
                        "P.apellidoMaterno, " +
                        "A.IdActividad, " +
                        "A.fechaProgramada, " +
                        "A.estadoActividad, " +
                        "A.cantEstudiantes, " +
                        "TA.IdTipoActividad, " +
                        "TA.Nombre, " +
                        "TA.descripcion, " +
                        "GE.IdColegio " +
                        "FROM GrupoEncuesta GE, Actividad A, TipoActividad TA, Persona P " +
                        "WHERE GE.IdActividad = A.IdActividad AND " +
                        "A.IdTipoActividad = TA.IdTipoActividad AND " +
                        "GE.IdGuia = P.IdPersona;";
            comando.CommandText = sql;
            comando.Connection = con;

            MySqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                //BuscarGrupoEncuesta grupo = new BuscarGrupoEncuesta(); NO ES NECESARIO
                //Leer Id del grupo de encuestas
                int idGrupoEncuesta = lector.GetInt32("IdGrupoEncuesta");
                //Crear grupo de encuestas
                GrupoEncuestas grupo = new GrupoEncuestas();
                grupo.IdGrupoEncuestas1 = idGrupoEncuesta;
                //Crear guia evaluado
                int idGuia = lector.GetInt32("IdGuia");
                string nombres = lector.GetString("Nombre");
                string apellidoPaterno = lector.GetString("apellidoPaterno");
                string apellidoMaterno = lector.GetString("apellidoMaterno");
                //Creamos un nuevo guia para mostrar, solo importan sus nombres  y su id
                Guia g = new Guia("", nombres, apellidoPaterno, apellidoMaterno, 0, TipoSexo.Personalizado, "", DateTime.MinValue, 0, DateTime.MinValue, 1, 0, 0, "", TipoGuia.Inscriptor, "");
                g.IdGuia1 = g.IdUsuario1 = g.IdPersona1 = idGuia;
                grupo.GuiaEvaluado = g;
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
                //Leer id de colegio
                int idColegio = lector.GetInt32("IdColegio");
                //Buscar colegio
                ColegioDA colegioDA = new ColegioDA();
                Colegio col = colegioDA.buscarColegioPorID(idColegio);
                //Asignar colegio a grupo
                grupo.Colegio = col;
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
