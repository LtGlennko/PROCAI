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
        private Guia digitador;
        private ColegioBL colegioBL;//para combobox
        private GuiaBL guiaBL;//para combobox;
        private ActividadBL actividadBL;//para el combobox
        private GrupoBL grupoBL; //Para registrar nuevos grupos de encuestas
        private bool modificar = false;
        public frmRegYeditEncuestas(Guia g)
        {
            InitializeComponent();
            disenio_tabla();
            estadoComponentes(estado.INICIAL);
            digitador = g;
            dgvEncuestas.AutoGenerateColumns = false;
            listaEncuestas = new BindingList<Encuesta>();

            colegioBL = new ColegioBL();
            guiaBL = new GuiaBL();
            actividadBL = new ActividadBL();
            grupoBL = new GrupoBL();

            cboColegio.DataSource = colegioBL.listarColegios();
            cboColegio.ValueMember = "IdColegio1";
            cboColegio.DisplayMember = "nombre";

            cboActividad.DataSource = actividadBL.listarActividades();
            cboActividad.ValueMember = "IdActividad1";
            cboActividad.DisplayMember = "nombreDeTipoYfecha";
            
            cboGuia.ValueMember = "IdGuia1";
            cboGuia.DisplayMember = "NombresYapellidos";
            cboGuia.DataSource = guiaBL.listarGuias();
        }

        public frmRegYeditEncuestas()
        {
            InitializeComponent();
            disenio_tabla();
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
            cboGuia.DataSource = guiaBL.listarGuias();

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
                flagGrupo = true;
                //Habilita botones para que se añadan encuestas al grupo existente
                btnAgregar.Enabled = true;
                btnModificar.Enabled = true;
                button1.Enabled = true;
                btnRegistrarGrupo.Enabled = false;
                //dateEncuentra.Value = bg.getGrupoSel().FechaProgramada;
            }

        }

        private bool existeSeleccionado(GroupBox g)
        {
            //Solo existen 5 controles radiobutton
            int cont = 0;
            foreach(RadioButton r in g.Controls)
            {
                cont++;
                if (r.Checked == true) return true;
                if (cont == 5) break;
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
            
            if (flagGrupo == true) encuestaCreada.GrupoPerteneciente = (grupoSeleccionado);
            else
            {//agregamiento del nuevo grupo
                GrupoEncuestas NuevoGrupo = new GrupoEncuestas();
                NuevoGrupo.Actividad = ((Actividad)cboActividad.SelectedItem);
                NuevoGrupo.Colegio = ((Colegio)cboColegio.SelectedItem);
                NuevoGrupo.GuiaEvaluado = ((Guia)cboGuia.SelectedItem);
                encuestaCreada.GrupoPerteneciente = NuevoGrupo;
            }
            
            if (grpP1.ForeColor == Color.Red || grpP2.ForeColor == Color.Red || grpP3.ForeColor == Color.Red || grpP4.ForeColor == Color.Red)
            {
                MessageBox.Show("Tiene que llenar todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                grpP1.Enabled = true;
                grpP2.Enabled = true;
                grpP3.Enabled = true;
                grpP4.Enabled = true;
                btnAgregar.Enabled = true;
            }

            else
            {
                encuestaCreada.IdEncuesta1 = 0; //Indica que la encuesta aun no ha sido registrada en la base de datos
                listaEncuestas.Add(encuestaCreada);
                dgvEncuestas.DataSource = listaEncuestas;
                disenio_tabla();
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
                calif.Pregunta = preg;
                encuesta.addCalificacionPorEncuesta(calif);
            }
        }

        private void button1_Click(object sender, EventArgs e) //VISUALIZACION
        {
            if (dgvEncuestas.SelectedCells.Count == 0) MessageBox.Show("Tiene que seleccionar una encuesta en la tabla para visualizarla", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                Encuesta temp = new Encuesta();
                temp = (Encuesta)dgvEncuestas.CurrentRow.DataBoundItem;
                encuestaModificada.IdEncuesta1 = temp.IdEncuesta1;
                encuestaModificada.GrupoPerteneciente = temp.GrupoPerteneciente;
                encuestaModificada.Digitador = temp.Digitador;
                

                foreach (Encuesta enc in listaEncuestas)
                {
                    if (enc == (Encuesta)dgvEncuestas.CurrentRow.DataBoundItem)
                    {
                        listaEncuestas.Remove(enc);
                        break;
                    }
                }

                
                CalificacionPXE c1 = new CalificacionPXE(1);
                CalificacionPXE c2 = new CalificacionPXE(1);
                CalificacionPXE c3 = new CalificacionPXE(1);
                CalificacionPXE c4 = new CalificacionPXE(1);
                if (rdBtnP1_1.Checked == true) c1.Calificacion = 1;
                else if (rdBtnP1_2.Checked == true) c1.Calificacion = 2;
                else if (rdBtnP1_3.Checked == true) c1.Calificacion = 3;
                else if (rdBtnP1_4.Checked == true) c1.Calificacion = 4;
                else c1.Calificacion = 5;

                if (rdBtnP2_1.Checked == true) c2.Calificacion = 1;
                else if (rdBtnP2_2.Checked == true) c2.Calificacion = 2;
                else if (rdBtnP2_3.Checked == true) c2.Calificacion = 3;
                else if (rdBtnP2_4.Checked == true) c2.Calificacion = 4;
                else c2.Calificacion = 5;

                if (rdBtnP3_1.Checked == true) c3.Calificacion = 1;
                else if (rdBtnP3_2.Checked == true) c3.Calificacion = 2;
                else if (rdBtnP3_3.Checked == true) c3.Calificacion = 3;
                else if (rdBtnP3_4.Checked == true) c3.Calificacion = 4;
                else c3.Calificacion = 5;

                if (rdBtnP4_1.Checked == true) c4.Calificacion = 1;
                else if (rdBtnP4_2.Checked == true) c4.Calificacion = 2;
                else if (rdBtnP4_3.Checked == true) c4.Calificacion = 3;
                else if (rdBtnP4_4.Checked == true) c4.Calificacion = 4;
                else c4.Calificacion = 5;


                encuestaModificada.CalificacionesPorEncuesta.Add(c1);
                encuestaModificada.CalificacionesPorEncuesta.Add(c2);
                encuestaModificada.CalificacionesPorEncuesta.Add(c3);
                encuestaModificada.CalificacionesPorEncuesta.Add(c4);


                Pregunta pregun1 = temp.CalificacionesPorEncuesta[0].getPregunta();
                Pregunta pregun2 = temp.CalificacionesPorEncuesta[1].getPregunta();
                Pregunta pregun3 = temp.CalificacionesPorEncuesta[2].getPregunta();
                Pregunta pregun4 = temp.CalificacionesPorEncuesta[3].getPregunta();
                encuestaModificada.CalificacionesPorEncuesta[0].setPregunta(pregun1);
                encuestaModificada.CalificacionesPorEncuesta[1].setPregunta(pregun2);
                encuestaModificada.CalificacionesPorEncuesta[2].setPregunta(pregun3);
                encuestaModificada.CalificacionesPorEncuesta[3].setPregunta(pregun4);

               
                
                listaEncuestas.Add(encuestaModificada);
                dgvEncuestas.DataSource = listaEncuestas;
                disenio_tabla();
              
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
            if (E == null) return;

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
            //dateEncuentra.Value = E.FechaProgramada;

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
                    //dateEncuentra.Enabled = false;
                    btnAgregar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnBusca.Enabled = false;
                    button1.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    flagGrupo = false;
                    btnEncuestaGrupo.Enabled = false;
                    btnRegistrarGrupo.Enabled = false;
                    limpiarCampos();
                    break;

                case estado.NUEVO:

                    cboActividad.Enabled = true;
                    cboColegio.Enabled = true;
                    cboGuia.Enabled = true;
                    grpP1.Enabled = false;
                    grpP2.Enabled = false;
                    grpP3.Enabled = false;
                    grpP4.Enabled = false;
                    //dateEncuentra.Enabled = true;
                    btnAgregar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnBusca.Enabled = true;
                    button1.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    flagGrupo = false;
                    limpiarCampos();
                    btnEncuestaGrupo.Enabled = false;
                    //Bloquear botones para evitar que se añadan encuestas a un grupo no existente
                    btnAgregar.Enabled = false;
                    btnModificar.Enabled = false;
                    button1.Enabled = false;
                    btnRegistrarGrupo.Enabled = true;
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
                    //dateEncuentra.Enabled = false;
                    btnAgregar.Enabled = true;
                    btnModificar.Enabled = true;
                    btnBusca.Enabled = true;
                    button1.Enabled = true;
                    btnGuardar.Enabled = true;
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
                    //dateEncuentra.Enabled = false;
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
                    //dateEncuentra.Enabled = false;
                    btnAgregar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnBusca.Enabled = false;
                    button1.Enabled = true;
                    btnGuardar.Enabled = true;
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
                    //dateEncuentra.Enabled = false;
                    btnAgregar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnBusca.Enabled = true;
                    button1.Enabled = true;
                    btnGuardar.Enabled = true;
                    btnNuevo.Enabled = false;
                  
                    btnEncuestaGrupo.Enabled = false;
                    break;
            }
        }

        public void limpiarCampos()
        {
            txtNumero.Text = "";
            

            //dateEncuentra.Value = DateTime.Now;

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

            //HACER REGISTRAR GRUPO !!! Actualización: Ya no, se registra encuesta con el botón de registrar encuestas

            EncuestaBL encuestaBL = new EncuestaBL();
            if (listaEncuestas == null) MessageBox.Show("No hay encuestas para registrar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int compteur = listaEncuestas.Count; //para que el mensaje de exito aparece solamenta una vez
                foreach (Encuesta E in listaEncuestas)
                {
                    E.Digitador = digitador;
                    int idEncuestaGenerada = encuestaBL.registrarEncuesta(E, digitador.IdGuia1);
                    if (idEncuestaGenerada != 0)
                    {
                        E.IdEncuesta1 = idEncuestaGenerada; //Cuando se crea exitosamente en la base de datos le da ese id al objeto
                        compteur--;
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
                if (compteur == 0) MessageBox.Show("Registrado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEncuestaGrupo_Click(object sender, EventArgs e)
        {
            VerEncuestasGrupo veg = new VerEncuestasGrupo(grupoSeleccionado);
            veg.Visible = true;
        }

        private void btnRegistrarGrupo_Click(object sender, EventArgs e)
        {
            GrupoEncuestas G = new GrupoEncuestas();
            G.Actividad = (Actividad)cboActividad.SelectedItem;
            G.GuiaEvaluado = (Guia)cboGuia.SelectedItem;
            G.Colegio = (Colegio)cboColegio.SelectedItem;
            //Se registra el nuevo grupo y se generará un nuevo id en la base de datos, 0 si no pudo
            int idGrupoEncuestas = grupoBL.registrarGrupo(G);
            if(idGrupoEncuestas == 0)
            {
                MessageBox.Show("Error al registrar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Registrado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            grupoSeleccionado = G;
            txtNumero.Text = idGrupoEncuestas.ToString();
            //cboActividad.SelectedValue = grupoSeleccionado.Actividad.IdActividad1;
            //cboGuia.SelectedValue = grupoSeleccionado.GuiaEvaluado.IdGuia1;
            //cboColegio.SelectedValue = grupoSeleccionado.Colegio.IdColegio1;
            flagGrupo = true;
            //Habilita botones para que se añadan encuestas al grupo existente
            btnAgregar.Enabled = true;
            btnModificar.Enabled = true;
            button1.Enabled = true;
            btnRegistrarGrupo.Enabled = false;
            btnGuardar.Enabled = true;
            grpP1.Enabled = true;
            grpP2.Enabled = true;
            grpP3.Enabled = true;
            grpP4.Enabled = true;
            //dateEncuentra.Value = bg.getGrupoSel().FechaProgramada;
        }
    }
}