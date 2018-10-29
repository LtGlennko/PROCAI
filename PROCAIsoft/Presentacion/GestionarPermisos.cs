﻿using LogicaNegocio;
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
        public Gestionar_permisos(Usuario u)
        {
            guiaBL = new GuiaBL();
            cargoBL = new CargoBL();
            usuarioBL = new UsuarioBL();
            BindingList<Usuario> usuarios = usuarioBL.listarUsuarios();
            trabajadores = convertirUsuariosAtrabajadores(usuarios);
            //Eliminar su propia cuenta
            eliminarElemento(trabajadores, u.IdUsuario1);
            //Ordenar lista por fecha de creación
            List<TrabajadorOCAI> sortedTrab = trabajadores.OrderBy(x => x.FechaCreacion).ToList();
            sortedTrab.Reverse();
            InitializeComponent();
            dvgUsuarios.AutoGenerateColumns = false;
            dvgUsuarios.DataSource = sortedTrab;
            //cboCargo.AutoComplete = true;
            cargos = cargoBL.listarCargos();
            cboCargo.DataSource = cargos;
            cboCargo.ValueMember = "IdCargo1";
            cboCargo.DisplayMember = "NombreCargo";
            //dvgUsuarios.Rows[0].Cells[3].Value = "Ejecutivo";
            //Precargar los datos de los cargos por usuario
            //preasignarCargos(dvgUsuarios);
            chkJefe.TrueValue = "True";
            chkJefe.FalseValue = "False";
            dvgUsuarios.Columns[4].ReadOnly = false;
        }

        private void eliminarElemento(BindingList<TrabajadorOCAI> trabajadores, int id)
        {
            foreach (TrabajadorOCAI t in trabajadores)
            {
                if (t.IdTrabajadorOCAI1 == id)
                {
                    trabajadores.Remove(t);
                    return;
                }
            }
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

        private void dvgUsuarios_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //dvgUsuarios.CancelEdit = true;
            if (dvgUsuarios.CurrentCell.ColumnIndex == 3 && e.Control is ComboBox)
            {
                ComboBox cbo = e.Control as ComboBox;
                if (cbo != null)
                {
                    cbo.SelectedIndexChanged -= new EventHandler(cbo_SelectedIndexChanged);
                    cbo.SelectedIndexChanged += new EventHandler(cbo_SelectedIndexChanged);
                }
            }
        }

        private void cbo_SelectedIndexChanged(object sender, EventArgs e)
        {            
            int idAntes = Int32.Parse(dvgUsuarios.CurrentRow.Cells[3].Value.ToString());
            Cargo cargoAntes = cargoBuscado(cargos, idAntes);
            ComboBox cbo = sender as ComboBox;
            if (cbo.SelectedItem != null && cargoAntes != null)
            {
                Cargo cargoAhora = (Cargo)cbo.SelectedItem;
                if (cargoAntes.IdCargo1 != cargoAhora.IdCargo1)
                {
                    MessageBox.Show("Antes: " + cargoAntes.NombreCargo + "\nAhora:  " + cargoAhora.NombreCargo);
                    if(cargoAntes.NombreCargo == "Guia")
                    {
                        //guiaBL.EliminarGuia(dv)
                    }
                }
                dvgUsuarios.CurrentRow.Cells[3].Value = cargoAhora.IdCargo1;
            }
        }

        private Cargo cargoBuscado(BindingList<Cargo> cargos, int id)
        {
            foreach(Cargo c in cargos)
            {
                if(c.IdCargo1 == id)
                    return c;
            }
            return null;
        }

        private void dvgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dvgUsuarios.CommitEdit(DataGridViewDataErrorContexts.Commit);
            if(e.ColumnIndex == 3)
            {
                //Evento de desplegar combobox al dar click
            }
            if(e.ColumnIndex == 4)
            {
                DataGridViewCheckBoxCell chk = dvgUsuarios[e.ColumnIndex, e.RowIndex] as DataGridViewCheckBoxCell;
                Boolean valor = Convert.ToBoolean(chk.Value);
                if (valor)
                    MessageBox.Show("False");
                else
                    MessageBox.Show("True");
                dvgUsuarios.CurrentRow.Cells[4].Value = !valor;
            }
        }

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
