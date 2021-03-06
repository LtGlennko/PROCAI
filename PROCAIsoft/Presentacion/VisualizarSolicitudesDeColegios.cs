﻿using AccesoDatos;
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
    public partial class VisualizarSolicitudesDeColegios : Form
    {
        private SolicitudColegioDA solicitudColegioDA;
        public VisualizarSolicitudesDeColegios()
        {
            InitializeComponent();

            solicitudColegioDA = new SolicitudColegioDA();

            //dgvSolicitudes.AutoGenerateColumns = false;
            dgvSolicitudes.RowHeadersVisible = false;
            dgvSolicitudes.AutoGenerateColumns = false;
            dgvSolicitudes.DataSource = solicitudColegioDA.listaSolicitudesColegios();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
