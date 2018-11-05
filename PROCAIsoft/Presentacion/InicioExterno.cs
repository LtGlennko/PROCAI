﻿using System;
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
    public partial class InicioExterno : Form
    {
        public const int MIN_SIZE = 46;
        public const int MAX_SIZE = 215;
        public InicioExterno()
        {
            InitializeComponent();
        }
        private void ptrDespliegue_Click(object sender, EventArgs e)
        {
            if (pnlOpciones.Width == MAX_SIZE) pnlOpciones.Width = MIN_SIZE;
            else pnlOpciones.Width = MAX_SIZE;
        }

        //ESTE METODO DESLIEGA LA VENTANA EN EL PANEL
        private void abrirFormInPanel(object formHijo)
        {
            if (this.pnlVentanas.Controls.Count > 0)
                this.pnlVentanas.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.StartPosition = FormStartPosition.CenterParent;
            //fh.Dock = DockStyle.Fill;
            this.pnlVentanas.Controls.Add(fh);
            this.pnlVentanas.Tag = fh;
            fh.Show();
        }

        private void btnSugerirColegio_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new SolicitarColegio());
            pnlOpciones.Width = MIN_SIZE;
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new InformacionParaExterno());
            pnlOpciones.Width = MIN_SIZE;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
