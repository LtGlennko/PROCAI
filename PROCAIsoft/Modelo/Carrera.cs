using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Carrera
    {
        private int IdCarrera;
        private string nombreCarrera;
        private List<PostulanteXprocesoAdmision> listaDeProcesos;

        public Carrera()
        {
            this.listaDeProcesos = null;
        }

        public Carrera(int idCarrera, string nombreCarrera, List<PostulanteXprocesoAdmision> listaDeProcesos)
        {
            this.IdCarrera = idCarrera;
            this.nombreCarrera = nombreCarrera;
            this.listaDeProcesos = listaDeProcesos;
        }

        ~Carrera()
        {
            System.Console.WriteLine("destructor");
        }

        public void setIdCarrera(int idCarrera)
        {
            this.IdCarrera = idCarrera;
        }

        public int getIdCarrera()
        {
            return IdCarrera;
        }

        public void setNombreCarrera(string nombreCarrera)
        {
            this.nombreCarrera = nombreCarrera;
        }

        public string getNombreCarrera()
        {
            return nombreCarrera;
        }



        public List<PostulanteXprocesoAdmision> getListaDeProcesos()
        {
            return listaDeProcesos;
        }

        public void setListaDeProcesos(List<PostulanteXprocesoAdmision> listaDeProcesos)
        {
            this.listaDeProcesos = listaDeProcesos;
        }


    }
}