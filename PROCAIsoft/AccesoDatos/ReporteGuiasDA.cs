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
    public class ReporteGuiasDA
    {
        private MySqlConnection con;
        public BindingList<ResultadoGuia> listarResultadosGuia()
        {
            BindingList<ResultadoGuia> resultados = new BindingList<ResultadoGuia>();
            con = new MySqlConnection(DBManager.cadena);
            con.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = con;
                comando.CommandText = "CALL REPORTE_GUIAS";
                MySqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    string nom = lector.GetString("nombres");
                    string apP = lector.GetString("apellidoPaterno");
                    string apM = lector.GetString("apellidoMaterno");
                    double prom = lector.GetDouble("promedio");
                    int nEnc = lector.GetInt32("nroEncuestas");

                    //Crea una linea del reporte
                    ResultadoGuia r = new ResultadoGuia(nom + " " + apP + " " + apM, prom, nEnc);

                    resultados.Add(r);
                }
                con.Close();
                return resultados;
            }
            catch (Exception)
            {
                con.Close();
                return resultados;
            }
            
        }
    }
}
