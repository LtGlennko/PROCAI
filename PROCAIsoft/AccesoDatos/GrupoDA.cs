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
        public BindingList<BuscarGrupoEncuesta> listarGrupo(){
            BindingList<BuscarGrupoEncuesta> grupos = new BindingList<BuscarGrupoEncuesta>();
            MySqlConnection con = new MySqlConnection(DBManager.cadena);
            MySqlCommand comando = new MySqlCommand();
            con.Open();
            String sql = "SELECT GR.IdGrupoEncuesta as ID_GRUPOENCUESTA, AC.fechaProgramada as FECHA, C.nombre as NOMBRE_COLEGIO, T.Nombre as TIPODEACTIVIDAD, P.nombres as NOMBREGUIA, P.apellidoMaterno as APELLIDOMATERNOGUIA, P.apellidoPaterno as APELLIDOPATERNOGUIA FROM GrupoEncuesta GR, Actividad AC, Guia G, Colegio C, TipoActividad T, Persona P where GR.IdActividad = AC.IdActividad and GR.IdGuia = G.IdGuia and GR.IdColegio = C.IdColegio and T.IdTipoActividad = AC.IdTipoActividad and G.IdPersona = P.IdPersona; ";
            comando.CommandText = sql;
            comando.Connection = con;

            MySqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                BuscarGrupoEncuesta grupo = new BuscarGrupoEncuesta();
                grupo.Colegio = lector.GetString("NOMBRE_COLEGIO");
                grupo.Guia_apellidom = lector.GetString("APELLIDOMATERNOGUIA");
                grupo.Guia_apellidop = lector.GetString("APELLIDOPATERNOGUIA");
                grupo.Guia_nombre = lector.GetString("NOMBRE_GUIA");
                grupo.IdGrupo1 = lector.GetInt32("ID_GRUPOENCUESTA");
                grupo.TipoActividad = lector.GetString("TIPODEACTIVIDAD");
                grupo.Fecha = lector.GetDateTime("FECHA");

                grupos.Add(grupo);
            }
           
            return grupos;
        }
    }
}
