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
    public enum estado
    {
        INICIAL, NUEVO, GUARDAR, BUSQUEDA, AGREGAR, MODIFICAR
    }
    public partial class frmRegYeditEncuestas : Form
    {
        private GrupoEncuestas grupoSeleccionado; //para el boton buscar, y llenar campos
        private Encuesta encuestaCreada;
        private Encuesta encuestaModificada;
        private Pregunta preg1;
        private Pregunta preg2;
        private Pregunta preg3;
        private Pregunta preg4;//las preguntas para recorgerlas 
        private bool flagGrupo;//para saber si tenemos que registar el guia o no
        private BindingList<Encuesta> listaEncuestas; //para el datagridview
        private int idGuia;
        public frmRegYeditEncuestas(Guia g)
        {
            InitializeComponent();
            estadoComponentes(estado.INICIAL);
            idGuia = g.IdGuia1;
            dgvEncuestas.AutoGenerateColumns = false;
            listaEncuestas = new BindingList<Encuesta>();

        }

        public frmRegYeditEncuestas()
        {
            InitializeComponent();
            estadoComponentes(estado.INICIAL);
            dgvEncuestas.AutoGenerateColumns = false;
            listaEncuestas = new BindingList<Encuesta>();

        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            BuscarGrupo bg = new BuscarGrupo();
            estadoComponentes(estado.BUSQUEDA);
            if (bg.ShowDialog() == DialogResult.OK)
            {
                grupoSeleccionado = bg.getGrupoSel();
                BindingList<Pregunta> preguntasSel = grupoSeleccionado.Actividad.TipoActividad.Preguntas;
                //definir preg1, preg2, preg3 y preg4
                if (preguntasSel.Count < 4)
                {
                    MessageBox.Show("El tipo de actividad tiene menos de 4 preguntas relacionadas");
                    return;
                }

                preg1 = preguntasSel[0];
                preg2 = preguntasSel[1];
                preg3 = preguntasSel[2];
                preg4 = preguntasSel[3];

                grpP1.Text = "Pregunta 1: " + preg1.Enunciado;
                grpP2.Text = "Pregunta 2: " + preg2.Enunciado;
                grpP3.Text = "Pregunta 3: " + preg3.Enunciado;
                grpP4.Text = "Pregunta 4: " + preg4.Enunciado;

                txtActividad.Text = grupoSeleccionado.Actividad.TipoActividad.Nombre;

            }
            txtNumero.Text = grupoSeleccionado.IdGrupoEncuestas1.ToString();
            txtGuia.Text = grupoSeleccionado.GuiaEvaluado.NombresYapellidos.ToString();
            txtColegio.Text = grupoSeleccionado.Colegio.Nombre.ToString();
            dateEncuentra.Value = bg.getGrupoSel().FechaProgramada;

        }

        private bool existeSeleccionado(GroupBox g)
        {
            foreach(RadioButton r in g.Controls)
            {
                if (r.Checked == true) return true;
            }
            return false;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            estadoComponentes(estado.AGREGAR);
            encuestaCreada = new Encuesta();
            

            if (existeSeleccionado(grpP1))
            {
                agregarCalificacionSeleccionada(encuestaCreada, grpP1, preg1);
                grpP1.ForeColor = Color.Black;
            }
            else
            {
                grpP1.ForeColor = Color.Red;
            }
            if (existeSeleccionado(grpP2))
            {
                agregarCalificacionSeleccionada(encuestaCreada, grpP2, preg2);
                grpP2.ForeColor = Color.Black;
            }
            else
            {
                grpP2.ForeColor = Color.Red;
            }
            if (existeSeleccionado(grpP3))
            {
                agregarCalificacionSeleccionada(encuestaCreada, grpP3, preg3);
                grpP3.ForeColor = Color.Black;
            }
            else
            {
                grpP3.ForeColor = Color.Red;
            }
            if (existeSeleccionado(grpP4))
            {
                agregarCalificacionSeleccionada(encuestaCreada, grpP4, preg4);
                grpP4.ForeColor = Color.Black;
            }
            else
            {
                grpP4.ForeColor = Color.Red;
            }

            if (flagGrupo == true) encuestaCreada.setGrupo(grupoSeleccionado);
            //else flagGrupo == false : como registar y assignar el nuevo grupo ?
            if (grpP1.ForeColor == Color.Red || grpP2.ForeColor == Color.Red || grpP3.ForeColor == Color.Red || grpP4.ForeColor == Color.Red)
            {
                MessageBox.Show("Tiene que llenar todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                grpP1.Enabled = true;
                grpP2.Enabled = true;
                grpP3.Enabled = true;
                grpP4.Enabled = true;
            }

            else
            {
                if (txtColegio.Text == "" || txtNumero.Text == "" || txtActividad.Text == "" || txtGuia.Text == "") MessageBox.Show("Tiene que llenar las informaciones del grupo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    listaEncuestas.Add(encuestaCreada);
                    dgvEncuestas.DataSource = listaEncuestas;
                    
                }
            }


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
        //Para hacer atras 
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e) //VISUALIZACION
        {
            if (dgvEncuestas.SelectedRows.Count == 0) MessageBox.Show("Tiene que seleccionar una encuesta en la tabla para visualizarla", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (dgvEncuestas.SelectedRows.Count > 1) MessageBox.Show("Hay demasiado encuentras seleccionadas. Tiene que seleccionar solamente una", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Encuesta E = new Encuesta();
                E = (Encuesta)dgvEncuestas.CurrentRow.DataBoundItem;
                frmDetalleEncuesta DE = new frmDetalleEncuesta(E);
                DE.Visible = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //verificar si habia evento doble click sobre datagridview
            
            
                encuestaModificada = new Encuesta();
                encuestaModificada = (Encuesta)dgvEncuestas.CurrentRow.DataBoundItem;
                listaEncuestas.Remove(encuestaModificada);
                agregarCalificacionSeleccionada(encuestaModificada, grpP1, preg1);
                agregarCalificacionSeleccionada(encuestaModificada, grpP2, preg2);
                agregarCalificacionSeleccionada(encuestaModificada, grpP3, preg3);
                agregarCalificacionSeleccionada(encuestaModificada, grpP4, preg4);

                listaEncuestas.Add(encuestaModificada);
                dgvEncuestas.DataSource = listaEncuestas;
                //Inserto encuesta en la base de datos
                EncuestaBL encuestaBL = new EncuestaBL();
                if (encuestaBL.modificarEncuesta(encuestaModificada, idGuia))
                    MessageBox.Show("Modificada con éxito");
                else
                    MessageBox.Show("Error al modificar");
            
        }

        private void dgvEncuestas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            estadoComponentes(estado.MODIFICAR);
            Encuesta E = new Encuesta();
            E = (Encuesta)dgvEncuestas.CurrentRow.DataBoundItem;
            

            Pregunta pregun1 = E.CalificacionesPorEncuesta[0].getPregunta();
            Pregunta pregun2 = E.CalificacionesPorEncuesta[1].getPregunta();
            Pregunta pregun3 = E.CalificacionesPorEncuesta[2].getPregunta();
            Pregunta pregun4 = E.CalificacionesPorEncuesta[3].getPregunta();
        

            grpP1.Text = "Pregunta 1: " + pregun1.Enunciado;
            grpP2.Text = "Pregunta 2: " + pregun2.Enunciado;
            grpP3.Text = "Pregunta 3: " + pregun3.Enunciado;
            grpP4.Text = "Pregunta 4: " + pregun4.Enunciado;

            //SET LAS CALIFICACIONES
            limpiarRadioBottones();
            if (E.CalificacionP1 == 1) rdBtnP1_1.Checked = true;
            else if (E.CalificacionP1 == 2) rdBtnP1_2.Checked = true;
            else if (E.CalificacionP1 == 3) rdBtnP1_3.Checked = true;
            else if (E.CalificacionP1 == 4) rdBtnP1_4.Checked = true;
            else if (E.CalificacionP1 == 5) rdBtnP1_5.Checked = true;

            if (E.CalificacionP2 == 1) rdBtnP2_1.Checked = true;
            else if (E.CalificacionP2 == 2) rdBtnP2_2.Checked = true;
            else if (E.CalificacionP2 == 3) rdBtnP2_3.Checked = true;
            else if (E.CalificacionP2 == 4) rdBtnP2_4.Checked = true;
            else if (E.CalificacionP2 == 5) rdBtnP2_5.Checked = true;

            if (E.CalificacionP3 == 1) rdBtnP3_1.Checked = true;
            else if (E.CalificacionP3 == 2) rdBtnP3_2.Checked = true;
            else if (E.CalificacionP3 == 3) rdBtnP3_3.Checked = true;
            else if (E.CalificacionP3 == 4) rdBtnP3_4.Checked = true;
            else if (E.CalificacionP3 == 5) rdBtnP3_5.Checked = true;

            if (E.CalificacionP4 == 1) rdBtnP4_1.Checked = true;
            else if (E.CalificacionP4 == 2) rdBtnP4_2.Checked = true;
            else if (E.CalificacionP4 == 3) rdBtnP4_3.Checked = true;
            else if (E.CalificacionP4 == 4) rdBtnP4_4.Checked = true;
            else if (E.CalificacionP4 == 5) rdBtnP4_5.Checked = true;
            
            // Y El GRUPO
            txtNumero.Text = E.IdGrupoPerteneciente.ToString();
            txtActividad.Text = E.GrupoPerteneciente.Actividad.TipoActividad.ToString();
            txtColegio.Text = E.GrupoPerteneciente.Colegio.Nombre.ToString();
            txtGuia.Text = E.GrupoPerteneciente.GuiaEvaluado.NombresYapellidos.ToString();
            dateEncuentra.Value = E.FechaProgramada;
        }


        public void estadoComponentes(estado e)
        {
            switch (e)
            {
                case estado.INICIAL:
                    txtNumero.Enabled = false;
                    txtActividad.Enabled = false;
                    txtColegio.Enabled = false;
                    txtGuia.Enabled = false;
                    grpP1.Enabled = false;
                    grpP2.Enabled = false;
                    grpP3.Enabled = false;
                    grpP4.Enabled = false;
                    dateEncuentra.Enabled = false;
                    btnAgregar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnBusca.Enabled = false;
                    button1.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    flagGrupo = false;
                    break;

                case estado.NUEVO:
                    txtNumero.Enabled = true;
                    txtActividad.Enabled = true;
                    txtColegio.Enabled = true;
                    txtGuia.Enabled = true;
                    grpP1.Enabled = true;
                    grpP2.Enabled = true;
                    grpP3.Enabled = true;
                    grpP4.Enabled = true;
                    dateEncuentra.Enabled = true;
                    btnAgregar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnBusca.Enabled = true;
                    button1.Enabled = true;
                    btnGuardar.Enabled = true;
                    btnNuevo.Enabled = true;
                    flagGrupo = false;
                    limpiarCampos();
                    break;

                case estado.GUARDAR:
                    txtNumero.Enabled = false;
                    txtActividad.Enabled = false;
                    txtColegio.Enabled = false;
                    txtGuia.Enabled = false;
                    grpP1.Enabled = false;
                    grpP2.Enabled = false;
                    grpP3.Enabled = false;
                    grpP4.Enabled = false;
                    dateEncuentra.Enabled = false;
                    btnAgregar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnBusca.Enabled = false;
                    button1.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    break;
                case estado.BUSQUEDA:
                    txtNumero.Enabled = false;
                    txtActividad.Enabled = false;
                    txtColegio.Enabled = false;
                    txtGuia.Enabled = false;
                    grpP1.Enabled = true;
                    grpP2.Enabled = true;
                    grpP3.Enabled = true;
                    grpP4.Enabled = true;
                    dateEncuentra.Enabled = false;
                    btnAgregar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnBusca.Enabled = true;
                    button1.Enabled = true;
                    btnGuardar.Enabled = true;
                    btnNuevo.Enabled = true;
                    flagGrupo = true;
                    limpiarCampos();
                    //anadir listEncuesta = null ?
                    break;
                case estado.MODIFICAR:
                    txtNumero.Enabled = false;
                    txtActividad.Enabled = false;
                    txtColegio.Enabled = false;
                    txtGuia.Enabled = false;
                    grpP1.Enabled = true;
                    grpP2.Enabled = true;
                    grpP3.Enabled = true;
                    grpP4.Enabled = true;
                    dateEncuentra.Enabled = false;
                    btnAgregar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnBusca.Enabled = true;
                    button1.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    break;

                case estado.AGREGAR:
                    txtNumero.Enabled = false;
                    txtActividad.Enabled = false;
                    txtColegio.Enabled = false;
                    txtGuia.Enabled = false;
                    grpP1.Enabled = false;
                    grpP2.Enabled = false;
                    grpP3.Enabled = false;
                    grpP4.Enabled = false;
                    dateEncuentra.Enabled = false;
                    btnAgregar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnBusca.Enabled = true;
                    button1.Enabled = true;
                    btnGuardar.Enabled = true;
                    btnNuevo.Enabled = false;
                    break;
            }
        }

        public void limpiarCampos()
        {
            txtNumero.Text = "";
            txtActividad.Text = "";
            txtColegio.Text = "";
            txtGuia.Text = "";

            dateEncuentra.Value = DateTime.Now;

            grpP1.Text = "Pregunta 1: ";
            grpP2.Text = "Pregunta 2: ";
            grpP3.Text = "Pregunta 3: ";
            grpP4.Text = "Pregunta 4: ";

            limpiarRadioBottones();
        }

        public void limpiarRadioBottones()
        {
            rdBtnP1_1.Checked = false;
            rdBtnP1_2.Checked = false;
            rdBtnP1_3.Checked = false;
            rdBtnP1_4.Checked = false;
            rdBtnP1_5.Checked = false;
            rdBtnP2_1.Checked = false;
            rdBtnP2_2.Checked = false;
            rdBtnP2_3.Checked = false;
            rdBtnP2_4.Checked = false;
            rdBtnP2_5.Checked = false;
            rdBtnP3_1.Checked = false;
            rdBtnP3_2.Checked = false;
            rdBtnP3_3.Checked = false;
            rdBtnP3_4.Checked = false;
            rdBtnP3_5.Checked = false;
            rdBtnP4_1.Checked = false;
            rdBtnP4_2.Checked = false;
            rdBtnP4_3.Checked = false;
            rdBtnP4_4.Checked = false;
            rdBtnP4_5.Checked = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estadoComponentes(estado.NUEVO);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
             
            estadoComponentes(estado.GUARDAR);

            // verificar si flag = true o false -> si false, tenemos que guardarlo...

            EncuestaBL encuestaBL = new EncuestaBL();
            if (listaEncuestas == null) MessageBox.Show("No hay encuentra para registrar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                foreach (Encuesta E in listaEncuestas)
                {
                    if (encuestaBL.registrarEncuesta(E, idGuia))
                        //este mensaje va a ponerse 3 veces en seguida si hay 3 encuestas... como hacer solamente uno ?
                        MessageBox.Show("Registrado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Error al registrar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

        


        //        private Encuesta encuestaCreada;
        //        private int idUsu;
        //        private GrupoEncuestas grupoBuscado;
        //        private Pregunta preg1;
        //        private Pregunta preg2;
        //        private Pregunta preg3;
        //        private Pregunta preg4;
        //        private BindingList<Encuesta> listaEncuestas;
        //        public frmRegYeditEncuestas(Usuario usu)
        //        {
        //            //btnRegistrar.Enabled = true;
        //            //btnModificar.Enabled = true;
        //            idUsu = usu.IdUsuario1;
        //            InitializeComponent();
        //            btnAgregar.Enabled = false;

        //            txtNumero.Enabled = false;
        //            dateEncuentra.Enabled = false;

        //            dgvEncuestas.AutoGenerateColumns = false;

        //            listaEncuestas = new BindingList<Encuesta>();
        //            //dgvEncuestas.DataSource = listaEncuestas;
        //            dateEncuentra.Enabled = false;           
        //        }

        //        private void btnRegistrar_Click(object sender, EventArgs e)
        //        {
        //            MessageBox.Show("Encuesta registrada con éxito");
        //            Encuesta E = new Encuesta();
        //        }
        //        private void btnAgregar_Click(object sender, EventArgs e)
        //        {
        //            encuestaCreada = new Encuesta();
        //            encuestaCreada.setGrupo(grupoBuscado);
        //            agregarCalificacionSeleccionada(encuestaCreada, grpP1, preg1);
        //            agregarCalificacionSeleccionada(encuestaCreada, grpP2, preg2);
        //            agregarCalificacionSeleccionada(encuestaCreada, grpP3, preg3);
        //            agregarCalificacionSeleccionada(encuestaCreada, grpP4, preg4);
        //            int cantCalif = encuestaCreada.CalificacionesPorEncuesta.Count;
        //            if (cantCalif >= 4)
        //                dgvEncuestas.DataSource = listaEncuestas;
        //                listaEncuestas.Add(encuestaCreada);
        //            //Inserto encuesta en la base de datos
        //            EncuestaBL encuestaBL = new EncuestaBL();
        //            if (encuestaBL.registrarEncuesta(encuestaCreada, idUsu))
        //                MessageBox.Show("Registrado con éxito");
        //            else
        //                MessageBox.Show("Error al registrar");
        //        }

        //        private void agregarCalificacionSeleccionada(Encuesta encuesta, GroupBox grupo, Pregunta preg)
        //        {
        //            RadioButton btn = grupo.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
        //            modificaYagregaCalif(btn, encuesta, preg, 1);
        //            modificaYagregaCalif(btn, encuesta, preg, 2);
        //            modificaYagregaCalif(btn, encuesta, preg, 3);
        //            modificaYagregaCalif(btn, encuesta, preg, 4);
        //            modificaYagregaCalif(btn, encuesta, preg, 5);
        //        }

        //        private void modificaYagregaCalif(RadioButton btn, Encuesta encuesta, Pregunta preg, int nro)
        //        {
        //            if ((btn.Text).Equals(nro.ToString()))
        //            {
        //                CalificacionPXE calif = new CalificacionPXE(nro);
        //                calif.setPregunta(preg);
        //                encuesta.addCalificacionPorEncuesta(calif);
        //            }
        //        }

        //        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //        {

        //        }

        //        private void button1_Click(object sender, EventArgs e)
        //        {
        //            frmDetalleEncuesta DE = new frmDetalleEncuesta();
        //            if (DE.ShowDialog() == DialogResult.OK)
        //            {

        //            }
        //        }

        //        private void frmRegYeditEncuestas_Load(object sender, EventArgs e)
        //        {

        //        }

        //        private void pictureBox1_Click(object sender, EventArgs e)
        //        {
        //            Dispose();
        //        }

        //        private void btnBusca_Click(object sender, EventArgs e)
        //        {
        //            BuscarGrupo bg = new BuscarGrupo();
        //            //bg.Visible = true;
        //            if(bg.ShowDialog() == DialogResult.OK)
        //            {
        //                grupoBuscado = bg.getGrupoSel();
        //                BindingList<Pregunta> preguntasSel = grupoBuscado.Actividad.TipoActividad.Preguntas;
        //                //definir preg1, preg2, preg3 y preg4
        //                if(preguntasSel.Count < 4)
        //                {
        //                    MessageBox.Show("El tipo de actividad tiene menos de 4 preguntas relacionadas");
        //                    return;
        //                }
        //                //Actualizar la fecha
        //                preg1 = preguntasSel[0];
        //                preg2 = preguntasSel[1];
        //                preg3 = preguntasSel[2];
        //                preg4 = preguntasSel[3];
        //                grpP1.Text = "Pregunta 1: " + preg1.Enunciado;
        //                grpP2.Text = "Pregunta 2: " + preg2.Enunciado;
        //                grpP3.Text = "Pregunta 3: " + preg3.Enunciado;
        //                grpP4.Text = "Pregunta 4: " + preg4.Enunciado;
        //                lblTipoEncuesta.Text = "Tipo de actividad: " + grupoBuscado.Actividad.TipoActividad.Nombre;
        //                dateEncuentra.Value = bg.getGrupoSel().FechaProgramada;
        //            }
        //            txtNumero.Text = grupoBuscado.IdGrupoEncuestas1.ToString();
        //            txtNumero.Enabled = false;
        //            btnAgregar.Enabled = true;
        //        }

        //       
        //        private void lblTipoEncuesta_Click(object sender, EventArgs e)
        //        {

        //        }
        //    }
    
