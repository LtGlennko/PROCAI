﻿using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;

namespace Presentacion
{    
    public partial class frmRegYeditEncuestas : Form
    {
        private Encuesta encuestaCreada;
        private int idUsu;
        private GrupoEncuestas grupoBuscado;
        private Pregunta preg1;
        private Pregunta preg2;
        private Pregunta preg3;
        private Pregunta preg4;
        private BindingList<Encuesta> listaEncuestas;
        public frmRegYeditEncuestas(int flag, int id)
        {
            idUsu = id;
            //btnRegistrar.Enabled = true;
            //btnModificar.Enabled = true;
            InitializeComponent();
            btnAgregar.Enabled = false;
            
            txtNumero.Enabled = false;
            dateEncuentra.Enabled = false;

            dgvEncuestas.AutoGenerateColumns = false;

            listaEncuestas = new BindingList<Encuesta>();
            //dgvEncuestas.DataSource = listaEncuestas;
            dateEncuentra.Enabled = false;
            if (flag == 0)
            {
                btnModificar.Enabled = false;
            }
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Encuesta registrada con éxito");
            Encuesta E = new Encuesta();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            encuestaCreada = new Encuesta();
            encuestaCreada.setGrupo(grupoBuscado);
            agregarCalificacionSeleccionada(encuestaCreada, grpP1, preg1);
            agregarCalificacionSeleccionada(encuestaCreada, grpP2, preg2);
            agregarCalificacionSeleccionada(encuestaCreada, grpP3, preg3);
            agregarCalificacionSeleccionada(encuestaCreada, grpP4, preg4);
            int cantCalif = encuestaCreada.CalificacionesPorEncuesta.Count;
            if (cantCalif >= 4)
                dgvEncuestas.DataSource = listaEncuestas;
                listaEncuestas.Add(encuestaCreada);
            //Inserto encuesta en la base de datos
            EncuestaBL encuestaBL = new EncuestaBL();
            if (encuestaBL.registrarEncuesta(encuestaCreada, idUsu))
                MessageBox.Show("Registrado con éxito");
            else
                MessageBox.Show("Error al registrar");
        }

        private void agregarCalificacionSeleccionada(Encuesta encuesta, GroupBox grupo, Pregunta preg)
        {
            RadioButton btn = grupo.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
            modificaYagregaCalif(btn, encuesta, preg, 1);
            modificaYagregaCalif(btn, encuesta, preg, 2);
            modificaYagregaCalif(btn, encuesta, preg, 3);
            modificaYagregaCalif(btn, encuesta, preg, 4);
            modificaYagregaCalif(btn, encuesta, preg, 5);
        }

        private void modificaYagregaCalif(RadioButton btn, Encuesta encuesta, Pregunta preg, int nro)
        {
            if ((btn.Text).Equals(nro.ToString()))
            {
                CalificacionPXE calif = new CalificacionPXE(nro);
                calif.setPregunta(preg);
                encuesta.addCalificacionPorEncuesta(calif);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDetalleEncuesta DE = new frmDetalleEncuesta();
            if (DE.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void frmRegYeditEncuestas_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            BuscarGrupo bg = new BuscarGrupo();
            //bg.Visible = true;
            if(bg.ShowDialog() == DialogResult.OK)
            {
                grupoBuscado = bg.getGrupoSel();
                BindingList<Pregunta> preguntasSel = grupoBuscado.Actividad.TipoActividad.Preguntas;
                //definir preg1, preg2, preg3 y preg4
                if(preguntasSel.Count < 4)
                {
                    MessageBox.Show("El tipo de actividad tiene menos de 4 preguntas relacionadas");
                    return;
                }
                //Actualizar la fecha
                preg1 = preguntasSel[0];
                preg2 = preguntasSel[1];
                preg3 = preguntasSel[2];
                preg4 = preguntasSel[3];
                grpP1.Text = "Pregunta 1: " + preg1.Enunciado;
                grpP2.Text = "Pregunta 2: " + preg2.Enunciado;
                grpP3.Text = "Pregunta 3: " + preg3.Enunciado;
                grpP4.Text = "Pregunta 4: " + preg4.Enunciado;
                lblTipoEncuesta.Text = "Tipo de actividad: " + grupoBuscado.Actividad.TipoActividad.Nombre;
                dateEncuentra.Value = bg.getGrupoSel().FechaProgramada;
            }
            txtNumero.Text = grupoBuscado.IdGrupoEncuestas1.ToString();
            txtNumero.Enabled = false;
            btnAgregar.Enabled = true;
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTipoEncuesta_Click(object sender, EventArgs e)
        {

        }
    }
}
