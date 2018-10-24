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
using LogicaNegocio;

namespace Presentacion
{
    public enum estado
    {
        INICIAL, BUSQUEDA, AGREGAR, MODIFICAR
    }
    public partial class frmRegYeditEncuestas : Form
    {
        private GrupoEncuestas grupoSeleccionado; //para el boton buscar, y llenar campos
        private Encuesta encuestaCreada;
        private Pregunta preg1;
        private Pregunta preg2;
        private Pregunta preg3;
        private Pregunta preg4;
        private Pregunta preg5; //las preguntas para recorgerlas 
        private BindingList<Encuesta> listaEncuestas; //para el datagridview
        private int idUsu;
        public frmRegYeditEncuestas(Usuario usu)
        {
            InitializeComponent();
            estadoComponentes(estado.INICIAL);
            idUsu = usu.IdUsuario1;
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
                //definir preg1, preg2, preg3 y preg4 Y PREG5
                if (preguntasSel.Count < 5)
                {
                    MessageBox.Show("El tipo de actividad tiene menos de 5 preguntas relacionadas");
                    return;
                }

                preg1 = preguntasSel[0];
                preg2 = preguntasSel[1];
                preg3 = preguntasSel[2];
                preg4 = preguntasSel[3];
                preg5 = preguntasSel[4];
                grpP1.Text = "Pregunta 1: De 0 (No, en absoluto) a 5 (Si, totalmente), " + preg1.Enunciado;
                grpP2.Text = "Pregunta 2: De 0 (No, en absoluto) a 5 (Si, totalmente), " + preg2.Enunciado;
                grpP3.Text = "Pregunta 3: De 0 (No, en absoluto) a 5 (Si, totalmente), " + preg3.Enunciado;
                grpP4.Text = "Pregunta 4: De 0 (No, en absoluto) a 5 (Si, totalmente), " + preg4.Enunciado;
                grpP5.Text = "Pregunta 5: De 0 (No, en absoluto) a 5 (Si, totalmente), " + preg5.Enunciado;
                lblTipoEncuesta.Text = "Tipo de actividad: " + grupoSeleccionado.Actividad.TipoActividad.Nombre;

            }
            txtNumero.Text = grupoSeleccionado.IdGrupoEncuestas1.ToString();
            dateEncuentra.Value = bg.getGrupoSel().FechaProgramada;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            estadoComponentes(estado.AGREGAR);
            encuestaCreada = new Encuesta();
            encuestaCreada.setGrupo(grupoSeleccionado);
            if (grpP1.Controls.Count == 1) agregarCalificacionSeleccionada(encuestaCreada, grpP1, preg1);
            else
            {
                grpP1.ForeColor = Color.Red;
            }
            if (grpP2.Controls.Count == 1) agregarCalificacionSeleccionada(encuestaCreada, grpP2, preg2);
            else
            {
                grpP2.ForeColor = Color.Red;
            }
            if (grpP3.Controls.Count == 1) agregarCalificacionSeleccionada(encuestaCreada, grpP3, preg3);
            else
            {
                grpP3.ForeColor = Color.Red;
            }
            if (grpP4.Controls.Count == 1) agregarCalificacionSeleccionada(encuestaCreada, grpP4, preg4);
            else
            {
                grpP4.ForeColor = Color.Red;
            }
            if (grpP5.Controls.Count == 1) agregarCalificacionSeleccionada(encuestaCreada, grpP5, preg5);
            else
            {
                grpP5.ForeColor = Color.Red;
            }

            if (grpP1.ForeColor == Color.Red || grpP2.ForeColor == Color.Red || grpP3.ForeColor == Color.Red || grpP4.ForeColor == Color.Red || grpP5.ForeColor == Color.Red)
            {
                MessageBox.Show("Tiene que llenar todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                listaEncuestas.Add(encuestaCreada);
                dgvEncuestas.DataSource = listaEncuestas;
                //Inserto encuesta en la base de datos
                EncuestaBL encuestaBL = new EncuestaBL();
                if (encuestaBL.registrarEncuesta(encuestaCreada, idUsu))
                    MessageBox.Show("Registrado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Error al registrar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button1_Click(object sender, EventArgs e)
        {
            frmDetalleEncuesta DE = new frmDetalleEncuesta();
            if (DE.ShowDialog() == DialogResult.OK)
            {

            }
        }
        public void estadoComponentes(estado e)
        {
            switch (e)
            {
                case estado.INICIAL:
                    txtNumero.Enabled = false;
                    //las preguntas false
                    dateEncuentra.Enabled = false;
                    btnAgregar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnBusca.Enabled = true;
                    //bouton vizualizar 
                    break;
                case estado.BUSQUEDA:
                    txtNumero.Enabled = false;
                    //las preguntas true
                    dateEncuentra.Enabled = false;
                    btnAgregar.Enabled = true;
                    btnModificar.Enabled = true;
                    btnBusca.Enabled = true;
                    //bouton vizualizar
                    limpiarCampos();
                    break;
                case estado.MODIFICAR:
                    txtNumero.Enabled = false;
                    //las preguntas true
                    dateEncuentra.Enabled = false;
                    btnAgregar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnBusca.Enabled = true;
                    //bouton vizualizar 
                    break;

                case estado.AGREGAR:
                    txtNumero.Enabled = false;
                    //las preguntas false
                    dateEncuentra.Enabled = false;
                    btnAgregar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnBusca.Enabled = true;
                    //bouton vizualizar 
                    break;
            }
        }

        public void limpiarCampos()
        {
            txtNumero.Text = "";
            dateEncuentra.Value = DateTime.Now;
            //limpiar preguntas
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
    
