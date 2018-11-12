using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Guia : TrabajadorOCAI
    {
        protected static int i = 0;
        private int IdGuia;
        private TipoGuia tipoGuia;
        private List<GrupoEncuestas> gruposDondeFueEvaluado;
        private List<Encuesta> encuestasDigitadas;

        public Guia(string dNI, string nombres, string apellidoPaterno, string apellidoMaterno, int celular, TipoSexo sexo, string correoElectronico, DateTime fechaCreacion, int nivelPermiso,  DateTime fechaIngreso, int estadoTrabajador, int telefonoOfi, int celularOfi, string correOfi, TipoGuia tipoGuia, string licencia) : base(dNI, nombres, apellidoPaterno, apellidoMaterno, celular, sexo, correoElectronico, fechaCreacion, nivelPermiso, fechaIngreso, telefonoOfi, celularOfi, correOfi)
        {
            IdGuia = ++i;
            this.tipoGuia = tipoGuia;
        }

        public Guia(Usuario usu, DateTime fechaIngreso, int telefonoOfi, int celularOfi, string correOfi, TipoGuia tipoGuia) : base(usu, fechaIngreso, telefonoOfi, celularOfi, correOfi)
        {
            IdGuia = ++i;
            this.tipoGuia = tipoGuia;
        }

        public int IdGuia1 { get => IdGuia; set => IdGuia = value; }
        public TipoGuia TipoGuia { get => tipoGuia; set => tipoGuia = value; }
        public List<GrupoEncuestas> GruposDondeFueEvaluado { get => gruposDondeFueEvaluado; set => gruposDondeFueEvaluado = value; }
        public List<Encuesta> EncuestasDigitadas { get => encuestasDigitadas; set => encuestasDigitadas = value; }
        public string NombresYapellidosGuia { get => NombresYapellidos; }
        public void addEncuestaDigitada(Encuesta enc)
        {
            this.encuestasDigitadas.Add(enc);
            enc.Digitador = this;
        }
        public void addGrupoDondeFueEvaluado(GrupoEncuestas gru)
        {
            this.gruposDondeFueEvaluado.Add(gru);
            gru.GuiaEvaluado = this;
        }
    }
}
