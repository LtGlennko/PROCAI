using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using MySql.Data.MySqlClient;
using System.ComponentModel;

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

        public BindingList<Colegio> listarColegio()
        {
            BindingList<Colegio> col = new BindingList<Colegio>();
            con = new MySqlConnection(DBManager.cadena);
            con.Open();
            comando = new MySqlCommand();
            sql = "SELECT IdColegio, RUC, nombre, pais, departamento, provincia,  direccion, tipo, telefonoContacto "
                + "FROM Colegio";
            comando.CommandText = sql;
            comando.Connection = con;
            MySqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                int idColegio = lector.GetInt32("IdColegio");
                string ruc = lector.GetString("RUC");
                string nombre = lector.GetString("nombre");
                string pais = lector.GetString("pais");
                string departamento = lector.GetString("departamento");
                string provincia = lector.GetString("provincia");
                string direccion = lector.GetString("direccion");
                string tipo = lector.GetString("tipo");
                int numero = lector.GetInt32("telefonoContacto");
                TipoColegio tc=new TipoColegio();
                if (tipo == "Estatal") tc = TipoColegio.Estatal;
                if (tipo == "Particular") tc = TipoColegio.Particular;
                Colegio c = new Colegio(idColegio,ruc,nombre,pais,departamento,provincia,direccion,tc,numero);
                col.Add(c);
            }
            con.Close();
            return col;
        }

    }
}
