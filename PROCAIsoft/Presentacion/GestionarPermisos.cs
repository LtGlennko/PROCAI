using LogicaNegocio;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Gestionar_permisos : Form
    {
        BindingList<TrabajadorOCAI> trabajadores;
        BindingList<Cargo> cargos;
        GuiaBL guiaBL;
        CargoBL cargoBL;
        UsuarioBL usuarioBL;
        TrabajadorOCAIBL trabajadorOCAIBL;
        public Gestionar_permisos(TrabajadorOCAI t)
        {
            guiaBL = new GuiaBL();
            cargoBL = new CargoBL();
            usuarioBL = new UsuarioBL();
            trabajadorOCAIBL = new TrabajadorOCAIBL();
            BindingList<Usuario> usuarios = usuarioBL.listarUsuariosSinGestionador(t.IdUsuario1);
            trabajadores = convertirUsuariosAtrabajadores(usuarios);
            InitializeComponent();
            dvgUsuarios.AutoGenerateColumns = false;
            dvgUsuarios.DataSource = trabajadores;
            cargos = cargoBL.listarCargos();
            //cboCargo.DataSource = cargos;
            //cboCargo.ValueMember = "IdCargo1";
            //cboCargo.DisplayMember = "NombreCargo";
        }

        //private void preasignarCargos(DataGridView dvgUsuarios)
        //{
        //    DataGridViewComboBoxColumn column = (DataGridViewComboBoxColumn)
        //        dvgUsuarios.Columns["cboCargo"];
        //    foreach (DataGridViewRow r in dvgUsuarios.Rows)
        //    {
        //        TrabajadorOCAI t = (TrabajadorOCAI)r.DataBoundItem;
        //        DataGridViewComboBoxCell cbo = (DataGridViewComboBoxCell)(r.Cells["cboCargo"]);
        //        //ComboBox c = (ComboBox)cbo as ComboBox;
        //        //c.Sele
        //        cbo.Value = 1;
        //    }
        //}

        private BindingList<TrabajadorOCAI> convertirUsuariosAtrabajadores(BindingList<Usuario> usuarios)
        {
            TrabajadorOCAIBL trabajadorOCAIBL = new TrabajadorOCAIBL();
            BindingList<TrabajadorOCAI> trabajadores = new BindingList<TrabajadorOCAI>();
            foreach(Usuario u in usuarios)
            {
                if(u.NivelPermiso >= 2)
                {
                    TrabajadorOCAI t = trabajadorOCAIBL.crearTrabajadorOCAI(u);
                    trabajadores.Add(t);
                }
            }
            return trabajadores;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los cambios han sido guardados con éxito");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        //private void dvgUsuarios_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        //{
        //    //dvgUsuarios.CancelEdit = true;
        //    //MessageBox.Show("Fila que activo evento: " + dvgUsuarios.CurrentCell.RowIndex);
        //    if (dvgUsuarios.CurrentCell.ColumnIndex == 3 && e.Control is ComboBox)
        //    {
        //        ComboBox cbo = e.Control as ComboBox;
        //        if (cbo != null)
        //        {
        //            cbo.SelectedIndexChanged -= new EventHandler(cbo_SelectedIndexChanged);
        //            cbo.SelectedIndexChanged += new EventHandler(cbo_SelectedIndexChanged);
        //        }
        //    }
        //}

        //private void cbo_SelectedIndexChanged(object sender, EventArgs e)
        //{            
        //    int idAntes = Int32.Parse(dvgUsuarios.CurrentRow.Cells[3].Value.ToString());
        //    Cargo cargoAntes = cargoBuscado(cargos, idAntes);
        //    ComboBox cbo = sender as ComboBox;
        //    if (cbo.SelectedItem != null && cargoAntes != null && cbo.DataSource != null && cbo.ContainsFocus)
        //    {
        //        Cargo cargoAhora = (Cargo)cbo.SelectedItem;
        //        if (cargoAntes.IdCargo1 != cargoAhora.IdCargo1)
        //        {
        //            MessageBox.Show("Antes: " + cargoAntes.NombreCargo + "\nAhora:  " + cargoAhora.NombreCargo);
        //            if(cargoAntes.NombreCargo == "Guia")
        //            {
        //                //guiaBL.EliminarGuia(dv)
        //            }
        //        }
        //        dvgUsuarios.CurrentRow.Cells[3].Value = cargoAhora.IdCargo1;
        //    }
        //}

        private Cargo cargoBuscado(BindingList<Cargo> cargos, int id)
        {
            foreach(Cargo c in cargos)
            {
                if(c.IdCargo1 == id)
                    return c;
            }
            return null;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            TrabajadorOCAI trabActual = (TrabajadorOCAI)dvgUsuarios.CurrentRow.DataBoundItem;
            if(trabActual == null)
            {
                MessageBox.Show("Debe seleccionar un registro", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DetalleNivelPermiso dnp = new DetalleNivelPermiso(trabActual);
            dnp.StartPosition = FormStartPosition.CenterParent;
            if (dnp.ShowDialog() == DialogResult.OK)
            {
                //Actualizar usuario con cargoSel y esJefeSel, para entrar aqui ya he asegurado que hubiero cambios
                if (!trabajadorOCAIBL.actualizarCargo(trabActual, dnp.CargoSel))
                    MessageBox.Show(trabajadorOCAIBL.MsgError, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if(!trabajadorOCAIBL.actualizarEstadoJefe(trabActual, dnp.EsJefeSel))
                    MessageBox.Show("Error al actualizar el estado de jefe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                trabActual.Cargo = dnp.CargoSel;
                trabActual.EsJefe = dnp.EsJefeSel;
            }
        }

        //private void dvgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if(e.ColumnIndex == 4)
        //    {
        //        DataGridViewCheckBoxCell chk = dvgUsuarios.CurrentRow.Cells[4] as DataGridViewCheckBoxCell;
        //        Boolean valor = Convert.ToBoolean(chk.Value);
        //        if (valor)
        //            MessageBox.Show("False");
        //        else
        //            MessageBox.Show("True");
        //        dvgUsuarios.CurrentRow.Cells[4].ReadOnly = false;
        //        //dvgUsuarios.CurrentRow.Cells[4].FormattedValue = true;
        //        //if (valor)
        //            dvgUsuarios.CurrentRow.Cells[4].Value = false;
        //        //if (!valor)
        //        //    dvgUsuarios.CurrentRow.Cells[4].Value = true;
        //        MessageBox.Show("Valor cambiado a: " + dvgUsuarios.CurrentRow.Cells[4].Value.ToString() +  "\nFormated value: " + dvgUsuarios.CurrentRow.Cells[4].FormattedValue);
        //    }
        //}

        //private void dvgUsuarios_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        //{
        //    if (e.ColumnIndex == 3)
        //    {
        //        ComboBox cbo = sender as ComboBox;
        //        Cargo cargoAntes = (Cargo)dvgUsuarios[e.ColumnIndex, e.RowIndex].Value;
        //        Cargo cargoDespues = (Cargo)e.FormattedValue;
        //        if (cargoAntes != cargoDespues)
        //        {
        //            MessageBox.Show(cargoDespues.NombreCargo);
        //            //if (nivelDespues < 0 || nivelDespues > 5)
        //            //{
        //            //    MessageBox.Show("Nivel fuera del rango (1-5)", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            //    e.Cancel = true;
        //            //    return;
        //            //}
        //            //if (nivelDespues == 5 && nivelAntes < 3)
        //            //{
        //            //    MessageBox.Show("Solo un Administrativo o Ejecutivo puede ser Jefe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            //    e.Cancel = true;
        //            //    return;
        //            //}
        //        }
        //        else e.Cancel = true;
        //    }
        //    //if (nivelNuevo == 5 && int(nivelAnterior) < 3)
        //    //{
        //    //    MessageBox.Show("Solo un ejecutivo o un administrativo pueden ser jefes");
        //    //    e.Cancel = true;
        //    //    return;
        //    //}                
        //    //string username = ((Usuario)dvgUsuarios.CurrentRow.DataBoundItem).NombreCuenta;
        //    //MessageBox.Show("Nivel de permiso de usuario '" + username + "' cambiado a " + nivelNuevo);
        //}
    }
}
