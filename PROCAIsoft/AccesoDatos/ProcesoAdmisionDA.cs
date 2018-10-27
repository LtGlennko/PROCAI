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
    public class ProcesoAdmisionDA
    {
        public ProcesoAdmisionDA() {
            
        }
        public bool insertarProcesoAdmision(ProcesoAdmision PA)
        {
            bool success = false;
            DBManager DBM = new DBManager() ;
            bool coneccion = DBM.initialize_conection();
            if (coneccion)
            {
                //si se logro la conion
                //preparo los parametros entonces
                //MySqlParameter parameter_id = new MySqlParameter("IdProceso", MySqlDbType.Int32);
                MySqlParameter parameter_name = new MySqlParameter("nombre", MySqlDbType.VarChar);
                MySqlParameter parameter_fecha = new MySqlParameter("fecha", MySqlDbType.DateTime);
                MySqlParameter parameter_vacantes = new MySqlParameter("cantVacantes", MySqlDbType.Int32);
                MySqlParameter parameter_idtipo = new MySqlParameter("idTipo", MySqlDbType.Int32);
                MySqlParameter parameter_cantInscritos = new MySqlParameter("cantInscritos", MySqlDbType.Int32);

                //parameter_id.Value = PA.IdProceso1;
                parameter_name.Value = PA.NombreProceso;
                parameter_fecha.Value = PA.FechaRealizacion;
                parameter_vacantes.Value = PA.CantVacantes;
                parameter_idtipo.Value = PA.TipoProceso.IdTipoProceso1;
                parameter_cantInscritos.Value = PA.CantInscritos;
                /*
                 ...
                 */
                DBM.Comando.CommandType = System.Data.CommandType.StoredProcedure;
                DBM.Comando.CommandText = "insertarProcesoAdmision";
                //agrego los parametros
                //DBM.Comando.Parameters.Add(parameter_id);
                DBM.Comando.Parameters.Add(parameter_name);
                DBM.Comando.Parameters.Add(parameter_fecha);
                DBM.Comando.Parameters.Add(parameter_vacantes);
                DBM.Comando.Parameters.Add(parameter_idtipo);
                DBM.Comando.Parameters.Add(parameter_cantInscritos);
                //fin agregar parametros

                //ejecuto el procedure call
                DBM.Comando.ExecuteNonQuery();
                success = true;
                DBM.finalize_conection();
            }
            else {
                success = false;

            }
            return success;
        }

        public bool listarProcesosAdmision(BindingList<ProcesoAdmision> listaPA) {
            bool success = false;
            ProcesoAdmision PA;
            TipoProcesoAdmision TPA;
            DBManager DBM = new DBManager();
            bool coneccion = DBM.initialize_conection();
            if (coneccion)
            {
                // no rwquiee parametros
                DBM.Comando.CommandType = System.Data.CommandType.StoredProcedure;
                DBM.Comando.CommandText = "listarProcesosAdmision";

                MySqlDataReader lector = DBM.Comando.ExecuteReader();

                //inserto en el bindinglist, se supone que ya se envio inicializado, pero porciacaso
                //listaPA = new BindingList<ProcesoAdmision>();
                while (lector.Read()) {
                    TPA = new TipoProcesoAdmision();
                    TPA.NombreTipoProceso = lector.GetString("Tipo");
                    PA = new ProcesoAdmision();
                    PA.TipoProceso = TPA;

                    PA.IdProceso1 = lector.GetInt32("IdProceso");
                    PA.NombreProceso = lector.GetString("nombreProceso");
                    PA.FechaRealizacion = lector.GetDateTime("fechaRealizacion");
                    PA.CantVacantes = lector.GetInt32("cantVacantes");
                    PA.CantInscritos = lector.GetInt32("cantInscritos");
                    //agrego el objeto a la lista y paso al siguiente
                    listaPA.Add(PA);

                }


                success = true;
                DBM.finalize_conection();
            }
            else {
                success = false;
            }
            return success;
        }
    }
}
