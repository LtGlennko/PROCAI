using System;
namespace Modelo
{
    public class ProcesoAdmision
    {
        private static int ID=0;
        private int IdProceso;
        private string NombreProceso;
        private string descripcion;
        private DateTime fechaCreacion;
        private int estaVigente; //1 = existe, 0 = ya no existe
        private int cantidadVacantes;
        //Constructador
        public ProcesoAdmision()
        {
            ID++;
            this.IdProceso = ID;
        }

        public ProcesoAdmision(int idProceso, string nombreProceso, string descripcion, DateTime fechaCreacion, int estaVigente, int cantidadVacantes)
        {
            IdProceso = idProceso;
            NombreProceso = nombreProceso;
            this.descripcion = descripcion;
            this.fechaCreacion = fechaCreacion;
            this.estaVigente = estaVigente;
            this.cantidadVacantes = cantidadVacantes;
        }

        public static int ID1 { get => ID; set => ID = value; }
        public int IdProceso1 { get => IdProceso; set => IdProceso = value; }
        public string NombreProceso1 { get => NombreProceso; set => NombreProceso = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public int EstaVigente { get => estaVigente; set => estaVigente = value; }
        public int CantidadVacantes { get => cantidadVacantes; set => cantidadVacantes = value; }
    }
}