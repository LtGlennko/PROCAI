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
    public class TipoProcesoAdmisionDA
    {
        public bool listarTipoProcesos(BindingList<TipoProcesoAdmision> listaTPA) {
            bool success = false;
            TipoProcesoAdmision TPA;
            DBManager DBM = new DBManager();
            bool coneccion = DBM.initialize_conection();
            if (coneccion)
            {
                // no rwquiee parametros
                DBM.Comando.CommandType = System.Data.CommandType.StoredProcedure;
                DBM.Comando.CommandText = "listarTipoProcesoAdmision";

                MySqlDataReader lector = DBM.Comando.ExecuteReader();

                //inserto en el bindinglist, se supone que ya se envio inicializado, pero porciacaso
                //listaTPA = new BindingList<TipoProcesoAdmision>();
                while (lector.Read())
                {
                    TPA = new TipoProcesoAdmision();
                    

                    TPA.IdTipoProceso1 = lector.GetInt32("IdTipoProcesoAdmision");
                    TPA.NombreTipoProceso = lector.GetString("nombreTipoProceso");
                    //TPA.Descripcion = lector.GetString("descripcion");
                    //agrego el objeto a la lista y paso al siguiente
                    listaTPA.Add(TPA);

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
