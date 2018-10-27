using System;
using Modelo;
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
    public partial class InfoSolicitud : Form
    {
        public InfoSolicitud(SolicitudInscripcionActividad SIA)
        {
            InitializeComponent();
            if (SIA!= null) {
                txt_nombres.Text = SIA.Solicitante.Nombres;
                txt_apPaterno.Text = SIA.Solicitante.ApellidoPaterno;
                txt_apMaterno.Text = SIA.Solicitante.ApellidoMaterno;
                txt_dni.Text = SIA.Solicitante.DNI1;
                txt_sexo.Text=  (SIA.Solicitante.Sexo == TipoSexo.Hombre)?"Masculino":"Femenino";
                txt_celular.Text = SIA.Solicitante.Celular.ToString();
                txt_email.Text = SIA.Solicitante.CorreoElectronico;
                /////////////////////
                txt_nombrecolegio.Text = SIA.ColegioAsistente.Nombre;
                txt_ruc.Text = SIA.ColegioAsistente.RUC1;
                txt_pais.Text = SIA.ColegioAsistente.Pais;
                txt_departamento.Text = SIA.ColegioAsistente.Departamento;
                txt_direccion.Text = SIA.ColegioAsistente.Direccion;
                txt_particular.Text = (SIA.ColegioAsistente.Tipo==TipoColegio.Particular)?"Si":"No";
                txt_telf.Text = SIA.ColegioAsistente.TelefonoContacto.ToString();
                //////////////////////
                txt_nombreactividad.Text = SIA.Actividad.TipoActividad.Nombre;
                txt_fecha.Text = SIA.Actividad.FechaProgramada.ToString();
                txt_merch.Text = 1500.ToString();
                txt_cel.Text = (SIA.Actividad.EstadoActividad==1)?"Activo":"No activo";
                txt_desc.Text = SIA.Actividad.TipoActividad.Descripcion;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void InfoSolicitud_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
