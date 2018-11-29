using LogicaNegocio;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class GeneradorRepEncuestas : Form
    {
        private ReporteGuiasBL reporteGuiasBL;
        public GeneradorRepEncuestas()
        {
            InitializeComponent();
            reporteGuiasBL = new ReporteGuiasBL();
            dtpIni.Value = DateTime.Today.AddDays(-20);
            dtpFin.Value = DateTime.Today;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRepEfecGuias_Click(object sender, EventArgs e)
        {
            TimeSpan tiempoDiferencia = dtpFin.Value - dtpIni.Value;
            if (tiempoDiferencia.Days < 0)
            {
                MessageBox.Show("La fecha fin debe ser posterior la fecha inicio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            BindingList<ResultadoGuia> reporte = reporteGuiasBL.listarResultadosGuia(dtpIni.Value, dtpFin.Value);
            FileStream Archivo;
            string nombreArch = "ReporteGuias" + dtpIni.Value.ToString("yyyyMMdd") +"-"+ dtpFin.Value.ToString("yyyyMMdd") + ".csv";
            Archivo = new FileStream(nombreArch, FileMode.Create, FileAccess.Write);
            StreamWriter Escritor = new StreamWriter(Archivo);
            Escritor.Write("NOMBRE DEL GUIA;CALIFICACION PROMEDIO;ENCUESTAS REFERENCIADAS\n");
            foreach (ResultadoGuia linea in reporte)
            {
                Escritor.Write(linea.NombreCompleto + ";");
                Escritor.Write(linea.Promedio + ";");
                Escritor.Write(linea.NroEncuestas + "\n");
            }
            Escritor.Close();
            Archivo.Close();

            //Abrir el excel
            FileInfo fi = new FileInfo(nombreArch);
            if (fi.Exists)
            {
                System.Diagnostics.Process.Start(@nombreArch);
            }
            else
            {
                //file doesn't exist
            }
        }

        private void GeneradorRepEncuestas_Load(object sender, EventArgs e)
        {

        }
    }
}
