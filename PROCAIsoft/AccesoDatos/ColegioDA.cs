using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class ColegioDA
    {
        private MySqlConnection con;
        MySqlCommand comando;
        String sql;
        public bool registrarColegio(Colegio colegio)
        {
            try
            {
                con = new MySqlConnection(DBManager.cadena);
                con.Open();
                comando = new MySqlCommand();
                string tipoStr = "No definido";
                if (colegio.Tipo == TipoColegio.Estatal) tipoStr = "Estatal";
                else if (colegio.Tipo == TipoColegio.Particular) tipoStr = "Particular";
                sql = "INSERT INTO Colegio(RUC,nombre,pais,departamento,provincia,direccion,tipo,telefonoContacto) " +
                             "VALUES('" + colegio.RUC1 + "','" + colegio.Nombre + "','" +
                                            colegio.Pais + "','" + colegio.Departamento + "','" +
                                            colegio.Provincia + "','" + colegio.Direccion + "','" +
                                            tipoStr + "'," + colegio.TelefonoContacto + ")";
                comando.CommandText = sql;
                comando.Connection = con;
                comando.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch {
                return false;
            }
        }


        
    }
}
