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
    public class SolicitudInscripcionDA
    {
        public bool listarSolicitudInscripcionActividad(BindingList<SolicitudInscripcionActividad> listaSIA)
        {
            bool success = false;

            SolicitudInscripcionActividad SIA;
            TipoActividad TA;
            Actividad A;
            Orientador O;
            Colegio C;
            

            //coneccion DataBase
            DBManager DBM = new DBManager();
            bool coneccion = DBM.initialize_conection();
            if (coneccion)
            {
                // no rwquiee parametros
                DBM.Comando.CommandType = System.Data.CommandType.StoredProcedure;
                DBM.Comando.CommandText = "listarSoicitudesInscripcionActividades_all";

                MySqlDataReader lector = DBM.Comando.ExecuteReader();

                //inserto en el bindinglist, se supone que ya se envio inicializado, pero porciacaso
                //listaPA = new BindingList<ProcesoAdmision>();
                while (lector.Read())
                {

                    O = new Orientador(
                        lector.GetString("dni"), lector.GetString("nombreOrientador"),
                        lector.GetString("apPaterno"),
                        lector.GetString("apMaterno"),
                        lector.GetInt32("celular"),
                        lector.GetString("sexo").Equals("M") ? TipoSexo.Hombre : TipoSexo.Mujer,
                        lector.GetString("email"),
                        new DateTime(), 1);
                    O.IdOrientador1 = lector.GetInt32("IdOrientador");

                    TA = new TipoActividad(lector.GetString("nombreTA"), lector.GetString("descTA"));
                    TA.IdTipoActividad1 = lector.GetInt32("IdTipoActividad");


                    A = new Actividad(lector.GetDateTime("fechaActividad"),1, lector.GetInt32("cantEstudiantes")) ;
                    A.IdActividad1 = lector.GetInt32("IdActividad");


                    

                    A.TipoActividad = TA;

                    

                    C = new Colegio(
                        lector.GetInt32("IdColegio"),
                        lector.GetString("ruc"),
                        lector.GetString("nombreColegio"),
                        lector.GetString("pais"),
                        lector.GetString("departamento"),
                        lector.GetString("provincia"),
                        lector.GetString("direccion"),
                        lector.GetString("tipoColegio").Equals("Particular") ? TipoColegio.Particular : TipoColegio.Estatal,
                        lector.GetInt32("telefono")
                        );
                    // TipoAct -> Act
                    // Act, Orient, Col  ->  Slicitud
                    //ahora todo lo levo dentro del registro Solicitud
                    SIA = new SolicitudInscripcionActividad(
                        lector.GetInt32("cantAlumnos"),
                        lector.GetInt32("grado"),
                        lector.GetDateTime("fecha"),
                        O,
                        C,
                        A,
                        lector.GetString("EstadoValidacion")
                    );
                    SIA.IdSolicitudInscripcion1 = lector.GetInt32("IdSolicitudInscripcion");

                    listaSIA.Add(SIA);


                }


                success = true;
                DBM.finalize_conection();
            }
            else
            {
                success = false;
            }
            return success;
        }


        public bool validarSolicitudInscripcionActividad(SolicitudInscripcionActividad SI, int validacion)
        {
            bool success = false;
            
            //coneccion DataBase
            DBManager DBM = new DBManager();
            bool coneccion = DBM.initialize_conection();
            if (coneccion)
            {
                
                MySqlParameter parameter_id = new MySqlParameter("IdSolicitud", MySqlDbType.Int32);
                MySqlParameter parameter_fp = new MySqlParameter("fechaProgramada", MySqlDbType.Datetime);//most important
                MySqlParameter parameter_ea = new MySqlParameter("estadoActividad", MySqlDbType.Int32);
                MySqlParameter parameter_ce = new MySqlParameter("cantEstudiantes", MySqlDbType.Int32);
                MySqlParameter parameter_idTA = new MySqlParameter("IdTipoActividad", MySqlDbType.Int32);
                MySqlParameter parameter_idM = new MySqlParameter("IdMerchandising", MySqlDbType.Int32);

                parameter_id.Value = SI.IdSolicitudInscripcion1;
                parameter_fp.Value = SI.Fecha;
                parameter_ea.Value = 1;
                parameter_ce.Value = SI.CantAlumnos;
                parameter_idTA.Value = SI.Actividad.TipoActividad.IdTipoActividad1;
                parameter_idM.Value = 1;//SI.Actividad.MaterialRepartido.IdMerchandising1;

                DBM.Comando.CommandType = System.Data.CommandType.StoredProcedure;
                if(validacion==1)
                    DBM.Comando.CommandText = "ValidarSolicitudInscripcion";
                else if (validacion==0)
                    DBM.Comando.CommandText = "RechazarSolicitudInscripcion";

                //agrego los parametros
                //DBM.Comando.Parameters.Add(parameter_id);
                DBM.Comando.Parameters.Add(parameter_id);
                DBM.Comando.Parameters.Add(parameter_fp);
                DBM.Comando.Parameters.Add(parameter_ea);
                DBM.Comando.Parameters.Add(parameter_ce);
                DBM.Comando.Parameters.Add(parameter_idTA);
                DBM.Comando.Parameters.Add(parameter_idM);

                //ejecuto el procedure call
                DBM.Comando.ExecuteNonQuery();

                success = true;
                DBM.finalize_conection();
            }
            else
            {
                success = false;
            }
            return success;
        }
    }
}
