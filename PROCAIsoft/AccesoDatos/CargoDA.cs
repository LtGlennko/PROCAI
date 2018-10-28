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
    public class CargoDA
    {
        private MySqlConnection con;
        MySqlCommand comando;
        String sql;
        public BindingList<Cargo> listaCargos()
        {
            BindingList<Cargo> cargos = new BindingList<Cargo>();
            con = new MySqlConnection(DBManager.cadena);
            con.Open();
            comando = new MySqlCommand();
            sql = "SELECT * FROM Cargo;";
            comando.CommandText = sql;
            comando.Connection = con;
            MySqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                //Lectura de datos del cargo
                int idCargo = lector.GetInt32("IdCargo");
                string nomCargo = lector.GetString("nombreCargo");
                //Creacion del cargo
                Cargo c = new Cargo(nomCargo);
                c.IdCargo1 = idCargo;
                //Agregamos el cargo a la lista
                cargos.Add(c);
            }
            con.Close();
            return cargos;
        }
    }
}
