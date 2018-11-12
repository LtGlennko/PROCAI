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
    public class ActividadDA
    {
        private MySqlConnection con;
        MySqlCommand comando;
        string sql;
        public BindingList<Actividad> listarActividades()
        {
            BindingList<Actividad> actividades = new BindingList<Actividad>();
            try
            {
                con = new MySqlConnection(DBManager.cadena);
                con.Open();
                comando = new MySqlCommand();
                sql = "SELECT A.IdActividad, A.fechaProgramada, A.cantEstudiantes, " +
                    "T.IdTipoActividad, T.Nombre, T.Descripcion, " +
                    "M.IdMerchandising, M.nombre AS nombreMerch, M.descripcion AS descripcionMerch, M.stock " +
                    "FROM Actividad A, Merchandising M, TipoActividad T " +
                    "WHERE estadoActividad = 1 AND A.IdMerchandising = M.IdMerchandising AND A.IdTipoActividad = T.IdTipoActividad;";
                comando.CommandText = sql;
                comando.Connection = con;
                MySqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    //Leer datos de actividad
                    int idActividad = lector.GetInt32("IdActividad");
                    DateTime fechaProgramada = lector.GetDateTime("fechaProgramada");
                    int cantEstudiantes = lector.GetInt32("cantEstudiantes");
                    //Crear actividad
                    Actividad a = new Actividad(fechaProgramada, 1, cantEstudiantes);
                    a.IdActividad1 = idActividad;
                    //Leer datos de tipo actividad
                    int idTipoActividad = lector.GetInt32("IdTipoActividad");
                    string nombreTipoActividad = lector.GetString("Nombre");
                    string descripcion = lector.GetString("Descripcion");
                    //Crear tipo actividad
                    TipoActividad t = new TipoActividad(idTipoActividad, nombreTipoActividad, descripcion);
                    //Asignar tipo a la actividad
                    a.TipoActividad = t;
                    //Leer datos de merchandising
                    int idMerchandising = lector.GetInt32("IdMerchandising");
                    string nombreMerch = lector.GetString("nombreMerch");
                    string descripcionMerch = lector.GetString("descripcionMerch");
                    int stock = lector.GetInt32("stock");
                    //Crear merchandising
                    Merchandising m = new Merchandising(idMerchandising, nombreMerch, descripcionMerch, stock);
                    //Asignar merchandising a la actividad
                    a.MaterialRepartido = m;
                    actividades.Add(a);
                }
                con.Close();
            }
            catch (Exception e)
            {

            }
            return actividades;
        }
    }
}
