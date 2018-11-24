using AccesoDatos;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace LogicaNegocio
{
    public class ColegioBL
    {
        private ColegioDA colegioDA;
        public ColegioBL()
        {
            colegioDA = new ColegioDA();
        }

        public bool eliminarColegio(int id)
        {
            return colegioDA.eliminarColegio(id);
        }

        public bool registrarColegio(Colegio colegio)
        {
            return colegioDA.registrarColegio(colegio);
        }

        public BindingList<Colegio> listarColegios()
        {
            return colegioDA.listarColegio();
        }

        public BindingList<Colegio> buscarColegio(string pista)
        {
            return colegioDA.buscarColegio(pista);
        }

        public BindingList<Colegio> buscarColegioId(int id)
        {
            return colegioDA.buscarColegioId(id);
        }
        public BindingList<Colegio> buscarColegioRUC(string pista)
        {
            return colegioDA.buscarColegioRUC(pista);
        }
        public BindingList<Colegio> buscarColegioDir(string pista)
        {
            return colegioDA.buscarColegioDir(pista);
        }
    }
     
}
