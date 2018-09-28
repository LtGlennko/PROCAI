using System;
using System.Collections.Generic;
namespace Modelo
{
    public class Escolar : Usuario
    {
        private int IdEscolar;
        private List<Colegio> colegio;
        private string Grado;
        private int telefonoApoderado;

        public Escolar(DateTime fechaCreacion, int nivelPermiso, int idEscolar, List<Colegio> colegio, string grado, int telefonoApoderado)
                                   : base(fechaCreacion, nivelPermiso)
        {
            IdEscolar = idEscolar;
            this.colegio = colegio ?? throw new ArgumentNullException(nameof(colegio));
            Grado = grado ?? throw new ArgumentNullException(nameof(grado));
            this.telefonoApoderado = telefonoApoderado;
        }

        //Constructadores




    }
}