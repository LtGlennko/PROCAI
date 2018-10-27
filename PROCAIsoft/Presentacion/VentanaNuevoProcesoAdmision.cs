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
using Modelo;
namespace Presentacion
{
    public partial class VentanaNuevoProcesoAdmision : Form
    {
        private string nombreTipoProceso = "";
        private string anio = "";
        private string ciclo = "I";

        private ProcesoAdmision PA;
        public BindingList<TipoProcesoAdmision> listaTipoProcesos= new BindingList<TipoProcesoAdmision>();
        private frmProcesoAdm parent;
        public VentanaNuevoProcesoAdmision(frmProcesoAdm parent_recived)
        {

            InitializeComponent();
            //conseguir los tipos de proceso
            this.parent = parent_recived;
            parent.Enabled=false;
            llenarComboBox(this.cmbx_tipoProceso, listaTipoProcesos);
        }
        public void llenarComboBox(ComboBox cmbx, BindingList<TipoProcesoAdmision> lista) {

            TipoProcesoAdmisionBL TPABL = new TipoProcesoAdmisionBL();
            if (lista != null) lista = new BindingList<TipoProcesoAdmision>();
            TPABL.listarTipoProcesos(lista);
            this.listaTipoProcesos = lista;
            BindingList<string> lista_str = new BindingList<string>();
            foreach (TipoProcesoAdmision TPA in lista) {
                lista_str.Add(TPA.NombreTipoProceso);
            }


            cmbx.DataSource = null;
            cmbx.DataSource = lista_str;
        }
        
        public void insertarDatagridView(BindingList<ProcesoAdmision> lista) {
            

        }
        private void VentanaNuevoProcesoAdmision_Load(object sender, EventArgs e)
        {
            
            
        }

        

        private void VentanaNuevoProcesoAdmision_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            MessageBox.Show("Cancelado por usuario!", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            parent.Enabled = true;
        }

        private void textBox_Vacantes_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txt_Vacantes_KeyUp(object sender, KeyEventArgs e)
        {
            int caracter = e.KeyValue;

            if (caracter > 57 || caracter < 48) {
                this.lbl_prueba.Text = "wrong, only numbers";
                this.txt_Vacantes.Text = "";
            } else {
                this.lbl_prueba.Text = "";
            }
        }
        private int buscar_IdTipoProceso() {
            int id=0;
            foreach (TipoProcesoAdmision TPA in listaTipoProcesos) {
                if (TPA.NombreTipoProceso.Equals(cmbx_tipoProceso.Text)) {
                    id = TPA.IdTipoProceso1;
                    break;
                }
            }
            return id;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            TipoProcesoAdmision TPA = new TipoProcesoAdmision();
            TPA.IdTipoProceso1 = buscar_IdTipoProceso();

            DateTime fecha = this.datetp_fecha.Value;

            PA = new ProcesoAdmision();
            PA.NombreProceso = txt_nombre.Text;
            
            PA.FechaRealizacion = datetp_fecha.Value;
            PA.CantVacantes = Convert.ToInt32( txt_Vacantes.Text);
            PA.TipoProceso = TPA;
            //PA.
            /*
             * Capa bussines logic
             */
            ProcesoAdmisionBL PABL = new ProcesoAdmisionBL();
            bool success = PABL.insertarProcesoAdmision(PA);
            lbl_prueba.Text = "";
            if(success)
                lbl_prueba.Text = "yeah";

            else
                lbl_prueba.Text = "nooooooo";
            this.parent.llenarDGV();
            parent.Enabled = true;
            this.Close();
        }

        private void cmbx_tipoProceso_SelectedValueChanged(object sender, EventArgs e)
        {
            this.nombreTipoProceso = cmbx_tipoProceso.Text;
            this.formar_nombreProceso();
        }

        private void datetp_fecha_ValueChanged(object sender, EventArgs e)
        {
            this.anio = "  -  " + datetp_fecha.Value.Year.ToString() + "-";
            int mes = datetp_fecha.Value.Month;
            if (mes<7 )
            {
                this.rbtn_1.Checked = true;
                this.rbtn_2.Checked = false;
                this.ciclo = 1.ToString();
            }
            else
            {
                this.rbtn_1.Checked = false;
                this.rbtn_2.Checked = true;
                this.ciclo = 2.ToString();
            }

            this.formar_nombreProceso();
        }

        private void datetp_fecha_MouseCaptureChanged(object sender, EventArgs e)
        {
            datetp_fecha_ValueChanged(sender,e);
        }
        public void formar_nombreProceso() {
            txt_nombre.Text = this.nombreTipoProceso + this.anio + this.ciclo;
        }

        private void datetp_fecha_VisibleChanged(object sender, EventArgs e)
        {
            datetp_fecha_MouseCaptureChanged(sender,e);
        }
    }
}
