using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using MySql.Data.MySqlClient;
using System.ComponentModel;

namespace AccesoDatos
{
    public class EncuestaDA
    {
        private MySqlConnection con;
        private MySqlCommand comando;
        private String sql;

        public BindingList<Encuesta> listarEncuestas()
        {
            BindingList<Encuesta> encuestas = new BindingList<Encuesta>();
            con = new MySqlConnection(DBManager.cadena);
            con.Open();
            comando = new MySqlCommand();
            sql = "SELECT IdEncuesta,Digitador,Calificaciones,GrupoPertenciente FROM Encuesta";
            comando.CommandText = sql;
            comando.Connection = con;
            MySqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                int idEncuesta = lector.GetInt32("IdEncuesta");
                //tipos especificos para los otros
                Encuesta e = new Encuesta(/* */);
                e.IdEncuesta1 = idEncuesta;
                encuestas.Add(e);
            }
            con.Close();
            return encuestas;
        }
        public bool registrarEncuesta (Encuesta E)
        {

            try
            {
                int Id_guia = 0;
                int Id_grupoEncuesta = E.GrupoPerteneciente.IdGrupoEncuestas1;
                con = new MySqlConnection(DBManager.cadena);

                con.Open();
                comando = new MySqlCommand();
                //aqui encuentro el ID del guia
                sql = "Select * from GrupoEncuesta GE, Guia G " +
                        " where GE.IdGrupoEncuesta = "+ Id_grupoEncuesta +
                        " and GE.IdGuia = G.IdGuia; ";

                comando.CommandText = sql;
                comando.Connection = con;

                MySqlDataReader lector = comando.ExecuteReader();
                //if(lector.Read())//s leyo el Id del guia (existe)
                //{
                ///    HASTQ AQUI YA FUNCIONA :D
                lector.Read();
                    Id_guia = lector.GetInt32("IdGuia");

                    string sql2 = "INSERT INTO `Encuesta`(`IdGrupoEncuesta`,`IdGuia`) " +
                             "VALUES("  + Id_grupoEncuesta   +","+ Id_guia + ")";


                    
                    comando.CommandText = sql2;
                    comando.Connection = con;
                    comando.ExecuteNonQuery();///AQUI SE CAE
                //}
                    
                //////////////////////////////////////////////////////////////
                ///

                









                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
