using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;


namespace AccesoDatos
{
    class ColegioDA
    {
        private SqlConnection con;
        public bool DBManagerRegistrarColegio(Colegio colegio)
        {
            try
            {
                con = new SqlConnection(DBManager.cadena);

                con.Open();
                SqlCommand comando = new SqlCommand();
                String sql = "INSERT INTO COLEGIO(RUC,nombre,pais,departamento,provincia,direccion,tipo,telefonoContacto) " +
                             "VALUES('" + colegio.RUC1 + "','" + colegio.Nombre + "','" +
                                            colegio.Pais + "','" + colegio.Departamento + "','" +
                                            colegio.Provincia + "','" + colegio.Direccion + "','" +
                                            colegio.Tipo + "'," + colegio.TelefonoContacto + ")";
                comando.CommandText = sql;
                comando.Connection = con;
                comando.ExecuteNonQuery();
                con.Close();
                return true;//succes
            }
            catch {
                return false;
            }
        }
    }
}
