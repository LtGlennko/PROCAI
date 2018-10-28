using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class TrabajadorOCAIDA
    {
        private MySqlConnection con;
        MySqlCommand comando;
        string sql;
        //Este metodo recibe como parametro de entrada un usuario y crea un nuevo guia usando las características de este
        public TrabajadorOCAI crearTrabajadorOCAI(Usuario usu)
        {
            con = new MySqlConnection(DBManager.cadena);
            con.Open();
            comando = new MySqlCommand();
            sql = "SELECT T.fechaIngreso, T.telefonoOfi, T.celularOfi, T.correOfi, C.IdCargo, C.NombreCargo " +
                "FROM TrabajadorOCAI T, Cargo C " +
                "WHERE C.IdCargo = T.IdCargo AND IdTrabajadorOCAI = " + usu.IdUsuario1 + ";";
            comando.CommandText = sql;
            comando.Connection = con;
            MySqlDataReader lector = comando.ExecuteReader();
            try
            {
                lector.Read();
                //Lectura de datos del trabajadorOCAI
                DateTime fechaIn = lector.GetDateTime("fechaIngreso");
                int tlfOfi = 0;
                if (!lector.IsDBNull(1)) tlfOfi = lector.GetInt32("telefonoOfi");
                int celOfi = 0;
                if (!lector.IsDBNull(2)) celOfi = lector.GetInt32("celularOfi");
                string corOfi = "";
                if (!lector.IsDBNull(3)) corOfi = lector.GetString("correOfi");
                //Creacion del trabajadorOCAI
                TrabajadorOCAI t = new TrabajadorOCAI(usu, fechaIn, tlfOfi, celOfi, corOfi);
                t.IdTrabajadorOCAI1 = usu.IdUsuario1;
                //Lectura de datos su cargo
                int idCarg = lector.GetInt32("IdCargo");
                string nomCarg = lector.GetString("NombreCargo");
                if ((usu.NivelPermiso == 2 && nomCarg != "Guia") || (usu.NivelPermiso == 3 && nomCarg != "Administrativo") || (usu.NivelPermiso == 4 && nomCarg != "Ejecutivo"))
                {
                    //En caso el trabajadorOCAI no presente el cargo correcto
                    con.Close();
                    return null;
                }
                Cargo c = new Cargo(nomCarg);
                c.IdCargo1 = idCarg;
                //Asignacion del cargo
                t.Cargo = c;
                con.Close();
                return t;
            }
            catch (Exception)
            {
                //En caso no haya leido bien los datos del trabajadorOCAI
                con.Close();
                return null;
            }
        }
    }
}
