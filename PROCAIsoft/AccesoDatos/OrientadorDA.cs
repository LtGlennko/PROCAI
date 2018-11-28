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
    public class OrientadorDA
    {
        private MySqlConnection con;
        MySqlCommand comando;
        //public int registrarEscolar(Orientador O)
        //{
        //    con = new MySqlConnection(DBManager.cadena);
        //    con.Open();
        //    MySqlCommand comando = new MySqlCommand();
        //    comando.Connection = con;
        //    try
        //    {
        //        comando.CommandText = "REGISTRAR_ESCOLAR";
        //        comando.CommandType = System.Data.CommandType.StoredProcedure;
        //        comando.Parameters.Add("_IdPersona", MySqlDbType.Int32).Value = E.IdEscolar1;
        //        comando.Parameters.Add("_fechaCreacion", MySqlDbType.Date).Value = E.FechaCreacion;
        //        int nroGrado = 3;
        //        if (E.Grado == TipoGrado.Cuarto) nroGrado = 4;
        //        if (E.Grado == TipoGrado.Quinto) nroGrado = 5;
        //        comando.Parameters.Add("_Grado", MySqlDbType.Int32).Value = nroGrado;
        //        comando.Parameters.Add("_telefonoApoderado", MySqlDbType.Int32).Value = E.TelefonoApoderado;
        //        comando.Parameters.Add("_IdColegio", MySqlDbType.Int32).Value = E.Colegio.IdColegio1;
        //        comando.ExecuteNonQuery();
        //        con.Close();
        //        return 1;
        //    }
        //    catch (Exception)
        //    {
        //        con.Close();
        //        return 0;
        //    }
        //}
        public BindingList<Orientador> listarOrientadores()
        {
            BindingList<Orientador> orientadores = new BindingList<Orientador>();
            con = new MySqlConnection(DBManager.cadena);
            con.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = con;
                comando.CommandText = "CALL LISTAR_ORIENTADORES";
                MySqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    int idPersona = lector.GetInt32("IdPersona");
                    string dni = lector.GetString("DNI");
                    string nombres = lector.GetString("nombres");
                    string apellidoPaterno = lector.GetString("apellidoPaterno");
                    string apellidoMaterno = lector.GetString("apellidoMaterno");

                    string sexoStr = lector.GetString("sexo");
                    TipoSexo sexo;
                    if (sexoStr == "M") sexo = TipoSexo.Hombre;
                    if (sexoStr == "F") sexo = TipoSexo.Mujer;
                    else sexo = TipoSexo.Personalizado;

                    //Crea un orientadore
                    Orientador o = new Orientador(dni, nombres, apellidoPaterno, apellidoMaterno, 0, sexo, "", DateTime.MinValue, 2);
                    o.IdPersona1 = o.IdUsuario1 = o.IdOrientador1 = idPersona;

                    int idColegio = lector.GetInt32("IdColegio");
                    string nombColegio = lector.GetString("nombre");

                    //Crea el escolar
                    Colegio c = new Colegio("", nombColegio, "", "", "", "", TipoColegio.Estatal, 0);
                    c.IdColegio1 = idColegio;

                    //Asignar el colegio al orientador
                    o.Colegio = c;

                    orientadores.Add(o);
                }
                con.Close();
            }
            catch (Exception)
            {
                con.Close();
            }
            return orientadores;
        }
    }
}
