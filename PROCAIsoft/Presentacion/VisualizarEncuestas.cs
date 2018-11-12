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
        private ColegioBL colegioBL;//para combobox
        private GuiaBL guiaBL;//para combobox;
        private ActividadBL actividadBL;//para el combobox
        private bool modificar = false;
        public frmRegYeditEncuestas(Guia g)
        {
            InitializeComponent();
            estadoComponentes(estado.INICIAL);
            idGuia = g.IdGuia1;
            dgvEncuestas.AutoGenerateColumns = false;
            listaEncuestas = new BindingList<Encuesta>();

            colegioBL = new ColegioBL();
            guiaBL = new GuiaBL();
            actividadBL = new ActividadBL();

            cboColegio.DataSource = colegioBL.listarColegios();
            cboColegio.ValueMember = "IdColegio1";
            cboColegio.DisplayMember = "nombre";

            cboActividad.DataSource = actividadBL.listarActividades();
            cboActividad.ValueMember = "IdActividad1";
            cboActividad.DisplayMember = "nombreDeTipoYfecha";
            
            cboGuia.ValueMember = "IdGuia1";
            cboGuia.DisplayMember = "NombresYapellidos";
            cboGuia.DataSource = guiaBL.listarGuias();//FUNCION NO COMPLETA!
        }

        public frmRegYeditEncuestas()
        {
            InitializeComponent();
            estadoComponentes(estado.INICIAL);
            dgvEncuestas.AutoGenerateColumns = false;
            listaEncuestas = new BindingList<Encuesta>();

            colegioBL = new ColegioBL();
            guiaBL = new GuiaBL();
            actividadBL = new ActividadBL();

            cboColegio.DataSource = colegioBL.listarColegios();
            cboColegio.ValueMember = "IdColegio1";
            cboColegio.DisplayMember = "nombre";

            cboActividad.DataSource = actividadBL.listarActividades();
            cboActividad.ValueMember = "IdActividad1";
            cboActividad.DisplayMember = "nombreDeTipoYfecha";

            cboGuia.ValueMember = "IdGuia1";
            cboGuia.DisplayMember = "NombresYapellidosGuia";
            cboGuia.DataSource = guiaBL.listarGuias();//HACER ESTA FUNCION !!! Hecha

        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            BuscarGrupo bg = new BuscarGrupo();
            estadoComponentes(estado.BUSQUEDA);
            grupoSeleccionado = null;
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


            }
            if (grupoSeleccionado != null)
            {
                txtNumero.Text = grupoSeleccionado.IdGrupoEncuestas1.ToString();
                cboActividad.SelectedValue = grupoSeleccionado.Actividad.IdActividad1;
                cboGuia.SelectedValue = grupoSeleccionado.GuiaEvaluado.IdGuia1;
                cboColegio.SelectedValue = grupoSeleccionado.Colegio.IdColegio1;
                //dateEncuentra.Value = bg.getGrupoSel().FechaProgramada;
            }

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
            else
            {//registracion del nuevo grupo
                GrupoEncuestas NuevoGrupo = new GrupoEncuestas();
                NuevoGrupo.setActividad((Actividad)cboActividad.SelectedValue);
                NuevoGrupo.setColegio((Colegio)cboColegio.SelectedValue);
                NuevoGrupo.setGuiaEvaluado((Guia)cboGuia.SelectedValue);
                encuestaCreada.setGrupo(NuevoGrupo);
            }
            
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
                //if (txtNumero.Text == "") MessageBox.Show("Tiene que llenar las informaciones del grupo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //else
                //{
                    listaEncuestas.Add(encuestaCreada);
                    dgvEncuestas.DataSource = listaEncuestas;
                    
                //}
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
            //verifica si habia evento doble click sobre datagridview
            if (modificar == true)
            {
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
            else
            {
                MessageBox.Show("Debe seleccionar una encuesta para modificarla");
            }
            
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
            cboActividad.Text = E.GrupoPerteneciente.Actividad.TipoActividad.ToString();
            cboColegio.Text = E.GrupoPerteneciente.Colegio.Nombre.ToString();
            cboGuia.Text = E.GrupoPerteneciente.GuiaEvaluado.NombresYapellidos.ToString();
            dateEncuentra.Value = E.FechaProgramada;

            modificar = true;
        }


        public void estadoComponentes(estado e)
        {
            switch (e)
            {
                case estado.INICIAL:
                    txtNumero.Enabled = false;
                    cboActividad.Enabled = false;
                    cboActividad.SelectedValue = -1; //Hace que no haya nada preseleccionado
                    cboColegio.Enabled = false;
                    cboColegio.SelectedValue = -1;
                    cboGuia.Enabled = false;
                    cboGuia.SelectedValue = -1;
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
                    btnEncuestaGrupo.Enabled = false;
                    break;

                case estado.NUEVO:
                    //txtNumero.Enabled = true;
                    cboActividad.Enabled = true;
                    cboColegio.Enabled = true;
                    cboGuia.Enabled = true;
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
                    btnEncuestaGrupo.Enabled = false;
                    break;

                case estado.GUARDAR:
                    txtNumero.Enabled = false;
                    cboActividad.Enabled = false;
                    cboColegio.Enabled = false;
                    cboGuia.Enabled = false;
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
                    btnEncuestaGrupo.Enabled = false;
                    break;
                case estado.BUSQUEDA:
                    txtNumero.Enabled = false;
                    cboActividad.Enabled = false;
                    cboColegio.Enabled = false;
                    cboGuia.Enabled = false;
                    grpP1.Enabled = true;
                    grpP2.Enabled = true;
                    grpP3.Enabled = true;
                    grpP4.Enabled = true;
                    dateEncuentra.Enabled = false;
                    btnAgregar.Enabled = true;
                    btnModificar.Enabled = true;
                    btnBusca.Enabled = true;
                    button1.Enabled = true;
                    btnGuardar.Enabled = true;
                    btnNuevo.Enabled = true;
                    flagGrupo = false;
                    btnEncuestaGrupo.Enabled = true;
                    limpiarCampos();
                    
                    break;
                case estado.MODIFICAR:
                    txtNumero.Enabled = false;
                    cboActividad.Enabled = false;
                    cboColegio.Enabled = false;
                    cboGuia.Enabled = false;
                    grpP1.Enabled = true;
                    grpP2.Enabled = true;
                    grpP3.Enabled = true;
                    grpP4.Enabled = true;
                    dateEncuentra.Enabled = false;
                    btnAgregar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnBusca.Enabled = false;
                    button1.Enabled = true;
                    btnGuardar.Enabled = false;
                    flagGrupo = false;
                    btnNuevo.Enabled = true;
                    btnEncuestaGrupo.Enabled = false;
                    break;

                case estado.AGREGAR:
                    txtNumero.Enabled = false;
                    cboActividad.Enabled = false;
                    cboColegio.Enabled = false;
                    cboGuia.Enabled = false;
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
                    flagGrupo = false;
                    btnEncuestaGrupo.Enabled = false;
                    break;
            }
        }

        public void limpiarCampos()
        {
            txtNumero.Text = "";
            //cboActividad.DisplayMember = ""; //comment s'appelle la colonne ?
            //cboColegio.Text = ""; //On doit remettre dataSource ?
            //cboGuia.Text = "";

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

            

            EncuestaBL encuestaBL = new EncuestaBL();
            if (listaEncuestas == null) MessageBox.Show("No hay encuentra para registrar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                foreach (Encuesta E in listaEncuestas)
                {
                    int compteur = listaEncuestas.Count; //para que el mensaje de exito aparece solamenta una vez
                    if (encuestaBL.registrarEncuesta(E, idGuia))
                        compteur--;

                    else
                        MessageBox.Show("Error al registrar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (compteur == 0) MessageBox.Show("Registrado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnEncuestaGrupo_Click(object sender, EventArgs e)
        {
            VerEncuestasGrupo veg = new VerEncuestasGrupo(grupoSeleccionado);
            veg.Visible = true;
        }
    }
}