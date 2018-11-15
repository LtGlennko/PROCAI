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
    }
}
