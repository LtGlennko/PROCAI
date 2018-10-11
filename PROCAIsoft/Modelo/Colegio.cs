using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Colegio
    {
        protected static int i = 0;
        private int IdColegio;
        private string RUC;
        private string nombre;
        private string pais;
        private string departamento;
        private string provincia;
        private string distrito;
        private string direccion;
        private TipoColegio tipo;
        private int telefonoContacto;
        private List<Orientador> orientadores;
        private List<Escolar> escolares;
        private List<GrupoEncuestas> encuestasLlenadas;

        public Colegio(int id,string rUC, string nombre, string pais, string departamento, string provincia/*, string distrito*/, string direccion, TipoColegio tipo, int telefonoContacto)
        {
            IdColegio = id;
            RUC = rUC;
            this.nombre = nombre;
            this.pais = pais;
            this.departamento = departamento;
            this.provincia = provincia;
            //this.distrito = distrito;
            this.direccion = direccion;
            this.tipo = tipo;
            this.telefonoContacto = telefonoContacto;
            this.orientadores = new List<Orientador>();
            this.escolares = new List<Escolar>();
            this.encuestasLlenadas = new List<GrupoEncuestas>();
        }
        public Colegio( string rUC, string nombre, string pais, string departamento, string provincia/*, string distrito*/, string direccion, TipoColegio tipo, int telefonoContacto)
        {
            //IdColegio = id;
            RUC = rUC;
            this.nombre = nombre;
            this.pais = pais;
            this.departamento = departamento;
            this.provincia = provincia;
            //this.distrito = distrito;
            this.direccion = direccion;
            this.tipo = tipo;
            this.telefonoContacto = telefonoContacto;
            this.orientadores = new List<Orientador>();
            this.escolares = new List<Escolar>();
            this.encuestasLlenadas = new List<GrupoEncuestas>();
        }


        public int IdColegio1 { get => IdColegio; set => IdColegio = value; }
        public string RUC1 { get => RUC; set => RUC = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        public string Distrito { get => distrito; set => distrito = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public TipoColegio Tipo { get => tipo; set => tipo = value; }
        public int TelefonoContacto { get => telefonoContacto; set => telefonoContacto = value; }
        public List<Orientador> Orientadores { get => orientadores; set => orientadores = value; }
        public List<Escolar> Escolares { get => escolares; set => escolares = value; }
        public List<GrupoEncuestas> EncuestasLlenadas { get => encuestasLlenadas; set => encuestasLlenadas = value; }

        public void addOrientador(Orientador ori)
        {
            this.orientadores.Add(ori);
            ori.Colegio = this;
        }
        public void addEscolar(Escolar esc)
        {
            this.escolares.Add(esc);
            esc.Colegio = this;
        }

        public void addGrupoEncuestas(GrupoEncuestas gru)
        {
            this.encuestasLlenadas.Add(gru);
            gru.Colegio = this;
        }
    }
}
