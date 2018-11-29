using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ResultadoGuia
    {
        private string nombreCompleto;
        private double promedio;
        private int nroEncuestas;

        public ResultadoGuia(string nom, double prom, int nroEnc)
        {
            nombreCompleto = nom;
            promedio = prom;
            nroEncuestas = nroEnc;
        }

        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public double Promedio { get => promedio; set => promedio = value; }
        public int NroEncuestas { get => nroEncuestas; set => nroEncuestas = value; }
    }
}
