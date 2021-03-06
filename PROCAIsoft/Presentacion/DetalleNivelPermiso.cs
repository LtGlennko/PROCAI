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
    public partial class DetalleNivelPermiso : Form
    {
        private BindingList<Cargo> cargos;
        private CargoBL cargoBL;
        private TrabajadorOCAI trabMos;
        private Boolean fueJefe;
        private Boolean esJefeSel;
        private Cargo cargoSel;
        public DetalleNivelPermiso(TrabajadorOCAI t)
        {
            InitializeComponent();
            trabMos = t;
            lblNombre.Text = trabMos.NombreCuenta;
            cargoBL = new CargoBL();
            cargos = cargoBL.listarCargos();
            cboCargo.DataSource = cargos;
            cboCargo.ValueMember = "IdCargo1";
            cboCargo.DisplayMember = "NombreCargo";
            cboCargo.SelectedValue = trabMos.Cargo.IdCargo1;
            fueJefe = chkJefe.Checked = trabMos.EsJefe;
            esJefeSel = trabMos.EsJefe;
            cargoSel = trabMos.Cargo;
        }

        public bool EsJefeSel { get => esJefeSel; set => esJefeSel = value; }
        public Cargo CargoSel { get => cargoSel; set => cargoSel = value; }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(((Cargo)cboCargo.SelectedItem).NombreCargo == "Guia" && chkJefe.Checked)
            {
                MessageBox.Show("Un guia no puede ser jefe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            cargoSel = (Cargo)cboCargo.SelectedItem;
            esJefeSel = chkJefe.Checked;
            if (cargoSel.IdCargo1 != trabMos.Cargo.IdCargo1 || fueJefe != esJefeSel)
            {
                DialogResult result = MessageBox.Show("¿Esta seguro de sus cambios?", "Confirmaciòn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) return;
                this.DialogResult = DialogResult.OK;
                return;
            }
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
