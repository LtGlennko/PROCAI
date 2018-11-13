﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using LogicaNegocio;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class EditarTA : Form
    {
        private TipoActividadBL tabl;
        public EditarTA()
        {
            InitializeComponent();
            tabl = new TipoActividadBL();
        }
        
        public EditarTA(int cod,string nombre,string descrip)
        {
            InitializeComponent();
            txtId.Text = cod.ToString();
            txtDesc.Text = descrip;
            txtN.Text = nombre;
            tabl = new TipoActividadBL();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nomb = txtN.Text;
            string descrip = txtDesc.Text;
            int id = Int32.Parse(txtId.Text);
            TipoActividad ta = new TipoActividad(id,nomb,descrip);
            bool actualizar = tabl.actualizarTipoActividad(ta);
            if (actualizar) MessageBox.Show("Datos del producto modificado");
            else MessageBox.Show("Error al registrar");
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }
    }
}