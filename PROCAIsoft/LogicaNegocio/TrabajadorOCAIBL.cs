using AccesoDatos;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class TrabajadorOCAIBL
    {
        private TrabajadorOCAIDA trabajadorOCAIDA;
        private UsuarioDA usuarioDA;
        private GuiaDA guiaDA;
        private String msgError;

        public string MsgError { get => msgError; set => msgError = value; }

        public TrabajadorOCAIBL()
        {
            trabajadorOCAIDA = new TrabajadorOCAIDA();
            usuarioDA = new UsuarioDA();
            guiaDA = new GuiaDA();
        }

        public TrabajadorOCAI crearTrabajadorOCAI(Usuario u)
        {
            return trabajadorOCAIDA.crearTrabajadorOCAI(u);
        }

        public bool actualizarCargo(TrabajadorOCAI tAntes, Cargo nuevoCargo)
        {
            if(tAntes.Cargo.IdCargo1 != nuevoCargo.IdCargo1)
            {
                if(!trabajadorOCAIDA.actualizarCargo(tAntes.IdTrabajadorOCAI1, nuevoCargo.IdCargo1))
                {
                    msgError = "Error al actualizar el cargo";
                    return false;
                }
                if (nuevoCargo.NombreCargo == "Guia")
                {
                    usuarioDA.actualizarNivelPermiso(tAntes.IdUsuario1, 2);
                    if (!guiaDA.insertarGuia(tAntes.IdTrabajadorOCAI1))
                    {
                        msgError = "Error al insertar guia";
                        return false;
                    }
                }
                else
                {
                    if (!guiaDA.eliminarGuia(tAntes.IdTrabajadorOCAI1))
                    {
                        msgError = "Error al eliminar guia";
                        return false;
                    }
                    if(nuevoCargo.NombreCargo == "Administrativo")
                    {
                        if(!usuarioDA.actualizarNivelPermiso(tAntes.IdUsuario1, 3))
                        {
                            msgError = "Error al actualizar nivel de permiso";
                            return false;
                        }
                    }
                    if (nuevoCargo.NombreCargo == "Ejecutivo")
                    {
                        if(!usuarioDA.actualizarNivelPermiso(tAntes.IdUsuario1, 4))
                        {
                            msgError = "Error al actualizar nivel de permiso";
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        public bool actualizarEstadoJefe(TrabajadorOCAI tAntes, bool esJefe)
        {
            return trabajadorOCAIDA.actualizarEsJefe(tAntes.IdTrabajadorOCAI1, esJefe);
        }
    }
}
